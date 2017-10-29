using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using AcessoDados.Properties.Settings;
using System.Data.SqlClient;
using AcessoDados.Properties;



namespace AcessoDados
{
    public class AcessoDadosSqlServer
    {
        //Lista de parâmetros que serão enviados junto ao comando SQL.
        private SqlParameterCollection objListaParametros = null;

        //Construtor da classe
        //O construtor é utilizado quando é realizada a instância de um objeto,
        //neste caso new AcessoDadosSqlServer.
        public AcessoDadosSqlServer()
        {
            //Iniciando o objeto objListaParametros que estava nulo.
            objListaParametros = new SqlCommand().Parameters;
        }

        //Método responsável por estabelecer uma conexão com o SQL Server.
        private SqlConnection ObterConexao()
        {
            try
            {
                //String de conexão com o BD. (Local BD, Usuário, Senha)
                string strConexaoBanco = Settings.Default.strConexao;
                //Tenta estabelecer a conexão com o BD utilizando os dados
                //da string de conexão informada.
                return new SqlConnection(strConexaoBanco);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao obter conexão com o BD. Falha: " +
                    ex.Message);
            }
        }

        public void AdicionarParametro(SqlParameter objParametro)
        {
            try
            {
                //Adiciona um elemento (parâmetro) a lista (conjunto) de parâmetros.
                objListaParametros.Add(objParametro);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao adicionar parâmetro. Falha: " +
                    ex.Message);
            }
        }

        public void LimparParametros()
        {
            try
            {
                //Limpa a lista de parâmetros. Deixa a lista vazia.
                objListaParametros.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao limpar parâmetros. Falha: " +
                    ex.Message);
            }
        }
        //Vincula ao comando que será executado no BD os parâmetros informados na
        //regra de negócios da aplicação.
        private void SetarParametros(SqlCommand objComando)
        {
            try
            {
                //Limpa os parâmetros contidos no comando SQL.
                objComando.Parameters.Clear();
                //Percorre todos os parâmetros contidos no objListaParametros
                //(valores vindos da regra de negócios) e os adiciona ao 
                //comando que será executado no BD.
                foreach (SqlParameter objParametro in objListaParametros)
                {
                    objComando.Parameters.Add(
                        new SqlParameter(objParametro.ParameterName,
                                         objParametro.Value)
                                         );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao adicionar parâmetros ao comando SQL."
                    + " Falha: " + ex.Message);
            }
        }

        public object ExecutarScalar(string strComando, CommandType cmdType)
        {
            try
            {
                //Na linha abaixo esta sendo obtida uma conexão com o BD.
                using (SqlConnection objConexao = ObterConexao())
                {
                    //Abre a conexão (cria o meio de comunicação)
                    objConexao.Open();
                    //Cria um novo comando (insert, update, delete) e o adiciona
                    //a conexão estabelecida.
                    SqlCommand objComando = objConexao.CreateCommand();
                    //Informa o comando a ser executado (insert into tblCliente...)
                    objComando.CommandText = strComando;
                    //Indica qual é o tipo d comando (Text, Proceudre, etc).
                    objComando.CommandType = cmdType;
                    //Indica qual é o tempo limite para execução do comando.
                    objComando.CommandTimeout = 7200;
                    //Adiciona os parâmetros ao comando (os dados da tela)
                    SetarParametros(objComando);
                    //Envia o comando ao Sql.
                    return objComando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao executar comando no BD. Falha: " +
                    ex.Message);
            }
        }

        public DataTable GetDataTable(string strComando, CommandType cmdType)
        {
            try
            {
                //Na linha abaixo esta sendo obtida uma conexão com o BD.
                using (SqlConnection objConexao = ObterConexao())
                {
                    //Abre a conexão (cria o meio de comunicação)
                    objConexao.Open();
                    //Cria um novo comando (select) e o adiciona
                    //a conexão estabelecida.
                    SqlCommand objComando = objConexao.CreateCommand();
                    //Informa o comando a ser executado (select * from tblCliente)
                    objComando.CommandText = strComando;
                    //Indica qual é o tipo d comando (Text, Proceudre, etc).
                    objComando.CommandType = cmdType;
                    //Indica qual é o tempo limite para execução do comando.
                    objComando.CommandTimeout = 7200;
                    //Adiciona os parâmetros ao comando (os dados da tela)
                    SetarParametros(objComando);
                    //Prepara a consulta a ser executada no banco de dados.
                    SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objComando);
                    //DataSet é um conjunto de tabelas (retornos - select).
                    DataSet dtsTabelas = new DataSet();
                    //Executa a consulta e adiciona seu resultado no conjunto de
                    //tabelas.
                    objSqlDataAdapter.Fill(dtsTabelas);
                    //Retorno a primeira tabela contida no conjunto.
                    return dtsTabelas.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao executar consulta no BD. Falha: " +
                    ex.Message);
            }
        }

    }
}