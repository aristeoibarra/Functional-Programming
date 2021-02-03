using System;
using System.Linq;
using System.Collections.Generic;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            var squares =
                Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.Write(num + " ");
            }

            System.Console.WriteLine();

            var students = new List<Student>
            {
                new Student{Name="Aristeo",Note=94},
                new Student {Name = "Pedro",Note = 50},
                new Student {Name = "Jorge",Note = 80},
                new Student {Name = "Andres",Note = 30}
            };

            var namesStudents = students.Select(x => x.Name).ToList();
            namesStudents.ForEach(x => Console.WriteLine(x));
        }

        public class Student
        {
            public string Name { get; set; }
            public int Note { get; set; }
        }
    }
}
