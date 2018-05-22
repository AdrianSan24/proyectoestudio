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
            nuevoUsuario = new Usuario();
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
            comboBox1.SelectedIndex = 1;
            nuevoUsuario.Administrador = false;
            this.conexion = conexion;
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nuevoUsuario.Rutafoto = openFileDialog1.FileName;
                nuevoUsuario.ImagenPefil = new Bitmap(nuevoUsuario.Rutafoto);
                pictureBoxU.Image = nuevoUsuario.ImagenPefil;
                
            }
        }

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

        private void btnAñadirU_Click(object sender, EventArgs e)
        {
            bool nombreOK=true;
            bool apellidosOK=true;
            if(!txtNombreU.Text.Equals("")&& !txtApellidosU.Text.Equals("")&& !txtCodigoU.Text.Equals("")&&!txtUsuario.Text.Equals(""))
            {
                foreach(char letra in txtNombreU.Text)
                {
                    if (!char.IsLetter(letra))
                    {
                        nombreOK = false;
                    }
                }
                foreach (char letra in txtApellidosU.Text)
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
                            MessageBox.Show("Error" ," Error en la creacion del Usuario");
                        }
                    }
                    else{
                        nuevoUsuario.Nombre = "";
                        nuevoUsuario.Apellidos = "";
                    }
                }
                else
                {
                    MessageBox.Show("error en nombre o apellido", "No pueden contener simbolos o numeros");
                    txtContraseña.Text = "";
                    txtContraseña2.Text="";
                }

            }
            else
            {
                MessageBox.Show("error ", "algun campo vacio ");
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
