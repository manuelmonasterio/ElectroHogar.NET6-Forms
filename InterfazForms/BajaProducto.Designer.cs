namespace InterfazForms
{
    partial class BajaProducto
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
            txbIDProducto = new TextBox();
            btnDarBaja = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 158);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID del producto a dar de baja: ";
            // 
            // txbIDProducto
            // 
            txbIDProducto.Location = new Point(406, 154);
            txbIDProducto.Name = "txbIDProducto";
            txbIDProducto.Size = new Size(235, 23);
            txbIDProducto.TabIndex = 1;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(356, 199);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(75, 23);
            btnDarBaja.TabIndex = 2;
            btnDarBaja.Text = "Dar Baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BajaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnDarBaja);
            Controls.Add(txbIDProducto);
            Controls.Add(label1);
            Name = "BajaProducto";
            Text = "BajaProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIDProducto;
        private Button btnDarBaja;
        private Button btnCancelar;
    }
}