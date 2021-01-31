using System;

namespace DesignPatterns.Singleton
{
    public class SingletonPattern : PatternSample
    {
        public SingletonPattern() : base("Singleton")
        {
            var singleObj = SingleObject.getInstance();
            singleObj.showMessage();

            var sameSingleObj = SingleObject.getInstance();
            sameSingleObj.showMessage();
        }
    }
}