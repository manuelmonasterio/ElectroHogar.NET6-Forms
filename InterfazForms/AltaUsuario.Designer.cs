namespace InterfazForms
{
    partial class AltaUsuario
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
            lblAltaUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txbPerfil = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            txbDireccion = new TextBox();
            txbTelefono = new TextBox();
            txbMail = new TextBox();
            txbFecNac = new TextBox();
            txbNombreUsuario = new TextBox();
            txbDNI = new TextBox();
            txbContrasena2 = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblAltaUsuario
            // 
            lblAltaUsuario.AutoSize = true;
            lblAltaUsuario.Location = new Point(12, 9);
            lblAltaUsuario.Name = "lblAltaUsuario";
            lblAltaUsuario.Size = new Size(108, 15);
            lblAltaUsuario.TabIndex = 0;
            lblAltaUsuario.Text = "Dar de Alta Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(359, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el número de perfil correspondiente para el nuevo usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 60);
            label2.Name = "label2";
            label2.Size = new Size(127, 45);
            label2.TabIndex = 2;
            label2.Text = "1- Perfil Administrador\r\n2- Perfil Supervisor\r\n3- Perfil Vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 126);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 158);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 4;
            label4.Text = "Ingrese el apellido: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 188);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 7;
            label5.Text = "Ingrese una dirección: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 215);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 6;
            label6.Text = "Ingrese un teléfono: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 244);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 5;
            label7.Text = "Ingrese un mail: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 273);
            label8.Name = "label8";
            label8.Size = new Size(177, 15);
            label8.TabIndex = 9;
            label8.Text = "Ingrese su fecha de nacimiento: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 301);
            label9.Name = "label9";
            label9.Size = new Size(600, 15);
            label9.TabIndex = 8;
            label9.Text = "El Nombre de Usuario debe tener entre 8 a 15 caracteres y no debe tener su nombre ni apellido dentro del mismo";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txbPerfil
            // 
            txbPerfil.Location = new Point(377, 66);
            txbPerfil.Name = "txbPerfil";
            txbPerfil.Size = new Size(30, 23);
            txbPerfil.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 330);
            label10.Name = "label10";
            label10.Size = new Size(154, 15);
            label10.TabIndex = 12;
            label10.Text = "Ingrese nombre de usuario: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(293, 358);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 13;
            label11.Text = "Ingrese DNI: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(240, 385);
            label12.Name = "label12";
            label12.Size = new Size(127, 15);
            label12.TabIndex = 14;
            label12.Text = "Ingrese su contraseña: ";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(377, 120);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(166, 23);
            txbNombre.TabIndex = 15;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(377, 151);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(166, 23);
            txbApellido.TabIndex = 16;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(377, 183);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(166, 23);
            txbDireccion.TabIndex = 17;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(377, 212);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(166, 23);
            txbTelefono.TabIndex = 18;
            // 
            // txbMail
            // 
            txbMail.Location = new Point(377, 241);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(166, 23);
            txbMail.TabIndex = 19;
            // 
            // txbFecNac
            // 
            txbFecNac.Location = new Point(377, 270);
            txbFecNac.Name = "txbFecNac";
            txbFecNac.Size = new Size(166, 23);
            txbFecNac.TabIndex = 20;
            // 
            // txbNombreUsuario
            // 
            txbNombreUsuario.Location = new Point(377, 325);
            txbNombreUsuario.Name = "txbNombreUsuario";
            txbNombreUsuario.Size = new Size(166, 23);
            txbNombreUsuario.TabIndex = 21;
            // 
            // txbDNI
            // 
            txbDNI.Location = new Point(377, 353);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(166, 23);
            txbDNI.TabIndex = 22;
            // 
            // txbContrasena2
            // 
            txbContrasena2.Location = new Point(377, 382);
            txbContrasena2.Name = "txbContrasena2";
            txbContrasena2.Size = new Size(166, 23);
            txbContrasena2.TabIndex = 23;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(591, 456);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(672, 456);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 491);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txbContrasena2);
            Controls.Add(txbDNI);
            Controls.Add(txbNombreUsuario);
            Controls.Add(txbFecNac);
            Controls.Add(txbMail);
            Controls.Add(txbTelefono);
            Controls.Add(txbDireccion);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txbPerfil);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAltaUsuario);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txbPerfil;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private TextBox txbDireccion;
        private TextBox txbTelefono;
        private TextBox txbMail;
        private TextBox txbFecNac;
        private TextBox txbNombreUsuario;
        private TextBox txbDNI;
        private TextBox txbContrasena2;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}