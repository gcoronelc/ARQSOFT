﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGI.Proxy.Services.CargoServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyCargo", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities.Keys")]
    public partial class KeyCargo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDCargoField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDCargo
        {
            get
            {
                return this.IDCargoField;
            }
            set
            {
                this.IDCargoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityCargo", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SGI.Proxy.Services.CargoServices.EntityCargoPaginacion))]
    public partial class EntityCargo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescripcionField;
        
        private int EstadoField;
        
        private SGI.Proxy.Services.CargoServices.KeyCargo KeyField;
        
        private string NombreCargoField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion
        {
            get
            {
                return this.DescripcionField;
            }
            set
            {
                this.DescripcionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGI.Proxy.Services.CargoServices.KeyCargo Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCargo
        {
            get
            {
                return this.NombreCargoField;
            }
            set
            {
                this.NombreCargoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityCargoPaginacion", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities.Pagination")]
    public partial class EntityCargoPaginacion : SGI.Proxy.Services.CargoServices.EntityCargo
    {
        
        private SGI.Proxy.Services.CargoServices.EntityPaginacion EntityPaginacionField;
        
        private string EstadoNombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGI.Proxy.Services.CargoServices.EntityPaginacion EntityPaginacion
        {
            get
            {
                return this.EntityPaginacionField;
            }
            set
            {
                this.EntityPaginacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoNombre
        {
            get
            {
                return this.EstadoNombreField;
            }
            set
            {
                this.EstadoNombreField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityPaginacion", Namespace="http://schemas.datacontract.org/2004/07/SGISystem.Domain.Entities")]
    public partial class EntityPaginacion : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PageIndexField;
        
        private int RowCountField;
        
        private int RowsPerPageField;
        
        private string SortDirField;
        
        private string SortTypeField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex
        {
            get
            {
                return this.PageIndexField;
            }
            set
            {
                this.PageIndexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RowCount
        {
            get
            {
                return this.RowCountField;
            }
            set
            {
                this.RowCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RowsPerPage
        {
            get
            {
                return this.RowsPerPageField;
            }
            set
            {
                this.RowsPerPageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SortDir
        {
            get
            {
                return this.SortDirField;
            }
            set
            {
                this.SortDirField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SortType
        {
            get
            {
                return this.SortTypeField;
            }
            set
            {
                this.SortTypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SGI.Proxy.Services.CargoServices.ICargoServices")]
    public interface ICargoServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/SelectByKey", ReplyAction="http://tempuri.org/ICargoServices/SelectByKeyResponse")]
        SGI.Proxy.Services.CargoServices.EntityCargo SelectByKey(SGI.Proxy.Services.CargoServices.KeyCargo oKeyCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/SelectByKey", ReplyAction="http://tempuri.org/ICargoServices/SelectByKeyResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> SelectByKeyAsync(SGI.Proxy.Services.CargoServices.KeyCargo oKeyCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Select", ReplyAction="http://tempuri.org/ICargoServices/SelectResponse")]
        SGI.Proxy.Services.CargoServices.EntityCargo[] Select(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Select", ReplyAction="http://tempuri.org/ICargoServices/SelectResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo[]> SelectAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/SelectPagging", ReplyAction="http://tempuri.org/ICargoServices/SelectPaggingResponse")]
        SGI.Proxy.Services.CargoServices.SelectPaggingResponse SelectPagging(SGI.Proxy.Services.CargoServices.SelectPaggingRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/SelectPagging", ReplyAction="http://tempuri.org/ICargoServices/SelectPaggingResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.SelectPaggingResponse> SelectPaggingAsync(SGI.Proxy.Services.CargoServices.SelectPaggingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Insert", ReplyAction="http://tempuri.org/ICargoServices/InsertResponse")]
        SGI.Proxy.Services.CargoServices.EntityCargo Insert(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Insert", ReplyAction="http://tempuri.org/ICargoServices/InsertResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> InsertAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Update", ReplyAction="http://tempuri.org/ICargoServices/UpdateResponse")]
        SGI.Proxy.Services.CargoServices.EntityCargo Update(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Update", ReplyAction="http://tempuri.org/ICargoServices/UpdateResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> UpdateAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Delete", ReplyAction="http://tempuri.org/ICargoServices/DeleteResponse")]
        SGI.Proxy.Services.CargoServices.EntityCargo Delete(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargoServices/Delete", ReplyAction="http://tempuri.org/ICargoServices/DeleteResponse")]
        System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> DeleteAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectPagging", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectPaggingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SGI.Proxy.Services.CargoServices.EntityCargoPaginacion oEntityCargoPaginacion;
        
        public SelectPaggingRequest()
        {
        }
        
        public SelectPaggingRequest(SGI.Proxy.Services.CargoServices.EntityCargoPaginacion oEntityCargoPaginacion)
        {
            this.oEntityCargoPaginacion = oEntityCargoPaginacion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectPaggingResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SelectPaggingResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SGI.Proxy.Services.CargoServices.EntityCargoPaginacion[] SelectPaggingResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SGI.Proxy.Services.CargoServices.EntityCargoPaginacion oEntityCargoPaginacion;
        
        public SelectPaggingResponse()
        {
        }
        
        public SelectPaggingResponse(SGI.Proxy.Services.CargoServices.EntityCargoPaginacion[] SelectPaggingResult, SGI.Proxy.Services.CargoServices.EntityCargoPaginacion oEntityCargoPaginacion)
        {
            this.SelectPaggingResult = SelectPaggingResult;
            this.oEntityCargoPaginacion = oEntityCargoPaginacion;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICargoServicesChannel : SGI.Proxy.Services.CargoServices.ICargoServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CargoServicesClient : System.ServiceModel.ClientBase<SGI.Proxy.Services.CargoServices.ICargoServices>, SGI.Proxy.Services.CargoServices.ICargoServices
    {
        
        public CargoServicesClient()
        {
        }
        
        public CargoServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CargoServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CargoServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CargoServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargo SelectByKey(SGI.Proxy.Services.CargoServices.KeyCargo oKeyCargo)
        {
            return base.Channel.SelectByKey(oKeyCargo);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> SelectByKeyAsync(SGI.Proxy.Services.CargoServices.KeyCargo oKeyCargo)
        {
            return base.Channel.SelectByKeyAsync(oKeyCargo);
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargo[] Select(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.Select(oEntityCargo);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo[]> SelectAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.SelectAsync(oEntityCargo);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SGI.Proxy.Services.CargoServices.SelectPaggingResponse SGI.Proxy.Services.CargoServices.ICargoServices.SelectPagging(SGI.Proxy.Services.CargoServices.SelectPaggingRequest request)
        {
            return base.Channel.SelectPagging(request);
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargoPaginacion[] SelectPagging(ref SGI.Proxy.Services.CargoServices.EntityCargoPaginacion oEntityCargoPaginacion)
        {
            SGI.Proxy.Services.CargoServices.SelectPaggingRequest inValue = new SGI.Proxy.Services.CargoServices.SelectPaggingRequest();
            inValue.oEntityCargoPaginacion = oEntityCargoPaginacion;
            SGI.Proxy.Services.CargoServices.SelectPaggingResponse retVal = ((SGI.Proxy.Services.CargoServices.ICargoServices)(this)).SelectPagging(inValue);
            oEntityCargoPaginacion = retVal.oEntityCargoPaginacion;
            return retVal.SelectPaggingResult;
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.SelectPaggingResponse> SelectPaggingAsync(SGI.Proxy.Services.CargoServices.SelectPaggingRequest request)
        {
            return base.Channel.SelectPaggingAsync(request);
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargo Insert(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.Insert(oEntityCargo);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> InsertAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.InsertAsync(oEntityCargo);
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargo Update(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.Update(oEntityCargo);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> UpdateAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.UpdateAsync(oEntityCargo);
        }
        
        public SGI.Proxy.Services.CargoServices.EntityCargo Delete(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.Delete(oEntityCargo);
        }
        
        public System.Threading.Tasks.Task<SGI.Proxy.Services.CargoServices.EntityCargo> DeleteAsync(SGI.Proxy.Services.CargoServices.EntityCargo oEntityCargo)
        {
            return base.Channel.DeleteAsync(oEntityCargo);
        }
    }
}