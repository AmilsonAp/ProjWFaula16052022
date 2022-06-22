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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void txtVendaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            //Carregar o Combo
            cboProduto.DataSource = new Service().FindAllProduto();
            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Descricao";

            cboCliente.DataSource = new Service().FindAllCliente();
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";          

            cboVendedor.DataSource = new Service().FindAllVendedor();
            cboVendedor.ValueMember = "Id";
            cboVendedor.DisplayMember = "Nome";          

        }

        private void btnVendaSalvar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda()
            {
                Produto = new Produto() { Id = Convert.ToInt32( cboProduto.SelectedValue.ToString()) },
                Cliente = new Cliente() { Id = Convert.ToInt32( cboCliente.SelectedValue.ToString()) },
                Vendedor = new Vendedor() { Id = Convert.ToInt32(cboVendedor.SelectedValue.ToString()) },           
            };

            Service service = new Service();

            service.AddVenda(venda);

            MessageBox.Show("Registro inserido com sucesso!");
        }

        private void btnVendaListar_Click(object sender, EventArgs e)
        {
            FrmConsultaVenda frmVenda = new FrmConsultaVenda();
            frmVenda.ShowDialog();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   
}
