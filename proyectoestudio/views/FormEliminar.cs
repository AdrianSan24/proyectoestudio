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

namespace proyectoestudio.images
{
    public partial class FormEliminar : Form
    {
        Conexiones con;//conexion
        bool user;//usuario que esta en la sesion
        public FormEliminar(bool usuario,Conexiones conexion)
        {
            InitializeComponent();
            con = conexion;
            user = usuario;
            if (conexion.comprobarConexion())
            {

            }
            else
            {
                MessageBox.Show("no esta conectado a la base de de datos por lo que cualquier cambio que haga no se vera reflejado");
            }
        }
        //se envia el codigo del textbox para eliminar ese ususario o empleado
        private void button2_Click(object sender, EventArgs e)
        {
            con.eliminar(user, textBox1.Text);
            
            this.Close();
        }
    }
}
