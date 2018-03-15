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
    public class NegCarregamentoBloco
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(CarregamentoBloco blocos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                // acessoDados.AdicionarParametro(new SqlParameter("@INIDProduto", blocos.Produto.IDProduto));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INBloco", blocos.Bloco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQuantidade", blocos.Quantidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDescricao", blocos.Descricao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDRomaneio", blocos.IDRomaneio));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFrutaP", blocos.FrutaP));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFrutaM", blocos.FrutaM));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFrutaG", blocos.FrutaG));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdP", blocos.QtdP));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdM", blocos.QtdM));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdG", blocos.QtdG));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INPrecoP", blocos.PrecoP));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INPrecoM", blocos.PrecoM));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INPrecoG", blocos.PrecoG));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorUnitP", blocos.ValorUnitP));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorUnitM", blocos.ValorUnitM));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorUnitG", blocos.ValorUnitG));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTotalBloco", blocos.TotalBloco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTotalCarreg", blocos.TotalCarreg));



                string IDCarregamentoBloco = acessoDadosSqlServer.ExecutarScalar("uspCadastrarBlocos", CommandType.StoredProcedure).ToString();

                return IDCarregamentoBloco;

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Bloco. Motivo: " + ex.Message);
            }

        }


        public ListaCarregamentoBloco Consultar(string codRomaneio)
        {
            try
            {
                ListaCarregamentoBloco carregBlocoLista = new ListaCarregamentoBloco();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDRomaneio", codRomaneio));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarCarregamentos", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        CarregamentoBloco carregamentoBloco = new CarregamentoBloco();

                        carregamentoBloco.IDRomaneio = Convert.ToInt32(linha["IDRomaneio"]);
                        carregamentoBloco.IDCarregamentoBloco = Convert.ToInt32(linha["IDCarregamentoBloco"]);
                        carregamentoBloco.Bloco = linha["Bloco"].ToString();
                        carregamentoBloco.Descricao = linha["Descricao"].ToString();
                        carregamentoBloco.FrutaP = linha["FrutaP"].ToString();
                        carregamentoBloco.FrutaM = linha["FrutaM"].ToString();
                        carregamentoBloco.FrutaG = linha["FrutaG"].ToString();
                        carregamentoBloco.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                        carregamentoBloco.PrecoP = Convert.ToDecimal(linha["PrecoP"]);
                        carregamentoBloco.PrecoM = Convert.ToDecimal(linha["PrecoM"]);
                        carregamentoBloco.PrecoG = Convert.ToDecimal(linha["PrecoG"]);
                        carregamentoBloco.QtdP = Convert.ToInt32(linha["QtdP"]);
                        carregamentoBloco.QtdM = Convert.ToInt32(linha["QtdM"]);
                        carregamentoBloco.QtdG = Convert.ToInt32(linha["QtdG"]);
                        carregamentoBloco.ValorUnitP = Convert.ToDecimal(linha["ValorUnitP"]);
                        carregamentoBloco.ValorUnitM = Convert.ToDecimal(linha["ValorUnitM"]);
                        carregamentoBloco.ValorUnitG = Convert.ToDecimal(linha["ValorUnitG"]);
                        carregamentoBloco.TotalBloco = Convert.ToDecimal(linha["TotalBloco"]);


                        carregBlocoLista.Add(carregamentoBloco);
                    }
                }
                return carregBlocoLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Carregamentos. Motivo: " + ex.Message);
            }



        }




    }
}