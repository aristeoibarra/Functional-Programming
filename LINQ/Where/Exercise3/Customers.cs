namespace Exercise3
{
    public class Customers
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public Customers(string name, string lastName, string country)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Country = country;
        }
    }
}