namespace InterfazForms
{
    partial class GestionUsuario
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
            btnAltaUsuario = new Button();
            btnModUsuario = new Button();
            btnBajaUsuario = new Button();
            btnVolver1 = new Button();
            SuspendLayout();
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Location = new Point(296, 116);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(175, 40);
            btnAltaUsuario.TabIndex = 0;
            btnAltaUsuario.Text = "Alta de Usuario";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // btnModUsuario
            // 
            btnModUsuario.Location = new Point(296, 162);
            btnModUsuario.Name = "btnModUsuario";
            btnModUsuario.Size = new Size(175, 40);
            btnModUsuario.TabIndex = 1;
            btnModUsuario.Text = "Modificar Usuario";
            btnModUsuario.UseVisualStyleBackColor = true;
            btnModUsuario.Click += btnModUsuario_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Location = new Point(296, 208);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(175, 40);
            btnBajaUsuario.TabIndex = 2;
            btnBajaUsuario.Text = "Baja de Usuario";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            // 
            // btnVolver1
            // 
            btnVolver1.Location = new Point(296, 254);
            btnVolver1.Name = "btnVolver1";
            btnVolver1.Size = new Size(175, 40);
            btnVolver1.TabIndex = 3;
            btnVolver1.Text = "Volver al menú anterior";
            btnVolver1.UseVisualStyleBackColor = true;
            btnVolver1.Click += btnVolver1_Click;
            // 
            // GestionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver1);
            Controls.Add(btnBajaUsuario);
            Controls.Add(btnModUsuario);
            Controls.Add(btnAltaUsuario);
            Name = "GestionUsuario";
            Text = "GestionUsuario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltaUsuario;
        private Button btnModUsuario;
        private Button btnBajaUsuario;
        private Button btnVolver1;
    }
}