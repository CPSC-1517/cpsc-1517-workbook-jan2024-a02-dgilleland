namespace Assorted;

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }
    public Fraction(int numerator, int denominator)
    {
        // Within my constructor's context, the "setter"
        // of my properties is "implied"
        Numerator = numerator;
        Denominator = denominator;
    }
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
