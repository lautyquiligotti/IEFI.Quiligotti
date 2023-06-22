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
            this.gbCargarProductos.SuspendLayout();
            this.gbConsultarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdTitulo
            // 
            this.lblProdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitulo.Location = new System.Drawing.Point(254, 50);
            this.lblProdTitulo.Name = "lblProdTitulo";
            this.lblProdTitulo.Size = new System.Drawing.Size(176, 43);
            this.lblProdTitulo.TabIndex = 1;
            this.lblProdTitulo.Text = "Productos";
            // 
            // gbCargarProductos
            // 
            this.gbCargarProductos.Controls.Add(this.btnCargarProducto);
            this.gbCargarProductos.Controls.Add(this.dtpFechaCargado);
            this.gbCargarProductos.Controls.Add(this.lblFechaRegistro);
            this.gbCargarProductos.Controls.Add(this.txtProductoCargado);
            this.gbCargarProductos.Controls.Add(this.lblNombreProducto);
            this.gbCargarProductos.Location = new System.Drawing.Point(33, 138);
            this.gbCargarProductos.Name = "gbCargarProductos";
            this.gbCargarProductos.Size = new System.Drawing.Size(262, 199);
            this.gbCargarProductos.TabIndex = 3;
            this.gbCargarProductos.TabStop = false;
            this.gbCargarProductos.Text = "Cargar Productos";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(50, 158);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(134, 23);
            this.btnCargarProducto.TabIndex = 4;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCargado
            // 
            this.dtpFechaCargado.Location = new System.Drawing.Point(21, 118);
            this.dtpFechaCargado.Name = "dtpFechaCargado";
            this.dtpFechaCargado.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaCargado.TabIndex = 3;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(18, 92);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(96, 13);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha De Registro";
            // 
            // txtProductoCargado
            // 
            this.txtProductoCargado.Location = new System.Drawing.Point(21, 47);
            this.txtProductoCargado.Name = "txtProductoCargado";
            this.txtProductoCargado.Size = new System.Drawing.Size(198, 20);
            this.txtProductoCargado.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(18, 30);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(109, 13);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Del Producto";
            // 
            // gbConsultarProducto
            // 
            this.gbConsultarProducto.Controls.Add(this.lvProductos);
            this.gbConsultarProducto.Controls.Add(this.cboConsultarProductoCarga);
            this.gbConsultarProducto.Location = new System.Drawing.Point(363, 138);
            this.gbConsultarProducto.Name = "gbConsultarProducto";
            this.gbConsultarProducto.Size = new System.Drawing.Size(325, 199);
            this.gbConsultarProducto.TabIndex = 4;
            this.gbConsultarProducto.TabStop = false;
            this.gbConsultarProducto.Text = "Consultar Productos";
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnFechaRegistro});
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(18, 61);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(275, 77);
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
            // columnFechaRegistro
            // 
            this.columnFechaRegistro.Text = "Fecha de Registro";
            this.columnFechaRegistro.Width = 180;
            // 
            // cboConsultarProductoCarga
            // 
            this.cboConsultarProductoCarga.FormattingEnabled = true;
            this.cboConsultarProductoCarga.Location = new System.Drawing.Point(83, 30);
            this.cboConsultarProductoCarga.Name = "cboConsultarProductoCarga";
            this.cboConsultarProductoCarga.Size = new System.Drawing.Size(139, 21);
            this.cboConsultarProductoCarga.TabIndex = 0;
            // 
            // btnVerListadoP
            // 
            this.btnVerListadoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListadoP.Location = new System.Drawing.Point(322, 367);
            this.btnVerListadoP.Name = "btnVerListadoP";
            this.btnVerListadoP.Size = new System.Drawing.Size(143, 35);
            this.btnVerListadoP.TabIndex = 6;
            this.btnVerListadoP.Text = "Ver Listado";
            this.btnVerListadoP.UseVisualStyleBackColor = true;
            this.btnVerListadoP.Click += new System.EventHandler(this.btnVerListadoP_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IEFI.Quiligotti.Properties.Resources.product;
            this.pictureBox2.Location = new System.Drawing.Point(95, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVerListadoP);
            this.Controls.Add(this.gbConsultarProducto);
            this.Controls.Add(this.gbCargarProductos);
            this.Controls.Add(this.lblProdTitulo);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
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
    }
}