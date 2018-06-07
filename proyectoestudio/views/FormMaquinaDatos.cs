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

namespace proyectoestudio.views
{
    public partial class FormMaquinaDatos : Form
    {
        List<TrabajoTotal> trabajosMaquina = new List<TrabajoTotal>();
        Conexiones con;
        public FormMaquinaDatos(Conexiones conexion)
        {
            InitializeComponent();
            con = conexion;
            if (con.comprobarConexion())
            {
                if (con.cogerTiemposMaquina() != null)
                {
                    trabajosMaquina = con.cogerTiemposMaquina();
                    foreach (TrabajoTotal total in trabajosMaquina)
                    {
                        dataGridView1.Rows.Add(total.Horainicio, total.Horafin, total.Tiempo, total.Codigomaquina, total.Bandejas, total.CodigoEmpleado, total.Fecha);
                    }
                }
                else
                {
                    MessageBox.Show("error al intentar conectar la base de datos ");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("error al intentar conectar la base de datos ");
                this.Close();

            }
        }
    }
}
