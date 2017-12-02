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
    public partial class frmFornecedor : Form
    {
        NegFornecedor negFornecedor = new NegFornecedor();

        private Fornecedor objFornecedor = new Fornecedor();

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetFornecedor.tblFornecedor' table. You can move, or remove it, as needed.
            //this.tblFornecedorTableAdapter.Fill(this.midasDataSetFornecedor.tblFornecedor);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor objFornecedor = new Fornecedor();

            this.objFornecedor.Nome = cpoNome.Text.TrimStart();
            this.objFornecedor.Cnpj = cpoCnpj.Text.TrimStart();
            this.objFornecedor.Cpf = cpoCpf.Text.TrimStart();
            this.objFornecedor.Endereco = cpoEndereco.Text.TrimStart();
            this.objFornecedor.Cidade = cpoCidade.Text.TrimStart();
            this.objFornecedor.Uf = cpoUf.Text.TrimStart();
            this.objFornecedor.Telefone = cpoTelefone.Text.TrimStart();
            this.objFornecedor.Email = cpoEmail.Text.TrimStart();
            this.objFornecedor.RazaoSocial = cpoRazaoSocial.Text.TrimStart();



            string strRetorno = string.Empty;

            if (cpoNome.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoRazaoSocial.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegFornecedor negFornecedor = new NegFornecedor();
            strRetorno = negFornecedor.Cadastrar(this.objFornecedor);

            try
            {


                int idFornecedor = Convert.ToInt32(strRetorno);
                //  if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idFornecedor.ToString()); - tambem funciona esse
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idFornecedor.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // this.DialogResult = DialogResult.OK;

                    //limpa os campos depois de salvar 
                    cpoNome.Clear();
                    cpoRazaoSocial.Clear();
                    cpoCnpj.Clear();
                    cpoCpf.Clear();
                    cpoCidade.Clear();
                    cpoEmail.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();


                    dgwFornecedor.DataSource = null;


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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }



        private void AtualizarGrid()
        {
            try
            {
                if (cpoCaixaPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o nome do Fornecedor para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegFornecedor objNegFornecedor = new NegFornecedor();
                FornecedorLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegFornecedor.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegFornecedor.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwFornecedor.DataSource = null;
                dgwFornecedor.DataSource = objLista;
                dgwFornecedor.Update();
                dgwFornecedor.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Fornecedor. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void dgwFornecedor_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cpoNome.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objFornecedor.IDFornecedor = Convert.ToInt32(cpoIDFornecedor.Text);
                //cliente.IDCliente = Convert.ToInt32(linha["IDCliente"]);
                this.objFornecedor.Nome = cpoNome.Text.TrimStart();
                this.objFornecedor.RazaoSocial = cpoRazaoSocial.Text;
                this.objFornecedor.Cnpj = cpoCnpj.Text.TrimStart();
                this.objFornecedor.Cpf = cpoCpf.Text.TrimStart();
                this.objFornecedor.Endereco = cpoEndereco.Text.TrimStart();
                this.objFornecedor.Cidade = cpoCidade.Text.TrimStart();
                this.objFornecedor.Uf = cpoUf.Text.TrimStart();
                this.objFornecedor.Telefone = cpoTelefone.Text.TrimStart();
                this.objFornecedor.Email = cpoEmail.Text.TrimStart();


                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoRazaoSocial.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoTelefone.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }


                strRetorno = negFornecedor.Alterar(this.objFornecedor);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFornecedor.DataSource = null;
                    dgwFornecedor.Update();
                    dgwFornecedor.Refresh();



                    cpoNome.Clear();
                    cpoRazaoSocial.Clear();
                    cpoCnpj.Clear();
                    cpoCidade.Clear();
                    cpoEmail.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();

                    btnSalvar.Enabled = true;


                    // CaixaPesquisa.Text = "";
                    // AtualizarGrid();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgwFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cpoIDFornecedor.Text = dgwFornecedor.SelectedRows[0].Cells[0].Value.ToString();
            cpoNome.Text = dgwFornecedor.SelectedRows[0].Cells[1].Value.ToString();
            cpoRazaoSocial.Text = dgwFornecedor.SelectedRows[0].Cells[2].Value.ToString();
            cpoCidade.Text = dgwFornecedor.SelectedRows[0].Cells[3].Value.ToString();
            cpoUf.Text = dgwFornecedor.SelectedRows[0].Cells[4].Value.ToString();
            cpoEndereco.Text = dgwFornecedor.SelectedRows[0].Cells[2].Value.ToString();
            cpoTelefone.Text = dgwFornecedor.SelectedRows[0].Cells[5].Value.ToString();
            cpoEmail.Text = dgwFornecedor.SelectedRows[0].Cells[6].Value.ToString();
            cpoCnpj.Text = dgwFornecedor.SelectedRows[0].Cells[7].Value.ToString();
            cpoCpf.Text = dgwFornecedor.SelectedRows[0].Cells[8].Value.ToString();
        }
    }


}