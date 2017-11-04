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
    public class NegCliente
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                //acessoDados.AdicionarParametro(new SqlParameter("@INIDCliente", cliente.IDCliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", cliente.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRazaoSocial", cliente.RazaoSocial));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", cliente.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", cliente.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", cliente.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", cliente.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", cliente.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", cliente.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCnpj", cliente.Cnpj));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", cliente.Uf));

               //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDCliente = acessoDadosSqlServer.ExecutarScalar("uspCadastrarCliente", CommandType.StoredProcedure).ToString();
                return IDCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Cliente. Motivo: " + ex.Message);

            }



        }




        [DataObjectMethodAttribute(DataObjectMethodType.Select)]
        public ClienteLista Consultar(string strNome)
        {
            try
            {
                ClienteLista clienteLista = new ClienteLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarCliente", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Cliente cliente = new Cliente();

                        cliente.IDCliente = Convert.ToInt32(linha["IDCliente"]);
                        cliente.Nome = linha["Nome"].ToString();
                        cliente.RazaoSocial = linha["RazaoSocial"].ToString();
                        cliente.Telefone = linha["Telefone"].ToString();
                        cliente.Email = linha["Email"].ToString();
                        cliente.Cidade = linha["Cidade"].ToString();
                        cliente.Status = Convert.ToChar(linha["Status"]);
                        cliente.Endereco = Convert.ToString(linha["Endereco"]);
                        cliente.Cpf = Convert.ToString(linha["Cpf"]);
                        cliente.Cnpj = Convert.ToString(linha["Cnpj"]);
                        cliente.Uf = Convert.ToString(linha["Uf"]);



                        clienteLista.Add(cliente);
                    }
                }
                return clienteLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Cliente. Motivo: " + ex.Message);
            }



        }

               public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", cliente.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRazaoSocial", cliente.RazaoSocial));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", cliente.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", cliente.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", cliente.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", cliente.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", cliente.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", cliente.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCnpj", cliente.Cnpj));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", cliente.Uf));

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






