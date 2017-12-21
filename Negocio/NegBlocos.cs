using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using System.Data.SqlClient;
using ObjetoTransferencia;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System;


namespace Negocio
{
    public class NegBlocos
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        [DataObjectMethodAttribute(DataObjectMethodType.Insert)]
        public string Cadastrar(Blocos blocos)
        {
            try
            {
                acessoDados.LimparParametros();
                // acessoDados.AdicionarParametro(new SqlParameter("@INIDProduto", blocos.Produto.IDProduto));
                acessoDados.AdicionarParametro(new SqlParameter("@INBloco", blocos.Bloco));
                acessoDados.AdicionarParametro(new SqlParameter("@INQuantidade", blocos.Quantidade));
                acessoDados.AdicionarParametro(new SqlParameter("@INDescricao", blocos.Descricao));


                string IDCarregamentoBloco = acessoDados.ExecutarScalar("uspCadastrarBlocos", CommandType.StoredProcedure).ToString();

                return IDCarregamentoBloco;

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Cadastrar Bloco. Motivo: " + ex.Message);
            }

        }

        [DataObjectMethodAttribute(DataObjectMethodType.Update)]
        public string Alterar(Blocos blocos)
        {
            try
            {

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametro(new SqlParameter("@INBloco", blocos.Bloco));
                acessoDados.AdicionarParametro(new SqlParameter("@INQuantidade", blocos.Quantidade));
                acessoDados.AdicionarParametro(new SqlParameter("@INDescricao", blocos.Descricao));

                string IDCarregamentoBloco = acessoDados.ExecutarScalar("uspAlterarBlocos", CommandType.StoredProcedure).ToString();

                return IDCarregamentoBloco;
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao alterar Bloco. Motivo: " + ex.Message);
            }
        }

        [DataObjectMethodAttribute(DataObjectMethodType.Delete)]
        public string Excluir(Blocos blocos)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametro(new SqlParameter("@INIDCarregamentoBloco", blocos.IDCarregamentoBloco));

                string IDVenda = acessoDados.ExecutarScalar("uspExcluirVendaItem", CommandType.StoredProcedure).ToString();

                return IDVenda;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir VendaItem. Motivo: " + ex.Message);
            }
        }
    }
}