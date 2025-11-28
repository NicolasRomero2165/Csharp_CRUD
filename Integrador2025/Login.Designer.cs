namespace Integrador2025
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            btnIniciarSesion = new Button();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtPassValidar = new TextBox();
            btnRegistrarOk = new Button();
            txtNombre = new TextBox();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '#';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(266, 27);
            txtPassword.TabIndex = 0;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 25);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(266, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            btnIniciarSesion.BackgroundImage = Properties.Resources.btnIniciarSesion;
            btnIniciarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderColor = Color.Black;
            btnIniciarSesion.FlatStyle = FlatStyle.Popup;
            btnIniciarSesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(335, 18);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(89, 57);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ButtonHighlight;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(335, 95);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 39);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.5F);
            btnCancelar.Location = new Point(335, 95);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 39);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPassValidar
            // 
            txtPassValidar.Location = new Point(30, 148);
            txtPassValidar.Name = "txtPassValidar";
            txtPassValidar.PasswordChar = '#';
            txtPassValidar.PlaceholderText = "Repita la Contraseña";
            txtPassValidar.Size = new Size(266, 27);
            txtPassValidar.TabIndex = 5;
            txtPassValidar.Visible = false;
            txtPassValidar.KeyPress += txtPassValidar_KeyPress;
            // 
            // btnRegistrarOk
            // 
            btnRegistrarOk.BackColor = SystemColors.ActiveCaption;
            btnRegistrarOk.FlatStyle = FlatStyle.Flat;
            btnRegistrarOk.Location = new Point(335, 36);
            btnRegistrarOk.Name = "btnRegistrarOk";
            btnRegistrarOk.Size = new Size(89, 39);
            btnRegistrarOk.TabIndex = 6;
            btnRegistrarOk.Text = "Registrar";
            btnRegistrarOk.UseVisualStyleBackColor = false;
            btnRegistrarOk.Visible = false;
            btnRegistrarOk.Click += btnRegistrarOk_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Apellido y Nombre";
            txtNombre.Size = new Size(266, 27);
            txtNombre.TabIndex = 7;
            txtNombre.Visible = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(276, 187);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "label1";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(452, 217);
            Controls.Add(lblFecha);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarOk);
            Controls.Add(txtPassValidar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button btnIniciarSesion;
        private Button btnRegistrar;
        private Button btnCancelar;
        private TextBox txtPassValidar;
        private Button btnRegistrarOk;
        private TextBox txtNombre;
        private Label lblFecha;
    }
}