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

    [Fact]
    public void Parse_Text_Into_Fraction()
    {
        // Arrange (Given)
        string given = "3/4";
        // Act     (When)
        Fraction actual = Fraction.Parse(given);
        // Assert  (Then)
        actual.Numerator.Should().Be(3);
        actual.Denominator.Should().Be(4);
    }

    [Theory]
    [InlineData("bob")]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("12")]
    [InlineData("12/bob")]
    [InlineData("1/2/3")]
    public void Reject_Invalid_Text_When_Parsing(string given)
    {
        // Arrange
        Action act = () => Fraction.Parse(given);
        // Act
        // Assert
        act.Should().Throw<FormatException>();
    }

    [Theory]
    [InlineData("bob")]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("12")]
    [InlineData("12/bob")]
    [InlineData("1/2/3")]
    public void Reject_Invalid_Text_When_TryParsing(string given)
    {
        // Arrange
        Fraction actualObj;
        // Act
        bool actual = Fraction.TryParse(given, out actualObj);
        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void Multiply_Fractions()
    {
        // Arrange
        Fraction first = new(1, 2), second = new(3, 5);
        // Act
        Fraction actual = first * second;
        // Assert
        actual.Numerator.Should().Be(3);
        actual.Denominator.Should().Be(10);
    }
}