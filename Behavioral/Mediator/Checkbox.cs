﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Mediator
{
    public class Checkbox: Component
    {
        public void Select()
        {
            Console.WriteLine("checkbox selected");
            this._mediator.Notify(this,"check");
        }
    }
}
