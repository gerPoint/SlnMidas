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
    public class NegClassificFruta
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(ClassificFruta classificfruta)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INClassificacao", classificfruta.Classificacao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", classificfruta.Status));


                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDClassificacao = acessoDadosSqlServer.ExecutarScalar("uspCadastrarClassificFruta", CommandType.StoredProcedure).ToString();
                return IDClassificacao;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Classificação de Fruta. Motivo: " + ex.Message);

            }


        }

        public ClassificFrutaLista Consultar(string strClassificacao)
        {
            try
            {
                ClassificFrutaLista classificfrutaLista = new ClassificFrutaLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INClassificacao", strClassificacao));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarClassificFruta", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        ClassificFruta classificfruta = new ClassificFruta();

                        classificfruta.IDClassificacao = Convert.ToInt32(linha["IDClassificacao"]);
                        classificfruta.Classificacao = linha["Classificacao"].ToString();


                        classificfrutaLista.Add(classificfruta);
                    }
                }
                return classificfrutaLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Classificação da Fruta. Motivo: " + ex.Message);
            }



        }

        public string Alterar(ClassificFruta classificfruta)

        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDClassificacao", classificfruta.IDClassificacao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INClassificacao", classificfruta.Classificacao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", classificfruta.Status));



                string codItem = acessoDadosSqlServer.ExecutarScalar("uspAlterarClassificFruta", CommandType.StoredProcedure).ToString();

                return codItem;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Classificação de Fruta. Motivo: " + ex.Message);

            }


        }


        public string Excluir(ClassificFruta classificfruta)

        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDClassificacao", classificfruta.IDClassificacao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INClassificacao", classificfruta.Classificacao));
 


                string codItem = acessoDadosSqlServer.ExecutarScalar("uspInativarClassificFruta", CommandType.StoredProcedure).ToString();

                return codItem;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir Classificação de Fruta. Motivo: " + ex.Message);

            }


        }




    }



}

