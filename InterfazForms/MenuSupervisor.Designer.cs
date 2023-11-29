namespace InterfazForms
{
    partial class MenuSupervisor
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
            btnProductos = new Button();
            btnReportes = new Button();
            btnDevoluciones = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 53);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a ElectroHogar SA";
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(304, 131);
            btnProductos.Margin = new Padding(6);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(176, 34);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(304, 223);
            btnReportes.Margin = new Padding(6);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(176, 34);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.Location = new Point(304, 177);
            btnDevoluciones.Margin = new Padding(6);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(176, 34);
            btnDevoluciones.TabIndex = 6;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = true;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(304, 269);
            btnCerrarSesion.Margin = new Padding(6);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 34);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnDevoluciones);
            Controls.Add(btnReportes);
            Controls.Add(btnProductos);
            Controls.Add(label1);
            Name = "MenuSupervisor";
            Text = "MenuSupervisor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProductos;
        private Button btnReportes;
        private Button btnDevoluciones;
        private Button btnCerrarSesion;
    }
}