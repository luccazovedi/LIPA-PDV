using LIPA3.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIPA3.Telas
{
    public partial class TelaProduto : Form
    {
        string tipoConsulta = "DESCRICAO";

        public TelaProduto()
        {
            InitializeComponent();

            descricaoTxt.Focus();
        }

        #region Funções Principais (CRUD)
        private void Limpar()
        {
            descricaoTxt.Text = "";
            CodProdutoTxt.Text = "";
            codigoBarrasTxt.Text = "";
            marcaTxt.Text = "";
            pesoTxt.Text = "";
            larguraTxt.Text = "";
            alturaTxt.Text = "";
            profundidadeTxt.Text = "";
            situacaoChk.Checked = false;
            novoRadBtn.Checked = true;
            precoVendaTxt.Text = "";
            quantidadeEstoqueTxt.Text = "";
            descricaoTxt.Focus();
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
                    int indiceLinha = produtoDataGrid.Rows.Add();

                    produtoDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["CodProduto"].Value = leitor["CodProduto"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["DESCRICAO"].Value = leitor["Descricao"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["MARCA"].Value = leitor["Marca"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["PRECOVENDA"].Value = leitor["PrecoVenda"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["QUANTIDADEESTOQUE"].Value = leitor["QuantidadeEstoque"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["CONDICAO"].Value = leitor["Condicao"].ToString();
                }
            }

            MySQL.conexao.Dispose();
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

            string condicao;
            if (novoRadBtn.Checked)
            {
                condicao = "NOVO";
            }
            else
            {
                condicao = "USADO";
            }

            MySQL.InserirTabelaProduto(descricaoTxt.Text,CodProdutoTxt.Text, codigoBarrasTxt.Text, marcaTxt.Text, double.Parse(pesoTxt.Text), 
                double.Parse(larguraTxt.Text), double.Parse(alturaTxt.Text), double.Parse(profundidadeTxt.Text), situacao, condicao, 
                double.Parse(precoVendaTxt.Text), double.Parse(quantidadeEstoqueTxt.Text));

            Exibir();
            Limpar();
        }

        private void Excluir()
        {
            if (produtoDataGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("[SISTEMA] Você realmente deseja excluir esse produto?", "[LAMBDA] Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(produtoDataGrid.SelectedRows[0].Cells["ID"].Value);

                    MySQL.RemoverTabelaProduto(id);

                    Exibir();
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("[SISTEMA] Erro! É necessário selecionar um produto antes de excluí-lo.", "[LAMBDA] Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            MySQL.conexao.Open();

            int id = Convert.ToInt32(produtoDataGrid.SelectedRows[0].Cells["ID"].Value);

            bool situacao = situacaoChk.Checked;

            string condicao;
            if (novoRadBtn.Checked)
            {
                condicao = "NOVO";
            }
            else
            {
                condicao = "USADO";
            }

            string consulta = "UPDATE Produto SET Descricao = @Descricao, CodProduto = @CodProduto, CodigoBarras = @CodigoBarras, Marca = @Marca, Peso = @Peso," +
                "Largura = @Largura, Altura = @Altura, Profundidade = @Profundidade, Situacao = @Situacao, Condicao = @Condicao," +
                "PrecoVenda = @PrecoVenda, QuantidadeEstoque = @QuantidadeEstoque WHERE Id = @Id";

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                comando.Parameters.AddWithValue("@Descricao", descricaoTxt.Text);
                comando.Parameters.AddWithValue("@CodProduto", CodProdutoTxt.Text);
                comando.Parameters.AddWithValue("@CodigoBarras", codigoBarrasTxt.Text);
                comando.Parameters.AddWithValue("@Marca", marcaTxt.Text);
                comando.Parameters.AddWithValue("@Peso", double.Parse(pesoTxt.Text));
                comando.Parameters.AddWithValue("@Largura", double.Parse(larguraTxt.Text));
                comando.Parameters.AddWithValue("@Altura", double.Parse(alturaTxt.Text));
                comando.Parameters.AddWithValue("@Profundidade", double.Parse(profundidadeTxt.Text));
                comando.Parameters.AddWithValue("@Situacao", situacao);
                comando.Parameters.AddWithValue("@Condicao", condicao);
                comando.Parameters.AddWithValue("@PrecoVenda", double.Parse(precoVendaTxt.Text));
                comando.Parameters.AddWithValue("@QuantidadeEstoque", double.Parse(quantidadeEstoqueTxt.Text));
                comando.Parameters.AddWithValue("@Id", id);

                comando.ExecuteNonQuery();

                MessageBox.Show("[SISTEMA] Produto editado com sucesso!", "[LAMBDA] Editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MySQL.conexao.Dispose();

            produtoDataGrid.DataSource = null;
            produtoDataGrid.Rows.Clear();

            Exibir();
            Limpar();
        }

        private void Consultar()
        {
            produtoDataGrid.DataSource = null;
            produtoDataGrid.Rows.Clear();

            MySQL.conexao.Open();

            string consulta = MySQL.ConsultarTabelaProduto(consultaTxt.Text, tipoConsulta);

            if (consulta == "")
            {
                MessageBox.Show("[SISTEMA] Erro! Não é possível realizar uma consulta vazia.", "[LAMBDA] Consultar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    int indiceLinha = produtoDataGrid.Rows.Add();

                    produtoDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["CodProduto"].Value = leitor["CodProduto"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["DESCRICAO"].Value = leitor["Descricao"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["MARCA"].Value = leitor["Marca"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["PRECOVENDA"].Value = leitor["PrecoVenda"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["QUANTIDADEESTOQUE"].Value = leitor["QuantidadeEstoque"].ToString();
                    produtoDataGrid.Rows[indiceLinha].Cells["CONDICAO"].Value = leitor["Condicao"].ToString();
                }
            }

            MySQL.conexao.Dispose();
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
            Salvar();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultaTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (tipoConsulta == "DESCRICAO")
                {
                    tipoConsulta = "MARCA";
                }
                else if (tipoConsulta == "MARCA")
                {
                    tipoConsulta = "CONDICAO";
                }
                else if (tipoConsulta == "CONDICAO")
                {
                    tipoConsulta = "DESCRICAO";
                }
                consultaLbl.Text = "[F1] CONSULTAR POR: " + tipoConsulta;
            }
        }

        private void produtoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySQL.conexao.Open();

            if (produtoDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = produtoDataGrid.SelectedRows[0];
                string id = linhaSelecionada.Cells["Id"].Value.ToString();
                descricaoTxt.Text = linhaSelecionada.Cells["Descricao"].Value.ToString();
                marcaTxt.Text = linhaSelecionada.Cells["Marca"].Value.ToString();
                precoVendaTxt.Text = linhaSelecionada.Cells["PrecoVenda"].Value.ToString();
                quantidadeEstoqueTxt.Text = linhaSelecionada.Cells["QuantidadeEstoque"].Value.ToString();

                if (linhaSelecionada.Cells["Condicao"].Value.ToString() == "NOVO")
                {
                    novoRadBtn.Checked = true;
                }
                else
                {
                    usadoRadBtn.Checked = true;
                }

                string consulta = "SELECT * FROM Produto WHERE Id = @Id";

                using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            CodProdutoTxt.Text = leitor["CodProduto"].ToString();
                            codigoBarrasTxt.Text = leitor["CodigoBarras"].ToString();
                            pesoTxt.Text = leitor["Peso"].ToString();
                            larguraTxt.Text = leitor["Largura"].ToString();
                            alturaTxt.Text = leitor["Altura"].ToString();
                            profundidadeTxt.Text = leitor["Profundidade"].ToString();

                            if (leitor["Situacao"].Equals(1))
                            {
                                situacaoChk.Checked = true;
                            }
                            else
                            {
                                situacaoChk.Checked = false;
                            }
                        }
                    }
                }

                MySQL.conexao.Dispose();
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
