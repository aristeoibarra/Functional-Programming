using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 8, 3, 4, 1, 2, 9, 8, 7, 41, 100 };

            // Generate a new list with the square of the numbers.
            // x => Math.Pow(x,2) or x => x * x
            numbers.Select(x => x * x).ToList().ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\n-------------------------------------------------");
            numbers.Select(x =>
            {
                if (x == 100)
                    return x * 100;
                return x;
            }).ToList().ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\n-------------------------------------------------");

            var persons = new List<Person>
            {
                new Person { Name = "Aristeo" , LastName = "Ibarra",Age = 21 },
                new Person { Name = "Luis", LastName ="Acosta", Age = 40 },
                new Person { Name = "Francisco" , LastName = "Cordero", Age = 19 },
                new Person { Name = "Patricia", LastName = "Martínez",Age = 51 },
                new Person { Name = "Isabel", LastName = "Espinoza", Age = 33 }
            };

            // Get indexs
            //persons.Select((p, index) => new { p.Name, index }).ToList().ForEach(x => Console.WriteLine(x.index));

            // Print list. for example: "A.Ibarra"
            //                          "L.Acosta"

            Console.WriteLine("\n-------------------------------------------------");

            persons.Select(x => new
            {
                Message = String.Format("{0}.{1}", x.Name.Substring(0, 1), x.LastName)
            }).ToList().ForEach(x => Console.WriteLine(x.Message));

            Console.WriteLine("-------------------------------------------------");
            // get person's ages
            persons.Select(x => x.Age).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
