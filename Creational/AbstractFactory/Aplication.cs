using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.AbstractFactory
{
    public class Aplication
    {
        private IUIElementFactory _elementFactory;
        public Aplication(IUIElementFactory elementFactory)=> _elementFactory = elementFactory;

        public void RenderUI()
        {
            var creatNewFileButton = _elementFactory.CreateButton();
            creatNewFileButton.Render();

            var craeteNewTextBox = _elementFactory.CreateTextBox();
            craeteNewTextBox.Render();
        }
    }
}
