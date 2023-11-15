using NUnit.Framework;
using System;
using System.Linq;

namespace TestApp.UnitTests
{
    public class ReverseConcatenateTests
    {
        [Test]
        public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string[] input = Array.Empty<string>();

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
        {
            // Arrange
            string[] input = { "Hello" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo("Hello"));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
        {
            // Arrange
            string[] input = { "one", "two", "three" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo("threetwoone"));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
        {
            // Arrange
            string[] input = null;

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
        {
            // Arrange
            string[] input = { "   ", "  ", "" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo("     "));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
        {
            // Arrange
            string[] input = new string[100000];
            for (int i = 0; i < 100000; i++)
            {
                input[i] = i.ToString();
            }

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

            // Assert
            Assert.That(result, Is.EqualTo(string.Join("", Enumerable.Range(0, 100000).Select(i => i.ToString()).Reverse())));
        }
    }
}
