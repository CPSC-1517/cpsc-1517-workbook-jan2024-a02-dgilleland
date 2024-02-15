# Historical Weather

A [CSV of historical weather](./HistoricalWeather/open-meteo-53.60N113.28W614m.csv) from [open-meteo.com](https://open-meteo.com/en/docs/historical-weather-api/#hourly=temperature_2m,wind_speed_10m,wind_gusts_10m&timezone=auto) is supplied for parsing purposes. Here is the structure of the CSV data:

- The first line is a header for the location of the weather
- The second line is the location data
- The third line is blank
- The fourth line is a header for the weather information
- The remaining lines are weather data
- The final line is empty

Examine the header lines and model appropriate classes with `Parse()` and `TryParse()` methods. Integrate the design with the [`WindChill`](./Code/WindChill.cs) class from earlier demos.

Create a page in a Blazor 8 application to report on the available historical data. Provide a custom component for calendar input to select a range of days (start/end) for the data.
