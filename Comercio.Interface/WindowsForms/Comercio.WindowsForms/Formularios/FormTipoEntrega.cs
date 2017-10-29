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
    public partial class FormTipoEntrega : Form
    {
        comercioEntities db = new comercioEntities();
        private tipoentrega tipoentreg;
        public FormTipoEntrega()
        {
            InitializeComponent();
        }

        private void FormTipoEntrega_Load(object sender, EventArgs e)
        {
            dataGridTipoEntrega.ColumnCount = 2;
            dataGridTipoEntrega.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridTipoEntrega.MultiSelect = false;
            dataGridTipoEntrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridTipoEntrega.Columns[0].HeaderText = "ID do tipo da entrega";
            dataGridTipoEntrega.Columns[0].DataPropertyName = "IDTipoEntrega";
            dataGridTipoEntrega.Columns[0].Width = 240;
            dataGridTipoEntrega.Columns[0].Name = "IDTipoEntrega";

            dataGridTipoEntrega.Columns[1].HeaderText = "Descrição do tipo da entrega";
            dataGridTipoEntrega.Columns[1].DataPropertyName = "Descricao";
            dataGridTipoEntrega.Columns[1].Width = 300;
            dataGridTipoEntrega.Columns[1].Name = "Descricao";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var tiposentregas = from tipoentreg in db.tipoentrega select (new { tipoentreg.IDTipoEntrega, tipoentreg.Descricao });
            dataGridTipoEntrega.DataSource = tiposentregas.ToList();
        }

        private void btnSalvarTipoEntrega_Click(object sender, EventArgs e)
        {
            if (tipoentreg == null)
                tipoentreg = new tipoentrega();

            int idTipoEntrega = (byte)tipoentreg.IDTipoEntrega > 0 ? tipoentreg.IDTipoEntrega : 0;

            tipoentreg.IDTipoEntrega = (byte)idTipoEntrega;

            tipoentreg.Descricao = txtDescricao.Text;

            string mensagem = "";

            if (tipoentreg.IDTipoEntrega == 0)
            {
                db.tipoentrega.Add(tipoentreg);
                mensagem = "Tipo de entrega registrada com sucesso!";
            }

            else
            {
                var obj = db.Entry(tipoentreg);
                obj.Property(x => x.Descricao).IsModified = true;

                mensagem = "Tipo de entrega alterada com sucesso!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtDescricao.Clear();
            tipoentreg = null;
        }

        private void btnEditarTipoEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridTipoEntrega.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridTipoEntrega.SelectedRows[0];
                byte idTipoEntrega = (byte)linha.Cells["IDTipoEntrega"].Value;

                tipoentreg = db.tipoentrega.Where(x => x.IDTipoEntrega == idTipoEntrega).FirstOrDefault();

                txtDescricao.Text = tipoentreg.Descricao;
            }

            else
            {
                MessageBox.Show("Selecione um tipo de entrega para alterar!");
            }

        }

        private void btnExcluirTipoEntrega_Click(object sender, EventArgs e)
        {
            if (dataGridTipoEntrega.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridTipoEntrega.SelectedRows[0];
                byte idTipoEntrega = (byte)linha.Cells["IDTipoEntrega"].Value;

                tipoentreg = db.tipoentrega.Where(x => x.IDTipoEntrega == idTipoEntrega).FirstOrDefault();

                db.tipoentrega.Remove(tipoentreg);
                db.SaveChanges();

                MessageBox.Show("Tipo de entrega excluída com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione um tipo de entrega para excluír!");
            }
        }
    }
}
