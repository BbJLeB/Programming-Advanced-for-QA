using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class OrdersTests
    {
        [Test]
        public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new List<string>();

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
        {
            // Arrange
            List<string> input = new List<string> { "apple 2 2.99", "banana 1 1.25", "orange 3 0.66" };

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 1.25{Environment.NewLine}orange -> 1.98"));
        }

        [Test]
        public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
        {
            // Arrange
            List<string> input = new List<string> { "apple 1 2.50", "banana 2 1.25", "orange 3 0.99" };

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo($"apple -> 2.50{Environment.NewLine}banana -> 2.50{Environment.NewLine}orange -> 2.97"));
        }

        [Test]
        public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
        {
            // Arrange
            List<string> input = new List<string> { "apple 2.5 2.99", "banana 1.75 1.25", "orange 3.5 0.66" };

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo($"apple -> 7.48{Environment.NewLine}banana -> 2.19{Environment.NewLine}orange -> 2.31"));
        }
    }
}
