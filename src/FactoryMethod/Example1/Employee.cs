using System;

namespace DesignPatternExamples.FactoryMethod.Example1
{
    public class Employee
    {
        public static readonly decimal MinimumWage = 100;
        
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public static Employee CreateNewEmployee(string fullName)
        {
            if(string.IsNullOrWhiteSpace(fullName)) throw new ArgumentNullException(nameof(fullName));

            var newEmployee = new Employee()
            {
                Id = Guid.NewGuid(),
                FullName = fullName,
                Salary = MinimumWage
            };

            return newEmployee;
        }
    }
}