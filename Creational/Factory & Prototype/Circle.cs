using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Factory
{
    public class Circle : Shape
    {
        public List<string> properties = new List<string>();
        public override Shape Clone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
