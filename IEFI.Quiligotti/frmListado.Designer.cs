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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.lblListadoTitulo = new System.Windows.Forms.Label();
            this.dtvMatrizProd = new System.Windows.Forms.DataGridView();
            this.columnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtvMatrizVenta = new System.Windows.Forms.DataGridView();
            this.columnFechaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProdV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblListVenta = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelecc = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dtvMatrizProd.Location = new System.Drawing.Point(26, 306);
            this.dtvMatrizProd.Name = "dtvMatrizProd";
            this.dtvMatrizProd.RowHeadersWidth = 82;
            this.dtvMatrizProd.RowTemplate.Height = 33;
            this.dtvMatrizProd.Size = new System.Drawing.Size(736, 589);
            this.dtvMatrizProd.TabIndex = 3;
            this.dtvMatrizProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMatrizProd_CellContentClick);
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
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1303, 987);
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
            this.btnMostrar.Location = new System.Drawing.Point(195, 987);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(339, 57);
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
            this.dtvMatrizVenta.Location = new System.Drawing.Point(840, 306);
            this.dtvMatrizVenta.Name = "dtvMatrizVenta";
            this.dtvMatrizVenta.RowHeadersWidth = 82;
            this.dtvMatrizVenta.RowTemplate.Height = 33;
            this.dtvMatrizVenta.Size = new System.Drawing.Size(812, 589);
            this.dtvMatrizVenta.TabIndex = 8;
            this.dtvMatrizVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMatrizVenta_CellContentClick);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(868, 987);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblListVenta
            // 
            this.lblListVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListVenta.Location = new System.Drawing.Point(994, 219);
            this.lblListVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListVenta.Name = "lblListVenta";
            this.lblListVenta.Size = new System.Drawing.Size(282, 65);
            this.lblListVenta.TabIndex = 10;
            this.lblListVenta.Text = "Ventas";
            // 
            // lblProd
            // 
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(207, 219);
            this.lblProd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(349, 65);
            this.lblProd.TabIndex = 11;
            this.lblProd.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IEFI.Quiligotti.Properties.Resources.listado;
            this.pictureBox1.Location = new System.Drawing.Point(415, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelecc
            // 
            this.lblSelecc.AutoSize = true;
            this.lblSelecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecc.Location = new System.Drawing.Point(749, 109);
            this.lblSelecc.Name = "lblSelecc";
            this.lblSelecc.Size = new System.Drawing.Size(300, 31);
            this.lblSelecc.TabIndex = 13;
            this.lblSelecc.Text = "Seleccione un Producto";
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(1088, 112);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(293, 33);
            this.lstProducto.TabIndex = 16;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1676, 1119);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.lblSelecc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblListVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvMatrizVenta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtvMatrizProd);
            this.Controls.Add(this.lblListadoTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatrizVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoTitulo;
        private System.Windows.Forms.DataGridView dtvMatrizProd;
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
        private System.Windows.Forms.Label lblListVenta;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelecc;
        private System.Windows.Forms.ComboBox lstProducto;
    }
}