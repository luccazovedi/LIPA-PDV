﻿using LIPA3.Classes;
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
        string tipoConsulta = "NOME";

        public TelaCliente()
        {
            InitializeComponent();
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
            consultaTxt.Text = "";
            nomeTxt.Focus();
        }

        private void Exibir()
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                clienteDataGrid.DataSource = null;
                clienteDataGrid.Rows.Clear();

                string consulta = MySQL.ExibirTabelaCliente();

                using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
                {
                    MySqlDataReader leitor = comando.ExecuteReader();

                    // Preenche o DataGridView com os dados do MySqlDataReader
                    while (leitor.Read())
                    {
                        int rowIndex = clienteDataGrid.Rows.Add();

                        // Preenche as células da linha com os dados do MySqlDataReader
                        clienteDataGrid.Rows[rowIndex].Cells["ID"].Value = leitor["Id"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["NOME"].Value = leitor["Nome"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["CPF"].Value = leitor["Cpf"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["RG"].Value = leitor["Rg"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["CIDADE"].Value = leitor["Cidade"].ToString();
                        clienteDataGrid.Rows[rowIndex].Cells["ESTADO"].Value = leitor["Estado"].ToString();
                    }
                }
                conexao.Dispose();
            }
        }

        private void Salvar()
        {
            int situacao;
            if (situacaoChk.Checked)
            {
                situacao = 1;
            }
            else
            {
                situacao = 0;
            }

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

            MySQL.InserirTabelaCliente(nomeTxt.Text, situacao, cpfTxt.Text, rgTxt.Text, genero, dataNascimentoTxt.Text,
                estadoCivilCmb.SelectedText, profissaoTxt.Text, nacionalidadeTxt.Text, telefoneTxt.Text,
                celularTxt.Text, whatsApp, emailTxt.Text, enderecoTxt.Text, numeroTxt.Text, complementoTxt.Text,
                bairroTxt.Text, cidadeTxt.Text, estadoTxt.Text, cepTxt.Text, observacoesTxt.Text);

            Exibir();
            Limpar();
        }

        private void Excluir()
        {
            if (MessageBox.Show("[SISTEMA] Você realmente deseja remover esse cliente?", "[LAMBDA] Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);

                MySQL.RemoverTabelaCliente(id);

                Exibir();
                Limpar();
            }
        }

        private void Editar()
        {
            if (MessageBox.Show("[SISTEMA] Você realmente deseja editar esse cliente?", "[LAMBDA] Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);
                bool situacao = situacaoChk.Checked;

                MySQL.EditarTabelaCliente(nomeTxt.Text, cpfTxt.Text, rgTxt.Text, cidadeTxt.Text, estadoTxt.Text, situacao, id);

                clienteDataGrid.DataSource = null;
                clienteDataGrid.Rows.Clear();

                Exibir();
                Limpar();
            }
        }

        private void Consultar()
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                clienteDataGrid.DataSource = null;
                clienteDataGrid.Rows.Clear();

                conexao.Open();

                string consulta = MySQL.ConsultarTabelaCliente(consultaTxt.Text, tipoConsulta);

                if (consulta == "")
                {
                    MessageBox.Show("Erro! Não é possível realizar uma consulta vazia.");
                    return;
                }

                using (MySqlCommand command = new MySqlCommand(consulta, MySQL.conexao))
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

        private bool VerificarCPF(string cpf)
        {
            using (MySqlConnection conexao = new MySqlConnection(MySQL.caminhoConexao))
            {
                conexao.Open();
                string consulta = "SELECT * FROM cliente WHERE Cpf = @cpf";

                using (MySqlCommand command = new MySqlCommand(consulta, conexao))
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
            bool cpfExistente = VerificarCPF(cpfTxt.Text);
            if (cpfValido && !cpfExistente)
            {
                Salvar();
            }
            else
            {
                MessageBox.Show("[SISTEMA] O CPF digitado é INVÁLIDO ou JÁ EXISTE! Tente novamente.");
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
                    conexao.Dispose();

                    Exibir();
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Nehuma linha selecionada");
                }
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                conexao.Open();
                int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);
                bool inativo = situacaoChk.Checked;
                string query = "UPDATE Cliente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Cidade = @cidade, Estado = @estado, Profissao = @profissao, Nacionalidade = @nacionalidade, Telefone = @telefone, Celular = @celular, Email = @email, Bairro = @bairro, Cep = @Cep, Observacoes = @observacoes, Endereco = @endereco, Numero = @numero, Complemento = @Complemento, Situacao = @situacao WHERE Id = @Id";
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
                Exibir();
                Limpar();
            }
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void exibirBtn_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void consultaTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (tipoConsulta == "NOME")
                {
                    tipoConsulta = "CIDADE";
                }
                else if (tipoConsulta == "CIDADE")
                {
                    tipoConsulta = "ESTADO";
                }
                else if (tipoConsulta == "ESTADO")
                {
                    tipoConsulta = "NOME";
                }
                consultaLbl.Text = "[F1] PESQUISAR POR: " + tipoConsulta;
            }
        }

        private void clienteDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conexao = MySQL.conexao)
            {
                conexao.Open();

                if (clienteDataGrid.SelectedRows.Count > 0)
                {
                    string query = "SELECT * FROM Cliente WHERE Cpf = @Cpf";

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
    }
}
