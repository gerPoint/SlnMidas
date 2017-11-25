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
    public class NegFornecedor
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", fornecedor.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCnpj", fornecedor.Cnpj));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", fornecedor.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", fornecedor.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", fornecedor.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", fornecedor.Uf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", fornecedor.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", fornecedor.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", fornecedor.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRazaoSocial", fornecedor.RazaoSocial));
                //acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INDataCadastro", fornecedor.DataCadastro));

                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDFornecedor = acessoDadosSqlServer.ExecutarScalar("uspCadastrarFornecedor", CommandType.StoredProcedure).ToString();
                return IDFornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Fornecedor. Motivo: " + ex.Message);

            }


        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select)]
        public FornecedorLista Consultar(string strNome)
        {
            try
            {
                FornecedorLista fornecedorLista = new FornecedorLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarFornecedor", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Fornecedor fornecedor = new Fornecedor();

                        fornecedor.IDFornecedor = Convert.ToInt32(linha["IDFornecedor"]);
                        fornecedor.Nome = linha["Nome"].ToString();
                        fornecedor.Telefone = linha["Telefone"].ToString();
                        fornecedor.Email = linha["Email"].ToString();
                        fornecedor.Cidade = linha["Cidade"].ToString();
                        fornecedor.Status = Convert.ToChar(linha["Status"]);
                        fornecedor.Endereco = Convert.ToString(linha["Endereco"]);
                        fornecedor.Cnpj = Convert.ToString(linha["Cnpj"]);
                        fornecedor.Cpf = Convert.ToString(linha["Cpf"]);
                        fornecedor.Uf = Convert.ToString(linha["Uf"]);
                        fornecedor.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                        fornecedor.RazaoSocial = Convert.ToString(linha["RazaoSocial"]);
                       



                        fornecedorLista.Add(fornecedor);
                    }
                }
                return fornecedorLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Fornecedor. Motivo: " + ex.Message);
            }



        }





    }
}
