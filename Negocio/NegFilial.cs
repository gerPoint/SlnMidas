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
   public class NegFilial
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Filial filial)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", filial.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRazaoSocial", filial.RazaoSocial));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCnpj", filial.Cnpj));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", filial.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", filial.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", filial.Uf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", filial.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", filial.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INChaveSistema", filial.ChaveSistema));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", filial.Status));


                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDFilial = acessoDadosSqlServer.ExecutarScalar("uspCadastrarFilial", CommandType.StoredProcedure).ToString();
                return IDFilial;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Filial. Motivo: " + ex.Message);

            }


        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select)]
        public FilialLista Consultar(string strNome)
        {
            try
            {
                FilialLista filialLista = new FilialLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarFilial", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Filial filial = new Filial();

                        filial.IDFilial = Convert.ToInt32(linha["IDFilial"]);
                        filial.Nome = linha["Nome"].ToString();
                        filial.RazaoSocial = linha["RazaoSocial"].ToString();
                        filial.Telefone = linha["Telefone"].ToString();
                        filial.Email = linha["Email"].ToString();
                        filial.Cidade = linha["Cidade"].ToString();
                        filial.Status = Convert.ToChar(linha["Status"]);
                        filial.Endereco = Convert.ToString(linha["Endereco"]);
                        filial.Cnpj = Convert.ToString(linha["Cnpj"]);
                        filial.ChaveSistema = Convert.ToString(linha["ChaveSistema"]);
                        filial.Uf = Convert.ToString(linha["Uf"]);
                        filial.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);



                        filialLista.Add(filial);
                    }
                }
                return filialLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Filial. Motivo: " + ex.Message);
            }



        }

        public string Alterar(Filial filial)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFilial", filial.IDFilial));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", filial.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRazaoSocial", filial.RazaoSocial));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", filial.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", filial.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", filial.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", filial.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", filial.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INChaveSistema", filial.ChaveSistema));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCnpj", filial.Cnpj));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", filial.Uf));

                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspAlterarFilial", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Filial. Motivo: " + ex.Message);
            }






        }




    }
}
