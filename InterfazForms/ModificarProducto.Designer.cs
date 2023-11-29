namespace InterfazForms
{
    partial class ModificarProducto
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbNuevoPrecio = new TextBox();
            txbNuevoStock = new TextBox();
            txbNuevoEstado = new TextBox();
            txbIDProducto = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 98);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 19;
            label1.Text = "Ingrese ID del producto a modificar: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 185);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 20;
            label2.Text = "Ingrese nuevo Precio: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 230);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 21;
            label3.Text = "Ingrese nuevo Stock: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 277);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 22;
            label4.Text = "Ingrese nuevo Estado: ";
            // 
            // txbNuevoPrecio
            // 
            txbNuevoPrecio.Location = new Point(399, 180);
            txbNuevoPrecio.Name = "txbNuevoPrecio";
            txbNuevoPrecio.Size = new Size(100, 23);
            txbNuevoPrecio.TabIndex = 23;
            txbNuevoPrecio.TextChanged += textBox1_TextChanged;
            // 
            // txbNuevoStock
            // 
            txbNuevoStock.Location = new Point(399, 225);
            txbNuevoStock.Name = "txbNuevoStock";
            txbNuevoStock.Size = new Size(100, 23);
            txbNuevoStock.TabIndex = 24;
            // 
            // txbNuevoEstado
            // 
            txbNuevoEstado.Location = new Point(399, 272);
            txbNuevoEstado.Name = "txbNuevoEstado";
            txbNuevoEstado.Size = new Size(100, 23);
            txbNuevoEstado.TabIndex = 25;
            // 
            // txbIDProducto
            // 
            txbIDProducto.Location = new Point(399, 94);
            txbIDProducto.Name = "txbIDProducto";
            txbIDProducto.Size = new Size(180, 23);
            txbIDProducto.TabIndex = 26;
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbIDProducto);
            Controls.Add(txbNuevoEstado);
            Controls.Add(txbNuevoStock);
            Controls.Add(txbNuevoPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ModificarProducto";
            Text = "ModificarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbNuevoPrecio;
        private TextBox txbNuevoStock;
        private TextBox txbNuevoEstado;
        private TextBox txbIDProducto;
    }
}