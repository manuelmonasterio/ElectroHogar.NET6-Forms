namespace InterfazForms
{
    partial class AltaUsuarioProveedor
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txbCUIT = new TextBox();
            txbMail = new TextBox();
            txbApellido = new TextBox();
            txbNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblAltaUsuario = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 49;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txbCUIT
            // 
            txbCUIT.Location = new Point(363, 242);
            txbCUIT.Name = "txbCUIT";
            txbCUIT.Size = new Size(166, 23);
            txbCUIT.TabIndex = 45;
            // 
            // txbMail
            // 
            txbMail.Location = new Point(363, 208);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(166, 23);
            txbMail.TabIndex = 44;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(363, 175);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(166, 23);
            txbApellido.TabIndex = 41;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(363, 144);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(166, 23);
            txbNombre.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(263, 246);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 35;
            label8.Text = "Ingrese su CUIT: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 214);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 31;
            label7.Text = "Ingrese un mail: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 182);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 30;
            label4.Text = "Ingrese el apellido: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 150);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 29;
            label3.Text = "Ingrese el nombre: ";
            // 
            // lblAltaUsuario
            // 
            lblAltaUsuario.AutoSize = true;
            lblAltaUsuario.Location = new Point(44, 34);
            lblAltaUsuario.Name = "lblAltaUsuario";
            lblAltaUsuario.Size = new Size(122, 15);
            lblAltaUsuario.TabIndex = 26;
            lblAltaUsuario.Text = "Dar de Alta Proveedor";
            // 
            // AltaUsuarioProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txbCUIT);
            Controls.Add(txbMail);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAltaUsuario);
            Name = "AltaUsuarioProveedor";
            Text = "AltaUsuarioProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txbCUIT;
        private TextBox txbMail;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label lblAltaUsuario;
    }
}