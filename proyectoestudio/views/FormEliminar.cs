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
        Conexiones con;
        bool user;
        public FormEliminar(bool usuario,Conexiones conexion)
        {
            InitializeComponent();
            con = conexion;
            user = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.eliminar(user, textBox1.Text))
            {
                MessageBox.Show("Personal eliminnado", "el personal ha sido eliminado con exito");
            }
            else
            {
                MessageBox.Show("Error", "ha habido un fallo en la eliminacion");
            }
            this.Close();
        }
    }
}
