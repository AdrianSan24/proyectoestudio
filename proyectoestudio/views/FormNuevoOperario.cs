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
        Operario nuevoOperario;
        public FormNuevoempleado(Conexiones conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            nuevoOperario = new Operario();
        }

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
                            MessageBox.Show("Error", " Error en la creacion del Usuario");
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
                MessageBox.Show("error ", "algun campo vacio ");
            }
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nuevoOperario.rutafoto = openFileDialog1.FileName;
                nuevoOperario.Foto = new Bitmap(nuevoOperario.rutafoto);
                pictureBoxE.Image = nuevoOperario.Foto;

            }
        }

        private void FormNuevoempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
