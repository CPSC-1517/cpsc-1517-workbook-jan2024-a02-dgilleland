using System.Diagnostics;

namespace WindChill.Specs;
// `ctrl` + `;` + `a`
public class WindChill_Should
{
    [Fact] // Annotation that identifies this as a test
    public void Construct_With_AirTemperature_And_WindSpeed()
    {
        // Arrange - Setup our test condition
        double givenTemp = -10, givenWind = 20;

        // Act - What it is that we are testing
        // - sut - System Under Test
        WindChill sut = new(givenTemp, givenWind);

        // Assert - Does it do what it should
        sut.AirTemperature.Should().Be(givenTemp);
        sut.WindSpeed.Should().Be(givenWind);
    }

    [Fact]
    public void Use_Celsius_If_Not_Specified()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        // Act
        var actual = sut.TemperatureUnits;
        // Assert
        actual.Should().Be('C');
    }

    [Fact]
    public void Use_KmPerHour_If_Not_Specified()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        // Act
        string actual = sut.WindSpeedUnits;
        // Assert
        actual.Should().Be("km/h");
    }

    [Fact]
    public void Calculate_Wind_Chill_Using_Default_Units()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        double expected = -17.9; // From our table of test data
        // Act
        var actual = sut.FeelsLike;
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Represent_WindChill_As_Text()
    {
        // Arrange
        string expected = $"-10{'\u00B0'}C at 20km/h feels like -17.9{'\u00B0'}C";
        var sut = new WindChill(-10, 20);
        // Act
        string actual = sut.ToString();
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Reject_Temperature_Above_Freezing()
    {
        // Arrange
        Action act = () => new WindChill(1, 20);
        // Act
        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Reject_WindSpeed_Below_10kph()
    {
        // Arrange
        Action act = () => new WindChill(0, 9.99999);
        // Act
        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("*Wind speeds below 10 kph are not allowed*");
    }

    [Fact]
    public void Reject_WindSpeed_Over_70kph()
    {
        // Arrange
        Action act = () => new WindChill(0, 71);
        // Act
        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("*Wind speeds above 70 kph are not allowed*");
    }

    [Fact]
    public void Represent_Temperature_As_Farenhiet()
    {
        // Arrange
        WindChill sut = new(32, 'F', 10, "m/h");
        string expected = $"32{'\u00B0'}F at 10m/h feels like 23.7{'\u00B0'}F";

        // Act
        var actual = sut.FeelsLike;
        var actualUnits = sut.TemperatureUnits;
        var actualWindChill = sut.ToString();
        // Assert
        actual.Should().Be(23.7);
        actualUnits.Should().Be('F');
        actualWindChill.Should().Be(expected);
    }

    [Fact(Skip = "Demo In Class")]
    public void Represent_WindSpeed_As_MilesPerHour()
    {
        // Arrange
        WindChill sut = new(32, 'F', 10, "m/h");
        string expected = $"32{'\u00B0'}F at 10m/h feels like 23.7{'\u00B0'}F";
        // Act
        var actualUnits = sut.WindSpeedUnits;
        var actualWindChill = sut.ToString();
        // Assert
        actualUnits.Should().Be("m/h");
        actualWindChill.Should().Be(expected);
    }
}