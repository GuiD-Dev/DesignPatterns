namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IShape getShape(string shapeType);
    }
}