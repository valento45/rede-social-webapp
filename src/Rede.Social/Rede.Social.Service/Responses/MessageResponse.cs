using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Service.Responses
{
    public class MessageResponse
    {
        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public string StackTrace { get; private set; }

        public MessageResponse() { }

        public MessageResponse(int statuCode, string message)
        {
            StatusCode = statuCode;
            Message = message;
            
        }
        public MessageResponse(int statuCode, string message, string stackTrace)
        {
            StatusCode = statuCode;
            Message = message;
            StackTrace = stackTrace;
        }


        public void InformarStatusCode(int statusCode)
        {
            StatusCode = statusCode;
        }
        public void InformarMessage(string message)
        {
            Message = message;
        }
        public void InformarStackTrace(string stackTrace)
        {
            StackTrace = stackTrace;
        }
    }
}
