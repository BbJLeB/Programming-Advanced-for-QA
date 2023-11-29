using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class MinerTests
    {
        [Test]
        public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new List<string>();

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
        {
            // Arrange
            List<string> input = new List<string> { "gold 5", "Silver 10", "Gold 3", "Silver 20" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
        }

        [Test]
        public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
        {
            // Arrange
            List<string> input = new List<string> { "gold 5", "silver 10", "copper 3", "gold 8", "silver 20" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo($"gold -> 13{Environment.NewLine}silver -> 30{Environment.NewLine}copper -> 3"));
        }

        [Test]
        public void Test_Mine_WithNegativeResourceAmounts_ShouldTreatThemAsZero()
        {
            // Arrange
            List<string> input = new List<string> { "gold 5", "silver -10", "copper 3", "gold -8", "silver 20" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo($"gold -> -3{Environment.NewLine}silver -> 20{Environment.NewLine}copper -> 3"));
        }
    }
}
