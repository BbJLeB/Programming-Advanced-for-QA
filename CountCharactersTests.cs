using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class CountCharactersTests
    {
        [Test]
        public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new List<string>();

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new List<string> { "", "", "" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new List<string> { "a" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("a -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new List<string> { "aa", "bb", "cc" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("a -> 2\nb -> 2\nc -> 2"));
        }

        [Test]
        public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new List<string> { "!@#", "$%^", "&*(" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("! -> 1\n@ -> 1\n# -> 1\n$ -> 1\n% -> 1\n^ -> 1\n& -> 1\n* -> 1\n( -> 1"));
        }
    }
}
