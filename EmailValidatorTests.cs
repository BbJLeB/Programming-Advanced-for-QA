using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class EmailValidatorTests
    {
        [TestCase("user@example.com")]
        [TestCase("john.doe123@company.org")]
        [TestCase("alice_smith@domain.net")]
        public void Test_ValidEmails_ReturnsTrue(string email)
        {
            // Arrange

            // Act
            bool result = EmailValidator.IsValidEmail(email);

            // Assert
            Assert.That(result, Is.True);
        }

        [TestCase("invalidemail")]
        [TestCase("missing@dotcom")]
        [TestCase("spaces @in@ email")]
        public void Test_InvalidEmails_ReturnsFalse(string email)
        {
            // Arrange

            // Act
            bool result = EmailValidator.IsValidEmail(email);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
