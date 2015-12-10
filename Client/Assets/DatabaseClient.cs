﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Statistic", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    public partial class Statistic : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int allField;
        
        private int idField;
        
        private int loseField;
        
        private string nameField;
        
        private int winField;
        
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
        public int all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int lose
        {
            get
            {
                return this.loseField;
            }
            set
            {
                this.loseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int win
        {
            get
            {
                return this.winField;
            }
            set
            {
                this.winField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDatabase")]
public interface IDatabase
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/BDOpen", ReplyAction="http://tempuri.org/IDatabase/BDOpenResponse")]
    void BDOpen();
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/BDOpen", ReplyAction="http://tempuri.org/IDatabase/BDOpenResponse")]
    System.Threading.Tasks.Task BDOpenAsync();
    */
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/BDClose", ReplyAction="http://tempuri.org/IDatabase/BDCloseResponse")]
    void BDClose();
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/BDClose", ReplyAction="http://tempuri.org/IDatabase/BDCloseResponse")]
    System.Threading.Tasks.Task BDCloseAsync();
    */
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/Authorization", ReplyAction="http://tempuri.org/IDatabase/AuthorizationResponse")]
    bool Authorization(string name, string password);
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/Authorization", ReplyAction="http://tempuri.org/IDatabase/AuthorizationResponse")]
    System.Threading.Tasks.Task<bool> AuthorizationAsync(string name, string password);
    */
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/AddPerson", ReplyAction="http://tempuri.org/IDatabase/AddPersonResponse")]
    bool AddPerson(string name, string password);
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/AddPerson", ReplyAction="http://tempuri.org/IDatabase/AddPersonResponse")]
    System.Threading.Tasks.Task<bool> AddPersonAsync(string name, string password);
    */
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/ShowInfo", ReplyAction="http://tempuri.org/IDatabase/ShowInfoResponse")]
    Service.Statistic ShowInfo(string name);
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/ShowInfo", ReplyAction="http://tempuri.org/IDatabase/ShowInfoResponse")]
    System.Threading.Tasks.Task<Service.Statistic> ShowInfoAsync(string name);
    */
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/Update", ReplyAction="http://tempuri.org/IDatabase/UpdateResponse")]
    bool Update(string Name, bool win);
    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabase/Update", ReplyAction="http://tempuri.org/IDatabase/UpdateResponse")]
    System.Threading.Tasks.Task<bool> UpdateAsync(string Name, bool win);*/
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDatabaseChannel : IDatabase, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DatabaseClient : System.ServiceModel.ClientBase<IDatabase>, IDatabase
{
    
    public DatabaseClient()
    {
    }
    
    public DatabaseClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public DatabaseClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DatabaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DatabaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void BDOpen()
    {
        base.Channel.BDOpen();
    }
    /*
    public System.Threading.Tasks.Task BDOpenAsync()
    {
        return base.Channel.BDOpenAsync();
    }
    */
    public void BDClose()
    {
        base.Channel.BDClose();
    }
    /*
    public System.Threading.Tasks.Task BDCloseAsync()
    {
        return base.Channel.BDCloseAsync();
    }
    */
    public bool Authorization(string name, string password)
    {
        return base.Channel.Authorization(name, password);
    }
    /*
    public System.Threading.Tasks.Task<bool> AuthorizationAsync(string name, string password)
    {
        return base.Channel.AuthorizationAsync(name, password);
    }
    */
    public bool AddPerson(string name, string password)
    {
        return base.Channel.AddPerson(name, password);
    }
    /* 
     public System.Threading.Tasks.Task<bool> AddPersonAsync(string name, string password)
     {
         return base.Channel.AddPersonAsync(name, password);
     }
     */
    public Service.Statistic ShowInfo(string name)
     {
         return base.Channel.ShowInfo(name);
     }
    /* 
     public System.Threading.Tasks.Task<Service.Statistic> ShowInfoAsync(string name)
     {
         return base.Channel.ShowInfoAsync(name);
     }
    */
    public bool Update(string Name, bool win)
    {
        return base.Channel.Update(Name, win);
    }
   /* 
    public System.Threading.Tasks.Task<bool> UpdateAsync(string Name, bool win)
    {
        return base.Channel.UpdateAsync(Name, win);
    }*/
}