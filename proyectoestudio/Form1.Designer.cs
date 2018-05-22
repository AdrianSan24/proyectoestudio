namespace proyectoestudio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.btninfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.dGViewDatos = new System.Windows.Forms.DataGridView();
            this.Horainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.lblmaquina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempoestandar = new System.Windows.Forms.TextBox();
            this.lblOscilacion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 16;
            this.listEmpleados.Location = new System.Drawing.Point(577, 31);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(294, 500);
            this.listEmpleados.TabIndex = 0;
            this.listEmpleados.SelectedIndexChanged += new System.EventHandler(this.listEmpleados_SelectedIndexChanged);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(435, 506);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(75, 23);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "Info";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPerfilToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // administrarPerfilToolStripMenuItem
            // 
            this.administrarPerfilToolStripMenuItem.Name = "administrarPerfilToolStripMenuItem";
            this.administrarPerfilToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.administrarPerfilToolStripMenuItem.Text = "Administrar perfil";
            this.administrarPerfilToolStripMenuItem.Click += new System.EventHandler(this.administrarPerfilToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Controls.Add(this.dGViewDatos);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblApellidos);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 408);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(18, 164);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(122, 17);
            this.lblRegistro.TabIndex = 15;
            this.lblRegistro.Text = "Ultimos Registros:";
            // 
            // dGViewDatos
            // 
            this.dGViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horainicio,
            this.CodigoMaquina,
            this.HoraFin,
            this.Tiempo});
            this.dGViewDatos.Location = new System.Drawing.Point(0, 187);
            this.dGViewDatos.Name = "dGViewDatos";
            this.dGViewDatos.ReadOnly = true;
            this.dGViewDatos.RowTemplate.Height = 24;
            this.dGViewDatos.Size = new System.Drawing.Size(462, 208);
            this.dGViewDatos.TabIndex = 14;
            // 
            // Horainicio
            // 
            this.Horainicio.HeaderText = "Hora Inicio";
            this.Horainicio.Name = "Horainicio";
            this.Horainicio.ReadOnly = true;
            // 
            // CodigoMaquina
            // 
            this.CodigoMaquina.HeaderText = "Codigo de Maquina";
            this.CodigoMaquina.Name = "CodigoMaquina";
            this.CodigoMaquina.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(189, 128);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(341, 45);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(186, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 101);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(186, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(338, 14);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(183, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(435, 45);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 24);
            this.cbxDepartamento.TabIndex = 5;
            this.cbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamento_SelectedIndexChanged);
            // 
            // lblmaquina
            // 
            this.lblmaquina.AutoSize = true;
            this.lblmaquina.Location = new System.Drawing.Point(343, 45);
            this.lblmaquina.Name = "lblmaquina";
            this.lblmaquina.Size = new System.Drawing.Size(86, 17);
            this.lblmaquina.TabIndex = 6;
            this.lblmaquina.Text = "Codigo Dep:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo Estandar:";
            // 
            // txtTiempoestandar
            // 
            this.txtTiempoestandar.Enabled = false;
            this.txtTiempoestandar.Location = new System.Drawing.Point(139, 44);
            this.txtTiempoestandar.Name = "txtTiempoestandar";
            this.txtTiempoestandar.Size = new System.Drawing.Size(100, 22);
            this.txtTiempoestandar.TabIndex = 8;
            // 
            // lblOscilacion
            // 
            this.lblOscilacion.AutoSize = true;
            this.lblOscilacion.Location = new System.Drawing.Point(252, 44);
            this.lblOscilacion.Name = "lblOscilacion";
            this.lblOscilacion.Size = new System.Drawing.Size(0, 17);
            this.lblOscilacion.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 541);
            this.Controls.Add(this.lblOscilacion);
            this.Controls.Add(this.txtTiempoestandar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmaquina);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Departamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEmpleados;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPerfilToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridView dGViewDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label lblmaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempoestandar;
        private System.Windows.Forms.Label lblOscilacion;
    }
}

