namespace Exercise4
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string lastName, int salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Salary = salary;
        }
    }
}