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
    public class NegUsuario
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                //acessoDados.AdicionarParametro(new SqlParameter("@INIDCliente", cliente.IDCliente));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", usuario.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INSenha", usuario.Senha));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", usuario.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", usuario.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", usuario.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", usuario.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", usuario.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRg", usuario.Rg));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", usuario.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", usuario.Uf));

                //(DIEGO)string IDCliente = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspCadastrarCliente").ToString();
                //return IDCliente;

                string IDUsuario = acessoDadosSqlServer.ExecutarScalar("uspCadastrarUsuario", CommandType.StoredProcedure).ToString();
                return IDUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Usuário. Motivo: " + ex.Message);

            }

        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select)]
        public UsuarioLista Consultar(string strNome)
        {
            try
            {
                UsuarioLista usuarioLista = new UsuarioLista();
                acessoDadosSqlServer.LimparParametros();
                //(DIEGO) acessoDadosSqlServer.AdicionarParametro("@INNome", strNome);
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", strNome));

                // using (DataTable dataTable = acessoDadosSqlServer.ExecutarScalar(CommandType.StoredProcedure, "uspConsultarCliente")) 
                using (DataTable dataTable = acessoDadosSqlServer.GetDataTable("uspConsultarUsuario", CommandType.StoredProcedure))
                {

                    foreach (DataRow linha in dataTable.Rows)
                    {
                        Usuario usuario = new Usuario();

                        usuario.IDUsuario = Convert.ToInt32(linha["IDUsuario"]);
                        usuario.Nome = linha["Nome"].ToString();
                        usuario.Senha = linha["Senha"].ToString();
                        usuario.Telefone = linha["Telefone"].ToString();
                        usuario.Email = linha["Email"].ToString();
                        usuario.Cpf = Convert.ToString(linha["Cpf"]);
                        usuario.Status = Convert.ToChar(linha["Status"]);
                        usuario.Rg = linha["Rg"].ToString();
                        usuario.Endereco = Convert.ToString(linha["Endereco"]);
                        usuario.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                        usuario.Cidade = Convert.ToString(linha["Cidade"]);
                        usuario.Uf = Convert.ToString(linha["Uf"]);



                        usuarioLista.Add(usuario);
                    }
                }
                return usuarioLista;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao Consultar Usuário. Motivo: " + ex.Message);
            }



        }

        public string Alterar(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDUsuario", usuario.IDUsuario));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", usuario.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INSenha", usuario.Senha));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", usuario.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", usuario.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", usuario.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", usuario.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", usuario.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRg", usuario.Rg));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", usuario.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", usuario.Uf));

                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspAlterarUsuario", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Usuario. Motivo: " + ex.Message);
            }
        }
        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INIDUsuario", usuario.IDUsuario));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INNome", usuario.Nome));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INSenha", usuario.Senha));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INTelefone", usuario.Telefone));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEmail", usuario.Email));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCpf", usuario.Cpf));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INStatus", usuario.Status));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INEndereco", usuario.Endereco));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INRg", usuario.Rg));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INCidade", usuario.Cidade));
                acessoDadosSqlServer.AdicionarParametro(new SqlParameter("@INUf", usuario.Uf));

                string codProduto = acessoDadosSqlServer.ExecutarScalar("uspInativarUsuario", CommandType.StoredProcedure).ToString();

                return codProduto;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir Usuario. Motivo: " + ex.Message);
            }


        }

    }

}





