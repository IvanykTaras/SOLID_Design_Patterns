using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;
        public BaseHandler(IHandler next) { 
            _next = next;
        }
        public abstract void Handle(RequestContext requestContext);
    }
}
