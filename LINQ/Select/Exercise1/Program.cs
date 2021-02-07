using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Ariteo","Ibarra", 12000),
                new Employee("Martín", "Limón", 18000),
                new Employee("Pedro","Sánchez",5000),
                new Employee("José","Beltrán", 6350),
                new Employee("Ricardo","Melgar",6500),
                new Employee("Víctor","Zapata", 27350)
            };

            // Print only employee names
            (employees.Select(x => x.Name)).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------------------");

            // Print the employee salaries (salary - 1000) 
            (employees.Select(x => x.Salary - 1000)).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------------------");

            // Print only employee last names ("Last name: ...........")
            (employees.Select(x => $"LastName: {x.LastName}")).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------------------");

            // Print the names and LastNames of employees
            (employees.Select(x => new { x.Name, x.LastName })).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------------------");
            
            // Only employees earning more than 10,000
            // Print names and annual salaries of employees (salary * 12)
            (
                employees.Where(x => x.Salary > 10000).Select(x => new
                {
                    x.Name,
                    AnnualSalary = x.Salary * 12
                })
            ).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
