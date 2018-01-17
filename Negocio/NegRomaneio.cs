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
                //acessoDados.AdicionarParametro(new SqlParameter("@INIDCliente", cliente.IDCliente));
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
     }

}
