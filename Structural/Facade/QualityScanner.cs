using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Facade
{
    public class QualityScanner
    {
        public IEnumerable<string> QualityScan(string gitHubUrl) {
            Console.WriteLine("Quality scan");
            return new List<string>() { "Error1", "Error2"};
        }
    }
}
