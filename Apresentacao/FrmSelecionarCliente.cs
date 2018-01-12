using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcessoDados;
using Negocio;
using ObjTransferencia;

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
            // this.tblClienteTableAdapter.Fill(this.midasDataSetcliente.tblCliente);
        }

        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO--------------------------------------------------------------------------
        public String NomeCliente
        {
            get { return cpoNomeCliente.Text; }
            set { cpoNomeCliente.Text = value; }
        }

        public String IDCliente
        {
            get { return cpoIDCliente.Text; }
            set { cpoIDCliente.Text = value; }
        }

        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO-----------------------------------------

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();

        }


        private void AtualizarGrid()
        {
            try
            {
                if (cpoCaixaPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o nome do Cliente para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegCliente objNegCliente = new NegCliente();
                ClienteLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegCliente.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegCliente.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwSelCliente.DataSource = null;
                dgwSelCliente.DataSource = objLista;
                dgwSelCliente.Update();
                dgwSelCliente.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Cliente. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

       }


    



    private void dgwSelCliente_DoubleClick(object sender, EventArgs e)
        {


             Cliente cliente = (dgwSelCliente.SelectedRows[0].DataBoundItem as Cliente);
             cpoIDCliente.Text = dgwSelCliente.SelectedRows[0].Cells[0].Value.ToString();
             cpoNomeCliente.Text = dgwSelCliente.SelectedRows[0].Cells[1].Value.ToString();
             

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cpoIDCliente.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Pesquise o cliente desejado e selecione-o dando um clique duplo sobre ele.");
                return;
            }
            Cliente cliente = (dgwSelCliente.SelectedRows[0].DataBoundItem as Cliente);
            cpoIDCliente.Text = cliente.Nome;
            cpoIDCliente.Text = cliente.IDCliente.ToString();
            this.Close();
        }


    }
}
