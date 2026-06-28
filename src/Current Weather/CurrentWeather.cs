/*
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.CurrentWeather
{
    public class currentWeather
    {
        public string? time { get; set; }
        public double? temperature_2m { get; set; }
        public double? relative_humidity_2m { get; set; }
        public double? apparent_temperature { get; set; }
        public double? precipitation { get; set; }
        public double? snowfall { get; set; }
        public double? cloud_cover { get; set; }
        public double? pressure_msl { get; set; }
        public double? surface_pressure { get; set; }
        public double? wind_speed_10m { get; set; }
        public double? wind_direction_10m { get; set; }
        public double? wind_gusts_10m { get; set; }
        public double? weather_code { get; set; }
        public double? rain { get; set; }
        public double? showers { get; set; }
        public DateTime? localTime { get; set; }
    }
    public static class currentWeatherApi
    {
        public static async Task<currentWeather?> GetPointData(string latitude,
                                                         string longitude,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns the latest weather data.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) temperatureUnit (string) - Default="fahrenheit". The units for the temperature data.
         * 
         *      Valid Units
         *      -----------
         *      
         *      1) fahrenheit [Fahrenheit]
         *      2) celsius [Celsius]
         *      
         * 2) windSpeedUnit (string) - Default="mph". The units for the wind speed data. 
         * 
         *      Valid Units
         *      -----------
         *      1) mph (Miles Per Hour)
         *      2) ms (Meters Per Second)
         *      3) kmh (Kilometers Per Hour)
         *      4) kn (Knots)
         *      
         * 3) precipitationUnit (string) - Default="inch". The units for the precipitation data.
         * 
         *      Valid Units
         *      -----------
         *      1) inch [Inches]
         *      2) mm [Millimeters]
         *      
         * 4) variables (string[]) - Optional list of current variables to request. Default is all variables.
         * 
         *      Variables
         *      ---------
         *      
         *      "temperature_2m"
                "relative_humidity_2m" 
                "apparent_temperature"
                "precipitation"
                "snowfall"
                "cloud_cover"
                "pressure_msl"
                "surface_pressure"
                "wind_speed_10m"
                "wind_direction_10m"
                "wind_gusts_10m"
                "weather_code"
                "rain"
                "showers"

          5) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).
         * 
         * Returns
         * -------
         * 
         * The current weather data in the form of a JSON object. 
         */

        {
            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m", 
                    "relative_humidity_2m" , 
                    "apparent_temperature" ,
                    "precipitation" ,
                    "snowfall" ,
                    "cloud_cover" ,
                    "pressure_msl" ,
                    "surface_pressure" ,
                    "wind_speed_10m" ,
                    "wind_direction_10m" ,
                    "wind_gusts_10m" ,
                    "weather_code"  ,
                    "rain"  ,
                    "showers"};
            }
            else
            {

            }

            // Build the 'current' query parameter from the variables array.
            var currentParam = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&" +
                $"current={currentParam}" +
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

                // Parse the JSON string and extract the "current" property, which contains the current weather data.
                var root = JsonDocument.Parse(jsonString).RootElement;

                // Check if the "current" property exists in the JSON response.
                if (!root.TryGetProperty("current", out var currentWeatherElement))
                {
                    Console.WriteLine("Response JSON does not contain a 'current' property.");
                    return null;
                }

                // Deserialize the "current" property into our currentWeather class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<currentWeather>(currentWeatherElement.GetRawText());
                if (data == null)
                {
                    Console.WriteLine("Unable to parse current weather data.");
                    return null;
                }
                else
                {
                    // Extract the time attribute which is in the form of a string.
                    var time = data.time;

                    // Convert the time string to a DateTime object.
                    var dateTime = DateTime.Parse(time);

                    // Convert the DateTime object to local time.
                    data.localTime = dateTime.ToLocalTime();

                    return data;

                }
            }    
        }
    }
}
