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
        private Cliente cliente;
        string mensagem = "";
        NegCliente negCliente = new NegCliente();
        Cliente objCliente = new Cliente();
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
          
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lbl_data_hora.Text = data_hora.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                this.objCliente.Nome = cpoNome.Text.TrimStart();
                this.objCliente.RazaoSocial = cpoRazaoSocial.Text;
                this.objCliente.Cnpj = cpoCnpj.Text.TrimStart();
                this.objCliente.Endereco = cpoEndereco.Text.TrimStart();
                this.objCliente.Cidade = cpoCidade.Text.TrimStart();
                this.objCliente.Uf= cpoUf.Text.TrimStart();
                this.objCliente.Telefone = cpoTelefone.Text.TrimStart();
                this.objCliente.Email = cpoEmail.Text.TrimStart();
                this.objCliente.Cpf = cpoCpf.Text.TrimStart();


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




                strRetorno = negCliente.Cadastrar(this.objCliente);


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
                    AtualizarGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
