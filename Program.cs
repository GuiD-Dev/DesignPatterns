using DesignPatterns.AbstractFactory;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            new FactoryPattern().Dispose();
            new AbstractFactoryPattern().Dispose();
            new SingletonPattern().Dispose();
        }
    }
}
