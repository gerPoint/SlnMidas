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
    public partial class frmFruta : Form
    {

        NegFruta negCliente = new NegFruta();

        private Fruta objFruta = new Fruta();


        public frmFruta()
        {
            InitializeComponent();
        }


        private void frmFruta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSet1.tblFruta' table. You can move, or remove it, as needed.
            /*this.tblFrutaTableAdapter.Fill(this.midasDataSet1.tblFruta);*/

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fruta objFruta = new Fruta();

            this.objFruta.Nome = cpoNome.Text.TrimStart();
            this.objFruta.UnidMedida = cpoUnidMedida.Text.TrimStart();



            string strRetorno = string.Empty;

            if (cpoNome.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }

            if (cpoUnidMedida.Text == "")
            {
                MessageBox.Show("Campo Obrigatório não informado.");
                return;
            }


            NegFruta negFruta = new NegFruta();
            strRetorno = negFruta.Cadastrar(this.objFruta);

            try
            {


                int idFruta = Convert.ToInt32(strRetorno);
               
                {
                    //MessageBox.Show("Registro salvo com sucesso! Código: " + idFruta.ToString()); - tbm funciona esse 
                    MessageBox.Show("Registro salvo com sucesso!", "Código: " + idFruta.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //limpa os campos depois de salvar 
                    cpoNome.Clear();
                    cpoUnidMedida.Clear();


                    dgwFruta.DataSource = null;
                    dgwFruta.Update();
                    dgwFruta.Refresh();

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

                dgwFruta.DataSource = null;
                dgwFruta.DataSource = objLista;
                dgwFruta.Update();
                dgwFruta.Refresh();
                cpoCaixaPesquisa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar Fruta. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        public void dgwFruta_DoubleClick(object sender, EventArgs e)
        {
            cpoIDFruta.Text = dgwFruta.SelectedRows[0].Cells[0].Value.ToString();
            cpoNome.Text = dgwFruta.SelectedRows[0].Cells[1].Value.ToString();
            cpoUnidMedida.Text = dgwFruta.SelectedRows[0].Cells[2].Value.ToString();
            //cpoStatus.Text = dgwCliente.SelectedRows[0].Cells[9].Value.ToString();
            btnSalvar.Enabled = false;
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
               
                this.objFruta.IDFruta = Convert.ToInt32(cpoIDFruta.Text);
                this.objFruta.Nome = cpoNome.Text.TrimStart();
                this.objFruta.UnidMedida = cpoUnidMedida.Text.TrimStart();
      


                string strRetorno = string.Empty;

                if (cpoNome.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                if (cpoUnidMedida.Text == "")
                {
                    MessageBox.Show("Campo Obrigatório não informado.");
                    return;
                }

                NegFruta negFruta = new NegFruta();
                strRetorno = negFruta.Alterar(this.objFruta);



                int intCodigo;
                if (int.TryParse(strRetorno, out intCodigo) == true)
                {
                    MessageBox.Show("Registro alterado com sucesso!", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwFruta.DataSource = null;
                    dgwFruta.Update();
                    dgwFruta.Refresh();
                    // CaixaPesquisa.Text = "%%";
                    // AtualizarGrid();
                    cpoIDFruta.Clear();
                    cpoNome.Clear();
                    cpoUnidMedida.Clear();





                    btnSalvar.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro. Falha: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
    
