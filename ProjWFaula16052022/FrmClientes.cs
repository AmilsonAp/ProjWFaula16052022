using Models;
using Services;

namespace ProjWFaula16052022
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmClientes = new FrmConsultaClientes();
            frmClientes.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
            };

            Service service = new Service();

            service.AddCliente(cliente);

            MessageBox.Show("Registro inserido com sucesso!");
        }

        private void cbxOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}