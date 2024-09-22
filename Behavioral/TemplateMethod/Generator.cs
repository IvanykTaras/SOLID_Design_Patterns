using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.TemplateMethod
{
    public abstract class Generator
    {
        public void GenerateReprot()
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }
        protected virtual void GetData()
        {
            Console.WriteLine("Base Get Data");
        }

        protected abstract void PrepareData();

        protected abstract void GenerateFile();
        protected void SendFile()
        {
            Console.WriteLine("Sending generator report");
        }
    }
}
