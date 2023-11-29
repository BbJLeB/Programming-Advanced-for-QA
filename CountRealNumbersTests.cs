using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class CountRealNumbersTests
    {
        [Test]
        public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            double[] input = new double[] { };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleNumber_ShouldReturnCountString()
        {
            // Arrange
            double input = 5.5;

            // Act
            string result = CountRealNumbers.Count(new double[] { input });

            // Assert
            Assert.That(result, Is.EqualTo("5.5 -> 1"));
        }


        [Test]
        public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
        {
            // Arrange
            double[] input = { 2.5, 3.5, 2.5, 3.5, 2.5 };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("2.5 -> 3\n3.5 -> 2"));
        }

        [Test]
        public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
        {
            // Arrange
            double[] input = new double[] { -1.5, -1.5, -3.0, -2.0 };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("-1.5 -> 2\n-3.0 -> 1\n-2.0 -> 1"));
        }

        [Test]
        public void Test_Count_WithZero_ShouldReturnCountString()
        {
            // Arrange
            double[] input = new double[] { 0 };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("0 -> 1"));
        }
    }
}
