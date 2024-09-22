using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public class MacTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Mac input");
        }
         
        public void Render()
        {
            Console.WriteLine("Mac input Render");
        }
    }
}
