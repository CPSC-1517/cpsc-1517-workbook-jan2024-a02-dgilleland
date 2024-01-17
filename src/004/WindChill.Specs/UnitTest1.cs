namespace WindChill.Specs;

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

    [Fact(Skip = "Demo In Class")]
    public void Use_Celsius_If_Not_Specified()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        // Act
        var actual = sut.TemperatureUnits;
        // Assert
        actual.Should().Be('C');
    }

    [Fact(Skip = "Demo In Class; Comment in the code")]
    public void Use_KmPerHour_If_Not_Specified()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        // Act
        // string actual = sut.WindSpeedUnits;
        // Assert
        // actual.Should().Be("km/h");
    }

    [Fact(Skip = "Demo In Class")]
    public void Calculate_Wind_Chill_Using_Default_Units()
    {
        // Arrange
        WindChill sut = new(-10, 20);
        double expected = -17.855; // From our table of test data
        // Act
        // var actual = sut.FeelsLike;
        // Assert
        // actual.Should().Be(expected);
    }
}