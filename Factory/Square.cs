using System;

namespace DesignPatterns.Factory
{
    public class Square : Shape
    {
        public void area(params double[] args)
        {
            Console.WriteLine($"The area of this square is: {(Math.Pow(args[0], 2)).ToString("F")}");
        }

        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}