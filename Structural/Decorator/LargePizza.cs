﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Decorator
{
    public class LargePizza : IPizza
    {
        public double CalculatePrice()
        {
            return 30;
        }
    }
}
