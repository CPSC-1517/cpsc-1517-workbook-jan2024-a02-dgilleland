using Assorted;

namespace DemoClasses;

public class DemoFractions
{
    public static void Run(string[] args)
    {
        // Validation: the first arg should be -f
        if(args.Length < 2 || args[0] != "-f")
            throw new ArgumentException("Incorrect args for Fractions demo");

        List<Fraction> numbers = ParseArgs(args.Skip(1));
        //  HINT:                              \______/
        //                   one of the LINQ methods |
        //  LINQ: Language INtegrated Query

        Fraction product = new(1,1);
        foreach(Fraction value in numbers)
            product = product * value;
        
        Console.WriteLine($"The product of those fractions is {product}");
    }

    private static List<Fraction> ParseArgs(IEnumerable<string> args)
    {
        // TODO: Validation
        List<Fraction> results = new(); // Initialize a new list
        foreach(string item in args)
            results.Add(Fraction.Parse(item));
        return results;
    }
}
