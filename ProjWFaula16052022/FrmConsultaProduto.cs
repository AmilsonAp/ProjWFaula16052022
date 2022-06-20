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
    public partial class FrmConsultaProduto : Form
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            
        }
        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmConsultaProduto_Load_1(object sender, EventArgs e)
        {
            dgvProduto.DataSource = new Service().FindAllProduto();
        }
    }
}
