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
    public partial class TelaProdutoConsulta : Form
    {
        public string ProdutoId { get; private set; }
        public string ProdutoDescricao { get; private set; }
        public string ProdutoValor { get; private set; }
        public bool Selecionou { get; private set; }

        public TelaProdutoConsulta()
        {
            InitializeComponent();

            Selecionou = false;
        }

        private void Exibir()
        {
            produtoDataGrid.DataSource = null;
            produtoDataGrid.Rows.Clear();

            MySQL.conexao.Open();

            string consulta = MySQL.ExibirTabelaProduto();

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    if (leitor["Situacao"].ToString() == "0")
                    {
                        int indiceLinha = produtoDataGrid.Rows.Add();

                        produtoDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                        produtoDataGrid.Rows[indiceLinha].Cells["DESCRICAO"].Value = leitor["Descricao"].ToString();
                        produtoDataGrid.Rows[indiceLinha].Cells["MARCA"].Value = leitor["Marca"].ToString();
                        produtoDataGrid.Rows[indiceLinha].Cells["PRECOVENDA"].Value = leitor["PrecoVenda"].ToString();
                        produtoDataGrid.Rows[indiceLinha].Cells["QUANTIDADEESTOQUE"].Value = leitor["QuantidadeEstoque"].ToString();
                        produtoDataGrid.Rows[indiceLinha].Cells["CONDICAO"].Value = leitor["Condicao"].ToString();
                    }
                }
            }

            MySQL.conexao.Dispose();
        }

        private void TelaProdutoConsulta_Load(object sender, EventArgs e)
        {
            Exibir();
        }

        private void produtoDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produtoDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = produtoDataGrid.SelectedRows[0];
                ProdutoId = linhaSelecionada.Cells["Id"].Value.ToString(); ;
                ProdutoDescricao = linhaSelecionada.Cells["Descricao"].Value.ToString();
                ProdutoValor = linhaSelecionada.Cells["PrecoVenda"].Value.ToString();
                Selecionou = true;
            }

            Close();
        }

        private void TelaProdutoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
