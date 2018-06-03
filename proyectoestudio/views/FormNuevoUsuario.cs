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

namespace proyectoestudio
{
    public partial class FormNuevoUsuario : Form
    {
        Conexiones conexion;
        Usuario nuevoUsuario;
        public FormNuevoUsuario(Conexiones conexion)
        {
            InitializeComponent();
            if (conexion.comprobarConexion())
            {

            }
            else
            {
                MessageBox.Show("no esta conectado a la base de de datos por lo que cualquier cambio que haga no se vera reflejado");
            }
            nuevoUsuario = new Usuario();
            //se cargan las opciones de usuario
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
            comboBox1.SelectedIndex = 1;
            nuevoUsuario.Administrador = false;
            this.conexion = conexion;
        }
        //se añade imagen
        private void btnimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nuevoUsuario.Rutafoto = openFileDialog1.FileName;
                nuevoUsuario.ImagenPefil = new Bitmap(nuevoUsuario.Rutafoto);
                pictureBoxU.Image = nuevoUsuario.ImagenPefil;
                
            }
        }
        // cada vez que cambia de eleccion se guarda la eleccion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                nuevoUsuario.Administrador = true;
            }
            else
            {
                nuevoUsuario.Administrador = false;
            }
        }
        //comprueba y añade el usuario si los campos estan rellenos
        private void btnAñadirU_Click(object sender, EventArgs e)
        {
            
            if(!txtNombreU.Text.Equals("")&& !txtApellidosU.Text.Equals("")&& !txtCodigoU.Text.Equals("")&&!txtUsuario.Text.Equals(""))
            {
               
                if (txtContraseña.Text.Equals(txtContraseña2.Text) && txtContraseña.Text!="")
                {
                    
                        nuevoUsuario.Nombre = txtNombreU.Text;
                        nuevoUsuario.Apellidos = txtApellidosU.Text;
                        nuevoUsuario.Codigo = txtCodigoU.Text;
                        nuevoUsuario.Contraseña = txtContraseña2.Text;
                        nuevoUsuario.User = txtUsuario.Text;
                       
                        if (conexion.crearUsuario(nuevoUsuario)) {
                            MessageBox.Show("Usuario  creado:"+nuevoUsuario.Nombre+" "+nuevoUsuario.Apellidos , "Usuario creado con exito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error" ," Error en la creacion del Usuario en la base de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    
                }
                else
                {
                    MessageBox.Show( "Las contraseñas no coinciden", " contraseñas ");
                    txtContraseña.Text = "";
                    txtContraseña2.Text="";
                }

            }
            else
            {
                MessageBox.Show("deben estar rellenos los campos de Nombre,Apellidos,Usuario y Codigo ", "algun campo vacio ");
            }
        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {

        }

       
    }
}
