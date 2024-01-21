namespace WindChill;
using static System.Math;

public class WindChill
{
    #region Properties/Fields
    private double _AirTemperature;
    public double AirTemperature
    {
        get { return _AirTemperature; }
        set
        {
            if (value > 0)
                throw new ArgumentOutOfRangeException();
            _AirTemperature = value;
        }
    }

    public double _WindSpeed;
    public double WindSpeed
    {
        get { return _WindSpeed; }
        set
        {
            if (value < 10)
                throw new ArgumentOutOfRangeException("Wind speeds below 10 kph are not allowed");
            if (value > 70)
                throw new ArgumentOutOfRangeException("Wind speeds above 70 kph are not allowed");
            _WindSpeed = value;
        }
    }
    public char TemperatureUnits { get; set; } = 'C';
    public string WindSpeedUnits { get; set; } = "km/h";
    public double FeelsLike
    {
        get
        {
            double temperature;
            if (TemperatureUnits == 'C' && WindSpeedUnits == "km/h")
            {
                // Use 13.12 + 0.6215T – 11.37 (V^0.16) + 0.3965T (V^0.16)
                temperature = 13.12 + 0.6215 * AirTemperature - 11.37 * Pow(WindSpeed, 0.16) + 0.3965 * AirTemperature * Pow(WindSpeed, 0.16);
            }
            else
            {
                // Use 35.74 + 0.6215T – 35.75 (V^0.16) + 0.4275T (V^0.16)
                temperature = 35.74 + 0.6215 * AirTemperature - 35.75 * Pow(WindSpeed, 0.16) + 0.4275 * AirTemperature * Pow(WindSpeed, 0.16);
            }
            return Round(temperature, 1);
        }
    }
    #endregion

    #region Constructor(s)
    public WindChill(double airTemp, double windSpeed)
    {
        AirTemperature = airTemp;
        WindSpeed = windSpeed;
    }
    public WindChill(double airTemp, char unitsOfTemperature, double windSpeed, string unitsOfWindSpeed)
    {
        _AirTemperature = airTemp;
        TemperatureUnits = unitsOfTemperature;
        _WindSpeed = windSpeed;
        WindSpeedUnits = unitsOfWindSpeed;
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"{AirTemperature}{'\u00B0'}{TemperatureUnits} at {WindSpeed}{WindSpeedUnits} feels like {FeelsLike}{'\u00B0'}{TemperatureUnits}";
    }

    public static WindChill Build(string[] args)
    {
        // Guard clauses
        if (args.Length < 2)
            throw new FormatException("Too few arguments");
        if (args.Length > 4)
            throw new FormatException("Too many arguments");
        if (args.Length > 2)
            CheckFlag(args[2]);
        if (args.Length > 3)
            CheckFlag(args[3]);

        double airTemp = double.Parse(args[0]);
        double windSpeed = double.Parse(args[1]);
        if (args.Length > 2)
            return new WindChill(airTemp, 'F', windSpeed, "m/h");
        else
            return new WindChill(airTemp, windSpeed);
    }

    private static void CheckFlag(string flag)
    {
        if (flag != "-f" && flag != "-m")
            throw new ArgumentException($"Unrecognized flag '{flag}'");
    }
    #endregion
}
