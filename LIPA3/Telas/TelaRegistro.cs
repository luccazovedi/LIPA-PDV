using LIPA3.Classes;
using System;
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
    public partial class TelaRegistro : Form
    {
        public TelaRegistro()
        {
            InitializeComponent();

            MySQL.Conectar();

            nomeTxt.Focus();
        }

        #region Funções Principais
        private void Registrar()
        {
            if (nomeTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo NOME!", "[LAMBDA] Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeTxt.Focus();
                return;
            }
            else if (usuarioTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo USUÁRIO!", "[LAMBDA] Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioTxt.Focus();
                return;
            }
            else if (tipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo TIPO!", "[LAMBDA] Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoCmb.Focus();
                return;
            }
            else if (senhaTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo SENHA!", "[LAMBDA] Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhaTxt.Focus();
                return;
            }

            MySQL.InserirTabelaUsuario(nomeTxt.Text, usuarioTxt.Text, tipoCmb.SelectedItem.ToString(), senhaTxt.Text, 1);

            nomeTxt.Clear();
            usuarioTxt.Clear();
            tipoCmb.SelectedIndex = -1;
            senhaTxt.Clear();
            nomeTxt.Focus();
        }

        private void Voltar()
        {
            this.Hide();
            var telaAcesso = new TelaAcesso();
            telaAcesso.Closed += (s, args) => this.Close();
            telaAcesso.Show();
        }
        #endregion

        #region Controles Principais
        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            Voltar();
        }
        #endregion
    }
}
