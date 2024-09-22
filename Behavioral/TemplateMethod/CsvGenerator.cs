using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.TemplateMethod
{
    public class CsvGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate file for csv");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for csv");
        }
    }
}
