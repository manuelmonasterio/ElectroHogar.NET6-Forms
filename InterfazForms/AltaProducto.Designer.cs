namespace InterfazForms
{
    partial class AltaProducto
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
            lblAltaUsuario = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txbNombre = new TextBox();
            txbPrecio = new TextBox();
            txbStock = new TextBox();
            txbCat = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblAltaUsuario
            // 
            lblAltaUsuario.AutoSize = true;
            lblAltaUsuario.Location = new Point(12, 9);
            lblAltaUsuario.Name = "lblAltaUsuario";
            lblAltaUsuario.Size = new Size(115, 15);
            lblAltaUsuario.TabIndex = 1;
            lblAltaUsuario.Text = "Dar de alta Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 218);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingrese el Stock: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 267);
            label4.Name = "label4";
            label4.Size = new Size(200, 15);
            label4.TabIndex = 5;
            label4.Text = "Ingrese el ID categoria del producto: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 128);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 171);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el Precio: ";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(392, 124);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 8;
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(392, 167);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(100, 23);
            txbPrecio.TabIndex = 9;
            // 
            // txbStock
            // 
            txbStock.Location = new Point(392, 215);
            txbStock.Name = "txbStock";
            txbStock.Size = new Size(100, 23);
            txbStock.TabIndex = 10;
            // 
            // txbCat
            // 
            txbCat.Location = new Point(392, 264);
            txbCat.Name = "txbCat";
            txbCat.Size = new Size(100, 23);
            txbCat.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txbCat);
            Controls.Add(txbStock);
            Controls.Add(txbPrecio);
            Controls.Add(txbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAltaUsuario);
            Name = "AltaProducto";
            Text = "AltaProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaUsuario;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txbNombre;
        private TextBox txbPrecio;
        private TextBox txbStock;
        private TextBox txbCat;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}