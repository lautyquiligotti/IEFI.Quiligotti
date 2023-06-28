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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCargaProductos_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
        }

        private void btnCargaVentas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }
    }
}
