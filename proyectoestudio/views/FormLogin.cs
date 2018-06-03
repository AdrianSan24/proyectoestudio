using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoestudio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            //ejemplo conexion
           // conexion.ConnectionString = @”Data Source = Raphael\SQLEXPRESS; Initial Catalog = bdtutorial; Integrated Security = True”;
           
        }

        
    }
}
