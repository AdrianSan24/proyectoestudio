namespace proyectoestudio
{
    partial class FormPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilUsuario));
            this.pictureBoxU = new System.Windows.Forms.PictureBox();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.txtCodigoU = new System.Windows.Forms.TextBox();
            this.txtApellidosU = new System.Windows.Forms.TextBox();
            this.lblCodigoU = new System.Windows.Forms.Label();
            this.lblApellidosU = new System.Windows.Forms.Label();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.btnAñadirEmpleado = new System.Windows.Forms.Button();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnEditarU = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.txtcontrasena2 = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btnGuardarperfil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEliminarOP = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxU)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxU
            // 
            this.pictureBoxU.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxU.Name = "pictureBoxU";
            this.pictureBoxU.Size = new System.Drawing.Size(153, 151);
            this.pictureBoxU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxU.TabIndex = 0;
            this.pictureBoxU.TabStop = false;
            this.pictureBoxU.Click += new System.EventHandler(this.pictureBoxU_Click);
            // 
            // txtNombreU
            // 
            this.txtNombreU.Enabled = false;
            this.txtNombreU.Location = new System.Drawing.Point(200, 39);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(100, 22);
            this.txtNombreU.TabIndex = 1;
            // 
            // txtCodigoU
            // 
            this.txtCodigoU.Enabled = false;
            this.txtCodigoU.Location = new System.Drawing.Point(200, 144);
            this.txtCodigoU.Name = "txtCodigoU";
            this.txtCodigoU.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoU.TabIndex = 5;
            // 
            // txtApellidosU
            // 
            this.txtApellidosU.Enabled = false;
            this.txtApellidosU.Location = new System.Drawing.Point(200, 95);
            this.txtApellidosU.Name = "txtApellidosU";
            this.txtApellidosU.Size = new System.Drawing.Size(180, 22);
            this.txtApellidosU.TabIndex = 3;
            // 
            // lblCodigoU
            // 
            this.lblCodigoU.AutoSize = true;
            this.lblCodigoU.Location = new System.Drawing.Point(211, 124);
            this.lblCodigoU.Name = "lblCodigoU";
            this.lblCodigoU.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoU.TabIndex = 4;
            this.lblCodigoU.Text = "Codigo:";
            // 
            // lblApellidosU
            // 
            this.lblApellidosU.AutoSize = true;
            this.lblApellidosU.Location = new System.Drawing.Point(200, 68);
            this.lblApellidosU.Name = "lblApellidosU";
            this.lblApellidosU.Size = new System.Drawing.Size(73, 17);
            this.lblApellidosU.TabIndex = 2;
            this.lblApellidosU.Text = "Apellidos :";
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(200, 13);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(66, 17);
            this.lblNombreU.TabIndex = 0;
            this.lblNombreU.Text = "Nombre :";
            // 
            // btnAñadirEmpleado
            // 
            this.btnAñadirEmpleado.Location = new System.Drawing.Point(12, 261);
            this.btnAñadirEmpleado.Name = "btnAñadirEmpleado";
            this.btnAñadirEmpleado.Size = new System.Drawing.Size(164, 39);
            this.btnAñadirEmpleado.TabIndex = 13;
            this.btnAñadirEmpleado.Text = "Añadir Empleado";
            this.btnAñadirEmpleado.UseVisualStyleBackColor = true;
            this.btnAñadirEmpleado.Click += new System.EventHandler(this.btnAñadirEmpleado_Click);
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.Location = new System.Drawing.Point(193, 262);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(187, 38);
            this.btnAñadirUsuario.TabIndex = 15;
            this.btnAñadirUsuario.Text = "Añadir Usuario";
            this.btnAñadirUsuario.UseVisualStyleBackColor = true;
            this.btnAñadirUsuario.Visible = false;
            this.btnAñadirUsuario.Click += new System.EventHandler(this.btnAñadirUsuario_Click);
            // 
            // btnEditarU
            // 
            this.btnEditarU.Location = new System.Drawing.Point(397, 305);
            this.btnEditarU.Name = "btnEditarU";
            this.btnEditarU.Size = new System.Drawing.Size(170, 39);
            this.btnEditarU.TabIndex = 17;
            this.btnEditarU.Text = "Editar Perfil";
            this.btnEditarU.UseVisualStyleBackColor = true;
            this.btnEditarU.Click += new System.EventHandler(this.btnEditarU_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(332, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(332, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 7;
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Location = new System.Drawing.Point(535, 90);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(130, 17);
            this.labelPass2.TabIndex = 10;
            this.labelPass2.Text = "Repita Contraseña:";
            this.labelPass2.Visible = false;
            // 
            // txtcontrasena2
            // 
            this.txtcontrasena2.Location = new System.Drawing.Point(538, 122);
            this.txtcontrasena2.Name = "txtcontrasena2";
            this.txtcontrasena2.Size = new System.Drawing.Size(100, 22);
            this.txtcontrasena2.TabIndex = 11;
            this.txtcontrasena2.Visible = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(535, 22);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(130, 17);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Nueva Contraseña:";
            this.labelPass.Visible = false;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(538, 52);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 22);
            this.txtcontrasena.TabIndex = 9;
            this.txtcontrasena.UseSystemPasswordChar = true;
            this.txtcontrasena.Visible = false;
            // 
            // btnGuardarperfil
            // 
            this.btnGuardarperfil.Location = new System.Drawing.Point(538, 183);
            this.btnGuardarperfil.Name = "btnGuardarperfil";
            this.btnGuardarperfil.Size = new System.Drawing.Size(153, 46);
            this.btnGuardarperfil.TabIndex = 12;
            this.btnGuardarperfil.Text = "Guardar perfil";
            this.btnGuardarperfil.UseVisualStyleBackColor = true;
            this.btnGuardarperfil.Visible = false;
            this.btnGuardarperfil.Click += new System.EventHandler(this.btnGuardarperfil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEliminarOP
            // 
            this.btnEliminarOP.Location = new System.Drawing.Point(13, 306);
            this.btnEliminarOP.Name = "btnEliminarOP";
            this.btnEliminarOP.Size = new System.Drawing.Size(163, 40);
            this.btnEliminarOP.TabIndex = 14;
            this.btnEliminarOP.Text = "Eliminar Empleado";
            this.btnEliminarOP.UseVisualStyleBackColor = true;
            this.btnEliminarOP.Click += new System.EventHandler(this.btnEliminarOP_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(193, 305);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(187, 41);
            this.btnEliminarU.TabIndex = 16;
            this.btnEliminarU.Text = "Eliminar Usuario";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Visible = false;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // FormPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 356);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnEliminarOP);
            this.Controls.Add(this.btnGuardarperfil);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.txtcontrasena2);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnEditarU);
            this.Controls.Add(this.btnAñadirUsuario);
            this.Controls.Add(this.btnAñadirEmpleado);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.lblApellidosU);
            this.Controls.Add(this.lblCodigoU);
            this.Controls.Add(this.txtApellidosU);
            this.Controls.Add(this.txtCodigoU);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.pictureBoxU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPerfilUsuario";
            this.Text = " Tu Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxU;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.TextBox txtCodigoU;
        private System.Windows.Forms.TextBox txtApellidosU;
        private System.Windows.Forms.Label lblCodigoU;
        private System.Windows.Forms.Label lblApellidosU;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.Button btnAñadirEmpleado;
        private System.Windows.Forms.Button btnAñadirUsuario;
        private System.Windows.Forms.Button btnEditarU;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.TextBox txtcontrasena2;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btnGuardarperfil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEliminarOP;
        private System.Windows.Forms.Button btnEliminarU;
    }
}