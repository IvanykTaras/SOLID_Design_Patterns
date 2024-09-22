using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.ChainOfResponsibility
{
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("Result ok");
            requestContext.response.IsSuccessesfull = true;
            requestContext.response.Message = "OK";
            requestContext.response.Data = "some value";
        }
    }
}
