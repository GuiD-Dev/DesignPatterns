using System;

namespace DesignPatterns.Factory
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }		
            else if (string.Equals(shapeType, "CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if (string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
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