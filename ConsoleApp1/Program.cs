using System;

namespace Singleton
    {
    class Program {
        static void Main(string[] args) {

            Console.Title = "Singleton parttern"; 
            //call the property getter twice 
            var instance1 = Logger.Instance;
            var instance2 = Logger.Instance;

            if (instance1 == instance2 && instance2 == Logger.Instance) {
                Console.WriteLine("instance are the same.");

            }
            instance1.Log($"Message from {nameof(instance1)}");
            instance1.Log($"Message from {nameof(instance2)}");
            Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");
            

        }
    }
}
