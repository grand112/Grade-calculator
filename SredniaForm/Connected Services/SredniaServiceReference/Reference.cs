﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SredniaForm.SredniaServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SredniaServiceReference.ISredniaService")]
    public interface ISredniaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/ObliczSrednia", ReplyAction="http://tempuri.org/ISredniaService/ObliczSredniaResponse")]
        double ObliczSrednia(double[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/ObliczSrednia", ReplyAction="http://tempuri.org/ISredniaService/ObliczSredniaResponse")]
        System.Threading.Tasks.Task<double> ObliczSredniaAsync(double[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/CzyPoprawna", ReplyAction="http://tempuri.org/ISredniaService/CzyPoprawnaResponse")]
        string CzyPoprawna(double[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/CzyPoprawna", ReplyAction="http://tempuri.org/ISredniaService/CzyPoprawnaResponse")]
        System.Threading.Tasks.Task<string> CzyPoprawnaAsync(double[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/CzyZdane", ReplyAction="http://tempuri.org/ISredniaService/CzyZdaneResponse")]
        string CzyZdane(double srednia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISredniaService/CzyZdane", ReplyAction="http://tempuri.org/ISredniaService/CzyZdaneResponse")]
        System.Threading.Tasks.Task<string> CzyZdaneAsync(double srednia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISredniaServiceChannel : SredniaForm.SredniaServiceReference.ISredniaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SredniaServiceClient : System.ServiceModel.ClientBase<SredniaForm.SredniaServiceReference.ISredniaService>, SredniaForm.SredniaServiceReference.ISredniaService {
        
        public SredniaServiceClient() {
        }
        
        public SredniaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SredniaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SredniaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SredniaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ObliczSrednia(double[] args) {
            return base.Channel.ObliczSrednia(args);
        }
        
        public System.Threading.Tasks.Task<double> ObliczSredniaAsync(double[] args) {
            return base.Channel.ObliczSredniaAsync(args);
        }
        
        public string CzyPoprawna(double[] args) {
            return base.Channel.CzyPoprawna(args);
        }
        
        public System.Threading.Tasks.Task<string> CzyPoprawnaAsync(double[] args) {
            return base.Channel.CzyPoprawnaAsync(args);
        }
        
        public string CzyZdane(double srednia) {
            return base.Channel.CzyZdane(srednia);
        }
        
        public System.Threading.Tasks.Task<string> CzyZdaneAsync(double srednia) {
            return base.Channel.CzyZdaneAsync(srednia);
        }
    }
}
