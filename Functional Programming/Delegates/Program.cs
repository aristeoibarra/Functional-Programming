using System;

namespace Delegates
{
    class Program
    {
        public delegate int PerformCalculation(int x, int y);

        /// Create a method for a delegate.
        static int Sum(int x, int y) => x + y;

        /// Create a method for a delegate.
        static int Subtract(int x, int y) => x - y;

        static void Main(string[] args)
        {
            // Instantiate the delegate.
            PerformCalculation performSum = new PerformCalculation(Sum);

            // Call the delegate.
            Console.WriteLine("Sum: " + performSum(10,5));

            PerformCalculation performSubs = Subtract;
            Console.WriteLine("Subtract: " + performSubs(9,4));

            Console.ReadKey();
        }
    }
}
