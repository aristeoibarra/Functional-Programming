using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               You use a lambda expression to create an anonymous function.

             * Expression lambda: 
                             (input-parameters) => expression

             * Statement lambda:
                             (input-parameters) => { <sequence-of-statements> }                                 
             */

            //Even or odd
            Func<int, bool> isEven = (number) => number % 2 == 0;
            Console.WriteLine($"The number is even: {isEven(7)}");

            //Sum of two numbers
            //static int sum(int a, int b) => a + b;
            Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine("\nThe sum is: " + sum(5, 6));
            Console.WriteLine();

            //Random Number
            Func<int, int> showNumber = (number) =>
            {
                if (number > 50)
                    return number;
                else
                    Console.WriteLine("The random number is less than 50");
                    return 0;
            };
            Console.WriteLine("Random Number : {0}", showNumber(new Random().Next(1, 100)));
                                 
            Console.ReadKey();
        }
    }
}
