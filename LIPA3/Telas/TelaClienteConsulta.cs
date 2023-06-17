using LIPA3.Classes;
using MySql.Data.MySqlClient;
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
    public partial class TelaClienteConsulta : Form
    {
        public string ClienteId { get; private set; }
        public string ClienteNome { get; private set; }

        public TelaClienteConsulta()
        {
            InitializeComponent();
        }

        private void Exibir()
        {
            clienteDataGrid.DataSource = null;
            clienteDataGrid.Rows.Clear();

            MySQL.conexao.Open();

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

            MySQL.conexao.Dispose();
        }

        private void TelaClienteConsulta_Load(object sender, EventArgs e)
        {
            Exibir();
        }

        private void clienteDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clienteDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = clienteDataGrid.SelectedRows[0];
                ClienteId = linhaSelecionada.Cells["Id"].Value.ToString(); ;
                ClienteNome = linhaSelecionada.Cells["Nome"].Value.ToString();
            }

            Close();
        }

        private void TelaClienteConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
