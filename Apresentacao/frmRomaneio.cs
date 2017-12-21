using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace Apresentacao
{
    public partial class frmRomaneio : Form
    {
        public frmRomaneio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRomaneio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetCarregbloco.tblCarregamentoBloco' table. You can move, or remove it, as needed.
            //this.tblCarregamentoBlocoTableAdapter.Fill(this.midasDataSetCarregbloco.tblCarregamentoBloco);
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer;
            acessoDados.GetDataTable("select IDFilial, Nome from tblFilial", CommandType.Text);

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            {

                string strRetorno = string.Empty;

                if (cpoBloco.Text == "")
                {
                    MessageBox.Show("Por favor defina o Bloco! ");
                    return;
                }

                if (cpoQtd.Text == "")
                {
                    MessageBox.Show("Por favor informe a Quantidade! ");
                    return;
                }
                if (cpoDescricao.Text == "")
                {
                    MessageBox.Show("Por favor selecione o(s) bloco(s) do Romaneio! ");
                    return;
                }


                dgwCarregamento.Rows.Add(cpoBloco.Text, cpoQtd.Text, cpoDescricao.Text);
            }
        }

        private void btnChamacli_Click(object sender, EventArgs e)
        {
            frmCliente OutroForm = new frmCliente();
            OutroForm.ShowDialog();
        }

        private void btnChamafor_Click(object sender, EventArgs e)
        {
            frmFornecedor OutroForm = new frmFornecedor();
            OutroForm.ShowDialog();
        }

        private void btnChamaTransp_Click(object sender, EventArgs e)
        {
            frmTransportador OutroForm = new frmTransportador();
            OutroForm.ShowDialog();
        }


    }
}
