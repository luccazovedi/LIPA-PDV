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
    public partial class RelatorioVenda : Form
    {
        public RelatorioVenda()
        {
            InitializeComponent();
        }

        private void RelatorioVenda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
