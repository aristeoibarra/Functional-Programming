using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create an anonymous function that lets you know if a number is prime or not 

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


            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Is number {0} prime? {1}", number, isPrime(number));
        }
    }
}
