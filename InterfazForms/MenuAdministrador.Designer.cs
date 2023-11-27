namespace InterfazForms
{
    partial class MenuAdministrador
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
            label1 = new Label();
            btnGestionUsuarios = new Button();
            btnProveedores = new Button();
            btnProductos = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 53);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a ElectroHogar SA";
            label1.Click += label1_Click;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Location = new Point(305, 126);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(176, 34);
            btnGestionUsuarios.TabIndex = 1;
            btnGestionUsuarios.Text = "Gestion de Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(305, 171);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(176, 34);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(305, 216);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(176, 34);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(305, 261);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(176, 34);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(305, 306);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 34);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReportes);
            Controls.Add(btnProductos);
            Controls.Add(btnProveedores);
            Controls.Add(btnGestionUsuarios);
            Controls.Add(label1);
            Name = "MenuAdministrador";
            Text = "MenuAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGestionUsuarios;
        private Button btnProveedores;
        private Button btnProductos;
        private Button btnReportes;
        private Button btnCerrarSesion;
    }
}