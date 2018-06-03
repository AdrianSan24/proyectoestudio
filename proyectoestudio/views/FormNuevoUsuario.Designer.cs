namespace proyectoestudio
{
    partial class FormNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoUsuario));
            this.pictureBoxU = new System.Windows.Forms.PictureBox();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.lblApellidosU = new System.Windows.Forms.Label();
            this.lblCodigoU = new System.Windows.Forms.Label();
            this.txtApellidosU = new System.Windows.Forms.TextBox();
            this.txtCodigoU = new System.Windows.Forms.TextBox();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.btnAñadirU = new System.Windows.Forms.Button();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnimage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxU)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxU
            // 
            this.pictureBoxU.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxU.Name = "pictureBoxU";
            this.pictureBoxU.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxU.TabIndex = 0;
            this.pictureBoxU.TabStop = false;
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(154, 14);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(66, 17);
            this.lblNombreU.TabIndex = 1;
            this.lblNombreU.Text = "Nombre :";
            // 
            // lblApellidosU
            // 
            this.lblApellidosU.AutoSize = true;
            this.lblApellidosU.Location = new System.Drawing.Point(154, 69);
            this.lblApellidosU.Name = "lblApellidosU";
            this.lblApellidosU.Size = new System.Drawing.Size(73, 17);
            this.lblApellidosU.TabIndex = 3;
            this.lblApellidosU.Text = "Apellidos :";
            // 
            // lblCodigoU
            // 
            this.lblCodigoU.AutoSize = true;
            this.lblCodigoU.Location = new System.Drawing.Point(154, 164);
            this.lblCodigoU.Name = "lblCodigoU";
            this.lblCodigoU.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoU.TabIndex = 7;
            this.lblCodigoU.Text = "Codigo:";
            // 
            // txtApellidosU
            // 
            this.txtApellidosU.Location = new System.Drawing.Point(154, 93);
            this.txtApellidosU.Name = "txtApellidosU";
            this.txtApellidosU.Size = new System.Drawing.Size(180, 22);
            this.txtApellidosU.TabIndex = 4;
            // 
            // txtCodigoU
            // 
            this.txtCodigoU.Location = new System.Drawing.Point(154, 184);
            this.txtCodigoU.Name = "txtCodigoU";
            this.txtCodigoU.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoU.TabIndex = 8;
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(154, 40);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(100, 22);
            this.txtNombreU.TabIndex = 2;
            this.txtNombreU.TextChanged += new System.EventHandler(this.txtNombreU_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(368, 27);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(66, 17);
            this.lblPermisos.TabIndex = 14;
            this.lblPermisos.Text = "Permisos";
            // 
            // btnAñadirU
            // 
            this.btnAñadirU.Location = new System.Drawing.Point(208, 212);
            this.btnAñadirU.Name = "btnAñadirU";
            this.btnAñadirU.Size = new System.Drawing.Size(176, 49);
            this.btnAñadirU.TabIndex = 14;
            this.btnAñadirU.Text = "Añadir";
            this.btnAñadirU.UseVisualStyleBackColor = true;
            this.btnAñadirU.Click += new System.EventHandler(this.btnAñadirU_Click);
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Location = new System.Drawing.Point(387, 147);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(130, 17);
            this.labelPass2.TabIndex = 12;
            this.labelPass2.Text = "Repita Contraseña:";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(387, 173);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña2.TabIndex = 13;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(387, 96);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(130, 17);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Nueva Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(387, 122);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 11;
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(13, 147);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(115, 48);
            this.btnimage.TabIndex = 0;
            this.btnimage.Text = "Añadir Imagen";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(154, 118);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(157, 139);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 279);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnAñadirU);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.lblApellidosU);
            this.Controls.Add(this.lblCodigoU);
            this.Controls.Add(this.txtApellidosU);
            this.Controls.Add(this.txtCodigoU);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.pictureBoxU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.FormNuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxU;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.Label lblApellidosU;
        private System.Windows.Forms.Label lblCodigoU;
        private System.Windows.Forms.TextBox txtApellidosU;
        private System.Windows.Forms.TextBox txtCodigoU;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Button btnAñadirU;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}