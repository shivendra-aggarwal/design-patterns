using System;

namespace Singleton.Library
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton singleton = null;
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static Singleton Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Singleton();
                }
                return singleton;
            }
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
