using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///  Create an anonymous function that allows us to know the average of a list (integers)

            Func<List<int>, int> average = number => number.Sum() / number.Count();
            Console.WriteLine("Averege: {0}", average(new List<int> { 10, 8, 7, 6, 10 }));
        }
    }
}
