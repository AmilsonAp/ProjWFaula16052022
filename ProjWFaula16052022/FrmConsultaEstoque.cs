using Services;
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
    public partial class FrmConsultaEstoque : Form
    {
        public FrmConsultaEstoque()
        {
            InitializeComponent();

        }

        private void FrmConsultaEstoque_Load(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = new Service().FindAllEstoque();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaEstoque_Load_1(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = new Service().FindAllProduto();
        }
    }
}
