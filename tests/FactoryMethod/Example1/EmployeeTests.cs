using System;
using DesignPatternExamples.FactoryMethod.Example1;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.FactoryMethod.Example1
{
    public class EmployeeTests
    {
        [Test]
        public void Create_TrueStory()
        {
            // Arrange
            var name = "Kutlu";
            
            // Act
            var newEmployee = Employee.CreateNewEmployee(name);
            
            // Assert
            Assert.AreNotEqual(Guid.Empty,  newEmployee.Id);
            Assert.AreEqual(name, newEmployee.FullName);
            Assert.AreEqual(Employee.MinimumWage, newEmployee.Salary);
        }
    }
}