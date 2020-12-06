using System.Linq;
using DesignPatternExamples.Singleton;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Singleton
{
    public class SingletonWithLazyImplTests
    {
        [TearDown]
        public void TearDown()
        {
            SingletonWithLazyImpl.Clear();
        }

        [Test]
        public void GetObject_TrueStory()
        {
            // Act
            var instance1 = SingletonWithLazyImpl.GetObject();
            var instance2 = SingletonWithLazyImpl.GetObject();

            // Assert
            Assert.IsTrue(instance1 == instance2);
        }

        [Test]
        public void GetObject_WhenInAMultiThreadedEnvironment_WillProduceAbsolutelySingleInstance()
        {
            //Arrange & Act
            var listOfCreatedObjects = MultiThreadSingletonEnvironment<SingletonWithLazyImpl>
                .Run(100, SingletonWithLazyImpl.GetObject);

            //Assert
            var totalNumberOfCreatedObjects = listOfCreatedObjects.Distinct().Count();
            Assert.AreEqual(1,  totalNumberOfCreatedObjects);
        }
    }
}