﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARTheamF.KnetService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestModel", Namespace="http://schemas.datacontract.org/2004/07/KNETService")]
    [System.SerializableAttribute()]
    public partial class RequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ARTheamF.KnetService.Configuration KNETConfigField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReffNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF5Field;
        
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
        public double Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ARTheamF.KnetService.Configuration KNETConfig {
            get {
                return this.KNETConfigField;
            }
            set {
                if ((object.ReferenceEquals(this.KNETConfigField, value) != true)) {
                    this.KNETConfigField = value;
                    this.RaisePropertyChanged("KNETConfig");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReffNo {
            get {
                return this.ReffNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ReffNoField, value) != true)) {
                    this.ReffNoField = value;
                    this.RaisePropertyChanged("ReffNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF1 {
            get {
                return this.UDF1Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF1Field, value) != true)) {
                    this.UDF1Field = value;
                    this.RaisePropertyChanged("UDF1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF2 {
            get {
                return this.UDF2Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF2Field, value) != true)) {
                    this.UDF2Field = value;
                    this.RaisePropertyChanged("UDF2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF3 {
            get {
                return this.UDF3Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF3Field, value) != true)) {
                    this.UDF3Field = value;
                    this.RaisePropertyChanged("UDF3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF4 {
            get {
                return this.UDF4Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF4Field, value) != true)) {
                    this.UDF4Field = value;
                    this.RaisePropertyChanged("UDF4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF5 {
            get {
                return this.UDF5Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF5Field, value) != true)) {
                    this.UDF5Field = value;
                    this.RaisePropertyChanged("UDF5");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Configuration", Namespace="http://schemas.datacontract.org/2004/07/KNETService")]
    [System.SerializableAttribute()]
    public partial class Configuration : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KnetCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResourcePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseURLField;
        
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
        public string AliasName {
            get {
                return this.AliasNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasNameField, value) != true)) {
                    this.AliasNameField = value;
                    this.RaisePropertyChanged("AliasName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorURL {
            get {
                return this.ErrorURLField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorURLField, value) != true)) {
                    this.ErrorURLField = value;
                    this.RaisePropertyChanged("ErrorURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KnetCurrency {
            get {
                return this.KnetCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.KnetCurrencyField, value) != true)) {
                    this.KnetCurrencyField = value;
                    this.RaisePropertyChanged("KnetCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResourcePath {
            get {
                return this.ResourcePathField;
            }
            set {
                if ((object.ReferenceEquals(this.ResourcePathField, value) != true)) {
                    this.ResourcePathField = value;
                    this.RaisePropertyChanged("ResourcePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponseURL {
            get {
                return this.ResponseURLField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseURLField, value) != true)) {
                    this.ResponseURLField = value;
                    this.RaisePropertyChanged("ResponseURL");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseModel", Namespace="http://schemas.datacontract.org/2004/07/KNETService")]
    [System.SerializableAttribute()]
    public partial class ResponseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PayReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaymentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RedirectionURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UDF5Field;
        
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
        public string Auth {
            get {
                return this.AuthField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthField, value) != true)) {
                    this.AuthField = value;
                    this.RaisePropertyChanged("Auth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PayReference {
            get {
                return this.PayReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.PayReferenceField, value) != true)) {
                    this.PayReferenceField = value;
                    this.RaisePropertyChanged("PayReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentId {
            get {
                return this.PaymentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PaymentIdField, value) != true)) {
                    this.PaymentIdField = value;
                    this.RaisePropertyChanged("PaymentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RedirectionURL {
            get {
                return this.RedirectionURLField;
            }
            set {
                if ((object.ReferenceEquals(this.RedirectionURLField, value) != true)) {
                    this.RedirectionURLField = value;
                    this.RaisePropertyChanged("RedirectionURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reference {
            get {
                return this.ReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceField, value) != true)) {
                    this.ReferenceField = value;
                    this.RaisePropertyChanged("Reference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransID {
            get {
                return this.TransIDField;
            }
            set {
                if ((object.ReferenceEquals(this.TransIDField, value) != true)) {
                    this.TransIDField = value;
                    this.RaisePropertyChanged("TransID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF1 {
            get {
                return this.UDF1Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF1Field, value) != true)) {
                    this.UDF1Field = value;
                    this.RaisePropertyChanged("UDF1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF2 {
            get {
                return this.UDF2Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF2Field, value) != true)) {
                    this.UDF2Field = value;
                    this.RaisePropertyChanged("UDF2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF3 {
            get {
                return this.UDF3Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF3Field, value) != true)) {
                    this.UDF3Field = value;
                    this.RaisePropertyChanged("UDF3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF4 {
            get {
                return this.UDF4Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF4Field, value) != true)) {
                    this.UDF4Field = value;
                    this.RaisePropertyChanged("UDF4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UDF5 {
            get {
                return this.UDF5Field;
            }
            set {
                if ((object.ReferenceEquals(this.UDF5Field, value) != true)) {
                    this.UDF5Field = value;
                    this.RaisePropertyChanged("UDF5");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KnetService.IKNETService")]
    public interface IKNETService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKNETService/InitPayment", ReplyAction="http://tempuri.org/IKNETService/InitPaymentResponse")]
        ARTheamF.KnetService.ResponseModel InitPayment(ARTheamF.KnetService.RequestModel objRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKNETService/InitPayment", ReplyAction="http://tempuri.org/IKNETService/InitPaymentResponse")]
        System.Threading.Tasks.Task<ARTheamF.KnetService.ResponseModel> InitPaymentAsync(ARTheamF.KnetService.RequestModel objRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKNETService/RetrievePaymentData", ReplyAction="http://tempuri.org/IKNETService/RetrievePaymentDataResponse")]
        ARTheamF.KnetService.ResponseModel RetrievePaymentData(ARTheamF.KnetService.RequestModel objRequest, string transData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKNETService/RetrievePaymentData", ReplyAction="http://tempuri.org/IKNETService/RetrievePaymentDataResponse")]
        System.Threading.Tasks.Task<ARTheamF.KnetService.ResponseModel> RetrievePaymentDataAsync(ARTheamF.KnetService.RequestModel objRequest, string transData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKNETServiceChannel : ARTheamF.KnetService.IKNETService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KNETServiceClient : System.ServiceModel.ClientBase<ARTheamF.KnetService.IKNETService>, ARTheamF.KnetService.IKNETService {
        
        public KNETServiceClient() {
        }
        
        public KNETServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KNETServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KNETServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KNETServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ARTheamF.KnetService.ResponseModel InitPayment(ARTheamF.KnetService.RequestModel objRequest) {
            return base.Channel.InitPayment(objRequest);
        }
        
        public System.Threading.Tasks.Task<ARTheamF.KnetService.ResponseModel> InitPaymentAsync(ARTheamF.KnetService.RequestModel objRequest) {
            return base.Channel.InitPaymentAsync(objRequest);
        }
        
        public ARTheamF.KnetService.ResponseModel RetrievePaymentData(ARTheamF.KnetService.RequestModel objRequest, string transData) {
            return base.Channel.RetrievePaymentData(objRequest, transData);
        }
        
        public System.Threading.Tasks.Task<ARTheamF.KnetService.ResponseModel> RetrievePaymentDataAsync(ARTheamF.KnetService.RequestModel objRequest, string transData) {
            return base.Channel.RetrievePaymentDataAsync(objRequest, transData);
        }
    }
}