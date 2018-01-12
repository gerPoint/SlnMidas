﻿using System;
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
    public partial class frmSelecionarFornecedor : Form
    {
        public frmSelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void frmSelecionarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetFornecedor.tblFornecedor' table. You can move, or remove it, as needed.
        }

        //--------------------------------------------SERVE PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO---------------------------

        public String NomeFornecedor
        {
            get { return cpoNomeFornecedor.Text; }
            set { cpoNomeFornecedor.Text = value; }
        }

        public String IDFornecedor
        {
            get { return cpoIDFornecedor.Text; }
            set { cpoIDFornecedor.Text = value; }
        }
        //--------------------------------------------SERVE PARA PEGAR DADOS DE UM FORM E PASSAR PARA OUTRO---------------------------

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

                dgwSelFornecedor.DataSource = null;
                dgwSelFornecedor.DataSource = objLista;
                dgwSelFornecedor.Update();
                dgwSelFornecedor.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Fornecedor. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cpoIDFornecedor.Text == "") //verifica se o campo id está vazio --tanto pro alterar quanto pro excluir a gente só vai usar o (id) 
            {
                MessageBox.Show("Pesquise o fornecedor desejado e selecione-o dando um clique duplo sobre ele.");
                return;
            }
            Fornecedor fornecedor = (dgwSelFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
            cpoIDFornecedor.Text = fornecedor.Nome;
            cpoIDFornecedor.Text = fornecedor.IDFornecedor.ToString();
            this.Close();
        }

        private void dgwSelFornecedor_DoubleClick(object sender, EventArgs e)
        {
            Fornecedor fornecedor = (dgwSelFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
            cpoIDFornecedor.Text = dgwSelFornecedor.SelectedRows[0].Cells[0].Value.ToString();
            cpoNomeFornecedor.Text = dgwSelFornecedor.SelectedRows[0].Cells[1].Value.ToString();
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

        //--------------------------------Somente a primeira letra maiuscula de cada palavra---------------------------------------------
    }

}
