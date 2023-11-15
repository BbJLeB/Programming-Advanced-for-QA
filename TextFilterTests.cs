using NUnit.Framework;
using System;

namespace TestApp.UnitTests
{
    public class TextFilterTests
    {
        [Test]
        public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
        {
            // Arrange
            string[] bannedWords = { "bear" };
            string text = "This is a sample text.";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo(text));
        }

        [Test]
        public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
        {
            // Arrange
            string[] bannedWords = { "sample" };
            string text = "This is a sample text.";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo("This is a ****** text."));
        }

        [Test]
        public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
        {
            // Arrange
            string[] bannedWords = Array.Empty<string>();
            string text = "This is a sample text.";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo(text));
        }

        [Test]
        public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
        {
            // Arrange
            string[] bannedWords = { "sample text"  };
            string text = "This is a sample text.";
            string expected = "This is a ***********." ;

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
