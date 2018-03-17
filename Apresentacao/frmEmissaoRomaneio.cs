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
using System.Data.SqlClient;
using Apresentacao.Properties;

namespace Apresentacao
{
    public partial class frmEmissaoRomaneio : Form
    {
        public frmEmissaoRomaneio()
        {
            InitializeComponent();
        }
//----------------------------------------------------------------------------
        //public frmEmissaoRomaneio(/*string texto1 , string texto2 , string texto3, string texto4, string texto5, string texto6, string texto7, string texto8, string texto9, string texto10, string texto11, string texto12, string texto13, string texto14, string texto15*/)
        //{
        //    InitializeComponent();
        //    //cpoIDRomaneio.Text = 
        //    //cpoCliente.Text = texto1;
        //    //cpoFornecedor.Text = texto2;
        //    //cpoTransportador.Text = texto3;
        //    //cpoFruta.Text = texto4;
        //    //cpoFormaPagamento.Text = texto5;
        //    //cpoUnidMedida.Text = texto6;
        //    //cpoValorComissao.Text = texto7;
        //    //cpoCustoCarreg.Text = texto8;
        //    //cpoAdiantFretMot.Text = texto9;
        //    //cpoValorFrete.Text = texto10;
        //    //cpoTaxaNf.Text = texto11;
        //    //cpoSeguro.Text = texto12;
        //    //cpoQtdGeral.Text = texto13;
        //    //cpoValorTotalRomaneio.Text = texto15;      
        //}




//-----------------------------------------------------------------------------
        NegRomaneio negRomaneio = new NegRomaneio();

        private Romaneio objRomaneio = new Romaneio();


     

        private void frmEmissaoRomaneio_Load(object sender, EventArgs e)
        {
            if (cpoIDRomaneio.Text != null)
            {
                
            }
        }


        private void printDocumentImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(pictureBoxTitulo.Image,15,15, pictureBoxTitulo.Width,pictureBoxTitulo.Height);
            e.Graphics.DrawString(lblCliente.Text, lblCliente.Font, Brushes.Black, new Point(62, 100));
            e.Graphics.DrawString(cpoCliente.Text, cpoCliente.Font, Brushes.Black, new Point(108, 100));
            e.Graphics.DrawString(lblFornecedor.Text, lblFornecedor.Font, Brushes.Black, new Point(36, 120));
            e.Graphics.DrawString(cpoFornecedor.Text, cpoCliente.Font, Brushes.Black, new Point(108, 120));
            e.Graphics.DrawString(lblTransportador.Text, lblTransportador.Font, Brushes.Black, new Point(20, 140));
            e.Graphics.DrawString(cpoTransportador.Text, cpoTransportador.Font, Brushes.Black, new Point(108, 140));
            e.Graphics.DrawString(lblFruta.Text, lblFruta.Font, Brushes.Black, new Point(69, 160));
            e.Graphics.DrawString(cpoFruta.Text, cpoFruta.Font, Brushes.Black, new Point(108, 160));
            e.Graphics.DrawString(lblUnidMedida.Text, lblUnidMedida.Font, Brushes.Black, new Point(398, 100));
            e.Graphics.DrawString(cpoUnidMedida.Text, cpoUnidMedida.Font, Brushes.Black, new Point(495, 100));
            e.Graphics.DrawString(lblFormaPagamento.Text, lblFormaPagamento.Font, Brushes.Black, new Point(369, 120));
            e.Graphics.DrawString(cpoFormaPagamento.Text, cpoFormaPagamento.Font, Brushes.Black, new Point(495, 120));
            e.Graphics.DrawString(lblComissao.Text, lblComissao.Font, Brushes.Black, new Point(430, 140));
            e.Graphics.DrawString(cpoValorComissao.Text, cpoValorComissao.Font, Brushes.Black, new Point(495, 140));
            e.Graphics.DrawString(lblCustoCarreg.Text, lblCustoCarreg.Font, Brushes.Black, new Point(372, 160));
            e.Graphics.DrawString(cpoCustoCarreg.Text, cpoCustoCarreg.Font, Brushes.Black, new Point(495, 160));
            e.Graphics.DrawString(lblAdiantFretMot.Text, lblAdiantFretMot.Font, Brushes.Black, new Point(630, 100));
            e.Graphics.DrawString(cpoAdiantFretMot.Text, cpoAdiantFretMot.Font, Brushes.Black, new Point(725, 100));
            e.Graphics.DrawString(lblFrete.Text, lblFrete.Font, Brushes.Black, new Point(688, 120));
            e.Graphics.DrawString(cpoValorFrete.Text, cpoValorFrete.Font, Brushes.Black, new Point(725, 120));
            e.Graphics.DrawString(lblTaxaNf.Text, lblTaxaNf.Font, Brushes.Black, new Point(671, 140));
            e.Graphics.DrawString(cpoTaxaNf.Text, cpoTaxaNf.Font, Brushes.Black, new Point(725, 140));
            e.Graphics.DrawString(lblSeguro.Text, lblSeguro.Font, Brushes.Black, new Point(677, 160));
            e.Graphics.DrawString(cpoSeguro.Text, cpoSeguro.Font, Brushes.Black, new Point(725, 160));



        }




