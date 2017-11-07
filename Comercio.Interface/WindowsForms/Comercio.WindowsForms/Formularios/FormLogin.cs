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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text == "admin") && (txtSenha.Text == "admin"))
            {
                
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
