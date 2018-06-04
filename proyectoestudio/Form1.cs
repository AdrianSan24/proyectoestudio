using proyectoestudio.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using proyectoestudio.views;
using System.IO;

namespace proyectoestudio
{
    public partial class Form1 : Form
    {
        Usuario userActual;//usuario en sesion
        List<Operario> operarios;//lista de operarios
        List<Usuario> usuarios;//lista de usuarios
        List<string> codigos;//lista de codigos de la maquina
        List<EstandarMaquina> estandaresM;//lista de los estandares
        int intentos;//intentos de sesion
        FormLogin login;//formulario de dialogo
        FormPerfilUsuario Perfil;//formulario del perfil
       FormInfoOperario infoEmp;//formulario de info del empleado seleccionado
        Conexiones conexion=new Conexiones();//conexion
        bool basededatos = false;//indica si la base esta conectada
        public Form1()
        {
            InitializeComponent();
            intentos = 0;
            //aqui se cargarian los empleados en la lista de la base de datos

            if (conexion.probarConexion())
            {
                operarios = conexion.conseguirOperarios();
                usuarios = conexion.conseguirUsuarios();
                codigos = new List<string>();
                estandaresM = new List<EstandarMaquina>();
                conexion.Conseguirestandar(estandaresM);
                conexion.codigos(codigos);
                cbxDepartamento.DataSource = codigos;
                cbxDepartamento.SelectedItem = "";
                this.cbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.listEmpleados_SelectedIndexChanged);
                foreach (Operario op in operarios)
                {
                    //se ñaaden a la lista
                    listEmpleados.Items.Add(op.Nombre + "  " + op.Apellidos);
                }
                basededatos = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se enviaria la informacion del operario y se cogerian los datos de la base de datos

            try
            {
                if (operarios[listEmpleados.SelectedIndex] != null){
                    if (conexion.comprobarConexion())
                    {
                        infoEmp = new FormInfoOperario(operarios[listEmpleados.SelectedIndex]);
                        infoEmp.ShowDialog();
                        
                        }
                    else
                    {
                        MessageBox.Show("la conexion a la base de datos se ha cerrado ");
                       
                    }
                }
            }catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Seleccione operario", "debe seleccionar un operario para ver informacion");
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int intentos = 0;
            bool estadentro=false;

            if (basededatos)
            {
                login = new FormLogin();
                //comprobacion del login
                while (intentos < 3)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        //se comprobara los datos de la base de datos de momento aun no hecho
                        //si entra

                        
                        if (login.chk.Checked)
                        {
                            foreach (Operario op in operarios)
                            {
                                if (login.txtUsuario.Text.Equals(op.Usuario) && login.txtPass.Text.Equals(op.Contraseña))
                                {


                                    FormDatos datos = new FormDatos(conexion,op);
                                    this.Enabled = false;
                                    this.Visible = false;
                                    datos.ShowDialog();
                                    intentos = 2;
                                    login.Close();
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            foreach (Usuario user in usuarios)
                            {
                                if (login.txtUsuario.Text.Equals(user.User) && login.txtPass.Text.Equals(user.Contraseña))
                                {

                                    userActual = user;
                                    login.Close();
                                    estadentro = true;
                                    intentos = 2;
                                }

                            }
                        }

                        // si ha dado todos los intentos y no ha entrado 
                        if (intentos == 2 && !estadentro)
                        {
                            login.Close();
                            Close();
                        }


                    }
                    else
                    {
                        //si cierra el login
                        intentos = 2;
                    }


                    intentos++;
                }
                if (!estadentro)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("error en base de datos", "error");
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //aqui se carga el formulario del perfil
        private void administrarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conexion.comprobarConexion())
            {
                Perfil = new FormPerfilUsuario(conexion, userActual);
                Perfil.ShowDialog();
                operarios = conexion.conseguirOperarios();
                listEmpleados.Items.Clear();
                foreach (Operario op in operarios)
                {
                    //se actualiza  la lista
                    listEmpleados.Items.Add(op.Nombre + "  " + op.Apellidos);
                }
            }
            else
            {
                MessageBox.Show("la conexion a la base de datos se ha cerrado ");
               
            }
            }

        

      
        //se cierra la conexion sucede cuando se cierra este formulario
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.cerrar();
        }
        //carga los datos del empleado seleccionado en el panel siempre que el codigo sea el mismo que el de los tiempos
        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conexion.comprobarConexion())
            {
                try
                {
                    if (operarios[listEmpleados.SelectedIndex] != null)
                    {
                        dGViewDatos.Rows.Clear();
                        Operario operarioSeleccionado = operarios[listEmpleados.SelectedIndex];
                        if (operarioSeleccionado.foto == null)
                        {

                            operarios[listEmpleados.SelectedIndex].foto = new Bitmap("..\\..\\images\\users.png");
                            pictureBox1.Image = operarioSeleccionado.foto;
                        }
                        pictureBox1.Image = operarioSeleccionado.foto;
                        txtNombre.Text = operarioSeleccionado.Nombre;
                        txtApellidos.Text = operarioSeleccionado.Apellidos;
                        txtCodigo.Text = operarioSeleccionado.Codigo;

                        int cont = 0;
                        foreach (string codigo in operarioSeleccionado.codigoParada)
                        {
                            if (codigo.Equals(cbxDepartamento.SelectedItem))
                            {
                                dGViewDatos.Rows.Add(operarioSeleccionado.horasInicio[cont], operarioSeleccionado.horasFin[cont], operarioSeleccionado.tiempoParada[cont], codigo, operarioSeleccionado.motivos[cont], operarioSeleccionado.descripcion[cont]);
                            }
                            cont++;
                        }
                    }
                }
              
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Seleccione Operario");
                }
            }
            else
            {
                MessageBox.Show("la conexion a la base de datos se ha cerrado ");
                
            }

            }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //es el metodo que cambia los estandares y comprobaciones
        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(EstandarMaquina maq in estandaresM)
            {
                if (cbxDepartamento.SelectedItem.Equals(maq.Codigomaquina))
                {
                    txtTiempoestandar.Text = (maq.Tiempoestandar);
                    lblOscilacion.Text = "+- " + maq.Oscilacion+" seg";
                }
            }
        }

        private void extraerAtascosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conexion.comprobarConexion())
            {

            }
        }

        private void btnTiemposMaquina_Click(object sender, EventArgs e)
        {
            FormMaquinaDatos datosmaquina = new FormMaquinaDatos(conexion);
            if (conexion.comprobarConexion())
            {
                datosmaquina.ShowDialog();
            }
            if (conexion.comprobarConexion())
            {
                operarios = conexion.conseguirOperarios();
            }
            listEmpleados.Items.Clear();
            foreach (Operario op in operarios)
            {
                //se actualiza  la lista
                listEmpleados.Items.Add(op.Nombre + "  " + op.Apellidos);
            }
            Refresh();
        }
    }
}
