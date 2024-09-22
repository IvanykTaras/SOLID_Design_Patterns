using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Adapter
{
    public class SmsSender
    {
        public void SendSms(string to, string text)
        {
            Console.WriteLine($"Send sms to: {to}");
        }
    }
}
