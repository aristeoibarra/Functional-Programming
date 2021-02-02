using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create an anonymous function that calculate the factorial given an integer number

            Func<int, int> factorial = (number) =>
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            };

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The factorial of {0} is: {1}", num, factorial(num));
            Console.ReadKey();
        }
    }
}
