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
    public partial class FormMarca : Form
    {
        comercioEntities db = new comercioEntities();
        private marca marc;
        public FormMarca()
        {
            InitializeComponent();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            dataGridMarca.ColumnCount = 2;
            dataGridMarca.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridMarca.MultiSelect = false;
            dataGridMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridMarca.Columns[0].HeaderText = "ID da Marca";
            dataGridMarca.Columns[0].DataPropertyName = "IDMarca";
            dataGridMarca.Columns[0].Width = 240;
            dataGridMarca.Columns[0].Name = "IDMarca";

            dataGridMarca.Columns[1].HeaderText = "Nome da Marca";
            dataGridMarca.Columns[1].DataPropertyName = "NomeMarca";
            dataGridMarca.Columns[1].Width = 300;
            dataGridMarca.Columns[1].Name = "NomeMarca";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var marcas = from marc  in db.marca select (new { marc.IDMarca, marc.NomeMarca });
            dataGridMarca.DataSource = marcas.ToList();
        }

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {
            if (marc == null)
                marc = new marca();

            int idMarca = (byte)marc.IDMarca > 0 ? marc.IDMarca : 0;

            marc.IDMarca = (byte)idMarca;

            marc.NomeMarca = txtNomeMarca.Text;

            string mensagem = "";

            if (marc.IDMarca == 0)
            {
                db.marca.Add(marc);
                mensagem = "Marca registrada com sucesso!";
            }

            else
            {
                var obj = db.Entry(marc);
                obj.Property(x => x.NomeMarca).IsModified = true;

                mensagem = "Marca alterada com sucesso!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNomeMarca.Clear();
            marc = null;
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridMarca.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridMarca.SelectedRows[0];
                byte idMarca = (byte)linha.Cells["IDMarca"].Value;

                marc = db.marca.Where(x => x.IDMarca == idMarca).FirstOrDefault();

                txtNomeMarca.Text = marc.NomeMarca;
            }

            else
            {
                MessageBox.Show("Selecione uma marca para alterar!");
            }

        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            if (dataGridMarca.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridMarca.SelectedRows[0];
                byte idMarca = (byte)linha.Cells["IDMarca"].Value;

                marc = db.marca.Where(x => x.IDMarca == idMarca).FirstOrDefault();

                db.marca.Remove(marc);
                db.SaveChanges();

                MessageBox.Show("Marca excluída com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione uma marca para excluír!");
            }
        }
    }
}
