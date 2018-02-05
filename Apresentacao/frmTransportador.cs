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
    public partial class frmTransportador : Form
    {
        NegTransportador negTransportador = new NegTransportador();
        private Transportador objTransportador = new Transportador();


        public frmTransportador()
        {
            InitializeComponent();
        }

        private void frmTransportador_Load(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Transportador objTransportador = new Transportador();

            this.objTransportador.Nome = cpoNome.Text.TrimStart();
            this.objTransportador.Veiculo = cpoVeiculo.Text.TrimStart();
            this.objTransportador.Endereco = cpoEndereco.Text.TrimStart();
            this.objTransportador.Telefone = cpoTelefone.Text.TrimStart();
            this.objTransportador.Cidade = cpoCidade.Text.TrimStart();
            this.objTransportador.Uf = cpoUf.Text.TrimStart();
            this.objTransportador.Placa = cpoPlaca.Text.TrimStart();


            string strRetorno = string.Empty;

            if (cpoNome.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoVeiculo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegTransportador negTransportador = new NegTransportador();
            strRetorno = negTransportador.Cadastrar(this.objTransportador);

            try
            {


                int idTransportador = Convert.ToInt32(strRetorno);
         
                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idTransportador.ToString()); esse tbm funciona
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idTransportador.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                    //limpa os campos depois de salvar 
                    cpoNome.Clear();
                    cpoEndereco.Clear();
                    cpoCidade.Clear();
                    cpoUf.Clear();
                    cpoTelefone.Clear();
                    cpoVeiculo.Clear();
                    cpoPlaca.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoIDTransportador.Clear();


                    dgwTransportador.DataSource = null;
                    dgwTransportador.Update();
                    dgwTransportador.Refresh();

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
                    MessageBox.Show("Por favor, informe o nome do Transportador para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();

                    return;
                }

                NegTransportador objNegTransportador = new NegTransportador();
                TransportadorLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegTransportador.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegTransportador.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwTransportador.DataSource = null;
                dgwTransportador.DataSource = objLista;
                dgwTransportador.Update();
                dgwTransportador.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Transportador. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void dgwTransportador_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Transportador transportador = (dgwTransportador.SelectedRows[0].DataBoundItem as Transportador);
                cpoIDTransportador.Text = dgwTransportador.SelectedRows[0].Cells[0].Value.ToString();
                cpoNome.Text = dgwTransportador.SelectedRows[0].Cells[1].Value.ToString();
                cpoVeiculo.Text = dgwTransportador.SelectedRows[0].Cells[2].Value.ToString();
                cpoPlaca.Text = dgwTransportador.SelectedRows[0].Cells[3].Value.ToString();
                cpoCidade.Text = dgwTransportador.SelectedRows[0].Cells[4].Value.ToString();
                cpoUf.Text = dgwTransportador.SelectedRows[0].Cells[5].Value.ToString();
                cpoEndereco.Text = dgwTransportador.SelectedRows[0].Cells[6].Value.ToString();
                cpoTelefone.Text = dgwTransportador.SelectedRows[0].Cells[7].Value.ToString();
                //cpoStatus.Text = dgwCliente.SelectedRows[0].Cells[9].Value.ToString();

                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informação: " + "Você clicou fora do intervalo de seleção. Por favor clique devidamente no registro desejado. " + MessageBoxButtons.OK);
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

                this.objTransportador.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
                this.objTransportador.Nome = cpoNome.Text.TrimStart();
                this.objTransportador.Veiculo = cpoVeiculo.Text.TrimStart();
                this.objTransportador.Placa = cpoPlaca.Text.TrimStart();
                this.objTransportador.Cidade = cpoCidade.Text.TrimStart();
                this.objTransportador.Uf = cpoUf.Text.TrimStart();
                this.objTransportador.Endereco = cpoEndereco.Text.TrimStart();
                this.objTransportador.Telefone = cpoTelefone.Text.TrimStart();


                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoVeiculo.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

             
                NegTransportador negTransportador = new NegTransportador();
                strRetorno = negTransportador.Alterar(this.objTransportador);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwTransportador.DataSource = null;


                    cpoIDTransportador.Clear();
                    cpoNome.Clear();
                    cpoVeiculo.Clear();
                    cpoPlaca.Clear();
                    cpoCidade.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();


                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        
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

                this.objTransportador.IDTransportador = Convert.ToInt32(cpoIDTransportador.Text);
                this.objTransportador.Nome = cpoNome.Text.TrimStart();
                this.objTransportador.Veiculo = cpoVeiculo.Text.TrimStart();
                this.objTransportador.Placa = cpoPlaca.Text.TrimStart();
                this.objTransportador.Cidade = cpoCidade.Text.TrimStart();
                this.objTransportador.Uf = cpoUf.Text.TrimStart();
                this.objTransportador.Endereco = cpoEndereco.Text.TrimStart();
                this.objTransportador.Telefone = cpoTelefone.Text.TrimStart();





                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                    return;
                }



                NegTransportador negTransportador = new NegTransportador();
                strRetorno = negTransportador.Excluir(this.objTransportador);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwTransportador.DataSource = null;
                    dgwTransportador.Update();
                    dgwTransportador.Refresh();

                    cpoIDTransportador.Clear();
                    cpoNome.Clear();
                    cpoVeiculo.Clear();
                    cpoPlaca.Clear();
                    cpoCidade.Clear();
                    cpoTelefone.Clear();
                    cpoEndereco.Clear();
                    cpoUf.Clear();

                    btnSalvar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


         }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            dgwTransportador.Update();
            dgwTransportador.Refresh();

            cpoIDTransportador.Clear();
            cpoNome.Clear();
            cpoVeiculo.Clear();
            cpoPlaca.Clear();
            cpoCidade.Clear();
            cpoTelefone.Clear();
            cpoEndereco.Clear();
            cpoUf.Clear();

            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = true;
        }

        private void cpoTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cpoCaixaPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                this.AtualizarGrid();

            
        }

        private void cpoPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cpoPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cpoCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
            cpoCaixaPesquisa.Text = ConvMaiuscula(cpoCaixaPesquisa.Text).ToString();
            cpoCaixaPesquisa.SelectionStart = cpoCaixaPesquisa.Text.Length;
        }
    }
    
}
