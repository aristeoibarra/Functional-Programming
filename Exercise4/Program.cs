using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create a list of integers (numbers).
            /// Create an anonymous function that allows us to know if the 45 number exist within the list
        
            List<int> numbers = new List<int> { 91, 8, 9, 6, 7, 79, 6, 45, 32, 987 };

            Func<List<int>, bool> exist = (number) => number.Exists(x => x == 79);

            Console.WriteLine($"Exist 79: {exist(numbers)}");
        }
    }
}
