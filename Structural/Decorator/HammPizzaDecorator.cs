﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Decorator
{
    public class HammPizzaDecorator : PizzaDecorator
    {
        public HammPizzaDecorator(IPizza pizza) : base(pizza) 
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 5;
        }
    }
}
