using NUnit.Framework;

namespace TermProject2.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(7, "7")]
        public void GetOutput_GivenNumber_ReturnsCorrectText(int number, string expected)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetOutput(number);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
