using DataProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServiceProject1
    {
        public IList<String> getCarreras()
        {
            Carrera carreras = new Carrera();
            IList<String> carrera = carreras.getCarrera();
            return carrera;
        }

        public void InformacionUsuario(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña)
        {
            Usuarios dataAlumnos = new Usuarios();
            dataAlumnos.Ingregar_Usuario(nombres, apellidos, cui, correo, carrera, rol, contraseña);
        }

        public bool Existe_Registro(string nombres, string apellidos, string correo, int cui)
        { 
            Usuarios dataAlumnos = new Usuarios();
            return dataAlumnos.ExisteRegistro(nombres, apellidos, correo, cui);
        }
    }
}
