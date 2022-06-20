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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmConsultaVendedor frmVendedor = new FrmConsultaVendedor();
            frmVendedor.ShowDialog();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor()
            {
                Id = int.Parse(txtIdVendedor.Text),
                Nome = txtNomeVendedor.Text,
                Telefone = txtTelefoneVendedor.Text,
            };

            Service service = new Service();

            service.AddVendedor(vendedor);

            MessageBox.Show("Registro inserido com sucesso!");
        }
    }
}
