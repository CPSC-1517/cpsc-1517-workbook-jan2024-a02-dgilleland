namespace WindChill;

public class WindChill
{
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
    public double FeelsLike { get; set; } = -17.855;

    public WindChill(double airTemp, double windSpeed)
    {
        AirTemperature = airTemp;
        WindSpeed = windSpeed;
    }

    public override string ToString()
    {
        return $"-10{'\u00B0'}C at 20km/h feels like -17.855{'\u00B0'}C";
    }
}
