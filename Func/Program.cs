using System;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///  Encapsulates a method that has no parameters and 
            ///  returns a value of the type specified by the TResult parameter.
            /// </summary>
            /// public delegate TResult Func<out TResult>();
            Func<int> getRamdonNumber = () => new Random().Next(1, 100);
            Console.WriteLine("Ramdon Number: " + getRamdonNumber());

            /// <summary>
            ///  Encapsulates a method that has one parameter and returns a value of the type specified by the TResult parameter.
            /// </summary>
            /// public delegate TResult Func<in T,out TResult>(T arg);
            Func<int, int> squared = (number) => (int)Math.Pow(number,2);
            Console.WriteLine("\nSquared: " + squared(5));

            /// <summary>
            ///     1) Func is a type of integrate delegate.
            ///     2) The function delegate type must return a value.
            ///     3) Func delegate type can have zero to 16 input parameters.
            ///     4) Func delegate does not allow ref and out parameters.
            ///     5) Func delegate type can be used with an anonymous method or lambda expression.
            /// </summary>
            Console.ReadKey();
        }
    }
}
