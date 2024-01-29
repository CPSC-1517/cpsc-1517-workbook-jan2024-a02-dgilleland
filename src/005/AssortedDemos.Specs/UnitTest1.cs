namespace AssortedDemos.Specs;
using Assorted;
public class Fraction_Should
{
    [Fact]
    public void Construct_With_Numerator_And_Denominator()
    {
        // Arrange
        int givenNumerator = 5, givenDenominator = 7;
        // Act
        Fraction sut = new(givenNumerator, givenDenominator);
        // Assert
        sut.Numerator.Should().Be(givenNumerator);
        sut.Denominator.Should().Be(givenDenominator);
    }

    [Fact]
    public void Express_Value_As_Text()
    {
        // Arrange
        int givenNumerator = 3, givenDenominator = 4;
        string expectedText = "3/4";
        Fraction sut = new(givenNumerator, givenDenominator);
        // Act
        string actual = sut.ToString();
        // Assert
        actual.Should().Be(expectedText);
    }
}