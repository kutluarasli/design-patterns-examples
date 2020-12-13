using DesignPatternExamples.Observer;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Observer
{
    public class ViewTests
    {
        [Test]
        public void NotifyAll()
        {
            // Arrange
            var input = "Hello World";
            var view  = new View();
            var controller = new Controller(view);
            
            //Act
            view.NotifyInputEventListeners(input);


            //Assert
            Assert.AreEqual(controller._lastestInput, input);
        }
    }
}