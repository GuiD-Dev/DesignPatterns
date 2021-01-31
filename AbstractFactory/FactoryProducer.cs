namespace DesignPatterns.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(bool rounded) =>
            rounded ? new RoundedShapeFactory() : new SimpleShapeFactory();
    }
}