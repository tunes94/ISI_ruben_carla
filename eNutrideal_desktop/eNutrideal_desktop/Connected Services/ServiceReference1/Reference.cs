﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eNutrideal_desktop.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Refeicao", Namespace="http://schemas.datacontract.org/2004/07/eNutridealWebservice")]
    [System.SerializableAttribute()]
    public partial class Refeicao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CaloriasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RestauranteField;
        
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
        public string Calorias {
            get {
                return this.CaloriasField;
            }
            set {
                if ((object.ReferenceEquals(this.CaloriasField, value) != true)) {
                    this.CaloriasField = value;
                    this.RaisePropertyChanged("Calorias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Item {
            get {
                return this.ItemField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemField, value) != true)) {
                    this.ItemField = value;
                    this.RaisePropertyChanged("Item");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quantidade {
            get {
                return this.QuantidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantidadeField, value) != true)) {
                    this.QuantidadeField = value;
                    this.RaisePropertyChanged("Quantidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Restaurante {
            get {
                return this.RestauranteField;
            }
            set {
                if ((object.ReferenceEquals(this.RestauranteField, value) != true)) {
                    this.RestauranteField = value;
                    this.RaisePropertyChanged("Restaurante");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DadosPessoais", Namespace="http://schemas.datacontract.org/2004/07/eNutridealWebservice")]
    [System.SerializableAttribute()]
    public partial class DadosPessoais : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AlturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelAtividadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PesoField;
        
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
        public int Altura {
            get {
                return this.AlturaField;
            }
            set {
                if ((this.AlturaField.Equals(value) != true)) {
                    this.AlturaField = value;
                    this.RaisePropertyChanged("Altura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Idade {
            get {
                return this.IdadeField;
            }
            set {
                if ((this.IdadeField.Equals(value) != true)) {
                    this.IdadeField = value;
                    this.RaisePropertyChanged("Idade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NivelAtividade {
            get {
                return this.NivelAtividadeField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelAtividadeField, value) != true)) {
                    this.NivelAtividadeField = value;
                    this.RaisePropertyChanged("NivelAtividade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Peso {
            get {
                return this.PesoField;
            }
            set {
                if ((this.PesoField.Equals(value) != true)) {
                    this.PesoField = value;
                    this.RaisePropertyChanged("Peso");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceENutrideal")]
    public interface IServiceENutrideal {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoResponse")]
        eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoResponse")]
        System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorRestaurante", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorRestauranteResponse")]
        eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicaoPorRestaurante(string restaurante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorRestaurante", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorRestauranteResponse")]
        System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoPorRestauranteAsync(string restaurante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorItem", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorItemResponse")]
        eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicaoPorItem(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorItem", ReplyAction="http://tempuri.org/IServiceENutrideal/GetRefeicaoPorItemResponse")]
        System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoPorItemAsync(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/AddRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/AddRefeicaoResponse")]
        void AddRefeicao(eNutrideal_desktop.ServiceReference1.Refeicao refeicao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/AddRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/AddRefeicaoResponse")]
        System.Threading.Tasks.Task AddRefeicaoAsync(eNutrideal_desktop.ServiceReference1.Refeicao refeicao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/addListRefeicoesToXML", ReplyAction="http://tempuri.org/IServiceENutrideal/addListRefeicoesToXMLResponse")]
        void addListRefeicoesToXML();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/addListRefeicoesToXML", ReplyAction="http://tempuri.org/IServiceENutrideal/addListRefeicoesToXMLResponse")]
        System.Threading.Tasks.Task addListRefeicoesToXMLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/recebeRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/recebeRefeicaoResponse")]
        void recebeRefeicao(eNutrideal_desktop.ServiceReference1.Refeicao refeicao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/recebeRefeicao", ReplyAction="http://tempuri.org/IServiceENutrideal/recebeRefeicaoResponse")]
        System.Threading.Tasks.Task recebeRefeicaoAsync(eNutrideal_desktop.ServiceReference1.Refeicao refeicao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/CriaXML", ReplyAction="http://tempuri.org/IServiceENutrideal/CriaXMLResponse")]
        void CriaXML(string restaurante, string item, string quantidade, string calorias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/CriaXML", ReplyAction="http://tempuri.org/IServiceENutrideal/CriaXMLResponse")]
        System.Threading.Tasks.Task CriaXMLAsync(string restaurante, string item, string quantidade, string calorias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/ApagarRefeicaoPorItem", ReplyAction="http://tempuri.org/IServiceENutrideal/ApagarRefeicaoPorItemResponse")]
        void ApagarRefeicaoPorItem(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/ApagarRefeicaoPorItem", ReplyAction="http://tempuri.org/IServiceENutrideal/ApagarRefeicaoPorItemResponse")]
        System.Threading.Tasks.Task ApagarRefeicaoPorItemAsync(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/Calculadora", ReplyAction="http://tempuri.org/IServiceENutrideal/CalculadoraResponse")]
        double Calculadora(eNutrideal_desktop.ServiceReference1.DadosPessoais dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceENutrideal/Calculadora", ReplyAction="http://tempuri.org/IServiceENutrideal/CalculadoraResponse")]
        System.Threading.Tasks.Task<double> CalculadoraAsync(eNutrideal_desktop.ServiceReference1.DadosPessoais dados);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceENutridealChannel : eNutrideal_desktop.ServiceReference1.IServiceENutrideal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceENutridealClient : System.ServiceModel.ClientBase<eNutrideal_desktop.ServiceReference1.IServiceENutrideal>, eNutrideal_desktop.ServiceReference1.IServiceENutrideal {
        
        public ServiceENutridealClient() {
        }
        
        public ServiceENutridealClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceENutridealClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceENutridealClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceENutridealClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicao() {
            return base.Channel.GetRefeicao();
        }
        
        public System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoAsync() {
            return base.Channel.GetRefeicaoAsync();
        }
        
        public eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicaoPorRestaurante(string restaurante) {
            return base.Channel.GetRefeicaoPorRestaurante(restaurante);
        }
        
        public System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoPorRestauranteAsync(string restaurante) {
            return base.Channel.GetRefeicaoPorRestauranteAsync(restaurante);
        }
        
        public eNutrideal_desktop.ServiceReference1.Refeicao[] GetRefeicaoPorItem(string item) {
            return base.Channel.GetRefeicaoPorItem(item);
        }
        
        public System.Threading.Tasks.Task<eNutrideal_desktop.ServiceReference1.Refeicao[]> GetRefeicaoPorItemAsync(string item) {
            return base.Channel.GetRefeicaoPorItemAsync(item);
        }
        
        public void AddRefeicao(eNutrideal_desktop.ServiceReference1.Refeicao refeicao) {
            base.Channel.AddRefeicao(refeicao);
        }
        
        public System.Threading.Tasks.Task AddRefeicaoAsync(eNutrideal_desktop.ServiceReference1.Refeicao refeicao) {
            return base.Channel.AddRefeicaoAsync(refeicao);
        }
        
        public void addListRefeicoesToXML() {
            base.Channel.addListRefeicoesToXML();
        }
        
        public System.Threading.Tasks.Task addListRefeicoesToXMLAsync() {
            return base.Channel.addListRefeicoesToXMLAsync();
        }
        
        public void recebeRefeicao(eNutrideal_desktop.ServiceReference1.Refeicao refeicao) {
            base.Channel.recebeRefeicao(refeicao);
        }
        
        public System.Threading.Tasks.Task recebeRefeicaoAsync(eNutrideal_desktop.ServiceReference1.Refeicao refeicao) {
            return base.Channel.recebeRefeicaoAsync(refeicao);
        }
        
        public void CriaXML(string restaurante, string item, string quantidade, string calorias) {
            base.Channel.CriaXML(restaurante, item, quantidade, calorias);
        }
        
        public System.Threading.Tasks.Task CriaXMLAsync(string restaurante, string item, string quantidade, string calorias) {
            return base.Channel.CriaXMLAsync(restaurante, item, quantidade, calorias);
        }
        
        public void ApagarRefeicaoPorItem(string item) {
            base.Channel.ApagarRefeicaoPorItem(item);
        }
        
        public System.Threading.Tasks.Task ApagarRefeicaoPorItemAsync(string item) {
            return base.Channel.ApagarRefeicaoPorItemAsync(item);
        }
        
        public double Calculadora(eNutrideal_desktop.ServiceReference1.DadosPessoais dados) {
            return base.Channel.Calculadora(dados);
        }
        
        public System.Threading.Tasks.Task<double> CalculadoraAsync(eNutrideal_desktop.ServiceReference1.DadosPessoais dados) {
            return base.Channel.CalculadoraAsync(dados);
        }
    }
}
