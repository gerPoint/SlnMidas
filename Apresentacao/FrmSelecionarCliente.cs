using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmSelecionarCliente : Form
    {
        public frmSelecionarCliente()
        {
            InitializeComponent();
        }

        private void FrmSelecionarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetcliente.tblCliente' table. You can move, or remove it, as needed.
            this.tblClienteTableAdapter.Fill(this.midasDataSetcliente.tblCliente);

        }
    }
}
