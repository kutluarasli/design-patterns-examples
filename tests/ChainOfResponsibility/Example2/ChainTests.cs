using System.Net;
using DesignPatternExamples.ChainOfResponsibility.Example2;
using NUnit.Framework;


namespace DesignPatternExamples.Tests.ChainOfResponsibility.Example2
{
    public class ChainTests
    {
        [Test]
        public void HandleError_WhenSystemException_ShouldReturnInternalServerError()
        {
            // Arrange

            var errorHandler = new ErrorHandlerChainBuilder(new NotFoundExceptionHandler())
                .With(new BusinessExceptionHandler())
                .With(new SystemExceptionHandler())
                .Build();
            var exception = new SystemException();
            
            // Act
       
            var result = errorHandler.HandleError(exception);

            //Assert
            Assert.AreEqual(result.StatusCode, HttpStatusCode.InternalServerError);
        }
    }
}