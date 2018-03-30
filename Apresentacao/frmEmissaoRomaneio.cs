using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlnMidas.Relatorio;
using AcessoDados;
using Negocio;
using ObjTransferencia;
using System.Data.SqlClient;
using Apresentacao.Properties;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Reporting.WebForms;
using System.Diagnostics;
using System.Drawing.Printing;



namespace Apresentacao
{
    public partial class frmEmissaoRomaneio : Form
    {
        public frmEmissaoRomaneio()
        {
            InitializeComponent();
        }

        Relatorio rel = new Relatorio();
        List<CarregamentoBloco> listCarreg = new List<CarregamentoBloco>();
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



        }


        private void printDocumentImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 112));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 142));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 172));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 202));

            e.Graphics.DrawImage(pictureBoxTitulo.Image, 15, 15, pictureBoxTitulo.Width, pictureBoxTitulo.Height);
            e.Graphics.DrawString(lblCliente.Text, lblCliente.Font, Brushes.Black, new Point(62, 100));
            e.Graphics.DrawString(cpoCliente.Text, cpoCliente.Font, Brushes.Black, new Point(108, 100));
            e.Graphics.DrawString(lblFornecedor.Text, lblFornecedor.Font, Brushes.Black, new Point(36, 130));
            e.Graphics.DrawString(cpoFornecedor.Text, cpoCliente.Font, Brushes.Black, new Point(108, 130));
            e.Graphics.DrawString(lblTransportador.Text, lblTransportador.Font, Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString(cpoTransportador.Text, cpoTransportador.Font, Brushes.Black, new Point(108, 160));
            e.Graphics.DrawString(lblFruta.Text, lblFruta.Font, Brushes.Black, new Point(69, 190));
            e.Graphics.DrawString(cpoFruta.Text, cpoFruta.Font, Brushes.Black, new Point(108, 190));
            e.Graphics.DrawString(lblUnidMedida.Text, lblUnidMedida.Font, Brushes.Black, new Point(398, 100));
            e.Graphics.DrawString(cpoUnidMedida.Text, cpoUnidMedida.Font, Brushes.Black, new Point(495, 100));
            e.Graphics.DrawString(lblFormaPagamento.Text, lblFormaPagamento.Font, Brushes.Black, new Point(369, 130));
            e.Graphics.DrawString(cpoFormaPagamento.Text, cpoFormaPagamento.Font, Brushes.Black, new Point(495, 130));
            e.Graphics.DrawString(lblComissao.Text, lblComissao.Font, Brushes.Black, new Point(430, 160));
            e.Graphics.DrawString(cpoValorComissao.Text, cpoValorComissao.Font, Brushes.Black, new Point(495, 160));
            e.Graphics.DrawString(lblCustoCarreg.Text, lblCustoCarreg.Font, Brushes.Black, new Point(372, 190));
            e.Graphics.DrawString(cpoCustoCarreg.Text, cpoCustoCarreg.Font, Brushes.Black, new Point(495, 190));
            e.Graphics.DrawString(lblAdiantFretMot.Text, lblAdiantFretMot.Font, Brushes.Black, new Point(630, 100));
            e.Graphics.DrawString(cpoAdiantFretMot.Text, cpoAdiantFretMot.Font, Brushes.Black, new Point(725, 100));
            e.Graphics.DrawString(lblFrete.Text, lblFrete.Font, Brushes.Black, new Point(688, 130));
            e.Graphics.DrawString(cpoValorFrete.Text, cpoValorFrete.Font, Brushes.Black, new Point(725, 130));
            e.Graphics.DrawString(lblTaxaNf.Text, lblTaxaNf.Font, Brushes.Black, new Point(671, 160));
            e.Graphics.DrawString(cpoTaxaNf.Text, cpoTaxaNf.Font, Brushes.Black, new Point(725, 160));
            e.Graphics.DrawString(lblSeguro.Text, lblSeguro.Font, Brushes.Black, new Point(677, 190));
            e.Graphics.DrawString(cpoSeguro.Text, cpoSeguro.Font, Brushes.Black, new Point(725, 190));


            //e.Graphics.DrawString(dgwEmissaoRomaneio.Rows[0].Cells[1].Value.ToString(), Font, Brushes.Black, 25, 220);
            //e.Graphics.DrawString(dgwEmissaoRomaneio.Rows[0].Cells[2].Value.ToString(), Font, Brushes.Black, 75, 220);
            //e.Graphics.DrawString(dgwEmissaoRomaneio.Rows[0].Cells[3].Value.ToString(), Font, Brushes.Black, 130, 220);


            e.Graphics.DrawString("Bloco", DataGridView.DefaultFont, Brushes.Black, new Rectangle(100, 200, 200, 100));
            e.Graphics.DrawString(dgwEmissaoRomaneio.Rows[0].Cells[3].Value.ToString(), DataGridView.DefaultFont, Brushes.Black, new Rectangle(100, 200, 200, 100));
           

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
        void setarParametros()
        {
            
            rel.CaminhoRelatorio = "SlnMidas.Relatorio.RLDC.REL001.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "003");
            rel.AdicionarParametro("Titulo", "FORNECEDORES");
            rel.AdicionarParametro("SubTitulo", "Relatório Fornecedores");

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            //if (printDialogImprimir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    printDocumentImprimir.PrinterSettings = printDialogImprimir.PrinterSettings;
            //    printDocumentImprimir.Print();
            //    printDialogImprimir.Reset();

            //}
            try
            {

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ImprimirRelatorio";
                args[1] = Convert.ToInt32(cpoIDRomaneio.Text);
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cpoIDRomaneio_TextChanged(object sender, EventArgs e)
        {
            if (cpoIDRomaneio != null)
            {
                AtualizarGrid3();
              
            }
           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
  

            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao.RelatórioFinalRomaneio.rdlc"; //caminho para encontra o relatório (no caso esta dentro de apresentacao) 

            //(parametros)para pegar da tela e mandar para o relatório

            List<ReportParameter> listReportParameter = new List<ReportParameter>();
            listReportParameter.Add(new ReportParameter("CodRomaneio", cpoIDRomaneio.Text));
            listReportParameter.Add(new ReportParameter("Cliente", cpoCliente.Text));
            listReportParameter.Add(new ReportParameter("Fornecedor", cpoFornecedor.Text));
            listReportParameter.Add(new ReportParameter("Transportador", cpoTransportador.Text));
            listReportParameter.Add(new ReportParameter("Fruta", cpoFruta.Text));
            listReportParameter.Add(new ReportParameter("FormaPagamento", cpoFormaPagamento.Text));
            listReportParameter.Add(new ReportParameter("UnidMedida", cpoUnidMedida.Text));
            listReportParameter.Add(new ReportParameter("Comissao", cpoValorComissao.Text));
            listReportParameter.Add(new ReportParameter("CustoCarreg", cpoCustoCarreg.Text));
            listReportParameter.Add(new ReportParameter("AdiantFretMot", cpoAdiantFretMot.Text));
            listReportParameter.Add(new ReportParameter("Frete", cpoValorFrete.Text));
            listReportParameter.Add(new ReportParameter("TaxaNf", cpoTaxaNf.Text));
            listReportParameter.Add(new ReportParameter("Seguro", cpoSeguro.Text));
            listReportParameter.Add(new ReportParameter("QuantidadeTot", cpoQtdGeral.Text));
            listReportParameter.Add(new ReportParameter("ValorTotalRomaneio", cpoValorTotalRomaneio.Text)); 

           // CarregamentoBloco CarregBloc = (dgwEmissaoRomaneio.SelectedRows[0].DataBoundItem as CarregamentoBloco);
            //listReportParameter.Add(new ReportParameter ("IDCarregamentoBloco", dgwEmissaoRomaneio.RowsDefaultCellStyle));
            //listReportParameter.Add(new ReportParameter("Bloco", dgwEmissaoRomaneio.SelectedRows[0].Cells[1].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("Descricao", dgwEmissaoRomaneio.SelectedRows[0].Cells[1].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("FrutaP", dgwEmissaoRomaneio.SelectedRows[0].Cells[2].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("FrutaM", dgwEmissaoRomaneio.SelectedRows[0].Cells[3].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("FrutaG", dgwEmissaoRomaneio.SelectedRows[0].Cells[5].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("QtdP", dgwEmissaoRomaneio.SelectedRows[0].Cells[6].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("QtdM", dgwEmissaoRomaneio.SelectedRows[0].Cells[7].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("QtdG", dgwEmissaoRomaneio.SelectedRows[0].Cells[8].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("ValorUnitP", dgwEmissaoRomaneio.SelectedRows[0].Cells[9].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("ValorUnitM", dgwEmissaoRomaneio.SelectedRows[0].Cells[10].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("ValorUnitG", dgwEmissaoRomaneio.SelectedRows[0].Cells[11].Value.ToString()));
            //listReportParameter.Add(new ReportParameter("TotalBloco", dgwEmissaoRomaneio.SelectedRows[0].Cells[13].Value.ToString()));



            reportViewer.LocalReport.SetParameters(listReportParameter);

            //datatable







            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytePDF = reportViewer.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);
          //  byte[] byteExcel = reportViewer.LocalReport.Render("Xls", null, out mimeType, out encoding, out extension, out streamids, out warnings);

         
            FileStream fileStreamPDF = null;
           // FileStream fileStreamXLS = null;

            string nomeArquivoPDF = Path.GetTempPath() // este metodo pega o arquivo na pasta "temp' do windows 
                + " RomaneioGerado"//nome que será salvo o arquivo na pasta temp
                + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss")  //Data e Hora que o arquivo foi salvo - colocamos isso pra nao dar erro dizendo que ja existe arquivo com este nome 
                + ".pdf";  //extensao do arquivo - tem que por

            // string nomeArquivoExcel = Path.GetTempPath() + " RomaneioGerado" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".xls";

            fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);// este modo que faz a criacao do arquivo
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();

            Process.Start(nomeArquivoPDF);//abre o arquivo que foi salvo na pasta temp

        }

        private void C(object sender, EventArgs e)
        {

        }

        private void lblAdiantFretMot_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds;
            object[] args = (object[])e.Argument;
            if (args[0].Equals("ImprimirRelatorio"))
            {
                ds = negRomaneio.RelRomaneio((int)args[1]);
                this.rel.DataTable1 = ds.Tables[0];
                this.rel.DataTable2 = ds.Tables[1];
                setarParametros();
                rel.Imprimir();
            }
        }
    }
}