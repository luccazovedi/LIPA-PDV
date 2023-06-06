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
        public static string caminhoConexao = "server=localhost;User Id=root;database=LIPA3;password=root";
        public static MySqlConnection conexao = new MySqlConnection(caminhoConexao);
        public static DataContext acesso = new DataContext(MySQL.conexao);

        #region Padrão
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
        #endregion

        #region Usuário
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
                //MessageBox.Show("[SISTEMA] Ocorreu um erro! Tente novamente.", "[LAMBDA] Criar Tabela Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("[SISTEMA] Usuário inserido com sucesso!", "[LAMBDA] Salvar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Salvar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        #region Cliente
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
                //MessageBox.Show("[SISTEMA] Ocorreu um erro! Tente novamente.", "[LAMBDA] Criar Tabela Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("[SISTEMA] Cliente inserido com sucesso!", "[LAMBDA] Salvar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Salvar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void RemoverTabelaCliente(int id)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM Cliente WHERE Id = '" + id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Cliente excluído com sucesso!", "[LAMBDA] Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void EditarTabelaCliente(string nome, string cpf, string rg, string cidade, string estado, bool situacao, int id)
        {
            try
            {
                conexao.Open();

                string consulta = "UPDATE cliente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Cidade = @cidade, Estado = @estado, Situacao = @situacao WHERE Id = @Id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Cpf", cpf);
                    comando.Parameters.AddWithValue("@Rg", rg);
                    comando.Parameters.AddWithValue("@Cidade", cidade);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Situacao", situacao ? 0 : 1);
                    comando.Parameters.AddWithValue("@Id", id);

                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }

                MessageBox.Show("[SISTEMA] Cliente editado com sucesso!", "[LAMBDA] Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static string ConsultarTabelaCliente(string conteudoConsulta, string tipoConsulta)
        {
            string consulta = "";

            if (conteudoConsulta != "")
            {
                switch (tipoConsulta)
                {
                    case "NOME":
                        consulta = "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM Cliente WHERE NOME LIKE '" + conteudoConsulta + "%'";
                        break;
                    case "CIDADE":
                        consulta = "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM Cliente WHERE CIDADE = '" + conteudoConsulta + "'";
                        break;
                    case "ESTADO":
                        consulta = "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM Cliente WHERE ESTADO = '" + conteudoConsulta + "'";
                        break;
                }
            }

            return consulta;
        }

        public static string ExibirTabelaCliente()
        {
            return "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM Cliente";
        }
        #endregion

        #region Outros
        public static object ChecarEditarCPF(int id)
        {
            var consulta = "SELECT Cpf FROM Cliente WHERE Id = " + id;

            MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao);
            object cpfCliente = comando.ExecuteScalar();
            return cpfCliente;
        }
        #endregion
    }
}
