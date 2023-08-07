using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class Lenguaje
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public IList<string> getLenguaje()
        {
            List<string> lenguajes = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select Lenguajes from Lenguajes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string lenguaje = reader.GetString(0);
                        lenguajes.Add(lenguaje);
                    }

                    reader.Close();
                }
            }
            return lenguajes;
        }
    }
}
