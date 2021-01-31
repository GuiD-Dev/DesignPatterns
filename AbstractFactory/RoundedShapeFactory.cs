using System;
using DesignPatterns.AbstractFactory.ConcreteShapes;

namespace DesignPatterns.AbstractFactory
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType)
        {
            if (string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new RoundedRectangle();         
            }
            else if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new RoundedSquare();
            }
            return null;
        }
    }
}