        private void AtualizarGrid3()
        {
            try
            {
                if (cpoIDRomaneio.Text == "")
                {
                    MessageBox.Show("Por favor, informe o Codigo do Romaneio para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoIDRomaneio.Text = string.Empty;
                    cpoIDRomaneio.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegCarregamentoBloco objNegCarreg = new NegCarregamentoBloco();
                ListaCarregamentoBloco objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegCarreg.ConsultarCarreg(cpoIDRomaneio.Text);
                }
                catch
                {

                    objLista = objNegCarreg.ConsultarCarreg(cpoIDRomaneio.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoIDRomaneio.Text = string.Empty;
                    cpoIDRomaneio.Focus();
                    return;
                }

                dgwEmissaoRomaneio.DataSource = null;
                dgwEmissaoRomaneio.DataSource = objLista;
                dgwEmissaoRomaneio.Update();
                dgwEmissaoRomaneio.Refresh();
                dgwEmissaoRomaneio.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Carregamento. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }









        private void cpoFormaPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultaRomaneio_Click(object sender, EventArgs e)
        {


            //essa parte que pega os dados de um form e passa para outro

            try
            {
                using (frmSelecionarRomaneio outroForm = new frmSelecionarRomaneio())
                {
                    if (outroForm.ShowDialog() == DialogResult.OK)
                    {
                        cpoIDRomaneio.Text = outroForm.IDRomaneio;
                        cpoCliente.Text = outroForm.Nomecliente;
                        cpoFornecedor.Text = outroForm.NomeFornecedor;
                        cpoTransportador.Text = outroForm.NomeTransportador;
                        cpoFruta.Text = outroForm.NomeFruta;
                        cpoFormaPagamento.Text = outroForm.FormaPagamento;
                        cpoUnidMedida.Text = outroForm.UnidMedida;
                        cpoQtdGeral.Text = outroForm.QtdGeral;
                        cpoValorFrete.Text = outroForm.ValorFrete;
                        cpoCustoCarreg.Text = outroForm.CustoCarreg;
                        cpoValorComissao.Text = outroForm.ValorComissao;
                        cpoAdiantFretMot.Text = outroForm.AdiantFretMot;
                        cpoSeguro.Text = outroForm.Seguro;
                        cpoTaxaNf.Text = outroForm.TaxaNF;
                        cpoValorTotalRomaneio.Text = outroForm.ValorTotalRomaneio;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (printDialogImprimir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentImprimir.PrinterSettings = printDialogImprimir.PrinterSettings;
                printDocumentImprimir.Print();
                printDialogImprimir.Reset();
            }

        }

        private void cpoIDRomaneio_TextChanged(object sender, EventArgs e)
        {
            if (cpoIDRomaneio != null)
            {
                AtualizarGrid3();
            }
            
        }
    }
}
