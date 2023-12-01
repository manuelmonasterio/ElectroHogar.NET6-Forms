namespace InterfazForms
{
    partial class FormLogin
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
            btnLogin = new Button();
            btnSalir = new Button();
            txbUsuario = new TextBox();
            txbContrasena = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(332, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(83, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(700, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 31);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(291, 121);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(169, 23);
            txbUsuario.TabIndex = 2;
            txbUsuario.Text = "Usuario";
            // 
            // txbContrasena
            // 
            txbContrasena.Location = new Point(291, 168);
            txbContrasena.Name = "txbContrasena";
            txbContrasena.PasswordChar = '*';
            txbContrasena.Size = new Size(169, 23);
            txbContrasena.TabIndex = 3;
            txbContrasena.Text = "Contraseña";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbContrasena);
            Controls.Add(txbUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnSalir;
        private TextBox txbUsuario;
        private TextBox txbContrasena;
    }
}