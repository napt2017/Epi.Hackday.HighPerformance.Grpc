﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://tempuri.org/", ClrNamespace="tempuri.org")]

namespace tempuri.org
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HackdayTopic", Namespace="http://tempuri.org/")]
    public partial class HackdayTopic : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        private System.DateTime CreatedTimeField;
        
        private string AuthorField;
        
        private string OfficeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime CreatedTime
        {
            get
            {
                return this.CreatedTimeField;
            }
            set
            {
                this.CreatedTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Author
        {
            get
            {
                return this.AuthorField;
            }
            set
            {
                this.AuthorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Office
        {
            get
            {
                return this.OfficeField;
            }
            set
            {
                this.OfficeField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHackdayTopicOperation")]
public interface IHackdayTopicOperation
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHackdayTopicOperation/GetAllHackdayTopic", ReplyAction="*")]
    tempuri.org.HackdayTopic[] GetAllHackdayTopic();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHackdayTopicOperation/GetAllHackdayTopic", ReplyAction="*")]
    System.Threading.Tasks.Task<tempuri.org.HackdayTopic[]> GetAllHackdayTopicAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHackdayTopicOperationChannel : IHackdayTopicOperation, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HackdayTopicOperationClient : System.ServiceModel.ClientBase<IHackdayTopicOperation>, IHackdayTopicOperation
{
    
    public HackdayTopicOperationClient()
    {
    }
    
    public HackdayTopicOperationClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HackdayTopicOperationClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HackdayTopicOperationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HackdayTopicOperationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public tempuri.org.HackdayTopic[] GetAllHackdayTopic()
    {
        return base.Channel.GetAllHackdayTopic();
    }
    
    public System.Threading.Tasks.Task<tempuri.org.HackdayTopic[]> GetAllHackdayTopicAsync()
    {
        return base.Channel.GetAllHackdayTopicAsync();
    }
}
