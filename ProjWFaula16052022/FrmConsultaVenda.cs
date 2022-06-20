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
    public partial class FrmConsultaVenda : Form
    {
        public FrmConsultaVenda()
        {
            InitializeComponent();
        }

        private void FrmConsultaVenda_Load(object sender, EventArgs e)
        {
            dgvVenda.DataSource = new Service().FindAllVenda();
        }
    }
}
