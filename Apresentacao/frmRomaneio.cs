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

        BindingList<CarregamentoBloco> listCarregamento = new BindingList<CarregamentoBloco>();

        //------------------usado para adicionar blocos --------------------

        NegRomaneio negRomaneio = new NegRomaneio();

        private Romaneio objRomaneio = new Romaneio();


        NegCarregamentoBloco negCarreg = new NegCarregamentoBloco();

        CarregamentoBloco objCarreg = new CarregamentoBloco();



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
                MessageBox.Show("Falha ao consultar Romaneio. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


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

                dgwRomaneio.DataSource = null;
                dgwRomaneio.DataSource = objLista;
                dgwRomaneio.Update();
                dgwRomaneio.Refresh();
                cpoCodigo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Romaneio. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }


        private void frmRomaneio_Load(object sender, EventArgs e)
        {


            tabPagePrincipal.Enabled = true;
            tabPageRomaneio.Enabled = true;
            //   tabPageCarregamento.Enabled = false;




            comboBoxTpoPesquisa.Text = "Código";
            cpoDtFinal.Enabled = false;
            cpoDtInicial.Enabled = false;


 //-------- seleção combobox puxando direto da tabela pelo select----------------------------

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




//-------- seleção combobox puxando direto da tabela pelo select----------------------------

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



                if (cpoMostraCodRomaneio.Text == "")
                {
                    MessageBox.Show("Para Adição dos blocos é necessário selecionar o Romaneio.");
                    return;
                }

                if (cpoBloco.Text == "")
                {
                    MessageBox.Show("Por favor, defina o Bloco! ");
                    cpoBloco.Focus();
                    return;
                }


                if (cpoDescricao.Text == "")
                {
                    MessageBox.Show("Por favor, informe a descrição do Bloco! ");
                    cpoDescricao.Focus();
                    return;
                }

                dgwCarregamento.DataSource = null;

                //-------------------------------------------COLOCAR UM DÍGITO VAZIO NA STRING E ZERO ONDE FOR VAZIO----------------------




                if (cpoFrutaP.Text == "")
                {
                    cpoFrutaP.Text = "";

                }


                if (cpoFrutaM.Text == "")
                {
                    cpoFrutaM.Text = "";

                }


                if (cpoFrutaG.Text == "")
                {
                    cpoFrutaG.Text = "";

                }

                if (cpoPrecoP.Text == "")
                {
                    cpoPrecoP.Text = "0";
                }


                if (cpoPrecoM.Text == "")
                {
                    cpoPrecoM.Text = "0";
                }


                if (cpoPrecoG.Text == "")
                {
                    cpoPrecoG.Text = "0";
                }
              



                if (cpoQtdP.Text == "")
                {
                    cpoQtdP.Text = "0";
                }

                if (cpoQtdM.Text == "")
                {
                    cpoQtdM.Text = "0";
                }

                if (cpoQtdG.Text == "")
                {
                    cpoQtdG.Text = "0";
                }
 

                //-----------------------Soma dAS QUANTIDADES  das frutas PEQUENA , MEDIA E GRANDE e também PREÇOS TOTAIS PEQUENO MEDIO E GRANDE-------------------

                if (cpoQtdP.Text + cpoQtdM.Text + cpoQtdG.Text + cpoPrecoTotalP.Text + cpoPrecoTotalM.Text + cpoPrecoTotalG.Text != "")
                {
                    cpoSomaQtd.Text = (Convert.ToDecimal(cpoQtdP.Text) + Convert.ToDecimal(cpoQtdM.Text) + Convert.ToDecimal(cpoQtdG.Text)).ToString();
                    cpoSomaPreco.Text = (Convert.ToDecimal(cpoPrecoTotalP.Text) + Convert.ToDecimal(cpoPrecoTotalM.Text) + Convert.ToDecimal(cpoPrecoTotalG.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, informe a Quantidade da Fruta a ser adicionada! ");
                    cpoDescricao.Focus();
                    return;
                }



                //-----------------------soma dos valores totais das frutas PEQUENA , MEDIA E GRANDE e também PREÇOS TOTAIS PEQUENO MEDIO E GRANDE-------------------


                dgwCarregamento.Rows.Add
                (cpoIDRomaneio.Text, cpoBloco.Text, cpoDescricao.Text, cpoFrutaP.Text, cpoFrutaM.Text, cpoFrutaG.Text, cpoPrecoP.Text, cpoPrecoM.Text, cpoPrecoG.Text, cpoQtdP.Text, cpoQtdM.Text, cpoQtdG.Text, cpoSomaQtd.Text, cpoPrecoTotalP.Text, cpoPrecoTotalM.Text, cpoPrecoTotalG.Text, cpoSomaPreco.Text,cpoTotalCarregamento.Text, cpoIDCarregamento.Text);

                //-------- tem que ser na sequencia de ordem do dataset---------------------
            }


      

            //-----------------------------------------------------------------------------------------------
 

            catch (Exception)
            {

            }
            finally
            {

                btnInserir.Click += new EventHandler(btnInserir_Click);
            }



            decimal soma = 0;

            foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                soma += Convert.ToDecimal(dr.Cells[16].Value);
            cpoTotalCarregamento.Text = Convert.ToString(soma);





            decimal somaQtd = 0;

            foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                somaQtd += Convert.ToDecimal(dr.Cells[12].Value);
            cpoQtdCarregada.Text = Convert.ToString(somaQtd);






            cpoDescricao.Clear();
            cpoBloco.Clear();
            cpoFrutaP.Clear();
            cpoFrutaM.Clear();
            cpoFrutaG.Clear();
            cpoPrecoP.Clear();
            cpoPrecoM.Clear();
            cpoPrecoG.Clear();
            cpoQtdP.Clear();
            cpoQtdM.Clear();
            cpoQtdG.Clear();
            cpoPrecoTotalP.Clear();
            cpoPrecoTotalM.Clear();
            cpoPrecoTotalG.Clear();
            cpoSomaPreco.Clear();
            cpoSomaQtd.Clear();




            cpoPrecoP.Enabled = true;
            cpoQtdP.Enabled = true;
            cpoFrutaP.Enabled = true;
            cpoPrecoTotalP.Clear();
            cpoPrecoTotalP.Enabled = false;

            cpoPrecoM.Enabled = true;
            cpoQtdM.Enabled = true;
            cpoFrutaM.Enabled = true;
            cpoPrecoTotalM.Clear();
            cpoPrecoTotalM.Enabled = false;

            cpoPrecoG.Enabled = true;
            cpoQtdG.Enabled = true;
            cpoFrutaG.Enabled = true;
            cpoPrecoTotalG.Clear();
            cpoPrecoTotalG.Enabled = false;

            cpoBloco.Enabled = true;
            cpoDescricao.Enabled = true;

            btnInserir.Enabled = false;
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

                CarregamentoBloco row = (dgwCarregamento.SelectedRows[0].DataBoundItem as CarregamentoBloco);

                cpoIDCarregamento.Text = dgwCarregamento.SelectedRows[0].Cells[0].Value.ToString();
                cpoBloco.Text = dgwCarregamento.SelectedRows[0].Cells[1].Value.ToString();
                cpoDescricao.Text = dgwCarregamento.SelectedRows[0].Cells[2].Value.ToString();
                cpoFrutaP.Text = dgwCarregamento.SelectedRows[0].Cells[3].Value.ToString();
                cpoFrutaM.Text = dgwCarregamento.SelectedRows[0].Cells[4].Value.ToString();
                cpoFrutaG.Text = dgwCarregamento.SelectedRows[0].Cells[5].Value.ToString();
                cpoPrecoP.Text = dgwCarregamento.SelectedRows[0].Cells[6].Value.ToString();                       
                cpoPrecoM.Text = dgwCarregamento.SelectedRows[0].Cells[7].Value.ToString();
                cpoPrecoG.Text = dgwCarregamento.SelectedRows[0].Cells[8].Value.ToString();
                cpoQtdP.Text = dgwCarregamento.SelectedRows[0].Cells[9].Value.ToString();
                cpoQtdM.Text = dgwCarregamento.SelectedRows[0].Cells[10].Value.ToString();
                cpoQtdG.Text = dgwCarregamento.SelectedRows[0].Cells[11].Value.ToString();
                cpoSomaQtd.Text = dgwCarregamento.SelectedRows[0].Cells[12].Value.ToString();
                cpoPrecoTotalP.Text = dgwCarregamento.SelectedRows[0].Cells[13].Value.ToString();
                cpoPrecoTotalM.Text = dgwCarregamento.SelectedRows[0].Cells[14].Value.ToString();
                cpoPrecoTotalG.Text = dgwCarregamento.SelectedRows[0].Cells[15].Value.ToString();
                cpoSomaPreco.Text = dgwCarregamento.SelectedRows[0].Cells[16].Value.ToString();
                
                
                

                this.dgwCarregamento.Rows.RemoveAt(e.RowIndex);


                decimal subtracao = 0;


                foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                    subtracao -= Convert.ToDecimal(dr.Cells[16].Value);
                cpoTotalCarregamento.Text = Convert.ToString(subtracao);
                cpoTotalCarregamento.Text = cpoTotalCarregamento.Text.Replace("-", "");// O MÉTODO REPLACE TIRA O SINAL QUE ESTA NA PRIMEIRA ASPAS"" E TROCA PELO VALOR QUE ESTA NA SEGUNDA ASPAS""(OU SEJA ..PEGA A PRIMEIRA E TROCA PELA SEGUNDA)



                decimal subtracaoQtd = 0;

                foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                    subtracaoQtd -= Convert.ToDecimal(dr.Cells[12].Value);
                cpoQtdCarregada.Text = Convert.ToString(subtracaoQtd);
                cpoQtdCarregada.Text = cpoQtdCarregada.Text.Replace("-", "");// O MÉTODO REPLACE TIRA O SINAL QUE ESTA NA PRIMEIRA ASPAS"" E TROCA PELO VALOR QUE ESTA NA SEGUNDA ASPAS""(OU SEJA ..PEGA A PRIMEIRA E TROCA PELA SEGUNDA)




                cpoPrecoP.Enabled = true;
                cpoQtdP.Enabled = true;
                cpoFrutaP.Enabled = true;
                cpoPrecoTotalP.Clear();
                cpoPrecoTotalP.Enabled = false;

                cpoPrecoM.Enabled = true;
                cpoQtdM.Enabled = true;
                cpoFrutaM.Enabled = true;
                cpoPrecoTotalM.Clear();
                cpoPrecoTotalM.Enabled = false;

                cpoPrecoG.Enabled = true;
                cpoQtdG.Enabled = true;
                cpoFrutaG.Enabled = true;
                cpoPrecoTotalG.Clear();
                cpoPrecoTotalG.Enabled = false;


            }
            catch (Exception ex )
            {

                 MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
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
//------------------------------------------------------------------------------------------------------------------
            this.objRomaneio.IDCliente = Convert.ToInt32(cpoIDCliente.Text);
            this.objRomaneio.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
            this.objRomaneio.IDFornecedor = Convert.ToInt32(cpoIDFornecedor.Text);
            this.objRomaneio.IDFruta = Convert.ToInt32(cpoIDFruta.Text);
            this.objRomaneio.ValorFrete = Convert.ToDecimal(cpoValorFrete.Text);
            this.objRomaneio.AdiantFretMot = Convert.ToDecimal(cpoAdiantFretMot.Text);
            this.objRomaneio.FormaPagamento = Convert.ToString(comboBoxFormaPagamento.Text);
            this.objRomaneio.CustoCarregamento = Convert.ToDecimal(cpoCustoCarreg.Text);
            this.objRomaneio.ValorComissao = Convert.ToDecimal(cpoValorComissao.Text);
            this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);
            this.objRomaneio.TaxaNf = Convert.ToDecimal(cpoTaxaNf.Text);
            this.objRomaneio.Seguro = Convert.ToDecimal(cpoSeguro.Text);
            this.objRomaneio.UnidMedida = Convert.ToString(comboBoxUnidMedida.Text);
            this.objRomaneio.QtdFrutas = Convert.ToInt32(cpoQtdGeral.Text);
            this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);
            this.objRomaneio.Cliente = Convert.ToString(cpoNomeCliente.Text);
            this.objRomaneio.Transportador = Convert.ToString(cpoNomeTransportador.Text);
            this.objRomaneio.Fornecedor = Convert.ToString(cpoNomeFornecedor.Text);
            this.objRomaneio.Fruta = Convert.ToString(cpoNomeFruta.Text);







            NegRomaneio negRomaneio = new NegRomaneio();
            strRetorno = negRomaneio.Cadastrar(this.objRomaneio);

            try
            {


                int idRomaneio = Convert.ToInt32(strRetorno);

                {

                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idRomaneio.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //limpa os campos depois de salvar 

                    dgwRomaneio.Update();
                    dgwRomaneio.Refresh();

                    if (this.dgwRomaneio.DataSource != null)
                    {
                        this.dgwRomaneio.DataSource = null;
                    }
                    else
                    {
                        this.dgwRomaneio.Rows.Clear();

                    }

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
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoAdiantFretMot.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }


        private void cpoValorTotalRomaneio_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cpoValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoValorFrete.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cpoSeguro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoSeguro.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cpoTaxaNf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoTaxaNf.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cpoCustoCarreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoCustoCarreg.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }




        }

        private void cpoValorComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoValorComissao.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
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

                if (cpoAdiantFretMot.Text == "")
                {

                    cpoAdiantFretMot.Text = "0";
                }
                cpoValorTotalRomaneio.Clear();


                Decimal valor1, valor2, valor3, valor4, valor5, valor6, resultado;
                valor1 = Convert.ToDecimal(cpoTaxaNf.Text);
                valor2 = Convert.ToDecimal(cpoValorComissao.Text);
                valor3 = Convert.ToDecimal(cpoValorFrete.Text);
                valor4 = Convert.ToDecimal(cpoSeguro.Text);
                valor5 = Convert.ToDecimal(cpoCustoCarreg.Text);
                valor6 = Convert.ToDecimal(cpoAdiantFretMot.Text);
                resultado = valor1 + valor2 + valor3 + valor4 + valor5 + valor6;
                cpoValorTotalRomaneio.Text = resultado.ToString();

                //     cpoValorTotalRomaneio.Text - cpoAdiantFretMot.Text = resultado.ToString()

                cpoSeguro.Enabled = false;
                cpoTaxaNf.Enabled = false;
                cpoValorComissao.Enabled = false;
                cpoValorFrete.Enabled = false;
                cpoCustoCarreg.Enabled = false;
                cpoQtdGeral.Enabled = false;
                checkBoxAdiantFretMot.Enabled = false;
                comboBoxFormaPagamento.Enabled = false;
                comboBoxUnidMedida.Enabled = false;
                btnChamacli.Enabled = false;
                btnChamafor.Enabled = false;
                btnChamaTransp.Enabled = false;
                btnChamaFruta.Enabled = false;
                btnAlterar.Enabled = true;


                if (cpoIDRomaneio.Text =="")
                {
                    btnSalvar.Enabled = true;
                }

                else
                {
                    btnSalvar.Enabled = false;
                }
                
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
            cpoQtdGeral.Enabled = true;
            checkBoxAdiantFretMot.Enabled = true;
            comboBoxFormaPagamento.Enabled = true;
            comboBoxUnidMedida.Enabled = true;
            btnChamacli.Enabled = true;
            btnChamafor.Enabled = true;
            btnChamaTransp.Enabled = true;
            btnChamaFruta.Enabled = true;

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

            //if (dgwCarregamento.RowCount <= 0)
            //{
            //    btnRemover.Enabled = false;
            //}
   


            BindingList<CarregamentoBloco> listCarregamento = new BindingList<CarregamentoBloco>();

            if (dgwCarregamento.Rows.Count < 1)
            {

                MessageBox.Show("Não há Blocos inseridos no Grid.");

            }

            else
            {

                this.dgwCarregamento.Rows.Remove(this.dgwCarregamento.CurrentRow);
                this.dgwCarregamento.Refresh();
            }

            decimal subtracao = 0;


            foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                subtracao -= Convert.ToDecimal(dr.Cells[16].Value);
            cpoTotalCarregamento.Text = Convert.ToString(subtracao);
            cpoTotalCarregamento.Text = cpoTotalCarregamento.Text.Replace("-", "");// O MÉTODO REPLACE TIRA O SINAL QUE ESTA NA PRIMEIRA ASPAS"" E TROCA PELO VALOR QUE ESTA NA SEGUNDA ASPAS""(OU SEJA ..PEGA A PRIMEIRA E TROCA PELA SEGUNDA)



            decimal subtracaoQtd = 0;

            foreach (DataGridViewRow dr in dgwCarregamento.Rows)
                subtracaoQtd -= Convert.ToDecimal(dr.Cells[12].Value);
            cpoQtdCarregada.Text = Convert.ToString(subtracaoQtd);
            cpoQtdCarregada.Text = cpoQtdCarregada.Text.Replace("-", "");// O MÉTODO REPLACE TIRA O SINAL QUE ESTA NA PRIMEIRA ASPAS"" E TROCA PELO VALOR QUE ESTA NA SEGUNDA ASPAS""(OU SEJA ..PEGA A PRIMEIRA E TROCA PELA SEGUNDA)



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

        private void cpoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 != (e.KeyChar == 13)) //PERMITE A DIGITAÇÃO DE NÚMEROS INTEIROS E DE PRESSIONAR A TECLA ENTER
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }


            if (e.KeyChar == 13)

                this.AtualizarGrid();


        }

        private void dgwRomaneio_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Romaneio romaneio = (dgwRomaneio.SelectedRows[0].DataBoundItem as Romaneio);
                cpoIDRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[0].Value.ToString();
                cpoMostraCodRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[0].Value.ToString();
                cpoNomeCliente.Text = dgwRomaneio.SelectedRows[0].Cells[1].Value.ToString();
                cpoNomeFornecedor.Text = dgwRomaneio.SelectedRows[0].Cells[2].Value.ToString();
                cpoNomeTransportador.Text = dgwRomaneio.SelectedRows[0].Cells[3].Value.ToString();
                cpoNomeFruta.Text = dgwRomaneio.SelectedRows[0].Cells[4].Value.ToString();
                comboBoxFormaPagamento.Text = dgwRomaneio.SelectedRows[0].Cells[5].Value.ToString();
                comboBoxUnidMedida.Text = dgwRomaneio.SelectedRows[0].Cells[6].Value.ToString();
                cpoQtdGeral.Text = dgwRomaneio.SelectedRows[0].Cells[7].Value.ToString();
                cpoValorFrete.Text = dgwRomaneio.SelectedRows[0].Cells[8].Value.ToString();
                cpoCustoCarreg.Text = dgwRomaneio.SelectedRows[0].Cells[9].Value.ToString();
                cpoValorComissao.Text = dgwRomaneio.SelectedRows[0].Cells[10].Value.ToString();
                cpoAdiantFretMot.Text = dgwRomaneio.SelectedRows[0].Cells[11].Value.ToString();
                cpoSeguro.Text = dgwRomaneio.SelectedRows[0].Cells[12].Value.ToString();
                cpoTaxaNf.Text = dgwRomaneio.SelectedRows[0].Cells[13].Value.ToString();
                cpoValorTotalRomaneio.Text = dgwRomaneio.SelectedRows[0].Cells[14].Value.ToString();
                cpoIDCliente.Text = dgwRomaneio.SelectedRows[0].Cells[19].Value.ToString();
                cpoIDTransportador.Text = dgwRomaneio.SelectedRows[0].Cells[20].Value.ToString();
                cpoIDFornecedor.Text = dgwRomaneio.SelectedRows[0].Cells[21].Value.ToString();
                cpoIDFruta.Text = dgwRomaneio.SelectedRows[0].Cells[22].Value.ToString();

               
                dgwCarregamento.DataSource = null;
                dgwCarregamento.Update();
                dgwCarregamento.Refresh();


                //Este método pesquisa os carregamentos vinculados ao romaneio que vc selecionar com um clique duplo
                // AtualizarGrid3(); 

                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = true;


                cpoSeguro.Enabled = false;
                cpoTaxaNf.Enabled = false;
                cpoValorComissao.Enabled = false;
                cpoValorFrete.Enabled = false;
                cpoCustoCarreg.Enabled = false;
                cpoQtdGeral.Enabled = false;
                checkBoxAdiantFretMot.Enabled = false;
                comboBoxFormaPagamento.Enabled = false;
                comboBoxUnidMedida.Enabled = false;
                btnChamacli.Enabled = false;
                btnChamafor.Enabled = false;
                btnChamaTransp.Enabled = false;
                btnChamaFruta.Enabled = false;

                //---------------------------------------------------------------------------


                


                //---------------------------------------------------------------------------
            }
            catch (Exception)
            {

                MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
            }
        }




        private void tabPageCarregamento_Click(object sender, EventArgs e)
        {
            if (cpoIDRomaneio.Text != null)
            {
                tabPageCarregamento.Visible = true;
                tabPageCarregamento.Enabled = true;
            }
        }



        private void btnIgnorarEdicoes_Click(object sender, EventArgs e)
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
            cpoMostraCodRomaneio.Clear();
            


            cpoSeguro.Enabled = true;
            cpoTaxaNf.Enabled = true;
            cpoValorComissao.Enabled = true;
            cpoValorFrete.Enabled = true;
            cpoCustoCarreg.Enabled = true;
            cpoQtdGeral.Enabled = true;
            checkBoxAdiantFretMot.Enabled = true;
            comboBoxFormaPagamento.Enabled = true;
            comboBoxUnidMedida.Enabled = true;
            btnChamacli.Enabled = true;
            btnChamafor.Enabled = true;
            btnChamaTransp.Enabled = true;
            btnChamaFruta.Enabled = true;


            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;

            //-------------------------limpar registros no DATAGRID VIEW----------------------------------

            if (this.dgwRomaneio.DataSource != null)
            {
                this.dgwRomaneio.DataSource = null;
            }
            else
            {
                this.dgwRomaneio.Rows.Clear();

            }
