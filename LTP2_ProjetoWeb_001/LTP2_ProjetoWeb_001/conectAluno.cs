using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ProjetoWeb_001
{
    public class conectAluno
    {
        //Propriedade de dados do Aluno
        public int ID_Aluno { get; set; }
        public string RA_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public string CPF_Aluno { get; set; }
        public string Sexo_Aluno { get; set; }
        public string Ingresso_Aluno { get; set; }

        public MySqlConnection connection;
        public string Erro;

        public conectAluno()
        {

        }

        public void configurarConexao()
        {
            string StringConexao = "SERVER=localhost;" +
                                   "DATABASE=ltp2_2017;" +
                                   "UID=root;" +
                                   "PASSWORD=unilago";

            connection = new MySqlConnection(StringConexao);
        }

        public void abrirConexao()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
        }

        public void fecharConexao()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
        }

        public void InserirAluno()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "INSERT INTO aluno (RA_Aluno, Nome_Aluno, CPF_Aluno, Sexo_Aluno, Ingresso_Aluno) VALUES(";
            query = query + "'" + RA_Aluno + "',"
                          + "'" + Nome_Aluno + "',"
                          + "'" + CPF_Aluno + "',"
                          + "'" + Sexo_Aluno + "',"
                          + "'" + Ingresso_Aluno + "')";

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

        public List<conectAluno> visualizarAlunos()
        {
            List<conectAluno> L = new List<conectAluno>();

            string query = "SELECT * FROM aluno";

            try
            {
                abrirConexao();

                //Cria o comando associado à conexão
                MySqlCommand comando = new MySqlCommand(query, connection);

                //Cria e preenche com dados uma estrutura de reader com o retorno do select do sql
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        conectAluno aluno = new conectAluno();
                        aluno.ID_Aluno = Convert.ToInt32(dataReader["ID_Aluno"].ToString());
                        aluno.RA_Aluno = dataReader["RA_Aluno"].ToString();
                        aluno.Nome_Aluno = dataReader["Nome_Aluno"].ToString();
                        aluno.CPF_Aluno = dataReader["CPF_Aluno"].ToString();
                        aluno.Sexo_Aluno = dataReader["Sexo_Aluno"].ToString();
                        aluno.Ingresso_Aluno = dataReader["Ingresso_Aluno"].ToString();

                        L.Add(aluno);
                    }
                }
                else
                {
                    throw new Exception("Não trouxe resultados.");
                }

                //fechando a estrutura dataReader
                dataReader.Close();

                fecharConexao();

            }
            catch (MySqlException ex)
            {
                Erro = "Erro ao buscar usuarios: " + ex.Message;
                L = null;
            }

            return L;
        }

        public conectAluno retornarItem(int id)
        {

            string query = "SELECT * FROM aluno WHERE ID_ALUNO = " + id;
            conectAluno A = new conectAluno();

            try
            {
                abrirConexao();

                //Cria o comando associado à conexão
                MySqlCommand comando = new MySqlCommand(query, connection);

                //Cria e preenche com dados uma estrutura de reader com o retorno do select do sql
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        A.ID_Aluno = Convert.ToInt32(dataReader["ID_Aluno"].ToString());
                        A.RA_Aluno = dataReader["RA_Aluno"].ToString();
                        A.Nome_Aluno = dataReader["Nome_Aluno"].ToString();
                        A.CPF_Aluno = dataReader["CPF_Aluno"].ToString();
                        A.Sexo_Aluno = dataReader["Sexo_Aluno"].ToString();
                        A.Ingresso_Aluno = dataReader["Ingresso_Aluno"].ToString();
                    }
                }
                else
                {
                    throw new Exception("Não trouxe resultados.");
                }

                //fechando a estrutura dataReader
                dataReader.Close();

                fecharConexao();

            }
            catch (MySqlException ex)
            {
                Erro = "Erro ao buscar usuarios: " + ex.Message;
                A = null;
            }

            return A;
        }

        public void alterarItem()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "UPDATE aluno SET ";
            query = query + "RA_Aluno='" + RA_Aluno + "',"
                          + "Nome_Aluno='" + Nome_Aluno + "',"
                          + "CPF_Aluno='" + CPF_Aluno + "',"
                          + "Sexo_Aluno='" + Sexo_Aluno + "',"
                          + "Ingresso_Aluno='" + Ingresso_Aluno + "' "
                          + "WHERE ID_Aluno=" + ID_Aluno;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

        public void excluirItem()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "DELETE FROM aluno "
                          + "WHERE ID_Aluno=" + ID_Aluno;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

    }
}