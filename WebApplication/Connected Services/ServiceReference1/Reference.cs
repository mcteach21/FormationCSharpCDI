//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.MyWebServiceSoap")]
    public interface MyWebServiceSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément MessageResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        WebApplication.ServiceReference1.MessageResponse Message(WebApplication.ServiceReference1.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication.ServiceReference1.MessageResponse> MessageAsync(WebApplication.ServiceReference1.MessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Message", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication.ServiceReference1.MessageRequestBody Body;
        
        public MessageRequest() {
        }
        
        public MessageRequest(WebApplication.ServiceReference1.MessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MessageRequestBody {
        
        public MessageRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication.ServiceReference1.MessageResponseBody Body;
        
        public MessageResponse() {
        }
        
        public MessageResponse(WebApplication.ServiceReference1.MessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MessageResult;
        
        public MessageResponseBody() {
        }
        
        public MessageResponseBody(string MessageResult) {
            this.MessageResult = MessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyWebServiceSoapChannel : WebApplication.ServiceReference1.MyWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication.ServiceReference1.MyWebServiceSoap>, WebApplication.ServiceReference1.MyWebServiceSoap {
        
        public MyWebServiceSoapClient() {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication.ServiceReference1.MessageResponse WebApplication.ServiceReference1.MyWebServiceSoap.Message(WebApplication.ServiceReference1.MessageRequest request) {
            return base.Channel.Message(request);
        }
        
        public string Message() {
            WebApplication.ServiceReference1.MessageRequest inValue = new WebApplication.ServiceReference1.MessageRequest();
            inValue.Body = new WebApplication.ServiceReference1.MessageRequestBody();
            WebApplication.ServiceReference1.MessageResponse retVal = ((WebApplication.ServiceReference1.MyWebServiceSoap)(this)).Message(inValue);
            return retVal.Body.MessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication.ServiceReference1.MessageResponse> WebApplication.ServiceReference1.MyWebServiceSoap.MessageAsync(WebApplication.ServiceReference1.MessageRequest request) {
            return base.Channel.MessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication.ServiceReference1.MessageResponse> MessageAsync() {
            WebApplication.ServiceReference1.MessageRequest inValue = new WebApplication.ServiceReference1.MessageRequest();
            inValue.Body = new WebApplication.ServiceReference1.MessageRequestBody();
            return ((WebApplication.ServiceReference1.MyWebServiceSoap)(this)).MessageAsync(inValue);
        }
    }
}