//-------------------------limpar registros no DATAGRID VIEW----------------------------------

        }

        private void cpoDtInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void cpoDtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        //------------------------------------------------Somente a primeira letra maiuscula de cada palavra--------------------------------------
        public string ConvMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }

        private void cpoBloco_TextChanged(object sender, EventArgs e)
        {
            cpoBloco.Text = ConvMaiuscula(cpoBloco.Text).ToString();
            cpoBloco.SelectionStart = cpoBloco.Text.Length;
        }

        private void cpoDescricao_TextChanged(object sender, EventArgs e)
        {
            cpoDescricao.Text = ConvMaiuscula(cpoDescricao.Text).ToString();
            cpoDescricao.SelectionStart = cpoDescricao.Text.Length;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cpoFrutaP_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void cpoFrutaM_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void cpoFrutaG_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void cpoFrutaP_TextChanged(object sender, EventArgs e)
        {
            //if (cpoFrutaP.Text != "")
            //{
            //    cpoQtdP.Enabled = true;
            //    cpoPrecoP.Enabled = true;
            //}

            //else
            //{
            //    cpoQtdP.Enabled = false;
            //    cpoPrecoP.Enabled = false;
            //    cpoPrecoP.Text = "";
            //    cpoPrecoTotalP.Text = "";
            //    cpoQtdP.Text = "";

            //}


            cpoFrutaP.Text = ConvMaiuscula(cpoFrutaP.Text).ToString();
            cpoFrutaP.SelectionStart = cpoFrutaP.Text.Length;
        }

        private void cpoFrutaM_TextChanged(object sender, EventArgs e)
        {
            //if (cpoFrutaM.Text != "")
            //{
            //    cpoQtdM.Enabled = true;
            //    cpoPrecoM.Enabled = true;
            //}

            //else

            //{
            //    cpoQtdM.Enabled = false;
            //    cpoPrecoM.Enabled = false;
            //    cpoPrecoM.Text = "";
            //    cpoPrecoTotalM.Text = "";
            //    cpoQtdM.Text = "";
            //}


            cpoFrutaM.Text = ConvMaiuscula(cpoFrutaM.Text).ToString();
            cpoFrutaM.SelectionStart = cpoFrutaM.Text.Length;
        }

        private void cpoFrutaG_TextChanged(object sender, EventArgs e)
        {
            //if (cpoFrutaG.Text != "")
            //{
            //    cpoQtdG.Enabled = true;
            //    cpoPrecoG.Enabled = true;
            //}

            //else
            //{
            //    cpoQtdG.Enabled = false;
            //    cpoPrecoG.Enabled = false;
            //    cpoPrecoG.Text = "";
            //    cpoPrecoTotalG.Text = "";
            //    cpoQtdG.Text = "";
            //}


            cpoFrutaG.Text = ConvMaiuscula(cpoFrutaG.Text).ToString();
            cpoFrutaG.SelectionStart = cpoFrutaG.Text.Length;
        }

        private void cpoQtdP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }
        }

        private void cpoQtdM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }
        }

        private void cpoQtdG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números inteiros");
                return;
            }
        }

        private void cpoQtdP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cpoQtdM_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cpoQtdG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cpoPrecoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoPrecoP.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void cpoPrecoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoPrecoM.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }


        }

        private void cpoPrecoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (cpoPrecoG.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cpoSomaQtd_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (cpoIDRomaneio.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {

                this.objRomaneio.IDRomaneio = Convert.ToInt32(cpoIDRomaneio.Text);
                this.objRomaneio.IDCliente = Convert.ToInt32(cpoIDCliente.Text);
                this.objRomaneio.Cliente = cpoNomeCliente.Text.TrimStart();
                this.objRomaneio.IDFornecedor = Convert.ToInt32(cpoIDFornecedor.Text);
                this.objRomaneio.Fornecedor = cpoNomeFornecedor.Text.TrimStart();
                this.objRomaneio.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
                this.objRomaneio.Transportador = cpoNomeTransportador.Text.TrimStart();
                this.objRomaneio.IDFruta = Convert.ToInt32(cpoIDFruta.Text);
                this.objRomaneio.Fruta = cpoNomeFruta.Text.TrimStart();
                this.objRomaneio.QtdFrutas = Convert.ToInt32(cpoQtdGeral.Text);
               // this.objRomaneio.IDCarregamento = Convert.ToInt32(cpoIDCarregamento.Text);
                this.objRomaneio.ValorFrete = Convert.ToDecimal(cpoValorFrete.Text);
                this.objRomaneio.AdiantFretMot = Convert.ToDecimal(cpoAdiantFretMot.Text);
                this.objRomaneio.Seguro = Convert.ToDecimal(cpoSeguro.Text);
                this.objRomaneio.FormaPagamento = comboBoxFormaPagamento.Text.TrimStart();
                this.objRomaneio.CustoCarregamento = Convert.ToDecimal(cpoCustoCarreg.Text);
                this.objRomaneio.ValorComissao = Convert.ToDecimal(cpoValorComissao.Text);
                this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);
                this.objRomaneio.TaxaNf = Convert.ToDecimal(cpoTaxaNf.Text);
                this.objRomaneio.UnidMedida = comboBoxUnidMedida.Text.TrimStart();



                string strRetorno = string.Empty;

                if (cpoNomeCliente.Text == "")
                {
                    MessageBox.Show("Defina o Cliente.");
                    return;
                }

                if (cpoNomeFornecedor.Text == "")
                {
                    MessageBox.Show("Defina o Fornecedor.");
                    return;
                }

                if (cpoNomeTransportador.Text == "")
                {
                    MessageBox.Show("Defina o Transportador.");
                    return;
                }

                if (cpoNomeFruta.Text == "")
                {
                    MessageBox.Show("Defina a Fruta.");
                    return;
                }

                if (cpoQtdGeral.Text == "")
                {
                    MessageBox.Show("Defina a Quantidade.");
                    return;
                }

                NegRomaneio negRomaneio = new NegRomaneio();
                strRetorno = negRomaneio.Alterar(this.objRomaneio);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    checkBoxAdiantFretMot.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Alterar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            if (dgwCarregamento.RowCount == 0)

            {
                MessageBox.Show("Nenhum Bloco foi adicionado ao Carregamento.");
                return;
            }

            if (cpoQtdCarregada.Text != cpoQtdGeral.Text)

            {
                MessageBox.Show("Quantidade Adicionada Não é Equivalente à Quantidade Total Descrita no Romaneio.");
                return;
            }



            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Finalizar?  Uma vez finalizado não é possível alterar o Carregamento ", "Salvar Carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {

                string strRetorno = string.Empty;

                foreach (DataGridViewRow row in dgwCarregamento.Rows)
                {

                    this.objCarreg.IDRomaneio = Convert.ToInt32(row.Cells[0].Value);
                    this.objCarreg.Bloco = Convert.ToString(row.Cells[1].Value);
                    this.objCarreg.Descricao = Convert.ToString(row.Cells[2].Value);
                    this.objCarreg.FrutaP = Convert.ToString(row.Cells[3].Value);
                    this.objCarreg.FrutaM = Convert.ToString(row.Cells[4].Value);
                    this.objCarreg.FrutaG = Convert.ToString(row.Cells[5].Value);
                    this.objCarreg.ValorUnitP = Convert.ToDecimal(row.Cells[6].Value);
                    this.objCarreg.ValorUnitM = Convert.ToDecimal(row.Cells[7].Value);
                    this.objCarreg.ValorUnitG = Convert.ToDecimal(row.Cells[8].Value);
                    this.objCarreg.QtdP = Convert.ToInt32(row.Cells[9].Value);
                    this.objCarreg.QtdM = Convert.ToInt32(row.Cells[10].Value);
                    this.objCarreg.QtdG = Convert.ToInt32(row.Cells[11].Value);
                    this.objCarreg.Quantidade = Convert.ToInt32(row.Cells[12].Value);
                    this.objCarreg.PrecoP = Convert.ToDecimal(row.Cells[13].Value);
                    this.objCarreg.PrecoM = Convert.ToDecimal(row.Cells[14].Value);
                    this.objCarreg.PrecoG = Convert.ToDecimal(row.Cells[15].Value);
                    this.objCarreg.TotalBloco = Convert.ToDecimal(row.Cells[16].Value);




                    NegCarregamentoBloco negCarreg = new NegCarregamentoBloco();
                    strRetorno = negCarreg.Cadastrar(this.objCarreg);

                }


                try
                {

                    int idCarregamentoBloco = Convert.ToInt32(strRetorno);


                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idCarregamentoBloco.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (this.dgwRomaneio.DataSource != null)
                    {
                        this.dgwRomaneio.DataSource = null;
                    }
                    else
                    {
                        this.dgwRomaneio.Rows.Clear();

                    }


                    if (this.dgwCarregamento.DataSource != null)
                    {
                        this.dgwCarregamento.DataSource = null;
                    }
                    else
                    {
                        this.dgwCarregamento.Rows.Clear();

                    }

   // limpar campos após Salvar

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
                    cpoQtdCarregada.Clear();
                    cpoTotalCarregamento.Clear();


                    cpoSeguro.Enabled = true;
                    cpoTaxaNf.Enabled = true;
                    cpoValorComissao.Enabled = true;
                    cpoValorFrete.Enabled = true;
                    cpoCustoCarreg.Enabled = true;
                    cpoQtdGeral.Enabled = true;
                    checkBoxAdiantFretMot.Enabled = true;
                    comboBoxFormaPagamento.Enabled = true;
                    comboBoxUnidMedida.Enabled = true;
                    btnChamacli.Enabled = true;
                    btnChamafor.Enabled = true;
                    btnChamaTransp.Enabled = true;
                    btnChamaFruta.Enabled = true;


                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = true;




                }



                catch (Exception ex)
                {

                    MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }

            }






             }

        private void cpoPrecoP_TextChanged(object sender, EventArgs e)
        {
            if (cpoPrecoP.Text == "")
            {
                cpoPrecoTotalP.Text = "";

            }
        }

        private void cpoPrecoM_TextChanged(object sender, EventArgs e)
        {
            if (cpoPrecoM.Text == "")
            {
                cpoPrecoTotalM.Text = "";

            }
        }

        private void cpoPrecoG_TextChanged(object sender, EventArgs e)
        {
            if (cpoPrecoG.Text == "")
            {
                cpoPrecoTotalG.Text = "";

            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //if (cpoQtdP.Text + cpoQtdM.Text + cpoQtdG.Text == "")
            //{
            //    MessageBox.Show(" É necessário conter ao menos uma quantidade de Frutas adicionada para o Bloco.");
            //    return;
            //}
            if (cpoQtdP.Text == "")
            {
                cpoPrecoTotalP.Text = "0";
            }

            if (!string.IsNullOrEmpty(cpoQtdP.Text))

                cpoPrecoTotalP.Text = (Convert.ToDecimal(cpoQtdP.Text) * Convert.ToDecimal(cpoPrecoP.Text)).ToString();

//----------------------------------------------------------------------


            if (cpoQtdM.Text == "")
            {
                cpoPrecoTotalM.Text = "0";
            }

            if (!string.IsNullOrEmpty(cpoQtdM.Text))

                cpoPrecoTotalM.Text = (Convert.ToDecimal(cpoQtdM.Text) * Convert.ToDecimal(cpoPrecoM.Text)).ToString();

//--------------------------------------------------
            if (cpoQtdG.Text == "")
            {
                cpoPrecoTotalG.Text = "0";
            }

            if (!string.IsNullOrEmpty(cpoQtdG.Text))

                cpoPrecoTotalG.Text = (Convert.ToDecimal(cpoQtdG.Text) * Convert.ToDecimal(cpoPrecoG.Text)).ToString();

            //----------------------------------------------

            if (cpoPrecoTotalP.Text != "0")
            {
                btnInserir.Enabled = true;
            }


            if (cpoPrecoTotalM.Text != "0")
            {
                btnInserir.Enabled = true;
            }


            if (cpoPrecoTotalG.Text != "0")
            {
                btnInserir.Enabled = true;
            }


            cpoPrecoP.Enabled = false;
            cpoQtdP.Enabled = false;
            cpoFrutaP.Enabled = false;

            cpoPrecoM.Enabled = false;
            cpoQtdM.Enabled = false;
            cpoFrutaM.Enabled = false;

            cpoPrecoG.Enabled = false;
            cpoQtdG.Enabled = false;
            cpoFrutaG.Enabled = false;


            cpoBloco.Enabled = false;
            cpoDescricao.Enabled = false;



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cpoBloco.Clear();
            cpoDescricao.Clear();
            cpoFrutaP.Clear();
            cpoFrutaM.Clear();
            cpoFrutaG.Clear();
            cpoQtdP.Clear();
            cpoQtdM.Clear();
            cpoQtdG.Clear();
            cpoPrecoTotalP.Clear();
            cpoPrecoTotalM.Clear();
            cpoPrecoTotalG.Clear();
            cpoPrecoP.Clear();
            cpoPrecoM.Clear();
            cpoPrecoG.Clear();
            cpoSomaQtd.Clear();
            cpoSomaPreco.Clear();


            cpoBloco.Enabled = true;
            cpoDescricao.Enabled = true;
            cpoFrutaP.Enabled = true;
            cpoFrutaM.Enabled = true;
            cpoFrutaG.Enabled = true;
            cpoPrecoP.Enabled = true;
            cpoPrecoM.Enabled = true;
            cpoPrecoG.Enabled = true;
            cpoQtdP.Enabled = true;
            cpoQtdM.Enabled = true;
            cpoQtdG.Enabled = true;

        }
    }

    }








