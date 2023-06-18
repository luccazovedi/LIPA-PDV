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
    public partial class TelaVendaConsulta : Form
    {
        public string VendaId { get; private set; }
        public bool Selecionou { get; private set; }

        public TelaVendaConsulta()
        {
            InitializeComponent();

            Selecionou = false;
        }

        private void Exibir()
        {
            vendaDataGrid.DataSource = null;
            vendaDataGrid.Rows.Clear();

            MySQL.conexao.Open();

            string consulta = MySQL.ExibirTabelaVenda();

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    int indiceLinha = vendaDataGrid.Rows.Add();

                    vendaDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                    vendaDataGrid.Rows[indiceLinha].Cells["DATAVENDA"].Value = leitor["DataVenda"].ToString();
                    vendaDataGrid.Rows[indiceLinha].Cells["CLIENTE"].Value = leitor["ClienteId"].ToString();
                    vendaDataGrid.Rows[indiceLinha].Cells["USUARIO"].Value = leitor["UsuarioId"].ToString();
                    vendaDataGrid.Rows[indiceLinha].Cells["VALORTOTAL"].Value = leitor["ValorTotal"].ToString();
                }
            }

            MySQL.conexao.Dispose();
        }

        private void TelaVendaConsulta_Load(object sender, EventArgs e)
        {
            Exibir();
        }

        private void vendaDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vendaDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = vendaDataGrid.SelectedRows[0];
                VendaId = linhaSelecionada.Cells["Id"].Value.ToString();
                Selecionou = true;
            }

            Close();
        }

        private void TelaVendaConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
