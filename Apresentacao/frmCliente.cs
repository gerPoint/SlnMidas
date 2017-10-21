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
    public partial class frmCliente : Form
    {
        private objCliente cliente = new objCliente();
        string mensagem = "";
        NegCliente negCliente = new NegCliente();
        DateTime data_hora;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSet.tblCliente' table. You can move, or remove it, as needed.
            this.tblClienteTableAdapter.Fill(this.midasDataSet.tblCliente);

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    data_hora = DateTime.Now;
        //    lbl_data_hora.Text = data_hora.ToString();
        //}

       

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.cliente.Nome = cpoNome.Text.TrimStart();
                this.cliente.RazaoSocial = cpoRazaoSocial.Text;
                this.cliente.Cnpj = cpoCnpj.Text.TrimStart();
                this.cliente.Endereco = cpoEndereco.Text.TrimStart();
                this.cliente.Cidade = cpoCidade.Text.TrimStart();
                this.cliente.Uf = cpoUf.Text.TrimStart();
                this.cliente.Telefone = cpoTelefone.Text.TrimStart();
                this.cliente.Email = cpoEmail.Text.TrimStart();
                this.cliente.Cpf = cpoCpf.Text.TrimStart();


                //   if (cpoAtivo.Checked == true) { objCliente.Ativo = "1"; } else { objCliente.Ativo = "0"; }



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

                strRetorno = this.negCliente.Cadastrar(this.cliente);

                //if (strRetorno != null)
                //{
                //    MessageBox.Show(strRetorno);
                //}
                //else
                //{
                //    MessageBox.Show("Está nulo");
                //}



                // strRetorno = negCliente.Cadastrar(this.objCliente);


                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro salvo com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  this.DialogResult = DialogResult.OK;
                    dgwCliente.DataSource = null;
                    dgwCliente.Update();
                    dgwCliente.Refresh();
                    CaixaPesquisa.Text = "%%";
                    //AtualizarGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
