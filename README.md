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

### Current Analysis

[***Current Weather***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/currentWeather.md#current-weather)

## Code Examples

### ***Example 1 OpenMeteoApi.NET Console Application Code***

```C#
/*
 * In this code example, I will use OpenMeteoAPI.NET to build a basic console application that does the following:
 * 
 * - Retrieves the latest 2-meter temperature ECMWF IFS, GFS, GEM & ICON forecast for a given latitude and longitude.
 *  
 */
using OpenMeteoApiNet.ECMWF_IFS;
using OpenMeteoApiNet.GFS;
using OpenMeteoApiNet.ICON;
using OpenMeteoApiNet.GEM;


// Our main program namespace
namespace Program
{
    class Program
    {
        // Our main task in our application
        public static async Task Main(string[] args)
        {
            // Continuous loop until the user manually exits the command prompt. 
            while (true)
            {
                // Prompt the user for latitude and longitude

                Console.WriteLine($"Enter a latitude");
                var latitude = Console.ReadLine();
                Console.WriteLine($"Enter a longitude");
                var longitude = Console.ReadLine();

                // Selects the variable temperature_2m
                string[] variables = new string[] { "temperature_2m" };


                // Retrieve the ECMWF IFS forecast for 1 day
                var ecmwfData = await ifsHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Retrieve the GFS forecast for 1 day
                var gfsData = await gfsHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Retrieve the GEM forecast for 1 day
                var gemData = await gemHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Retrieve the ICON forecast for 1 day
                var iconData = await iconHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Prints a no data message if the API returns null.
                if (ecmwfData == null)
                {
                    Console.WriteLine("No ECMWF IFS data returned from the API.");
                    continue;
                }

                if (gfsData == null)
                {
                    Console.WriteLine("No GFS data returned from the API.");
                    continue;
                }

                if (gemData == null)
                {
                    Console.WriteLine("No GEM data returned from the API.");
                    continue;
                }

                if (iconData == null)
                {
                    Console.WriteLine("No ICON data returned from the API.");
                    continue;
                }

                // Prints the various forecasts to the console
                for (int i = 0; i < (ecmwfData.time?.Length ?? 0); i++)
                {
                    var forecastTime = ecmwfData.time?[i] ?? "N/A";

                    // Rounds to the nearest whole number and converts from double to integer.
                    int ecmwfTemp2mInt = (int)Math.Round(ecmwfData.temperature_2m?[i] ?? 0);
                    int gfsTemp2mInt = (int)Math.Round(gfsData.temperature_2m?[i] ?? 0);
                    int gemTemp2mInt = (int)Math.Round(gemData.temperature_2m?[i] ?? 0);
                    int iconTemp2mInt = (int)Math.Round(iconData.temperature_2m?[i] ?? 0);

                    // Rounds to the nearest whole number and converts from double to integer
                    Console.WriteLine($"Time: {forecastTime} | ECMWF IFS: {ecmwfTemp2mInt}°F | GFS: {gfsTemp2mInt}°F | GEM: {gemTemp2mInt}°F | ICON: {iconTemp2mInt}°F");
                }
            }
        }
    }
}
```


***Example 1 OpenMeteoApi.NET Console Application Output***

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/examples/OpenMeteoApiNet%20Console%20App.png?raw=true" width="1000" alt="Alt text" />

### ***Example 2 OpenMeteoApi.NET ICON EPS Application Code***

```C#
/*
 * In this code example, I will use OpenMeteoAPI.NET to build a basic console application that does the following:
 * 
 * - Retrieves the latest 2-meter relative humidity for the ICON Ensemble (control + first 5 members)
 *  
 */
using OpenMeteoApiNet.ICON_EPS;


// Our main program namespace
namespace Program
{
    class Program
    {
        // Our main task in our application
        public static async Task Main(string[] args)
        {
            // Continuous loop until the user manually exits the command prompt. 
            while (true)
            {
                // Prompt the user for latitude and longitude

                Console.WriteLine($"Enter a latitude");
                var latitude = Console.ReadLine();
                Console.WriteLine($"Enter a longitude");
                var longitude = Console.ReadLine();

                // Selects the variable temperature_2m
                string[] variables = new string[] { "relative_humidity_2m" };


                // Retrieve the ICON forecast for 1 day
                var iconEPSData = await iconEPSHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days: 1);

                // Prints a no data message if the API returns null.
                if (iconEPSData == null)
                {
                    Console.WriteLine("No ICON EPS data returned from the API.");
                    continue;
                }

                Console.WriteLine($"ICON EPS Forecast\n");

                // Prints the various forecasts to the console
                for (int i = 0; i < (iconEPSData.time?.Length ?? 0); i++)
                {
                    var forecastTime = iconEPSData.time?[i] ?? "N/A";

                    // Rounds to the nearest whole number and converts from double to integer.
                    int RHIntControl = (int)Math.Round(iconEPSData.relative_humidity_2m?[i] ?? 0);
                    int RHIntMember01 = (int)Math.Round(iconEPSData.relative_humidity_2m_member01?[i] ?? 0);
                    int RHIntMember02 = (int)Math.Round(iconEPSData.relative_humidity_2m_member02?[i] ?? 0);
                    int RHIntMember03 = (int)Math.Round(iconEPSData.relative_humidity_2m_member03?[i] ?? 0);
                    int RHIntMember04 = (int)Math.Round(iconEPSData.relative_humidity_2m_member04?[i] ?? 0);
                    int RHIntMember05 = (int)Math.Round(iconEPSData.relative_humidity_2m_member05?[i] ?? 0);

                    // Rounds to the nearest whole number and converts from double to integer
                    Console.WriteLine($"Time: {forecastTime} | Control: {RHIntControl}% | M1: {RHIntMember01}% | M2: {RHIntMember02}% | M3: {RHIntMember03}% | M4: {RHIntMember04}% | M5: {RHIntMember05}%");
                }
            }
        }
    }
}

```

***Example 2 OpenMeteoApi.NET Console Application Output***

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/examples/OpenMeteoApiNet%20ICON%20EPS%20Console.png?raw=true" width="1000" alt="Alt text" />
