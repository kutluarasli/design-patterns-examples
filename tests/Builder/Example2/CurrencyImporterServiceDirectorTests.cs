using DesignPatternExamples.Builder.Example2;
using Moq;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Builder.Example2
{
    public class CurrencyImporterServiceDirectorTests
    {

        [Test]
        public void GetCurrencyImporterService_ShouldCreateObject()
        {
            // Arrange
            var builder = new Mock<ICurrencyImporterServiceBuilder>();
            var sut = new CurrencyImporterServiceDirector(builder.Object);

            //Act
            sut.GetCurrencyImporterService();
            
            //Assert
            builder.Verify(x => x.BuildCurrencyProvider(), Times.Once);
            builder.Verify(x => x.BuildCurrencyStorage(), Times.Once);
        }
    }
}