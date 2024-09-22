﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Factory
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            return (Triangle)this.MemberwiseClone();
        }
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
