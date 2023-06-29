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
            this.lblProdTitulo = new System.Windows.Forms.Label();
            this.gbCargarProductos = new System.Windows.Forms.GroupBox();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.lblCantP = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.dtpFechaCargado = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtProductoCargado = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.gbConsultarProducto = new System.Windows.Forms.GroupBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboConsultarProductoCarga = new System.Windows.Forms.ComboBox();
            this.btnVerListadoP = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.columnCant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultarProd = new System.Windows.Forms.Button();
            this.gbCargarProductos.SuspendLayout();
            this.gbConsultarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdTitulo
            // 
            this.lblProdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitulo.Location = new System.Drawing.Point(508, 96);
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
            // gbConsultarProducto
            // 
            this.gbConsultarProducto.Controls.Add(this.btnConsultarProd);
            this.gbConsultarProducto.Controls.Add(this.lvProductos);
            this.gbConsultarProducto.Controls.Add(this.cboConsultarProductoCarga);
            this.gbConsultarProducto.Location = new System.Drawing.Point(741, 226);
            this.gbConsultarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.gbConsultarProducto.Name = "gbConsultarProducto";
            this.gbConsultarProducto.Padding = new System.Windows.Forms.Padding(6);
            this.gbConsultarProducto.Size = new System.Drawing.Size(713, 398);
            this.gbConsultarProducto.TabIndex = 4;
            this.gbConsultarProducto.TabStop = false;
            this.gbConsultarProducto.Text = "Consultar Productos";
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnFechaRegistro,
            this.columnCant});
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(27, 119);
            this.lvProductos.Margin = new System.Windows.Forms.Padding(6);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(674, 144);
            this.lvProductos.TabIndex = 14;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.SelectedIndexChanged += new System.EventHandler(this.lvProductos_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 57;
            // 
            // columnNombre
            // 
            this.columnNombre.DisplayIndex = 2;
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 145;
            // 
            // columnFechaRegistro
            // 
            this.columnFechaRegistro.DisplayIndex = 1;
            this.columnFechaRegistro.Text = "Fecha de Registro";
            this.columnFechaRegistro.Width = 228;
            // 
            // cboConsultarProductoCarga
            // 
            this.cboConsultarProductoCarga.FormattingEnabled = true;
            this.cboConsultarProductoCarga.Location = new System.Drawing.Point(166, 58);
            this.cboConsultarProductoCarga.Margin = new System.Windows.Forms.Padding(6);
            this.cboConsultarProductoCarga.Name = "cboConsultarProductoCarga";
            this.cboConsultarProductoCarga.Size = new System.Drawing.Size(274, 33);
            this.cboConsultarProductoCarga.TabIndex = 0;
            // 
            // btnVerListadoP
            // 
            this.btnVerListadoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListadoP.Location = new System.Drawing.Point(644, 706);
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
            this.pictureBox2.Location = new System.Drawing.Point(190, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // columnCant
            // 
            this.columnCant.Text = "Cantidad";
            this.columnCant.Width = 131;
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.Location = new System.Drawing.Point(194, 315);
            this.btnConsultarProd.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(268, 44);
            this.btnConsultarProd.TabIndex = 15;
            this.btnConsultarProd.Text = "Consultar";
            this.btnConsultarProd.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVerListadoP);
            this.Controls.Add(this.gbConsultarProducto);
            this.Controls.Add(this.gbCargarProductos);
            this.Controls.Add(this.lblProdTitulo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbCargarProductos.ResumeLayout(false);
            this.gbCargarProductos.PerformLayout();
            this.gbConsultarProducto.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbConsultarProducto;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnFechaRegistro;
        private System.Windows.Forms.ComboBox cboConsultarProductoCarga;
        private System.Windows.Forms.Button btnVerListadoP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCantP;
        private System.Windows.Forms.Label lblCantP;
        private System.Windows.Forms.ColumnHeader columnCant;
        private System.Windows.Forms.Button btnConsultarProd;
    }
}