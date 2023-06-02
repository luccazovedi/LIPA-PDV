﻿using System;
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

        private void Entrar()
        {
            if (usuarioTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo USUÁRIO!");
                usuarioTxt.Focus();
                return;
            }
            else if (senhaTxt.Text == "")
            {
                MessageBox.Show("[SISTEMA] É necessário preencher o campo SENHA!");
                senhaTxt.Focus();
                return;
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
                        TelaPrincipal telaPrincipal = new TelaPrincipal();
                        telaPrincipal.Show();

                    }
                    else
                    {
                        MessageBox.Show("[SISTEMA] Senha incorreta! Tente novamente.");
                        senhaTxt.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("[SISTEMA] Usuário incorreto! Tente novamente.");
                    usuarioTxt.Focus();
                    return;
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("[SISTEMA] Ocorreu um erro!.");
            }
            finally
            {
                MySQL.conexao.Close();
            }
        }

        private void Registrar()
        {
            TelaRegistro telaRegistro = new TelaRegistro();
            telaRegistro.Show();
        }

        private void TelaAcesso_Load(object sender, EventArgs e)
        {
            
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            Entrar();
            //Close();
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Registrar();
        }
    }
}
