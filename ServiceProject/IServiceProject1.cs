using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProject1
    {
        [OperationContract]
        IList<String> getCarreras();

        [OperationContract]
        void RegistroUsuario(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña);

        [OperationContract]
        bool Existe_Registro(string nombres, string apellidos, string correo, int cui);
        
        [OperationContract]
        bool IniciarSesion(string correo, int cui, string password);

        [OperationContract]
        bool Existe_Usuario(string correo, int cui);


    }
}
