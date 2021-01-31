using System;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryPattern : PatternSample
    {
        public AbstractFactoryPattern() : base("Abstract")
        {
            var simpleShapeFactory = FactoryProducer.getFactory(false);

            var simpleRect = simpleShapeFactory.getShape("RECTANGLE");
            simpleRect.draw();
            
            var simpleSquare = simpleShapeFactory.getShape("SQUARE");
            simpleSquare.draw();
            
            var roundedShapeFactory = FactoryProducer.getFactory(true);
            
            var roundedRect = roundedShapeFactory.getShape("RECTANGLE");
            roundedRect.draw();
            
            var roundedSquare = roundedShapeFactory.getShape("SQUARE");
            roundedSquare.draw();
        }
    }
}