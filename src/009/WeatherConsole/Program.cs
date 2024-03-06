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
if(dataFlag == "-w" || dataFlag == "--weather")
{
    try
    {
        var rawData = CsvRepository.GetWeatherCSV(path);
        ForegroundColor = ConsoleColor.Green;
        DateOnly day = DateOnly.MinValue;
        foreach(string row in rawData)
        {
            try
            {
                // Parse the weather
                Weather data = Weather.Parse(row);
                // Show the weather with WindChill if applicable
                if(day != DateOnly.FromDateTime(data.Time))
                {
                    day = DateOnly.FromDateTime(data.Time);
                    // Print a "header" for the new day
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine(day.ToLongDateString());
                    ForegroundColor = ConsoleColor.Green;
                }
                Write($"{data.Time.ToShortTimeString()} - {data.Temperature}");
                if(data.WindChill is not null)
                {
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine($" (feels like {data.WindChill.FeelsLike})");
                    ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    WriteLine();
                }
            }
            catch (System.Exception ex)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(ex.Message);
                ForegroundColor = ConsoleColor.Green;
            }
        }
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
