using System.ComponentModel.DataAnnotations;
using static System.Console;

Clear();
WriteLine("Fleet Records!");
Run();
ResetColor();
return 0;
/***** Supporting Methods *****/
void Run()
{
    if(args.Length == 0)
        ShowHelp();
    else
    {
        try
        {
            IEnumerable<string> lines = File.ReadAllLines(args[0]);
            var fleet = ParseTabSeparatedValues(lines);
            if(IsFilterRequired())
                fleet = Filter(fleet, args[2]);
            if(!fleet.Any())
                Report("No ships were found in the records.", ConsoleColor.Red);
            else
                foreach(var ship in fleet)
                    Report(ship.ToString());
        }
        catch (System.Exception ex)
        {
            Report(ex.Message, ConsoleColor.DarkRed);
        }
    }
}

void ShowHelp()
{
    ForegroundColor = ConsoleColor.DarkGreen;
    WriteLine("\nUsage:");
    WriteLine("\tDeveloper mode:\tdotnet run -- <path> [flags]");
    WriteLine("\tRun executable:\tConsoleApp.exe <path> [flags]");
    WriteLine("\nArguments:");
    WriteLine("\t<path>     A relative or absolute path to a TSV file. E.g.: \"path/to/file.tsv\"");
    WriteLine("\t-f, --filter    Filter results for records containing a part of the supplied text; if no text is supplied, no filter is applied.");
    WriteLine("\nExamples: ");
    ForegroundColor = ConsoleColor.DarkYellow;
    WriteLine("\tdotnet run -- \"..\\..\\Data\\Starships.tsv\"");
    WriteLine("\tdotnet run -- \"..\\..\\Data\\Starships.tsv\" -f \"Ent\"");
    ResetColor();
}

IEnumerable<Starship> ParseTabSeparatedValues(IEnumerable<string> lines)
{
    foreach(var line in lines)
    {
        var parts = line.Split('\t');
        yield return new Starship(parts[0], parts[1], parts[2]);
    }
}

IEnumerable<Starship> Filter(IEnumerable<Starship> fleet, string partialText)
{
    foreach(var ship in fleet)
        if(IsPartialMatch(ship, partialText))
            yield return ship;
}

bool IsPartialMatch(Starship ship, string partialText) => ship.Name.Contains(partialText) || ship.RegistryNumber.Contains(partialText) || ship.Class.Contains(partialText);

bool IsFilterRequired()
{
    return args.Length == 3 && MatchesFlag("filter", "f");
}

bool MatchesFlag(string flag, string shortFlag) => args[1] == $"--{flag}" || args[1] == $"-{shortFlag}";

void Report(string message, ConsoleColor color = ConsoleColor.Cyan)
{
    ForegroundColor = color;
    WriteLine(message);
    ResetColor();
}

/*** Supporting Types ***/
record Starship(string Name, string RegistryNumber, string Class);
