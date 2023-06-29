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
    public partial class frmListado : Form
    {


        public string[,] matrizProductos = new string[5, 3];
        public string[,] matrizVentas = new string[5, 3];
        int cp = 0;
        int cv = 0;

        public frmListado()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
            this.Hide();
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizProductos.GetLength(0); i++)
            {
                if (matrizProductos[i,cp] != null)
                {
                    dtvMatrizProd.Rows.Add(matrizProductos[i, 0], matrizProductos[i, 1], matrizProductos[i, 2]);
                    
                }
            }
        }

        private void dtvMatrizProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizVentas.GetLength(0); i++)
            {
                if (matrizVentas[i,cv] != null)
                {
                    dtvMatrizVenta.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2]);
                    
                }
            }
        }
    }
}
