using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Aristeo",new List<int>{100,70,96,63,75}),
                new Student("José",new List<int>{73,60,100,75,80}),
                new Student("Mónica",new List<int>{90,95,98,100,90}),
                new Student("Felipe",new List<int>{60,100,62,80,90})
            };

            (
                from student in students
                let average = student.Grades.Average()
                where average > 90
                select new { student.Name, average }
            ).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
