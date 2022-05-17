using Models;
using System.Data.SqlClient;

namespace Services
{
    public class ClienteService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\Amilson\source\repos\ProjEventos\Banco\bdclient.mdf;";

        public void Add(Cliente cliente) {
            
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

        public List<Cliente> FindAll() {
            List<Cliente> list = new List<Cliente>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Nome, Telefone from Cliente";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nNome: " + dr["Nome"] + "\nTelefone: " + dr["Telefone"]);
                list.Add(new Cliente() { 
                    Id = Convert.ToInt32(dr["Id"]), 
                    Nome = dr["Nome"].ToString(), 
                    Telefone = dr["Telefone"].ToString()}
                );
            }
            conn.Close();
            return list;
        }
    }
}