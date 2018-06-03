namespace proyectoestudio.views
{
    partial class FormDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInicioparada = new System.Windows.Forms.TextBox();
            this.txtFinparada = new System.Windows.Forms.TextBox();
            this.txtTiempoParada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempoAtasco = new System.Windows.Forms.TextBox();
            this.txthoraFinAtasco = new System.Windows.Forms.TextBox();
            this.txthoraInicioAtasco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuaradarParada = new System.Windows.Forms.Button();
            this.btnGuardarAtasco = new System.Windows.Forms.Button();
            this.lblBandeja = new System.Windows.Forms.Label();
            this.txtBandeja = new System.Windows.Forms.TextBox();
            this.btnAñadirbandeja = new System.Windows.Forms.Button();
            this.btnquitarBandeja = new System.Windows.Forms.Button();
            this.btnInicioAtasco = new System.Windows.Forms.Button();
            this.btnfinatasco = new System.Windows.Forms.Button();
            this.btnFinParada = new System.Windows.Forms.Button();
            this.btnInicioParada = new System.Windows.Forms.Button();
            this.comboBoxMotivo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCodigoTrabajo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timerParada = new System.Windows.Forms.Timer(this.components);
            this.timerAtasco = new System.Windows.Forms.Timer(this.components);
            this.timerTotal = new System.Windows.Forms.Timer(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo";
            // 
            // txtInicioparada
            // 
            this.txtInicioparada.Enabled = false;
            this.txtInicioparada.Location = new System.Drawing.Point(113, 52);
            this.txtInicioparada.Name = "txtInicioparada";
            this.txtInicioparada.Size = new System.Drawing.Size(100, 22);
            this.txtInicioparada.TabIndex = 2;
            this.txtInicioparada.Text = "00:00:00";
            this.txtInicioparada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFinparada
            // 
            this.txtFinparada.Enabled = false;
            this.txtFinparada.Location = new System.Drawing.Point(219, 52);
            this.txtFinparada.Name = "txtFinparada";
            this.txtFinparada.Size = new System.Drawing.Size(100, 22);
            this.txtFinparada.TabIndex = 5;
            this.txtFinparada.Text = "00:00:00";
            this.txtFinparada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTiempoParada
            // 
            this.txtTiempoParada.Enabled = false;
            this.txtTiempoParada.Location = new System.Drawing.Point(325, 52);
            this.txtTiempoParada.Name = "txtTiempoParada";
            this.txtTiempoParada.Size = new System.Drawing.Size(100, 22);
            this.txtTiempoParada.TabIndex = 8;
            this.txtTiempoParada.Text = "00:00:00";
            this.txtTiempoParada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Atasco";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTiempoAtasco
            // 
            this.txtTiempoAtasco.Enabled = false;
            this.txtTiempoAtasco.Location = new System.Drawing.Point(353, 251);
            this.txtTiempoAtasco.Name = "txtTiempoAtasco";
            this.txtTiempoAtasco.Size = new System.Drawing.Size(100, 22);
            this.txtTiempoAtasco.TabIndex = 25;
            this.txtTiempoAtasco.Text = "00:00:00";
            this.txtTiempoAtasco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthoraFinAtasco
            // 
            this.txthoraFinAtasco.Enabled = false;
            this.txthoraFinAtasco.Location = new System.Drawing.Point(247, 251);
            this.txthoraFinAtasco.Name = "txthoraFinAtasco";
            this.txthoraFinAtasco.Size = new System.Drawing.Size(100, 22);
            this.txthoraFinAtasco.TabIndex = 22;
            this.txthoraFinAtasco.Text = "00:00:00";
            this.txthoraFinAtasco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthoraInicioAtasco
            // 
            this.txthoraInicioAtasco.Enabled = false;
            this.txthoraInicioAtasco.Location = new System.Drawing.Point(141, 251);
            this.txthoraInicioAtasco.Name = "txthoraInicioAtasco";
            this.txthoraInicioAtasco.Size = new System.Drawing.Size(100, 22);
            this.txthoraInicioAtasco.TabIndex = 19;
            this.txthoraInicioAtasco.Text = "00:00:00";
            this.txthoraInicioAtasco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tiempo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hora Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora Inicio";
            // 
            // btnGuaradarParada
            // 
            this.btnGuaradarParada.Location = new System.Drawing.Point(758, 52);
            this.btnGuaradarParada.Name = "btnGuaradarParada";
            this.btnGuaradarParada.Size = new System.Drawing.Size(129, 70);
            this.btnGuaradarParada.TabIndex = 13;
            this.btnGuaradarParada.Text = "Guardar Parada";
            this.btnGuaradarParada.UseVisualStyleBackColor = true;
            this.btnGuaradarParada.Click += new System.EventHandler(this.btnGuaradarParada_Click);
            // 
            // btnGuardarAtasco
            // 
            this.btnGuardarAtasco.Location = new System.Drawing.Point(488, 244);
            this.btnGuardarAtasco.Name = "btnGuardarAtasco";
            this.btnGuardarAtasco.Size = new System.Drawing.Size(129, 77);
            this.btnGuardarAtasco.TabIndex = 26;
            this.btnGuardarAtasco.Text = "Guardar Atasco";
            this.btnGuardarAtasco.UseVisualStyleBackColor = true;
            this.btnGuardarAtasco.Click += new System.EventHandler(this.btnGuardarAtasco_Click);
            // 
            // lblBandeja
            // 
            this.lblBandeja.AutoSize = true;
            this.lblBandeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeja.Location = new System.Drawing.Point(4, 374);
            this.lblBandeja.Name = "lblBandeja";
            this.lblBandeja.Size = new System.Drawing.Size(181, 20);
            this.lblBandeja.TabIndex = 27;
            this.lblBandeja.Text = "Bandejas no conformes:";
            // 
            // txtBandeja
            // 
            this.txtBandeja.Enabled = false;
            this.txtBandeja.Location = new System.Drawing.Point(235, 374);
            this.txtBandeja.Name = "txtBandeja";
            this.txtBandeja.Size = new System.Drawing.Size(39, 22);
            this.txtBandeja.TabIndex = 28;
            // 
            // btnAñadirbandeja
            // 
            this.btnAñadirbandeja.Location = new System.Drawing.Point(302, 351);
            this.btnAñadirbandeja.Name = "btnAñadirbandeja";
            this.btnAñadirbandeja.Size = new System.Drawing.Size(174, 28);
            this.btnAñadirbandeja.TabIndex = 29;
            this.btnAñadirbandeja.Text = "+ Bandeja no conforme";
            this.btnAñadirbandeja.UseVisualStyleBackColor = true;
            this.btnAñadirbandeja.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnquitarBandeja
            // 
            this.btnquitarBandeja.Location = new System.Drawing.Point(302, 385);
            this.btnquitarBandeja.Name = "btnquitarBandeja";
            this.btnquitarBandeja.Size = new System.Drawing.Size(174, 30);
            this.btnquitarBandeja.TabIndex = 30;
            this.btnquitarBandeja.Text = "- Bandeja no Conforme";
            this.btnquitarBandeja.UseVisualStyleBackColor = true;
            this.btnquitarBandeja.Click += new System.EventHandler(this.btnquitarBandeja_Click);
            // 
            // btnInicioAtasco
            // 
            this.btnInicioAtasco.Location = new System.Drawing.Point(141, 279);
            this.btnInicioAtasco.Name = "btnInicioAtasco";
            this.btnInicioAtasco.Size = new System.Drawing.Size(155, 42);
            this.btnInicioAtasco.TabIndex = 20;
            this.btnInicioAtasco.Text = "Inicio Atasco";
            this.btnInicioAtasco.UseVisualStyleBackColor = true;
            this.btnInicioAtasco.Click += new System.EventHandler(this.btnInicioAtasco_Click);
            // 
            // btnfinatasco
            // 
            this.btnfinatasco.Location = new System.Drawing.Point(302, 279);
            this.btnfinatasco.Name = "btnfinatasco";
            this.btnfinatasco.Size = new System.Drawing.Size(151, 42);
            this.btnfinatasco.TabIndex = 23;
            this.btnfinatasco.Text = "Fin Atasco";
            this.btnfinatasco.UseVisualStyleBackColor = true;
            this.btnfinatasco.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFinParada
            // 
            this.btnFinParada.Location = new System.Drawing.Point(274, 80);
            this.btnFinParada.Name = "btnFinParada";
            this.btnFinParada.Size = new System.Drawing.Size(151, 42);
            this.btnFinParada.TabIndex = 6;
            this.btnFinParada.Text = "Fin Parada";
            this.btnFinParada.UseVisualStyleBackColor = true;
            this.btnFinParada.Click += new System.EventHandler(this.btnFinParada_Click);
            // 
            // btnInicioParada
            // 
            this.btnInicioParada.Location = new System.Drawing.Point(113, 80);
            this.btnInicioParada.Name = "btnInicioParada";
            this.btnInicioParada.Size = new System.Drawing.Size(155, 42);
            this.btnInicioParada.TabIndex = 3;
            this.btnInicioParada.Text = "Inicio Parada";
            this.btnInicioParada.UseVisualStyleBackColor = true;
            this.btnInicioParada.Click += new System.EventHandler(this.btnInicioParada_Click);
            // 
            // comboBoxMotivo
            // 
            this.comboBoxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotivo.FormattingEnabled = true;
            this.comboBoxMotivo.Location = new System.Drawing.Point(431, 50);
            this.comboBoxMotivo.Name = "comboBoxMotivo";
            this.comboBoxMotivo.Size = new System.Drawing.Size(168, 24);
            this.comboBoxMotivo.TabIndex = 10;
            this.comboBoxMotivo.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotivo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Motivo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(605, 52);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(147, 173);
            this.txtdescripcion.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descripcion";
            // 
            // comboBoxCodigoTrabajo
            // 
            this.comboBoxCodigoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodigoTrabajo.Enabled = false;
            this.comboBoxCodigoTrabajo.FormattingEnabled = true;
            this.comboBoxCodigoTrabajo.ItemHeight = 16;
            this.comboBoxCodigoTrabajo.Location = new System.Drawing.Point(110, 165);
            this.comboBoxCodigoTrabajo.Name = "comboBoxCodigoTrabajo";
            this.comboBoxCodigoTrabajo.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCodigoTrabajo.TabIndex = 29;
            this.comboBoxCodigoTrabajo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoTrabajo_SelectedIndexChanged);
            this.comboBoxCodigoTrabajo.SelectedValueChanged += new System.EventHandler(this.comboBoxCodigoTrabajo_SelectedValueChanged);
            this.comboBoxCodigoTrabajo.Click += new System.EventHandler(this.comboBoxCodigoTrabajo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = " codigo de trabajo";
            // 
            // timerParada
            // 
            this.timerParada.Interval = 1000;
            this.timerParada.Tick += new System.EventHandler(this.timerParada_Tick);
            // 
            // timerAtasco
            // 
            this.timerAtasco.Interval = 1000;
            this.timerAtasco.Tick += new System.EventHandler(this.timerAtasco_Tick);
            // 
            // timerTotal
            // 
            this.timerTotal.Interval = 1000;
            this.timerTotal.Tick += new System.EventHandler(this.timerTotal_Tick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(320, 165);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 68);
            this.button1.TabIndex = 31;
            this.button1.Text = "Guardar Codigo Maquina y Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxCodigoTrabajo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxMotivo);
            this.Controls.Add(this.btnFinParada);
            this.Controls.Add(this.btnInicioParada);
            this.Controls.Add(this.btnfinatasco);
            this.Controls.Add(this.btnInicioAtasco);
            this.Controls.Add(this.btnquitarBandeja);
            this.Controls.Add(this.btnAñadirbandeja);
            this.Controls.Add(this.txtBandeja);
            this.Controls.Add(this.lblBandeja);
            this.Controls.Add(this.btnGuardarAtasco);
            this.Controls.Add(this.btnGuaradarParada);
            this.Controls.Add(this.txtTiempoAtasco);
            this.Controls.Add(this.txthoraFinAtasco);
            this.Controls.Add(this.txthoraInicioAtasco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTiempoParada);
            this.Controls.Add(this.txtFinparada);
            this.Controls.Add(this.txtInicioparada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatos";
            this.Text = "Recogida de Datos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicioparada;
        private System.Windows.Forms.TextBox txtFinparada;
        private System.Windows.Forms.TextBox txtTiempoParada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempoAtasco;
        private System.Windows.Forms.TextBox txthoraFinAtasco;
        private System.Windows.Forms.TextBox txthoraInicioAtasco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuaradarParada;
        private System.Windows.Forms.Button btnGuardarAtasco;
        private System.Windows.Forms.Label lblBandeja;
        private System.Windows.Forms.TextBox txtBandeja;
        private System.Windows.Forms.Button btnAñadirbandeja;
        private System.Windows.Forms.Button btnquitarBandeja;
        private System.Windows.Forms.Button btnInicioAtasco;
        private System.Windows.Forms.Button btnfinatasco;
        private System.Windows.Forms.Button btnFinParada;
        private System.Windows.Forms.Button btnInicioParada;
        private System.Windows.Forms.ComboBox comboBoxMotivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCodigoTrabajo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerParada;
        private System.Windows.Forms.Timer timerAtasco;
        private System.Windows.Forms.Timer timerTotal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button button1;
    }
}