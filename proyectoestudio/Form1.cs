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
    public partial class Form1 : Form
    {
        Usuario user;
        List<Operario> operarios = new List<Operario>();
        Operario EjemploOp = new Operario();
        Operario EjemploOp2 = new Operario();
        int intentos;
        FormLogin login;
        FormPerfilUsuario Perfil;
        FormInfoEmpleado infoEmp;
        public Form1()
        {
            InitializeComponent();
            intentos = 0;
            //aqui se cargarian los empleados en la lista de la base de datos
            EjemploOp.Nombre = "Paco";
            EjemploOp.Apellidos = "Jimenez";
            EjemploOp.Codigo = "ES09";
            EjemploOp2.Nombre = "Paco2";
            EjemploOp2.Apellidos = "Jimenez2";
            EjemploOp2.Codigo = "ES10";
            operarios.Add(EjemploOp);
            operarios.Add(EjemploOp2);
            
            foreach(Operario op in operarios)
            {
                //se ñaaden a la lista
                listEmpleados.Items.Add(op.Nombre + "  " + op.Apellidos);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se enviaria la informacion del operario y se cogerian los datos de la base de datos
            infoEmp = new FormInfoEmpleado(operarios[listEmpleados.SelectedIndex]);
            infoEmp.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intentos = 0;
            bool estadentro=false;
            login = new FormLogin();
          //comprobacion del login
            while (intentos < 3 )
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    //se comprobara los datos de la base de datos de momento aun no hecho
                    //si entra
                    if (!login.txtUsuario.Text.Equals("") && !login.txtPass.Text.Equals(""))
                    {
                        // user.Nombre=conexion.nombre y asi con los campos
                       
                        login.Close();
                        estadentro = true;
                        intentos = 2;
                    }
                   // si ha dado todos los intentos y no ha entrado 
                     if (intentos == 2 && !estadentro )
                    {
                        login.Close();
                        Close();
                    }


                }
               
               
                intentos++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil = new FormPerfilUsuario(user);
            Perfil.ShowDialog();
        }

        

      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operarios[listEmpleados.SelectedIndex].foto==null)
            {
                operarios[listEmpleados.SelectedIndex].foto = new Bitmap("F:\\proyectoestudio\\proyectoestudio\\images\\users.png");
                pictureBox1.Image = operarios[listEmpleados.SelectedIndex].foto;
            }
            txtNombre.Text = operarios[listEmpleados.SelectedIndex].Nombre;
            txtApellidos.Text = operarios[listEmpleados.SelectedIndex].Apellidos;
            txtCodigo.Text = operarios[listEmpleados.SelectedIndex].Codigo;
        }
    }
}
