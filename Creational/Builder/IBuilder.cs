using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Builder
{
    public interface IBuilder<T>
    {
        public void SetNumber(string number);
        public void SetDate(DateTime date);
        public void SetVendor(string vendor);
        public void SetVendee(string vendee);
        public void SetLineItems(IEnumerable<string> lineItems);
        public void SetNote(string note);

        //standart
        void Reset();
        T Result();
    }
}
