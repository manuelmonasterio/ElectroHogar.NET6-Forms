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
            txbUsuario = new TextBox();
            txbContrasena = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(322, 117);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(100, 23);
            txbUsuario.TabIndex = 0;
            txbUsuario.Text = "Usuario";
            // 
            // txbContrasena
            // 
            txbContrasena.Location = new Point(322, 159);
            txbContrasena.Name = "txbContrasena";
            txbContrasena.Size = new Size(100, 23);
            txbContrasena.TabIndex = 1;
            txbContrasena.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(331, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txbContrasena);
            Controls.Add(txbUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUsuario;
        private TextBox txbContrasena;
        private Button btnLogin;
    }
}