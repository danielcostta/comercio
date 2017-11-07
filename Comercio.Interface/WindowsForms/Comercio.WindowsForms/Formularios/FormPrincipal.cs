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

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormMarca formMarca = new FormMarca();
             formMarca.ShowDialog();
        }

        private void tipoDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoEntrega formTipoEntrega = new FormTipoEntrega();
            formTipoEntrega.MdiParent = this;
            formTipoEntrega.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.MdiParent = this;
            formProduto.Show();
        }

        private void gerenciadorDeTipoDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntrega formEntrega = new FormEntrega();
            formEntrega.MdiParent = this;
            formEntrega.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.MdiParent = this;
            formPedido.Show();
        }
    }
}
