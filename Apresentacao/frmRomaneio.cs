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

        private void frmRomaneio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetDescFormPgto.tblFormaPagamento' table. You can move, or remove it, as needed.
            this.tblFormaPagamentoTableAdapter.Fill(this.midasDataSetDescFormPgto.tblFormaPagamento);
            // TODO: This line of code loads data into the 'midasDataSetUnidMedida.tblFruta' table. You can move, or remove it, as needed.
            this.tblFrutaTableAdapter.Fill(this.midasDataSetUnidMedida.tblFruta);
            // TODO: This line of code loads data into the 'midasDataSetCarregbloco.tblCarregamentoBloco' table. You can move, or remove it, as needed.
            //this.tblCarregamentoBlocoTableAdapter.Fill(this.midasDataSetCarregbloco.tblCarregamentoBloco);
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
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

                ObjTransferencia.objCarregamentoBloco novoCarregamentoBloco = new objCarregamentoBloco();
                novoCarregamentoBloco.Bloco = cpoBloco.Text;
                novoCarregamentoBloco.Quantidade = Convert.ToInt32(cpoQtd.Text);
                novoCarregamentoBloco.Descricao = cpoDescricao.Text;
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
            }
        }

        private void cpoQtdGeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoAdiantFretMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoTaxaNf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoCustoCarreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

  

        private void btnChamaFruta_Click(object sender, EventArgs e)
        {

            //alterarrrr

            frmSelecionarFruta OutroForm = new frmSelecionarFruta();
            OutroForm.ShowDialog();
            cpoNomeFruta.Text = OutroForm.NomeFruta;
            cpoIDFruta.Text = OutroForm.IDFruta;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Romaneio objRomaneio = new Romaneio();

            this.objRomaneio.IDCliente = Convert.ToInt32(cpoIDCliente.Text);
            this.objRomaneio.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
            this.objRomaneio.IDFornecedor = Convert.ToInt32(cpoIDFornecedor.Text);
            this.objRomaneio.IDFruta = Convert.ToInt32(cpoIDFruta.Text);
            this.objRomaneio.QtdFrutas = Convert.ToInt32(cpoQtdFrutas.Text);
            this.objRomaneio.IDCarregamento = Convert.ToInt32(cpoIDCarregamento.Text);
            this.objRomaneio.ValorFrete = Convert.ToDecimal(cpoValorFrete.Text);
            this.objRomaneio.AdiantFretMot = Convert.ToDecimal(cpoAdiantFretMot.Text);
            this.objRomaneio.FormaPagamento = comboBoxFormaPagamento.Text.TrimStart();
            this.objRomaneio.CustoCarregamento = Convert.ToDecimal(cpoCustoCarregamento.Text);
            this.objRomaneio.ValorComissao = Convert.ToDecimal(cpoValorComissao.Text);
            this.objRomaneio.ValorTotalRomaneio = Convert.ToDecimal(cpoValorTotalRomaneio.Text);
            this.objRomaneio.TaxaNf = Convert.ToDecimal(cpoTaxaNf.Text);
            this.objRomaneio.UnidMedida = comboBoxUnidMedida.Text.TrimStart();
            

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

            // strRetorno = this.negCliente.Cadastrar(this.objCliente);

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
                    cpoQtdFrutas.Clear();
                    cpoValorFrete.Clear();
                    cpoAdiantFretMot.Clear();
                    cpoSeguro.Clear();
                    cpoTaxaNf.Clear();
                    cpoCustoCarregamento.Clear();
                    cpoValorComissao.Clear();
                    cpoValorTotalRomaneio.Clear();



                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
            }


          }

 
    }

    }


 
            
            


