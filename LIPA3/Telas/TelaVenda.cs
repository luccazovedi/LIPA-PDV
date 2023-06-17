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

        public TelaVenda()
        {
            InitializeComponent();
        }

        #region Funções Principais Venda (CRUD)
        private void Limpar()
        {
            clienteTxt.Text = "";
            formaPagamentoCmb.SelectedIndex = -1;
            situacaoCmb.SelectedIndex = -1;
            observacoesTxt.Text = "";
            produtoTxt.Text = "";
            quantidadeTxt.Text = "";
            valorUnitarioTxt.Text = "";
            subTotalProdutoTxt.Text = "";
            totalItensTxt.Text = "";
            subTotalTxt.Text = "";
            descontoTxt.Text = "";
            valorTotalTxt.Text = "";
            clienteTxt.Focus();
        }

        //private void Exibir()
        //{
        //    vendaItensDataGrid.DataSource = null;
        //    vendaItensDataGrid.Rows.Clear();

        //    MySQL.conexao.Open();

        //    string consulta = MySQL.ExibirTabelaVendaItens(VendaId);

        //    using (MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao))
        //    {
        //        MySqlDataReader leitor = comando.ExecuteReader();

        //        while (leitor.Read())
        //        {
        //            int indiceLinha = vendaItensDataGrid.Rows.Add();

        //            vendaItensDataGrid.Rows[indiceLinha].Cells["ID"].Value = leitor["Id"].ToString();
        //            vendaItensDataGrid.Rows[indiceLinha].Cells["DESCRICAO"].Value = leitor["Descricao"].ToString();
        //            vendaItensDataGrid.Rows[indiceLinha].Cells["QUANTIDADE"].Value = leitor["Marca"].ToString();
        //            vendaItensDataGrid.Rows[indiceLinha].Cells["VALORUNITARIO"].Value = leitor["PrecoVenda"].ToString();
        //            vendaItensDataGrid.Rows[indiceLinha].Cells["SUBTOTAL"].Value = leitor["SubTotal"].ToString();
 
        //        }
        //    }

        //    MySQL.conexao.Dispose();
        //}

        private void Salvar()
        {
            MySQL.InserirTabelaVenda(ClienteId, 1, int.Parse(totalItensTxt.Text), double.Parse(subTotalTxt.Text), double.Parse(descontoTxt.Text),
                double.Parse(valorTotalTxt.Text), formaPagamentoCmb.SelectedItem.ToString(), situacaoCmb.SelectedItem.ToString(), observacoesTxt.Text);

            //Exibir();
            Limpar();
        }

        private void Excluir()
        {
            if (VendaId != 0)
            {
                if (MessageBox.Show("[SISTEMA] Você realmente deseja excluir essa venda?", "[LAMBDA] Excluir Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySQL.RemoverTabelaProduto(VendaId);

                    //Exibir();
                    Limpar();
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
        #endregion

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
                ClienteId = int.Parse(telaClienteConsulta.ClienteId);
                clienteTxt.Text = telaClienteConsulta.ClienteNome;
            }
        }

        private void produtoBtn_Click(object sender, EventArgs e)
        {
            TelaProdutoConsulta telaProdutoConsulta = new TelaProdutoConsulta();
            DialogResult resultado = telaProdutoConsulta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ProdutoId = int.Parse(telaProdutoConsulta.ProdutoId);
                produtoTxt.Text = telaProdutoConsulta.ProdutoDescricao;
            }
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            TelaVendaConsulta telaVendaConsulta = new TelaVendaConsulta();
            DialogResult resultado = telaVendaConsulta.ShowDialog();

            VendaId = int.Parse(telaVendaConsulta.VendaId);

            if (resultado == DialogResult.OK && VendaId != 0)
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

                            if (leitor["Situacao"].ToString() == "ABERTA")
                            {
                                situacaoCmb.SelectedIndex = 0;
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
            }
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void exibirBtn_Click(object sender, EventArgs e)
        {
            //Exibir();
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
