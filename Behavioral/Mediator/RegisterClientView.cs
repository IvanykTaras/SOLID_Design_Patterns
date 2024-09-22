using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Mediator
{
    public class RegisterClientView : IMediator
    {
        private Checkbox _checkbox;
        private Button _button;

        public RegisterClientView(Checkbox checkbox, Button button)
        {
            _checkbox = checkbox;
            _button = button;

            _button.SetMediator(this);
            _checkbox.SetMediator(this);

        }
        public void Notify(Component component, string @event)
        {
            if (@event == "click") {
                _button.Render();
            }
        }
    }
}
