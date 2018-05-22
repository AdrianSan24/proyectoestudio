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
                dGViewDatosempleado.Rows.Add(op.horasInicio[i], op.codigoParada[i], op.horasFin[i], op.tiempoParada[i]);
            }
        }
    }
}
