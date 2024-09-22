using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.TemplateMethod
{
    public class PdfGenerator : Generator
    {
        protected override void GetData()
        {
            Console.WriteLine("Pdf get data");
        }
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate pdf file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for pdf");
        }
    }
}
