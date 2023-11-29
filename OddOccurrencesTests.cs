using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class OddOccurrencesTests
    {
        [Test]
        public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { "apple", "banana", "cherry", "apple", "banana" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
        {
            // Arrange
            string[] input = new string[] { "apple", "banana", "cherry", "banana", "cherry", "apple", "kiwi" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("kiwi"));
        }

        [Test]
        public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
        {
            // Arrange
            string[] input = new string[] { "apple", "banana", "cherry", "banana", "cherry", "apple", "kiwi", "banana", "kiwi" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("kiwi, banana"));
        }

        [Test]
        public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "apple", "Banana", "Cherry", "apple", "banana", "cherry" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("banana, cherry"));
        }
    }
}
