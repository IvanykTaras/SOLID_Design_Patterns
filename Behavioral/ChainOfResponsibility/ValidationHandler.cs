using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.ChainOfResponsibility
{
    public class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.request.EntityId > 100) {
                Console.WriteLine("Validation ok");
                _next.Handle(requestContext);
                return;
            }

            requestContext.response.IsSuccessesfull = false;
            requestContext.response.Message = "validation error";
        }
    }
}
