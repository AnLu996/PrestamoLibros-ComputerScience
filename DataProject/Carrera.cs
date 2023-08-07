using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class Carrera
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public IList<string> getCarrera()
        {
            List<string> carreras = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select Carrera from Carreras";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string carrera = reader.GetString(0);
                        carreras.Add(carrera);
                    }

                    reader.Close();
                }
            }
            return carreras;
        }
    }
}
