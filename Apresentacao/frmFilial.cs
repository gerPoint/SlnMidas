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
    public partial class frmFilial : Form
    {
        NegFilial negFilial = new NegFilial();

        private Filial objFilial = new Filial();

        public frmFilial()
        {
            InitializeComponent();
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
                    MessageBox.Show("Por favor, informe o nome do Cliente para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegFilial objNegFilial = new NegFilial();
                FilialLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegFilial.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegFilial.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwFilial.DataSource = null;
                dgwFilial.DataSource = objLista;
                dgwFilial.Update();
                dgwFilial.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Filial. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }












        private void frmFilial_Load(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Filial objFilial = new Filial();

            this.objFilial.Nome = cpoFilial.Text.TrimStart();
            this.objFilial.RazaoSocial = cpoRazaoSocial.Text.TrimStart();
            this.objFilial.Cnpj = cpoCnpj.Text.TrimStart();
            this.objFilial.Endereco = cpoEndereco.Text.TrimStart();
            this.objFilial.Cidade = cpoCidade.Text.TrimStart();
            this.objFilial.Uf = cpoUf.Text.TrimStart();
            this.objFilial.Telefone = cpoTelefone.Text.TrimStart();
            this.objFilial.Email = cpoEmail.Text.TrimStart();
            this.objFilial.ChaveSistema = cpoChaveSistema.Text.TrimStart();


            string strRetorno = string.Empty;

            if (cpoFilial.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoRazaoSocial.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegFilial negFilial = new NegFilial();
            strRetorno = negFilial.Cadastrar(this.objFilial);

            try
            {


                int idFilial = Convert.ToInt32(strRetorno);
                //  if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                   // MessageBox.Show("Registro salvo com sucesso! Código: " + idFilial.ToString()); - tambem funciona esse
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idFilial.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //limpa os campos depois de salvar 
                    cpoFilial.Clear();
                    cpoRazaoSocial.Clear();
                    cpoCnpj.Clear();
                    cpoCidade.Clear();
                    cpoEmail.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();

                   dgwFilial.DataSource = null;

                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cpoIDFilial.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objFilial.IDFilial = Convert.ToInt32(cpoIDFilial.Text);
                this.objFilial.Nome = cpoFilial.Text.TrimStart();
                this.objFilial.RazaoSocial = cpoRazaoSocial.Text;
                this.objFilial.Cnpj = cpoCnpj.Text.TrimStart();
                this.objFilial.Endereco = cpoEndereco.Text.TrimStart();
                this.objFilial.Cidade = cpoCidade.Text.TrimStart();
                this.objFilial.Uf = cpoUf.Text.TrimStart();
                this.objFilial.Telefone = cpoTelefone.Text.TrimStart();
                this.objFilial.Email = cpoEmail.Text.TrimStart();
                this.objFilial.ChaveSistema = cpoChaveSistema.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoFilial.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }



                strRetorno = negFilial.Excluir(this.objFilial);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro Excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFilial.DataSource = null;

                    dgwFilial.Refresh();

                    cpoFilial.Clear();
                    cpoRazaoSocial.Clear();
                    cpoCnpj.Clear();
                    cpoCidade.Clear();
                    cpoEmail.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();

                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;


                    // CaixaPesquisa.Text = "";
                    // AtualizarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

  
        private void dgwFilial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cpoIDFilial.Text = dgwFilial.SelectedRows[0].Cells[0].Value.ToString();
            cpoFilial.Text = dgwFilial.SelectedRows[0].Cells[1].Value.ToString();
            cpoRazaoSocial.Text = dgwFilial.SelectedRows[0].Cells[2].Value.ToString();
            cpoChaveSistema.Text = dgwFilial.SelectedRows[0].Cells[9].Value.ToString();
            cpoCidade.Text = dgwFilial.SelectedRows[0].Cells[5].Value.ToString();
            cpoUf.Text = dgwFilial.SelectedRows[0].Cells[6].Value.ToString();
            cpoEndereco.Text = dgwFilial.SelectedRows[0].Cells[4].Value.ToString();
            cpoTelefone.Text = dgwFilial.SelectedRows[0].Cells[7].Value.ToString();
            cpoEmail.Text = dgwFilial.SelectedRows[0].Cells[8].Value.ToString();
            cpoCnpj.Text = dgwFilial.SelectedRows[0].Cells[3].Value.ToString();

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cpoIDFilial.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            try
            {


                this.objFilial.IDFilial = Convert.ToInt32(cpoIDFilial.Text);
                this.objFilial.Nome = cpoFilial.Text.TrimStart();
                this.objFilial.RazaoSocial = cpoRazaoSocial.Text;
                this.objFilial.Cnpj = cpoCnpj.Text.TrimStart();
                this.objFilial.Endereco = cpoEndereco.Text.TrimStart();
                this.objFilial.Cidade = cpoCidade.Text.TrimStart();
                this.objFilial.Uf = cpoUf.Text.TrimStart();
                this.objFilial.Telefone = cpoTelefone.Text.TrimStart();
                this.objFilial.Email = cpoEmail.Text.TrimStart();
                this.objFilial.ChaveSistema = cpoChaveSistema.Text.TrimStart();

                string strRetorno = string.Empty;

                if (cpoFilial.Text == "")
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


                strRetorno = negFilial.Alterar(this.objFilial);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFilial.DataSource = null;
                    dgwFilial.Update();
                    dgwFilial.Refresh();


                    cpoIDFilial.Clear();
                    cpoFilial.Clear();
                    cpoRazaoSocial.Clear();
                    cpoCnpj.Clear();
                    cpoCidade.Clear();
                    cpoEmail.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();

                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            dgwFilial.Update();
            dgwFilial.Refresh();


            cpoIDFilial.Clear();
            cpoFilial.Clear();
            cpoRazaoSocial.Clear();
            cpoCnpj.Clear();
            cpoCidade.Clear();
            cpoEmail.Clear();
            cpoTelefone.Clear();
            cpoEndereco.Clear();
            cpoUf.Clear();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void cpoCnpj_KeyPress(object sender, KeyPressEventArgs e)
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

//------------------------------------------------Somente a primeira letra maiuscula de cada palavra--------------------------------------
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

        private void cpoFilial_TextChanged(object sender, EventArgs e)
        {
            cpoFilial.Text = ConvMaiuscula(cpoFilial.Text).ToString();
            cpoFilial.SelectionStart = cpoFilial.Text.Length;
        }

        private void cpoRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            cpoRazaoSocial.Text = ConvMaiuscula(cpoRazaoSocial.Text).ToString();
            cpoRazaoSocial.SelectionStart = cpoRazaoSocial.Text.Length;
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

        private void cpoCnpj_TextChanged(object sender, EventArgs e)
        {

        }

//------------------------------------------------Somente a primeira letra maiuscula de cada palavra--------------------------------------

    }

}
    
