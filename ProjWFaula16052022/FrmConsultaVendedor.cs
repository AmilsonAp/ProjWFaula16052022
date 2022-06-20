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
    public partial class FrmConsultaVendedor : Form
    {
        public FrmConsultaVendedor()
        {
            InitializeComponent();
        }

        private void FrmConsultaVendedor_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaVendedor_Load_1(object sender, EventArgs e)
        {
            dgvVendedor.DataSource = new Service().FindAllVendedor();
        }
    }
}
