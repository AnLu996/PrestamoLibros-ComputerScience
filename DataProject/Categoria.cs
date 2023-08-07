using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class Categoria
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public IList<string> getCategoria()
        {
            List<string> categorias = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select Categories from Categorias";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string categoria = reader.GetString(0);
                        categorias.Add(categoria);
                    }

                    reader.Close();
                }
            }
            return categorias;
        }
    }
}
