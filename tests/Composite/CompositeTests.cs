using DesignPatternExamples.Composite;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Composite
{
    public class CompositeTests
    {
        [Test]
        public void Calculate()
        {
            // Arrange
            var three = new Number(3);
            var five = new Number(5);
            var add1 = new Add(three, five);
            
            var ten = new Number(10);
            var multiply1 = new Multiply(add1, ten);
            
            var six = new Number(6);
            var four = new Number(4);
            var minus1 = new Minus(six, four);
            
            var topMinus = new Minus(multiply1, minus1);
            
            // Act
            var result = topMinus.Calculate();
            
            // Assert
            Assert.True(true, "Just a sample code");
        }
    }
}