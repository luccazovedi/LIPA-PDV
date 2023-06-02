using LIPA3.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIPA3.Telas
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }
        
        private void Salvar()
        {
            char genero;
            if (generoCmb.SelectedIndex == 0)
            {
                genero = 'M';
            }
            else if (generoCmb.SelectedIndex == 1)
            {
                genero = 'F';
            }
            else
            {
                genero = 'O';
            }

            int whatsApp;
            if (whatsAppChk.Checked)
            {
                whatsApp = 1;
            }
            else
            {
                whatsApp = 0;
            }

            MySQL.InserirTabelaCliente(nomeTxt.Text, 0, cpfTxt.Text, rgTxt.Text, genero, dataNascimentoTxt.Text, 
                estadoCivilCmb.SelectedText, profissaoTxt.Text, nacionalidadeTxt.Text, telefoneTxt.Text, 
                celularTxt.Text, whatsApp, emailTxt.Text, enderecoTxt.Text, numeroTxt.Text, complementoTxt.Text, 
                bairroTxt.Text, cidadeTxt.Text, estadoTxt.Text, cepTxt.Text, observacoesTxt.Text);

            Limpar();
        }

        private void Limpar()
        {
            nomeTxt.Text = "";
            situacaoChk.Checked = false;
            cpfTxt.Text = "";
            rgTxt.Text = "";
            generoCmb.SelectedIndex = -1;
            dataNascimentoTxt.Text = "";
            estadoCivilCmb.SelectedIndex = -1;
            profissaoTxt.Text = "";
            nacionalidadeTxt.Text = "";
            telefoneTxt.Text = "";
            celularTxt.Text = "";
            whatsAppChk.Checked = false;
            emailTxt.Text = "";
            enderecoTxt.Text = "";
            numeroTxt.Text = "";
            complementoTxt.Text = "";
            bairroTxt.Text = "";
            cidadeTxt.Text = "";
            estadoTxt.Text = "";
            estadoTxt.Text = "";
            cepTxt.Text = "";
            observacoesTxt.Text = "";
            nomeTxt.Focus();
        }

        private bool VerificaCPFExistente(string cpf)
        {
            string conecta = "server=localhost;User Id=root;database=LIPA3;password=root";
            using (MySqlConnection conexao = new MySqlConnection(conecta))
            {
                conexao.Open();
                string query = "SELECT * FROM cliente WHERE Cpf = @cpf";

                using (MySqlCommand command = new MySqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        
        }

        private bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", ""); // Remove pontos e traço, se existirem

            if (cpf.Length != 11) // Verifica se o CPF tem 11 caracteres
                return false;

            if (!cpf.All(char.IsDigit)) // Verifica se todos os caracteres são dígitos
                return false;

            // Verifica se todos os dígitos são iguais, o que tornaria o CPF inválido
            bool todosDigitosIguais = cpf.Distinct().Count() == 1;
            if (todosDigitosIguais)
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            // Verifica se o primeiro dígito verificador está correto
            if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador)
                return false;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            // Verifica se o segundo dígito verificador está correto
            if (int.Parse(cpf[10].ToString()) != segundoDigitoVerificador)
                return false;

            return true; // CPF válido
        }


        private void salvarBtn_Click(object sender, EventArgs e)
        {
            bool cpfValido = ValidarCPF(cpfTxt.Text);
            bool cpdExistente = VerificaCPFExistente(cpfTxt.Text);
            if (cpfValido && !cpdExistente)
            {

                Salvar();
            }
            else
            {
                MessageBox.Show("cpf invalido ou ja existente");
            }
            
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                clienteDataGrid.DataSource = null;
                clienteDataGrid.Rows.Clear();
                string query;
                conexao.Open();
                if (situacaoChk.Checked)
                {
                     query = "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM cliente WHERE Situacao=1";
                }
                else
                {
                     query = "SELECT Id, Nome, Cpf, Rg, Cidade, Estado FROM cliente WHERE Situacao=0";
                }
                using (MySqlCommand command = new MySqlCommand(query, conexao))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    // Preenche o DataGridView com os dados do MySqlDataReader
                    while (reader.Read())
                    {
                        int rowIndex = clienteDataGrid.Rows.Add();


                        // Preenche as células da linha com os dados do MySqlDataReader
                        clienteDataGrid.Rows[rowIndex].Cells["ID"].Value = reader["Id"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["NOME"].Value = reader["Nome"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["CPF"].Value = reader["Cpf"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["RG"].Value = reader["Rg"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["CIDADE"].Value = reader["Cidade"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["ESTADO"].Value = reader["Estado"].ToString();
                    }
                }
                conexao.Dispose();
            }


        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = MySQL.conexao)
            {
                conexao.Open();
                int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);
                bool inativo = situacaoChk.Checked;
                string query = "UPDATE cliente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Cidade = @cidade, Estado = @estado, Profissao = @profissao, Nacionalidade = @nacionalidade, Telefone = @telefone, Celular = @celular, Email = @email, Bairro = @bairro, Cep = @Cep, Observacoes = @observacoes, Endereco = @endereco, Numero = @numero, Complemento = @Complemento, Situacao = @situacao WHERE Id = @Id";
                using (MySqlCommand command = new MySqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Nome", nomeTxt.Text);
                    command.Parameters.AddWithValue("@Cpf", cpfTxt.Text);
                    command.Parameters.AddWithValue("@Rg", rgTxt.Text);
                    command.Parameters.AddWithValue("@Cidade", cidadeTxt.Text);
                    command.Parameters.AddWithValue("@Estado", estadoTxt.Text);
                    command.Parameters.AddWithValue("@Profissao", profissaoTxt.Text);
                    command.Parameters.AddWithValue("@Nacionalidade", nacionalidadeTxt.Text);
                    command.Parameters.AddWithValue("@Telefone", telefoneTxt.Text);
                    command.Parameters.AddWithValue("@Celular", celularTxt.Text);
                    command.Parameters.AddWithValue("@Email", emailTxt.Text);
                    command.Parameters.AddWithValue("@Bairro", bairroTxt.Text);
                    command.Parameters.AddWithValue("@Cep", cepTxt.Text);
                    command.Parameters.AddWithValue("@Observacoes", observacoesTxt.Text);
                    command.Parameters.AddWithValue("@Endereco", enderecoTxt.Text);
                    command.Parameters.AddWithValue("@Numero", numeroTxt.Text);
                    command.Parameters.AddWithValue("@Complemento", complementoTxt.Text);
                    command.Parameters.AddWithValue("@Situacao", inativo);
                    command.Parameters.AddWithValue("@Id", id);
                    
                    command.ExecuteNonQuery();                  
                }
                conexao.Dispose();
                clienteDataGrid.DataSource = null;
                clienteDataGrid.Rows.Clear();
                btnConsultar_Click(sender, e);
                Limpar();
                
               
            }
           
        }

        private void clienteDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                conexao.Open();

                if (clienteDataGrid.SelectedRows.Count > 0)
                {
                    string query = "SELECT * FROM cliente WHERE Cpf= @Cpf";

                    DataGridViewRow selectedRow = clienteDataGrid.SelectedRows[0];
                    nomeTxt.Text = selectedRow.Cells["Nome"].Value.ToString();
                    cpfTxt.Text = selectedRow.Cells["Cpf"].Value.ToString();
                    rgTxt.Text = selectedRow.Cells["Rg"].Value.ToString();
                    cidadeTxt.Text = selectedRow.Cells["Cidade"].Value.ToString();
                    estadoTxt.Text = selectedRow.Cells["Estado"].Value.ToString();
                    using (MySqlCommand command = new MySqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@Cpf", cpfTxt.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                profissaoTxt.Text = reader["Profissao"].ToString();
                                nacionalidadeTxt.Text = reader["Nacionalidade"].ToString();
                                telefoneTxt.Text = reader["Telefone"].ToString();
                                celularTxt.Text = reader["Celular"].ToString();
                                emailTxt.Text = reader["Email"].ToString();
                                bairroTxt.Text = reader["Bairro"].ToString();
                                cepTxt.Text = reader["Cep"].ToString();
                                observacoesTxt.Text = reader["Observacoes"].ToString();
                                enderecoTxt.Text = reader["Endereco"].ToString();
                                numeroTxt.Text = reader["Numero"].ToString();
                                complementoTxt.Text = reader["Complemento"].ToString();
                            }
                        }
                    }
                   
                   conexao.Dispose();
                }
            }
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                conexao.Open();
                if (clienteDataGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);
                    string query = "DELETE FROM cliente WHERE Id = @Id";

                    using (MySqlCommand command = new MySqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                    Limpar();
                    conexao.Dispose();
                    btnConsultar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Nehuma linha selecionada");
                }
            }
        }
    }
}
