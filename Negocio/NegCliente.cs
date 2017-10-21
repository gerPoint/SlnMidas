
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using AcessoDados;
using ObjTransferencia;
using System;


namespace Negocio
{
    public class NegCliente
    {
        AcessoSqlServer acessoDados = new AcessoSqlServer();


        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(objCliente cliente)
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

    }

}