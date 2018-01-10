using System;
using System.Data;
using System.Windows.Forms;
using AcessoDados;
using ObjTransferencia;
using System.Collections.Generic;
using System.ComponentModel;

namespace Apresentacao
{
    
    public partial class frmRomaneio : Form
    {
        BindingList<objCarregamentoBloco> listCarregamento = new BindingList<objCarregamentoBloco>();
        private int idcliente;

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


            
        }

        private void btnChamafor_Click(object sender, EventArgs e)
        {
            frmSelecionarFornecedor OutroForm = new frmSelecionarFornecedor();
            OutroForm.ShowDialog();
        }

        private void btnChamaTransp_Click(object sender, EventArgs e)
        {
            frmSelecionarTransportador OutroForm = new frmSelecionarTransportador();
            OutroForm.ShowDialog();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void cpoQtd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }


 }
            
            


