using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Facade
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScna(string gitHubUrl)
        {
            Console.WriteLine("Dependency scan");
            return new List<string>() { "Dependency error1"};
        }
    }
}
