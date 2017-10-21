using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcessoDados.Properties;

namespace AcessoDados
{
    public class AcessoSqlServer
    {
        //criar conexao
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.strConexao);
        }

        //paramentros que vao para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }


        public void AdicionarParamentros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }


        //persistencia inserir, alterar, deletar
        public object ExecutarManipulacao(CommandType commandType, string comandoSql)
        {
            try
            {
                //criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar comando que vai para o banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = comandoSql;
                sqlCommand.CommandTimeout = 3600;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //consulta
        public DataTable ExecutarConsulta(CommandType commandType, string comandoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = comandoSql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //criar adptador para o dados da tabela
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //crirar a tabela de dados para guardar as informacoes do banco
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    

    }

}
