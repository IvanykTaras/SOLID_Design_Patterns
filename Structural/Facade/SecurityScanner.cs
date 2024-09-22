using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Facade
{
    public class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string gitHubUrl) {
            Console.WriteLine("Security scan");
            return new List<string>() { "security error1"};
        }
    }
}
