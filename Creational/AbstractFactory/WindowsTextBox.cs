using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public class WindowsTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Windows input");
        }

        public void Render() 
        {
            Console.WriteLine("Windows input render");
        }
    }
}
