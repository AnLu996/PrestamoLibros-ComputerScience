using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    class DBconnection
    {
        public static void Main(string[] args)
        {
            DBconnection dBconnection = new DBconnection();
            dBconnection.query();

            Console.ReadKey();
        }

        private void query()
        {
            Usuarios carrera = new Usuarios();
            IList<string> carreras = carrera.getCarrera();

            if (carreras == null)
            {
                Console.WriteLine("No data");
                return;
            }
            for (int i = 0; i < carreras.Count; i++)
            {
                Console.WriteLine(carreras[i]);
            }
            Usuarios dataAlumnos = new Usuarios();
            dataAlumnos.Ingregar_Usuario("Andrea", "Cuela Morales", 2022150, "acuelam@unsa.edu.pe", 1, "Estudiante", "uwu");
            Console.WriteLine(dataAlumnos.ExisteRegistro("Giomar", "Muñoz Curi", "gmunoz@unsa.edu.pe", 20222150));

            Libros categoria = new Libros();
            IList<string> categorias = categoria.getCategoria();

            if (categorias == null)
            {
                Console.WriteLine("No data");
                return;
            }
            for (int i = 0; i < categorias.Count; i++)
            {
                Console.WriteLine(categorias[i]);
            }

            Libros lenguaje = new Libros();
        }
    }
}
