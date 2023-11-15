﻿using NUnit.Framework;
using System;

namespace TestApp.UnitTests
{
    public class MatchDatesTests
    {
        [Test]
        public void Test_Match_ValidDate_ReturnsExpectedResult()
        {
            // Arrange
            string input = "31-Dec-2022";
            string expected = "Day: 31, Month: Dec, Year: 2022";

            // Act
            string result = MatchDates.Match(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_NoMatch_ReturnsEmptyString()
        {
            // Arrange
            string input = "Invalid date format";
            string expected = string.Empty;

            // Act
            string result = MatchDates.Match(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_MultipleMatches_ReturnsFirstMatch()
        {
            // Arrange
            string input = "31-Dec-2022 25-Jan-2023";
            string expected = "Day: 31, Month: Dec, Year: 2022";

            // Act
            string result = MatchDates.Match(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            string expected = string.Empty;

            // Act
            string result = MatchDates.Match(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_NullInput_ThrowsArgumentException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
        }
    }
}
