/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.DeterministicForecasts.ECMWF.ECMWF_AIFS
{
    public class aifsParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? relative_humidity_2m { get; set; }
        public double?[]? dew_point_2m { get; set; }
        public double?[]? apparent_temperature { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? rain { get; set; }
        public double?[]? showers { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? runoff { get; set; }
        public double?[]? visibility { get; set; }
        public double?[]? weather_code { get; set; }
        public double?[]? pressure_msl { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? cloud_cover { get; set; }
        public double?[]? cloud_cover_low { get; set; }
        public double?[]? cloud_cover_mid { get; set; }
        public double?[]? cloud_cover_high { get; set; }
        public double?[]? sunshine_duration { get; set; }
        public double?[]? potential_evapotranspiration { get; set; }
        public double?[]? et0_fao_evapotranspiration { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_100m { get; set; }
        public double?[]? wind_speed_200m { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_100m { get; set; }
        public double?[]? wind_direction_200m { get; set; }
        public double?[]? wind_gusts_10m { get; set; }
        public double?[]? cape { get; set; }
        public double?[]? convective_inhibition { get; set; }
        public double?[]? total_column_integrated_water_vapour { get; set; }
        public double?[]? vapour_pressure_deficit { get; set; }
        public double?[]? surface_temperature { get; set; }
        public double?[]? soil_temperature_0_to_7cm { get; set; }
        public double?[]? soil_temperature_7_to_28cm { get; set; }
        public double?[]? soil_temperature_28_to_100cm { get; set; }
        public double?[]? soil_temperature_100_to_255cm { get; set; }
        public double?[]? soil_moisture_0_to_7cm { get; set; }
        public double?[]? soil_moisture_28_to_100cm { get; set; }
        public double?[]? soil_moisture_7_to_28cm { get; set; }
        public double?[]? soil_moisture_100_to_255cm { get; set; }
        public double?[]? temperature_1000hPa { get; set; }
        public double?[]? temperature_925hPa { get; set; }
        public double?[]? temperature_850hPa { get; set; }
        public double?[]? temperature_700hPa { get; set; }
        public double?[]? temperature_600hPa { get; set; }
        public double?[]? temperature_500hPa { get; set; }
        public double?[]? temperature_400hPa { get; set; }
        public double?[]? temperature_300hPa { get; set; }
        public double?[]? temperature_250hPa { get; set; }
        public double?[]? temperature_200hPa { get; set; }
        public double?[]? temperature_150hPa { get; set; }
        public double?[]? temperature_100hPa { get; set; }
        public double?[]? temperature_50hPa { get; set; }
        public double?[]? relative_humidity_1000hPa { get; set; }
        public double?[]? relative_humidity_925hPa { get; set; }
        public double?[]? relative_humidity_850hPa { get; set; }
        public double?[]? relative_humidity_700hPa { get; set; }
        public double?[]? relative_humidity_600hPa { get; set; }
        public double?[]? relative_humidity_500hPa { get; set; }
        public double?[]? relative_humidity_400hPa { get; set; }
        public double?[]? relative_humidity_300hPa { get; set; }
        public double?[]? relative_humidity_250hPa { get; set; }
        public double?[]? relative_humidity_200hPa { get; set; }
        public double?[]? relative_humidity_150hPa { get; set; }
        public double?[]? relative_humidity_100hPa { get; set; }
        public double?[]? relative_humidity_50hPa { get; set; }
        public double?[]? cloud_cover_1000hPa { get; set; }
        public double?[]? cloud_cover_925hPa { get; set; }
        public double?[]? cloud_cover_850hPa { get; set; }
        public double?[]? cloud_cover_700hPa { get; set; }
        public double?[]? cloud_cover_600hPa { get; set; }
        public double?[]? cloud_cover_500hPa { get; set; }
        public double?[]? cloud_cover_400hPa { get; set; }
        public double?[]? cloud_cover_300hPa { get; set; }
        public double?[]? cloud_cover_250hPa { get; set; }
        public double?[]? cloud_cover_200hPa { get; set; }
        public double?[]? cloud_cover_150hPa { get; set; }
        public double?[]? cloud_cover_100hPa { get; set; }
        public double?[]? cloud_cover_50hPa { get; set; }
        public double?[]? wind_speed_1000hPa { get; set; }
        public double?[]? wind_speed_925hPa { get; set; }
        public double?[]? wind_speed_850hPa { get; set; }
        public double?[]? wind_speed_700hPa { get; set; }
        public double?[]? wind_speed_600hPa { get; set; }
        public double?[]? wind_speed_500hPa { get; set; }
        public double?[]? wind_speed_400hPa { get; set; }
        public double?[]? wind_speed_300hPa { get; set; }
        public double?[]? wind_speed_250hPa { get; set; }
        public double?[]? wind_speed_200hPa { get; set; }
        public double?[]? wind_speed_150hPa { get; set; }
        public double?[]? wind_speed_100hPa { get; set; }
        public double?[]? wind_speed_50hPa { get; set; }
        public double?[]? wind_direction_1000hPa { get; set; }
        public double?[]? wind_direction_925hPa { get; set; }
        public double?[]? wind_direction_850hPa { get; set; }
        public double?[]? wind_direction_700hPa { get; set; }
        public double?[]? wind_direction_600hPa { get; set; }
        public double?[]? wind_direction_500hPa { get; set; }
        public double?[]? wind_direction_400hPa { get; set; }
        public double?[]? wind_direction_300hPa { get; set; }
        public double?[]? wind_direction_250hPa { get; set; }
        public double?[]? wind_direction_200hPa { get; set; }
        public double?[]? wind_direction_150hPa { get; set; }
        public double?[]? wind_direction_100hPa { get; set; }
        public double?[]? wind_direction_50hPa { get; set; }
        public double?[]? vertical_velocity_1000hPa { get; set; }
        public double?[]? vertical_velocity_925hPa { get; set; }
        public double?[]? vertical_velocity_850hPa { get; set; }
        public double?[]? vertical_velocity_700hPa { get; set; }
        public double?[]? vertical_velocity_600hPa { get; set; }
        public double?[]? vertical_velocity_500hPa { get; set; }
        public double?[]? vertical_velocity_400hPa { get; set; }
        public double?[]? vertical_velocity_300hPa { get; set; }
        public double?[]? vertical_velocity_250hPa { get; set; }
        public double?[]? vertical_velocity_200hPa { get; set; }
        public double?[]? vertical_velocity_150hPa { get; set; }
        public double?[]? vertical_velocity_100hPa { get; set; }
        public double?[]? vertical_velocity_50hPa { get; set; }
        public double?[]? geopotential_height_1000hPa { get; set; }
        public double?[]? geopotential_height_925hPa { get; set; }
        public double?[]? geopotential_height_850hPa { get; set; }
        public double?[]? geopotential_height_700hPa { get; set; }
        public double?[]? geopotential_height_600hPa { get; set; }
        public double?[]? geopotential_height_500hPa { get; set; }
        public double?[]? geopotential_height_400hPa { get; set; }
        public double?[]? geopotential_height_300hPa { get; set; }
        public double?[]? geopotential_height_250hPa { get; set; }
        public double?[]? geopotential_height_200hPa { get; set; }
        public double?[]? geopotential_height_150hPa { get; set; }
        public double?[]? geopotential_height_100hPa { get; set; }
        public double?[]? geopotential_height_50hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }
    }
    public static class aifsHourlyForecastApi
    {
        public static async Task<aifsParams?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 14,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns ECMWF AIFS Forecast from the Open-Meteo API.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=14. The number of days to retrieve forecast data for, starting from the current day. Maximum is 14 days.
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
                "temperature_2m"
                "relative_humidity_2m"
                "dew_point_2m"
                "apparent_temperature"
                "precipitation"
                "rain"
                "showers"
                "snowfall"
                "runoff"
                "visibility"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "cloud_cover_low"
                "cloud_cover_mid"
                "cloud_cover_high"
                "sunshine_duration"
                "potential_evapotranspiration"
                "et0_fao_evapotranspiration"
                "wind_speed_10m"
                "wind_speed_100m"
                "wind_speed_200m"
                "wind_direction_10m"
                "wind_direction_100m"
                "wind_direction_200m"
                "wind_gusts_10m"
                "cape"
                "convective_inhibition"
                "total_column_integrated_water_vapour"
                "vapour_pressure_deficit"
                "surface_temperature"
                "soil_temperature_0_to_7cm"
                "soil_temperature_7_to_28cm"
                "soil_temperature_28_to_100cm"
                "soil_temperature_100_to_255cm"
                "soil_moisture_0_to_7cm"
                "soil_moisture_28_to_100cm"
                "soil_moisture_7_to_28cm"
                "soil_moisture_100_to_255cm"
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
                "cloud_cover_1000hPa"
                "cloud_cover_925hPa"
                "cloud_cover_850hPa"
                "cloud_cover_700hPa"
                "cloud_cover_600hPa"
                "cloud_cover_500hPa"
                "cloud_cover_400hPa"
                "cloud_cover_300hPa"
                "cloud_cover_250hPa"
                "cloud_cover_200hPa"
                "cloud_cover_150hPa"
                "cloud_cover_100hPa"
                "cloud_cover_50hPa"
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
         *      
         * 
         * Returns
         * -------
         * 
         * The ECMWF AIFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {
            if (days > 14)
            {
                Console.WriteLine("The maximum number of days for the forecast is 14. Setting 'days' to 14.");
                days = 14;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m" ,
                                    "relative_humidity_2m" ,
                                    "dew_point_2m" ,
                                    "apparent_temperature" ,
                                    "precipitation" ,
                                    "rain" ,
                                    "showers" ,
                                    "snowfall" ,
                                    "runoff" ,
                                    "visibility" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "cloud_cover_low" ,
                                    "cloud_cover_mid" ,
                                    "cloud_cover_high" ,
                                    "sunshine_duration" ,
                                    "potential_evapotranspiration" ,
                                    "et0_fao_evapotranspiration" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_100m" ,
                                    "wind_speed_200m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_100m" ,
                                    "wind_direction_200m" ,
                                    "wind_gusts_10m" ,
                                    "cape" ,
                                    "convective_inhibition" ,
                                    "total_column_integrated_water_vapour" ,
                                    "vapour_pressure_deficit" ,
                                    "surface_temperature" ,
                                    "soil_temperature_0_to_7cm" ,
                                    "soil_temperature_7_to_28cm" ,
                                    "soil_temperature_28_to_100cm" ,
                                    "soil_temperature_100_to_255cm" ,
                                    "soil_moisture_0_to_7cm" ,
                                    "soil_moisture_28_to_100cm" ,
                                    "soil_moisture_7_to_28cm" ,
                                    "soil_moisture_100_to_255cm" ,
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
                                    "cloud_cover_1000hPa" ,
                                    "cloud_cover_925hPa" ,
                                    "cloud_cover_850hPa" ,
                                    "cloud_cover_700hPa" ,
                                    "cloud_cover_600hPa" ,
                                    "cloud_cover_500hPa" ,
                                    "cloud_cover_400hPa" ,
                                    "cloud_cover_300hPa" ,
                                    "cloud_cover_250hPa" ,
                                    "cloud_cover_200hPa" ,
                                    "cloud_cover_150hPa" ,
                                    "cloud_cover_100hPa" ,
                                    "cloud_cover_50hPa" ,
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

            // Open-Meto API Call URL
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=ecmwf_aifs025_single&forecast_days={days}" +
                $"&wind_speed_unit={windSpeedUnit}&temperature_unit={temperatureUnit}&precipitation_unit={precipitationUnit}";

            // Create HTTP client
            HttpClient httpClient;

            // If a proxy is provided, set up the HttpClient to use the proxy.
            if (!string.IsNullOrEmpty(proxy))
            {
                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = new WebProxy(proxy),
                    UseProxy = true
                };
                httpClient = new HttpClient(httpClientHandler);
            }
            else
            {
                httpClient = new HttpClient();
            }

            // 3. Ensure proper disposal of the selected client
            using (httpClient)
            {

                // Ping the server for a response. 
                var response = await httpClient.GetAsync(url);

                // Ensure we get a successful response, otherwise throw an exception.
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch
                {
                    HttpStatusCode statusCode = response.StatusCode;

                    if (statusCode == HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine($"Bad Request: The server could not understand the request. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.Unauthorized)
                    {
                        Console.WriteLine($"Unauthorized: Access is denied due to invalid credentials. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.Forbidden)
                    {
                        Console.WriteLine($"Forbidden: You do not have permission to access this resource. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Not Found: The requested resource could not be found. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if ((int)statusCode >= 500 && (int)statusCode < 600)
                    {
                        Console.WriteLine($"Server Error: The server encountered an error. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else
                    {
                        Console.WriteLine($"HTTP Error: An error occurred while making the request. Status Code: {(int)statusCode} {statusCode}");
                    }
                }

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

                // Deserialize the "hourly" property into our aifsParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<aifsParams>(hourlyWeatherElement.GetRawText());
                if (data == null)
                {
                    Console.WriteLine("Unable to parse hourly weather data.");
                    return null;
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

                    return data;
                }
                else
                {
                    Console.WriteLine($"ECMWF AIFS Data Not Available At This Time");
                    return null;

                }
            }
        }
    }
}




