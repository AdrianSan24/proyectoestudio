namespace proyectoestudio
{
    partial class FormNuevoempleado
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
            this.btnAñadirE = new System.Windows.Forms.Button();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblApellidosE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.txtApellidosE = new System.Windows.Forms.TextBox();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.pictureBoxE = new System.Windows.Forms.PictureBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadirE
            // 
            this.btnAñadirE.Location = new System.Drawing.Point(127, 242);
            this.btnAñadirE.Name = "btnAñadirE";
            this.btnAñadirE.Size = new System.Drawing.Size(176, 49);
            this.btnAñadirE.TabIndex = 23;
            this.btnAñadirE.Text = "Añadir";
            this.btnAñadirE.UseVisualStyleBackColor = true;
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(151, 12);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(66, 17);
            this.lblNombreE.TabIndex = 22;
            this.lblNombreE.Text = "Nombre :";
            // 
            // lblApellidosE
            // 
            this.lblApellidosE.AutoSize = true;
            this.lblApellidosE.Location = new System.Drawing.Point(151, 67);
            this.lblApellidosE.Name = "lblApellidosE";
            this.lblApellidosE.Size = new System.Drawing.Size(73, 17);
            this.lblApellidosE.TabIndex = 21;
            this.lblApellidosE.Text = "Apellidos :";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(162, 123);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoE.TabIndex = 20;
            this.lblCodigoE.Text = "Codigo:";
            // 
            // txtApellidosE
            // 
            this.txtApellidosE.Enabled = false;
            this.txtApellidosE.Location = new System.Drawing.Point(151, 94);
            this.txtApellidosE.Name = "txtApellidosE";
            this.txtApellidosE.Size = new System.Drawing.Size(180, 22);
            this.txtApellidosE.TabIndex = 19;
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(151, 143);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoE.TabIndex = 18;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Enabled = false;
            this.txtNombreE.Location = new System.Drawing.Point(151, 38);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(100, 22);
            this.txtNombreE.TabIndex = 17;
            // 
            // pictureBoxE
            // 
            this.pictureBoxE.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxE.Name = "pictureBoxE";
            this.pictureBoxE.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxE.TabIndex = 16;
            this.pictureBoxE.TabStop = false;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(283, 143);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartamento.TabIndex = 25;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(280, 123);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(98, 17);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento";
            // 
            // FormNuevoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.btnAñadirE);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.lblApellidosE);
            this.Controls.Add(this.lblCodigoE);
            this.Controls.Add(this.txtApellidosE);
            this.Controls.Add(this.txtCodigoE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.pictureBoxE);
            this.Name = "FormNuevoempleado";
            this.Text = "Nuevo empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblApellidosE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.TextBox txtApellidosE;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.PictureBox pictureBoxE;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
    }
}