﻿using System;
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
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clienteLbl_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.Show();
            Close();
        }

        private void produtoLbl_Click(object sender, EventArgs e)
        {
            TelaProduto telaProduto = new TelaProduto();
            telaProduto.Show();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaAcesso telaAcesso = new TelaAcesso();
            telaAcesso.Show();
         
        }
    }
}
