using System.Collections.Generic;
using DesignPatternExamples.Prototype;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Prototype
{
    public class OrderTests
    {
        [Test]
        public void Clone_ShouldCreateANewObject()
        {
            // Arrange
            var orderDetail = new OrderDetail
            {
                Id = 1,
                Barcode = "adsasdsa",
                Quantity = 10
            };

            var order = new Order
            {
                Id = 1,
                CustomerName = "Kutlu",
                OrderDetails = new List<OrderDetail> {orderDetail}
            };

            //Act
            var newOrder = (Order) order.Clone();
            
            //Assert
            Assert.AreNotEqual(order, newOrder);
        }
    }
}