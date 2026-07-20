# OpenMeteoApi.NET

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/icons/opem%20meteo%20logo.jpg?raw=true" width="500" alt="Alt text" /> <img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/icons/csharplogo.png?raw=true" width="329" alt="Alt text" />

***(C) Eric J. Drewitz 2026***

**OpenMeteoApi.NET is a C# package that provides an interface with the Open-Meteo API to access various types of weather data.** 

Current Version:

![NuGet Version](https://img.shields.io/nuget/v/OpenMeteoApiNet)

NuGet Downloads:

![NuGet Downloads](https://img.shields.io/nuget/dt/OpenMeteoApiNet)


## Table of Contents

[***Documentation***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/README.md#documentation)

[***Code Example 1***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/README.md#example-1-openmeteoapinet-console-application-code)

[***Code Example 2***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/README.md#example-2-openmeteoapinet-icon-eps-application-code)

## Documentation

### Forecast Data

[***NOAA/NCEP Model Data Access***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/noaa.md#national-oceanic-and-atmospheric-administration-noaa)

[***ECMWF Model Data Access***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/ecmwf.md#european-centre-for-medium-range-weather-forecasts-ecmwf)

[***CMC Model Data Access***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/cmc.md#canadian-meteorological-centre-cmc)

[***DWD Model Data Access***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/dwd.md#deutscher-wetterdienst-dwd)

[***Meteo France Model Data Access***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/meteo%20france.md#meteo-france)

[***Japan Meteorological Agency (JMA)***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/jma.md#japan-meteorological-agency-jma)

### Current Analysis

[***Current Weather***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/currentWeather.md#current-weather)

## Code Examples

### ***Example 1 OpenMeteoApi.NET Console Application Code***

```CSharp
/*
 * In this code example, I will use OpenMeteoAPI.NET to build a basic console application that does the following:
 * 
 * - Retrieves the latest 2-Meter Temperature & 2-Meter Relative Humidity 1-day hourly time series point forecast from the UKMO Global Ensemble.
 * 
 * - Save the forecast data as a CSV file to C:\Users\drewi\Open Meteo Data
 * 
 * - Print the forecast data to the console
 *  
 */

// A using statement in C# is the equivalent of an import statement in Python
using OpenMeteoApiNet.EnsembleForecasts.UKMO.UKMO_Global_ENS;


// The namespace for the Weather Forecast Application
namespace WeatherForecastApplication
{
    class WeatherApp
    {
        // Our main task in our application
        public static async Task Main(string[] args)
        {
            // Continuous loop until the user manually exits the command prompt. 
            while (true)
            {
                // Prompt the user for latitude and longitude

                /* For Python Developers like myself, it is good practice to define variables in C# in the following way:
                 * 
                 * var latitude
                 * var longitude
                 * 
                 * Rather than:
                 * 
                 * double latitude
                 * double longitude
                 * 
                 * This is because using the prefix var allows the compiler to determine the data type (makes it feel dynamically typed like Python)
                 * 
                 */
                // Title
                Console.WriteLine("\nUKMO Global Ensemble Forecast\n");
                Console.WriteLine($"Enter a latitude");
                var latitude = Console.ReadLine();
                Console.WriteLine($"Enter a longitude");
                var longitude = Console.ReadLine();

                // Selects the variables to query: temperature_2m, relative_humidity_2m
                string[] variables = new string[] { "temperature_2m", "relative_humidity_2m" };


                // Retrieve the UKMO Global Ensemble forecast for 1 day
                // Save the data as a CSV file to C:\Users\drewi\Open Meteo Data
                // Retrieves our Microsoft.Data.Analysis DataFrame df
                var df = await ukmoGlobalENSHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1,
                    toCsv: true,
                    filePath: @"C:\Users\drewi\Open Meteo Data");

                // If the Microsoft.Data.Analysis DataFrame is not null proceed to write the output to the console.
                if (df != null)
                {
                    Console.WriteLine("2-Meter Temperature & Relative Humidity Forecast\n");
                    // Prints the Temperature data
                    for (long i = 0; i < df.Rows.Count; i++)
                    {

                        // Print the row data cleanly on a single line
                        Console.WriteLine($"Time: {df["time"][i], -20} | Control: {df["temperature_2m"][i], -6} °F | Member 1: {df["temperature_2m_member01"][i]} °F | Member 10: {df["temperature_2m_member10"][i]} °F |");                        

                    }

                    Console.WriteLine("\n2-Meter Relative Humidity Forecast\n");
                    for (long i = 0; i < df.Rows.Count; i++)
                    {

                        // Print the row data cleanly on a single line                        
                        Console.WriteLine($"Time: {df["time"][i],-20} | Control: {df["relative_humidity_2m"][i],-6} % | Member 1: {df["relative_humidity_2m_member01"][i]} % | Member 10: {df["relative_humidity_2m_member10"][i]} % |");
                    }
                    // Signature and credit
                    Console.WriteLine("\nData Retrieved with OpenMeteoApi.NET (C) Eric J. Drewitz 2026");
                }
                else
                {
                    // Returns this error message to the user if df == null. 
                    Console.WriteLine($"Data not available for (Latitude: {latitude}, Longitude: {longitude}");
                }
            }
        }
    }
}
```


***Example 1 OpenMeteoApi.NET Console Application Output***

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/examples/OpenMeteoApiNet%20Console%20App.png?raw=true" width="1000" alt="Alt text" />

### ***Example 2 OpenMeteoApi.NET GFS + ECMWF Forecast***

```CSharp
/*
 * In this code example, I will use OpenMeteoAPI.NET to build a basic console application that does the following:
 * 
 * - Retrieves the latest 2-Meter Temperature 1-day hourly time series point forecast from the GFS and ECMWF IFS.
 * 
 * - Print the GFS & ECMWF forecasts and the difference between models to the console. 
 *  
 */

// A using statement in C# is the equivalent of an import statement in Python
using OpenMeteoApiNet.DeterministicForecasts.NOAA.GFS;
using OpenMeteoApiNet.DeterministicForecasts.ECMWF.ECMWF_IFS;
using Microsoft.Data.Analysis;

// The namespace for the Weather Forecast Application
namespace WeatherForecastApplication
{
    class WeatherApp
    {
        // Our main task in our application
        public static async Task Main(string[] args)
        {
            // Continuous loop until the user manually exits the command prompt. 
            while (true)
            {
                // Prompt the user for latitude and longitude

                /* For Python Developers like myself, it is good practice to define variables in C# in the following way:
                 * 
                 * var latitude
                 * var longitude
                 * 
                 * Rather than:
                 * 
                 * double latitude
                 * double longitude
                 * 
                 * This is because using the prefix var allows the compiler to determine the data type (makes it feel dynamically typed like Python)
                 * 
                 */
                // Title
                Console.WriteLine("\nGFS & ECMWF IFS 2-Meter Temperature Forecasts\n");
                Console.WriteLine($"Enter a latitude");
                var latitude = Console.ReadLine();
                Console.WriteLine($"Enter a longitude");
                var longitude = Console.ReadLine();

                // Selects the variables to query: temperature_2m
                string[] variables = new string[] { "temperature_2m" };


                // Retrieve the GFS forecast for 1 day as a Microsoft.Data.Analysis DataFrame df
                var gfs = await gfsHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Retrieve the ECMWF IFS forecast for 1 day as a Microsoft.Data.Analysis DataFrame df
                var ecmwf = await ifsHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Merges our gfs and ecmwf dataframes
                DataFrame df = gfs.Merge(
                                    other: ecmwf,
                                    leftJoinColumns: new string[] { "time" },
                                    rightJoinColumns: new string[] { "time" },
                                    leftSuffix: "_gfs",
                                    rightSuffix: "_ecmwf",
                                    joinAlgorithm: JoinAlgorithm.Left
                                );

                // Drop the column named "time_ecmwf" as this is a redundant field
                df.Columns.Remove("time_ecmwf");

                // Create a new column
                PrimitiveDataFrameColumn<double> temperature_2m_difference = (PrimitiveDataFrameColumn<double>)(df["temperature_2m_gfs"] - df["temperature_2m_ecmwf"]);

                // 4. Name the new column
                temperature_2m_difference.SetName("temperature_2m_difference");

                // 5. Append the new column to the DataFrame
                df.Columns.Add(temperature_2m_difference);

                // If the Microsoft.Data.Analysis DataFrame is not null proceed to write the output to the console.
                if (df != null)
                {
                    Console.WriteLine("\n      Time             GFS      ECMWF     (GFS-ECMWF)");
                    Console.WriteLine("-------------------------------------------------------");
                    // Prints the Forecast data
                    for (long i = 0; i < df.Rows.Count; i++)
                    {
                        // Print the row data cleanly on a single line
                        Console.WriteLine($"{df["time_gfs"][i], -3} UTC | {df["temperature_2m_gfs"][i], -3}°F | {df["temperature_2m_ecmwf"][i],-3}°F | {Math.Round((double)df["temperature_2m_difference"][i], 1),-3}°F");                        

                    }

                    // Signature and credit
                    Console.WriteLine("\nData Retrieved with OpenMeteoApi.NET (C) Eric J. Drewitz 2026");
                }
                else
                {
                    // Returns this error message to the user if df == null. 
                    Console.WriteLine($"Data not available for (Latitude: {latitude}, Longitude: {longitude}");
                }
            }
        }
    }
}

```

***Example 2 OpenMeteoApi.NET Console Application Output***

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/examples/OpenMeteoApiNet%20ICON%20EPS%20Console.png?raw=true" width="1000" alt="Alt text" />
