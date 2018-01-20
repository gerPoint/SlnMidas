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
    public partial class frmSelecionarFruta : Form
    {
        public frmSelecionarFruta()
        {
            InitializeComponent();
        }


        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO--------------------------------------------------------------------------
        public String NomeFruta
        {
            get { return cpoNomeFruta.Text; }
            set { cpoNomeFruta.Text = value; }
        }

        public String IDFruta
        {
            get { return cpoIDFruta.Text; }
            set { cpoIDFruta.Text = value; }
        }

        // -------------------------------------------------USADO PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO-----------------------------------------

        private void frmSelecionarFruta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show("Por favor, informe o nome da Fruta para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
                    return;
                }

                NegFruta objNegFruta = new NegFruta();
                FrutaLista objLista;
                try
                {
                    //int cod = int.Parse(CaixaPesquisa.Text);
                    objLista = objNegFruta.Consultar(cpoCaixaPesquisa.Text);
                }
                catch
                {

                    objLista = objNegFruta.Consultar(cpoCaixaPesquisa.Text);
                }


                if (objLista.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    return;
                }

                dgwSelecionarFruta.DataSource = null;
                dgwSelecionarFruta.DataSource = objLista;
                dgwSelecionarFruta.Update();
                dgwSelecionarFruta.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Fruta. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }



        private void btnSelecionar_Click(object sender, EventArgs e)
        {
          
        }



//--------------------------------Somente a primeira letra maiuscula de cada palavra---------------------------------------------

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

        private void dgwSelecionarFruta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Fruta fruta = (dgwSelecionarFruta.SelectedRows[0].DataBoundItem as Fruta);
                cpoIDFruta.Text = dgwSelecionarFruta.SelectedRows[0].Cells[0].Value.ToString();
                cpoNomeFruta.Text = dgwSelecionarFruta.SelectedRows[0].Cells[1].Value.ToString();

                if (cpoIDFruta.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
                {
                    MessageBox.Show("Pesquise a Fruta desejada e selecione-a dando um clique duplo sobre a mesma.");
                    return;
                }
                cpoIDFruta.Text = fruta.Nome;
                cpoIDFruta.Text = fruta.IDFruta.ToString();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //--------------------------------Somente a primeira letra maiuscula de cada palavra---------------------------------------------

    }
}
