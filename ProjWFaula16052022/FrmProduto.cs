using Models;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = int.Parse(txtIdProd.Text),
                Descricao = txtDescProd.Text,
            };

            Service service = new Service();

            service.AddProduto(produto);

            MessageBox.Show("Registro inserido com sucesso!");
        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto frmProduto = new FrmConsultaProduto();
            frmProduto.ShowDialog();
        }
    }
}
