using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Singelton
{
    public class Configuration
    {
        public static Configuration _instance = null;
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }

        private Configuration() { }
        public static Configuration GenInstance()
        {
            if (_instance == null) {
                _instance = new Configuration();
            }

            return _instance;
        }
    }
}
