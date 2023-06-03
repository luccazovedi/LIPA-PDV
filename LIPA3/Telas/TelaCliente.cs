using LIPA3.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIPA3.Telas
{

    public partial class TelaCliente : Form
    {

        string tipoConsulta = "NOME";

        public TelaCliente()
        {
            InitializeComponent();
        }

        #region Funções Principais (CRUD)
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

                    while (leitor.Read())
                    {
                        int indiceLinha = clienteDataGrid.Rows.Add();

                        clienteDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                        clienteDataGrid.Rows[indiceLinha].Cells["NOME"].Value = leitor["Nome"].ToString();
                        clienteDataGrid.Rows[indiceLinha].Cells["CPF"].Value = leitor["Cpf"].ToString();
                        clienteDataGrid.Rows[indiceLinha].Cells["RG"].Value = leitor["Rg"].ToString();
                        clienteDataGrid.Rows[indiceLinha].Cells["CIDADE"].Value = leitor["Cidade"].ToString();
                        clienteDataGrid.Rows[indiceLinha].Cells["ESTADO"].Value = leitor["Estado"].ToString();
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
            if (clienteDataGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("[SISTEMA] Você realmente deseja remover esse cliente?", "[LAMBDA] Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);

                    MySQL.RemoverTabelaCliente(id);

                    Exibir();
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("[SISTEMA] Erro! É necessário selecionar um cliente antes de excluí-lo.", "[LAMBDA] Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Editar()
        {
            if (MessageBox.Show("[SISTEMA] Você realmente deseja editar esse cliente?", "[LAMBDA] Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySQL.conexao.Open();

                int id = Convert.ToInt32(clienteDataGrid.SelectedRows[0].Cells["ID"].Value);

                if (RetornarCPF() == false)
                {
                    if ((string) MySQL.ChecarEditarCPF(id) == cpfTxt.Text)
                    {
                        bool situacao = situacaoChk.Checked;
                        bool whatsApp = whatsAppChk.Checked;

                        string consulta = "UPDATE Cliente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Cidade = @cidade, Estado = @estado, Profissao = @profissao, Nacionalidade = @nacionalidade, Telefone = @telefone, Celular = @celular, Email = @email, Bairro = @bairro, Cep = @Cep, Observacoes = @observacoes, Endereco = @endereco, Numero = @numero, Complemento = @Complemento, EstadoCivil = @EstadoCivil, Situacao = @situacao, WhatsApp = @whatsapp WHERE Id = @Id";

                        using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
                        {
                            comando.Parameters.AddWithValue("@Nome", nomeTxt.Text);
                            comando.Parameters.AddWithValue("@Cpf", cpfTxt.Text);
                            comando.Parameters.AddWithValue("@Rg", rgTxt.Text);
                            comando.Parameters.AddWithValue("@Cidade", cidadeTxt.Text);
                            comando.Parameters.AddWithValue("@Estado", estadoTxt.Text);
                            comando.Parameters.AddWithValue("@Profissao", profissaoTxt.Text);
                            comando.Parameters.AddWithValue("@Nacionalidade", nacionalidadeTxt.Text);
                            comando.Parameters.AddWithValue("@Telefone", telefoneTxt.Text);
                            comando.Parameters.AddWithValue("@Celular", celularTxt.Text);
                            comando.Parameters.AddWithValue("@Email", emailTxt.Text);
                            comando.Parameters.AddWithValue("@Bairro", bairroTxt.Text);
                            comando.Parameters.AddWithValue("@Cep", cepTxt.Text);
                            comando.Parameters.AddWithValue("@Observacoes", observacoesTxt.Text);
                            comando.Parameters.AddWithValue("@Endereco", enderecoTxt.Text);
                            comando.Parameters.AddWithValue("@Numero", numeroTxt.Text);
                            comando.Parameters.AddWithValue("@Complemento", complementoTxt.Text);
                            comando.Parameters.AddWithValue("@EstadoCivil", estadoCivilCmb.Text);
                            comando.Parameters.AddWithValue("@Situacao", situacao);
                            comando.Parameters.AddWithValue("@Id", id);
                            comando.Parameters.AddWithValue("@WhatsApp", whatsApp);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("[SISTEMA] Cliente editado com sucesso!", "[LAMBDA] Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        MySQL.conexao.Dispose();

                        clienteDataGrid.DataSource = null;
                        clienteDataGrid.Rows.Clear();

                        Exibir();
                        Limpar();
                    }
                }
                else
                {
                    MessageBox.Show("[SISTEMA] O CPF digitado é INVÁLIDO ou JÁ EXISTE! Tente novamente.", "[LAMBDA] Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Consultar()
        {
            clienteDataGrid.DataSource = null;
            clienteDataGrid.Rows.Clear();

            MySQL.conexao.Open();

            string consulta = MySQL.ConsultarTabelaCliente(consultaTxt.Text, tipoConsulta);

            if (consulta == "")
            {
                MessageBox.Show("[SISTEMA] Erro! Não é possível realizar uma consulta vazia.", "[LAMBDA] Consultar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    int indiceLinha = clienteDataGrid.Rows.Add();

                    clienteDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                    clienteDataGrid.Rows[indiceLinha].Cells["NOME"].Value = leitor["Nome"].ToString();
                    clienteDataGrid.Rows[indiceLinha].Cells["CPF"].Value = leitor["Cpf"].ToString();
                    clienteDataGrid.Rows[indiceLinha].Cells["RG"].Value = leitor["Rg"].ToString();
                    clienteDataGrid.Rows[indiceLinha].Cells["CIDADE"].Value = leitor["Cidade"].ToString();
                    clienteDataGrid.Rows[indiceLinha].Cells["ESTADO"].Value = leitor["Estado"].ToString();
                }
            }

            MySQL.conexao.Dispose();
        }
        #endregion

        #region Métodos CPF
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

        private bool RetornarCPF()
        {
            bool cpfValido = ValidarCPF(cpfTxt.Text);
            bool cpfExistente = VerificarCPF(cpfTxt.Text);

            if (cpfValido && !cpfExistente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Métodos Controles (WF)
        private void limparBtn_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void exibirBtn_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (RetornarCPF() == true)
            {
                Salvar();
            }
            else
            {
                MessageBox.Show("[SISTEMA] O CPF digitado é INVÁLIDO ou JÁ EXISTE! Tente novamente.", "[LAMBDA] Salvar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void editarBtn_Click(object sender, EventArgs e) // Não esquecer de melhorar essa Função.
        {
            Editar();
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            Consultar();
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
                                dataNascimentoTxt.Text = reader["DataNascimento"].ToString();

                                if (reader["Genero"].ToString() == "M")
                                {
                                    generoCmb.SelectedIndex = 0;
                                }
                                else if (reader["Genero"].ToString() == "F")
                                {
                                    generoCmb.SelectedIndex = 1;
                                }
                                else
                                {
                                    generoCmb.SelectedIndex = 2;
                                }

                                if (reader["EstadoCivil"].ToString() == "SOLTEIRO")
                                {
                                    estadoCivilCmb.SelectedIndex = 0;
                                }

                                if (reader["WhatsApp"].ToString() == "0")
                                {
                                    whatsAppChk.Checked = false;
                                }
                                if (reader["WhatsApp"].ToString() == "1")
                                {
                                    whatsAppChk.Checked = true;
                                }
                            }
                        }
                    }

                    conexao.Dispose();
                }
            }
        }
        #endregion
    
        #region Outros Eventos
        // Eventos
        private void numero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Evento de Redimensionamento do Formulário
        private void Form_Resize(object sender, EventArgs e)
        {
            generoCmb.Size = new Size(this.ClientSize.Width - 20, (this.ClientSize.Height - 40) / 2);
            dataNascimentoTxt.Size = new Size(this.ClientSize.Width - 20, (this.ClientSize.Height - 40) / 2);

            //textBox2.Location = new Point(10, textBox1.Bottom + 10);
        }

        private void TelaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }
        #endregion
    }
}
