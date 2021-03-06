﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LR40_WCF_Client.MathService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathService.IMath")]
    public interface IMath {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Factorial", ReplyAction="http://tempuri.org/IMath/FactorialResponse")]
        int Factorial(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Factorial", ReplyAction="http://tempuri.org/IMath/FactorialResponse")]
        System.Threading.Tasks.Task<int> FactorialAsync(int num);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathChannel : LR40_WCF_Client.MathService.IMath, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathClient : System.ServiceModel.ClientBase<LR40_WCF_Client.MathService.IMath>, LR40_WCF_Client.MathService.IMath {
        
        public MathClient() {
        }
        
        public MathClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Factorial(int num) {
            return base.Channel.Factorial(num);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int num) {
            return base.Channel.FactorialAsync(num);
        }
    }
}
