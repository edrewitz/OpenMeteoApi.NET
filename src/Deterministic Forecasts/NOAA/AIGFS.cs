/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.DataFrames.HourlyData.AIGFS;
using OpenMeteoApiNet.Variables.HourlyData.AIGFS;
using OpenMeteoApiNet.Utils.BuildDirectory;
using OpenMeteoApiNet.Utils.DataAccess;
using OpenMeteoApiNet.Utils.DataArchive;
using System.Text.Json;

namespace OpenMeteoApiNet.DeterministicForecasts.NOAA.AIGFS
{

    public static class aigfsHourlyForecastApi
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
         * This function is the client that retrieves and returns the hourly NOAA/NCEP/AIGFS point forecast for a specified point of lat/lon.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=7. The number of days to forecast, up to a maximum of 16 days.
         * 
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
                "apparent_temperature" 
                "cape"
                "precipitation" 
                "rain"
                "snow"  
                "snowfall" 
                "snow_depth" 
                "pressure_msl" 
                "surface_pressure" 
                "cloud_cover" 
                "cloud_cover_low" 
                "cloud_cover_mid" 
                "cloud_cover_high" 
                "visibility" 
                "evapotranspiration" 
                "et0_fao_evapotranspiration" 
                "vapour_pressure_deficit" 
                "wind_speed_10m" 
                "wind_speed_80m" 
                "wind_speed_120m" 
                "wind_speed_180m" 
                "wind_direction_10m" 
                "wind_direction_80m" 
                "wind_direction_120m" 
                "wind_direction_180m" 
                "temperature_80m" 
                "wind_gusts_10m" 
                "temperature_120m" 
                "temperature_180m" 
                "soil_temperature_0cm" 
                "soil_temperature_6cm" 
                "soil_temperature_18cm" 
                "soil_temperature_54cm" 
                "soil_moisture_0_to_1cm" 
                "soil_moisture_1_to_3cm" 
                "soil_moisture_3_to_9cm" 
                "soil_moisture_9_to_27cm" 
                "soil_moisture_27_to_81cm"
                "temperature_1000hPa" 
                "temperature_925hPa" 
                "temperature_850hPa" 
                "temperature_700hPa" 
                "temperature_600hPa" 
                "temperature_500hPa" 
                "temperature_400hPa" 
                "temperature_300hPa" 
                "temperature_250hPa" 
                "temperature_200hPa" 
                "temperature_150hPa" 
                "temperature_100hPa" 
                "temperature_50hPa" 
                "dew_point_1000hPa" 
                "dew_point_925hPa" 
                "dew_point_850hPa" 
                "dew_point_700hPa" 
                "dew_point_600hPa" 
                "dew_point_500hPa" 
                "dew_point_400hPa" 
                "dew_point_300hPa" 
                "dew_point_250hPa" 
                "dew_point_200hPa" 
                "dew_point_150hPa" 
                "dew_point_100hPa" 
                "dew_point_50hPa" 
                "relative_humidity_1000hPa" 
                "relative_humidity_925hPa" 
                "relative_humidity_850hPa" 
                "relative_humidity_700hPa" 
                "relative_humidity_600hPa" 
                "relative_humidity_500hPa" 
                "relative_humidity_400hPa" 
                "relative_humidity_300hPa" 
                "relative_humidity_250hPa" 
                "relative_humidity_200hPa" 
                "relative_humidity_150hPa" 
                "relative_humidity_100hPa" 
                "relative_humidity_50hPa" 
                "wind_speed_1000hPa" 
                "wind_speed_925hPa" 
                "wind_speed_850hPa" 
                "wind_speed_700hPa" 
                "wind_speed_600hPa" 
                "wind_speed_500hPa" 
                "wind_speed_400hPa" 
                "wind_speed_300hPa" 
                "wind_speed_250hPa" 
                "wind_speed_200hPa" 
                "wind_speed_150hPa" 
                "wind_speed_100hPa" 
                "wind_speed_50hPa" 
                "wind_direction_1000hPa" 
                "wind_direction_925hPa" 
                "wind_direction_850hPa" 
                "wind_direction_700hPa" 
                "wind_direction_600hPa" 
                "wind_direction_500hPa" 
                "wind_direction_400hPa" 
                "wind_direction_300hPa" 
                "wind_direction_250hPa" 
                "wind_direction_200hPa" 
                "wind_direction_150hPa" 
                "wind_direction_100hPa" 
                "wind_direction_50hPa" 
                "vertical_velocity_1000hPa" 
                "vertical_velocity_925hPa" 
                "vertical_velocity_850hPa" 
                "vertical_velocity_700hPa" 
                "vertical_velocity_600hPa" 
                "vertical_velocity_500hPa" 
                "vertical_velocity_400hPa" 
                "vertical_velocity_300hPa" 
                "vertical_velocity_250hPa" 
                "vertical_velocity_200hPa" 
                "vertical_velocity_150hPa" 
                "vertical_velocity_100hPa" 
                "vertical_velocity_50hPa" 
                "geopotential_height_1000hPa" 
                "geopotential_height_925hPa" 
                "geopotential_height_850hPa" 
                "geopotential_height_700hPa" 
                "geopotential_height_600hPa" 
                "geopotential_height_500hPa" 
                "geopotential_height_400hPa" 
                "geopotential_height_300hPa" 
                "geopotential_height_250hPa" 
                "geopotential_height_200hPa" 
                "geopotential_height_150hPa" 
                "geopotential_height_100hPa" 
                "geopotential_height_50hPa" 

          6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

          7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

          8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

