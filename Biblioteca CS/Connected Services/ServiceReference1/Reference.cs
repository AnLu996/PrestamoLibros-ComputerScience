﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca_CS.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceProject1")]
    public interface IServiceProject1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/getCarreras", ReplyAction="http://tempuri.org/IServiceProject1/getCarrerasResponse")]
        string[] getCarreras();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/getCarreras", ReplyAction="http://tempuri.org/IServiceProject1/getCarrerasResponse")]
        System.Threading.Tasks.Task<string[]> getCarrerasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/InformacionUsuario", ReplyAction="http://tempuri.org/IServiceProject1/InformacionUsuarioResponse")]
        void InformacionUsuario(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/InformacionUsuario", ReplyAction="http://tempuri.org/IServiceProject1/InformacionUsuarioResponse")]
        System.Threading.Tasks.Task InformacionUsuarioAsync(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/Existe_Registro", ReplyAction="http://tempuri.org/IServiceProject1/Existe_RegistroResponse")]
        bool Existe_Registro(string nombres, string apellidos, string correo, int cui);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProject1/Existe_Registro", ReplyAction="http://tempuri.org/IServiceProject1/Existe_RegistroResponse")]
        System.Threading.Tasks.Task<bool> Existe_RegistroAsync(string nombres, string apellidos, string correo, int cui);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceProject1Channel : Biblioteca_CS.ServiceReference1.IServiceProject1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProject1Client : System.ServiceModel.ClientBase<Biblioteca_CS.ServiceReference1.IServiceProject1>, Biblioteca_CS.ServiceReference1.IServiceProject1 {
        
        public ServiceProject1Client() {
        }
        
        public ServiceProject1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProject1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProject1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProject1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getCarreras() {
            return base.Channel.getCarreras();
        }
        
        public System.Threading.Tasks.Task<string[]> getCarrerasAsync() {
            return base.Channel.getCarrerasAsync();
        }
        
        public void InformacionUsuario(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña) {
            base.Channel.InformacionUsuario(nombres, apellidos, cui, correo, carrera, rol, contraseña);
        }
        
        public System.Threading.Tasks.Task InformacionUsuarioAsync(string nombres, string apellidos, int cui, string correo, int carrera, string rol, string contraseña) {
            return base.Channel.InformacionUsuarioAsync(nombres, apellidos, cui, correo, carrera, rol, contraseña);
        }
        
        public bool Existe_Registro(string nombres, string apellidos, string correo, int cui) {
            return base.Channel.Existe_Registro(nombres, apellidos, correo, cui);
        }
        
        public System.Threading.Tasks.Task<bool> Existe_RegistroAsync(string nombres, string apellidos, string correo, int cui) {
            return base.Channel.Existe_RegistroAsync(nombres, apellidos, correo, cui);
        }
    }
}