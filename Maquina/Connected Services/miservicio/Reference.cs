//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maquina.miservicio {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="miservicio.ServicioSoap")]
    public interface ServicioSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodasMaquinas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ObtenerTodasMaquinas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodasMaquinas", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerTodasMaquinasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarAlquiler", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertarAlquiler(string usuario, string cliente, string idmaquina, string fecha_devolucion, string correo2, string precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarAlquiler", ReplyAction="*")]
        System.Threading.Tasks.Task insertarAlquilerAsync(string usuario, string cliente, string idmaquina, string fecha_devolucion, string correo2, string precio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioSoapChannel : Maquina.miservicio.ServicioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioSoapClient : System.ServiceModel.ClientBase<Maquina.miservicio.ServicioSoap>, Maquina.miservicio.ServicioSoap {
        
        public ServicioSoapClient() {
        }
        
        public ServicioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet ObtenerTodasMaquinas() {
            return base.Channel.ObtenerTodasMaquinas();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerTodasMaquinasAsync() {
            return base.Channel.ObtenerTodasMaquinasAsync();
        }
        
        public void insertarAlquiler(string usuario, string cliente, string idmaquina, string fecha_devolucion, string correo2, string precio) {
            base.Channel.insertarAlquiler(usuario, cliente, idmaquina, fecha_devolucion, correo2, precio);
        }
        
        public System.Threading.Tasks.Task insertarAlquilerAsync(string usuario, string cliente, string idmaquina, string fecha_devolucion, string correo2, string precio) {
            return base.Channel.insertarAlquilerAsync(usuario, cliente, idmaquina, fecha_devolucion, correo2, precio);
        }
    }
}
