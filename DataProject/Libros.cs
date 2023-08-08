using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public class Libros
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public void Ingregar_Libro(int code, int idioma, string titulo, string autor, int año, int edicion, string editorial, int categoria)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Libros VALUES(@Code, @Code_Lenguajes, @Titulo, @Autor, @Año, @Edicion, @Editorial, @Code_Categories)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Code", code);
                    command.Parameters.AddWithValue("@Code:Lenguajes", idioma);
                    command.Parameters.AddWithValue("@Titulo", titulo);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Año", año);
                    command.Parameters.AddWithValue("@Edicion", edicion);
                    command.Parameters.AddWithValue("@Editorial", editorial);
                    command.Parameters.AddWithValue("@Code_Categories", categoria);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool ExisteRegistro(int code, int idioma, string titulo, string autor, int año, int edicion, string editorial, int categoria)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Code FROM Usuarios WHERE code = @Code AND idioma = @Code_Lenguajes AND titulo = @Titulo AND autor = @Autor AND año = @Año AND edicion = @Edicion AND editorial = @Editorial AND categoria = @Code_Categories";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Code:Lenguajes", idioma);
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Autor", autor);
                        command.Parameters.AddWithValue("@Año", año);
                        command.Parameters.AddWithValue("@Edicion", edicion);
                        command.Parameters.AddWithValue("@Editorial", editorial);
                        command.Parameters.AddWithValue("@Code_Categories", categoria);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var dato = reader["Code"];
                                count = int.Parse(dato.ToString());
                            }
                        }
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la consulta: " + ex.Message);
                    return false;
                }
            }
        }
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

        internal IList<string> getCarrera()
        {
            throw new NotImplementedException();
        }
    }
}
