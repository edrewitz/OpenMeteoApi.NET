/*
 * Eric J. Drewitz 2026
 * 
 * 
 * Written on 5/25/2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.AIGFS
{
    public class modelParams
    {
        public string[]? time { get; set; }
        public double[]? temperature_2m { get; set; }
        public double[]? relative_humidity_2m { get; set; }
        public double[]? apparent_temperature { get; set; }
        public double[]? cape { get; set; }
        public double[]? precipitation { get; set; }
        public double[]? rain { get; set; }
        public double[]? snow { get; set; }
        public double[]? snowfall { get; set; }
        public double[]? snow_depth { get; set; }
        public double[]? pressure_msl { get; set; }
        public double[]? surface_pressure { get; set; }
        public double[]? cloud_cover { get; set; }
        public double[]? cloud_cover_low { get; set; }
        public double[]? cloud_cover_mid { get; set; }
        public double[]? cloud_cover_high { get; set; }
        public double[]? visibility { get; set; }
        public double[]? evapotranspiration { get; set; }
        public double[]? et0_fao_evapotranspiration { get; set; }
        public double[]? vapour_pressure_deficit { get; set; }
        public double[]? wind_speed_10m { get; set; }
        public double[]? wind_speed_80m { get; set; }
        public double[]? wind_speed_120m { get; set; }
        public double[]? wind_speed_180m { get; set; }
        public double[]? wind_direction_10m { get; set; }
        public double[]? wind_direction_80m { get; set; }
        public double[]? wind_direction_120m { get; set; }
        public double[]? wind_direction_180m { get; set; }
        public double[]? temperature_80m { get; set; }
        public double[]? wind_gusts_10m { get; set; }
        public double[]? temperature_120m { get; set; }
        public double[]? temperature_180m { get; set; }
        public double[]? soil_temperature_0cm { get; set; }
        public double[]? soil_temperature_6cm { get; set; }
        public double[]? soil_temperature_18cm { get; set; }
        public double[]? soil_temperature_54cm { get; set; }
        public double[]? soil_moisture_0_to_1cm { get; set; }
        public double[]? soil_moisture_1_to_3cm { get; set; }
        public double[]? soil_moisture_3_to_9cm { get; set; }
        public double[]? soil_moisture_9_to_27cm { get; set; }
        public double[]? soil_moisture_27_to_81cm { get; set; }
        public double[]? temperature_1000hPa { get; set; }
        public double[]? temperature_925hPa { get; set; }
        public double[]? temperature_850hPa { get; set; }
        public double[]? temperature_700hPa { get; set; }
        public double[]? temperature_600hPa { get; set; }
        public double[]? temperature_500hPa { get; set; }
        public double[]? temperature_400hPa { get; set; }
        public double[]? temperature_300hPa { get; set; }
        public double[]? temperature_250hPa { get; set; }
        public double[]? temperature_200hPa { get; set; }
        public double[]? temperature_150hPa { get; set; }
        public double[]? temperature_100hPa { get; set; }
        public double[]? temperature_50hPa { get; set; }
        public double[]? dew_point_1000hPa { get; set; }
        public double[]? dew_point_925hPa { get; set; }
        public double[]? dew_point_850hPa { get; set; }
        public double[]? dew_point_700hPa { get; set; }
        public double[]? dew_point_600hPa { get; set; }
        public double[]? dew_point_500hPa { get; set; }
        public double[]? dew_point_400hPa { get; set; }
        public double[]? dew_point_300hPa { get; set; }
        public double[]? dew_point_250hPa { get; set; }
        public double[]? dew_point_200hPa { get; set; }
        public double[]? dew_point_150hPa { get; set; }
        public double[]? dew_point_100hPa { get; set; }
        public double[]? dew_point_50hPa { get; set; }
        public double[]? relative_humidity_1000hPa { get; set; }
        public double[]? relative_humidity_925hPa { get; set; }
        public double[]? relative_humidity_850hPa { get; set; }
        public double[]? relative_humidity_700hPa { get; set; }
        public double[]? relative_humidity_600hPa { get; set; }
        public double[]? relative_humidity_500hPa { get; set; }
        public double[]? relative_humidity_400hPa { get; set; }
        public double[]? relative_humidity_300hPa { get; set; }
        public double[]? relative_humidity_250hPa { get; set; }
        public double[]? relative_humidity_200hPa { get; set; }
        public double[]? relative_humidity_150hPa { get; set; }
        public double[]? relative_humidity_100hPa { get; set; }
        public double[]? relative_humidity_50hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }

    }
    public static class aigfsHourlyPointForecastApi
    {
        public static async Task<modelParams?> GetData(string latitude,
                                                         string longitude,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns a NOAA/NCEP/AIGFS point forecast for a specified point of lat/lon.
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

          5) proxy (string) - Optional proxy server URL in the form of "https://proxyserver:port". Default is null (no proxy).
         *      
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
                                    "soil_moisture_27_to_81cm" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=gfs_seamless" +
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
                    Console.WriteLine("An Error Occurred: Most likely due to a bad request. Check for typos and try again.");
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

                // Deserialize the "hourly" property into our modelParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<modelParams>(hourlyWeatherElement.GetRawText());
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

                    return data;
                }

                else
                {
                    Console.WriteLine($"GFS Data Not Available At This Time");
                    return null;
                }
            }

        }
    }
}


