﻿namespace InterfazForms
{
    partial class BajaUsuarioProveedor
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
            txbIDProveedor = new TextBox();
            btnDarBaja = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 174);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 20;
            label1.Text = "Ingresar el ID del proveedor a dar de baja: ";
            // 
            // txbIDProveedor
            // 
            txbIDProveedor.Location = new Point(393, 170);
            txbIDProveedor.Name = "txbIDProveedor";
            txbIDProveedor.Size = new Size(227, 23);
            txbIDProveedor.TabIndex = 21;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(352, 224);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(75, 23);
            btnDarBaja.TabIndex = 22;
            btnDarBaja.Text = "Dar Baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // BajaUsuarioProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDarBaja);
            Controls.Add(txbIDProveedor);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "BajaUsuarioProveedor";
            Text = "BajaUsuarioProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label1;
        private TextBox txbIDProveedor;
        private Button btnDarBaja;
    }
}