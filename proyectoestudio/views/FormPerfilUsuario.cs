using proyectoestudio.clases;
using proyectoestudio.images;
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
    public partial class FormPerfilUsuario : Form
    {
         Usuario user;
        Conexiones conexion;
        FormNuevoUsuario Nuevo;
        FormNuevoempleado formOp;
        FormEliminar a;
        bool operario;
        public FormPerfilUsuario(Conexiones conexion ,Usuario user)
        {
            InitializeComponent();
            if (user.Administrador)
            {
                btnAñadirUsuario.Visible = true;
                btnAñadirUsuario.Enabled = true;
                btnEliminarU.Visible = true;
            }
            this.user = user;
            txtNombreU.Text = user.Nombre;
            txtApellidosU.Text = user.Apellidos;
            txtCodigoU.Text = user.Codigo;
            txtUsuario.Text = user.User;
            txtcontrasena.Text = user.Contraseña;
            this.conexion = conexion;
            if (user.Rutafoto == "")
            {
                
            }
            else
            {
                pictureBoxU.Image = new Bitmap(user.Rutafoto);
            }
        }

        private void pictureBoxU_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                user.Rutafoto = openFileDialog1.FileName;
                user.ImagenPefil = new Bitmap(user.Rutafoto);
                pictureBoxU.Image = user.ImagenPefil;
            }
           
        }

        private void btnEditarU_Click(object sender, EventArgs e)
        {
            txtNombreU.Text = "";
            txtApellidosU.Text = "";
            txtUsuario.Text = "";
            labelPass.Visible = true;
            labelPass2.Visible = true;
            txtcontrasena.Visible = true;
            txtcontrasena2.Visible = true;
            btnGuardarperfil.Visible = true;
            txtNombreU.Enabled = true;
            txtApellidosU.Enabled = true;
            txtUsuario.Enabled = true;
            txtcontrasena.UseSystemPasswordChar = false;
            txtcontrasena2.UseSystemPasswordChar = false;
        }

        private void btnGuardarperfil_Click(object sender, EventArgs e)
        {
           
            labelPass.Visible = false;
            labelPass2.Visible = false;
            txtcontrasena.Visible = false;
            txtcontrasena2.Visible = false;
            btnGuardarperfil.Visible = false;
            user.Nombre = txtNombreU.Text;
            user.Apellidos = txtApellidosU.Text;
            user.User = txtUsuario.Text;
            txtNombreU.Enabled = false;
            txtApellidosU.Enabled = false;
            txtUsuario.Enabled = false;
            txtNombreU.Text = user.Nombre;
            txtApellidosU.Text = user.Apellidos;
            txtCodigoU.Text = user.Codigo;
            txtUsuario.Text = user.User;
            if (txtcontrasena.Text.Equals(txtcontrasena2.Text))
            {
               user.Contraseña= txtcontrasena.Text;
               if( !txtApellidosU.Text.Equals("") && !txtNombreU.Text.Equals(""))
                {
                    if(conexion.editarUsuario(user))
                    {
                        MessageBox.Show("Usuario:" + user.Nombre + " " + user.Apellidos, "usuario editado con exito");
                    }

                }
                else
                {
                    MessageBox.Show("campos vacios", "los campos estan vacios");
                }
                
            }else {
                MessageBox.Show("contraseñas diferentes", "las contraseñas no son iguales");
            }

        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            Nuevo = new FormNuevoUsuario(conexion);
            Nuevo.ShowDialog();
        }

        private void btnAñadirEmpleado_Click(object sender, EventArgs e)
        {
            formOp = new FormNuevoempleado(conexion);
            formOp.ShowDialog();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {

            a = new FormEliminar(true, conexion);
            a.ShowDialog();
        }

        private void btnEliminarOP_Click(object sender, EventArgs e)
        {
            a = new FormEliminar(false, conexion);
            a.ShowDialog();
        }
    }
}
