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
            // TODO: This line of code loads data into the 'midasDataSet2.tblTransportador' table. You can move, or remove it, as needed.
            //this.tblTransportadorTableAdapter.Fill(this.midasDataSet2.tblTransportador);

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
                    MessageBox.Show("Por favor, informe o nome do Transportador para pesquisar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cpoCaixaPesquisa.Text = string.Empty;
                    cpoCaixaPesquisa.Focus();
                    //CaixaPesquisa.DataSource = "";
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
                MessageBox.Show("Falha ao consultar Fruta. Falha: " +
                    ex.Message, "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }




    }
}