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
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnVerListadoP_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.ShowDialog();
            this.Hide();
        }
    }
}
