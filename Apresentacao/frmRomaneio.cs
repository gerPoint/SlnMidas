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
    
   public partial class frmRomaneio : Form
    {
//------------------usado para adicionar blocos --------------------

        BindingList<objCarregamentoBloco> listCarregamento = new BindingList<objCarregamentoBloco>();

//------------------usado para adicionar blocos --------------------

        NegRomaneio negRomaneio = new NegRomaneio();

        private Romaneio objRomaneio = new Romaneio();


        public frmRomaneio()
        {
            InitializeComponent();
        }
//-------------------------------------------------- SERVE PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO FORM-----------------------------
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

        //------

        public String NomeFornecedor
        {
            get { return cpoNomeFornecedor.Text; }
            set { cpoNomeFornecedor.Text = value; }
        }

        public String IDFornecedor
        {
            get { return cpoIDFornecedor.Text; }
            set { cpoIDFornecedor.Text = value; }
        }

        //------

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
        //-------

        public String NomeFruta
        {
            get { return cpoNomeFruta.Text; }
            set { cpoNomeFruta.Text = value; }
        }

        public String IDFruta
        {
            get { return cpoIDFruta.Text; }
            set { cpoIDFruta.Text = value; }
        }



        //---------------------------------------- SERVE PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO FORM-----------------------------------
        //-----------------------------TEM QUE TER ESSAS STRINGS NO FORM QUE MANDA OS DADOS E NO FORM QUE RECEBE ------------------------------
        private void groupBox1_Enter(object sender, EventArgs e)
        {




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

                dgwRomaneio.DataSource = null;
                dgwRomaneio.DataSource = objLista;
                dgwRomaneio.Update();
                dgwRomaneio.Refresh();
                cpoCodigo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Cliente. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }




        private void frmRomaneio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetCarregBlo.tblCarregamentoBloco' table. You can move, or remove it, as needed.
            this.tblCarregamentoBlocoTableAdapter2.Fill(this.midasDataSetCarregBlo.tblCarregamentoBloco);
            // TODO: This line of code loads data into the 'midasDataSetCarregamentoBlocook.tblCarregamentoBloco' table. You can move, or remove it, as needed.
            this.tblCarregamentoBlocoTableAdapter1.Fill(this.midasDataSetCarregamentoBlocook.tblCarregamentoBloco);
            // TODO: This line of code loads data into the 'midasDataSetRomaneioCorreto.tblRomaneio' table. You can move, or remove it, as needed.
            //esse funfa porra(No caso o de baixo)
            //this.tblRomaneioTableAdapter1.Fill(this.midasDataSetRomaneioCorreto.tblRomaneio);

            // TODO: This line of code loads data into the 'midasDataSetRomaneio.tblRomaneio' table. You can move, or remove it, as needed.
            //  this.tblRomaneioTableAdapter.Fill(this.midasDataSetRomaneio.tblRomaneio);
            // TODO: This line of code loads data into the 'midasDataSetDescFormPgto.tblFormaPagamento' table. You can move, or remove it, as needed.
            //this.tblFormaPagamentoTableAdapter.Fill(this.midasDataSetDescFormPgto.tblFormaPagamento);
            // TODO: This line of code loads data into the 'midasDataSetUnidMedida.tblFruta' table. You can move, or remove it, as needed.
            // this.tblFrutaTableAdapter.Fill(this.midasDataSetUnidMedida.tblFruta);
            // TODO: This line of code loads data into the 'midasDataSetCarregbloco.tblCarregamentoBloco' table. You can move, or remove it, as needed.
            if (cpoIDRomaneio.Text == "")
            {
                
                /*tabPageCarregamento.Enabled = false;*/
            }

            tabPagePrincipal.Enabled = true;
            tabPageRomaneio.Enabled = true;
         //   tabPageCarregamento.Enabled = false;
            



            comboBoxTpoPesquisa.Text = "Código";
            mskTxtBoxDtFinal.Enabled = false;
            mskTxtBoxDtInicial.Enabled = false;

        

            string comandoSql = "Select IDFormaPagamento, Descricao from tblFormaPagamento";
            string conexao = Settings.Default.strConexao;

            SqlDataAdapter sqlDataAdapterFormaPagamento = new SqlDataAdapter(comandoSql, conexao);
            DataTable dataTableFormaPagamento = new DataTable();
            dataTableFormaPagamento.Clear();
            sqlDataAdapterFormaPagamento.Fill(dataTableFormaPagamento);
            comboBoxFormaPagamento.DataSource = dataTableFormaPagamento;
            comboBoxFormaPagamento.ValueMember = "IDFormaPagamento";
            comboBoxFormaPagamento.DisplayMember = "Descricao";
            comboBoxFormaPagamento.SelectedItem = "";
            comboBoxFormaPagamento.Refresh();

            comandoSql = "select IDFilial, RazaoSocial from tblFilial";
            SqlDataAdapter sqlDataAdapterFilial = new SqlDataAdapter(comandoSql, conexao);
            DataTable dataTableFilial = new DataTable();
            dataTableFilial.Clear();
            sqlDataAdapterFilial.Fill(dataTableFilial);
            comboBoxFilial.DataSource = dataTableFilial;
            comboBoxFilial.ValueMember = "IDFilial";
            comboBoxFilial.DisplayMember = "RazaoSocial";
            comboBoxFilial.SelectedItem = "";
            comboBoxFilial.Refresh();
           



                

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
            try
            {
                //Desabilita o click do botão ate terminar o processo
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                string strRetorno = string.Empty;

               

                if (cpoBloco.Text == "")
                {
                    MessageBox.Show("Por favor defina o Bloco! ");
                    cpoBloco.Focus();
                    return;
                }

                if (cpoQtd.Text == "")
                {
                    MessageBox.Show("Por favor informe a Quantidade! ");
                    cpoQtd.Focus();
                    return;
                }
                if (cpoDescricao.Text == "")
                {
                    MessageBox.Show("Por favor informe a descrição do Bloco! ");
                    cpoDescricao.Focus();
                    return;
                }

                dgwCarregamento.DataSource = null;

                objCarregamentoBloco novoCarregamentoBloco = new objCarregamentoBloco();
                novoCarregamentoBloco.Bloco = cpoBloco.Text;
                novoCarregamentoBloco.Quantidade = Convert.ToInt32(cpoQtd.Text);
                novoCarregamentoBloco.Descricao = cpoDescricao.Text;
                novoCarregamentoBloco.IDRomaneio = Convert.ToInt32(cpoIDRomaneio.Text);
                listCarregamento.Add(novoCarregamentoBloco);
                dgwCarregamento.DataSource = listCarregamento;

                cpoBloco.Clear();
                cpoDescricao.Clear();
                cpoQtd.Clear();


            }
            catch (Exception)
            {

            }
            finally
            {
             
                btnInserir.Click += new EventHandler(btnInserir_Click);
            }
        }

        private void btnChamacli_Click(object sender, EventArgs e)
        {
            frmSelecionarCliente OutroForm = new frmSelecionarCliente();
            OutroForm.ShowDialog();
            cpoNomeCliente.Text = OutroForm.NomeCliente;
            cpoIDCliente.Text = OutroForm.IDCliente;

        }

        private void btnChamafor_Click(object sender, EventArgs e)
        {
            frmSelecionarFornecedor OutroForm = new frmSelecionarFornecedor();
            OutroForm.ShowDialog();
            cpoNomeFornecedor.Text = OutroForm.NomeFornecedor;
            cpoIDFornecedor.Text = OutroForm.IDFornecedor;
        }

        private void btnChamaTransp_Click(object sender, EventArgs e)
        {
            frmSelecionarTransportador OutroForm = new frmSelecionarTransportador();
            OutroForm.ShowDialog();
            cpoNomeTransportador.Text = OutroForm.NomeTransportador;
            cpoIDTransportador.Text = OutroForm.IDTransportador;
        }

        private void dgwCarregamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                objCarregamentoBloco row = (dgwCarregamento.SelectedRows[0].DataBoundItem as objCarregamentoBloco);
               
                cpoDescricao.Text = row.Descricao;
                cpoQtd.Text = row.Quantidade.ToString();
                cpoBloco.Text = row.Bloco;

                this.dgwCarregamento.Rows.RemoveAt(e.RowIndex);
            }
            finally
            {
                        
            }
        }

        private void checkBoxAdiantFretMot_CheckedChanged(object sender, EventArgs e)
        {
            Verificado();
        }

        private void Verificado()
        {
            cpoAdiantFretMot.Enabled = checkBoxAdiantFretMot.Checked;

        }

        private void cpoQtd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }
        }



        private void btnChamaFruta_Click(object sender, EventArgs e)
        {

            frmSelecionarFruta OutroForm = new frmSelecionarFruta();
            OutroForm.ShowDialog();
            cpoNomeFruta.Text = OutroForm.NomeFruta;
            cpoIDFruta.Text = OutroForm.IDFruta;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Romaneio objRomaneio = new Romaneio();


            string strRetorno = string.Empty;

            if (cpoIDCliente.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoIDTransportador.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoIDFruta.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoIDFornecedor.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoQtdGeral.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            //--------------------------------------------coloca o zero onde esta vazio------------------------------------------------------

            if (cpoAdiantFretMot.Text == "") 

            {
                cpoAdiantFretMot.Text = "0";
            }

            this.objRomaneio.IDCliente = Convert.ToInt32(cpoIDCliente.Text);
            this.objRomaneio.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
            this.objRomaneio.IDFornecedor = Convert.ToInt32(cpoIDFornecedor.Text);
            this.objRomaneio.IDFruta = Convert.ToInt32(cpoIDFruta.Text);
            this.objRomaneio.ValorFrete = Convert.ToDecimal(cpoValorFrete.Text);
            this.objRomaneio.AdiantFretMot = Convert.ToDecimal(cpoAdiantFretMot.Text);
            this.objRomaneio.FormaPagamento = comboBoxFormaPagamento.Text.TrimStart();
            this.objRomaneio.CustoCarregamento = Convert.ToDecimal(cpoCustoCarreg.Text);
            this.objRomaneio.ValorComissao = Convert.ToDecimal(cpoValorComissao.Text);
            this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);
            this.objRomaneio.TaxaNf = Convert.ToDecimal(cpoTaxaNf.Text);
            this.objRomaneio.Seguro = Convert.ToDecimal(cpoSeguro.Text);
            this.objRomaneio.UnidMedida = comboBoxUnidMedida.Text.TrimStart();
            this.objRomaneio.QtdFrutas = Convert.ToInt32(cpoQtdGeral.Text);
            this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);

            

   


            NegRomaneio negRomaneio = new NegRomaneio();
            strRetorno = negRomaneio.Cadastrar(this.objRomaneio);

            try
            {


                int idRomaneio = Convert.ToInt32(strRetorno);
                //  if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: "  + idCliente.ToString() );
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idRomaneio.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // this.DialogResult = DialogResult.OK;

                    //limpa os campos depois de salvar 

                    dgwRomaneio.DataSource = null;
                    dgwRomaneio.Update();
                    dgwRomaneio.Refresh();

                    cpoNomeCliente.Clear();
                    cpoIDCliente.Clear();
                    cpoNomeFornecedor.Clear();
                    cpoIDFornecedor.Clear();
                    cpoNomeFruta.Clear();
                    cpoIDFruta.Clear();
                    cpoIDTransportador.Clear();
                    cpoNomeTransportador.Clear();
                    cpoQtdGeral.Clear();
                    cpoValorFrete.Clear();
                    cpoAdiantFretMot.Clear();
                    cpoSeguro.Clear();
                    cpoTaxaNf.Clear();
                    cpoCustoCarreg.Clear();
                    cpoValorComissao.Clear();
                    cpoValorTotalRomaneio.Clear();

                    btnSalvar.Enabled = false;


                    cpoSeguro.Enabled = true;
                    cpoTaxaNf.Enabled = true;
                    cpoValorComissao.Enabled = true;
                    cpoValorFrete.Enabled = true;
                    cpoCustoCarreg.Enabled = true;
                    //cpoAdiantFretMot.Enabled = true;
                    checkBoxAdiantFretMot.Enabled = false;


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
            }


          }

        private void cpoQtdGeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }
        }



        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblFormaPagamentoTableAdapter.FillBy(this.midasDataSetDescFormPgto.tblFormaPagamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblFormaPagamentoTableAdapter.FillBy1(this.midasDataSetDescFormPgto.tblFormaPagamento);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void cpoValorFrete_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpoTaxaNf_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpoAdiantFretMot_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }


        private void cpoValorTotalRomaneio_KeyDown(object sender, KeyEventArgs e)
        {

         }

        private void cpoValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }

        private void cpoSeguro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }

        private void cpoTaxaNf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }

        private void cpoCustoCarreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))

            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }


            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }


        }

        private void cpoValorComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }

        private void btnTotalizar_Click(object sender, EventArgs e)
        {


            try

            {

                if (cpoCustoCarreg.Text == "")
                {
                    MessageBox.Show("Custo Carregamento não informado.");
                    return;
                }

                if (cpoValorFrete.Text == "")
                {
                    MessageBox.Show("Valor do Frete não informado.");
                    return;
                }

                if (cpoTaxaNf.Text == "")
                {
                    MessageBox.Show("Taxa da Nota Fiscal não informada.");
                    return;
                }

                if (cpoSeguro.Text == "")
                {
                    MessageBox.Show("Valor do Seguro não informado.");
                    return;
                }

                if (cpoValorComissao.Text == "")
                {
                    MessageBox.Show("Valor da Comissão não informado.");
                    return;
                }


                cpoValorTotalRomaneio.Clear();


                Decimal valor1, valor2, valor3, valor4, valor5, valor6, resultado;
                valor1 = Convert.ToDecimal(cpoTaxaNf.Text);
                valor2 = Convert.ToDecimal(cpoValorComissao.Text);
                valor3 = Convert.ToDecimal(cpoValorFrete.Text);
                valor4 = Convert.ToDecimal(cpoSeguro.Text);
                valor5 = Convert.ToDecimal(cpoCustoCarreg.Text);
                valor6 = Convert.ToDecimal(cpoAdiantFretMot.Text);
                resultado = valor1 + valor2 + valor3 + valor4 + valor5 - valor6;
                cpoValorTotalRomaneio.Text = resultado.ToString();
           //     cpoValorTotalRomaneio.Text - cpoAdiantFretMot.Text = resultado.ToString()

                cpoSeguro.Enabled = false;
                cpoTaxaNf.Enabled = false;
                cpoValorComissao.Enabled = false;
                cpoValorFrete.Enabled = false;
                cpoCustoCarreg.Enabled = false;
                cpoAdiantFretMot.Enabled = false;
                checkBoxAdiantFretMot.Enabled = false;


                btnSalvar.Enabled = true;






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }

   
        }




        private void cpoValorTotalRomaneio_TextChanged(object sender, EventArgs e)
        {
 


        }

        private void btnRevisarValores_Click(object sender, EventArgs e)
        {

            cpoValorTotalRomaneio.Clear();


            cpoSeguro.Enabled = true;
            cpoTaxaNf.Enabled = true;
            cpoValorComissao.Enabled = true;
            cpoValorFrete.Enabled = true;
            cpoCustoCarreg.Enabled = true;
            //cpoAdiantFretMot.Enabled = true;
            checkBoxAdiantFretMot.Enabled = true;

            btnSalvar.Enabled = false;
        }

        private void cpoAdiantFretMot_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.dgwCarregamento.Rows.Remove(this.dgwCarregamento.CurrentRow);
            this.dgwCarregamento.Refresh();
        }

        private void comboBoxTpoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTpoPesquisa.Text == "Código")
            {
                cpoCodigo.Enabled = true;
                mskTxtBoxDtFinal.Enabled = false;
                mskTxtBoxDtInicial.Enabled = false;
            }
            else
            {
                cpoCodigo.Enabled = false;
                mskTxtBoxDtFinal.Enabled = true;
                mskTxtBoxDtInicial.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (comboBoxTpoPesquisa.Text == "Código")
            {
                AtualizarGrid();
            }
            else
            {
               
            }
        }

        private void cpoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                this.AtualizarGrid();
        }

        private void dgwRomaneio_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               Romaneio romaneio = (dgwRomaneio.SelectedRows[0].DataBoundItem as Romaneio);
                cpoIDRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[0].Value.ToString();
                cpoIDCliente.Text = dgwRomaneio.SelectedRows[0].Cells[1].Value.ToString();
                cpoIDTransportador.Text = dgwRomaneio.SelectedRows[0].Cells[2].Value.ToString();
                cpoIDFornecedor.Text = dgwRomaneio.SelectedRows[0].Cells[3].Value.ToString();
                cpoIDFruta.Text = dgwRomaneio.SelectedRows[0].Cells[4].Value.ToString();
                cpoQtdGeral.Text = dgwRomaneio.SelectedRows[0].Cells[5].Value.ToString();
          //    cpoIDCarregamento.Text = dgwRomaneio.SelectedRows[0].Cells[3].Value.ToString();
                cpoValorFrete.Text = dgwRomaneio.SelectedRows[0].Cells[7].Value.ToString();
                cpoSeguro.Text = dgwRomaneio.SelectedRows[0].Cells[8].Value.ToString();
                cpoAdiantFretMot.Text = dgwRomaneio.SelectedRows[0].Cells[9].Value.ToString();
                comboBoxFormaPagamento.Text = dgwRomaneio.SelectedRows[0].Cells[10].Value.ToString();
                cpoCustoCarreg.Text = dgwRomaneio.SelectedRows[0].Cells[11].Value.ToString();
                cpoValorComissao.Text = dgwRomaneio.SelectedRows[0].Cells[12].Value.ToString();
                cpoValorTotalRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[13].Value.ToString();
                cpoTaxaNf.Text = dgwRomaneio.SelectedRows[0].Cells[14].Value.ToString();
                comboBoxUnidMedida.Text = dgwRomaneio.SelectedRows[0].Cells[15].Value.ToString();
                cpoMostraCodRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[0].Value.ToString();


                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;


             //   tabPageCarregamento.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
            }
        }



        private void btnRetornar_Click(object sender, EventArgs e)
        {
            cpoIDRomaneio.Clear();
            cpoIDCliente.Clear();
            cpoNomeCliente.Clear();
            cpoIDFornecedor.Clear();
            cpoNomeFornecedor.Clear();
            cpoIDTransportador.Clear();
            cpoNomeTransportador.Clear();
            cpoIDFruta.Clear();
            cpoNomeFruta.Clear();
            cpoQtdGeral.Clear();
            cpoCustoCarreg.Clear();
            cpoAdiantFretMot.Clear();
            cpoValorFrete.Clear();
            cpoTaxaNf.Clear();
            cpoSeguro.Clear();
            cpoValorComissao.Clear();
            cpoValorTotalRomaneio.Clear();

        }

        private void tabPageCarregamento_Click(object sender, EventArgs e)
        {
            if (cpoIDRomaneio.Text != null)
            {
                tabPageCarregamento.Visible = true;
                tabPageCarregamento.Enabled = true;
            }
        }
    }

    }








