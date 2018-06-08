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
    public partial class FormNuevoempleado : Form
    {
        Conexiones conexion;
        Operario nuevoOperario;//operario que se añadira
        public FormNuevoempleado(Conexiones conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            nuevoOperario = new Operario();
            if (conexion.comprobarConexion())
            {

            }
            else
            {
                MessageBox.Show("no esta conectado a la base de de datos por lo que cualquier cambio que haga no se vera reflejado");
            }
        }
        // se añade se comprueba que no estan vacios los campos esenciales y se añade el operario si todoes correcto
        private void btnAñadirE_Click(object sender, EventArgs e)
        {
            bool nombreOK = true;
            bool apellidosOK = true;
            if (!txtNombreE.Text.Equals("") && !txtApellidosE.Text.Equals("") && !txtCodigoE.Text.Equals("") && !txtUsuario.Text.Equals(""))
            {
                foreach (char letra in txtNombreE.Text)
                {
                    if (!char.IsLetter(letra))
                    {
                        nombreOK = false;
                    }
                }
                foreach (char letra in txtApellidosE.Text)
                {
                    if (!char.IsLetter(letra))
                    {
                        apellidosOK = false;
                    }
                }
                if (txtContraseña.Text.Equals(txtContraseña2.Text))
                {
                    if (nombreOK && apellidosOK)
                    {
                        nuevoOperario.Nombre = txtNombreE.Text;
                        nuevoOperario.Apellidos = txtApellidosE.Text;
                        nuevoOperario.Codigo = txtCodigoE.Text;
                        nuevoOperario.Contraseña = txtContraseña2.Text;
                        nuevoOperario.Usuario = txtUsuario.Text;

                        if (conexion.crearOperario(nuevoOperario))
                        {
                            MessageBox.Show("Operario  creado:" + nuevoOperario.Nombre + " " + nuevoOperario.Apellidos, "Usuario creado con exito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show( " Error en la creacion del Operario en la base de datos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        nuevoOperario.Nombre = "";
                        nuevoOperario.Apellidos = "";
                    }
                }
                else
                {
                    MessageBox.Show("error en nombre o apellido", "No pueden contener simbolos o numeros");
                    txtContraseña.Text = "";
                    txtContraseña2.Text = "";
                }

            }
            else
            {
                MessageBox.Show( "alguno de los  campos esta vacio vacio ", "error ");
            }
        }
        //abre un cuadro para cargar una imagen de perfil se lanza cuando se pincha encima de la imagen
        private void btnimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try { 
                nuevoOperario.rutafoto = openFileDialog1.FileName;
                nuevoOperario.Foto = new Bitmap(nuevoOperario.rutafoto);
                pictureBoxE.Image = nuevoOperario.Foto;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show( "Se debe seleccionar una imagen");
                }
            }
        }

        private void FormNuevoempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