          9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
         *      
         * 
         * Returns
         * -------
         * 
         * The AIGFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {
            if (days > 16)
            {
                Console.WriteLine("The maximum number of forecast days is 16. Setting 'days' to 16.");
                days = 16;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m" ,
                                    "relative_humidity_2m" ,
                                    "apparent_temperature" ,
                                    "precipitation" ,
                                    "snowfall" ,
                                    "snow_depth" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "cloud_cover_low" ,
                                    "cloud_cover_mid" ,
                                    "cloud_cover_high" ,
                                    "visibility" ,
                                    "evapotranspiration" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_80m" ,
                                    "wind_speed_120m" ,
                                    "wind_speed_180m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_80m" ,
                                    "wind_direction_120m" ,
                                    "wind_direction_180m" ,
                                    "temperature_80m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_120m" ,
                                    "temperature_180m" ,
                                    "soil_temperature_0cm" ,
                                    "soil_temperature_6cm" ,
                                    "soil_temperature_18cm" ,
                                    "soil_temperature_54cm" ,
                                    "soil_moisture_0_to_1cm" ,
                                    "soil_moisture_1_to_3cm" ,
                                    "soil_moisture_3_to_9cm" ,
                                    "soil_moisture_9_to_27cm" ,
                                    "soil_moisture_27_to_81cm" ,
                                    "temperature_1000hPa" ,
                                    "temperature_925hPa" ,
                                    "temperature_850hPa" ,
                                    "temperature_700hPa" ,
                                    "temperature_600hPa" ,
                                    "temperature_500hPa" ,
                                    "temperature_400hPa" ,
                                    "temperature_300hPa" ,
                                    "temperature_250hPa" ,
                                    "temperature_200hPa" ,
                                    "temperature_150hPa" ,
                                    "temperature_100hPa" ,
                                    "temperature_50hPa" ,
                                    "dew_point_1000hPa" ,
                                    "dew_point_925hPa" ,
                                    "dew_point_850hPa" ,
                                    "dew_point_700hPa" ,
                                    "dew_point_600hPa" ,
                                    "dew_point_500hPa" ,
                                    "dew_point_400hPa" ,
                                    "dew_point_300hPa" ,
                                    "dew_point_250hPa" ,
                                    "dew_point_200hPa" ,
                                    "dew_point_150hPa" ,
                                    "dew_point_100hPa" ,
                                    "dew_point_50hPa" ,
                                    "relative_humidity_1000hPa" ,
                                    "relative_humidity_925hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "wind_speed_1000hPa" ,
                                    "wind_speed_925hPa" ,
                                    "wind_speed_850hPa" ,
                                    "wind_speed_700hPa" ,
                                    "wind_speed_600hPa" ,
                                    "wind_speed_500hPa" ,
                                    "wind_speed_400hPa" ,
                                    "wind_speed_300hPa" ,
                                    "wind_speed_250hPa" ,
                                    "wind_speed_200hPa" ,
                                    "wind_speed_150hPa" ,
                                    "wind_speed_100hPa" ,
                                    "wind_speed_50hPa" ,
                                    "wind_direction_1000hPa" ,
                                    "wind_direction_925hPa" ,
                                    "wind_direction_850hPa" ,
                                    "wind_direction_700hPa" ,
                                    "wind_direction_600hPa" ,
                                    "wind_direction_500hPa" ,
                                    "wind_direction_400hPa" ,
                                    "wind_direction_300hPa" ,
                                    "wind_direction_250hPa" ,
                                    "wind_direction_200hPa" ,
                                    "wind_direction_150hPa" ,
                                    "wind_direction_100hPa" ,
                                    "wind_direction_50hPa" ,
                                    "vertical_velocity_1000hPa" ,
                                    "vertical_velocity_925hPa" ,
                                    "vertical_velocity_850hPa" ,
                                    "vertical_velocity_700hPa" ,
                                    "vertical_velocity_600hPa" ,
                                    "vertical_velocity_500hPa" ,
                                    "vertical_velocity_400hPa" ,
                                    "vertical_velocity_300hPa" ,
                                    "vertical_velocity_250hPa" ,
                                    "vertical_velocity_200hPa" ,
                                    "vertical_velocity_150hPa" ,
                                    "vertical_velocity_100hPa" ,
                                    "vertical_velocity_50hPa" ,
                                    "geopotential_height_1000hPa" ,
                                    "geopotential_height_925hPa" ,
                                    "geopotential_height_850hPa" ,
                                    "geopotential_height_700hPa" ,
                                    "geopotential_height_600hPa" ,
                                    "geopotential_height_500hPa" ,
                                    "geopotential_height_400hPa" ,
                                    "geopotential_height_300hPa" ,
                                    "geopotential_height_250hPa" ,
                                    "geopotential_height_200hPa" ,
                                    "geopotential_height_150hPa" ,
                                    "geopotential_height_100hPa" ,
                                    "geopotential_height_50hPa" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=ncep_aigfs025&forecast_days={days}" +
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
                return null;
            }

            // Deserialize the "hourly" property into our aigfsParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<aigfsParams>(hourlyWeatherElement.GetRawText());
            if (data == null)
            {
                Console.WriteLine("Unable to parse hourly weather data.");
                return null;
            }

            // Convert the DateTime object to local time.
            if (data != null)
            {
                data.parsedDateTimes = data.time
                                            .Select(t => DateTime.Parse(t))
                                            .ToList();

                data.parsedLocalTimes = data.parsedDateTimes
                                            .Select(dt => dt.ToLocalTime())
                                            .ToList();

                var df = aigfsDataFrame.ToDataFrame(data);

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
                        fileName = $"AIGFS_PointForecast_{latString}_{lonString}.csv";
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
                Console.WriteLine($"AI GFS Data Not Available At This Time");
                return null;
            }

        }
    }
}


