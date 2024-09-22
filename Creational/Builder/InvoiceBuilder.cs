using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Builder
{
    public class InvoiceBuilder: IBuilder<Invoice>
    {
        private Invoice _invoice = new Invoice();

        public void SetNumber(string number) { _invoice.Number = number; }
        public void SetDate(DateTime date){ _invoice.Date = date; }
        public void SetVendor(string vendor){ _invoice.Vendor = vendor; }
        public void SetVendee(string vendee){ _invoice.Vendee = vendee; }
        public void SetLineItems(IEnumerable<string> lineItems){ _invoice.LineItems = lineItems; }
        public void SetNote(string note){ _invoice.Note = note; }

        public void Reset() { _invoice = new Invoice(); }
        public Invoice Result() { 
            var invoice = _invoice;  

            return invoice; 
        }

    }
}
