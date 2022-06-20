using Models;
using System.Data.SqlClient;

namespace Services
{
    public class ServiceBase
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\Amilson\source\repos\ProjEventos\Banco\bdclient.mdf;";
        public List<Vendedor> FindAll()
        {
            List<Vendedor> list = new List<Vendedor>();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string strSelect = "select Id, Nome, Telefone from Cliente";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                //Console.WriteLine("Id: " + dr["Id"] + "\nNome: " + dr["Nome"] + "\nTelefone: " + dr["Telefone"]);
                list.Add(new Vendedor()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nome = dr["Nome"].ToString(),
                    Telefone = dr["Telefone"].ToString()
                }
                );
            }
            conn.Close();
            return list;
        }
    }
}