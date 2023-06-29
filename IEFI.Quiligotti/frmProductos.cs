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
    public partial class frmProductos : Form
    {
        frmListado frmListado = new frmListado();

        public frmProductos()
        {
            InitializeComponent();
        }

        string[] vectorProducto = new string[10];
        string productoCargado = " ";
        string fechaProdCargado = " ";
        string cantidad = " ";
        int i = 0;


        private void btnVerListadoP_Click(object sender, EventArgs e)
        {
            frmListado.ShowDialog();
            this.Hide();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            if (dtpFechaCargado.Value >= DateTime.Today)
            {
                fechaProdCargado = dtpFechaCargado.Value.ToString();

                if (txtProductoCargado.Text != "")
                {
                    productoCargado = txtProductoCargado.Text;

                    if (txtCantP.Text != "")
                    {
                        cantidad = txtCantP.Text;
                        

                        frmListado.matrizProductos[i, 0] = fechaProdCargado;
                        frmListado.matrizProductos[i, 1] = productoCargado;
                        frmListado.matrizProductos[i, 2] = cantidad;
                        i++;

                        MessageBox.Show("Producto cargado");
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad");
                        txtCantP.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del producto");
                    txtProductoCargado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o posterior a la de hoy");
                dtpFechaCargado.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
