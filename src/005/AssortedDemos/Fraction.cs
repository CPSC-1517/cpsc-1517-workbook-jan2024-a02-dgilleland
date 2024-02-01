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

    public static Fraction Parse(string text)
    {
        // Guard clauses
        if(text is null)
            throw new FormatException("A null string is not a valid fraction");
        // Actual work
        string[] parts = text.Split('/');
        if(parts.Length != 2)
            throw new FormatException();
        int num = int.Parse(parts[0]);
        int denom = int.Parse(parts[1]);
        return new Fraction(num, denom);
    }

    public static bool TryParse(string text, out Fraction result)
    {
        try
        {
            result = Parse(text);
            return true;
        }
        catch (System.Exception)
        {
            result = default;
            return false; // Explicit return type
        }
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int num = a.Numerator * b.Numerator;
        int denom = a.Denominator * b.Denominator;
        return new(num, denom);
    }
}
