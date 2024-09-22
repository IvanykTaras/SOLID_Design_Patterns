using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows button render");
        }
         
        public void HandleClick()
        {
            Console.WriteLine("WIndows button handle click");
        }
    }
}
