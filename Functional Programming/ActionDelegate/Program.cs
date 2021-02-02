using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///  Encapsulates a method that has a single parameter and does not return a value.
            ///  Action delegate type can have zero to 16 input parameters.
            /// </summary>
            /// Void
            /// public delegate void Action<in T>(T obj);

            Action<string> Show = (message) => Console.WriteLine(message);
            Show("Hello World!!!");

            Console.ReadKey();
        }
    }
}
