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
    public class NegCarregamentoBloco
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(objCarregamentoBloco blocos)
        {
            try
            {
                acessoDados.LimparParametros();
                // acessoDados.AdicionarParametro(new SqlParameter("@INIDProduto", blocos.Produto.IDProduto));
                acessoDados.AdicionarParametro(new SqlParameter("@INBloco", blocos.Bloco));
                acessoDados.AdicionarParametro(new SqlParameter("@INQuantidade", blocos.Quantidade));
                acessoDados.AdicionarParametro(new SqlParameter("@INDescricao", blocos.Descricao));
                acessoDados.AdicionarParametro(new SqlParameter("@INIDRomaneio", blocos.IDRomaneio));


                string IDCarregamentoBloco = acessoDados.ExecutarScalar("uspCadastrarBlocos", CommandType.StoredProcedure).ToString();

                return IDCarregamentoBloco;

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Bloco. Motivo: " + ex.Message);
            }

        }

      
    }
}