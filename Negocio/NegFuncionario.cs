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
    public class NegFuncionario
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Funcionario funcionario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", funcionario.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", funcionario.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", funcionario.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", funcionario.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", funcionario.Uf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", funcionario.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", funcionario.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRg", funcionario.Rg));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", funcionario.Status));


                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDFuncionario = acessoDadosSqlServer.ExecutarScalar("uspCadastrarFuncionario", CommandType.StoredProcedure).ToString();
                return IDFuncionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Funcionario. Motivo: " + ex.Message);

            }


        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select)]
        public FuncionarioLista Consultar(string strNome)
        {
            try
            {
                FuncionarioLista funcionarioLista = new FuncionarioLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarFuncionario", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Funcionario funcionario = new Funcionario();

                        funcionario.IDFuncionario = Convert.ToInt32(linha["IDFuncionario"]);
                        funcionario.Nome = linha["Nome"].ToString();
                        funcionario.Telefone = linha["Telefone"].ToString();
                        funcionario.Email = linha["Email"].ToString();
                        funcionario.Cidade = linha["Cidade"].ToString();
                        funcionario.Status = Convert.ToChar(linha["Status"]);
                        funcionario.Endereco = Convert.ToString(linha["Endereco"]);
                        funcionario.Cpf = Convert.ToString(linha["Cpf"]);
                        funcionario.Rg = Convert.ToString(linha["Rg"]);
                        funcionario.Uf = Convert.ToString(linha["Uf"]);

                    



                        funcionarioLista.Add(funcionario);
                    }
                }
                return funcionarioLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Funcionario. Motivo: " + ex.Message);
            }



        }


    }

}