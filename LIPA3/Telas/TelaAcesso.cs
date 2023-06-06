using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIPA3.Classes;
using MySql.Data.MySqlClient;
using System.Data.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using LIPA3.Telas;
using System.Threading;

namespace LIPA3
{
    public partial class TelaAcesso : Form
    {
        public TelaAcesso()
        {
            InitializeComponent();

            MySQL.Conectar();
            MySQL.CriarTabelaUsuario();
            MySQL.CriarTabelaCliente();

            usuarioTxt.Focus();
        }

        #region Funções Principais
        private bool Entrar()
        {
            if (usuarioTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo USUÁRIO!", "[LAMBDA] Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioTxt.Focus();
                return false;
            }
            else if (senhaTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo SENHA!", "[LAMBDA] Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhaTxt.Focus();
                return false;
            }

            try
            {
                MySQL.conexao.Open();

                var consulta = "SELECT Id FROM Usuario WHERE Usuario = '" + usuarioTxt.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao);
                object usuarioId = comando.ExecuteScalar();

                if (usuarioId != null)
                {
                    consulta = "SELECT Senha FROM Usuario WHERE Id = '" + usuarioId + "'";
                    comando = new MySqlCommand(consulta, MySQL.conexao);
                    object usuarioSenha = comando.ExecuteScalar();

                    if ((string)usuarioSenha == senhaTxt.Text)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("[SISTEMA] Senha incorreta! Tente novamente.", "[LAMBDA] Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        senhaTxt.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("[SISTEMA] Usuário incorreto! Tente novamente.", "[LAMBDA] acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuarioTxt.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!", "[LAMBDA] Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MySQL.conexao.Close();
            }
        }

        private void Registrar()
        {
            this.Hide();
            var telaRegistro = new TelaRegistro();
            telaRegistro.Closed += (s, args) => this.Close();
            telaRegistro.Show();
        }
        #endregion

        #region Controles Principais
        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (Entrar() == true)
            {
                this.Hide();
                var telaPrincipal = new TelaPrincipal();
                telaPrincipal.Closed += (s, args) => this.Close();
                telaPrincipal.Show();
            }
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void usuarioTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                senhaTxt.Focus();
            }
        }

        private void senhaTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                entrarBtn_Click(sender, e);
            }
        }
        #endregion
    }
}
