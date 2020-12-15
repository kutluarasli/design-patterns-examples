using DesignPatternExamples.Flyweight.Example2;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Flyweight.Example2
{
    public class DbConnectionPoolTests
    {
        [Test]
        public void LeaseConnection_ShouldReturnAvailableConnection()
        {
            // Arrange
            var poolSize = 10;
            var sut = new DbConnectionPool(poolSize);
            
            //Act
            var dbConnection =  sut.LeaseConnection();
            
            //Assert
            Assert.NotNull(dbConnection);
            Assert.AreEqual(poolSize - 1, sut.AvailableConnectionCount);
        }
    }
}