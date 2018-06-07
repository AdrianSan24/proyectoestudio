using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoestudio.clases
{
    public class Conexiones
    {
        //clase con todo para la base de datos
        MySqlConnection cn;
        MySqlCommand consulta;

        public Conexiones()
        {


        }
        //cierra la conexion
        public void cerrar()
        {
            cn.Close();
        }
        //abre la conexion
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
        //se consiguen los tiempos hechos y los añade al operario
        public void conseguirhoras(List<string> horasInicio, List<string> horasFin, List<string> tiempos, List<string> codigos, List<string> motivos, List<string> descripciones, string codempleado)
        {
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select horainicio,horafin,tiempoesperado,codigodemaquina,Motivo,descripcion from datos where codigoempleado=" + "'" + codempleado + "'", cn);

            MySqlDataReader lector2 = consulta2.ExecuteReader();//se ejecuta la consulta
            while (lector2.Read())
            {
//se lee la consulta
                string horainicio = lector2.GetString("horainicio");
                horasInicio.Add(horainicio);
                string horafin = lector2.GetString("horafin");
                horasFin.Add(horafin);
                string tiempo = lector2.GetString("tiempoesperado");
                tiempos.Add(tiempo);
                codigos.Add(lector2.GetString("codigodemaquina"));
                    motivos.Add(lector2.GetString("Motivo"));
                    if (lector2.GetString("descripcion") == null || lector2.GetString("descripcion") == "NULL")
                    {
                        descripciones.Add("");
                    }
                    else
                    {
                        descripciones.Add(lector2.GetString("descripcion"));
                    }
                    
            }
            lector2.Close();
        }
            catch (MySqlException E)
            {
                MessageBox.Show("error en la base de datos al cargar los horarios");
            }
}
        //consigue los operarios de la base de datos
        public List<Operario> conseguirOperarios()
        {

            List<Operario> ops = new List<Operario>();
            try
            {
                
                    consulta = new MySqlCommand("SELECT * FROM operarios ", cn);
                    MySqlDataReader lector = consulta.ExecuteReader();

                    while (lector.Read())
                    {
                        //se rellena cada operario
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
                        op.tiempoParada = new List<string>();
                        op.codigoParada = new List<string>();
                        op.descripcion = new List<string>();
                        op.motivos = new List<string>();
                        conseguirhoras(op.horasInicio, op.horasFin, op.tiempoParada, op.codigoParada, op.motivos, op.descripcion, op.Codigo);
                    }
                
            }catch(MySqlException ex)
            {
                MessageBox.Show("error en la base de datos al cargar operarios");
            }
            return ops;
        }
        //consigue todos los ususarios de la BD
        public List<Usuario> conseguirUsuarios()
        {

            List<Usuario> users = new List<Usuario>();
            try
            {
                consulta = new MySqlCommand("SELECT * FROM usuarios2 ", cn);
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                //se rellena cada usuario
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error en la base de datos al cargar usuarios");
            }
            return users;
        }
        //consigue los estandars(tiempo estandar y oscilacion de error) de la smaquinas o departamentos
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
                MessageBox.Show("error en la base de datos al cargar estandares");
            }
        }
        //consigue los codigos
        public void codigos(List<string> codigos)
        {
            try
            {
                consulta = new MySqlCommand("SELECT codigodemaquina FROM datos ", cn);
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (!codigos.Contains(lector.GetString(0))) codigos.Add(lector.GetString(0));
                }
                lector.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show("error en la base de datos al cargar codigos"); 
            }
        }
        //actualiza el usuario  en la BD
        public bool editarUsuario(Usuario user)
        {
            try
            {
                
                string sentencia = String.Format("UPDATE `usuarios2` SET `Nombre` = '{0}', `Apellidos` = '{1}',`Usuario` = '{2}',`contrasena` = '{3}',`fotoperfil` = '{4}' WHERE `usuarios2`.`codigousuario` = '{5}'", user.Nombre, user.Apellidos, user.User,user.Contraseña, user.Rutafoto, user.Codigo);
                MySqlCommand consulta2 = new MySqlCommand(sentencia, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        //crea un usuario  en la BD
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
        //crea un operario en la BD
        public bool crearOperario(Operario op)
        {
            try
            {
                string sentencia2;
                if (op.Foto == null)
                {
                    
                    sentencia2 = String.Format(" INSERT INTO operarios ( codigo,Nombre, Apellidos, Usuario, contrasena, codigoempleado,fotoperfil) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', '{4}','')", op.Nombre, op.Apellidos, op.Usuario, op.Contraseña, op.Codigo);
                }
                else
                {
                    sentencia2 = String.Format(" INSERT INTO operarios ( codigo,Nombre, Apellidos, Usuario, contrasena, fotoperfil, codigoempleado) VALUES ( NULL,'{0}', '{1}', '{2}', '{3}', {4}, '{5}')", op.Nombre, op.Apellidos, op.Usuario, op.Contraseña, op.Foto, op.Codigo);
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
        public bool buscarempleado(string codigo)
        {
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select codigoempleado from operarios ", cn);

                MySqlDataReader lector2 = consulta2.ExecuteReader();
                while (lector2.Read())
                {

                    if (codigo == lector2.GetString("codigoempleado")){
                        lector2.Close();
                        return true;
                    }

                }
                lector2.Close();
                return false;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public bool buscarusuario(string codigo)
        {
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select codigousuario from usuarios2 ", cn);

                MySqlDataReader lector2 = consulta2.ExecuteReader();
                while (lector2.Read())
                {

                    if (codigo == lector2.GetString("codigousuario"))
                    {
                        lector2.Close();
                        return true;
                    }

                }
                lector2.Close();
                return false;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        //elimina el empleado o usuario dependiendo del boleano
        public bool eliminar(bool usuario ,string codigo)
        {
            MySqlCommand consulta2= new MySqlCommand();
            try
            {
                
                string sentencia2;
                if (usuario)
                {
                    if (buscarusuario(codigo))
                    {
                        sentencia2 = String.Format("DELETE FROM `usuarios2` WHERE `usuarios2`.`codigousuario`=" + "'" + codigo + "'");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        return false;
                    }
                }
                else
                {
                    if (buscarempleado(codigo))
                    {
                        sentencia2 = String.Format("DELETE FROM `operarios` WHERE `operarios`.`codigoempleado`=" + "'" + codigo + "'");
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado");
                        return false;
                    }
                   
                }
               
               if( MessageBox.Show("Esta seguro que desea eliminar a  " + codigo, "Eliminar",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK){
                    MySqlCommand consulta3 = new MySqlCommand(sentencia2, cn);
                    consulta3.ExecuteNonQuery();
                    MessageBox.Show("Personal eliminnado", "el personal ha sido eliminado con exito");
                }
              
                return true;
            }
            catch (MySqlException E)
            {
                MessageBox.Show( "ha habido un fallo en la eliminacion", "Error");
                return false;
            }
        }
        //añade los datos a la tabla con los datos de la parada,motivo y descripcion
        public bool Añadirdatos(Operario op,string tiempoParada,string InicioParada,string Finparada,string codigoMaquina,string motivo,string descripcion)
        {
            try
            {
                string sentencia2;
                if (descripcion=="")
                {

                    sentencia2 = String.Format(" INSERT INTO `datos` (`codigo`,`horainicio`, `horafin`, `tiempoesperado`, `codigodemaquina`, `codigoempleado`, `Motivo`,`descripcion`, `created_at`) VALUES (NULL,'{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', CURRENT_TIMESTAMP)", InicioParada, Finparada, tiempoParada, codigoMaquina, op.Codigo, motivo, "");
                }
                else
                {
                    sentencia2 = String.Format(" INSERT INTO `datos` (`codigo`,`horainicio`, `horafin`, `tiempoesperado`, `codigodemaquina`, `codigoempleado`, `Motivo`,`descripcion`, `created_at`) VALUES (NULL,'{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', CURRENT_TIMESTAMP)", InicioParada, Finparada, tiempoParada, codigoMaquina, op.Codigo, motivo,descripcion);
                }
                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }//añade el tiempo de los atascos y el codigo de la maquina
        public bool AñadirAtascos(Operario op, string tiempoAtasco, string InicioAtasco, string FinAtasco, string codigoMaquina)
        {
            try
            {
                string sentencia2;
                

                    sentencia2 = String.Format("INSERT INTO `atascos` (`Cod`, `horainicio`, `horafin`, `tiempo`,`created_at`,`CodigoMaquina`) VALUES(NULL, '{0}', '{1}', '{2}', CURRENT_TIMESTAMP,'{3}') ", InicioAtasco, FinAtasco, tiempoAtasco, codigoMaquina, op.Codigo,codigoMaquina);
                
                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        //añade el tiempo total que se ha estado trabajando en los codigos
        public bool AñadirTiempoTotal(string Iniciototal,string  FinTotal,string  tiempoTotal,string codigodetrabajo,string codigoEmpleado, int bandejasmalas)
        {
            try
            {
                string sentencia2;


                sentencia2 = String.Format("INSERT INTO `trabajomaquina` (`horainicio`, `horafinal`, `codigomaquina`, `tiempotranscurrido`, `Cod`, `Bandejasmalas`, `created_at`, `codigoempleado`) VALUES ('{0}', '{1}', '{2}', '{3}', NULL, {4}, CURRENT_TIMESTAMP, '{5}') ", Iniciototal, FinTotal,codigodetrabajo , tiempoTotal,bandejasmalas, codigoEmpleado);

                MySqlCommand consulta2 = new MySqlCommand(sentencia2, cn);
                consulta2.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public bool  cogercodigos(List<string> codes)
        {
            
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select codigomaquina from maquina ", cn);

                MySqlDataReader lector2 = consulta2.ExecuteReader();
                while (lector2.Read())
                {

                    codes.Add(lector2.GetString("codigomaquina"));
                   
                }
                lector2.Close();
                return true;
            }
            catch (MySqlException E)
            {
                return false;
            }
        }
        public List<TrabajoTotal> cogerTiemposMaquina()
        {
            List<TrabajoTotal> totalesMaquina = new List<TrabajoTotal>();
            try
            {
                MySqlCommand consulta2 = new MySqlCommand("Select * from trabajomaquina ", cn);

                MySqlDataReader lector2 = consulta2.ExecuteReader();
                while (lector2.Read())
                {
                    TrabajoTotal trabajo = new TrabajoTotal();
                    trabajo.Bandejas=lector2.GetInt32("Bandejasmalas");
                    trabajo.CodigoEmpleado = lector2.GetString("codigoempleado");
                    trabajo.Codigomaquina = lector2.GetString("codigomaquina");
                    trabajo.Horafin = lector2.GetString("horafinal");
                    trabajo.Horainicio = lector2.GetString("horainicio");
                    trabajo.Tiempo = lector2.GetString("tiempotranscurrido");
                    DateTime dia = lector2.GetDateTime("created_at");
                    trabajo.Fecha = dia.Date.ToShortDateString();
                    totalesMaquina.Add(trabajo);
                }
                lector2.Close();
                return totalesMaquina;
            }
            catch (MySqlException E)
            {
                return null;
            }
        }
        public bool comprobarConexion()
        {
            try
            {
                if (cn.Ping())
                {
                    return true;
                }
                //if (cn.State == System.Data.ConnectionState.Open)
                //{
                //    return true;
                //}

                else
                {
                    return false;
                }
            }catch(MySqlException e)
            {
                return false;
            }
        }
    }
}
