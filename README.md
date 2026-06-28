# OpenMeteoApi.NET

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/icons/opem%20meteo%20logo.jpg?raw=true" width="500" alt="Alt text" /> <img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/icons/csharplogo.png?raw=true" width="329" alt="Alt text" />


## Code Example

***OpenMeteoApi.NET Console Application Code***

```C#
/*
 * In this code example, I will use OpenMeteoAPI.NET to build a basic console application that does the following:
 * 
 * 1) Retrieves the latest 2-meter temperature ECMWF IFS, GFS, GEM & ICON forecast for a given latitude and longitude.
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
                    days:1);

                // Retrieve the GFS forecast for 1 day
                var gfsData = await gfsHourlyForecastApi.GetPointForecast(latitude,
                    longitude,
                    variables: variables,
                    days:1);

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
                    var ecmwfTime = ecmwfData.time?[i] ?? "N/A";
                    var ecmwfTemp2m = ecmwfData.temperature_2m?[i].ToString() ?? "N/A";
                    var gfsTemp2m = gfsData.temperature_2m?[i].ToString() ?? "N/A";
                    var gemTemp2m = gemData.temperature_2m?[i].ToString() ?? "N/A";
                    var iconTemp2m = iconData.temperature_2m?[i].ToString() ?? "N/A";

                    // Rounds to the nearest whole number and converts from double to integer.
                    int ecmwfTemp2mInt = (int)Math.Round(ecmwfData.temperature_2m?[i] ?? 0);
                    int gfsTemp2mInt = (int)Math.Round(gfsData.temperature_2m?[i] ?? 0);
                    int gemTemp2mInt = (int)Math.Round(gemData.temperature_2m?[i] ?? 0);
                    int iconTemp2mInt = (int)Math.Round(iconData.temperature_2m?[i] ?? 0);

                    // Rounds to the nearest whole number and converts from double to integer
                    Console.WriteLine($"Time: {ecmwfTime} | ECMWF IFS: {ecmwfTemp2mInt}°F | GFS: {gfsTemp2mInt}°F | GEM: {gemTemp2mInt}°F | ICON: {iconTemp2mInt}°F");
                }
            }
        }
    }
}
```


***OpenMeteoApi.NET Console Application Output***

<img src="https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/examples/OpenMeteoApiNet%20Console%20App.png?raw=true" width="1000" alt="Alt text" />
