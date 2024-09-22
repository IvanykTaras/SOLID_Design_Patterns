using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Builder
{
    public class Director
    {
        private IBuilder<Invoice> _builder;
        public Director(IBuilder<Invoice> builder) => _builder = builder;

        public void MakeInvoiceForTaras() {
            _builder.SetNumber("Taras");
            _builder.SetDate(new DateTime());
            _builder.SetVendor("Taras");
            _builder.SetVendee("Taras");
            _builder.SetLineItems(new List<string>() { "1","2","3"});
            _builder.SetNote("Taras");
        }

        public void MakeInvoiceForEdward() {
            _builder.SetNumber("Edward");
            _builder.SetDate(new DateTime());
            _builder.SetVendor("Edward");
            _builder.SetVendee("Edward");
            _builder.SetLineItems(new List<string>() { "1", "2", "3" });
            _builder.SetNote("Edward");
        }
    }
}
