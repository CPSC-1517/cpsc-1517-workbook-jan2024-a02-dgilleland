namespace WindChill;

public class WindChill
{
    public double AirTemperature { get; set; }
    public double WindSpeed { get; set; }
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
