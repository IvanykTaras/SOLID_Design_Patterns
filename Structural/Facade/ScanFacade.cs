using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Facade
{
    public class ScanFacade
    {

        private QualityScanner _qualityScanner = new QualityScanner();
        private SecurityScanner _securityScanner = new SecurityScanner();
        private DependencyScanner _dependencyScanner = new DependencyScanner();
        private ReportGenerator _reportGenerator = new ReportGenerator();

        public void Scan(string gitHubUrl) {
            Console.WriteLine($"Scanning github: {gitHubUrl}");

            var qualityScanErrors = _qualityScanner.QualityScan(gitHubUrl);
            var securityScanErrors = _securityScanner.SecurityScan(gitHubUrl);
            var dependencyScanErrors = _dependencyScanner.DependencyScna(gitHubUrl);

            Console.WriteLine("Scan report");
            _reportGenerator.GenerateRaport(qualityScanErrors,securityScanErrors,dependencyScanErrors);
            Console.WriteLine("Scan end");


        }
    }
}
