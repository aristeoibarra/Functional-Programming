using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Generate a sequence of integers from 1 to 10
            // and then select their squares.
            var squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n--------------------------------");

            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            // The second parameter represents the index of the data source.
            // (element, index) => IEnumerable<TResult>
            (
                fruits.Select((fruit, index) => new
                { 
                    fruit, 
                    index 
                })
            ).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
