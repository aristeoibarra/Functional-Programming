using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a list of employee , 
            // Print: "Last name: ......., Salary: .........."
            // Only those who earn more than 10,000
            // Order by last name (ascending)

            var employees = new List<Employee>
            {
                new Employee("Ariteo","Ibarra", 12000),
                new Employee("Martín", "Limón", 18000),
                new Employee("Pedro","Sánchez",5000),
                new Employee("José","Beltrán", 6350),
                new Employee("Ricardo","Melgar",6500),
                new Employee("Víctor","Zapata", 27350)
            };

            // Query Expression.    
            (
                from employee in employees
                where employee.Salary > 10000
                orderby employee.LastName ascending
                select new
                {
                    Message = $"Last Name: {employee.LastName} , Salary: {employee.Salary}"
                }
            ).ToList().ForEach(x => Console.WriteLine(x.Message));
        }
    }
}
