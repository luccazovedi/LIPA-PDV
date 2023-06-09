﻿using LIPA3.Classes;
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
    public partial class TelaPrincipal : Form
    {
        string escolhaTela = "";
        object usuarioId;
        public TelaPrincipal(object usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        private bool ChecarTipoUsuario()
        {
            try
            {
                MySQL.conexao.Open();

                var consulta = "SELECT Tipo FROM Usuario WHERE Id = '" + usuarioId + "'";
                MySqlCommand comando = new MySqlCommand(consulta, MySQL.conexao);
                object usuarioTipo = comando.ExecuteScalar();

                if ((string) usuarioTipo == "ADMINISTRADOR")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception) 
            {
                return false;
            }
            finally
            {
                MySQL.conexao.Close();
            }
        }

        private void clienteLbl_Click(object sender, EventArgs e)
        {
            if (ChecarTipoUsuario() == false)
            {
                MessageBox.Show("[SISTEMA] Permissão insuficiente!", "[LAMBDA] Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                escolhaTela = "C";
            }

            //this.Hide();
            //var telaCliente = new TelaCliente();
            //telaCliente.Closed += (s, args) => this.Close();
            //telaCliente.Show();
        }

        private void produtoLbl_Click(object sender, EventArgs e)
        {
            if (ChecarTipoUsuario() == false)
            {
                MessageBox.Show("[SISTEMA] Permissão insuficiente!", "[LAMBDA] Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                escolhaTela = "P";
            }

            //this.Hide();
            //var telaProduto = new TelaProduto();
            //telaProduto.Closed += (s, args) => this.Close();
            //telaProduto.Show();
        }

        private void vendaLbl_Click(object sender, EventArgs e)
        {
            escolhaTela = "V";

            //this.Hide();
            //var telaVenda = new TelaVenda();
            //telaVenda.Closed += (s, args) => this.Close();
            //telaVenda.Show();
        }

        private void painelPnl_Click(object sender, EventArgs e)
        {
            if (escolhaTela == "C")
            {
                TelaCliente telaCliente = new TelaCliente();
                telaCliente.TopLevel = false;
                painelPnl.Controls.Add(telaCliente);
                telaCliente.FormBorderStyle = FormBorderStyle.None;
                telaCliente.Dock = DockStyle.Fill;
                telaCliente.Show();
            }
            else if (escolhaTela == "P")
            {
                TelaProduto telaProduto = new TelaProduto();
                telaProduto.TopLevel = false;
                painelPnl.Controls.Add(telaProduto);
                telaProduto.FormBorderStyle = FormBorderStyle.None;
                telaProduto.Dock = DockStyle.Fill;
                telaProduto.Show();
            }
            else if (escolhaTela == "V")
            {
                TelaVenda telaVenda = new TelaVenda();
                telaVenda.TopLevel = false;
                painelPnl.Controls.Add(telaVenda);
                telaVenda.FormBorderStyle = FormBorderStyle.None;
                telaVenda.Dock = DockStyle.Fill;
                telaVenda.Show();
            }
        }

        private void outroPainelPnl_Click(object sender, EventArgs e)
        {
            if (escolhaTela == "C")
            {
                TelaCliente telaCliente = new TelaCliente();
                telaCliente.TopLevel = false;
                outroPainelPnl.Controls.Add(telaCliente);
                telaCliente.FormBorderStyle = FormBorderStyle.None;
                telaCliente.Dock = DockStyle.Fill;
                telaCliente.Show();
            }
            else if (escolhaTela == "P")
            {
                TelaProduto telaProduto = new TelaProduto();
                telaProduto.TopLevel = false;
                outroPainelPnl.Controls.Add(telaProduto);
                telaProduto.FormBorderStyle = FormBorderStyle.None;
                telaProduto.Dock = DockStyle.Fill;
                telaProduto.Show();
            }
            else if (escolhaTela == "V")
            {
                TelaVenda telaVenda = new TelaVenda();
                telaVenda.TopLevel = false;
                outroPainelPnl.Controls.Add(telaVenda);
                telaVenda.FormBorderStyle = FormBorderStyle.None;
                telaVenda.Dock = DockStyle.Fill;
                telaVenda.Show();
            }
        }
    }
}
