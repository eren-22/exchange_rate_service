﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KurlarMvc.KurServis {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KurServis.IKurServis")]
    public interface IKurServis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurServis/paraBirimleriGetir", ReplyAction="http://tempuri.org/IKurServis/paraBirimleriGetirResponse")]
        string[] paraBirimleriGetir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurServis/paraBirimleriGetir", ReplyAction="http://tempuri.org/IKurServis/paraBirimleriGetirResponse")]
        System.Threading.Tasks.Task<string[]> paraBirimleriGetirAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurServis/kurlariGetir", ReplyAction="http://tempuri.org/IKurServis/kurlariGetirResponse")]
        double[] kurlariGetir(string kurTipi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurServis/kurlariGetir", ReplyAction="http://tempuri.org/IKurServis/kurlariGetirResponse")]
        System.Threading.Tasks.Task<double[]> kurlariGetirAsync(string kurTipi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKurServisChannel : KurlarMvc.KurServis.IKurServis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KurServisClient : System.ServiceModel.ClientBase<KurlarMvc.KurServis.IKurServis>, KurlarMvc.KurServis.IKurServis {
        
        public KurServisClient() {
        }
        
        public KurServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KurServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KurServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KurServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] paraBirimleriGetir() {
            return base.Channel.paraBirimleriGetir();
        }
        
        public System.Threading.Tasks.Task<string[]> paraBirimleriGetirAsync() {
            return base.Channel.paraBirimleriGetirAsync();
        }
        
        public double[] kurlariGetir(string kurTipi) {
            return base.Channel.kurlariGetir(kurTipi);
        }
        
        public System.Threading.Tasks.Task<double[]> kurlariGetirAsync(string kurTipi) {
            return base.Channel.kurlariGetirAsync(kurTipi);
        }
    }
}