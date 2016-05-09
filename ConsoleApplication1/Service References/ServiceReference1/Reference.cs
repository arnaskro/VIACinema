﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MovieS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReleaseYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ReleaseYear {
            get {
                return this.ReleaseYearField;
            }
            set {
                if ((object.ReferenceEquals(this.ReleaseYearField, value) != true)) {
                    this.ReleaseYearField = value;
                    this.RaisePropertyChanged("ReleaseYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CinemaMoviesSoap")]
    public interface CinemaMoviesSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsoleApplication1.ServiceReference1.HelloWorldResponse HelloWorld(ConsoleApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ConsoleApplication1.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetAvailableMoviesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAvailableMovies", ReplyAction="*")]
        ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse GetAvailableMovies(ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAvailableMovies", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse> GetAvailableMoviesAsync(ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsoleApplication1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsoleApplication1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableMoviesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableMovies", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequestBody Body;
        
        public GetAvailableMoviesRequest() {
        }
        
        public GetAvailableMoviesRequest(ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAvailableMoviesRequestBody {
        
        public GetAvailableMoviesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableMoviesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableMoviesResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponseBody Body;
        
        public GetAvailableMoviesResponse() {
        }
        
        public GetAvailableMoviesResponse(ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAvailableMoviesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApplication1.ServiceReference1.MovieS[] GetAvailableMoviesResult;
        
        public GetAvailableMoviesResponseBody() {
        }
        
        public GetAvailableMoviesResponseBody(ConsoleApplication1.ServiceReference1.MovieS[] GetAvailableMoviesResult) {
            this.GetAvailableMoviesResult = GetAvailableMoviesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CinemaMoviesSoapChannel : ConsoleApplication1.ServiceReference1.CinemaMoviesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CinemaMoviesSoapClient : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.CinemaMoviesSoap>, ConsoleApplication1.ServiceReference1.CinemaMoviesSoap {
        
        public CinemaMoviesSoapClient() {
        }
        
        public CinemaMoviesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CinemaMoviesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CinemaMoviesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CinemaMoviesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication1.ServiceReference1.HelloWorldResponse ConsoleApplication1.ServiceReference1.CinemaMoviesSoap.HelloWorld(ConsoleApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsoleApplication1.ServiceReference1.HelloWorldRequest inValue = new ConsoleApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference1.HelloWorldRequestBody();
            ConsoleApplication1.ServiceReference1.HelloWorldResponse retVal = ((ConsoleApplication1.ServiceReference1.CinemaMoviesSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.HelloWorldResponse> ConsoleApplication1.ServiceReference1.CinemaMoviesSoap.HelloWorldAsync(ConsoleApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ConsoleApplication1.ServiceReference1.HelloWorldRequest inValue = new ConsoleApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference1.HelloWorldRequestBody();
            return ((ConsoleApplication1.ServiceReference1.CinemaMoviesSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse ConsoleApplication1.ServiceReference1.CinemaMoviesSoap.GetAvailableMovies(ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest request) {
            return base.Channel.GetAvailableMovies(request);
        }
        
        public ConsoleApplication1.ServiceReference1.MovieS[] GetAvailableMovies() {
            ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest inValue = new ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequestBody();
            ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse retVal = ((ConsoleApplication1.ServiceReference1.CinemaMoviesSoap)(this)).GetAvailableMovies(inValue);
            return retVal.Body.GetAvailableMoviesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse> ConsoleApplication1.ServiceReference1.CinemaMoviesSoap.GetAvailableMoviesAsync(ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest request) {
            return base.Channel.GetAvailableMoviesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.GetAvailableMoviesResponse> GetAvailableMoviesAsync() {
            ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest inValue = new ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference1.GetAvailableMoviesRequestBody();
            return ((ConsoleApplication1.ServiceReference1.CinemaMoviesSoap)(this)).GetAvailableMoviesAsync(inValue);
        }
    }
}