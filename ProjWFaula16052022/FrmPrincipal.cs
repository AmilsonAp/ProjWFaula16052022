using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFaula16052022
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes cli = new FrmClientes();
            cli.MdiParent = this;
            cli.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto prod = new FrmProduto();
            prod.MdiParent = this;
            prod.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor vend = new FrmVendedor();
            vend.MdiParent = this;
            vend.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            est.MdiParent = this;
            est.Show();
        }

        private void vendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVenda est = new FrmVenda();
            est.MdiParent = this;
            est.Show();
        }
    }
}
