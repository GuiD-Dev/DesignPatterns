using System;
using DesignPatterns.AbstractFactory.ConcreteShapes;

namespace DesignPatterns.AbstractFactory
{
    public class SimpleShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType){    
            if (string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();         
            }
            else if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}