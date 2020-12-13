using DesignPatternExamples.Visitor;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Visitor
{
    public class TaxCalculatorTests
    {
        [Test]
        public void Calculate_TrueStory()
        {
            // Arrange
            var bill = new Bill();
            bill.AddProductCharge(new ProductCharge { Amount = 10});
            bill.AddServiceCharge(new ServiceCharge() { Amount = 20});

            //Act
            var sut = new TaxCalculator();
            var totalTax = sut.Calculate(bill);

            //Assert
            Assert.AreEqual(3.4M, totalTax);
        }   
    }
}