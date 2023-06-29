namespace IEFI.Quiligotti
{
    partial class frmVentas
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
            this.lblVentasTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCargarVentas = new System.Windows.Forms.GroupBox();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtProductoVendido = new System.Windows.Forms.TextBox();
            this.lblProductoVendido = new System.Windows.Forms.Label();
            this.gbConsultarProductos = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCatidad = new System.Windows.Forms.RadioButton();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboConsultarProducto = new System.Windows.Forms.ComboBox();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gbCargarVentas.SuspendLayout();
            this.gbConsultarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentasTitulo
            // 
            this.lblVentasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTitulo.Location = new System.Drawing.Point(560, 67);
            this.lblVentasTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVentasTitulo.Name = "lblVentasTitulo";
            this.lblVentasTitulo.Size = new System.Drawing.Size(262, 83);
            this.lblVentasTitulo.TabIndex = 0;
            this.lblVentasTitulo.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbCargarVentas
            // 
            this.gbCargarVentas.Controls.Add(this.txtCantidad);
            this.gbCargarVentas.Controls.Add(this.lblCantidad);
            this.gbCargarVentas.Controls.Add(this.btnCargarVenta);
            this.gbCargarVentas.Controls.Add(this.dtpFechaVenta);
            this.gbCargarVentas.Controls.Add(this.lblFechaVenta);
            this.gbCargarVentas.Controls.Add(this.txtProductoVendido);
            this.gbCargarVentas.Controls.Add(this.lblProductoVendido);
            this.gbCargarVentas.Location = new System.Drawing.Point(68, 200);
            this.gbCargarVentas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbCargarVentas.Name = "gbCargarVentas";
            this.gbCargarVentas.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbCargarVentas.Size = new System.Drawing.Size(524, 563);
            this.gbCargarVentas.TabIndex = 2;
            this.gbCargarVentas.TabStop = false;
            this.gbCargarVentas.Text = "Cargar Ventas";
            this.gbCargarVentas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.Location = new System.Drawing.Point(75, 457);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(268, 44);
            this.btnCargarVenta.TabIndex = 4;
            this.btnCargarVenta.Text = "Cargar Venta";
            this.btnCargarVenta.UseVisualStyleBackColor = true;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(42, 227);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(392, 31);
            this.dtpFechaVenta.TabIndex = 3;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(36, 177);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(167, 25);
            this.lblFechaVenta.TabIndex = 2;
            this.lblFechaVenta.Text = "Fecha De Venta";
            // 
            // txtProductoVendido
            // 
            this.txtProductoVendido.Location = new System.Drawing.Point(42, 90);
            this.txtProductoVendido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductoVendido.Name = "txtProductoVendido";
            this.txtProductoVendido.Size = new System.Drawing.Size(392, 31);
            this.txtProductoVendido.TabIndex = 1;
            this.txtProductoVendido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProductoVendido
            // 
            this.lblProductoVendido.AutoSize = true;
            this.lblProductoVendido.Location = new System.Drawing.Point(36, 58);
            this.lblProductoVendido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductoVendido.Name = "lblProductoVendido";
            this.lblProductoVendido.Size = new System.Drawing.Size(189, 25);
            this.lblProductoVendido.TabIndex = 0;
            this.lblProductoVendido.Text = "Producto Vendido:";
            // 
            // gbConsultarProductos
            // 
            this.gbConsultarProductos.Controls.Add(this.btnFiltrar);
            this.gbConsultarProductos.Controls.Add(this.txtFiltrar);
            this.gbConsultarProductos.Controls.Add(this.lblFiltrar);
            this.gbConsultarProductos.Controls.Add(this.optProducto);
            this.gbConsultarProductos.Controls.Add(this.optCatidad);
            this.gbConsultarProductos.Controls.Add(this.lvProductos);
            this.gbConsultarProductos.Controls.Add(this.cboConsultarProducto);
            this.gbConsultarProductos.Location = new System.Drawing.Point(730, 200);
            this.gbConsultarProductos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbConsultarProductos.Name = "gbConsultarProductos";
            this.gbConsultarProductos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbConsultarProductos.Size = new System.Drawing.Size(650, 517);
            this.gbConsultarProductos.TabIndex = 3;
            this.gbConsultarProductos.TabStop = false;
            this.gbConsultarProductos.Text = "Consultar Productos";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(214, 444);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 44);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(146, 394);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(276, 31);
            this.txtFiltrar.TabIndex = 18;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(238, 304);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(73, 25);
            this.lblFiltrar.TabIndex = 17;
            this.lblFiltrar.Text = "Filtrar:";
            this.lblFiltrar.Click += new System.EventHandler(this.label5_Click);
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Location = new System.Drawing.Point(308, 350);
            this.optProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(129, 29);
            this.optProducto.TabIndex = 16;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // optCatidad
            // 
            this.optCatidad.AutoSize = true;
            this.optCatidad.Location = new System.Drawing.Point(118, 350);
            this.optCatidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optCatidad.Name = "optCatidad";
            this.optCatidad.Size = new System.Drawing.Size(129, 29);
            this.optCatidad.TabIndex = 15;
            this.optCatidad.TabStop = true;
            this.optCatidad.Text = "Cantidad";
            this.optCatidad.UseVisualStyleBackColor = true;
            this.optCatidad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnFechaVenta});
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(36, 117);
            this.lvProductos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(546, 144);
            this.lvProductos.TabIndex = 14;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 25;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 145;
            // 
            // columnFechaVenta
            // 
            this.columnFechaVenta.Text = "Fecha de Venta";
            this.columnFechaVenta.Width = 180;
            // 
            // cboConsultarProducto
            // 
            this.cboConsultarProducto.FormattingEnabled = true;
            this.cboConsultarProducto.Location = new System.Drawing.Point(166, 58);
            this.cboConsultarProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboConsultarProducto.Name = "cboConsultarProducto";
            this.cboConsultarProducto.Size = new System.Drawing.Size(274, 33);
            this.cboConsultarProducto.TabIndex = 0;
            // 
            // btnVerListado
            // 
            this.btnVerListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListado.Location = new System.Drawing.Point(640, 754);
            this.btnVerListado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(286, 67);
            this.btnVerListado.TabIndex = 5;
            this.btnVerListado.Text = "Ver Listado";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IEFI.Quiligotti.Properties.Resources.ventas2;
            this.pictureBox3.Location = new System.Drawing.Point(302, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 352);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 25);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(185, 350);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 31);
            this.txtCantidad.TabIndex = 6;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnVerListado);
            this.Controls.Add(this.gbConsultarProductos);
            this.Controls.Add(this.gbCargarVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVentasTitulo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbCargarVentas.ResumeLayout(false);
            this.gbCargarVentas.PerformLayout();
            this.gbConsultarProductos.ResumeLayout(false);
            this.gbConsultarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVentasTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCargarVentas;
        private System.Windows.Forms.TextBox txtProductoVendido;
        private System.Windows.Forms.Label lblProductoVendido;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.GroupBox gbConsultarProductos;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnFechaVenta;
        private System.Windows.Forms.ComboBox cboConsultarProducto;
        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton optCatidad;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}