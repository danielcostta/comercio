using Comercio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio.WindowsForms.Formularios
{
    public partial class FormProduto : Form
    {
        comercioEntities db = new comercioEntities();
        private produto product;
        private marca marc;
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            cbMarcaProduto.DataSource = db.marca.ToList();
            cbMarcaProduto.DisplayMember = "NomeMarca";
            cbMarcaProduto.ValueMember = "IDMarca";

            dataGridProduto.ColumnCount = 4;
            dataGridProduto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridProduto.MultiSelect = false;
            dataGridProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridProduto.Columns[0].HeaderText = "ID do produto";
            dataGridProduto.Columns[0].DataPropertyName = "IDProduto";
            dataGridProduto.Columns[0].Width = 240;
            dataGridProduto.Columns[0].Name = "IDProduto";

            dataGridProduto.Columns[1].HeaderText = "Nome do produto";
            dataGridProduto.Columns[1].DataPropertyName = "NomeProduto";
            dataGridProduto.Columns[1].Width = 300;
            dataGridProduto.Columns[1].Name = "NomeProduto";

            dataGridProduto.Columns[2].HeaderText = "Valor do produto";
            dataGridProduto.Columns[2].DataPropertyName = "Valor";
            dataGridProduto.Columns[2].Width = 300;
            dataGridProduto.Columns[2].Name = "Valor";

            dataGridProduto.Columns[3].HeaderText = "Marca do produto";
            dataGridProduto.Columns[3].DataPropertyName = "NomeMarca";
            dataGridProduto.Columns[3].Width = 300;
            dataGridProduto.Columns[3].Name = "NomeMarca";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var produtos = from product in db.produto join marc in db.marca on product.IDMarca equals marc.IDMarca
            select (new { product.IDProduto, product.NomeProduto, product.Valor, marc.NomeMarca});
            dataGridProduto.DataSource = produtos.ToList();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (product == null)
                product = new produto();

            int idProduto = (short)product.IDProduto > 0 ? product.IDProduto : 0;

            product.IDProduto = (short)idProduto;

            product.NomeProduto = txtNomeProduto.Text;

            product.Valor = Double.Parse(txtValorProduto.Text);

            var a = cbMarcaProduto.SelectedValue;

            product.IDMarca = Convert.ToByte(a);

            string mensagem = "";

            if (product.IDProduto == 0)
            {
                db.produto.Add(product);
                mensagem = "Produto registrado com sucesso!";
            }

            else
            {
                var obj = db.Entry(product);
                obj.Property(x => x.NomeProduto).IsModified = true;

                mensagem = "Produto alterado com sucesso!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtValorProduto.Clear();
            cbMarcaProduto.SelectedIndex = 0;
            product = null;
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridProduto.SelectedRows[0];
                short idProduto = (short)linha.Cells["IDProduto"].Value;

                product = db.produto.Where(x => x.IDProduto == idProduto).FirstOrDefault();

                txtNomeProduto.Text = product.NomeProduto;

                txtValorProduto.Text = Convert.ToString(product.Valor);

                cbMarcaProduto.SelectedValue = product.IDMarca;

            }

            else
            {
                MessageBox.Show("Selecione um produto para alterar!");

            }

        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dataGridProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridProduto.SelectedRows[0];
                short idProduto = (short)linha.Cells["IDProduto"].Value;

                product = db.produto.Where(x => x.IDProduto == idProduto).FirstOrDefault();

                db.produto.Remove(product);
                db.SaveChanges();

                MessageBox.Show("Produto excluído com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione um produto para excluír!");
            }
        }
    }
}
