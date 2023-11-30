namespace InterfazForms
{
    partial class Venta
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
            label3 = new Label();
            label4 = new Label();
            txbIDCliente = new TextBox();
            txbIDProducto = new TextBox();
            txbCantidad = new TextBox();
            label5 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            txbIDUsuario = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 123);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresar ID Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 212);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingresar ID Producto: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 253);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Ingresar cantidad: ";
            // 
            // txbIDCliente
            // 
            txbIDCliente.Location = new Point(298, 119);
            txbIDCliente.Name = "txbIDCliente";
            txbIDCliente.Size = new Size(260, 23);
            txbIDCliente.TabIndex = 4;
            // 
            // txbIDProducto
            // 
            txbIDProducto.Location = new Point(298, 208);
            txbIDProducto.Name = "txbIDProducto";
            txbIDProducto.Size = new Size(260, 23);
            txbIDProducto.TabIndex = 6;
            // 
            // txbCantidad
            // 
            txbCantidad.Location = new Point(298, 250);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(35, 23);
            txbCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 8;
            label5.Text = "Registrar Venta";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(632, 415);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 169);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresar ID Usuario: ";
            // 
            // txbIDUsuario
            // 
            txbIDUsuario.Location = new Point(298, 165);
            txbIDUsuario.Name = "txbIDUsuario";
            txbIDUsuario.Size = new Size(260, 23);
            txbIDUsuario.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(342, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 39);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(txbCantidad);
            Controls.Add(txbIDProducto);
            Controls.Add(txbIDUsuario);
            Controls.Add(txbIDCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Venta";
            Text = "Venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txbIDCliente;
        private TextBox txbIDProducto;
        private TextBox txbCantidad;
        private Label label5;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txbIDUsuario;
        private Button btnAgregar;
    }
}