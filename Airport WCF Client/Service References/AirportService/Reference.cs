﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport_WCF_Client.AirportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vol", Namespace="http://schemas.datacontract.org/2004/07/AirportEntities")]
    [System.SerializableAttribute()]
    public partial class Vol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string companyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idVolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime lastTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int lineNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parkingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public string company {
            get {
                return this.companyField;
            }
            set {
                if ((object.ReferenceEquals(this.companyField, value) != true)) {
                    this.companyField = value;
                    this.RaisePropertyChanged("company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idVol {
            get {
                return this.idVolField;
            }
            set {
                if ((this.idVolField.Equals(value) != true)) {
                    this.idVolField = value;
                    this.RaisePropertyChanged("idVol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastTime {
            get {
                return this.lastTimeField;
            }
            set {
                if ((this.lastTimeField.Equals(value) != true)) {
                    this.lastTimeField = value;
                    this.RaisePropertyChanged("lastTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int lineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                if ((this.lineNumberField.Equals(value) != true)) {
                    this.lineNumberField = value;
                    this.RaisePropertyChanged("lineNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parking {
            get {
                return this.parkingField;
            }
            set {
                if ((object.ReferenceEquals(this.parkingField, value) != true)) {
                    this.parkingField = value;
                    this.RaisePropertyChanged("parking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Bagage", Namespace="http://schemas.datacontract.org/2004/07/AirportEntities")]
    [System.SerializableAttribute()]
    public partial class Bagage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeIataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string compagnieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateCreationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBagageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idVolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string itineraireField;
        
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
        public string codeIata {
            get {
                return this.codeIataField;
            }
            set {
                if ((object.ReferenceEquals(this.codeIataField, value) != true)) {
                    this.codeIataField = value;
                    this.RaisePropertyChanged("codeIata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string compagnie {
            get {
                return this.compagnieField;
            }
            set {
                if ((object.ReferenceEquals(this.compagnieField, value) != true)) {
                    this.compagnieField = value;
                    this.RaisePropertyChanged("compagnie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateCreation {
            get {
                return this.dateCreationField;
            }
            set {
                if ((this.dateCreationField.Equals(value) != true)) {
                    this.dateCreationField = value;
                    this.RaisePropertyChanged("dateCreation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idBagage {
            get {
                return this.idBagageField;
            }
            set {
                if ((this.idBagageField.Equals(value) != true)) {
                    this.idBagageField = value;
                    this.RaisePropertyChanged("idBagage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idVol {
            get {
                return this.idVolField;
            }
            set {
                if ((this.idVolField.Equals(value) != true)) {
                    this.idVolField = value;
                    this.RaisePropertyChanged("idVol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string itineraire {
            get {
                return this.itineraireField;
            }
            set {
                if ((object.ReferenceEquals(this.itineraireField, value) != true)) {
                    this.itineraireField = value;
                    this.RaisePropertyChanged("itineraire");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AirportService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVol", ReplyAction="http://tempuri.org/IService1/GetVolResponse")]
        Airport_WCF_Client.AirportService.Vol GetVol(int idVol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVol", ReplyAction="http://tempuri.org/IService1/GetVolResponse")]
        System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Vol> GetVolAsync(int idVol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBagage", ReplyAction="http://tempuri.org/IService1/GetBagageResponse")]
        Airport_WCF_Client.AirportService.Bagage GetBagage(int idBagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBagage", ReplyAction="http://tempuri.org/IService1/GetBagageResponse")]
        System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Bagage> GetBagageAsync(int idBagage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBagagesFromVol", ReplyAction="http://tempuri.org/IService1/GetBagagesFromVolResponse")]
        Airport_WCF_Client.AirportService.Bagage[] GetBagagesFromVol(int idVol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBagagesFromVol", ReplyAction="http://tempuri.org/IService1/GetBagagesFromVolResponse")]
        System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Bagage[]> GetBagagesFromVolAsync(int idVol);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Airport_WCF_Client.AirportService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Airport_WCF_Client.AirportService.IService1>, Airport_WCF_Client.AirportService.IService1 {
        
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
        
        public Airport_WCF_Client.AirportService.Vol GetVol(int idVol) {
            return base.Channel.GetVol(idVol);
        }
        
        public System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Vol> GetVolAsync(int idVol) {
            return base.Channel.GetVolAsync(idVol);
        }
        
        public Airport_WCF_Client.AirportService.Bagage GetBagage(int idBagage) {
            return base.Channel.GetBagage(idBagage);
        }
        
        public System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Bagage> GetBagageAsync(int idBagage) {
            return base.Channel.GetBagageAsync(idBagage);
        }
        
        public Airport_WCF_Client.AirportService.Bagage[] GetBagagesFromVol(int idVol) {
            return base.Channel.GetBagagesFromVol(idVol);
        }
        
        public System.Threading.Tasks.Task<Airport_WCF_Client.AirportService.Bagage[]> GetBagagesFromVolAsync(int idVol) {
            return base.Channel.GetBagagesFromVolAsync(idVol);
        }
    }
}
