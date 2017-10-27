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

        }
    }
}
