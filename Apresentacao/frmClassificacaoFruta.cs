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
    public partial class frmClassificacaoFruta : Form
    {

        private ClassificFruta objClassificFruta = new ClassificFruta();
        public frmClassificacaoFruta()
        {
            InitializeComponent();
        }

        private void frmClassificacaoFruta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetClassificFruta.tblClassificacaoFruta' table. You can move, or remove it, as needed.
           // this.tblClassificacaoFrutaTableAdapter.Fill(this.midasDataSetClassificFruta.tblClassificacaoFruta);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.objClassificFruta.Classificacao = cpoClassificacao.Text.TrimStart();
            //this.objClassificFruta.IDClassificacao = cpoIDClassificacao.Text.TrimStart();



            string strRetorno = string.Empty;

            if (cpoClassificacao.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegClassificFruta negClassificFruta = new NegClassificFruta();
            strRetorno = negClassificFruta.Cadastrar(this.objClassificFruta);

            try
            {


                int idclassFruta = Convert.ToInt32(strRetorno);

                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idFruta.ToString()); - tbm funciona esse 
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idclassFruta.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //limpa os campos depois de salvar 
                    cpoClassificacao.Clear();

                    dgwClassificFruta.Update();
                    dgwClassificFruta.Refresh();


                    if (this.dgwClassificFruta.DataSource != null)
                    {
                        this.dgwClassificFruta.DataSource = null;
                    }
                    else
                    {
                        this.dgwClassificFruta.Rows.Clear();

                    }

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

        private void cpoClassificacao_TextChanged(object sender, EventArgs e)
        {

            cpoClassificacao.Text = ConvMaiuscula(cpoClassificacao.Text).ToString();
            cpoClassificacao.SelectionStart = cpoClassificacao.Text.Length;

        }


        public string ConvMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cpoClassificacao.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {

                this.objClassificFruta.IDClassificacao = Convert.ToInt32(cpoIDClassificacao.Text);
                this.objClassificFruta.Classificacao = cpoClassificacao.Text.TrimStart();


                string strRetorno = string.Empty;

                if (cpoClassificacao.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }


                NegClassificFruta negClassificFruta = new NegClassificFruta();
                strRetorno = negClassificFruta.Excluir(this.objClassificFruta);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwClassificFruta.DataSource = null;
                    dgwClassificFruta.Update();
                    dgwClassificFruta.Refresh();
                    cpoIDClassificacao.Clear();
                    cpoClassificacao.Clear();


                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Excluir registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            dgwClassificFruta.Update();
            dgwClassificFruta.Refresh();
            cpoIDClassificacao.Clear();
            cpoClassificacao.Clear();

            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }


    private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cpoClassificacao.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {

                this.objClassificFruta.IDClassificacao = Convert.ToInt32(cpoIDClassificacao.Text);
                this.objClassificFruta.Classificacao = cpoClassificacao.Text.TrimStart();


                string strRetorno = string.Empty;

                if (cpoClassificacao.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }


                NegClassificFruta negClassificFruta = new NegClassificFruta();
                strRetorno = negClassificFruta.Alterar(this.objClassificFruta);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwClassificFruta.DataSource = null;
                    dgwClassificFruta.Update();
                    dgwClassificFruta.Refresh();
                    cpoIDClassificacao.Clear();
                    cpoClassificacao.Clear();
                  

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
                    MessageBox.Show("Por favor, informe a Classificacao da Fruta para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegClassificFruta objNegClassificFruta = new NegClassificFruta();
                ClassificFrutaLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegClassificFruta.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegClassificFruta.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwClassificFruta.DataSource = null;
                dgwClassificFruta.DataSource = objLista;
                dgwClassificFruta.Update();
                dgwClassificFruta.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Classificacao de Fruta. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

          }

        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            dgwClassificFruta.Update();
            dgwClassificFruta.Refresh();
            cpoIDClassificacao.Clear();
            cpoClassificacao.Clear();

            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void dgwClassificFruta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ClassificFruta classificFruta = (dgwClassificFruta.SelectedRows[0].DataBoundItem as ClassificFruta);
                cpoIDClassificacao.Text = dgwClassificFruta.SelectedRows[0].Cells[0].Value.ToString();
                cpoClassificacao.Text = dgwClassificFruta.SelectedRows[0].Cells[1].Value.ToString();

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
            }


         }
       }
    }