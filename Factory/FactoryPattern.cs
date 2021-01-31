using System;

namespace DesignPatterns.Factory
{
    public class FactoryPattern : PatternSample
    {
        public FactoryPattern() : base("Factory")
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.getShape("CIRCLE");
            circle.draw();
            circle.area(7);

            var rectangle = shapeFactory.getShape("RECTANGLE");
            rectangle.draw();
            rectangle.area(2, 3);

            var square = shapeFactory.getShape("SQUARE");
            square.draw();
            square.area(5);
        }
    }
}