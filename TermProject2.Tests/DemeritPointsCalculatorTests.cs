using System;
using NUnit.Framework;

namespace TermProject2.Tests
{
    [TestFixture]
    /*
     These tests verify that demerit points are calculated correctly according to the given speed rules.
     The tests check valid speeds, boundary values, and invalid speed inputs.
     Exception handling is also tested to ensure that invalid speeds result in appropriate errors.
     */
    public class DemeritPointsCalculatorTests
    {
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_WhenSpeedIsInvalid_ThrowsException(int speed)
        {
            // Arrange
            var calculator = new DemeritPointsCalculator();

            // Act + Assert
            Assert.That(() => calculator.CalculateDemeritPoints(speed),
                Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0, 0)]
        [TestCase(65, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]

        public void CalculateDemeritPoints_WhenSpeedIsValid_ReturnsCorrectPoints(int speed, int expected)
        {
            // Arrange
            var calculator = new DemeritPointsCalculator();

            // Act
            var result = calculator.CalculateDemeritPoints(speed);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
