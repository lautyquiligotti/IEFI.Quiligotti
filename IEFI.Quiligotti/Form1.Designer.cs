namespace IEFI.Quiligotti
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCargaProductos = new System.Windows.Forms.Button();
            this.btnCargaVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(99, 62);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(157, 35);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // btnCargaProductos
            // 
            this.btnCargaProductos.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaProductos.Location = new System.Drawing.Point(24, 149);
            this.btnCargaProductos.Name = "btnCargaProductos";
            this.btnCargaProductos.Size = new System.Drawing.Size(140, 43);
            this.btnCargaProductos.TabIndex = 1;
            this.btnCargaProductos.Text = "Carga De Productos";
            this.btnCargaProductos.UseVisualStyleBackColor = true;
            // 
            // btnCargaVentas
            // 
            this.btnCargaVentas.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaVentas.Location = new System.Drawing.Point(192, 149);
            this.btnCargaVentas.Name = "btnCargaVentas";
            this.btnCargaVentas.Size = new System.Drawing.Size(135, 43);
            this.btnCargaVentas.TabIndex = 2;
            this.btnCargaVentas.Text = "Carga De Ventas";
            this.btnCargaVentas.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 249);
            this.Controls.Add(this.btnCargaVentas);
            this.Controls.Add(this.btnCargaProductos);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCargaProductos;
        private System.Windows.Forms.Button btnCargaVentas;
    }
}

