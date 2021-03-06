#region File Information
/********************************************************************
  Project: ServiceBusMQ
  File:    Reference.cs
  Created: 2012-12-09

  Author(s):
    Daniel Halan

 (C) Copyright 2012 Ingenious Technology with Quality Sweden AB
     all rights reserved

********************************************************************/
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace ServiceBusMQ.HalanService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IProductManager", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_IProductManager : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReportErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReportAttachmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLatestVersionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_IProductManager() {
            this.Url = global::ServiceBusMQ.Properties.Settings.Default.ServiceBusMQ_HalanService_ProductManager;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReportErrorCompletedEventHandler ReportErrorCompleted;
        
        /// <remarks/>
        public event ReportAttachmentCompletedEventHandler ReportAttachmentCompleted;
        
        /// <remarks/>
        public event GetLatestVersionCompletedEventHandler GetLatestVersionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/ReportError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ErrorReportResponse ReportError([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ErrorReportRequest request) {
            object[] results = this.Invoke("ReportError", new object[] {
                        request});
            return ((ErrorReportResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ReportErrorAsync(ErrorReportRequest request) {
            this.ReportErrorAsync(request, null);
        }
        
        /// <remarks/>
        public void ReportErrorAsync(ErrorReportRequest request, object userState) {
            if ((this.ReportErrorOperationCompleted == null)) {
                this.ReportErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReportErrorOperationCompleted);
            }
            this.InvokeAsync("ReportError", new object[] {
                        request}, this.ReportErrorOperationCompleted, userState);
        }
        
        private void OnReportErrorOperationCompleted(object arg) {
            if ((this.ReportErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReportErrorCompleted(this, new ReportErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/ReportAttachment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ReportAttachmentResponse ReportAttachment([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ReportAttachmentRequest request) {
            object[] results = this.Invoke("ReportAttachment", new object[] {
                        request});
            return ((ReportAttachmentResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ReportAttachmentAsync(ReportAttachmentRequest request) {
            this.ReportAttachmentAsync(request, null);
        }
        
        /// <remarks/>
        public void ReportAttachmentAsync(ReportAttachmentRequest request, object userState) {
            if ((this.ReportAttachmentOperationCompleted == null)) {
                this.ReportAttachmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReportAttachmentOperationCompleted);
            }
            this.InvokeAsync("ReportAttachment", new object[] {
                        request}, this.ReportAttachmentOperationCompleted, userState);
        }
        
        private void OnReportAttachmentOperationCompleted(object arg) {
            if ((this.ReportAttachmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReportAttachmentCompleted(this, new ReportAttachmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/GetLatestVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public LatestVersionResponse GetLatestVersion([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] LatestVersionRequest request) {
            object[] results = this.Invoke("GetLatestVersion", new object[] {
                        request});
            return ((LatestVersionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetLatestVersionAsync(LatestVersionRequest request) {
            this.GetLatestVersionAsync(request, null);
        }
        
        /// <remarks/>
        public void GetLatestVersionAsync(LatestVersionRequest request, object userState) {
            if ((this.GetLatestVersionOperationCompleted == null)) {
                this.GetLatestVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLatestVersionOperationCompleted);
            }
            this.InvokeAsync("GetLatestVersion", new object[] {
                        request}, this.GetLatestVersionOperationCompleted, userState);
        }
        
        private void OnGetLatestVersionOperationCompleted(object arg) {
            if ((this.GetLatestVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLatestVersionCompleted(this, new GetLatestVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IProductManager1", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_IProductManager1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReportErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReportAttachmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLatestVersionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_IProductManager1() {
            this.Url = "http://www.halan.se/service/ProductManager.svc/mtom";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReportErrorCompletedEventHandler ReportErrorCompleted;
        
        /// <remarks/>
        public event ReportAttachmentCompletedEventHandler ReportAttachmentCompleted;
        
        /// <remarks/>
        public event GetLatestVersionCompletedEventHandler GetLatestVersionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/ReportError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ErrorReportResponse ReportError([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ErrorReportRequest request) {
            object[] results = this.Invoke("ReportError", new object[] {
                        request});
            return ((ErrorReportResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ReportErrorAsync(ErrorReportRequest request) {
            this.ReportErrorAsync(request, null);
        }
        
        /// <remarks/>
        public void ReportErrorAsync(ErrorReportRequest request, object userState) {
            if ((this.ReportErrorOperationCompleted == null)) {
                this.ReportErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReportErrorOperationCompleted);
            }
            this.InvokeAsync("ReportError", new object[] {
                        request}, this.ReportErrorOperationCompleted, userState);
        }
        
        private void OnReportErrorOperationCompleted(object arg) {
            if ((this.ReportErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReportErrorCompleted(this, new ReportErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/ReportAttachment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ReportAttachmentResponse ReportAttachment([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ReportAttachmentRequest request) {
            object[] results = this.Invoke("ReportAttachment", new object[] {
                        request});
            return ((ReportAttachmentResponse)(results[0]));
        }
        
        /// <remarks/>
        public void ReportAttachmentAsync(ReportAttachmentRequest request) {
            this.ReportAttachmentAsync(request, null);
        }
        
        /// <remarks/>
        public void ReportAttachmentAsync(ReportAttachmentRequest request, object userState) {
            if ((this.ReportAttachmentOperationCompleted == null)) {
                this.ReportAttachmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReportAttachmentOperationCompleted);
            }
            this.InvokeAsync("ReportAttachment", new object[] {
                        request}, this.ReportAttachmentOperationCompleted, userState);
        }
        
        private void OnReportAttachmentOperationCompleted(object arg) {
            if ((this.ReportAttachmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReportAttachmentCompleted(this, new ReportAttachmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductManager/GetLatestVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public LatestVersionResponse GetLatestVersion([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] LatestVersionRequest request) {
            object[] results = this.Invoke("GetLatestVersion", new object[] {
                        request});
            return ((LatestVersionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetLatestVersionAsync(LatestVersionRequest request) {
            this.GetLatestVersionAsync(request, null);
        }
        
        /// <remarks/>
        public void GetLatestVersionAsync(LatestVersionRequest request, object userState) {
            if ((this.GetLatestVersionOperationCompleted == null)) {
                this.GetLatestVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLatestVersionOperationCompleted);
            }
            this.InvokeAsync("GetLatestVersion", new object[] {
                        request}, this.GetLatestVersionOperationCompleted, userState);
        }
        
        private void OnGetLatestVersionOperationCompleted(object arg) {
            if ((this.GetLatestVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLatestVersionCompleted(this, new GetLatestVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class ErrorReportRequest {
        
        private string dotNetFrameworkVersionField;
        
        private ErrorReportException exceptionField;
        
        private string managerStateField;
        
        private string messageField;
        
        private string operatingSystemField;
        
        private string productNameField;
        
        private string productVersionField;
        
        private string referenceField;
        
        private string reportIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DotNetFrameworkVersion {
            get {
                return this.dotNetFrameworkVersionField;
            }
            set {
                this.dotNetFrameworkVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ErrorReportException Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ManagerState {
            get {
                return this.managerStateField;
            }
            set {
                this.managerStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string OperatingSystem {
            get {
                return this.operatingSystemField;
            }
            set {
                this.operatingSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ProductName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ProductVersion {
            get {
                return this.productVersionField;
            }
            set {
                this.productVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ReportID {
            get {
                return this.reportIDField;
            }
            set {
                this.reportIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class ErrorReportException {
        
        private ErrorReportException innerExceptionField;
        
        private string messageField;
        
        private string sourceField;
        
        private string stackTraceField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ErrorReportException InnerException {
            get {
                return this.innerExceptionField;
            }
            set {
                this.innerExceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StackTrace {
            get {
                return this.stackTraceField;
            }
            set {
                this.stackTraceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class LatestVersionResponse {
        
        private string descriptionField;
        
        private string[] featuresField;
        
        private string productVersionField;
        
        private System.DateTime releaseDateField;
        
        private bool releaseDateFieldSpecified;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ProductVersion {
            get {
                return this.productVersionField;
            }
            set {
                this.productVersionField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ReleaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReleaseDateSpecified {
            get {
                return this.releaseDateFieldSpecified;
            }
            set {
                this.releaseDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class LatestVersionRequest {
        
        private string currentProductVersionField;
        
        private string productNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CurrentProductVersion {
            get {
                return this.currentProductVersionField;
            }
            set {
                this.currentProductVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ProductName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class ReportAttachmentResponse {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class ReportAttachmentRequest {
        
        private byte[] dataField;
        
        private string fileNameField;
        
        private string reportIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ReportId {
            get {
                return this.reportIdField;
            }
            set {
                this.reportIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services.Contracts")]
    public partial class ErrorReportResponse {
        
        private string messageField;
        
        private bool successfulField;
        
        private bool successfulFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public bool Successful {
            get {
                return this.successfulField;
            }
            set {
                this.successfulField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuccessfulSpecified {
            get {
                return this.successfulFieldSpecified;
            }
            set {
                this.successfulFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ReportErrorCompletedEventHandler(object sender, ReportErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReportErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReportErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ErrorReportResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ErrorReportResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ReportAttachmentCompletedEventHandler(object sender, ReportAttachmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReportAttachmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReportAttachmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReportAttachmentResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReportAttachmentResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetLatestVersionCompletedEventHandler(object sender, GetLatestVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLatestVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLatestVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LatestVersionResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LatestVersionResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591