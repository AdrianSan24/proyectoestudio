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
    public partial class FormDatos : Form
    {
        int bandejasmalas=0;
        Operario op;
        Conexiones con;
        int segParada, minParada;//variable para contar el tiempo 
        int segAtasco = 0, minAtasco = 0, horaAtasco = 0;//variables para contar el tiempo de los atascos
        int segTotal = 0, minTotal=0, horaTotal = 0;//variables para contar el tiempo total 
        string tiempoParada = "";//variable para guardar el tiempo que tardo la parada
        string tiempoAtasco = "";//variable para guardar el tiempo que tardo el atasco
        string InicioParada = "";//variable que guarda a que hora inicio el atasco
        string Finparada = "";//variable que guarda a que hora finalizo la parada
        string InicioAtasco = "";//variable que guarda la hora inicial del Atasco
        string FinAtasco = "";//variable que guarda la hora final del atasco
        string Iniciototal;//variable que guarda hora inicial que se empezo a trabajar en ese codigo
        string FinTotal;//variable que guarda hora que se acabo de trabajar con ese codigo
        string tiempoTotal;//variable que guarda el tiempo total que se ha trabajado en el codigo
        string codigodetrabajo;//guarda el codigo de la maquina que se esta trabajando 
       
        List<string> motivoslista = new List<string>();//opciones de las causas de las paradas
        List<string> codes;//lista de los codigos de las maquinas que se van trabajar

        //evento que cuenta el tiempo del trabajo total en un codigo,se ejecuta cada segundo
        private void timerTotal_Tick(object sender, EventArgs e)
        {
            segTotal += 1;
            if (segTotal == 60)
            {
                segTotal = 0;
                minTotal += 1;
            }
            if (minTotal == 60)
            {
                minTotal = 0;
                horaTotal += 1;
            }
        }
        //evento que cuenta el tiempo del Atasco en un codigo,se ejecuta cada segundo
        private void timerAtasco_Tick(object sender, EventArgs e)
        {
            segAtasco += 1;
            if (segAtasco == 60)
            {
                segAtasco = 0;
                minAtasco += 1;
            }
            if (minAtasco == 60)
            {
                minAtasco = 0;
                horaAtasco += 1;
            }
        }
        //evento que cuenta el tiempo de las paradas  en un codigo,se ejecuta cada segundo
        private void timerParada_Tick(object sender, EventArgs e)
        {
            segParada += 1;
            if (segParada == 60)
            {
                segParada = 0;
                minParada += 1;
            }
           
        }
        //se guarda el tiempo a que hora empieza la parada y se inicializa el timer de paradas
        private void btnInicioParada_Click(object sender, EventArgs e)
        {
            txtInicioparada.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            InicioParada = txtInicioparada.Text;
            txtTiempoParada.Text = "00:00:00";
            timerParada.Start();
        }
        //se guarda el tiempo de la parada y se envian a la base de datos los datos de la parada
        private void btnGuaradarParada_Click(object sender, EventArgs e)
        {
            if(txtTiempoParada.Text == "00:00:00")
            {
                MessageBox.Show("no hay un tiempo valido");

            }
            else
            {
              
                    if (txtdescripcion.Text == "" && comboBoxMotivo.SelectedItem.ToString() == "Otro")
                    {
                        MessageBox.Show("en este caso debe rellenar el campo descripcion");

                    }
                    else
                    {
                        if(MessageBox.Show("Desea guardar la parada?","Guardar Parada", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (con.Añadirdatos(op, tiempoParada, InicioParada, Finparada, comboBoxCodigoTrabajo.SelectedItem.ToString(), comboBoxMotivo.SelectedItem.ToString(), txtdescripcion.Text)){
                                MessageBox.Show("La parada ha sido guardada", "Guardar Parada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtdescripcion.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ha habido un error al guardar la parada", "Guardar Parada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                       
                        segParada = 0;
                        minParada = 0;
                    txtTiempoParada.Text = "00:00:00";
                    txtInicioparada.Text = "00:00:00";
                    txtFinparada.Text = "00:00:00";
                    tiempoParada = "";
                }

                    
               
            }
        }
        //se guarda la hora a la que acaba la parada 
        private void btnFinParada_Click(object sender, EventArgs e)
        {
            txtFinparada.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            Finparada = txtFinparada.Text;
            timerParada.Stop();
            if (minParada < 10)
            {
                tiempoParada += "0" + minParada + ":";
            }
            else
            {
                tiempoParada +=  minParada + ":";
            }
            if (segParada < 10)
            {
                tiempoParada += "0" +segParada ;
            }
            else
            {
                tiempoParada += segParada;
            }
            txtTiempoParada.Text = tiempoParada;
            segParada = 0;
            minParada = 0;
            tiempoParada = "";
        }
        //se guarda la hora a la que empieza el atasco y se pone en marcha el timer de atasco
        private void btnInicioAtasco_Click(object sender, EventArgs e)
        {
           txthoraInicioAtasco.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            InicioAtasco = txthoraInicioAtasco.Text;
            txtTiempoAtasco.Text = "00:00:00";
            timerAtasco.Start();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthoraFinAtasco.Text = DateTime.Now.Hour+":" + DateTime.Now.Minute+":" + DateTime.Now.Second;
            FinAtasco = txthoraFinAtasco.Text;
            timerAtasco.Stop();
            tiempoAtasco = horaAtasco + ":";
            if (minAtasco < 10)
            {
                tiempoAtasco += "0" + minAtasco + ":";
            }
            else
            {
                tiempoAtasco += minAtasco + ":";
            }
            if (segAtasco < 10)
            {
                tiempoAtasco += "0" + segAtasco ;
            }
            else
            {
                tiempoAtasco +=  segAtasco;
            }
            txtTiempoAtasco.Text = tiempoAtasco;
           
            segAtasco = 0;
            minAtasco = 0;
            horaAtasco = 0;
        }

        private void btnGuardarAtasco_Click(object sender, EventArgs e)
        {

            if (txtTiempoAtasco.Text == "00:00:00")
            {
                MessageBox.Show("no hay un tiempo valido");
                timerAtasco.Stop();
            }
            else
            {

                 if (MessageBox.Show("Desea guardar la parada de Atasco?", "Guardar Atasco", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (con.AñadirAtascos(op, tiempoAtasco, InicioAtasco, FinAtasco, comboBoxCodigoTrabajo.SelectedItem.ToString()))
                        {
                            MessageBox.Show("La parada de Atasco ha sido guardada", "Guardar Parada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtdescripcion.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ha habido un error al guardar la parada de Atasco", "Guardar Parada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                   
                    }

                txtTiempoAtasco.Text = "00:00:00";
                txthoraInicioAtasco.Text = "00:00:00";
                txthoraFinAtasco.Text = "00:00:00";
                tiempoAtasco = "";
            }
           

        }

        private void comboBoxCodigoTrabajo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxCodigoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

               
                    codigodetrabajo = comboBoxCodigoTrabajo.SelectedItem.ToString();
                   Iniciototal= DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                   

                    lblCodigo.Text = comboBoxCodigoTrabajo.SelectedItem.ToString();
                    
                    timerTotal.Start();
                
            comboBoxCodigoTrabajo.Enabled = false;
            btnFinParada.Enabled = true;
            btnInicioParada.Enabled = true;
            btnInicioAtasco.Enabled = true;
            btnfinatasco.Enabled = true;
            btnGuaradarParada.Enabled = true;
            btnGuardarAtasco.Enabled = true;
            button1.Enabled = true;
            btnAñadirbandeja.Enabled = true;
            btnquitarBandeja.Enabled = true;
        }

        private void comboBoxCodigoTrabajo_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Desea guardar el tiempo total del codigo?", "Guardar Codigo de trabajo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                timerTotal.Stop();
                FinTotal = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                tiempoTotal = horaTotal + ":";
                if (minTotal < 10)
                {
                    tiempoTotal += "0" + minTotal + ":";
                }
                else
                {
                    tiempoTotal += minTotal + ":";
                }
                if (segTotal < 10)
                {
                    tiempoTotal += "0" + segTotal;
                }
                else
                {
                    tiempoTotal += segTotal;
                }
                if (con.AñadirTiempoTotal(Iniciototal, FinTotal, tiempoTotal, codigodetrabajo, op.Codigo, bandejasmalas))
                {
                    
                    segTotal = 0;
                    minTotal = 0;
                    horaTotal = 0;
                    bandejasmalas = 0;
                    MessageBox.Show("Se ha guardado correctamente el tiempo total del codigo "+ codigodetrabajo, "Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en la base de datos", "Guardar Atasco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                comboBoxCodigoTrabajo.Enabled = true;
                btnFinParada.Enabled = false;
                btnInicioParada.Enabled = false;
                btnInicioAtasco.Enabled = false;
                btnfinatasco.Enabled = false;
                btnGuaradarParada.Enabled = false;
                btnGuardarAtasco.Enabled = false;
            }else if (result == DialogResult.No)
            {
                timerTotal.Stop();
                segTotal = 0;
                minTotal = 0;
                horaTotal = 0;
                comboBoxCodigoTrabajo.Enabled = true;
                btnFinParada.Enabled = false;
                btnInicioParada.Enabled = false;
                btnInicioAtasco.Enabled = false;
                btnfinatasco.Enabled = false;
                btnGuaradarParada.Enabled = false;
                btnGuardarAtasco.Enabled = false;
                btnAñadirbandeja.Enabled = false;
                btnquitarBandeja.Enabled = false;
            }
            tiempoTotal = "";
            
        }

        private void comboBoxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public FormDatos(Conexiones con,Operario op)
        {
            InitializeComponent();
           

            motivoslista.Add("Averia Retractiladora");//opciones de parada
            motivoslista.Add("Averia pesadora Bizerba");
            motivoslista.Add("Falta Materia Prima");
            motivoslista.Add("Falta Materia Auxiliar");
            motivoslista.Add("Cambio Bobina");
            motivoslista.Add("Cambio etiqueta pesadora");
            motivoslista.Add("Cambio etiqueta impresora");
            motivoslista.Add("Cambio de producto");
            motivoslista.Add("Otro");
            comboBoxMotivo.DataSource = motivoslista;
            comboBoxMotivo.SelectedIndex = 0;
            codes = new List<string>();
            if (con.comprobarConexion())
            {
                con.cogercodigos(codes);
            }
            else
            {
                MessageBox.Show("error  la base de datos no esta conectdada,se cerrara el programa");
                this.Close();
            }
            comboBoxCodigoTrabajo.DataSource = codes;
            codigodetrabajo = comboBoxCodigoTrabajo.SelectedItem.ToString();
            lblCodigo.Text = comboBoxCodigoTrabajo.SelectedItem.ToString();
            timerTotal.Start();
            this.con = con;
            this.op = op;
            bandejasmalas = 0;
            txtBandeja.Text = "0";
           
            comboBoxCodigoTrabajo.Enabled = true;
            btnFinParada.Enabled = false;
            btnInicioParada.Enabled = false;
            btnInicioAtasco.Enabled = false;
            btnfinatasco.Enabled = false;
            btnGuaradarParada.Enabled = false;
            btnGuardarAtasco.Enabled = false;
            button1.Enabled = false;
            btnAñadirbandeja.Enabled = false;
            btnquitarBandeja.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bandejasmalas += 1;
            txtBandeja.Text = bandejasmalas+"";
        }

        private void btnquitarBandeja_Click(object sender, EventArgs e)
        {
            if (bandejasmalas > 0)
            {
                bandejasmalas -= 1;
                txtBandeja.Text = bandejasmalas + "";
            }
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
