using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a list of clients, print the name and Last Name of the people who live in México.
            // Message : Name: ……, Last Name:……”
            List<Customers> customers = new List<Customers>
            {
                new Customers("Ricardo","Sánchez","Peru"),
                new Customers("Victor","Limón","México"),
                new Customers("Aristeo","Ibarra","México")
            };

            // Query Expression.
            (
                from customer in customers
                where customer.Country.Equals("México")
                select new
                {
                    Message = $"Name: {customer.Name}, Last Name: {customer.LastName}"
                }
            ).ToList().ForEach(x => Console.WriteLine(x.Message));

            System.Console.WriteLine("--------------------------S---------------------");

            // Method-based syntax
            (
                customers.Where(x => x.Country.Equals("México")).Select(x => new
                {
                    Message = String.Format("Name: {0}, Last Name: {1}", x.Name, x.LastName)
                })
            ).ToList().ForEach(x => Console.WriteLine(x.Message));
        }
    }
}
