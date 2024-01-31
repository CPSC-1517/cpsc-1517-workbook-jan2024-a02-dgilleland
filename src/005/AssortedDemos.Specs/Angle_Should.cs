namespace AssortedDemos.Specs;
using Assorted;
using static Assorted.AngleType;
/*
- Should get and set the angle's value (in degrees)
- Should calculate the equivalent angle in Radians and Grads, using the following formulas:
    Radians = Degrees * (pi / 180)
    Grads = Radians * (200 / pi)
- Should override the ToString() method to return the angle in degrees, in the following format:
    degrees °
    The Unicode character for the degrees symbol (°) is '\u00B0'
- Should get the type of angle
*/
public class Angle_Should
{
    [Fact]
    public void Construct_Angle_In_Degrees()
    {
        // Arrange
        double given = 25; // 25 degrees
        // Act
        Angle sut = new(given);
        // Assert
        sut.Degrees.Should().Be(given);
    }

    [Fact]
    public void Change_Angle_In_Degrees()
    {
        // Arrange
        double initial = 25, given = 40;
        Angle sut = new(initial);
        // Act
        sut.Degrees = given;
        // Assert
        sut.Degrees.Should().Be(given);
    }
    
    [Theory]
    [InlineData(0, 0)]
    [InlineData(180, Math.PI)]
    public void Calculate_Angle_In_Radians(double givenDegrees, double expectedRadians)
    {
        // Arrange
        Angle sut = new(givenDegrees);
        // Act
        double actual = sut.Radians;
        // Assert
        actual.Should().Be(expectedRadians);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(180, 200)]
    public void Calculate_Angle_In_Grads(double givenDegrees, double expectedGrads)
    {
        // Arrange
        Angle sut = new(givenDegrees);
        // Act
        double actual = sut.Grads;
        // Assert
        actual.Should().Be(expectedGrads);
    }

    [Theory]
    [InlineData(0, Undefined)]
    [InlineData(360, Undefined)]
    
    public void Determine_Angle_Type(double given, AngleType expected)
    {
        // Arrange
        Angle sut = new(given);
        // Act
        var actual = sut.Type;
        // Assert
        actual.Should().Be(expected);
    }
}
