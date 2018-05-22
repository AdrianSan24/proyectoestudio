using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoestudio.clases
{
    public class Conexiones
    {

        MySqlConnection cn;
        MySqlCommand consulta;

        public Conexiones()
        {


        }

        public void cerrar()
        {
            cn.Close();
        }
            public bool probarConexion()
        {

            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "";
            String database = "prueba";

            //Cadena de conexion
            string cadenaConexion = String.Format("server={0};port={1};user id={2}; password={3}; database={4};SslMode = none;", servidor, puerto, usuario, password, database);
            try
            {
                cn = new MySqlConnection(cadenaConexion);
                cn.Open();//se abre la conexion
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (MySqlException ex){
                return false;
            }
        }

        public void conseguirhoras(List<string> horasInicio, List<string> horasFin, List<string> tiempos, List<string> codigos, string codempleado)
        {
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select horainicio,horafin,tiempoesperado,codigodemaquina from datos where codigoempleado=" + "'" + codempleado + "'", cn);

            MySqlDataReader lector2 = consulta2.ExecuteReader();
            while (lector2.Read())
            {

                string horainicio = lector2.GetValue(0).ToString();
                horasInicio.Add(horainicio);
                string horafin = lector2.GetValue(1).ToString();
                horasFin.Add(horafin);
                string tiempo = lector2.GetValue(2).ToString();
                tiempos.Add(tiempo);
                codigos.Add(lector2.GetString("codigodemaquina"));
            }
            lector2.Close();
        }
            catch (MySqlException E)
            {

            }
}
        public List<Operario> conseguirOperarios()
        {

            List<Operario> ops = new List<Operario>();
            consulta = new MySqlCommand("SELECT * FROM operarios ", cn);
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                Operario operario = new Operario();
                operario.Codigo = lector.GetString("codigoempleado");
                operario.Nombre = lector.GetString("Nombre");
                operario.Apellidos = lector.GetString("Apellidos");
                operario.rutafoto = lector.GetString("fotoperfil");
                operario.Usuario = lector.GetString("Usuario");
                operario.Contraseña = lector.GetString("contrasena");
                ops.Add(operario);

            }
            lector.Close();

            foreach (Operario op in ops)
            {
                op.horasInicio = new List<string>();
                op.horasFin = new List<string>();
                op.tiempoParada=new List<string>();
                op.codigoParada = new List<string>();
                conseguirhoras(op.horasInicio, op.horasFin, op.tiempoParada, op.codigoParada, op.Codigo);
            }
            return ops;
        }

        public List<Usuario> conseguirUsuarios()
        {

            List<Usuario> users = new List<Usuario>();
            consulta = new MySqlCommand("SELECT * FROM usuarios2 ", cn);
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                Usuario user = new Usuario();
                user.Codigo = lector.GetString("codigousuario");
                user.Nombre = lector.GetString("Nombre");
                user.Apellidos = lector.GetString("Apellidos");
                user.Rutafoto = lector.GetString("fotoperfil");
                user.User = lector.GetString("Usuario");
                user.Contraseña = lector.GetString("contrasena");
                user.Administrador = lector.GetBoolean("Administrador");
                users.Add(user);

            }
            lector.Close();
            
            return users;
        }
        public void Conseguirestandar(List<EstandarMaquina> estandares)
        {
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select * from maquina ", cn);

                MySqlDataReader lector2 = consulta2.ExecuteReader();
                while (lector2.Read())
                {
                    EstandarMaquina maquina = new EstandarMaquina();
                   maquina.Codigomaquina = lector2.GetString("codigomaquina");
                    maquina.Tiempoestandar = lector2.GetValue(2).ToString();
                    
                   maquina.Oscilacion = lector2.GetInt32("TiempodeOscilacion");
                    estandares.Add(maquina);
                }
                lector2.Close();
            }
            catch (MySqlException E)
            {

            }
        }
        public void codigos(List<string> codigos)
        {
            consulta = new MySqlCommand("SELECT codigodemaquina FROM datos ", cn);
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                if (!codigos.Contains(lector.GetString(0))) codigos.Add(lector.GetString(0));
            }
            lector.Close();
        }
        public bool editarUsuario(Usuario user)
        {
            try
            {
                string sentencia = String.Format("UPDATE `usuarios2` SET `Nombre` = '{0}', `Apellidos` = '{1}',`Usuario` = '{2}',`contrasena` = '{3}',`fotoperfil` = '{4}', WHERE `usuarios2`.`codigousuario` = {5};", user.Nombre, user.Apellidos, user.User,user.Contraseña, user.Rutafoto, user.Codigo);
                MySqlCommand consulta2 = new MySqlCommand(sentencia, cn);

                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public bool crearUsuario(Usuario user)
        {
            try
            {
                string sentencia2;
                if (user.Rutafoto == null)
                {
                    sentencia2 = String.Format(" INSERT INTO usuarios2 ( COD,Nombre, Apellidos, Usuario, contrasena, Administrador, codigousuario) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', {4}, '{5}');", user.Nombre, user.Apellidos, user.User, user.Contraseña, Convert.ToInt32(user.Administrador), user.Codigo);
                }
                else
                {
                    sentencia2 = String.Format(" INSERT INTO usuarios2 ( COD,Nombre, Apellidos, Usuario, contrasena, fotoperfil, Administrador, codigousuario) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}');", user.Nombre, user.Apellidos, user.User, user.Contraseña, user.Rutafoto, Convert.ToInt32(user.Administrador), user.Codigo);
                }
                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public bool crearOperario(Operario op)
        {
            try
            {
                string sentencia2;
                if (op.Foto == null)
                {
                    sentencia2 = String.Format(" INSERT INTO operarios ( COD,Nombre, Apellidos, Usuario, contrasena, codigoempleado) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', {4});", op.Nombre, op.Apellidos, op.Usuario, op.Contraseña, op.Codigo);
                }
                else
                {
                    sentencia2 = String.Format(" INSERT INTO operarios ( COD,Nombre, Apellidos, Usuario, contrasena, fotoperfil, codigoempleado) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', {4}, '{5}');", op.Nombre, op.Apellidos, op.Usuario, op.Contraseña, op.Foto, op.Codigo);
                }
                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public bool eliminar(bool usuario ,string codigo)
        {
            try
            {
                string sentencia2;
                if (usuario)
                {
                    sentencia2 = String.Format("DELETE FROM `operarios` WHERE `operarios`.`codigousuario`="+ "'" + codigo+ "'" );
                }
                else
                {
                    sentencia2 = String.Format("DELETE FROM `operarios` WHERE `operarios`.`codigoempleado`=" +"'"+ codigo+"'");
                }
                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
    }
}
