using System;
using ConsoleCalculator;

namespace CalculatorTests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TwoPlusTwoShouldEqualFour()
    {
        // Arrange Prerequisites
        Calculator calc = new Calculator();
        int x = 2;
        int y = 2;
        int z = 4;

        // Act and Assert
        Assert.AreEqual(z, calc.Add(x, y));
    }

    [TestMethod]
    public void TwoMinusTwoShouldEqualZero()
    {
        // Arrange Prerequisites
        Calculator calc = new Calculator();
        int x = 2;
        int y = 2;
        int z = 0;

        // Act and Assert
        Assert.AreEqual(z, calc.Subtract(x, y));
    }

    [TestMethod]
    public void TwoTimesTwoShouldEqualFour()
    {
        // Arrange
        Calculator calc = new Calculator();
        int x = 2;
        int y = 2;
        int z = 4;

        // Act and Assert
        Assert.AreEqual(z, calc.Multiply(x, y));
    }

    [TestMethod]
    public void TwoDividedByTwoShouldEqualOne()
    {
        // Arrange
        Calculator calc = new Calculator();
        int x = 2;
        int y = 2;
        int z = 1;

        // Act and Assert
        Assert.AreEqual(z, calc.Divide(x, y));
    }
}
