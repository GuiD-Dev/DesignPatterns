using System;

namespace DesignPatterns.AbstractFactory.ConcreteShapes
{
    public class Rectangle : IShape
    {
        public void draw() {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}