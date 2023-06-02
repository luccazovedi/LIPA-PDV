using LIPA3.Telas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIPA3.Classes
{
    internal class MySQL
    {
        // Altere a variável "caminhoConexao" com as informações do seu banco de dados local.
        private static string caminhoConexao = "server=localhost;User Id=root;database=LIPA3;password=root";
        public static MySqlConnection conexao = new MySqlConnection(caminhoConexao);
        public static DataContext acesso = new DataContext(MySQL.conexao);

        public static void Conectar()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception)
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        public static void CriarTabelaUsuario()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE Usuario (Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                    "Nome VARCHAR(255), Usuario VARCHAR(255), Tipo VARCHAR(255), Senha VARCHAR(255), Situacao INT);";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception)
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        public static void InserirTabelaUsuario(string nome, string usuario, string tipo, string senha, int situacao)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO Usuario (nome, usuario, tipo, senha, situacao) " +
                    "VALUES ('" + nome + "', '" + usuario + "', '" + tipo + "', '" + senha + "', '" + situacao + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Usuário inserido com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void CriarTabelaCliente()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE Cliente (Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                    "Nome VARCHAR(255), Situacao INT, Cpf VARCHAR(255), Rg VARCHAR(255), Genero CHAR(1)," +
                    "DataNascimento VARCHAR(255), EstadoCivil VARCHAR(255), Profissao VARCHAR(255), Nacionalidade VARCHAR(255)," +
                    "Telefone VARCHAR(255), Celular VARCHAR(255), WhatsApp INT, Email VARCHAR(255), Endereco VARCHAR(255)," +
                    "Numero VARCHAR(255), Complemento VARCHAR(255), Bairro VARCHAR(255), Cidade VARCHAR(255), Estado CHAR(2)," +
                    "Cep VARCHAR(255), Observacoes VARCHAR(255), DataCadastro VARCHAR(255));";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception)
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        public static void InserirTabelaCliente(string nome, int situacao, string cpf, string rg, char genero, 
            string dataNascimento, string estadoCivil, string profissao, string nacionalidade, string telefone, string celular, 
            int whatsApp, string email, string endereco, string numero, string complemento, string bairro, string cidade, 
            string estado, string cep, string observacoes)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO Cliente (nome, situacao, cpf, rg, genero, dataNascimento, estadoCivil, " +
                    "profissao, nacionalidade, telefone, celular, whatsApp, email, endereco, numero, complemento, bairro, " +
                    "cidade, estado, cep, observacoes, dataCadastro) " +
                    "VALUES ('" + nome + "', '" + situacao + "', '" + cpf + "', '" + rg + "', '" + genero + "', " +
                    "'" + dataNascimento + "', '" + estadoCivil + "', '" + profissao + "', '" + nacionalidade + "', '" + telefone + "', " +
                    "'" + celular + "', '" + whatsApp + "', '" + email + "', '" + endereco + "', '" + numero + "', " +
                    "'" + complemento + "', '" + bairro + "', '" + cidade + "', '" + estado + "', '" + cep + "', " +
                    "'" + observacoes + "', '" + DateTime.Now.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Cliente inserido com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
