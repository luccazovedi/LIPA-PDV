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
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clienteLbl_Click(object sender, EventArgs e)
        {
            painelPnl.Controls.Clear();
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.TopLevel = false;
            painelPnl.Controls.Add(telaCliente);
            telaCliente.FormBorderStyle = FormBorderStyle.None;
            telaCliente.Dock = DockStyle.Fill;
            telaCliente.Show();

            //this.Hide();
            //var telaCliente = new TelaCliente();
            //telaCliente.Closed += (s, args) => this.Close();
            //telaCliente.Show();
        }

        private void produtoLbl_Click(object sender, EventArgs e)
        {
            painelPnl.Controls.Clear();
            TelaProduto telaProduto = new TelaProduto();
            telaProduto.TopLevel = false;
            painelPnl.Controls.Add(telaProduto);
            telaProduto.FormBorderStyle = FormBorderStyle.None;
            telaProduto.Dock = DockStyle.Fill;
            telaProduto.Show();

            //this.Hide();
            //var telaProduto = new TelaProduto();
            //telaProduto.Closed += (s, args) => this.Close();
            //telaProduto.Show();
        }
    }
}
