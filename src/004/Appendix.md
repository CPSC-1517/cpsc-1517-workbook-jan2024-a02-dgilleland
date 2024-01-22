# Appendix

## Version 1.0.0

Here's the first version of our unit tests and the `WindChill` class.

### `WindChill_Should.cs`

Here's the complete code for the `WindChill_Should` class.

```cs
```

### `WindChill.cs`

Here's the complete code for the `WindChill` class.

```cs
```


----

----

# TEMP

```cs
// Using statements must be at the top of the file
using System;
using static System.Console; // so we can use Console.WriteLine() as WriteLine()

// The body of the Main method is the next item in the file
WriteLine("Hello Wind Chill!");
// TODO: Add code to parse the arguments and calculate the wind chill
// For now, we'll just exit with a code of 0
return 0;

// Members of the class (fields, properties, and methods) are to be placed after the body of the Main method
// Fields
public static const double FreezingPointCelsius = 0.0;
private static double _TemperatureCelcius;
private static double _WindSpeedKmH;

public static double WindChill { get; private set; }
public static char Units { get; private set; } // 'F' or 'C'

// Methods
public static double ConvertToFarhenheit(double temperatureCelcius)
{
    return temperatureCelcius * 9 / 5 + 32;
}
public static double ConvertToCelsius(double temperatureFahrenheit)
{
    return (temperatureFahrenheit - 32) * 5 / 9;
}
public static double ConvertToMilesPerHour(double windSpeedKmH)
{
    return windSpeedKmH / 1.609344;
}
public static void CalculateWindChill()
{
    // Based on fields/properties, this will set the WindChill property
    // Assuming that _TemperatureCelcius and _WindSpeedKmH have been set
    // first, calculating the results in Celsius
    double windChillCelsius = 13.12 + 0.6215 * _TemperatureCelcius - 11.37 * Math.Pow(_WindSpeedKmH, 0.16) + 0.3965 * _TemperatureCelcius * Math.Pow(_WindSpeedKmH, 0.16);
    // Adjust the wind chill based on the units
    if (Units == 'F')
    {
        WindChill = ConvertToFarhenheit(windChillCelsius);
    }
    else
    {
        WindChill = windChillCelsius;
    }
}
    WriteLine($"Temperature: {args[0]}°C");
    WriteLine($"Wind Speed: {args[1]} km/h");


public static void ShowHelp()
{
    WriteLine("This is a CLI to calculate wind chill.");
    WriteLine("Usage: dotnet run -- <temperature> <wind speed> <options>");
    WriteLine();
    WriteLine("Arguments:");
    WriteLine("  <temperature>\tAir Temperature (in Celsius by default)");
    WriteLine("  <wind speed>\tWind Speed (in km/h by default)");
    WriteLine();
    WriteLine("Options:");
    WriteLine("  --help\tShow this help message");
    WriteLine("  -f\t\tTemperature is in Fahrenheit");
    WriteLine("  -m\t\tWind speed is in m/h");
}
```

----
