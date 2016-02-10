﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidateTryItPage.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Validate")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ValidateTryItPage.ServiceReference1.CompositeType GetDataUsingDataContract(ValidateTryItPage.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ValidateTryItPage.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ValidateTryItPage.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/emailValidate", ReplyAction="http://tempuri.org/IService1/emailValidateResponse")]
        bool emailValidate(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/emailValidate", ReplyAction="http://tempuri.org/IService1/emailValidateResponse")]
        System.Threading.Tasks.Task<bool> emailValidateAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/passwordValidate", ReplyAction="http://tempuri.org/IService1/passwordValidateResponse")]
        bool passwordValidate(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/passwordValidate", ReplyAction="http://tempuri.org/IService1/passwordValidateResponse")]
        System.Threading.Tasks.Task<bool> passwordValidateAsync(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/usernameValidate", ReplyAction="http://tempuri.org/IService1/usernameValidateResponse")]
        bool usernameValidate(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/usernameValidate", ReplyAction="http://tempuri.org/IService1/usernameValidateResponse")]
        System.Threading.Tasks.Task<bool> usernameValidateAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ValidateTryItPage.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ValidateTryItPage.ServiceReference1.IService1>, ValidateTryItPage.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ValidateTryItPage.ServiceReference1.CompositeType GetDataUsingDataContract(ValidateTryItPage.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ValidateTryItPage.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ValidateTryItPage.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool emailValidate(string text) {
            return base.Channel.emailValidate(text);
        }
        
        public System.Threading.Tasks.Task<bool> emailValidateAsync(string text) {
            return base.Channel.emailValidateAsync(text);
        }
        
        public bool passwordValidate(string password) {
            return base.Channel.passwordValidate(password);
        }
        
        public System.Threading.Tasks.Task<bool> passwordValidateAsync(string password) {
            return base.Channel.passwordValidateAsync(password);
        }
        
        public bool usernameValidate(string username) {
            return base.Channel.usernameValidate(username);
        }
        
        public System.Threading.Tasks.Task<bool> usernameValidateAsync(string username) {
            return base.Channel.usernameValidateAsync(username);
        }
    }
}
