using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using System.Data.SqlClient;
using ObjTransferencia;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System;

namespace Negocio
{
    public class NegFormaPagamento
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(FormaPagamento formaPagamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDescricao", formaPagamento.Descricao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INParcelamento", formaPagamento.Parcelamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", formaPagamento.Status));


                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDFormaPagamento = acessoDadosSqlServer.ExecutarScalar("uspCadastrarFormaPagamento", CommandType.StoredProcedure).ToString();
                return IDFormaPagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Forma de Pagamento. Motivo: " + ex.Message);

            }


        }

        public FormaPagamentoLista Consultar(string strDescricao)
        {
            try
            {
                FormaPagamentoLista formaPagamentoLista = new FormaPagamentoLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDescricao", strDescricao));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarFormaPagamento", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        FormaPagamento formaPagamento = new FormaPagamento();

                        formaPagamento.IDFormaPagamento = Convert.ToInt32(linha["IDFormaPagamento"]);
                        formaPagamento.Descricao = linha["Descricao"].ToString();
                        formaPagamento.Parcelamento = linha["Parcelamento"].ToString();
                        formaPagamento.Status = Convert.ToChar(linha["Status"]);
                        formaPagamento.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);



                        formaPagamentoLista.Add(formaPagamento);
                    }
                }
                return formaPagamentoLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Forma de Pagamento. Motivo: " + ex.Message);
            }



        }

        public string Alterar(FormaPagamento formaPagamento)

        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFormaPagamento", formaPagamento.IDFormaPagamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDescricao", formaPagamento.Descricao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INParcelamento", formaPagamento.Parcelamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", formaPagamento.Status));


                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspAlterarFormaPagamento", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Forma de Pagamento. Motivo: " + ex.Message);

            }


        }


        public string Excluir(FormaPagamento formaPagamento)

        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFormaPagamento", formaPagamento.IDFormaPagamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDescricao", formaPagamento.Descricao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INParcelamento", formaPagamento.Parcelamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", formaPagamento.Status));


                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspInativarFormaPagamento", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir Forma de Pagamento. Motivo: " + ex.Message);

            }


        }




    }



}

