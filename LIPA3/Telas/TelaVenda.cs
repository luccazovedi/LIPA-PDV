using LIPA3.Classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIPA3.Telas
{
    public partial class TelaVenda : Form
    {
        private int ClienteId { get; set; }
        private int ProdutoId { get; set; }
        private int VendaId { get; set; }
        private int VendaItemId { get; set; }

        public TelaVenda()
        {
            InitializeComponent();

            Limpar("T");
        }

        #region Funções Principais Venda (CRUD)
        private void Limpar(string tipo)
        {
            if (tipo == "T" || tipo == "V")
            {
                clienteTxt.Text = "";
                formaPagamentoCmb.SelectedIndex = -1;
                situacaoCmb.SelectedIndex = -1;
                observacoesTxt.Text = "";
                totalItensTxt.Text = "";
                subTotalTxt.Text = "";
                descontoTxt.Text = "";
                valorTotalTxt.Text = "";
                ClienteId = 0;
                ProdutoId = 0;
                VendaId = 0;

                vendaItensDataGrid.DataSource = null;
                vendaItensDataGrid.Rows.Clear();

                clienteTxt.Focus();

                totalItensTxt.Enabled = false;
                subTotalTxt.Enabled = false;
                descontoTxt.Enabled = false;
                valorTotalTxt.Enabled = false;
            }
            
            if (tipo == "T" || tipo == "VI")
            {
                produtoTxt.Text = "";
                quantidadeTxt.Text = "";
                valorUnitarioTxt.Text = "";
                subTotalProdutoTxt.Text = "";
                VendaItemId = 0;

                produtoTxt.Focus();
            }       
        }

        private void Exibir()
        {
            vendaItensDataGrid.DataSource = null;
            vendaItensDataGrid.Rows.Clear();

            MySQL.conexao.Open();

            string consulta = MySQL.ExibirTabelaVendaItens(VendaId);

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    int indiceLinha = vendaItensDataGrid.Rows.Add();

                    vendaItensDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
                    vendaItensDataGrid.Rows[indiceLinha].Cells["DESCRICAO"].Value = leitor["Descricao"].ToString();
                    vendaItensDataGrid.Rows[indiceLinha].Cells["QUANTIDADE"].Value = leitor["Quantidade"].ToString();
                    vendaItensDataGrid.Rows[indiceLinha].Cells["VALORUNITARIO"].Value = leitor["ValorUnitario"].ToString();
                    vendaItensDataGrid.Rows[indiceLinha].Cells["SUBTOTAL"].Value = leitor["SubTotalProduto"].ToString();
                }
            }

            MySQL.conexao.Dispose();
        }

        private void Salvar()
        {
            if (clienteTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo CLIENTE!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clienteTxt.Focus();
                return;
            }
            else if (formaPagamentoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo FORMA PAGAMENTO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formaPagamentoCmb.Focus();
                return;
            }
            else if (situacaoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo SITUAÇÃO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                situacaoCmb.Focus();
                return;
            }

            //MySQL.InserirTabelaVenda(ClienteId, 1, int.Parse(totalItensTxt.Text), double.Parse(subTotalTxt.Text), double.Parse(descontoTxt.Text),
            //    double.Parse(valorTotalTxt.Text), formaPagamentoCmb.SelectedItem.ToString(), situacaoCmb.SelectedItem.ToString(), observacoesTxt.Text);
            MySQL.InserirTabelaVenda(ClienteId, 1, 0, 0, 0, 0, formaPagamentoCmb.SelectedItem.ToString(), situacaoCmb.SelectedItem.ToString(), observacoesTxt.Text);

            //Exibir();
            Limpar("V");
        }

        private void Excluir()
        {
            if (VendaId != 0)
            {
                if (MessageBox.Show("[SISTEMA] Você realmente deseja excluir essa venda?", "[LAMBDA] Excluir Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySQL.RemoverTabelaVenda(VendaId);

                    //Exibir();
                    Limpar("T");
                }
            }
            else
            {
                MessageBox.Show("[SISTEMA] Erro! É necessário selecionar uma venda antes de excluí-la.", "[LAMBDA] Excluir Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void Editar()
        {
            MySQL.conexao.Open();

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
        }*/

        private void CalcularTotal()
        {
            MySQL.conexao.Open();

            string consulta = "SELECT COUNT(Id) AS TotalItens, SUM(SubTotalProduto) AS SubTotal FROM VendaItens WHERE VendaId = " + VendaId;

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    totalItensTxt.Text = leitor["TotalItens"].ToString();

                    if (int.Parse(totalItensTxt.Text) > 0)
                    {
                        subTotalTxt.Text = leitor["SubTotal"].ToString();
                    }
                    else
                    {
                        subTotalTxt.Text = "0";
                    }
                }
            }

            MySQL.conexao.Dispose();

            double subTotal = double.Parse(subTotalTxt.Text);
            double desconto = double.Parse(descontoTxt.Text);
            double valorTotal = subTotal - desconto;
            valorTotalTxt.Text = valorTotal.ToString();

            MySQL.conexao.Open();

            consulta = "UPDATE Venda SET TotalItens = @TotalItens, SubTotal = @SubTotal, Desconto = @Desconto, " +
                "ValorTotal = @ValorTotal WHERE Id = " + VendaId;

            using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            {
                comando.Parameters.AddWithValue("@TotalItens", int.Parse(totalItensTxt.Text));
                if (double.Parse(subTotalTxt.Text) <= 0)
                {
                    comando.Parameters.AddWithValue("@SubTotal", 0);
                }
                else
                {
                    comando.Parameters.AddWithValue("@SubTotal", double.Parse(subTotalTxt.Text));
                }
                comando.Parameters.AddWithValue("@Desconto", double.Parse(descontoTxt.Text));
                comando.Parameters.AddWithValue("@ValorTotal", double.Parse(valorTotalTxt.Text));

                comando.ExecuteNonQuery();
            }

            MySQL.conexao.Dispose();
        }
        #endregion

        #region Métodos Controles (WF)
        private void limparBtn_Click(object sender, EventArgs e)
        {
            Limpar("T");
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            TelaClienteConsulta telaClienteConsulta = new TelaClienteConsulta();
            DialogResult resultado = telaClienteConsulta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (telaClienteConsulta.Selecionou == true)
                {
                    ClienteId = int.Parse(telaClienteConsulta.ClienteId);
                    clienteTxt.Text = telaClienteConsulta.ClienteNome;
                }
            }
        }

        private void produtoBtn_Click(object sender, EventArgs e)
        {
            TelaProdutoConsulta telaProdutoConsulta = new TelaProdutoConsulta();
            DialogResult resultado = telaProdutoConsulta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (telaProdutoConsulta.Selecionou == true)
                {
                    ProdutoId = int.Parse(telaProdutoConsulta.ProdutoId);
                    produtoTxt.Text = telaProdutoConsulta.ProdutoDescricao;
                    valorUnitarioTxt.Text = telaProdutoConsulta.ProdutoValor;
                }
            }
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            TelaVendaConsulta telaVendaConsulta = new TelaVendaConsulta();
            DialogResult resultado = telaVendaConsulta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (telaVendaConsulta.Selecionou == true)
                {
                    VendaId = int.Parse(telaVendaConsulta.VendaId);

                    if (VendaId != 0)
                    {
                        MySQL.conexao.Open();

                        string consulta = "SELECT * FROM Venda WHERE Id = @Id";

                        using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
                        {
                            comando.Parameters.AddWithValue("@Id", VendaId);
                            using (MySqlDataReader leitor = comando.ExecuteReader())
                            {
                                if (leitor.Read())
                                {
                                    observacoesTxt.Text = leitor["Observacoes"].ToString();
                                    totalItensTxt.Text = leitor["TotalItens"].ToString();
                                    subTotalTxt.Text = leitor["SubTotal"].ToString();
                                    descontoTxt.Text = leitor["Desconto"].ToString();
                                    valorTotalTxt.Text = leitor["ValorTotal"].ToString();

                                    if (leitor["FormaPagamento"].ToString() == "CARTÃO CRÉDITO")
                                    {
                                        formaPagamentoCmb.SelectedIndex = 0;
                                    }
                                    else if (leitor["FormaPagamento"].ToString() == "CARTÃO DÉBITO")
                                    {
                                        formaPagamentoCmb.SelectedIndex = 1;
                                    }
                                    else if (leitor["FormaPagamento"].ToString() == "DEPÓSITO")
                                    {
                                        formaPagamentoCmb.SelectedIndex = 2;
                                    }
                                    else if (leitor["FormaPagamento"].ToString() == "DINHEIRO")
                                    {
                                        formaPagamentoCmb.SelectedIndex = 3;
                                    }
                                    else if (leitor["FormaPagamento"].ToString() == "PIX")
                                    {
                                        formaPagamentoCmb.SelectedIndex = 4;
                                    }

                                    if (leitor["Situacao"].ToString() == "ABERTA")
                                    {
                                        situacaoCmb.SelectedIndex = 0;
                                    }
                                    else if (leitor["Situacao"].ToString() == "PAGA")
                                    {
                                        situacaoCmb.SelectedIndex = 1;
                                    }
                                    else if (leitor["Situacao"].ToString() == "FINALIZADA")
                                    {
                                        situacaoCmb.SelectedIndex = 2;
                                    }

                                    string clienteId = leitor["ClienteId"].ToString();
                                    consulta = "SELECT Nome FROM Cliente WHERE Id = " + int.Parse(clienteId);
                                }
                            }
                            MySqlCommand outroComando = new MySqlCommand(consulta, MySQL.conexao);
                            MySqlDataReader outroLeitor = outroComando.ExecuteReader();

                            if (outroLeitor.Read())
                            {
                                clienteTxt.Text = outroLeitor["Nome"].ToString();
                            }
                        }

                        MySQL.conexao.Dispose();

                        Exibir();

                        totalItensTxt.Enabled = true;
                        subTotalTxt.Enabled = true;
                        descontoTxt.Enabled = true;
                        valorTotalTxt.Enabled = true;
                    }
                }
            }
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            if (produtoTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo PRODUTO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                produtoTxt.Focus();
                return;
            }
            else if (quantidadeTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo QUANTIDADE!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quantidadeTxt.Focus();
                return;
            }
            else if (valorUnitarioTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo VALOR UNITÁRIO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valorUnitarioTxt.Focus();
                return;
            }
            else if (int.Parse(quantidadeTxt.Text) <= 0)
            {
                MessageBox.Show("[SISTEMA] A quantidade não pode ser NEGATIVA ou IGUAL A ZERO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quantidadeTxt.Focus();
                return;

            }
            else if (double.Parse(valorUnitarioTxt.Text) <= 0)
            {
                MessageBox.Show("[SISTEMA] O valor unitário não pode ser NEGATIVO OU IGUAL A ZERO!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valorUnitarioTxt.Focus();
                return;
            }

            if (VendaId != 0 && ProdutoId != 0)
            {
                int quantidade = int.Parse(quantidadeTxt.Text);
                double valorUnitario = double.Parse(valorUnitarioTxt.Text);
                double subTotalProduto = quantidade * valorUnitario;

                subTotalProdutoTxt.Text = subTotalProduto.ToString();

                //int quantidadeEstoque = MySQL.ChecarEstoque(ProdutoId, quantidadeTxt.Text);

                //if (quantidadeEstoque != 0)
                //{
                //    int quantidadeAtualizada = quantidadeEstoque - quantidade;

                //    MySQL.conexao.Open();

                //    string consulta = "UPDATE Produto SET QuantidadeEstoque = @QuantidadeAtualizada WHERE Id = " + ProdutoId;

                //    using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
                //    {
                //        comando.Parameters.AddWithValue("@QuantidadeAtualizada", quantidadeAtualizada);

                //        comando.ExecuteNonQuery();
                //    }

                //    MySQL.conexao.Dispose();

                MySQL.InserirTabelaVendaItens(VendaId, ProdutoId, quantidade, produtoTxt.Text, valorUnitario, subTotalProduto);

                CalcularTotal();
                Exibir();
                Limpar("VI");
                //}
                //else
                //{
                //    MessageBox.Show("[SISTEMA] A quantidade digitada ultrapassa o estoque do produto!", "[LAMBDA] Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
            }
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            //int quantidade = int.Parse(quantidadeTxt.Text);

            //int quantidadeEstoque = MySQL.ChecarEstoque(ProdutoId, quantidadeTxt.Text);

            //int quantidadeAtualizada = quantidadeEstoque + quantidade;

            //MySQL.conexao.Open();

            //string consulta = "UPDATE Produto SET QuantidadeEstoque = @QuantidadeAtualizada WHERE Id = " + ProdutoId;

            //using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
            //{
            //    comando.Parameters.AddWithValue("@QuantidadeAtualizada", quantidadeAtualizada);

            //    comando.ExecuteNonQuery();
            //}

            //MySQL.conexao.Dispose();

            if (VendaId != 0 && VendaItemId != 0)
            {
                MySQL.RemoverTabelaVendaItens(VendaItemId);

                CalcularTotal();
                Exibir();
                Limpar("VI");
            }
        }

        private void vendaItensDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MySQL.conexao.Open();

            if (vendaItensDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = vendaItensDataGrid.SelectedRows[0];
                string id = linhaSelecionada.Cells["Id"].Value.ToString();
                VendaItemId = int.Parse(id);
                produtoTxt.Text = linhaSelecionada.Cells["Descricao"].Value.ToString();
                quantidadeTxt.Text = linhaSelecionada.Cells["Quantidade"].Value.ToString();
                valorUnitarioTxt.Text = linhaSelecionada.Cells["ValorUnitario"].Value.ToString();
                subTotalProdutoTxt.Text = linhaSelecionada.Cells["SubTotal"].Value.ToString();
            }

            MySQL.conexao.Dispose();
        }
        #endregion
    }
}
