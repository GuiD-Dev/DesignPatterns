using System;

namespace DesignPatterns.AbstractFactory.ConcreteShapes
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}