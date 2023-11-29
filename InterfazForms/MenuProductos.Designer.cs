namespace InterfazForms
{
    partial class MenuProductos
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
            btnAltaProducto = new Button();
            btnProducto = new Button();
            btnBajaProducto = new Button();
            btnVolver1 = new Button();
            SuspendLayout();
            // 
            // btnAltaProducto
            // 
            btnAltaProducto.Location = new Point(291, 122);
            btnAltaProducto.Name = "btnAltaProducto";
            btnAltaProducto.Size = new Size(175, 40);
            btnAltaProducto.TabIndex = 5;
            btnAltaProducto.Text = "Alta de Producto";
            btnAltaProducto.UseVisualStyleBackColor = true;
            btnAltaProducto.Click += btnAltaProducto_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(291, 168);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(175, 40);
            btnProducto.TabIndex = 6;
            btnProducto.Text = "Modificar Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnBajaProducto
            // 
            btnBajaProducto.Location = new Point(291, 214);
            btnBajaProducto.Name = "btnBajaProducto";
            btnBajaProducto.Size = new Size(175, 40);
            btnBajaProducto.TabIndex = 7;
            btnBajaProducto.Text = "Baja de Producto";
            btnBajaProducto.UseVisualStyleBackColor = true;
            btnBajaProducto.Click += btnBajaProducto_Click;
            // 
            // btnVolver1
            // 
            btnVolver1.Location = new Point(291, 260);
            btnVolver1.Name = "btnVolver1";
            btnVolver1.Size = new Size(175, 40);
            btnVolver1.TabIndex = 8;
            btnVolver1.Text = "Volver al menú anterior";
            btnVolver1.UseVisualStyleBackColor = true;
            btnVolver1.Click += btnVolver1_Click;
            // 
            // MenuProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver1);
            Controls.Add(btnBajaProducto);
            Controls.Add(btnProducto);
            Controls.Add(btnAltaProducto);
            Name = "MenuProductos";
            Text = "MenuProductos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltaProducto;
        private Button btnProducto;
        private Button btnBajaProducto;
        private Button btnVolver1;
    }
}