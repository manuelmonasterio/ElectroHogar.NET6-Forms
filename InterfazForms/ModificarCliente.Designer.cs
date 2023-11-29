namespace InterfazForms
{
    partial class ModificarCliente
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
            txbIDCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbModDireccion = new TextBox();
            txbModTelefono = new TextBox();
            txbEmail = new TextBox();
            txbEstado = new TextBox();
            label6 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 67);
            label1.Name = "label1";
            label1.Size = new Size(313, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID del cliente a buscar para modificar sus datos: ";
            // 
            // txbIDCliente
            // 
            txbIDCliente.Location = new Point(389, 63);
            txbIDCliente.Name = "txbIDCliente";
            txbIDCliente.Size = new Size(291, 23);
            txbIDCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 166);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Modificar Dirección: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 209);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Modificar Teléfono: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 257);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "Modificar Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 305);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 5;
            label5.Text = "Modificar Estado: ";
            // 
            // txbModDireccion
            // 
            txbModDireccion.Location = new Point(389, 162);
            txbModDireccion.Name = "txbModDireccion";
            txbModDireccion.Size = new Size(156, 23);
            txbModDireccion.TabIndex = 6;
            // 
            // txbModTelefono
            // 
            txbModTelefono.Location = new Point(389, 205);
            txbModTelefono.Name = "txbModTelefono";
            txbModTelefono.Size = new Size(156, 23);
            txbModTelefono.TabIndex = 7;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(389, 256);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(156, 23);
            txbEmail.TabIndex = 8;
            // 
            // txbEstado
            // 
            txbEstado.Location = new Point(389, 301);
            txbEstado.Name = "txbEstado";
            txbEstado.Size = new Size(156, 23);
            txbEstado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(281, 127);
            label6.Name = "label6";
            label6.Size = new Size(246, 15);
            label6.TabIndex = 10;
            label6.Text = "Ingrese únicamente los campos a modificar";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(txbEstado);
            Controls.Add(txbEmail);
            Controls.Add(txbModTelefono);
            Controls.Add(txbModDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbIDCliente);
            Controls.Add(label1);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIDCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbModDireccion;
        private TextBox txbModTelefono;
        private TextBox txbEmail;
        private TextBox txbEstado;
        private Label label6;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}