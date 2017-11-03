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
    public partial class FormPedido : Form
    {
        comercioEntities db = new comercioEntities();
        private pedido ped;
        private vendedor vend;
        private produto produt;
        private cliente client;
        public FormPedido()
        {
            InitializeComponent();
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = db.cliente.ToList();
            cbCliente.DisplayMember = "NomeCliente";
            cbCliente.ValueMember = "IDCliente";

            cbProduto.DataSource = db.produto.ToList();
            cbProduto.DisplayMember = "NomeProduto";
            cbProduto.ValueMember = "IDProduto";

            cbVendedor.DataSource = db.vendedor.ToList();
            cbVendedor.DisplayMember = "NomeVendedor";
            cbVendedor.ValueMember = "IDVendedor";

            dataGridPedido.ColumnCount = 5;
            dataGridPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridPedido.MultiSelect = false;
            dataGridPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridPedido.Columns[0].HeaderText = "ID do pedido";
            dataGridPedido.Columns[0].DataPropertyName = "IDPedido";
            dataGridPedido.Columns[0].Width = 240;
            dataGridPedido.Columns[0].Name = "IDPedido";

            dataGridPedido.Columns[1].HeaderText = "Cliente";
            dataGridPedido.Columns[1].DataPropertyName = "NomeCliente";
            dataGridPedido.Columns[1].Width = 240;
            dataGridPedido.Columns[1].Name = "NomeCliente";

            dataGridPedido.Columns[2].HeaderText = "Quantidade";
            dataGridPedido.Columns[2].DataPropertyName = "Quantidade";
            dataGridPedido.Columns[2].Width = 300;
            dataGridPedido.Columns[2].Name = "Quantidade";

            dataGridPedido.Columns[3].HeaderText = "Produto";
            dataGridPedido.Columns[3].DataPropertyName = "NomeProduto";
            dataGridPedido.Columns[3].Width = 300;
            dataGridPedido.Columns[3].Name = "NomeProduto";

            dataGridPedido.Columns[4].HeaderText = "Vendedor";
            dataGridPedido.Columns[4].DataPropertyName = "NomeVendedor";
            dataGridPedido.Columns[4].Width = 300;
            dataGridPedido.Columns[4].Name = "NomeVendedor";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var pedidos = from ped in db.pedido
                           join prod in db.produto on ped.IDProduto equals prod.IDProduto
                           join vend in db.vendedor on ped.IDVendedor equals vend.IDVendedor
                           join client in db.cliente on ped.IDCliente equals client.IDCliente
                          select (new { ped.IDPedido, client.NomeCliente, ped.Quantidade, prod.NomeProduto, vend.NomeVendedor });
            dataGridPedido.DataSource = pedidos.ToList();

        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (ped == null)
                ped = new pedido();

            int idPedido = (int)ped.IDPedido > 0 ? ped.IDPedido : 0;

            ped.IDPedido = (int)idPedido;

            ped.IDCliente = (int)cbCliente.SelectedValue;

            ped.Quantidade = byte.Parse(txtQuantidade.Text);

            ped.IDProduto = (short)cbProduto.SelectedValue;

            ped.IDVendedor = (byte)cbVendedor.SelectedValue;

            string mensagem = "";

            if (ped.IDPedido == 0)
            {
                db.pedido.Add(ped);
                mensagem = "Produto registrado com sucesso!";
            }

            else
            {
                var obj = db.Entry(ped);
                obj.Property(x => x.IDPedido).IsModified = true;

                mensagem = "Produto alterado com sucesso!";
            }


            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            cbCliente.SelectedIndex = 0;
            cbProduto.SelectedIndex = 0;
            cbVendedor.SelectedIndex = 0;
            txtQuantidade.Clear();
            ped = null;
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            if (dataGridPedido.SelectedRows.Count > 0)
            {

                int idPedido = (int)dataGridPedido.CurrentRow.Cells[0].Value;

                ped = db.pedido.Where(x => x.IDPedido == idPedido).FirstOrDefault();

                cbCliente.SelectedValue = ped.IDCliente;

                txtQuantidade.Text = Convert.ToString(ped.Quantidade);

                cbProduto.SelectedValue = ped.IDProduto;

                cbVendedor.SelectedValue = ped.IDVendedor;

            }

            else
            {
                MessageBox.Show("Selecione um pedido para alterar!");

            }
        }

        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            if (dataGridPedido.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPedido.SelectedRows[0];
                int idPedido = (int)linha.Cells["IDPedido"].Value;

                ped = db.pedido.Where(x => x.IDPedido == idPedido).FirstOrDefault();

                db.pedido.Remove(ped);
                db.SaveChanges();

                MessageBox.Show("Pedido excluído com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione um pedido para excluír!");
            }
        }
    }
}
