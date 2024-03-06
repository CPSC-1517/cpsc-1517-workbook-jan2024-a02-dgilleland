﻿namespace WeatherSystem;

public class Weather
{
    public Weather() {}
    public Weather(DateTime time, double temp, double wind, double gust)
    {
        this.Time = time;
        this.Temperature = temp;
        this.WindSpeed = wind;
        this.WindGusts = gust;
    }

    public DateTime Time { get; set; }
    public double Temperature { get; set; }
    public double WindSpeed { get; set; }
    public double WindGusts { get; set; }

    public override string ToString()
    {
        return $"{Time.ToString("yyyy-MM-ddTHH:mm")},{Temperature:F1},{WindSpeed:F1},{WindGusts:F1}";
    }

    public static Weather Parse(string text)
    {
        if(text is null) throw new FormatException("Cannot parse weather data from a null string");
        string[] parts = text.Split(',');
        if(parts.Length != 4) throw new FormatException($"Expected 4 parts to the Weather CSV string, but found {parts.Length} parts");
        DateTime time = DateTime.Parse(parts[0]);
        double temp = double.Parse(parts[1]);
        double wind = double.Parse(parts[2]);
        double gust = double.Parse(parts[3]);
        Weather result = new(time, temp, wind, gust);
        return result;
    }
}
