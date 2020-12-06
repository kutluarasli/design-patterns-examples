using DesignPatternExamples.FactoryMethod.Example2;
using Moq;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.FactoryMethod.Example2
{
    public class LoggerFactoryTests
    {
        [Test]
        public void Create_WhenNoConfigurationProvided_ShouldUseDefaultLogger()
        {
            // Arrange
            var loggingConfigurationSource = new Mock<LoggingConfigurationSource>();
            loggingConfigurationSource
                .Setup(x => x.ReadLoggerName())
                .Returns(string.Empty);
            
            // Act
            var sut = new LoggerFactory(loggingConfigurationSource.Object);
            var logger = sut.CreateLogger();
            
            // Assert
            Assert.IsInstanceOf<ConsoleLogger>(logger);
        }
        
        [Test]
        public void Create_WhenLoggerNameIsConfigured_ShouldCreateConfiguredLogger()
        {
            // Arrange
            var loggingConfigurationSource = new Mock<LoggingConfigurationSource>();
            loggingConfigurationSource
                .Setup(x => x.ReadLoggerName())
                .Returns(typeof(DummyLogger).AssemblyQualifiedName);

            //Act
            var sut = new LoggerFactory(loggingConfigurationSource.Object);
            var logger = sut.CreateLogger();

            //Assert
            Assert.IsInstanceOf<DummyLogger>(logger);
        }

        private class DummyLogger : ILogger
        {
            public void LogError(string log)
            {
            }
        }

    }
}