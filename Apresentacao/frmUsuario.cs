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
    public partial class frmUsuario : Form
    {

        NegUsuario negUsuario = new NegUsuario();

        private Usuario objUsuario = new Usuario();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Usuario objUsuario = new Usuario();

            this.objUsuario.Nome = cpoNome.Text.TrimStart();
            this.objUsuario.Senha = cpoSenha.Text;
            this.objUsuario.Telefone = cpoTelefone.Text.TrimStart();
            this.objUsuario.Email = cpoEmail.Text.TrimStart();
            this.objUsuario.Endereco = cpoEndereco.Text.TrimStart();
            this.objUsuario.Cpf = cpoCpf.Text.TrimStart();
            this.objUsuario.Rg = cpoUf.Text.TrimStart();
            this.objUsuario.Cidade = cpoCidade.Text.TrimStart();
            this.objUsuario.Uf = cpoUf.Text.TrimStart();

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

            // strRetorno = this.negCliente.Cadastrar(this.objCliente);

            NegUsuario negUsuario = new NegUsuario();
            strRetorno = negUsuario.Cadastrar(this.objUsuario);

            try
            {


                int idUsuario = Convert.ToInt32(strRetorno);
                //  if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: "  + idCliente.ToString() );- da certo tb 
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idUsuario.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //limpa os campos depois de salvar 




                    dgwUsuario.DataSource = null;
                    dgwUsuario.Update();
                    dgwUsuario.Refresh();

                    cpoNome.Clear();
                    cpoSenha.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoRg.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoCidade.Clear();
                    cpoUf.Clear();


                    //teste

                    //strRetorno = negCliente.Consultar(); 

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cpoNome.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objUsuario.IDUsuario = Convert.ToInt32(cpoIDUsuario.Text);
                this.objUsuario.Nome = cpoNome.Text.TrimStart();
                this.objUsuario.Senha = cpoSenha.Text;
                this.objUsuario.Telefone = cpoTelefone.Text.TrimStart();
                this.objUsuario.Email = cpoEmail.Text.TrimStart();
                this.objUsuario.Endereco = cpoEndereco.Text.TrimStart();
                this.objUsuario.Cpf = cpoCpf.Text.TrimStart();
                this.objUsuario.Rg = cpoUf.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoSenha.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoTelefone.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }


                strRetorno = negUsuario.Alterar(this.objUsuario);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwUsuario.DataSource = null;
                    dgwUsuario.Update();
                    dgwUsuario.Refresh();

                    cpoIDUsuario.Clear();
                    cpoNome.Clear();
                    cpoSenha.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoRg.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoCidade.Clear();
                    cpoUf.Clear();


                    btnSalvar.Enabled = true;

                    // CaixaPesquisa.Text = "";
                    // AtualizarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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


                this.objUsuario.IDUsuario = Convert.ToInt32(cpoIDUsuario.Text);
                this.objUsuario.Nome = cpoNome.Text.TrimStart();
                this.objUsuario.Senha = cpoSenha.Text;
                this.objUsuario.Telefone = cpoTelefone.Text.TrimStart();
                this.objUsuario.Email = cpoEmail.Text.TrimStart();
                this.objUsuario.Endereco = cpoEndereco.Text.TrimStart();
                this.objUsuario.Cpf = cpoCpf.Text.TrimStart();
                this.objUsuario.Rg = cpoUf.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }

                if (cpoSenha.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }



                strRetorno = negUsuario.Alterar(this.objUsuario);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwUsuario.DataSource = null;
                    dgwUsuario.Update();
                    dgwUsuario.Refresh();

                    cpoIDUsuario.Clear();
                    cpoNome.Clear();
                    cpoSenha.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoRg.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoCidade.Clear();
                    cpoUf.Clear();


                    btnSalvar.Enabled = true;

                    // CaixaPesquisa.Text = "";
                    // AtualizarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void dgwUsuario_DoubleClick(object sender, EventArgs e)
        {
            cpoIDUsuario.Text = dgwUsuario.SelectedRows[0].Cells[0].Value.ToString();
            cpoNome.Text = dgwUsuario.SelectedRows[0].Cells[1].Value.ToString();
            cpoSenha.Text = dgwUsuario.SelectedRows[0].Cells[9].Value.ToString();
            cpoTelefone.Text = dgwUsuario.SelectedRows[0].Cells[7].Value.ToString();
            cpoEmail.Text = dgwUsuario.SelectedRows[0].Cells[8].Value.ToString();
            cpoCidade.Text = dgwUsuario.SelectedRows[0].Cells[5].Value.ToString();
            cpoUf.Text = dgwUsuario.SelectedRows[0].Cells[6].Value.ToString();
            cpoEndereco.Text = dgwUsuario.SelectedRows[0].Cells[4].Value.ToString();
            cpoCpf.Text = dgwUsuario.SelectedRows[0].Cells[2].Value.ToString();
            cpoRg.Text = dgwUsuario.SelectedRows[0].Cells[3].Value.ToString();
          
            btnSalvar.Enabled = false;
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
                    MessageBox.Show("Por favor, informe o nome do Usuário para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegUsuario objNegUsuario = new NegUsuario();
                UsuarioLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegUsuario.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegUsuario.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwUsuario.DataSource = null;
                dgwUsuario.DataSource = objLista;
                dgwUsuario.Update();
                dgwUsuario.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Usuário. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }



        }
    }

}


    

