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
            this.lblListadoTitulo.Location = new System.Drawing.Point(44, 27);
            this.lblListadoTitulo.Name = "lblListadoTitulo";
            this.lblListadoTitulo.Size = new System.Drawing.Size(141, 34);
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
            this.dtvMatrizProd.Location = new System.Drawing.Point(13, 159);
            this.dtvMatrizProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvMatrizProd.Name = "dtvMatrizProd";
            this.dtvMatrizProd.RowHeadersWidth = 82;
            this.dtvMatrizProd.RowTemplate.Height = 33;
            this.dtvMatrizProd.Size = new System.Drawing.Size(368, 306);
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
            this.btnCerrar.Location = new System.Drawing.Point(652, 513);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 30);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(98, 513);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(170, 30);
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
            this.dtvMatrizVenta.Location = new System.Drawing.Point(420, 159);
            this.dtvMatrizVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvMatrizVenta.Name = "dtvMatrizVenta";
            this.dtvMatrizVenta.RowHeadersWidth = 82;
            this.dtvMatrizVenta.RowTemplate.Height = 33;
            this.dtvMatrizVenta.Size = new System.Drawing.Size(406, 306);
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
            this.button1.Location = new System.Drawing.Point(434, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblListVenta
            // 
            this.lblListVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListVenta.Location = new System.Drawing.Point(497, 114);
            this.lblListVenta.Name = "lblListVenta";
            this.lblListVenta.Size = new System.Drawing.Size(141, 34);
            this.lblListVenta.TabIndex = 10;
            this.lblListVenta.Text = "Ventas";
            // 
            // lblProd
            // 
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(104, 114);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(174, 34);
            this.lblProd.TabIndex = 11;
            this.lblProd.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IEFI.Quiligotti.Properties.Resources.listado;
            this.pictureBox1.Location = new System.Drawing.Point(208, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelecc
            // 
            this.lblSelecc.AutoSize = true;
            this.lblSelecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecc.Location = new System.Drawing.Point(374, 57);
            this.lblSelecc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelecc.Name = "lblSelecc";
            this.lblSelecc.Size = new System.Drawing.Size(158, 17);
            this.lblSelecc.TabIndex = 13;
            this.lblSelecc.Text = "Seleccione un Producto";
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(544, 58);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(148, 21);
            this.lstProducto.TabIndex = 16;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 581);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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