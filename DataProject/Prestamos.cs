using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class Prestamos
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public void Ingresar_Prestamo(string titulo, string autor, int cui, DateTime fechaprestamo, DateTime fechaentrega)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT Code FROM Usuarios WHERE cui = @CUI";
                string query2 = "SELECT [Index] FROM Libros WHERE titulo = @Titulo AND autor = @Autor";
                string insertQuery = "INSERT INTO Prestamos VALUES(@Code_CUI, @Code_Libro, @FechaPrestamo, @FechaEntrega)";

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                using (SqlCommand command3 = new SqlCommand(insertQuery, connection))
                {
                    command1.Parameters.AddWithValue("@CUI", cui);
                    command2.Parameters.AddWithValue("@Titulo", titulo);
                    command2.Parameters.AddWithValue("@Autor", autor);

                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            int datoUser = reader1.GetInt32(0);
                            command3.Parameters.AddWithValue("@Code_CUI", datoUser);

                            using (SqlDataReader reader2 = command2.ExecuteReader())
                            {
                                if (reader2.Read())
                                {
                                    int datoLibro = reader2.GetInt32(0);
                                    command3.Parameters.AddWithValue("@Code_Libro", datoLibro);

                                    command3.Parameters.AddWithValue("@FechaPrestamo", fechaprestamo);
                                    command3.Parameters.AddWithValue("@FechaEntrega", fechaentrega);

                                    reader2.Close(); 
                                    reader1.Close(); 

                                    command3.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
