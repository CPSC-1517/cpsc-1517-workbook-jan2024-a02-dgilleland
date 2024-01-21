// See https://aka.ms/new-console-template for more information
using static System.Console;
using static WindChill.WindChill;
WriteLine("Hello, Wind-Chill!");

int exitCode = 0;
if (HasHelpArg())
    ShowHelp();
else
{
    try
    {
        var windChill = Build(args);
        ForegroundColor = ConsoleColor.Green;
        WriteLine(windChill);
    }
    catch(Exception ex)
    {
        exitCode = ProcessError(ex.Message);
        ShowHelp();
    }
    finally
    {
        ResetColor();
    }
}
return exitCode;


bool HasHelpArg()
{
    return args.Length > 0 && (args[0] == "--help" || args[0] == "-h");
}

int ProcessError(string message)
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"Error: {message}");
    WriteLine("Review the --help for usage information.");
    ResetColor();
    return 1;
}

void ShowHelp()
{
    WriteLine("This is a CLI to calculate wind chill.");
    WriteLine("Usage: dotnet run -- <temperature> <wind speed> <options>");
    WriteLine();
    WriteLine("Arguments:");
    WriteLine("  <temperature>\tAir Temperature (in Celsius by default)");
    WriteLine("  <wind speed>\tWind Speed (in km/h by default)");
    WriteLine();
    WriteLine("Options:");
    WriteLine("  -f\t\tTemperature in Fahrenheit");
    WriteLine("  -m\t\tWind speed in m/h");
    WriteLine("  --help\tShow this help message");
}
