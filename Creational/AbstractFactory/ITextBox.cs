using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public interface ITextBox
    {
        void Render();
        void HandleInput();
    }
}
