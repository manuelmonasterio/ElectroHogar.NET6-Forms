namespace InterfazForms
{
    partial class Reportes
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
            btnVentasxVendedor = new Button();
            btnProdxCat = new Button();
            btnStockCritico = new Button();
            btnVolver = new Button();
            btnSCLogica = new Button();
            btnPxCLogica = new Button();
            btnVxVLogica = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnVentasxVendedor
            // 
            btnVentasxVendedor.Location = new Point(207, 126);
            btnVentasxVendedor.Name = "btnVentasxVendedor";
            btnVentasxVendedor.Size = new Size(175, 40);
            btnVentasxVendedor.TabIndex = 1;
            btnVentasxVendedor.Text = "Ventas por Vendedor";
            btnVentasxVendedor.UseVisualStyleBackColor = true;
            btnVentasxVendedor.Click += btnVentasxVendedor_Click;
            // 
            // btnProdxCat
            // 
            btnProdxCat.Location = new Point(207, 172);
            btnProdxCat.Name = "btnProdxCat";
            btnProdxCat.Size = new Size(175, 40);
            btnProdxCat.TabIndex = 2;
            btnProdxCat.Text = "Productos más vendidos por Categoría";
            btnProdxCat.UseVisualStyleBackColor = true;
            btnProdxCat.Click += btnProdxCat_Click;
            // 
            // btnStockCritico
            // 
            btnStockCritico.Location = new Point(207, 218);
            btnStockCritico.Name = "btnStockCritico";
            btnStockCritico.Size = new Size(175, 40);
            btnStockCritico.TabIndex = 3;
            btnStockCritico.Text = "Stock Crítico";
            btnStockCritico.UseVisualStyleBackColor = true;
            btnStockCritico.Click += btnStockCritico_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(301, 275);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(175, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver al menú anterior";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSCLogica
            // 
            btnSCLogica.Location = new Point(398, 218);
            btnSCLogica.Name = "btnSCLogica";
            btnSCLogica.Size = new Size(175, 40);
            btnSCLogica.TabIndex = 5;
            btnSCLogica.Text = "Stock Crítico";
            btnSCLogica.UseVisualStyleBackColor = true;
            // 
            // btnPxCLogica
            // 
            btnPxCLogica.Location = new Point(398, 172);
            btnPxCLogica.Name = "btnPxCLogica";
            btnPxCLogica.Size = new Size(175, 40);
            btnPxCLogica.TabIndex = 7;
            btnPxCLogica.Text = "Productos más vendidos por Categoría";
            btnPxCLogica.UseVisualStyleBackColor = true;
            // 
            // btnVxVLogica
            // 
            btnVxVLogica.Location = new Point(398, 126);
            btnVxVLogica.Name = "btnVxVLogica";
            btnVxVLogica.Size = new Size(175, 40);
            btnVxVLogica.TabIndex = 6;
            btnVxVLogica.Text = "Ventas por Vendedor";
            btnVxVLogica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 90);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Ficticio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Lógica";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPxCLogica);
            Controls.Add(btnVxVLogica);
            Controls.Add(btnSCLogica);
            Controls.Add(btnVolver);
            Controls.Add(btnStockCritico);
            Controls.Add(btnProdxCat);
            Controls.Add(btnVentasxVendedor);
            Name = "Reportes";
            Text = "Reportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVentasxVendedor;
        private Button btnProdxCat;
        private Button btnStockCritico;
        private Button btnVolver;
        private Button btnSCLogica;
        private Button btnPxCLogica;
        private Button btnVxVLogica;
        private Label label1;
        private Label label2;
    }
}