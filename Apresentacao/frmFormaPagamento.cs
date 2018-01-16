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
    public partial class frmFormaPagamento : Form
    {
        NegFormaPagamento negFormaPagamento = new NegFormaPagamento();

        private FormaPagamento objFormaPagamento = new FormaPagamento();


        public frmFormaPagamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetFormaPgto.tblFormaPagamento' table. You can move, or remove it, as needed.


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FormaPagamento objFormaPagamento = new FormaPagamento();

            this.objFormaPagamento.Descricao = cpoDescricao.Text.TrimStart();
            this.objFormaPagamento.Parcelamento = cpoParcelamento.Text.TrimStart();



            string strRetorno = string.Empty;

            if (cpoDescricao.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoParcelamento.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegFormaPagamento negFormaPagamento = new NegFormaPagamento();
            strRetorno = negFormaPagamento.Cadastrar(this.objFormaPagamento);

            try
            {


                int idFormaPagamento = Convert.ToInt32(strRetorno);

                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idFruta.ToString()); - tbm funciona esse 
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idFormaPagamento.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //limpa os campos depois de salvar 
                    cpoDescricao.Clear();
                    cpoParcelamento.Clear();


                    dgwFormaPagamento.DataSource = null;
                    dgwFormaPagamento.Update();
                    dgwFormaPagamento.Refresh();

                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (cpoDescricao.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {

                this.objFormaPagamento.IDFormaPagamento = Convert.ToInt32(cpoIDFormaPagamento.Text);
                this.objFormaPagamento.Descricao = cpoDescricao.Text.TrimStart();
                this.objFormaPagamento.Parcelamento = cpoParcelamento.Text.TrimStart();



                string strRetorno = string.Empty;

                if (cpoDescricao.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoParcelamento.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                NegFormaPagamento negFormaPagamento = new NegFormaPagamento();
                strRetorno = negFormaPagamento.Alterar(this.objFormaPagamento);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFormaPagamento.DataSource = null;
                    dgwFormaPagamento.Update();
                    dgwFormaPagamento.Refresh();
                    cpoIDFormaPagamento.Clear();
                    cpoDescricao.Clear();
                    cpoParcelamento.Clear();




                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cpoDescricao.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {

                this.objFormaPagamento.IDFormaPagamento = Convert.ToInt32(cpoIDFormaPagamento.Text);
                this.objFormaPagamento.Descricao = cpoDescricao.Text.TrimStart();
                this.objFormaPagamento.Parcelamento = cpoParcelamento.Text.TrimStart();



                string strRetorno = string.Empty;

                if (cpoDescricao.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }


                NegFormaPagamento negFormaPagamento = new NegFormaPagamento();
                strRetorno = negFormaPagamento.Excluir(this.objFormaPagamento);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFormaPagamento.DataSource = null;
                    dgwFormaPagamento.Update();
                    dgwFormaPagamento.Refresh();
                    cpoIDFormaPagamento.Clear();
                    cpoDescricao.Clear();
                    cpoParcelamento.Clear();





                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        //------------------------------------------------Somente a primeira letra maiuscula de cada palavra--------------------------------------
        public string ConvMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }

        private void cpoDescricao_TextChanged(object sender, EventArgs e)
        {
            cpoDescricao.Text = ConvMaiuscula(cpoDescricao.Text).ToString();
            cpoDescricao.SelectionStart = cpoDescricao.Text.Length;
        }

        private void cpoParcelamento_TextChanged(object sender, EventArgs e)
        {
            cpoParcelamento.Text = ConvMaiuscula(cpoParcelamento.Text).ToString();
            cpoParcelamento.SelectionStart = cpoParcelamento.Text.Length;
        }

        private void cpoCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
            cpoCaixaPesquisa.Text = ConvMaiuscula(cpoCaixaPesquisa.Text).ToString();
            cpoCaixaPesquisa.SelectionStart = cpoCaixaPesquisa.Text.Length;
        }

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
                    MessageBox.Show("Por favor, informe o nome da Forma de Pagamento para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                NegFormaPagamento objNegFormaPagamento = new NegFormaPagamento();
                FormaPagamentoLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegFormaPagamento.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegFormaPagamento.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwFormaPagamento.DataSource = null;
                dgwFormaPagamento.DataSource = objLista;
                dgwFormaPagamento.Update();
                dgwFormaPagamento.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Forma de Pagamento. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void dgwFormaPagamento_DoubleClick(object sender, EventArgs e)
        {
            cpoIDFormaPagamento.Text = dgwFormaPagamento.SelectedRows[0].Cells[0].Value.ToString();
            cpoDescricao.Text = dgwFormaPagamento.SelectedRows[0].Cells[1].Value.ToString();
            cpoParcelamento.Text = dgwFormaPagamento.SelectedRows[0].Cells[2].Value.ToString();

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            dgwFormaPagamento.Update();
            dgwFormaPagamento.Refresh();


            cpoIDFormaPagamento.Clear();
            cpoDescricao.Clear();
            cpoParcelamento.Clear();
 
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
