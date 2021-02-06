using System.Collections.Generic;

namespace Exercise5
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, List<int> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }
}