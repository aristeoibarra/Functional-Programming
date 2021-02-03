using System;
using System.Linq;
using System.Collections.Generic;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source.
            int[] scores = new int[] { 70, 100, 90, 80, 50, 60 };

            // Query Expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query to produce the results
            foreach (var score in scoreQuery)
            {
                Console.Write(score + " ");
            }

            System.Console.WriteLine();

            // Method-based syntax
            IEnumerable<int> scoreQuery2 = scores.Where(x => x > 80);

            foreach (int score in scoreQuery2)
            {
                Console.Write(score + " ");
            }
        }
    }
}
