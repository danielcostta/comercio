using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercio.Modelo;
using System.Data.Entity;

namespace Comercio.WindowsForms.Formularios
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendedor formVendedor = new FormVendedor();
            formVendedor.MdiParent = this;
            formVendedor.Show();
        }
    }
}
