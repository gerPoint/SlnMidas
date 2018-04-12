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
using iTextSharp;

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
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCliente", romaneio.Cliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTransportador", romaneio.Transportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFornecedor", romaneio.Fornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFruta", romaneio.Fruta));


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

        public DataSet RelRomaneio(int Codigo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro( new SqlParameter("@INIntIDRomaneio", Codigo));

                using (DataSet dtbRgistros = acessoDadosSqlServer.GetDataTables("uspConsultarRomaneioNOVO", CommandType.StoredProcedure))
                {
                    return dtbRgistros;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
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
                        romaneio.ValorFrete = Convert.ToDecimal(linha["ValorFrete"]);
                        romaneio.Seguro = Convert.ToDecimal(linha["Seguro"]);
                        romaneio.AdiantFretMot = Convert.ToDecimal(linha["AdiantFretMot"]);
                        romaneio.DataRomaneio = Convert.ToDateTime(linha["DataRomaneio"]);
                        romaneio.FormaPagamento = Convert.ToString(linha["FormaPagamento"]);
                        romaneio.CustoCarregamento = Convert.ToDecimal(linha["CustoCarregamento"]);
                        romaneio.ValorComissao = Convert.ToDecimal(linha["ValorComissao"]);
                        romaneio.ValorTotalRomaneio = Convert.ToDecimal(linha["ValorTotalRomaneio"]);
                        romaneio.TaxaNf = Convert.ToDecimal(linha["TaxaNf"]);
                        romaneio.UnidMedida = Convert.ToString(linha["UnidMedida"]);
                        romaneio.Status = Convert.ToChar(linha["Status"]);
                        romaneio.Cliente = Convert.ToString(linha["Cliente"]);
                        romaneio.Transportador = Convert.ToString(linha["Transportador"]);
                        romaneio.Fornecedor = Convert.ToString(linha["Fornecedor"]);
                        romaneio.Fruta = Convert.ToString(linha["Fruta"]);

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


        public RomaneioLista ConsultarData(DateTime DataInicio,DateTime DataFim)
        {
            try
            {
                RomaneioLista romaneioLista = new RomaneioLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDataRomaneioInicio", DataInicio));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDataRomaneioFim", DataFim));
                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarRomaneioData", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Romaneio romaneio = new Romaneio();

                        romaneio.IDRomaneio = Convert.ToInt32(linha["IDRomaneio"]);
                        romaneio.IDCliente = Convert.ToInt32(linha["IDCliente"]);
                        romaneio.IDTransportador = Convert.ToInt32(linha["IDTransportador"]);
                        romaneio.IDFornecedor = Convert.ToInt32(linha["IDFornecedor"]);
                        romaneio.IDFruta = Convert.ToInt32(linha["IDFruta"]);
                        romaneio.QtdFrutas = Convert.ToInt32(linha["QtdFrutas"]);
                        romaneio.ValorFrete = Convert.ToDecimal(linha["ValorFrete"]);
                        romaneio.Seguro = Convert.ToDecimal(linha["Seguro"]);
                        romaneio.AdiantFretMot = Convert.ToDecimal(linha["AdiantFretMot"]);
                        romaneio.DataRomaneio = Convert.ToDateTime(linha["DataRomaneio"]);
                        romaneio.FormaPagamento = Convert.ToString(linha["FormaPagamento"]);
                        romaneio.CustoCarregamento = Convert.ToDecimal(linha["CustoCarregamento"]);
                        romaneio.ValorComissao = Convert.ToDecimal(linha["ValorComissao"]);
                        romaneio.ValorTotalRomaneio = Convert.ToDecimal(linha["ValorTotalRomaneio"]);
                        romaneio.TaxaNf = Convert.ToDecimal(linha["TaxaNf"]);
                        romaneio.UnidMedida = Convert.ToString(linha["UnidMedida"]);
                        romaneio.Status = Convert.ToChar(linha["Status"]);
                        romaneio.Cliente = Convert.ToString(linha["Cliente"]);
                        romaneio.Transportador = Convert.ToString(linha["Transportador"]);
                        romaneio.Fornecedor = Convert.ToString(linha["Fornecedor"]);
                        romaneio.Fruta = Convert.ToString(linha["Fruta"]);

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

        public string Alterar(Romaneio romaneio)

        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDRomaneio", romaneio.IDRomaneio));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDCliente", romaneio.IDCliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDTransportador", romaneio.IDTransportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFornecedor", romaneio.IDFornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFruta", romaneio.IDFruta));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdFrutas", romaneio.QtdFrutas));
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
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCliente", romaneio.Cliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTransportador", romaneio.Transportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFornecedor", romaneio.Fornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFruta", romaneio.Fruta));



                string codRomaneio = acessoDadosSqlServer.ExecutarScalar("uspAlterarRomaneio", CommandType.StoredProcedure).ToString();

                return codRomaneio;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Romaneio. Motivo: " + ex.Message);

            }


        }



        public string Excluir(Romaneio romaneio)

        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDRomaneio", romaneio.IDRomaneio));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDCliente", romaneio.IDCliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDTransportador", romaneio.IDTransportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFornecedor", romaneio.IDFornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDFruta", romaneio.IDFruta));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INQtdFrutas", romaneio.QtdFrutas));
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
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCliente", romaneio.Cliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTransportador", romaneio.Transportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFornecedor", romaneio.Fornecedor));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INFruta", romaneio.Fruta));



                string codRomaneio = acessoDadosSqlServer.ExecutarScalar("uspInativarRomaneio", CommandType.StoredProcedure).ToString();

                return codRomaneio;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir Romaneio. Motivo: " + ex.Message);

            }




           }


        }

    }
