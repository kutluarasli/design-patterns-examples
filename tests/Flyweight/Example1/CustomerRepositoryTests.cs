using DesignPatternExamples.Flyweight.Example1;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Flyweight.Example1
{
    public class CustomerRepositoryTests
    {
        [Test]
        public void LoadCustomer_GivenPreviouslyLoadedCustomer_ShouldReturnSameObject()
        {
            // Arrange
            var id = 1;

            //Act
            var sut = new CustomerRepository();
            var newCustomer = sut.LoadCustomer(id);
            var sameCustomer = sut.LoadCustomer(id);

            //Assert
            Assert.AreEqual(newCustomer, sameCustomer);
        }
    }
}