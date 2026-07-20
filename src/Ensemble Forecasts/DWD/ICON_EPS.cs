/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.DataFrames.HourlyData.ICON_EPS;
using OpenMeteoApiNet.Variables.HourlyData.ICON_EPS;
using OpenMeteoApiNet.Utils.BuildDirectory;
using OpenMeteoApiNet.Utils.DataAccess;
using OpenMeteoApiNet.Utils.DataArchive;
using System.Text.Json;

namespace OpenMeteoApiNet.EnsembleForecasts.DWD.ICON_EPS
{
    public static class iconEPSHourlyForecastApi
    {
        private static string currentDirectory = DirectoryHelper.GetCurrentDirectory();

        public static async Task<DataFrame?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 7,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null,
                                                         bool toCsv = false,
                                                         string? filePath = null,
                                                         string? fileName = null)
        /*
         * This function is the client that retrieves and returns the hourly DWD ICON EPS Forecast from the Open-Meteo API.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=7. The number of forecast days to retrieve, starting from the current day. Maximum is 36 days.
         *          * 
         * 2) temperatureUnit (string) - Default="fahrenheit". The units for the temperature data.
         * 
         *      Valid Units
         *      -----------
         *      
         *      1) fahrenheit [Fahrenheit]
         *      2) celsius [Celsius]
         *      
         * 3) windSpeedUnit (string) - Default="mph". The units for the wind speed data. 
         * 
         *      Valid Units
         *      -----------
         *      1) mph (Miles Per Hour)
         *      2) ms (Meters Per Second)
         *      3) kmh (Kilometers Per Hour)
         *      4) kn (Knots)
         *      
         * 4) precipitationUnit (string) - Default="inch". The units for the precipitation data.
         * 
         *      Valid Units
         *      -----------
         *      1) inch [Inches]
         *      2) mm [Millimeters]
         *      
         * 5) variables (string[]) - Optional list of current variables to request. Default is all variables.
         * 
         *      Variables
         *      ---------
         *      "temperature_2m"
                "relative_humidity_2m"
                "dew_point_2m"
                "apparent_temperature"
                "precipitation"
                "rain"
                "snowfall"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "et0_fao_evapotranspiration"
                "vapour_pressure_deficit"
                "wind_speed_10m"
                "wind_speed_80m"
                "wind_direction_10m"
                "wind_direction_80m"
                "wind_gusts_10m"
                "temperature_80m"


          6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

          7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

          8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

          9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
         *      
         * 
         * Returns
         * -------
         * 
         * The ICON EPS point forecast for a given latitude and longitude. 
         * 
         *          variable naming convention
         *          ---------------------------
         *          
         *          Control Run (Example 2-Meter Temperature): data.temperature_2m
         *          Ensemble Member 1 (Example 2-Meter Temperature): data.temperature_2m_member01 -> data.temperature_2m_member39 (40 total members [39 members + 1 control])
         */

        {
            // Fixes if the user enters more than 36 days since the data goes out to 36 days at most. 

            if (days > 36)
            {
                Console.WriteLine($"Requested forecast length of {days} days exceeds the maximum of 36 days. Defaulting to 36 days.");
                days = 36;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m", 
                                    "relative_humidity_2m",
                                    "dew_point_2m",
                                    "apparent_temperature",
                                    "precipitation" ,
                                    "rain" ,
                                    "snowfall" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_80m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_80m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_80m" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://ensemble-api.open-meteo.com/v1/ensemble?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=icon_seamless_eps&forecast_days={days}" +
                $"&wind_speed_unit={windSpeedUnit}&temperature_unit={temperatureUnit}&precipitation_unit={precipitationUnit}";
            
            var response = await RetrieveData.GetDataAsync(url,
                                              proxy);  

            // Read our response as a string, then parse it as JSON.
            var jsonString = await response.Content.ReadAsStringAsync();

            // Parse the JSON string and extract the "hourly" property, which contains the hourly weather data.
            var root = JsonDocument.Parse(jsonString).RootElement;

            // Check if the "hourly" property exists in the JSON response.
            if (!root.TryGetProperty("hourly", out var hourlyWeatherElement))
            {
                Console.WriteLine("Response JSON does not contain a 'hourly property.");

            }

            // Deserialize the "hourly" property into our iconEPSParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<iconEPSParams>(hourlyWeatherElement.GetRawText());

            if (data == null)
            {
                Console.WriteLine("Unable to parse hourly weather data.");
            }

            // Extract the time attribute which is in the form of a string.
            var time = data.time;

            // Convert the time string to a DateTime object.
            var dateTimeList = new List<DateTime>();

            // Convert the DateTime object to local time.
            if (data != null)
            {
                data.parsedDateTimes = data.time
                                            .Select(t => DateTime.Parse(t))
                                            .ToList();

                data.parsedLocalTimes = data.parsedDateTimes
                                            .Select(dt => dt.ToLocalTime())
                                            .ToList();


                var df = iconEPSDataFrame.ToDataFrame(data);

                if (toCsv == true)
                {
                    if (filePath == null)
                    {
                        filePath = Path.Combine(currentDirectory, "Open Meteo Data");
                    }
                    else
                    {
                        filePath = filePath;
                    }
                    DirectoryBuilder.BuildDirectory(filePath);

                    if (fileName == null)
                    {
                        string latString = (string)latitude.Replace('.', '_');
                        string lonString = (string)longitude.Replace('.', '_');
                        fileName = $"ICON_EPS_PointForecast_{latString}_{lonString}.csv";
                    }
                    else
                    {
                        fileName = fileName;
                    }

                    ArchiveData.SaveDataToCsv(filePath, fileName, df);
                }

                return df;
            }
            else
            {
                Console.WriteLine($"ICON EPS Data Not Available At This Time");
                return null;

            }
        }
    }
}

