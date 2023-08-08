using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;


namespace DataProject
{
    public class Usuarios
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPrestamoLibros;Integrated Security=True";

        public string EncriptarContraseña(string password) //algoritmo de hashing
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            int iterations = 1000;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashWithSalt = new byte[36];
                Array.Copy(salt, 0, hashWithSalt, 0, 16);
                Array.Copy(hash, 0, hashWithSalt, 16, 20);
                string encryptedPassword = Convert.ToBase64String(hashWithSalt);

                return encryptedPassword;
            }
        }

        public bool VerificarContraseña(string password, string encryptedPassword) //algoritmo de hashing
        {
            byte[] hashWithSalt = Convert.FromBase64String(encryptedPassword);

            byte[] salt = new byte[16];
            byte[] hash = new byte[20];
            Array.Copy(hashWithSalt, 0, salt, 0, 16);
            Array.Copy(hashWithSalt, 16, hash, 0, 20);

            int iterations = 1000;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] newHash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hash[i] != newHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public void Ingregar_Usuario(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Usuarios VALUES(@Nombres, @Apellidos, @CUI, @Correo, @Carrera, @Rol, @Contrasena)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    string encryptedPassword = EncriptarContraseña(contraseña);

                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@CUI", cui);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Carrera", carrera);
                    command.Parameters.AddWithValue("@Rol", rol);
                    command.Parameters.AddWithValue("@Contrasena", encryptedPassword);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool Existe_Registro(string nombres, string apellidos, string correo, int cui)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Code FROM Usuarios WHERE Nombres = @Nombres AND Apellidos = @Apellidos AND CUI = @CUI AND Correo = @Correo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombres", nombres);
                        command.Parameters.AddWithValue("@Apellidos", apellidos);
                        command.Parameters.AddWithValue("@CUI", cui);
                        command.Parameters.AddWithValue("@Correo", correo);

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

        public bool ExisteUsuario(string correo, int cui)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Code FROM Usuarios WHERE CUI = @CUI AND Correo = @Correo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CUI", cui);
                        command.Parameters.AddWithValue("@Correo", correo);

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

        public bool Iniciar_Usuario(string email, int cui, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT contrasena FROM Usuarios WHERE cui = @CUI AND email = @Correo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@CUI", cui);
                    command.Parameters.AddWithValue("@Correo", email);

                    string contraseñaEncriptada = (string)command.ExecuteScalar();
                    bool isPasswordCorrect = VerificarContraseña(password, contraseñaEncriptada);

                    if (isPasswordCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error en la consulta:");
                        return false;
                    }
                }
            }
        }

        public IList<string> getCarrera()
        {
            List<string> carreras = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Carrera FROM Carreras";

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

        /*public void Cambiar_Contraseña(int id, string contra)
        {
            string connectionString = "Data Source=ARLEEN;" +
                "Initial Catalog=CitasMedicas;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Update_Contrasena", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Contrasena", contra);

                command.ExecuteNonQuery();
                connection.Close();
            }


        }*/
    }
}
