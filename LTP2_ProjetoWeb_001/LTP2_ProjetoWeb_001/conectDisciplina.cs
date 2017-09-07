using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ProjetoWeb_001
{
    public class conectDisciplina
    {
        //Propriedade de dados da Disciplina
        public int ID_Disciplina { get; set; }
        public string Codigo_Disciplina { get; set; }
        public string Nome_Disciplina { get; set; }
        public string Ementa_Disciplina { get; set; }
        public string Semestre_Disciplina { get; set; }
        public string CargaHoraria_Disciplina { get; set; }

        public MySqlConnection connection;
        public string Erro;

        public conectDisciplina()
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

        public void InserirDisciplina()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "INSERT INTO disciplina (Codigo_Disciplina, Nome_Disciplina, Ementa_Disciplina, Semestre_Disciplina, CargaHoraria_Disciplina) VALUES(";
            query = query + "'" + Codigo_Disciplina + "',"
                          + "'" + Nome_Disciplina + "',"
                          + "'" + Ementa_Disciplina + "',"
                          + "'" + Semestre_Disciplina + "',"
                          + "'" + CargaHoraria_Disciplina + "')";

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

        public List<conectDisciplina> visualizarDisciplinas()
        {
            List<conectDisciplina> L = new List<conectDisciplina>();

            string query = "SELECT * FROM disciplina";

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
                        conectDisciplina disciplina = new conectDisciplina();
                        disciplina.ID_Disciplina = Convert.ToInt32(dataReader["ID_Disciplina"].ToString());
                        disciplina.Codigo_Disciplina = dataReader["Codigo_Disciplina"].ToString();
                        disciplina.Nome_Disciplina = dataReader["Nome_Disciplina"].ToString();
                        disciplina.Ementa_Disciplina = dataReader["Ementa_Disciplina"].ToString();
                        disciplina.Semestre_Disciplina = dataReader["Semestre_Disciplina"].ToString();
                        disciplina.CargaHoraria_Disciplina = dataReader["CargaHoraria_Disciplina"].ToString();

                        L.Add(disciplina);
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

        public conectDisciplina retornarItem(int id)
        {

            string query = "SELECT * FROM disciplina WHERE ID_DISCIPLINA = " + id;
            conectDisciplina D = new conectDisciplina();

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
                        D.ID_Disciplina = Convert.ToInt32(dataReader["ID_Disciplina"].ToString());
                        D.Codigo_Disciplina = dataReader["Codigo_Disciplina"].ToString();
                        D.Nome_Disciplina = dataReader["Nome_Disciplina"].ToString();
                        D.Ementa_Disciplina = dataReader["Ementa_Disciplina"].ToString();
                        D.Semestre_Disciplina = dataReader["Semestre_Disciplina"].ToString();
                        D.CargaHoraria_Disciplina = dataReader["CargaHoraria_Disciplina"].ToString();
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
                D = null;
            }

            return D;
        }

        public void alterarItem()
        {
            abrirConexao(); //Abrindo a conexão

            //String que armazena a consulta que será realizada
            string query = "UPDATE disciplina SET ";
            query = query + "Codigo_Disciplina='" + Codigo_Disciplina + "',"
                          + "Nome_Disciplina='" + Nome_Disciplina + "',"
                          + "Ementa_Disciplina='" + Ementa_Disciplina + "',"
                          + "Semestre_Disciplina='" + Semestre_Disciplina + "',"
                          + "CargaHoraria_Disciplina='" + CargaHoraria_Disciplina + "' "
                          + "WHERE ID_Disciplina=" + ID_Disciplina;

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
            string query = "DELETE FROM disciplina "
                          + "WHERE ID_Disciplina=" + ID_Disciplina;

            //Cria o comando associado à conexão
            MySqlCommand comando = new MySqlCommand(query, connection);

            //Executa o comando na base de dados
            comando.ExecuteNonQuery();

            fecharConexao();
        }

    }
}