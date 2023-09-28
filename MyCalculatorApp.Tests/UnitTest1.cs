//using System;
using Xunit;
using MyCalculatorApp; // Adjust the namespace as needed

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 4);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Subtract(7, 3);

        // Assert
        Assert.Equal(4, result);
    }
}
