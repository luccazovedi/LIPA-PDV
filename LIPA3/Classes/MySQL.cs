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

                string consulta = "UPDATE Cliente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Cidade = @cidade, Estado = @estado, Situacao = @situacao WHERE Id = @Id";

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

        #region Produto
        public static void CriarTabelaProduto()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE Produto (Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                    "Descricao VARCHAR(255), CodigoBarras VARCHAR(255), Marca VARCHAR(255), Peso NUMERIC(18, 2), Largura NUMERIC(18, 2), " +
                    "Altura NUMERIC(18, 2), Profundidade NUMERIC(18, 2), Situacao INT, Condicao VARCHAR(255), PrecoVenda NUMERIC(18, 2), " +
                    "QuantidadeEstoque NUMERIC(18, 2), DataCadastro VARCHAR(255));";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("[SISTEMA] Ocorreu um erro! Tente novamente.", "[LAMBDA] Criar Tabela Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void InserirTabelaProduto(string descricao, string codigoBarras, string marca, double peso, double largura, double altura,
            double profundidade, int situacao, string condicao, double precoVenda, double quantidadeEstoque)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO Produto (descricao, codigoBarras, marca, peso, largura, altura, profundidade, " +
                    "situacao, condicao, precoVenda, quantidadeEstoque, dataCadastro)" +
                    "VALUES ('" + descricao + "', '" + codigoBarras + "', '" + marca + "', '" + peso + "', " +
                    "'" + largura + "', '" + altura + "', '" + profundidade + "', '" + situacao + "', '" + condicao + "', " +
                    "'" + precoVenda + "', '" + quantidadeEstoque + "', '" + DateTime.Now.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Produto inserido com sucesso!", "[LAMBDA] Salvar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Salvar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void RemoverTabelaProduto(int id)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM Produto WHERE Id = '" + id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Produto excluído com sucesso!", "[LAMBDA] Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static string ConsultarTabelaProduto(string conteudoConsulta, string tipoConsulta)
        {
            string consulta = "SELECT Id, Descricao, Marca, PrecoVenda, QuantidadeEstoque, Condicao FROM Produto WHERE " + tipoConsulta + " LIKE '" + conteudoConsulta + "%'";

            /*if (conteudoConsulta != "")
            {
                switch (tipoConsulta)
                {
                    case "DESCRICAO":
                        consulta = "SELECT Id, Descricao, Marca, PrecoVenda, QuantidadeEstoque, Condicao FROM Produto WHERE DESCRICAO LIKE '" + conteudoConsulta + "%'";
                        break;
                    case "MARCA":
                        consulta = "SELECT Id, Descricao, Marca, PrecoVenda, QuantidadeEstoque, Condicao FROM Produto WHERE MARCA LIKE '" + conteudoConsulta + "%'";
                        break;
                    case "CONDICAO":
                        consulta = "SELECT Id, Descricao, Marca, PrecoVenda, QuantidadeEstoque, Condicao FROM Produto WHERE CONDICAO LIKE '" + conteudoConsulta + "%'";
                        break;
                }
            }*/

            return consulta;
        }

        public static string ExibirTabelaProduto()
        {
            return "SELECT Id, Descricao, Marca, PrecoVenda, QuantidadeEstoque, Condicao, Situacao FROM Produto";
        }
        #endregion

        #region Venda
        public static void CriarTabelaVenda()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE Venda (Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                    "DataVenda VARCHAR(255), ClienteId INT, UsuarioId INT, TotalItens INT, SubTotal NUMERIC(18, 2), " +
                    "Desconto NUMERIC(18, 2), ValorTotal NUMERIC(18, 2), FormaPagamento VARCHAR(255), Situacao VARCHAR(255), " +
                    "Observacoes VARCHAR(255), FOREIGN KEY (ClienteId) REFERENCES Cliente(Id), FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id));";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("[SISTEMA] Ocorreu um erro! Tente novamente.", "[LAMBDA] Criar Tabela Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void InserirTabelaVenda(int clienteId, int usuarioId, int totalItens, double subTotal, double desconto, double valorTotal, 
            string formaPagamento, string situacao, string observacoes)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO Venda (DataVenda, ClienteId, UsuarioId, TotalItens, SubTotal, Desconto, ValorTotal, " +
                    "FormaPagamento, Situacao, Observacoes)" +
                    "VALUES ('" + DateTime.Now.ToString() + "','" + clienteId + "', '" + usuarioId + "', '" + totalItens + "', '" + subTotal + "', " +
                    "'" + desconto + "', '" + valorTotal + "', '" + formaPagamento + "', '" + situacao + "', '" + observacoes + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Venda inserida com sucesso!", "[LAMBDA] Salvar Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Salvar Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void RemoverTabelaVenda(int id)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM Venda WHERE Id = '" + id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();

                MessageBox.Show("[SISTEMA] Venda excluída com sucesso!", "[LAMBDA] Excluir Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Excluir Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static string ExibirTabelaVenda()
        {
            return "SELECT Id, DataVenda, ClienteId, UsuarioId, ValorTotal FROM Venda";
        }
        #endregion

        #region VendaItens
        public static void CriarTabelaVendaItens()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE VendaItens (Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                    "VendaId INT, ProdutoId INT, Quantidade INT, Descricao VARCHAR(255), ValorUnitario NUMERIC(18, 2), SubTotalProduto NUMERIC(18, 2), " +
                    "FOREIGN KEY (VendaId) REFERENCES Venda(Id), FOREIGN KEY (ProdutoId) REFERENCES Produto(Id));"; ;
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("[SISTEMA] Ocorreu um erro! Tente novamente.", "[LAMBDA] Criar Tabela Venda Itens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void InserirTabelaVendaItens(int vendaId, int produtoId, int quantidade, string descricao, double valorUnitario, double subTotalProduto)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO VendaItens (VendaId, ProdutoId, Quantidade, Descricao, ValorUnitario, SubTotalProduto)" +
                    "VALUES ('" + vendaId + "','" + produtoId + "', '" + quantidade + "', '" + descricao + "', '" + valorUnitario + "', " +
                    "'" + subTotalProduto + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();

                //MessageBox.Show("[SISTEMA] Item adicionado com sucesso!", "[LAMBDA] Adicionar Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Adicionar Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void RemoverTabelaVendaItens(int id)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM VendaItens WHERE Id = '" + id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();

                //MessageBox.Show("[SISTEMA] Item removido com sucesso!", "[LAMBDA] Remover Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Remover Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static string ExibirTabelaVendaItens(int vendaId)
        {
            return "SELECT Id, ProdutoId, Descricao, Quantidade, ValorUnitario, SubTotalProduto FROM VendaItens WHERE VendaId = " + vendaId;
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
