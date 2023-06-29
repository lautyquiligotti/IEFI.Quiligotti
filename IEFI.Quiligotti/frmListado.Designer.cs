namespace IEFI.Quiligotti
{
    partial class frmListado
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
            this.lblListadoTitulo = new System.Windows.Forms.Label();
            this.dtvMatrizProd = new System.Windows.Forms.DataGridView();
            this.btnVolverProductos = new System.Windows.Forms.Button();
            this.btnVolverVentas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtvMatrizVenta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnFechaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProdV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoTitulo
            // 
            this.lblListadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoTitulo.Location = new System.Drawing.Point(88, 51);
            this.lblListadoTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListadoTitulo.Name = "lblListadoTitulo";
            this.lblListadoTitulo.Size = new System.Drawing.Size(282, 65);
            this.lblListadoTitulo.TabIndex = 2;
            this.lblListadoTitulo.Text = "Listado";
            // 
            // dtvMatrizProd
            // 
            this.dtvMatrizProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMatrizProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFecha,
            this.ColumnNombre,
            this.ColumnCantidad});
            this.dtvMatrizProd.Location = new System.Drawing.Point(46, 135);
            this.dtvMatrizProd.Name = "dtvMatrizProd";
            this.dtvMatrizProd.RowHeadersWidth = 82;
            this.dtvMatrizProd.RowTemplate.Height = 33;
            this.dtvMatrizProd.Size = new System.Drawing.Size(1438, 265);
            this.dtvMatrizProd.TabIndex = 3;
            this.dtvMatrizProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMatrizProd_CellContentClick);
            // 
            // btnVolverProductos
            // 
            this.btnVolverProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverProductos.Location = new System.Drawing.Point(33, 954);
            this.btnVolverProductos.Name = "btnVolverProductos";
            this.btnVolverProductos.Size = new System.Drawing.Size(281, 57);
            this.btnVolverProductos.TabIndex = 4;
            this.btnVolverProductos.Text = "Volver a Productos";
            this.btnVolverProductos.UseVisualStyleBackColor = true;
            this.btnVolverProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolverVentas
            // 
            this.btnVolverVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVentas.Location = new System.Drawing.Point(366, 954);
            this.btnVolverVentas.Name = "btnVolverVentas";
            this.btnVolverVentas.Size = new System.Drawing.Size(270, 57);
            this.btnVolverVentas.TabIndex = 5;
            this.btnVolverVentas.Text = "Volver a Ventas";
            this.btnVolverVentas.UseVisualStyleBackColor = true;
            this.btnVolverVentas.Click += new System.EventHandler(this.btnVolverVentas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1303, 954);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(212, 57);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(701, 954);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(257, 57);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar Productos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dtvMatrizVenta
            // 
            this.dtvMatrizVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMatrizVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFechaV,
            this.ColumnProdV,
            this.ColumnCantV});
            this.dtvMatrizVenta.Location = new System.Drawing.Point(101, 509);
            this.dtvMatrizVenta.Name = "dtvMatrizVenta";
            this.dtvMatrizVenta.RowHeadersWidth = 82;
            this.dtvMatrizVenta.RowTemplate.Height = 33;
            this.dtvMatrizVenta.Size = new System.Drawing.Size(1383, 274);
            this.dtvMatrizVenta.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 954);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // columnFechaV
            // 
            this.columnFechaV.HeaderText = "Fecha";
            this.columnFechaV.MinimumWidth = 10;
            this.columnFechaV.Name = "columnFechaV";
            this.columnFechaV.Width = 200;
            // 
            // ColumnProdV
            // 
            this.ColumnProdV.HeaderText = "Producto";
            this.ColumnProdV.MinimumWidth = 10;
            this.ColumnProdV.Name = "ColumnProdV";
            this.ColumnProdV.Width = 200;
            // 
            // ColumnCantV
            // 
            this.ColumnCantV.HeaderText = "Cantidad";
            this.ColumnCantV.MinimumWidth = 10;
            this.ColumnCantV.Name = "ColumnCantV";
            this.ColumnCantV.Width = 200;
            // 
            // columnFecha
            // 
            this.columnFecha.HeaderText = "Fecha";
            this.columnFecha.MinimumWidth = 10;
            this.columnFecha.Name = "columnFecha";
            this.columnFecha.Width = 200;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Producto";
            this.ColumnNombre.MinimumWidth = 10;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 200;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MinimumWidth = 10;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 200;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 1119);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvMatrizVenta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolverVentas);
            this.Controls.Add(this.btnVolverProductos);
            this.Controls.Add(this.dtvMatrizProd);
            this.Controls.Add(this.lblListadoTitulo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmListado";
            this.Text = "frmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListadoTitulo;
        private System.Windows.Forms.DataGridView dtvMatrizProd;
        private System.Windows.Forms.Button btnVolverProductos;
        private System.Windows.Forms.Button btnVolverVentas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dtvMatrizVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProdV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantV;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
    }
}