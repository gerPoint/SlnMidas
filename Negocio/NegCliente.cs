
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using AcessoDados;
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
                acessoDados.AdicionarParametro(new SqlParameter("@INNome", cliente.Nome));
                acessoDados.AdicionarParametro(new SqlParameter("@INRazaoSocial", cliente.RazaoSocial));
                acessoDados.AdicionarParametro(new SqlParameter("@INTelefone", cliente.Telefone));
                acessoDados.AdicionarParametro(new SqlParameter("@INEmail", cliente.Email));
                acessoDados.AdicionarParametro(new SqlParameter("@INCidade", cliente.Cidade));
                acessoDados.AdicionarParametro(new SqlParameter("@INEndereco", cliente.Endereco));
                acessoDados.AdicionarParametro(new SqlParameter("@INCpf", cliente.Cpf));
                acessoDados.AdicionarParametro(new SqlParameter("@INCnpj", cliente.Cnpj));
                acessoDados.AdicionarParametro(new SqlParameter("@INUf", cliente.Uf));
                acessoDados.AdicionarParametro(new SqlParameter("@INStatus", cliente.Status));



                string IDCliente = acessoDados.ExecutarScalar("uspCadastrarCliente", CommandType.StoredProcedure).ToString();
                return IDCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Cliente. Motivo: " + ex.Message);
            }


        }

    }

}