﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.00, "Very Good")]
    [TestCase(4.50, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {

        // Act
        string result = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(0, "Invalid!")]
    [TestCase(-5.00, "Invalid!")]
    [TestCase(35.00, "Invalid!")]
    [TestCase(33.50, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string result = Grades.GradeAsWords(grade);

        // Assert
       Assert.AreEqual(expected, result);
    }
}
