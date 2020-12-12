using System.Net;
using DesignPatternExamples.ChainOfResponsibility.Example1;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.ChainOfResponsibility.Example1
{
    public class ChainTests
    {
        [Test]
        public void HandleError_WhenSystemException_ShouldReturnInternalServerError()
        {
            // Arrange
            
            var systemHandler = new SystemExceptionHandler(null);
            var businessHandler = new BusinessExceptionHandler(systemHandler);
            var notFoundHandler = new NotFoundExceptionHandler(businessHandler);
            var exception = new SystemException();

            //Act
            var result = notFoundHandler.HandleError(exception);

            //Assert
            Assert.AreEqual(result.StatusCode, HttpStatusCode.InternalServerError);
        }
    }
}