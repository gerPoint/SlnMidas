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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void romaneioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void romaneioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRomaneio OutroForm = new frmRomaneio();
            OutroForm.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente OutroForm = new frmCliente();
            OutroForm.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor OutroForm = new frmFornecedor();
            OutroForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void filialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFilial OutroForm = new frmFilial();
            OutroForm.ShowDialog();
        }

        private void frutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFruta OutroForm = new frmFruta();
            OutroForm.ShowDialog();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario OutroForm = new frmFuncionario();
            OutroForm.ShowDialog();
        }

        private void transportadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransportador OutroFrm = new frmTransportador();
            OutroFrm.ShowDialog();        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario OutroFrm = new frmUsuario();
            OutroFrm.ShowDialog();
        }
    }
}
