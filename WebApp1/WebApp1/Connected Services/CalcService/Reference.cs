﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp1.CalcService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        double Add(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        double Subtract(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiply", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyResponse")]
        double Multiply(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiply", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Divide", ReplyAction="http://tempuri.org/ICalculatorService/DivideResponse")]
        double Divide(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Divide", ReplyAction="http://tempuri.org/ICalculatorService/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(int value1, int value2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : WebApp1.CalcService.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<WebApp1.CalcService.ICalculatorService>, WebApp1.CalcService.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(int value1, int value2) {
            return base.Channel.Add(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(int value1, int value2) {
            return base.Channel.AddAsync(value1, value2);
        }
        
        public double Subtract(int value1, int value2) {
            return base.Channel.Subtract(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(int value1, int value2) {
            return base.Channel.SubtractAsync(value1, value2);
        }
        
        public double Multiply(int value1, int value2) {
            return base.Channel.Multiply(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(int value1, int value2) {
            return base.Channel.MultiplyAsync(value1, value2);
        }
        
        public double Divide(int value1, int value2) {
            return base.Channel.Divide(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(int value1, int value2) {
            return base.Channel.DivideAsync(value1, value2);
        }
    }
}
