namespace InterfazForms
{
    partial class ModificarUsuario
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
            label1 = new Label();
            txbIDUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnNuevaContra = new Button();
            btnNuevoEstado = new Button();
            btnDarBaja = new Button();
            txbNuevaContra = new TextBox();
            txbNuevoEstado = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(361, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre del usuario que desea realizar una modificación: ";
            // 
            // txbIDUsuario
            // 
            txbIDUsuario.Location = new Point(379, 39);
            txbIDUsuario.Name = "txbIDUsuario";
            txbIDUsuario.Size = new Size(245, 23);
            txbIDUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 134);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "Modificar Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 160);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingrese nueva contraseña: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(190, 201);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 5;
            label4.Text = "Modificar Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 228);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 6;
            label5.Text = "Ingrese nuevo estado: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(190, 268);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "Baja Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 298);
            label7.Name = "label7";
            label7.Size = new Size(320, 15);
            label7.TabIndex = 8;
            label7.Text = "¿Desea dar de baja el usuario? Por no simplemente cancelar";
            // 
            // btnNuevaContra
            // 
            btnNuevaContra.Location = new Point(500, 157);
            btnNuevaContra.Name = "btnNuevaContra";
            btnNuevaContra.Size = new Size(75, 23);
            btnNuevaContra.TabIndex = 9;
            btnNuevaContra.Text = "Modificar";
            btnNuevaContra.UseVisualStyleBackColor = true;
            // 
            // btnNuevoEstado
            // 
            btnNuevoEstado.Location = new Point(500, 225);
            btnNuevoEstado.Name = "btnNuevoEstado";
            btnNuevoEstado.Size = new Size(75, 23);
            btnNuevoEstado.TabIndex = 10;
            btnNuevoEstado.Text = "Modificar";
            btnNuevoEstado.UseVisualStyleBackColor = true;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(336, 333);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(75, 23);
            btnDarBaja.TabIndex = 11;
            btnDarBaja.Text = "Si";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // txbNuevaContra
            // 
            txbNuevaContra.Location = new Point(379, 156);
            txbNuevaContra.Name = "txbNuevaContra";
            txbNuevaContra.Size = new Size(100, 23);
            txbNuevaContra.TabIndex = 12;
            // 
            // txbNuevoEstado
            // 
            txbNuevoEstado.Location = new Point(379, 224);
            txbNuevoEstado.Name = "txbNuevoEstado";
            txbNuevoEstado.Size = new Size(100, 23);
            txbNuevoEstado.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(653, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar/borrar?";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txbNuevoEstado);
            Controls.Add(txbNuevaContra);
            Controls.Add(btnDarBaja);
            Controls.Add(btnNuevoEstado);
            Controls.Add(btnNuevaContra);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbIDUsuario);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "ModificarUsuario";
            Text = "ModificarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label1;
        private TextBox txbIDUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnNuevaContra;
        private Button btnNuevoEstado;
        private Button btnDarBaja;
        private TextBox txbNuevaContra;
        private TextBox txbNuevoEstado;
        private Button btnBuscar;
    }
}