using DesignPatternExamples.Iterator.Example1;
using NUnit.Framework;


namespace DesignPatternExamples.Tests.Iterator.Example1
{
    public class ImmutableListEnumeratorTests
    {
        [Test]
        public void MoveNext_ShouldVisitAllElements()
        {
            // Arrange
            var customers = new[]
            {
                new Customer { Id = 1 },
                new Customer { Id = 2 },
                new Customer { Id = 3 }
            };

            var list = new ImmutableList<Customer>(customers);

            //Act
            using var sut = list.GetEnumerator();
            var counter = 0;
            while (sut.MoveNext())
            {
                counter++;
            }

            //Assert
            Assert.AreEqual(customers.Length, counter);
        }
    }
}