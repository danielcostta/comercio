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
    public partial class FormVendedor : Form
    {
        comercioEntities db = new comercioEntities();
        private vendedor vd;
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            dataGridVendedor.ColumnCount = 2;
            dataGridVendedor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridVendedor.MultiSelect = false;
            dataGridVendedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridVendedor.Columns[0].HeaderText = "ID do vendedor";
            dataGridVendedor.Columns[0].DataPropertyName = "IDVendedor";
            dataGridVendedor.Columns[0].Width = 240;
            dataGridVendedor.Columns[0].Name = "IDVendedor";

            dataGridVendedor.Columns[1].HeaderText = "Nome do vendedor";
            dataGridVendedor.Columns[1].DataPropertyName = "NomeVendedor";
            dataGridVendedor.Columns[1].Width = 300;
            dataGridVendedor.Columns[1].Name = "NomeVendedor";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var vendedores = from vendedor in db.vendedor select (new { vendedor.IDVendedor, vendedor.NomeVendedor });
            dataGridVendedor.DataSource = vendedores.ToList();
        }

        //O TIPO BYTE SE APLICA AO TIPO TINYINT DO BANCO DE DADOS

        private void btnSalvarVendedor_Click(object sender, EventArgs e)
        {
            if (vd == null)
                vd = new vendedor();

            int idVendedor = (byte)vd.IDVendedor > 0 ? vd.IDVendedor : 0;

            vd.IDVendedor = (byte)idVendedor;

            vd.NomeVendedor = txtNomeVendedor.Text;

            string mensagem = "";

            if (vd.IDVendedor == 0)
            {
                db.vendedor.Add(vd);
                mensagem = "Vendedor registrado com sucesso!";
            }

            else
            {
                var obj = db.Entry(vd);
                obj.Property(x => x.NomeVendedor).IsModified = true;

                mensagem = "Vendedor alterado com sucesso!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }

        public void LimparCampos()
        {
            txtNomeVendedor.Clear();
            vd = null;
        }

        private void btnEditarVendedor_Click(object sender, EventArgs e)
        {
            if(dataGridVendedor.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridVendedor.SelectedRows[0];
                byte idVendedor = (byte)linha.Cells["IDVendedor"].Value;

                vd = db.vendedor.Where(x => x.IDVendedor == idVendedor).FirstOrDefault();

                txtNomeVendedor.Text = vd.NomeVendedor;
            }

            else
            {
                MessageBox.Show("Selecione um vendedor para alterar!");
            }
        }

        private void btnExcluirVendedor_Click(object sender, EventArgs e)
        {
            if(dataGridVendedor.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridVendedor.SelectedRows[0];
                byte idVendedor = (byte)linha.Cells["IDVendedor"].Value;

                vd = db.vendedor.Where(x => x.IDVendedor == idVendedor).FirstOrDefault();

                db.vendedor.Remove(vd);
                db.SaveChanges();

                MessageBox.Show("Vendedor excluído com sucesso!");

                CarregarGrid();
                LimparCampos();
            }

            else
            {
                MessageBox.Show("Selecione um vendedor para excluír!");
            }
        }
    }
}
