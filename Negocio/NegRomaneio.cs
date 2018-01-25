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
   public class NegRomaneio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]

        public string Cadastrar(Romaneio romaneio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDCliente", romaneio.IDCliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDTransportador", romaneio.IDTransportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFornecedor", romaneio.IDFornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFruta", romaneio.IDFruta));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdFrutas", romaneio.QtdFrutas));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDCarregamento", romaneio.IDCarregamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorFrete", romaneio.ValorFrete));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INAdiantFretMot", romaneio.AdiantFretMot));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFormaPagamento", romaneio.FormaPagamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCustoCarregamento", romaneio.CustoCarregamento));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorComissao", romaneio.ValorComissao));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INValorTotalRomaneio", romaneio.ValorTotalRomaneio));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTaxaNf", romaneio.TaxaNf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INSeguro", romaneio.Seguro));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUnidMedida", romaneio.UnidMedida));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", romaneio.Status));
                

                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDRomaneio = acessoDadosSqlServer.ExecutarScalar("uspCadastrarRomaneio", CommandType.StoredProcedure).ToString();
                return IDRomaneio;
            }
            catch (Exception ex)
            {
               throw new Exception("Falha ao Cadastrar Romaneio. Motivo: " + ex.Message);

            }


        }

        public RomaneioLista ConsultarCodigo(int Codigo)
        {
            try
            {
                RomaneioLista romaneioLista = new RomaneioLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDRomaneio", Codigo));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarRomaneioCodigo", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Romaneio romaneio = new Romaneio();

                        romaneio.IDRomaneio = Convert.ToInt32(linha["IDRomaneio"]);
                        romaneio.IDCliente = Convert.ToInt32(linha["IDCliente"]);
                        romaneio.IDTransportador = Convert.ToInt32(linha["IDTransportador"]);
                        romaneio.IDFornecedor = Convert.ToInt32(linha["IDFornecedor"]);
                        romaneio.IDFruta = Convert.ToInt32(linha["IDFruta"]);
                        romaneio.QtdFrutas= Convert.ToInt32(linha["QtdFrutas"]);                       
                        //romaneio.IDCarregamento = Convert.ToInt32(linha["IDCarregamento"]);
                        romaneio.ValorFrete = Convert.ToDecimal(linha["ValorFrete"]);
                        romaneio.Seguro = Convert.ToDecimal(linha["Seguro"]);
                        romaneio.AdiantFretMot = Convert.ToDecimal(linha["AdiantFretMot"]);
                        romaneio.DataRomaneio = Convert.ToDateTime(linha["DataRomaneio"]);
                        //romaneio.DataAlteracao = Convert.ToDateTime(linha["DataAlteracao"]);
                        //romaneio.DataExclusao = Convert.ToDateTime(linha["DataExclusao"]);
                        romaneio.FormaPagamento = Convert.ToString(linha["FormaPagamento"]);
                        romaneio.CustoCarregamento = Convert.ToDecimal(linha["CustoCarregamento"]);
                        romaneio.ValorComissao = Convert.ToDecimal(linha["ValorComissao"]);
                        romaneio.ValorTotalRomaneio = Convert.ToDecimal(linha["ValorTotalRomaneio"]);
                        romaneio.TaxaNf = Convert.ToDecimal(linha["TaxaNf"]);
                        romaneio.UnidMedida = Convert.ToString(linha["UnidMedida"]);
                        romaneio.Status = Convert.ToChar(linha["Status"]);

                        romaneioLista.Add(romaneio);
                    }
                }
                return romaneioLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Romaneio. Motivo: " + ex.Message);
            }

        }


     }

}
