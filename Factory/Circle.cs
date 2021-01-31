using System;

namespace DesignPatterns.Factory
{
    public class Circle : IShape
    {
        public void area(params double[] args)
        {
            Console.WriteLine($"The area of this circle is: {(Math.PI * Math.Pow(args[0], 2)).ToString("F")}");
        }

        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}