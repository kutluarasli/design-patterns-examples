using System;
using DesignPatternExamples.State;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.State
{
    public class CustomerOrderTests
    {
        [Test]
        public void Cancel_WhenInPackingState_ShouldThrowInvalidOperation()
        {
            // Arrange
            var sut = CustomerOrder.CreateNewOrder();
            sut.ChangeState(new PackingState());

            // Act & Act
            Assert.Throws<InvalidOperationException>(() => sut.Cancel());
        }
    }
}