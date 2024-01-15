namespace App;
using static System.Console; // Allow me to just type WriteLine() instead of Console.WriteLine()

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, World!");
        if (args.Length == 0)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\tNo information was passed to this program.");
        }
        else
        {
            ForegroundColor = ConsoleColor.Green;
            foreach (string info in args)
                WriteLine($"\t{info}");
        }
        ResetColor();
    }
}
