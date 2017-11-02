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
    public partial class FormEntrega : Form
    {
        comercioEntities db = new comercioEntities();
        private entrega ent;
        private pedido ped;
        private tipoentrega te;
        public FormEntrega()
        {
            InitializeComponent();
        }

        private void FormEntrega_Load(object sender, EventArgs e)
        {
            cbTipoEntrega.DataSource = db.tipoentrega.ToList();
            cbTipoEntrega.DisplayMember = "Descricao";
            cbTipoEntrega.ValueMember = "IDTipoEntrega";

            cbPedido.DataSource = db.pedido.ToList();
            cbPedido.DisplayMember = "IDPedido";
            cbPedido.ValueMember = "IDPedido";

            dataGridEntrega.ColumnCount = 4;
            dataGridEntrega.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridEntrega.MultiSelect = false;
            dataGridEntrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridEntrega.Columns[0].HeaderText = "ID da entrega";
            dataGridEntrega.Columns[0].DataPropertyName = "IDEntrega";
            dataGridEntrega.Columns[0].Width = 240;
            dataGridEntrega.Columns[0].Name = "IDEntrega";

            dataGridEntrega.Columns[1].HeaderText = "Código de Rastreio";
            dataGridEntrega.Columns[1].DataPropertyName = "CodigoRastreio";
            dataGridEntrega.Columns[1].Width = 240;
            dataGridEntrega.Columns[1].Name = "CodigoRastreio";

            dataGridEntrega.Columns[2].HeaderText = "Tipo de entrega";
            dataGridEntrega.Columns[2].DataPropertyName = "Descricao";
            dataGridEntrega.Columns[2].Width = 300;
            dataGridEntrega.Columns[2].Name = "Descricao";

            dataGridEntrega.Columns[3].HeaderText = "Pedido";
            dataGridEntrega.Columns[3].DataPropertyName = "IDPedido";
            dataGridEntrega.Columns[3].Width = 300;
            dataGridEntrega.Columns[3].Name = "IDPedido";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var entregas = from ent in db.entrega
                           join te in db.tipoentrega on ent.IDTipoEntrega equals te.IDTipoEntrega
                           join ped in db.pedido on ent.IDPedido equals ped.IDPedido
                           select (new { ent.IDEntrega, ent.CodigoRastreio, te.Descricao, ped.IDPedido });
            dataGridEntrega.DataSource = entregas.ToList();

        }

        private void btnSalvarEntrega_Click(object sender, EventArgs e)
        {
            if (ent == null)
                ent = new entrega();

                int idEntrega = (int)ent.IDEntrega > 0 ? ent.IDEntrega : 0;

                ent.IDEntrega = (int)idEntrega;

                ent.CodigoRastreio = txtCodigoRastreio.Text;

                ent.IDTipoEntrega = (byte)cbTipoEntrega.SelectedValue;

                ent.IDPedido = (int)cbPedido.SelectedValue;

                string mensagem = "";

                if (ent.IDEntrega == 0)
                {
                    db.entrega.Add(ent);
                    mensagem = "Entrega registrada com sucesso!";
                }

                else
                {
                    var obj = db.Entry(ent);
                    obj.Property(x => x.CodigoRastreio).IsModified = true;

                    mensagem = "Entrega alterada com sucesso!";
                }


                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();

        }

        public void LimparCampos()
        {
            txtCodigoRastreio.Clear();
            cbTipoEntrega.SelectedIndex = 0;
            cbPedido.SelectedIndex = 0;
            ent = null;
        }

        private void btnEditarEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridEntrega.SelectedRows.Count > 0)
            {

                int idEntrega = (int)dataGridEntrega.CurrentRow.Cells[0].Value;

                ent = db.entrega.Where(x => x.IDEntrega == idEntrega).FirstOrDefault();

                txtCodigoRastreio.Text = ent.CodigoRastreio;

                cbTipoEntrega.SelectedValue = ent.IDTipoEntrega;

                cbPedido.SelectedValue = ent.IDPedido;

            }

            else
            {
                MessageBox.Show("Selecione uma entrega para alterar!");

            }
        }

        private void btnExcluirEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridEntrega.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridEntrega.SelectedRows[0];
                int idEntrega = (int)linha.Cells["IDEntrega"].Value;

                ent = db.entrega.Where(x => x.IDEntrega == idEntrega).FirstOrDefault();

                db.entrega.Remove(ent);
                db.SaveChanges();

                MessageBox.Show("Entrega excluída com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione uma entrega para excluír!");
            }
        }
    }

}
