using System;

namespace DesignPatterns.Singleton
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();
        private bool ready = false;

        private SingleObject() {}

        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine($"Single Object {(ready ? "Ready!" : "Loading...")}");
            ready = true;
        }
    }
}