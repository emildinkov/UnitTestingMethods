using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Addition_WhenParametersAreNegative()
    {
        // Arrange
        Calculate calculate = new();

        // Act
        int result = calculate.Addition(-5, -2);

        // Assert
        Assert.AreEqual(-7, result);


    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
       Calculate calculate = new();

        // Act
       int result = calculate.Subtraction(5, 2);

        // Assert
        Assert.AreEqual(3, result);
    }
}
