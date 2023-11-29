namespace InterfazForms
{
    partial class MenuAdProveedores
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
            btnVolver1 = new Button();
            btnBajaUsuario = new Button();
            btnModUsuario = new Button();
            btnAltaUsuario = new Button();
            SuspendLayout();
            // 
            // btnVolver1
            // 
            btnVolver1.Location = new Point(298, 260);
            btnVolver1.Name = "btnVolver1";
            btnVolver1.Size = new Size(175, 40);
            btnVolver1.TabIndex = 7;
            btnVolver1.Text = "Volver al menú anterior";
            btnVolver1.UseVisualStyleBackColor = true;
            btnVolver1.Click += btnVolver1_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Location = new Point(298, 214);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(175, 40);
            btnBajaUsuario.TabIndex = 6;
            btnBajaUsuario.Text = "Baja de Proveedor";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // btnModUsuario
            // 
            btnModUsuario.Location = new Point(298, 168);
            btnModUsuario.Name = "btnModUsuario";
            btnModUsuario.Size = new Size(175, 40);
            btnModUsuario.TabIndex = 5;
            btnModUsuario.Text = "Modificar Proveedor";
            btnModUsuario.UseVisualStyleBackColor = true;
            btnModUsuario.Click += btnModUsuario_Click;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Location = new Point(298, 122);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(175, 40);
            btnAltaUsuario.TabIndex = 4;
            btnAltaUsuario.Text = "Alta de Proveedor";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // MenuAdProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver1);
            Controls.Add(btnBajaUsuario);
            Controls.Add(btnModUsuario);
            Controls.Add(btnAltaUsuario);
            Name = "MenuAdProveedores";
            Text = "MenuAdProveedores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver1;
        private Button btnBajaUsuario;
        private Button btnModUsuario;
        private Button btnAltaUsuario;
    }
}