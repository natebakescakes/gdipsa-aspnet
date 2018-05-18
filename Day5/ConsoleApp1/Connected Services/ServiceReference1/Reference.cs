﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        private System.Nullable<int> SupplierIDField;
        
        private System.Nullable<int> CategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantityPerUnitField;
        
        private System.Nullable<decimal> UnitPriceField;
        
        private System.Nullable<short> UnitsInStockField;
        
        private System.Nullable<short> UnitsOnOrderField;
        
        private System.Nullable<short> ReorderLevelField;
        
        private bool DiscontinuedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> SupplierID {
            get {
                return this.SupplierIDField;
            }
            set {
                if ((this.SupplierIDField.Equals(value) != true)) {
                    this.SupplierIDField = value;
                    this.RaisePropertyChanged("SupplierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<int> CategoryID {
            get {
                return this.CategoryIDField;
            }
            set {
                if ((this.CategoryIDField.Equals(value) != true)) {
                    this.CategoryIDField = value;
                    this.RaisePropertyChanged("CategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string QuantityPerUnit {
            get {
                return this.QuantityPerUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantityPerUnitField, value) != true)) {
                    this.QuantityPerUnitField = value;
                    this.RaisePropertyChanged("QuantityPerUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<decimal> UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<short> UnitsInStock {
            get {
                return this.UnitsInStockField;
            }
            set {
                if ((this.UnitsInStockField.Equals(value) != true)) {
                    this.UnitsInStockField = value;
                    this.RaisePropertyChanged("UnitsInStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<short> UnitsOnOrder {
            get {
                return this.UnitsOnOrderField;
            }
            set {
                if ((this.UnitsOnOrderField.Equals(value) != true)) {
                    this.UnitsOnOrderField = value;
                    this.RaisePropertyChanged("UnitsOnOrder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<short> ReorderLevel {
            get {
                return this.ReorderLevelField;
            }
            set {
                if ((this.ReorderLevelField.Equals(value) != true)) {
                    this.ReorderLevelField = value;
                    this.RaisePropertyChanged("ReorderLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public bool Discontinued {
            get {
                return this.DiscontinuedField;
            }
            set {
                if ((this.DiscontinuedField.Equals(value) != true)) {
                    this.DiscontinuedField = value;
                    this.RaisePropertyChanged("Discontinued");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetProductIdsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductIds", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.GetProductIdsResponse GetProductIds(ConsoleApp1.ServiceReference1.GetProductIdsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductIds", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductIdsResponse> GetProductIdsAsync(ConsoleApp1.ServiceReference1.GetProductIdsRequest request);
        
        // CODEGEN: Generating message contract since element name GetProductResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProduct", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.GetProductResponse GetProduct(ConsoleApp1.ServiceReference1.GetProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProduct", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductResponse> GetProductAsync(ConsoleApp1.ServiceReference1.GetProductRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductIdsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductIds", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.GetProductIdsRequestBody Body;
        
        public GetProductIdsRequest() {
        }
        
        public GetProductIdsRequest(ConsoleApp1.ServiceReference1.GetProductIdsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetProductIdsRequestBody {
        
        public GetProductIdsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductIdsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductIdsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.GetProductIdsResponseBody Body;
        
        public GetProductIdsResponse() {
        }
        
        public GetProductIdsResponse(ConsoleApp1.ServiceReference1.GetProductIdsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductIdsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp1.ServiceReference1.ArrayOfInt GetProductIdsResult;
        
        public GetProductIdsResponseBody() {
        }
        
        public GetProductIdsResponseBody(ConsoleApp1.ServiceReference1.ArrayOfInt GetProductIdsResult) {
            this.GetProductIdsResult = GetProductIdsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProduct", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.GetProductRequestBody Body;
        
        public GetProductRequest() {
        }
        
        public GetProductRequest(ConsoleApp1.ServiceReference1.GetProductRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetProductRequestBody() {
        }
        
        public GetProductRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.GetProductResponseBody Body;
        
        public GetProductResponse() {
        }
        
        public GetProductResponse(ConsoleApp1.ServiceReference1.GetProductResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp1.ServiceReference1.Product GetProductResult;
        
        public GetProductResponseBody() {
        }
        
        public GetProductResponseBody(ConsoleApp1.ServiceReference1.Product GetProductResult) {
            this.GetProductResult = GetProductResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ConsoleApp1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.WebServiceSoap>, ConsoleApp1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.GetProductIdsResponse ConsoleApp1.ServiceReference1.WebServiceSoap.GetProductIds(ConsoleApp1.ServiceReference1.GetProductIdsRequest request) {
            return base.Channel.GetProductIds(request);
        }
        
        public ConsoleApp1.ServiceReference1.ArrayOfInt GetProductIds() {
            ConsoleApp1.ServiceReference1.GetProductIdsRequest inValue = new ConsoleApp1.ServiceReference1.GetProductIdsRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.GetProductIdsRequestBody();
            ConsoleApp1.ServiceReference1.GetProductIdsResponse retVal = ((ConsoleApp1.ServiceReference1.WebServiceSoap)(this)).GetProductIds(inValue);
            return retVal.Body.GetProductIdsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductIdsResponse> ConsoleApp1.ServiceReference1.WebServiceSoap.GetProductIdsAsync(ConsoleApp1.ServiceReference1.GetProductIdsRequest request) {
            return base.Channel.GetProductIdsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductIdsResponse> GetProductIdsAsync() {
            ConsoleApp1.ServiceReference1.GetProductIdsRequest inValue = new ConsoleApp1.ServiceReference1.GetProductIdsRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.GetProductIdsRequestBody();
            return ((ConsoleApp1.ServiceReference1.WebServiceSoap)(this)).GetProductIdsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.GetProductResponse ConsoleApp1.ServiceReference1.WebServiceSoap.GetProduct(ConsoleApp1.ServiceReference1.GetProductRequest request) {
            return base.Channel.GetProduct(request);
        }
        
        public ConsoleApp1.ServiceReference1.Product GetProduct(int id) {
            ConsoleApp1.ServiceReference1.GetProductRequest inValue = new ConsoleApp1.ServiceReference1.GetProductRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.GetProductRequestBody();
            inValue.Body.id = id;
            ConsoleApp1.ServiceReference1.GetProductResponse retVal = ((ConsoleApp1.ServiceReference1.WebServiceSoap)(this)).GetProduct(inValue);
            return retVal.Body.GetProductResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductResponse> ConsoleApp1.ServiceReference1.WebServiceSoap.GetProductAsync(ConsoleApp1.ServiceReference1.GetProductRequest request) {
            return base.Channel.GetProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.GetProductResponse> GetProductAsync(int id) {
            ConsoleApp1.ServiceReference1.GetProductRequest inValue = new ConsoleApp1.ServiceReference1.GetProductRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.GetProductRequestBody();
            inValue.Body.id = id;
            return ((ConsoleApp1.ServiceReference1.WebServiceSoap)(this)).GetProductAsync(inValue);
        }
    }
}