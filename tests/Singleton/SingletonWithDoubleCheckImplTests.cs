using System.Linq;
using DesignPatternExamples.Singleton;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Singleton
{
    public class SingletonWithDoubleCheckImplTests
    {
        [TearDown]
        public void TearDown()
        {
            SingletonWithDoubleCheckImpl.Clear();
        }

        [Test]
        public void GetObject_TrueStory()
        {
            // Act
            var instance1 = SingletonWithDoubleCheckImpl.GetObject();
            var instance2 = SingletonWithDoubleCheckImpl.GetObject();

            // Assert
            Assert.IsTrue(instance1 == instance2);
        }

        [Test]
        public void GetObject_WhenInAMultiThreadedEnvironment_WillProduceAbsolutelySingleInstance()
        {
            //Arrange & Act
            var listOfCreatedObjects = MultiThreadSingletonEnvironment<SingletonWithDoubleCheckImpl>
                .Run(100, SingletonWithDoubleCheckImpl.GetObject);

            //Assert
            var totalNumberOfCreatedObjects = listOfCreatedObjects.Distinct().Count();
            Assert.AreEqual(1,  totalNumberOfCreatedObjects);
        }
    }
}