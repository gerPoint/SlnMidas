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
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idFuncionario.ToString()); -- tbm funciona esse
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idFuncionario.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //limpa os campos depois de salvar 




                    dgwFuncionario.DataSource = null;
                    dgwFuncionario.Update();
                    dgwFuncionario.Refresh();

                    //cpoCaixaPesquisa.Text = "%%";
                    // AtualizarGrid();

                    cpoNome.Clear();
                    cpoEndereco.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoCidade.Clear();
                    cpoCpf.Clear();
                    cpoEmail.Clear();
                    cpoIDFuncionario.Clear();
                    cpoTelefone.Clear();
                    cpoRg.Clear();


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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cpoNome.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objFuncionario.IDFuncionario = Convert.ToInt32(cpoIDFuncionario.Text);
                this.objFuncionario.Nome = cpoNome.Text.TrimStart();
                this.objFuncionario.Endereco = cpoEndereco.Text.TrimStart();
                this.objFuncionario.Cidade = cpoCidade.Text.TrimStart();
                this.objFuncionario.Uf = cpoUf.Text.TrimStart();
                this.objFuncionario.Telefone = cpoTelefone.Text.TrimStart();
                this.objFuncionario.Email = cpoEmail.Text.TrimStart();
                this.objFuncionario.Cpf = cpoCpf.Text.TrimStart();
                this.objFuncionario.Rg = cpoCpf.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoTelefone.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoTelefone.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }


                strRetorno = negFuncionario.Alterar(this.objFuncionario);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwFuncionario.DataSource = null;
                    dgwFuncionario.Update();
                    dgwFuncionario.Refresh();


                    cpoNome.Clear();
                    cpoRg.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoCidade.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoUf.Clear();
                    cpoIDFuncionario.Clear();


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

        private void dgwFuncionario_DoubleClick(object sender, EventArgs e)
        {
            cpoIDFuncionario.Text = dgwFuncionario.SelectedRows[0].Cells[0].Value.ToString();
            cpoNome.Text = dgwFuncionario.SelectedRows[0].Cells[1].Value.ToString();
            cpoEndereco.Text = dgwFuncionario.SelectedRows[0].Cells[2].Value.ToString();
            cpoCidade.Text = dgwFuncionario.SelectedRows[0].Cells[3].Value.ToString();
            cpoUf.Text = dgwFuncionario.SelectedRows[0].Cells[4].Value.ToString();
            cpoEmail.Text = dgwFuncionario.SelectedRows[0].Cells[6].Value.ToString();
            cpoTelefone.Text = dgwFuncionario.SelectedRows[0].Cells[5].Value.ToString();
            cpoRg.Text = dgwFuncionario.SelectedRows[0].Cells[8].Value.ToString();
            cpoCpf.Text = dgwFuncionario.SelectedRows[0].Cells[7].Value.ToString();
            //cpoStatus.Text = dgwCliente.SelectedRows[0].Cells[9].Value.ToString();
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cpoNome.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objFuncionario.IDFuncionario = Convert.ToInt32(cpoIDFuncionario.Text);
                this.objFuncionario.Nome = cpoNome.Text.TrimStart();
                this.objFuncionario.Endereco = cpoEndereco.Text.TrimStart();
                this.objFuncionario.Cidade = cpoCidade.Text.TrimStart();
                this.objFuncionario.Uf = cpoUf.Text.TrimStart();
                this.objFuncionario.Telefone = cpoTelefone.Text.TrimStart();
                this.objFuncionario.Email = cpoEmail.Text.TrimStart();
                this.objFuncionario.Cpf = cpoCpf.Text.TrimStart();
                this.objFuncionario.Rg = cpoCpf.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }

              

                strRetorno = negFuncionario.Excluir(this.objFuncionario);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwFuncionario.DataSource = null;
                    dgwFuncionario.Update();
                    dgwFuncionario.Refresh();


                    cpoIDFuncionario.Clear();
                    cpoNome.Clear();
                    cpoRg.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoCidade.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoUf.Clear();
                    cpoIDFuncionario.Clear();


                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;

                    // CaixaPesquisa.Text = "";
                    // AtualizarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            dgwFuncionario.Update();
            dgwFuncionario.Refresh();


            cpoIDFuncionario.Clear();
            cpoNome.Clear();
            cpoRg.Clear();
            cpoEndereco.Clear();
            cpoEmail.Clear();
            cpoCpf.Clear();
            cpoCidade.Clear();
            cpoCaixaPesquisa.Clear();
            cpoTelefone.Clear();
            cpoUf.Clear();
            cpoIDFuncionario.Clear();


            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void cpoCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        //---------------------Somente a primeira letra maiuscula de cada palavra---------------------------------

        public string ConvMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }

        private void cpoCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
            cpoCaixaPesquisa.Text = ConvMaiuscula(cpoCaixaPesquisa.Text).ToString();
            cpoCaixaPesquisa.SelectionStart = cpoCaixaPesquisa.Text.Length;

        }

        private void cpoNome_TextChanged(object sender, EventArgs e)
        {
            cpoNome.Text = ConvMaiuscula(cpoNome.Text).ToString();
            cpoNome.SelectionStart = cpoNome.Text.Length;
        }

        private void cpoEndereco_TextChanged(object sender, EventArgs e)
        {
            cpoEndereco.Text = ConvMaiuscula(cpoEndereco.Text).ToString();
            cpoEndereco.SelectionStart = cpoEndereco.Text.Length;
        }

        private void cpoCidade_TextChanged(object sender, EventArgs e)
        {
            cpoCidade.Text = ConvMaiuscula(cpoCidade.Text).ToString();
            cpoCidade.SelectionStart = cpoCidade.Text.Length;
        }

        private void cpoUf_TextChanged(object sender, EventArgs e)
        {
            cpoUf.Text = ConvMaiuscula(cpoUf.Text).ToString();
            cpoUf.SelectionStart = cpoUf.Text.Length;
        }



        //---------------------Somente a primeira letra maiuscula de cada palavra-------------------------------
    }


}
