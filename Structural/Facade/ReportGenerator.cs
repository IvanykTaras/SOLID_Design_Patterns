using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Facade
{
    public class ReportGenerator
    {
        public void GenerateRaport(
            IEnumerable<string> QualityErrors,
            IEnumerable<string> SecurityScanErrors,
            IEnumerable<string> DependencyError
        )
        {
            Console.WriteLine("Quality scan errors:");
            Console.WriteLine(String.Join(", ", QualityErrors));

            Console.WriteLine("Security scan errors:");
            Console.WriteLine(String.Join(", ", SecurityScanErrors));

            Console.WriteLine("Dependency scan errors:");
            Console.WriteLine(String.Join(", ", DependencyError));


        }
    }
}
