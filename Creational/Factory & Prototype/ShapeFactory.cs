using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Creational.Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
           
                case ShapeType.Rectangle:
                    return new Rectangle();
                
                case ShapeType.Triangle:
                    return new Triangle();
                
                default:
                    throw new Exception("Not handle shape");
            }
        }
    }
}
