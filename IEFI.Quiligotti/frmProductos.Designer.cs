namespace IEFI.Quiligotti
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.lblProdTitulo = new System.Windows.Forms.Label();
            this.gbCargarProductos = new System.Windows.Forms.GroupBox();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.lblCantP = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.dtpFechaCargado = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtProductoCargado = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnVerListadoP = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbCargarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdTitulo
            // 
            this.lblProdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitulo.Location = new System.Drawing.Point(349, 92);
            this.lblProdTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdTitulo.Name = "lblProdTitulo";
            this.lblProdTitulo.Size = new System.Drawing.Size(352, 83);
            this.lblProdTitulo.TabIndex = 1;
            this.lblProdTitulo.Text = "Productos";
            // 
            // gbCargarProductos
            // 
            this.gbCargarProductos.Controls.Add(this.txtCantP);
            this.gbCargarProductos.Controls.Add(this.lblCantP);
            this.gbCargarProductos.Controls.Add(this.btnCargarProducto);
            this.gbCargarProductos.Controls.Add(this.dtpFechaCargado);
            this.gbCargarProductos.Controls.Add(this.lblFechaRegistro);
            this.gbCargarProductos.Controls.Add(this.txtProductoCargado);
            this.gbCargarProductos.Controls.Add(this.lblNombreProducto);
            this.gbCargarProductos.Location = new System.Drawing.Point(66, 265);
            this.gbCargarProductos.Margin = new System.Windows.Forms.Padding(6);
            this.gbCargarProductos.Name = "gbCargarProductos";
            this.gbCargarProductos.Padding = new System.Windows.Forms.Padding(6);
            this.gbCargarProductos.Size = new System.Drawing.Size(524, 519);
            this.gbCargarProductos.TabIndex = 3;
            this.gbCargarProductos.TabStop = false;
            this.gbCargarProductos.Text = "Cargar Productos";
            // 
            // txtCantP
            // 
            this.txtCantP.Location = new System.Drawing.Point(165, 328);
            this.txtCantP.Margin = new System.Windows.Forms.Padding(6);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(62, 31);
            this.txtCantP.TabIndex = 6;
            this.txtCantP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCantP
            // 
            this.lblCantP.AutoSize = true;
            this.lblCantP.Location = new System.Drawing.Point(37, 328);
            this.lblCantP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantP.Name = "lblCantP";
            this.lblCantP.Size = new System.Drawing.Size(98, 25);
            this.lblCantP.TabIndex = 5;
            this.lblCantP.Text = "Cantidad";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(100, 428);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(268, 44);
            this.btnCargarProducto.TabIndex = 4;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // dtpFechaCargado
            // 
            this.dtpFechaCargado.Location = new System.Drawing.Point(42, 227);
            this.dtpFechaCargado.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaCargado.Name = "dtpFechaCargado";
            this.dtpFechaCargado.Size = new System.Drawing.Size(392, 31);
            this.dtpFechaCargado.TabIndex = 3;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(36, 177);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(191, 25);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha De Registro";
            // 
            // txtProductoCargado
            // 
            this.txtProductoCargado.Location = new System.Drawing.Point(42, 90);
            this.txtProductoCargado.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductoCargado.Name = "txtProductoCargado";
            this.txtProductoCargado.Size = new System.Drawing.Size(392, 31);
            this.txtProductoCargado.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(36, 58);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(217, 25);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Del Producto";
            // 
            // btnVerListadoP
            // 
            this.btnVerListadoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListadoP.Location = new System.Drawing.Point(138, 861);
            this.btnVerListadoP.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerListadoP.Name = "btnVerListadoP";
            this.btnVerListadoP.Size = new System.Drawing.Size(286, 67);
            this.btnVerListadoP.TabIndex = 6;
            this.btnVerListadoP.Text = "Ver Listado";
            this.btnVerListadoP.UseVisualStyleBackColor = true;
            this.btnVerListadoP.Click += new System.EventHandler(this.btnVerListadoP_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IEFI.Quiligotti.Properties.Resources.product;
            this.pictureBox2.Location = new System.Drawing.Point(49, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 1031);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVerListadoP);
            this.Controls.Add(this.gbCargarProductos);
            this.Controls.Add(this.lblProdTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbCargarProductos.ResumeLayout(false);
            this.gbCargarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProdTitulo;
        private System.Windows.Forms.GroupBox gbCargarProductos;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaCargado;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtProductoCargado;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnVerListadoP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCantP;
        private System.Windows.Forms.Label lblCantP;
    }
}