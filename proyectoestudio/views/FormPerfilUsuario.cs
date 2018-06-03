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
            if (conexion.comprobarConexion())
            {

            }
            else
            {
                MessageBox.Show("no esta conectado a la base de de datos por lo que cualquier cambio que haga no se vera reflejado");
            }
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
                try
                {
                    pictureBoxU.Image = new Bitmap(user.Rutafoto);
                }catch(Exception e)
                {
                    MessageBox.Show("No se pudo cargar la imagen");
                }
            }
            
        }
        //carga una imagen
        private void pictureBoxU_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                user.Rutafoto = openFileDialog1.FileName;
                user.ImagenPefil = new Bitmap(user.Rutafoto);
                pictureBoxU.Image = user.ImagenPefil;
                
            }
           
        }
        //habilita la edicion de editar el perfil
        private void btnEditarU_Click(object sender, EventArgs e)
        {
          
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
        //se ejecuta cuando se pincha en el boton guardar despues de pinchar en editar para guardar los cambios
        private void btnGuardarperfil_Click(object sender, EventArgs e)
        {
           
            labelPass.Visible = false;
            labelPass2.Visible = false;
            txtcontrasena.Visible = false;
            txtcontrasena2.Visible = false;
            btnGuardarperfil.Visible = false;
           if(txtNombreU.Text != "" && txtApellidosU.Text != "" && txtUsuario.Text != ""){
                user.Nombre = txtNombreU.Text;
                user.Apellidos = txtApellidosU.Text;
                user.User = txtUsuario.Text;
            }
            txtNombreU.Text = user.Nombre;
            txtApellidosU.Text = user.Apellidos;
            txtCodigoU.Text = user.Codigo;
            txtUsuario.Text = user.User;
            txtNombreU.Enabled = false;
            txtApellidosU.Enabled = false;
            txtUsuario.Enabled = false;
           
            if (txtcontrasena.Text.Equals(txtcontrasena2.Text))
            {
               user.Contraseña= txtcontrasena.Text;
               if( !txtApellidosU.Text.Equals("") && !txtNombreU.Text.Equals(""))
                {
                    if(conexion.editarUsuario(user))
                    {
                        MessageBox.Show("Usuario: " + user.Nombre + " " + user.Apellidos, " usuario editado con exito");
                      
                    }
                    else
                    {
                        MessageBox.Show("el usuario no se ha editado ,error en la consulta de bases de datos");
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
        //solo si se es admin y abre un formulario de nuevo usuario
        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            
            if (!conexion.comprobarConexion())
            {
                MessageBox.Show("hay un problema en la base de datos");
            }
            else
            {

                if (conexion.comprobarConexion())
                {
                    Nuevo = new FormNuevoUsuario(conexion);
                    Nuevo.ShowDialog();
                }
                if (!conexion.comprobarConexion())
                {
                    MessageBox.Show("hay un problema en la base de datos los cambios puede que no se  efectuen");
                }
                
            }
        }
        //abre un formulario de empleado para añadir un nuevo empleado
        private void btnAñadirEmpleado_Click(object sender, EventArgs e)
        {
            formOp = new FormNuevoempleado(conexion);
            formOp.ShowDialog();
            if (!conexion.comprobarConexion())
            {
                MessageBox.Show("hay un problema en la base de datos los cambios puede que no se  efectuen");
            }
        }
        //abre un formulario para eliminar un usuario
        private void btnEliminarU_Click(object sender, EventArgs e)
        {

            a = new FormEliminar(true, conexion);
            a.ShowDialog();
            if (!conexion.comprobarConexion())
            {
                MessageBox.Show("hay un problema en la base de datos ,los cambios puede que no se  efectuen");
            }
        }
        //abre un formulario para eliminar un operario
        private void btnEliminarOP_Click(object sender, EventArgs e)
        {
            a = new FormEliminar(false, conexion);
            a.ShowDialog();
            if (!conexion.comprobarConexion())
            {
                MessageBox.Show("hay un problema en la base de datos los cambios puede que no se  efectuen");
            }
        }
    }
}
