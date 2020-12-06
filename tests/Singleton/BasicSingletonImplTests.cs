using System.Linq;
using DesignPatternExamples.Singleton;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Singleton
{
    public class BasicSingletonImplTests
    {
        [TearDown]
        public void TearDown()
        {
            BasicSingletonImpl.Clear();
        }

        [Test]
        public void GetObject_TrueStory()
        {
            // Act
            var instance1 = BasicSingletonImpl.GetObject();
            var instance2 = BasicSingletonImpl.GetObject();

            // Assert
            Assert.IsTrue(instance1 == instance2);
        }

        [Test]
        public void GetObject_WhenInAMultiThreadedEnvironment_CanProduceMultipleInstances()
        {
            //Arrange & Act
            var listOfCreatedObjects = MultiThreadSingletonEnvironment<BasicSingletonImpl>.Run(100, BasicSingletonImpl.GetObject);

            //Assert
            var totalNumberOfCreatedObjects = listOfCreatedObjects.Distinct().Count();
            Assert.Greater(totalNumberOfCreatedObjects, 1);
        }
    }
}