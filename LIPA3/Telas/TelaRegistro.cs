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
        }

        private void Registrar()
        {
            if (nomeTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo NOME!");
                nomeTxt.Focus();
                return;
            }
            else if (usuarioTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo USUÁRIO!");
                usuarioTxt.Focus();
                return;
            }
            else if (tipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo TIPO!");
                tipoCmb.Focus();
                return;
            }
            else if (senhaTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo SENHA!");
                senhaTxt.Focus();
                return;
            }

            MySQL.InserirTabelaUsuario(nomeTxt.Text, usuarioTxt.Text, tipoCmb.SelectedText, senhaTxt.Text, 1);

            nomeTxt.Clear();
            usuarioTxt.Clear();
            tipoCmb.SelectedIndex = -1;
            senhaTxt.Clear();
            nomeTxt.Focus();
        }

        private void Voltar()
        {
            Close();
        }

        private void TelaRegistro_Load(object sender, EventArgs e)
        {
            MySQL.Conectar();
            MySQL.CriarTabelaUsuario();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            Voltar();
        }
    }
}
