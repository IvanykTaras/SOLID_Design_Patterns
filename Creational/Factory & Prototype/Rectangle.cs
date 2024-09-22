using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Factory
{
    internal class Rectangle : Shape
    {
        public override Shape Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }
        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}
