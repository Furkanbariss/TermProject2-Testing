using NUnit.Framework;

namespace TermProject2.Tests
{
    [TestFixture]
    /* 
     These tests verify that the GetOutput method returns the correct string based on the input number.
     The tests check numbers divisible by 3, divisible by 5, divisible by both 3 and 5, and numbers that are not divisible by either.
     Parameterized test cases are used to test multiple inputs efficiently.
     */
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
