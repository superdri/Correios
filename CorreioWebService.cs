using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CorreioWebService
{

    public class InspectorBehavior : IEndpointBehavior
    {
        private MyMessageInspector myMessageInspector = new MyMessageInspector();

        public string LastRequestXML
        {
            get
            {
                return myMessageInspector.LastRequestXML;
            }
        }

        public string LastResponseXML
        {
            get
            {
                return myMessageInspector.LastResponseXML;
            }
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(myMessageInspector);
        }

    }

    public class MyMessageInspector : IClientMessageInspector
    {

        private string _LastRequestXML;
        private string _LastResponseXML;

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            LastResponseXML = reply.ToString();
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            LastRequestXML = request.ToString();
            return request;
        }

        public string LastResponseXML
        {
            get
            {
                return _LastResponseXML;
            }
            set
            {
                _LastResponseXML = value;
            }
        }

        public string LastRequestXML
        {
            get
            {
                return _LastRequestXML;
            }
            set
            {
                _LastRequestXML = value;
            }
        }
    }
}