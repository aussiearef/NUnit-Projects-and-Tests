using NUnit.Framework.Constraints;
using StringFunctions;

namespace StringFunctionsTests
{
    public class MakeFullNameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MakeFullName_When_GenderUnspecified_Then_BeginsWithFirstName()
        {
            var firstName = "John";
            var lastName = "Doe";
            var fullName = NamesHelper.MakeFullName(firstName, lastName);

            StringAssert.StartsWith(firstName, fullName, "The test expects the full name to begin with {0}.", firstName);
            Assert.That(fullName, Does.StartWith(firstName).And.EndsWith(lastName));
        }

        [Test]
        public void MakeFullname_When_GivenFirstNameAndLastName_Then_ReturnFirstNameLastName()
        {
            var firstName = "John";
            var lastName = "Doe";
            var fullName = NamesHelper.MakeFullName(firstName, lastName);

            StringAssert.AreEqualIgnoringCase($"{firstName} {lastName}", fullName);
            Assert.That(fullName, Is.EqualTo($"{firstName} {lastName}").IgnoreCase);
        }

        [Test]
        public void MakeFullName_When_GenderUnspecified_Then_EndWithLastName()
        {
            var firstName = "John";
            var lastName = "Doe";
            var fullName = NamesHelper.MakeFullName(firstName, lastName);

            StringAssert.EndsWith(lastName, fullName);
            Assert.That(fullName, Does.EndWith(lastName));
        }

        [Test]
        public void MakeFullName_When_GenderIsMale_Then_BeginsWithMr()
        {
            const string regexPattern = "^(Mr.)";
            const string maleTitle = "Mr.";
            var firstName = "John";
            var lastName = "Doe";
            var fullName = NamesHelper.MakeFullName(firstName, lastName, Genders.Male);

            StringAssert.IsMatch(regexPattern, fullName);
            Assert.That(fullName, Does.Match(regexPattern));
        }
    }
}