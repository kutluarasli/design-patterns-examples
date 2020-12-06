using System;
using DesignPatternExamples.Builder.Example1;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Builder.Example1
{
    public class EmployeeBuilderTests
    {
        [Test]
        public void Build_WhenOptionalValuesAreNotProvided_ShouldCreateWithDefaultValues()
        {
            // Arrange
            var name = "Kutlu";
            var birthday = DateTime.Today.AddYears(-30);

            //Act
            var result = new EmployeeBuilder(name, birthday)
                .Build();

            //Assert
            Assert.AreEqual(name, result.FullName);
            Assert.AreEqual(birthday, result.Birthday);
            Assert.AreEqual(EmployeeBuilder.MinimumWage, result.Salary);
            Assert.AreEqual(EmployeeBuilder.DefaultType, result.Type);
            Assert.IsNull(result.FavoriteMovie);
        }
        
        [Test]
        public void Build_WhenOptionalValuesAreProvided_ShouldCreateWithIt()
        {
            // Arrange
            var name = "Kutlu";
            var birthday = DateTime.Today.AddYears(-30);
            var favoriteMovice = "Lord Of The Rings";
            var salary = 1000;
            var type = EmployeeType.Consultant;

            //Act
            var result = new EmployeeBuilder(name, birthday)
                .WithSalary(1000)
                .WithType(EmployeeType.Consultant)
                .WithFavoriteMovie(favoriteMovice)
                .Build();

            //Assert
            Assert.AreEqual(name, result.FullName);
            Assert.AreEqual(birthday, result.Birthday);
            Assert.AreEqual(salary, result.Salary);
            Assert.AreEqual(type, result.Type);
            Assert.AreEqual(favoriteMovice, result.FavoriteMovie);
        }
    }
}