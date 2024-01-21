namespace WindChill.Specs;

public class WindChillBuilder_Should
{
    [Theory]
    [InlineData("-10", "20")]
    [InlineData("32", "10", "-f", "-m")]
    public void Build_WindChill_From_Valid_String_Array(params string[] args)
    {
        // Arrange
        WindChill actual = null;
        Action act = () => actual = WindChill.Build(args);
        // Act
        // Assert
        act.Should().NotThrow();
        actual.Should().NotBeNull();
    }

    [Theory]
    [InlineData("Too few arguments", "-10")]
    [InlineData("Too many arguments", "32", "10", "-f", "-m", "extra")]
    [InlineData("The input string '-f' was not in a correct format.", "-10", "-f")]
    [InlineData("The input string 'bob' was not in a correct format.", "bob", "20")]
    [InlineData("Unrecognized flag '-x'", "-10", "20", "-x")]
    [InlineData("Unrecognized flag '-x'", "-10", "20", "-f", "-x")]
    public void Reject_Invalid_Arguments(string expectedReason, params string[] args)
    {
        // Arrange
        Action act = () => WindChill.Build(args);
        // Act
        // Assert
        act.Should().Throw<Exception>().WithMessage(expectedReason);
    }
}
