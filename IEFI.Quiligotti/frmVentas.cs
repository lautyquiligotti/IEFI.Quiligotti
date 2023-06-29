using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI.Quiligotti
{
    public partial class frmVentas : Form
    {
        frmListado frmListado = new frmListado();
        public frmVentas()
        {
            InitializeComponent();
        }

        string[] vectorVentas = new string[10];
        string productoVendido = " ";
        string fechaProdVendido = " ";
        string cantidad = " ";
        int i = 0;

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {

            frmListado.ShowDialog();
            this.Hide();
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            if (dtpFechaVenta.Value >= DateTime.Today)
            {
                fechaProdVendido = dtpFechaVenta.Value.ToString();

                if (txtProductoVendido.Text != "")
                {
                    productoVendido = txtProductoVendido.Text;

                    if (txtCantidad.Text != "")
                    {
                        cantidad = txtCantidad.Text;

                        frmListado.matrizVentas[i, 0] = fechaProdVendido;
                        frmListado.matrizVentas[i, 1] = productoVendido;
                        frmListado.matrizVentas[i, 2] = cantidad;

                        MessageBox.Show("Venta cargada");

                    }


                }
                else
                {
                    MessageBox.Show("Ingresa el nombre del producto");
                    txtProductoVendido.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy");
                dtpFechaVenta.Focus();
            }
        }
    }
}
