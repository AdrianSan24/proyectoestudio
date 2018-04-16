namespace proyectoestudio
{
    partial class FormCronometrar
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lblOtros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Empezar Registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(31, 13);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(75, 17);
            this.lblHoraInicio.TabIndex = 1;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(158, 13);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(58, 17);
            this.lblHoraFin.TabIndex = 2;
            this.lblHoraFin.Text = "Hora fin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 158);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(552, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(549, 52);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(152, 17);
            this.lbltiempo.TabIndex = 5;
            this.lbltiempo.Text = "tiempo fuera de rango:";
            this.lbltiempo.Visible = false;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Location = new System.Drawing.Point(443, 125);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(154, 17);
            this.lblOtros.TabIndex = 6;
            this.lblOtros.Text = "Describa la otra causa:";
            this.lblOtros.Visible = false;
            // 
            // FormCronometrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 423);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.button1);
            this.Name = "FormCronometrar";
            this.Text = "Nuevo Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label lblOtros;
    }
}