namespace DesignPatterns.Factory
{
    public class FactoryPattern
    {
        public FactoryPattern()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.getShape("CIRCLE");
            shape1.draw();
            shape1.area(7);

            Shape shape2 = shapeFactory.getShape("RECTANGLE");
            shape2.draw();
            shape2.area(2, 3);

            Shape shape3 = shapeFactory.getShape("SQUARE");
            shape3.draw();
            shape3.area(5);
        }
    }
}