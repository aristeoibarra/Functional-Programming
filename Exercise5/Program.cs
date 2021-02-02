using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create an anonymous function that receives 3 parameters of integers type.
            /// The function must return TRUE if the parameters are primes numbers, otherwise return FALSE.
           
            Func<int, bool> isPrime = (number) =>
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                        count++;
                }

                Func<int, bool> result = (count) => count == 2;
                return result(count);
            };

            Func<int, int, int, bool> prime = (num1, num2, num3) => (isPrime(num1) && isPrime(num2) && isPrime(num3));

            Console.WriteLine("Are primes? {0}", prime(2, 3, 5));
        }
    }
}
