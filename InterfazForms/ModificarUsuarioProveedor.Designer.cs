namespace InterfazForms
{
    partial class ModificarUsuarioProveedor
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
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            label1 = new Label();
            txbIDProveedor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txbNuevoNombre = new TextBox();
            txbNuevoApellido = new TextBox();
            txbNuevoCuit = new TextBox();
            txbNuevoMail = new TextBox();
            txbNuevoEstado = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 62);
            label1.Name = "label1";
            label1.Size = new Size(332, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el ID del proveedor a buscar para modificar sus datos: ";
            // 
            // txbIDProveedor
            // 
            txbIDProveedor.Location = new Point(389, 59);
            txbIDProveedor.Name = "txbIDProveedor";
            txbIDProveedor.Size = new Size(249, 23);
            txbIDProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 133);
            label2.Name = "label2";
            label2.Size = new Size(246, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese únicamente los campos a modificar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 174);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Nuevo Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 211);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Nuevo Apellido: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 300);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 7;
            label5.Text = "Nuevo Email: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 255);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Nuevo CUIT: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 343);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 9;
            label7.Text = "Nuevo Estado: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txbNuevoNombre
            // 
            txbNuevoNombre.Location = new Point(389, 171);
            txbNuevoNombre.Name = "txbNuevoNombre";
            txbNuevoNombre.Size = new Size(100, 23);
            txbNuevoNombre.TabIndex = 11;
            // 
            // txbNuevoApellido
            // 
            txbNuevoApellido.Location = new Point(389, 207);
            txbNuevoApellido.Name = "txbNuevoApellido";
            txbNuevoApellido.Size = new Size(100, 23);
            txbNuevoApellido.TabIndex = 12;
            // 
            // txbNuevoCuit
            // 
            txbNuevoCuit.Location = new Point(389, 250);
            txbNuevoCuit.Name = "txbNuevoCuit";
            txbNuevoCuit.Size = new Size(100, 23);
            txbNuevoCuit.TabIndex = 13;
            // 
            // txbNuevoMail
            // 
            txbNuevoMail.Location = new Point(389, 296);
            txbNuevoMail.Name = "txbNuevoMail";
            txbNuevoMail.Size = new Size(100, 23);
            txbNuevoMail.TabIndex = 14;
            // 
            // txbNuevoEstado
            // 
            txbNuevoEstado.Location = new Point(389, 339);
            txbNuevoEstado.Name = "txbNuevoEstado";
            txbNuevoEstado.Size = new Size(100, 23);
            txbNuevoEstado.TabIndex = 15;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // ModificarUsuarioProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(txbNuevoEstado);
            Controls.Add(txbNuevoMail);
            Controls.Add(txbNuevoCuit);
            Controls.Add(txbNuevoApellido);
            Controls.Add(txbNuevoNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbIDProveedor);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "ModificarUsuarioProveedor";
            Text = "ModificarUsuarioProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label1;
        private TextBox txbIDProveedor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txbNuevoNombre;
        private TextBox txbNuevoApellido;
        private TextBox txbNuevoCuit;
        private TextBox txbNuevoMail;
        private TextBox txbNuevoEstado;
        private Button btnAceptar;
    }
}