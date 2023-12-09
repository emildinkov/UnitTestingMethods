using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
       string actual = StringReverse.Reverse(input);

        // Assert
       Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert + Дължината на текста трябва да е 1 !
       Assert.AreEqual ("X", actual);
       Assert.AreEqual (1, actual.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "QWE";

        //Act
       string actual = StringReverse.Reverse (input);

        // Assert
        Assert.AreEqual("EWQ", actual);
        Assert.AreEqual(input.Length, actual.Length);
                        // Не трябва да се променя дължината.
    }
}
