using Models;
using System.Data.SqlClient;

namespace Services
{
    public class Service
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\Amilson\source\repos\ProjEventos\Banco\bdclient.mdf;";

        public void AddCliente(Cliente cliente) {
            
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            //Exemplo Insert
            string strInsert = "insert into Cliente (Id, Nome, Telefone) values (@Id, @Nome, @Telefone)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", cliente.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public List<Cliente> FindAllCliente() {
            List<Cliente> listClientes = new List<Cliente>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Nome, Telefone from Cliente";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nNome: " + dr["Nome"] + "\nTelefone: " + dr["Telefone"]);
                listClientes.Add(new Cliente() { 
                    Id = Convert.ToInt32(dr["Id"]), 
                    Nome = dr["Nome"].ToString(), 
                    Telefone = dr["Telefone"].ToString()}
                );
            }
            conn.Close();
            return listClientes;
        }

        public void AddVendedor(Vendedor vendedor)
        {

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            //Exemplo Insert
            string strInsert = "insert into Vendedor (Id, Nome, Telefone) values (@Id, @Nome, @Telefone)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", vendedor.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Nome", vendedor.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", vendedor.Telefone));

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public List<Vendedor> FindAllVendedor()
        {
            List<Vendedor> listVendedor = new List<Vendedor>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Nome, Telefone from Vendedor";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nNome: " + dr["Nome"] + "\nTelefone: " + dr["Telefone"]);
                listVendedor.Add(new Vendedor()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nome = dr["Nome"].ToString(),
                    Telefone = dr["Telefone"].ToString()
                }
                );
            }
            conn.Close();
            return listVendedor;
        }

        public void AddProduto(Produto produto)
        {

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            //Exemplo Insert
            string strInsert = "insert into Produto (Id, Descricao) values (@Id, @Descricao)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", produto.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Descricao", produto.Descricao));            

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public List<Produto> FindAllProduto()
        {
            List<Produto> listProduto = new List<Produto>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Descricao from Produto";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nDescricao: " + dr["Descricao"]);
                listProduto.Add(new Produto()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Descricao = dr["Descricao"].ToString(),
                }
                );
            }
            conn.Close();
            return listProduto;

        }

        public void AddEstoque(Estoque estoque)
        {

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            //Exemplo Insert
            string strInsert = "insert into Estoque (Id, Descricao) values (@Id, @Descricao)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", estoque.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Descricao", estoque.Descricao));

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public List<Estoque> FindAllEstoque()
        {
            List<Estoque> listEstoque = new List<Estoque>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Descricao from Estoque";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nDescricao: " + dr["Descricao"]);
                listEstoque.Add(new Estoque()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Descricao = dr["Descricao"].ToString(),
                }
                );
            }
            conn.Close();
            return listEstoque;

        }

        public void AddVenda(Venda venda)
        {

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            //Exemplo Insert
            string strInsert = "insert into Venda (Produto, Cliente, Vendedor) values (@Produto, @Cliente, @Vendedor)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Produto", venda.Produto.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Cliente", venda.Cliente.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Vendedor", venda.Vendedor.Id));

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public List<Venda> FindAllVenda()
        {
            List<Venda> listVenda = new List<Venda>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Produto, Cliente, Vendedor from Venda";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Produto: " + dr["Produto"] + "\nCliente: " + dr["Cliente"] + "\nVendedor: " + dr["Vendedor"]);
                listVenda.Add(new Venda()
                {
                    Produto = new Produto() { Id = Convert.ToInt32(dr["Produto"]) },
                    Cliente = new Cliente() { Id = Convert.ToInt32(dr["Cliente"]) },
                    Vendedor = new Vendedor() { Id = Convert.ToInt32(dr["Vendedor"]) },
                }
                );
            }
            conn.Close();
            return listVenda;

        }
    }
}