﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FridgeClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.IFridge")]
    public interface IFridge {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/AddFood", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/AddFoodResponse")]
        void AddFood(int quantity, string food);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/AddFood", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/AddFoodResponse")]
        System.Threading.Tasks.Task AddFoodAsync(int quantity, string food);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/SubtractFood", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/SubtractFoodResponse")]
        void SubtractFood(int quantity, string food);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/SubtractFood", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/SubtractFoodResponse")]
        System.Threading.Tasks.Task SubtractFoodAsync(int quantity, string food);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/Food", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/FoodResponse")]
        System.Collections.Generic.Dictionary<string, int> Food();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/Food", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/FoodResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> FoodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/EmptyFridge", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/EmptyFridgeResponse")]
        void EmptyFridge();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IFridge/EmptyFridge", ReplyAction="http://Microsoft.ServiceModel.Samples/IFridge/EmptyFridgeResponse")]
        System.Threading.Tasks.Task EmptyFridgeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFridgeChannel : FridgeClient.ServiceReference1.IFridge, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FridgeClient : System.ServiceModel.ClientBase<FridgeClient.ServiceReference1.IFridge>, FridgeClient.ServiceReference1.IFridge {
        
        public FridgeClient() {
        }
        
        public FridgeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FridgeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FridgeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FridgeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddFood(int quantity, string food) {
            base.Channel.AddFood(quantity, food);
        }
        
        public System.Threading.Tasks.Task AddFoodAsync(int quantity, string food) {
            return base.Channel.AddFoodAsync(quantity, food);
        }
        
        public void SubtractFood(int quantity, string food) {
            base.Channel.SubtractFood(quantity, food);
        }
        
        public System.Threading.Tasks.Task SubtractFoodAsync(int quantity, string food) {
            return base.Channel.SubtractFoodAsync(quantity, food);
        }
        
        public System.Collections.Generic.Dictionary<string, int> Food() {
            return base.Channel.Food();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> FoodAsync() {
            return base.Channel.FoodAsync();
        }
        
        public void EmptyFridge() {
            base.Channel.EmptyFridge();
        }
        
        public System.Threading.Tasks.Task EmptyFridgeAsync() {
            return base.Channel.EmptyFridgeAsync();
        }
    }
}
