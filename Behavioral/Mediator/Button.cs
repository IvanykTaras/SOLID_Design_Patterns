using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Mediator
{
    public class Button: Component
    {
        public void Render()
        {
            Console.WriteLine("Render button");
        }

        public void Click()
        {
            Console.WriteLine("Button click");
            _mediator.Notify(this,"click");
        }
    }
}
