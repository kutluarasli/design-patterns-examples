using System.Linq;
using DesignPatternExamples.Singleton;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Singleton
{
    public class SingletonWithStasticConsImplTests
    {
     
        [Test]
        public void GetObject_TrueStory()
        {
            // Act
            var instance1 = SingletonWithStaticConsImpl.GetObject();
            var instance2 = SingletonWithStaticConsImpl.GetObject();

            // Assert
            Assert.IsTrue(instance1 == instance2);
        }
    }
}