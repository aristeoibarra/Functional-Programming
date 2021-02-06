using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an Array[], with a student's grades.
            // Print approved grades, knowing that it is approved with a grade greater than 70.

            int[] grades = { 50, 100, 80, 60, 68, 94, 87 };

            (
                from grade in grades
                where grade > 70
                orderby grade descending
                select grade
            ).ToList().ForEach(x => Console.Write(x + " "));

            System.Console.WriteLine("\n-----------------------------------");
            // Given an Array [], get the elements that are even numbers.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            var even = numbers.Where(x => x % 2 == 0);

            Console.WriteLine("Count: " + even.Count());
            Console.WriteLine("Max: " + even.Max());
            Console.WriteLine("Average: " + even.Average());
            Console.WriteLine("First: " + even.First());
        }
    }
}
