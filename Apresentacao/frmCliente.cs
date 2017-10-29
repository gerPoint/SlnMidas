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

        //private Cliente cliente = new Cliente();
        NegCliente negCliente = new NegCliente();
       
       private Cliente objCliente = new Cliente();
       
      //  DateTime data_hora;

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
           // this.tblClienteTableAdapter.Fill(this.midasDataSet.tblCliente);
            // TODO: This line of code loads data into the 'midasDataSet.tblCliente' table. You can move, or remove it, as needed.
            // this.tblClienteTableAdapter.Fill(this.midasDataSet.tblCliente);

        }




       

 private void btnSalvar_Click(object sender, EventArgs e)

        {

            Cliente objCliente = new Cliente();

            this.objCliente.Nome = cpoNome.Text.TrimStart();
            this.objCliente.RazaoSocial = cpoRazaoSocial.Text;
            this.objCliente.Cnpj = cpoCnpj.Text.TrimStart();
            this.objCliente.Endereco = cpoEndereco.Text.TrimStart();
            this.objCliente.Cidade = cpoCidade.Text.TrimStart();
            this.objCliente.Uf = cpoUf.Text.TrimStart();
            this.objCliente.Telefone = cpoTelefone.Text.TrimStart();
            this.objCliente.Email = cpoEmail.Text.TrimStart();
            this.objCliente.Cpf = cpoCpf.Text.TrimStart();


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

            // strRetorno = this.negCliente.Cadastrar(this.objCliente);

            NegCliente negCliente = new NegCliente();
            strRetorno = negCliente.Cadastrar(this.objCliente);

            try
            {


                int idCliente = Convert.ToInt32(strRetorno);
                //  if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro salvo com sucesso! Código: " + idCliente.ToString());

                    // this.DialogResult = DialogResult.OK;

                    //limpa os campos depois de salvar 
                    cpoNome.Clear();
                    cpoRazaoSocial.Clear();
                    cpoEndereco.Clear();
                    cpoEmail.Clear();
                    cpoCpf.Clear();
                    cpoCnpj.Clear();
                    cpoCidade.Clear();
                    cpoCaixaPesquisa.Clear();
                    cpoTelefone.Clear();
                    cpoUf.Clear();
                   


                    dgwCliente.DataSource = null;
                    dgwCliente.Update();
                    dgwCliente.Refresh();

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
                    MessageBox.Show("Por favor, informe o nome do Cliente para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegCliente objNegCliente = new NegCliente();
                ClienteLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegCliente.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegCliente.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwCliente.DataSource = null;
                dgwCliente.DataSource = objLista;
                dgwCliente.Update();
                dgwCliente.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Cliente. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwCliente_DoubleClick(object sender, EventArgs e)
        {
          //  cpoIDCliente.Text = dgwCliente.SelectedRows[0].Cells[0].Value.ToString();
            cpoNome.Text = dgwCliente.SelectedRows[0].Cells[1].Value.ToString();
            cpoRazaoSocial.Text = dgwCliente.SelectedRows[0].Cells[2].Value.ToString();
            cpoTelefone.Text = dgwCliente.SelectedRows[0].Cells[3].Value.ToString();
            cpoEmail.Text = dgwCliente.SelectedRows[0].Cells[4].Value.ToString();
            cpoCidade.Text = dgwCliente.SelectedRows[0].Cells[5].Value.ToString();
            cpoUf.Text = dgwCliente.SelectedRows[0].Cells[6].Value.ToString();
            cpoEndereco.Text = dgwCliente.SelectedRows[0].Cells[7].Value.ToString();
            cpoCpf.Text = dgwCliente.SelectedRows[0].Cells[8].Value.ToString();
            cpoCnpj.Text = dgwCliente.SelectedRows[0].Cells[9].Value.ToString();
            //cpoStatus.Text = dgwCliente.SelectedRows[0].Cells[9].Value.ToString();
            btnSalvar.Enabled = false;
        }
    }
    }

