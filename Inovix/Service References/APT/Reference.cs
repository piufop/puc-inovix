﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inovix.APT {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="APT.IAPTService")]
    public interface IAPTService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAPTService/SolicitarBilhetePortabilidade", ReplyAction="http://tempuri.org/IAPTService/SolicitarBilhetePortabilidadeResponse")]
        Inovix.Data.Portability.PortabilityTicket SolicitarBilhetePortabilidade(Inovix.Data.Customer customer, Inovix.Data.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAPTService/SolicitarBilhetePortabilidade", ReplyAction="http://tempuri.org/IAPTService/SolicitarBilhetePortabilidadeResponse")]
        System.Threading.Tasks.Task<Inovix.Data.Portability.PortabilityTicket> SolicitarBilhetePortabilidadeAsync(Inovix.Data.Customer customer, Inovix.Data.Account account);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAPTServiceChannel : Inovix.APT.IAPTService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class APTServiceClient : System.ServiceModel.ClientBase<Inovix.APT.IAPTService>, Inovix.APT.IAPTService {
        
        public APTServiceClient() {
        }
        
        public APTServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public APTServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APTServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APTServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Inovix.Data.Portability.PortabilityTicket SolicitarBilhetePortabilidade(Inovix.Data.Customer customer, Inovix.Data.Account account) {
            return base.Channel.SolicitarBilhetePortabilidade(customer, account);
        }
        
        public System.Threading.Tasks.Task<Inovix.Data.Portability.PortabilityTicket> SolicitarBilhetePortabilidadeAsync(Inovix.Data.Customer customer, Inovix.Data.Account account) {
            return base.Channel.SolicitarBilhetePortabilidadeAsync(customer, account);
        }
    }
}