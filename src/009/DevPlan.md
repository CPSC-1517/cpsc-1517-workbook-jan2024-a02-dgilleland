# Development Plan

The overall goal of this application is to present Weather data from a file and append weather recordings to the same file. To do this, we'll make use of a class library to hold the "heart" of the system and a Blazor web application to act as the front end. We'll also create a quick console front end to act as a CLI for some simple manual interactions with the system.

## Project Setup

```ps
dotnet new gitignore
dotnet new sln -n WeatherSystem
dotnet new classlib -n WeatherSystem -o WeatherLibrary
dotnet new console -n WeatherCLI -o WeatherConsole
dotnet new blazor -n WebApp -o Website -e
dotnet sln add WeatherLibrary/WeatherSystem.csproj
dotnet sln add WeatherConsole/WeatherCLI.csproj
dotnet sln add Website/WebApp.csproj
```

To connect the various project dependencies, I can do the following.

```ps
# cd to the WeatherConsole folder
dotnet add reference ../WeatherLibrary/WeatherSystem.csproj
```

```ps
# cd to the Website folder
dotnet add reference ../WeatherLibrary/WeatherSystem.csproj
```

## Project Components

The front end of the web application will consist of two primary pages:

- **ViewHistoricalWeather.razor** which will be used to present a listing of all the data read from the file.
- **RecordLocalWeather.razor** which will be used to enter information that can be appended to the file.

The `WeatherSystem` itself will consist of the following data types:

- `Location` (a POCO) to represent the place to which the weather data relates
- `Weather` (a DTO) to represent each individual weather recording, enhanced with the ability to determine wind chill effects of cold weather
- `WindChill` (a CBO) to perform wind chill calculations based on the given temperature and air speed

In addition, the `WeatherSystem` will need some classes that allow access to the data. At first, the data will come from plain CSV files, but later we will make use of a database of weather information.

## Automated Tests

Typically, we would use a TDD process to build the system using automated tests to guide our understanding of the requirements of our application. Additionally, the tests would give us a sense of confidence in the stability of our system as we move forward and make adjustments in the face of changing requirements. We won't be following TDD strictly in this example, but we will make use of it in key areas.

One of those key areas has to do with reading and writing the information from the CSV files. Because this will involve having to generates lines of CSV as well as parse those lines back into our POCO/DTO classes, a good approach is to ensure our `.Parse()` and `.ToString()` methods correctly "round-trip" the data. In other words, if I can use a CSV string as the basis for parsing and generating my DTO/POCO instances, then calling the `.ToString()` on those objects should generate the original CSV string.

To include a project to test the heart of our system, we'll run the following from the folder that holds our `.sln`

```ps
dotnet new xunit -n WeatherSystem.Specs -o WeatherLibrary.Specs
cd WeatherLibrary.Specs
dotnet add reference ../WeatherLibrary/WeatherSystem.csproj
dotnet add package FluentAssertions
```

I'll include the unit test project in my solution

```ps
dotnet sln add WeatherLibrary.Specs/WeatherSystem.Specs.csproj
```

## DateTime Formatting

The timestamp for the weather reports is in the format `""`. For example, the value `"2024-01-30T00:00"` refers to January 30, 2024 at the very start of the day (i.e.: midnight).

Here's a discussion I had with Microsoft Copilot about converting strings to and from `DateTime` in C# while maintaining a consistent format.



> ![Me](./Images/Copilot-Me.png)
> 
> Imagine I have a string "2024-01-30T00:00" and I want to parse it into a `DateTime` in C#. Then imagine that I want to convert it back into a string in the same format. What would my code look like?
> 
> ![AI](./Images/Copilot-AI.png)
>
> Certainly! To parse the string "2024-01-30T00:00" into a `DateTime` in C#, you can use the `DateTime.ParseExact` method. Let's break down the steps:
> 
> 1. **Parsing the String to DateTime**:
> 
>    You'll specify the expected format of the input string using a format string. In your case, the format is "yyyy-MM-ddTHH:mm". Here's how you can do it:
> 
>     ```csharp
>     using System;
> 
>     class Program
>     {
>         static void Main()
>         {
>             string inputString = "2024-01-30T00:00";
>             string format = "yyyy-MM-ddTHH:mm";
> 
>             if (DateTime.TryParseExact(inputString, format, null, DateTimeStyles.None, out DateTime parsedDateTime))
>             {
>                 Console.WriteLine($"Parsed DateTime: {parsedDateTime}");
>             }
>             else
>             {
>                 Console.WriteLine("Invalid input format.");
>             }
>         }
>     }
>     ```
> 
>    This code snippet will parse the input string into a `DateTime` object. If successful, it will print the parsed date and time.
> 
> 2. **Converting Back to String in the Same Format**:
> 
>    To convert the `DateTime` back to a string in the same format, you can use the `ToString` method with the desired format:
> 
>     ```csharp
>     string formattedDateTime = parsedDateTime.ToString(format);
>     Console.WriteLine($"Formatted DateTime: {formattedDateTime}");
>     ```
> 
>    This will give you the string "2024-01-30T00:00" again.
> 
> Remember to adjust the format string if your input string has additional components (such as seconds or milliseconds). The `DateTimeStyles.None` parameter ensures that no additional adjustments are made during parsing.
> 
> Feel free to customize the code according to your specific needs! 🕰️📅
> 
> Source: Conversation with Bing, 2024-03-06
> 
> (1) Convert strings to DateTime - .NET | Microsoft Learn. https://learn.microsoft.com/en-us/dotnet/standard/base-types/parsing-datetime.
> 
> (2) Convert time string to DateTime in c# - Stack Overflow. https://stackoverflow.com/questions/36122397/convert-time-string-to-datetime-in-c-sharp.
> 
> (3) How to parse strings to DateTime in C# properly? - Stack Overflow. https://stackoverflow.com/questions/5366285/how-to-parse-strings-to-datetime-in-c-sharp-properly.
> 
> (4) C# - Parsing a DateTime from a string | MAKOLYTE. https://makolyte.com/csharp-parsing-a-datetime-string-with-a-custom-format/.
> 
> (5) c# - Converting a String to DateTime - Stack Overflow. https://stackoverflow.com/questions/919244/converting-a-string-to-datetime.
> 
> ----
> 
> ![Me](./Images/Copilot-Me.png)
> 
> When you call `parsedDateTime.ToString(format)`, what should the value of `format` be in order to get an output that matches a date-time like "2024-01-30T00:00"? Also, is there a name for that kind of format for date-time?
> 
> ![AI](./Images/Copilot-AI.png)
>
> Certainly! To get an output in the format "2024-01-30T00:00", you should set the value of `format` to `"yyyy-MM-ddTHH:mm"`.
> 
> This format is known as the **ISO 8601** date and time format. It's widely used for representing date and time information in a standardized way, especially in contexts like XML, JSON, and APIs. The "T" in the format separates the date part from the time part, and the colons (":") indicate the hours and minutes.
> 
> Feel free to use this format for consistent and interoperable date-time representations! 🕰️📅
> 
> ----

