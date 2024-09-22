using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.ChainOfResponsibility
{
    public class RequestContext
    {
        public Request request { get; set; }
        public Response response { get; set; }
    }

    public class Request
    {
        public string UserRole { get; set; }
        public int UserId { get; set; }
        public int EntityId { get; set; }

    }

    public class Response
    {
        public bool IsSuccessesfull { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
