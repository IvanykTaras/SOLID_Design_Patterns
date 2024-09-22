using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Observer
{
    public interface ISubscriber
    {
        void Update(string context);
    }
}
