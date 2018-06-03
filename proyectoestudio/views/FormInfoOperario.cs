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
    public partial class FormInfoOperario : Form
    { 
        public FormInfoOperario(Operario op)
        {
            InitializeComponent();
           //se cargan todos los datos de ese usuario
                if (op.foto == null)
                {

                    op.foto = new Bitmap("..\\..\\images\\users.png");
                    pictureBox1.Image = op.foto;
                }
                pictureBox1.Image = op.foto;
            txtApellidos.Text = op.Apellidos;
            txtNombre.Text = op.Nombre;
            txtCodigo.Text = op.Codigo;
            for (int i = 0; i < op.codigoParada.Count; i++)
            {
                dGViewDatosempleado.Rows.Add(op.horasInicio[i],op.horasFin[i], op.tiempoParada[i], op.codigoParada[i], op.motivos[i], op.descripcion[i]);
            }
        }

        private void FormInfoOperario_Load(object sender, EventArgs e)
        {

        }

        private void dGViewDatosempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
