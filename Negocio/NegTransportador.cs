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
    public class NegTransportador
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Transportador transportador)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", transportador.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INVeiculo", transportador.Veiculo));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", transportador.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", transportador.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", transportador.Uf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", transportador.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INPlaca", transportador.Placa));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", transportador.Telefone));

                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDTransportador = acessoDadosSqlServer.ExecutarScalar("uspCadastrarTransportador", CommandType.StoredProcedure).ToString();
                return IDTransportador;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Transportador. Motivo: " + ex.Message);

            }


        }

        public TransportadorLista Consultar(string strNome)
        {
            try
            {
                TransportadorLista transportadorLista = new TransportadorLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO fez assim) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarTransportador", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Transportador transportador = new Transportador();

                        transportador.IDTransportador = Convert.ToInt32(linha["IDTransportador"]);
                        transportador.Nome = linha["Nome"].ToString();
                        transportador.Endereco = linha["Endereco"].ToString();
                        transportador.Cidade = linha["Cidade"].ToString();
                        transportador.Uf = linha["Uf"].ToString();
                        transportador.Veiculo = linha["Veiculo"].ToString();
                        transportador.Placa = linha["Placa"].ToString();
                        transportador.Telefone = linha["Telefone"].ToString();
                        transportador.Status = Convert.ToChar(linha["Status"]);
                        transportador.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);




                        transportadorLista.Add(transportador);
                    }
                }
                return transportadorLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Transportador. Motivo: " + ex.Message);
            }



        }

        public string Alterar(Transportador transportador)

        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDTransportador", transportador.IDTransportador));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", transportador.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", transportador.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", transportador.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", transportador.Uf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INVeiculo", transportador.Veiculo));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INPlaca", transportador.Placa));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", transportador.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", transportador.Status));
               

                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspAlterarTransportador", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Transportador. Motivo: " + ex.Message);

            }


        }



    }

}
