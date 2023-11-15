using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class MatchPhoneNumbersTests
    {
        [Test]
        public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
            string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "No valid phone numbers here.";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_Match_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, InvalidNumber, +359-2-555-5555";
            string expected = "+359-2-124-5678, +359-2-555-5555";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
