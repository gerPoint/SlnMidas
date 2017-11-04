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
    public class NegFruta
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Fruta fruta)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
              
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", fruta.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUnidMedida", fruta.UnidMedida));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", fruta.Status));


                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDFruta = acessoDadosSqlServer.ExecutarScalar("uspCadastrarFruta", CommandType.StoredProcedure).ToString();
                return IDFruta;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Fruta. Motivo: " + ex.Message);

            }


        }

        public FrutaLista Consultar(string strNome)
        {
            try
            {
                FrutaLista frutaLista = new FrutaLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarFruta", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Fruta fruta = new Fruta();

                        fruta.IDFruta = Convert.ToInt32(linha["IDFruta"]);
                        fruta.Nome = linha["Nome"].ToString();
                        fruta.UnidMedida = linha["UnidMedida"].ToString();
                        fruta.Status = Convert.ToChar(linha["Status"]);




                        frutaLista.Add(fruta);
                    }
                }
                return frutaLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Fruta. Motivo: " + ex.Message);
            }



        }

        public string Alterar(Fruta fruta)

        { 
             try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", fruta.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUnidMedida", fruta.UnidMedida));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", fruta.Status));


                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspAlterarCliente", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Produto. Motivo: " + ex.Message);

             }


         }
        


    }



}
    
