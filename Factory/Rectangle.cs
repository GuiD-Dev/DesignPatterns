using System;

namespace DesignPatterns.Factory
{
    public class Rectangle : IShape
    {
        public void area(params double[] args)
        {
            Console.WriteLine($"The area of this retangle is: {(args[0] * args[1]).ToString("F")}");
        }

        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}