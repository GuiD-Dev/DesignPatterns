using System;

namespace DesignPatterns.AbstractFactory.ConcreteShapes
{
    public class RoundedSquare : IShape
    {
        public void draw() {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}