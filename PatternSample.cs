using System;

namespace DesignPatterns
{
    public class PatternSample : IDisposable
    {
        public PatternSample(string patternName)
        {
            Console.WriteLine($"{patternName.ToUpper()} PATTERN SAMPLES");
        }

        public void Dispose()
        {
            Console.WriteLine();
        }
    }
}