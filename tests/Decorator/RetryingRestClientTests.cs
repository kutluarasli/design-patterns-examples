using System;
using DesignPatternExamples.Decorator;
using Moq;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Decorator
{
    public class RetryingRestClientTests
    {

        [Test]
        public void Get_ShouldRetry3Times()
        {
            // Arrange
            var underlyingRestClient = new Mock<IRestClient>();
            underlyingRestClient.Setup(x => x.Get()).Throws(new Exception());
            
            //Act
            var sut = new RetryingRestClient(underlyingRestClient.Object);
            Assert.Throws<Exception>(() => sut.Get());
            
            //Assert
            underlyingRestClient.Verify(x => x.Get(), Times.Exactly(3));
        }
    }
}