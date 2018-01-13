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
    public partial class frmSelecionarTransportador : Form
    {
        public frmSelecionarTransportador()
        {
            InitializeComponent();
        }

        private void frmSelecionarTransportador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetFornecedor.tblFornecedor' table. You can move, or remove it, as needed.

        }
            // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO--------------------------------------------------------------------------
        public String NomeTransportador
        {
            get { return cpoNomeTransportador.Text; }
            set { cpoNomeTransportador.Text = value; }
        }

        public String IDTransportador
        {
            get { return cpoIDTransportador.Text; }
            set { cpoIDTransportador.Text = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwSelTransportador_DoubleClick(object sender, EventArgs e)
        {
            Transportador transportador = (dgwSelTransportador.SelectedRows[0].DataBoundItem as Transportador);
            cpoIDTransportador.Text = dgwSelTransportador.SelectedRows[0].Cells[0].Value.ToString();
            cpoNomeTransportador.Text = dgwSelTransportador.SelectedRows[0].Cells[1].Value.ToString();
        }


//--------------------------------Somente a primeira letra maiuscula de cada palavra---------------------------------------------

        public string ConvMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }



        private void cpoCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
            cpoCaixaPesquisa.Text = ConvMaiuscula(cpoCaixaPesquisa.Text).ToString();
            cpoCaixaPesquisa.SelectionStart = cpoCaixaPesquisa.Text.Length;
        }
 //--------------------------------Somente a primeira letra maiuscula de cada palavra---------------------------------------------
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
                    MessageBox.Show("Por favor, informe o nome do Transportador para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();

                    return;
                }

                NegTransportador objNegTransportador = new NegTransportador();
                TransportadorLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegTransportador.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegTransportador.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwSelTransportador.DataSource = null;
                dgwSelTransportador.DataSource = objLista;
                dgwSelTransportador.Update();
                dgwSelTransportador.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Transportador. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cpoIDTransportador.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Pesquise o Transportador desejado e selecione-o dando um clique duplo sobre o mesmo.");
                return;
            }
            Transportador transportador = (dgwSelTransportador.SelectedRows[0].DataBoundItem as Transportador);
            cpoIDTransportador.Text = transportador.Nome;
            cpoIDTransportador.Text = transportador.IDTransportador.ToString();
            this.Close();
        }
    }




    }



