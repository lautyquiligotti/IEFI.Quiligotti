﻿namespace IEFI.Quiligotti
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
            this.SuspendLayout();
            // 
            // lblListadoTitulo
            // 
            this.lblListadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoTitulo.Location = new System.Drawing.Point(44, 48);
            this.lblListadoTitulo.Name = "lblListadoTitulo";
            this.lblListadoTitulo.Size = new System.Drawing.Size(141, 34);
            this.lblListadoTitulo.TabIndex = 2;
            this.lblListadoTitulo.Text = "Listado";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListadoTitulo);
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListadoTitulo;
    }
}