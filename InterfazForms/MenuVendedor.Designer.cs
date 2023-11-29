namespace InterfazForms
{
    partial class MenuVendedor
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
            btnVenta = new Button();
            btnAgregarCliente = new Button();
            btnModificarCliente = new Button();
            btnRVxV = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 53);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a ElectroHogar SA";
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(320, 112);
            btnVenta.Margin = new Padding(6);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(176, 34);
            btnVenta.TabIndex = 5;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(320, 158);
            btnAgregarCliente.Margin = new Padding(6);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(176, 34);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(320, 204);
            btnModificarCliente.Margin = new Padding(6);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(176, 34);
            btnModificarCliente.TabIndex = 7;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnRVxV
            // 
            btnRVxV.Location = new Point(320, 250);
            btnRVxV.Margin = new Padding(6);
            btnRVxV.Name = "btnRVxV";
            btnRVxV.Size = new Size(176, 34);
            btnRVxV.TabIndex = 8;
            btnRVxV.Text = "Reporte Ventas por Vendedor";
            btnRVxV.UseVisualStyleBackColor = true;
            btnRVxV.Click += btnRVxV_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(320, 296);
            btnCerrarSesion.Margin = new Padding(6);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 34);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRVxV);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnVenta);
            Controls.Add(label1);
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVenta;
        private Button btnAgregarCliente;
        private Button btnModificarCliente;
        private Button btnRVxV;
        private Button btnCerrarSesion;
    }
}