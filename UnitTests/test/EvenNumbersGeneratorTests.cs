using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyLibrary.UnitTests;

/// <summary>
/// Create an EvenNumbersGenerator class to make the unit tests pass.
/// Use LINQ to implement the logic when picking numbers.
/// </summary>
public class EvenNumbersGeneratorTests
{
    private readonly Mock<IDataSource> _mockDataSource;
    private readonly INumbersGenerator _evenNumbersGenerator;

    public EvenNumbersGeneratorTests()
    {
        _mockDataSource = new Mock<IDataSource>(MockBehavior.Strict);
        _evenNumbersGenerator = new EvenNumbersGenerator(_mockDataSource.Object);
    }

    [Fact(DisplayName = "GetSpecialNumbers throws ArgumentException when parameter 'min' is greater or equal than 'max'")]
    public void GetSpecialNumbers_WhenMinIsGreaterOrEqualThanMax_ThrowsArgumentException()
    {
        // Arrange
        const int min = 5;
        const int max = 1;
        
        // Act
        var exception = Assert.Throws<ArgumentException>(() => _evenNumbersGenerator.GetSpecialNumbers(min, max));

        // Assert
        Assert.NotNull(exception);
		Assert.Equal("min must be less than max.", exception.Message);
        _mockDataSource.VerifyAll();
    }

    [Fact(DisplayName = "GetSpecialNumbers returns expected numbers when parameters are valid")]
    public void GetSpecialNumbers_WhenValidParams_ReturnsExpectedNumbers()
    {
        // Arrange
        const int min = 1;
        const int max = 5;
        List<int> numbers = new() { 5, 0, 1, 8, 7, 4, 9, 2, 3, 6 };
        List<int> expected = new() { 2, 4 };
        _mockDataSource.Setup(s => s.GetNumbers()).Returns(numbers);

        // Act
        var result = _evenNumbersGenerator.GetSpecialNumbers(min, max).ToList();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.True(result.SequenceEqual(expected));
        _mockDataSource.VerifyAll();
    }
}
