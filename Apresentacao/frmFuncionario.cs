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
    public partial class frmFuncionario : Form
    {


        NegFuncionario negFuncionario = new NegFuncionario();

        private Funcionario objFuncionario = new Funcionario();



        public frmFuncionario()
        {
            InitializeComponent();
        }

        // private void dgwCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {

        //  }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();

            this.objFuncionario.Nome = cpoNome.Text.TrimStart();
            this.objFuncionario.Cidade = cpoCidade.Text.TrimStart();
            this.objFuncionario.Endereco = cpoEndereco.Text.TrimStart();
            this.objFuncionario.Uf = cpoUf.Text.TrimStart();
            this.objFuncionario.Telefone = cpoTelefone.Text.TrimStart();
            this.objFuncionario.Email = cpoEmail.Text.TrimStart();
            this.objFuncionario.Cpf = cpoCpf.Text.TrimStart();
            this.objFuncionario.Rg = cpoRg.Text.TrimStart();





            string strRetorno = string.Empty;

            if (cpoNome.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoEndereco.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegFuncionario negFuncionario = new NegFuncionario();
            strRetorno = negFuncionario.Cadastrar(this.objFuncionario);

            try
            {


                int idFuncionario = Convert.ToInt32(strRetorno);
          
                {
                    MessageBox.Show("Registro salvo com sucesso! Código: " + idFuncionario.ToString());

                   

                    //limpa os campos depois de salvar 
                    cpoNome.Clear();
                    cpoEndereco.Clear();


                    dgwFuncionario.DataSource = null;
                    dgwFuncionario.Update();
                    dgwFuncionario.Refresh();

                    //cpoCaixaPesquisa.Text = "%%";
                    // AtualizarGrid();


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
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
                    MessageBox.Show("Por favor, informe o nome do Funcionario para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegFuncionario objNegFuncionario = new NegFuncionario();
                FuncionarioLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegFuncionario.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegFuncionario.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwFuncionario.DataSource = null;
                dgwFuncionario.DataSource = objLista;
                dgwFuncionario.Update();
                dgwFuncionario.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Funcionario. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }

}
