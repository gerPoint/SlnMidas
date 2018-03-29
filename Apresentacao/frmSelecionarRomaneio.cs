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
    public partial class frmSelecionarRomaneio : Form
    {
        public string IDRomaneio { get; set; }
        public string Nomecliente { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeTransportador { get; set; }
        public string NomeFruta { get; set; }
        public string FormaPagamento { get; set; }
        public string UnidMedida{ get; set; }
        public string QtdGeral { get; set; }
        public string ValorFrete { get; set; }
        public string CustoCarreg { get; set; }
        public string ValorComissao { get; set; }
        public string AdiantFretMot { get; set; }
        public string Seguro { get; set; }
        public string TaxaNF { get; set; }
        public string ValorTotalRomaneio { get; set; }


        public frmSelecionarRomaneio()
        {
            InitializeComponent();
        }


        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO--------------------------------------------------------------------------


        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO--------------------------------------------------------------------------



        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (comboBoxTpoPesquisa.Text == "Código") 
            {
                AtualizarGrid();
            }

            else
            {
                AtualizarGrid2();
            }

        }

        private void AtualizarGrid()
        {
            try
            {
                if (cpoCodigo.Text == "")
                {
                    MessageBox.Show("Por favor, informe o Codigo do Romaneio para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCodigo.Text = string.Empty;
                    cpoCodigo.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegRomaneio objNegRomaneio = new NegRomaneio();
                RomaneioLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegRomaneio.ConsultarCodigo(Convert.ToInt32(cpoCodigo.Text));
                }
                catch
                {

                    objLista = objNegRomaneio.ConsultarCodigo(Convert.ToInt32(cpoCodigo.Text));
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCodigo.Text = string.Empty;
                    cpoCodigo.Focus();
                    return;
                }

                dgwSelRomaneio.DataSource = null;
                dgwSelRomaneio.DataSource = objLista;
                dgwSelRomaneio.Update();
                dgwSelRomaneio.Refresh();
                cpoCodigo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Romaneio. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void frmSelecionarRomaneio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetRomaneioCorreto.tblRomaneio' table. You can move, or remove it, as needed.
            //this.tblRomaneioTableAdapter.Fill(this.midasDataSetRomaneioCorreto.tblRomaneio);
            // TODO: This line of code loads data into the 'midasDataSetRomaneio.tblRomaneio' table. You can move, or remove it, as needed.
            // this.tblRomaneioTableAdapter.Fill(this.midasDataSetRomaneioCorreto.tblRomaneio);



            comboBoxTpoPesquisa.Text = "Código";
            cpoDtFinal.Enabled = false;
            cpoDtInicial.Enabled = false;
        }


        private void AtualizarGrid2()
        {
            try
            {
                if (cpoDtInicial.Text == "")
                {
                    MessageBox.Show("Por favor, informe o Codigo do Romaneio para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoDtFinal.Text = string.Empty;
                    cpoDtFinal.Focus();
                    cpoDtFinal.Text = string.Empty;
                    cpoDtFinal.Focus();
                    return;
                }

                NegRomaneio objNegRomaneio = new NegRomaneio();
                RomaneioLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegRomaneio.ConsultarData(cpoDtInicial.Value, cpoDtFinal.Value);
                }
                catch
                {

                    objLista = objNegRomaneio.ConsultarData(cpoDtInicial.Value, cpoDtFinal.Value);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCodigo.Text = string.Empty;
                    cpoCodigo.Focus();
                    return;
                }

                dgwSelRomaneio.DataSource = null;
                dgwSelRomaneio.DataSource = objLista;
                dgwSelRomaneio.Update();
                dgwSelRomaneio.Refresh();
                cpoCodigo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Romaneio. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }





        private void comboBoxTpoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTpoPesquisa.Text == "Código")
            {
                cpoCodigo.Enabled = true;
                cpoDtFinal.Enabled = false;
                cpoDtInicial.Enabled = false;
            }
            else
            {
                cpoCodigo.Enabled = false;
                cpoDtFinal.Enabled = true;
                cpoDtInicial.Enabled = true;
            }
        }

        private void dgwRomaneio_DoubleClick(object sender, EventArgs e)
        {
            try
            {



                Romaneio romaneio = (dgwSelRomaneio.SelectedRows[0].DataBoundItem as Romaneio);
                cpoIDRomaneio.Text = dgwSelRomaneio.SelectedRows[0].Cells[0].Value.ToString();
                cpoNomeCliente.Text = dgwSelRomaneio.SelectedRows[0].Cells[1].Value.ToString();
                cpoNomeFornecedor.Text = dgwSelRomaneio.SelectedRows[0].Cells[2].Value.ToString();
                cpoNomeTransportador.Text = dgwSelRomaneio.SelectedRows[0].Cells[3].Value.ToString();
                cpoNomeFruta.Text = dgwSelRomaneio.SelectedRows[0].Cells[4].Value.ToString();
                cpoFormaPagamento.Text = dgwSelRomaneio.SelectedRows[0].Cells[5].Value.ToString();
                cpoUnidMedida.Text = dgwSelRomaneio.SelectedRows[0].Cells[6].Value.ToString();
                cpoQtdGeral.Text = dgwSelRomaneio.SelectedRows[0].Cells[7].Value.ToString();
                cpoValorFrete.Text = dgwSelRomaneio.SelectedRows[0].Cells[8].Value.ToString();
                cpoCustoCarreg.Text = dgwSelRomaneio.SelectedRows[0].Cells[9].Value.ToString();
                cpoValorComissao.Text = dgwSelRomaneio.SelectedRows[0].Cells[10].Value.ToString();
                cpoAdiantFretMot.Text = dgwSelRomaneio.SelectedRows[0].Cells[11].Value.ToString();
                cpoSeguro.Text = dgwSelRomaneio.SelectedRows[0].Cells[12].Value.ToString();
                cpoTaxaNf.Text = dgwSelRomaneio.SelectedRows[0].Cells[13].Value.ToString();
                cpoValorTotalRomaneio.Text = dgwSelRomaneio.SelectedRows[0].Cells[14].Value.ToString();
                cpoIDCliente.Text = dgwSelRomaneio.SelectedRows[0].Cells[19].Value.ToString();
                cpoIDTransportador.Text = dgwSelRomaneio.SelectedRows[0].Cells[20].Value.ToString();
                cpoIDFornecedor.Text = dgwSelRomaneio.SelectedRows[0].Cells[21].Value.ToString();
                cpoIDFruta.Text = dgwSelRomaneio.SelectedRows[0].Cells[22].Value.ToString();


                if (cpoIDRomaneio.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
                {
                    MessageBox.Show("Pesquise o Romaneio desejado e selecione-o dando um clique duplo sobre a mesma.");
                    return;
                }

                this.IDRomaneio = romaneio.IDRomaneio.ToString();
                this.Nomecliente = romaneio.Cliente;
                this.NomeFornecedor = romaneio.Fornecedor;
                this.NomeTransportador = romaneio.Transportador;
                this.NomeFruta = romaneio.Fruta;
                this.FormaPagamento = romaneio.FormaPagamento;
                this.UnidMedida = romaneio.UnidMedida;
                this.QtdGeral = romaneio.QtdFrutas.ToString();
                this.ValorFrete = romaneio.ValorFrete.ToString();
                this.CustoCarreg = romaneio.CustoCarregamento.ToString();
                this.ValorComissao = romaneio.ValorComissao.ToString();
                this.AdiantFretMot = romaneio.AdiantFretMot.ToString();
                this.Seguro = romaneio.TaxaNf.ToString();
                this.TaxaNF = romaneio.TaxaNf.ToString();
                this.ValorTotalRomaneio = romaneio.ValorTotalRomaneio.ToString();



                this.DialogResult = DialogResult.OK;
                this.Close();



                //btnSalvar.Enabled = false;
                //btnAlterar.Enabled = false;
                //btnExcluir.Enabled = true;


                //cpoSeguro.Enabled = false;
                //cpoTaxaNf.Enabled = false;
                //cpoValorComissao.Enabled = false;
                //cpoValorFrete.Enabled = false;
                //cpoCustoCarreg.Enabled = false;
                //cpoQtdGeral.Enabled = false;
                //checkBoxAdiantFretMot.Enabled = false;
                //comboBoxFormaPagamento.Enabled = false;
                //comboBoxUnidMedida.Enabled = false;
                //btnChamacli.Enabled = false;
                //btnChamafor.Enabled = false;
                //btnChamaTransp.Enabled = false;
                //btnChamaFruta.Enabled = false;

                //---------------------------------------------------------------------------

            }
            catch (Exception)
            {

                MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
            }


            //Este método pesquisa os carregamentos vinculados ao romaneio que vc selecionar com um clique duplo
       

        }

        private void progressBarSelRom_Click(object sender, EventArgs e)
        {
 
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //object[] args = (object[]) e.Argument;

            //if (args[0].Equals("Texto"))
            //{
            //    AtualizarGrid();
            //}
            //else if (args[0].Equals("Data"))
            //{
            //    AtualizarGrid2();
            //}
        }
    }
}
