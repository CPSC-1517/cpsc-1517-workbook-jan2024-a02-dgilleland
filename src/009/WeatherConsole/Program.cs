using static System.Console;
using WeatherSystem;

// Expect the following arguments in my CLI:
// - Path to the file
// - A flag indicating which type of data to show
//   - -l or --location for the Location data
//   - -w or --weather for the Weather information

// TODO: Have "robust" parsing of the args
string path = args[0];
string dataFlag = args[1];
Clear(); // clear my console
if(dataFlag == "-l" || dataFlag == "--location")
{
    // retrieve and display the location portion of the CSV data
    try
    {
        Location loc = CsvRepository.GetLocation(path);
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine(loc);
    }
    catch (System.Exception ex)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        WriteLine(ex.StackTrace);
    }
}

// final steps
ResetColor();
