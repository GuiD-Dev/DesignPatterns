using System;

namespace DesignPatterns.AbstractFactory.ConcreteShapes
{
    public class RoundedRectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}