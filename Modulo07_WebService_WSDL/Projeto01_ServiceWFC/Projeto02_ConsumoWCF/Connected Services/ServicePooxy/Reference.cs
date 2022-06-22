﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto02_ConsumoWCF.ServicePooxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aluno", Namespace="http://schemas.datacontract.org/2004/07/Projeto01_ServiceWFC.Models")]
    [System.SerializableAttribute()]
    public partial class Aluno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public string Curso {
            get {
                return this.CursoField;
            }
            set {
                if ((object.ReferenceEquals(this.CursoField, value) != true)) {
                    this.CursoField = value;
                    this.RaisePropertyChanged("Curso");
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
        public int Matricula {
            get {
                return this.MatriculaField;
            }
            set {
                if ((this.MatriculaField.Equals(value) != true)) {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePooxy.IServiceConceitos")]
    public interface IServiceConceitos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/ListarAluno", ReplyAction="http://tempuri.org/IServiceConceitos/ListarAlunoResponse")]
        Projeto02_ConsumoWCF.ServicePooxy.Aluno[] ListarAluno();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/ListarAluno", ReplyAction="http://tempuri.org/IServiceConceitos/ListarAlunoResponse")]
        System.Threading.Tasks.Task<Projeto02_ConsumoWCF.ServicePooxy.Aluno[]> ListarAlunoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/AdicionarAluno", ReplyAction="http://tempuri.org/IServiceConceitos/AdicionarAlunoResponse")]
        void AdicionarAluno(Projeto02_ConsumoWCF.ServicePooxy.Aluno aluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/AdicionarAluno", ReplyAction="http://tempuri.org/IServiceConceitos/AdicionarAlunoResponse")]
        System.Threading.Tasks.Task AdicionarAlunoAsync(Projeto02_ConsumoWCF.ServicePooxy.Aluno aluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/ListarNome", ReplyAction="http://tempuri.org/IServiceConceitos/ListarNomeResponse")]
        string[] ListarNome();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/ListarNome", ReplyAction="http://tempuri.org/IServiceConceitos/ListarNomeResponse")]
        System.Threading.Tasks.Task<string[]> ListarNomeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/CalcularSoma", ReplyAction="http://tempuri.org/IServiceConceitos/CalcularSomaResponse")]
        double CalcularSoma(double y, double z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceConceitos/CalcularSoma", ReplyAction="http://tempuri.org/IServiceConceitos/CalcularSomaResponse")]
        System.Threading.Tasks.Task<double> CalcularSomaAsync(double y, double z);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceConceitosChannel : Projeto02_ConsumoWCF.ServicePooxy.IServiceConceitos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceConceitosClient : System.ServiceModel.ClientBase<Projeto02_ConsumoWCF.ServicePooxy.IServiceConceitos>, Projeto02_ConsumoWCF.ServicePooxy.IServiceConceitos {
        
        public ServiceConceitosClient() {
        }
        
        public ServiceConceitosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceConceitosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceConceitosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceConceitosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Projeto02_ConsumoWCF.ServicePooxy.Aluno[] ListarAluno() {
            return base.Channel.ListarAluno();
        }
        
        public System.Threading.Tasks.Task<Projeto02_ConsumoWCF.ServicePooxy.Aluno[]> ListarAlunoAsync() {
            return base.Channel.ListarAlunoAsync();
        }
        
        public void AdicionarAluno(Projeto02_ConsumoWCF.ServicePooxy.Aluno aluno) {
            base.Channel.AdicionarAluno(aluno);
        }
        
        public System.Threading.Tasks.Task AdicionarAlunoAsync(Projeto02_ConsumoWCF.ServicePooxy.Aluno aluno) {
            return base.Channel.AdicionarAlunoAsync(aluno);
        }
        
        public string[] ListarNome() {
            return base.Channel.ListarNome();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarNomeAsync() {
            return base.Channel.ListarNomeAsync();
        }
        
        public double CalcularSoma(double y, double z) {
            return base.Channel.CalcularSoma(y, z);
        }
        
        public System.Threading.Tasks.Task<double> CalcularSomaAsync(double y, double z) {
            return base.Channel.CalcularSomaAsync(y, z);
        }
    }
}