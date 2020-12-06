using System;

namespace DesignPatternExamples.Builder.Example1
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string FavoriteMovie { get; set; }
        public decimal Salary { get; set; }
        public EmployeeType Type { get; set; }
    }
}