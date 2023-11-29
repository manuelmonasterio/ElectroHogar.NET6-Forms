namespace InterfazForms
{
    partial class BajaUsuario
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
            btnDarBaja = new Button();
            txbIDUsuario = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(351, 204);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(75, 23);
            btnDarBaja.TabIndex = 17;
            btnDarBaja.Text = "Dar Baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // txbIDUsuario
            // 
            txbIDUsuario.Location = new Point(396, 157);
            txbIDUsuario.Name = "txbIDUsuario";
            txbIDUsuario.Size = new Size(248, 23);
            txbIDUsuario.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 161);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 15;
            label1.Text = "Ingresar el ID del usuario a dar de baja: ";
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
            // BajaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnDarBaja);
            Controls.Add(txbIDUsuario);
            Controls.Add(label1);
            Name = "BajaUsuario";
            Text = "BajaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDarBaja;
        private TextBox txbIDUsuario;
        private Label label1;
        private Button btnCancelar;
    }
}