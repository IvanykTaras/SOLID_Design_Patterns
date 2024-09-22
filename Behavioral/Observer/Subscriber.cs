using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Observer
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(string context)
        {
            Console.WriteLine($"Subscriber {Name} notified: {context}");
        }
    }
}
