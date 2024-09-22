using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Mac Button render"); 
        }

        public void HandleClick()
        {
            Console.WriteLine("Mac Button handle click");
        }
    }
}
