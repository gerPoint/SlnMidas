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
        AcessoSqlServer acessoDados = new AcessoSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Cliente cliente)
        {
            try
            {
                acessoDados.LimparParametros();
                //acessoDados.AdicionarParametro(new SqlParameter("@INIDCliente", cliente.IDCliente));
                acessoDados.AdicionarParametros("@INNome", cliente.Nome);
                acessoDados.AdicionarParametros("@INRazaoSocial", cliente.RazaoSocial);
                acessoDados.AdicionarParametros("@INTelefone", cliente.Telefone);
                acessoDados.AdicionarParametros("@INEmail", cliente.Email);
                acessoDados.AdicionarParametros("@INCidade", cliente.Cidade);
                acessoDados.AdicionarParametros("@INEndereco", cliente.Endereco);
                acessoDados.AdicionarParametros("@INCpf", cliente.Cpf);
                acessoDados.AdicionarParametros("@INCnpj", cliente.Cnpj);
                acessoDados.AdicionarParametros("@INUf", cliente.Uf);
                acessoDados.AdicionarParametros("@INStatus", cliente.Status);



                string IDCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
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
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametro = new SqlParameter(strNome, "@INNome"));
            
                using (DataTable dataTable = acessoDados.GetDataTable("uspConsultarCliente", CommandType.StoredProcedure))
                {
                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Cliente cliente = new Cliente();

                        cliente.IDCliente = Convert.ToInt32(linha["IDCliente"]);
                        cliente.Nome = linha["Nome"].ToString();
                        cliente.RazaoSocial = Convert.ToString(linha["RazaoSocial"]);
                        cliente.Telefone = linha["Telefone"].ToString();
                        cliente.Email = linha["Email"].ToString();
                        cliente.Cpf = Convert.ToString(linha["CPF"]);
                        cliente.Ie = linha["IE"].ToString();
                        cliente.Sexo = linha["Sexo"].ToString();
                        if (cliente.Sexo == "1") { cliente.Sexo = "M"; } else { cliente.Sexo = "F"; }
                        cliente.Endereco = Convert.ToString(linha["Endereco"]);



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


