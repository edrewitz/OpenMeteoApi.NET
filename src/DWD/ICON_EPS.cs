/*
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.ICON_EPS
{
    public class Temperature2m
    {
        public string[]? time { get; set; }
        public double[]? temperature_2m { get; set; }
        public double[]? temperature_2m_member01 { get; set; }
        public double[]? temperature_2m_member02 { get; set; }
        public double[]? temperature_2m_member03 { get; set; }
        public double[]? temperature_2m_member04 { get; set; }
        public double[]? temperature_2m_member05 { get; set; }
        public double[]? temperature_2m_member06 { get; set; }
        public double[]? temperature_2m_member07 { get; set; }
        public double[]? temperature_2m_member08 { get; set; }
        public double[]? temperature_2m_member09 { get; set; }
        public double[]? temperature_2m_member10 { get; set; }
        public double[]? temperature_2m_member11 { get; set; }
        public double[]? temperature_2m_member12 { get; set; }
        public double[]? temperature_2m_member13 { get; set; }
        public double[]? temperature_2m_member14 { get; set; }
        public double[]? temperature_2m_member15 { get; set; }
        public double[]? temperature_2m_member16 { get; set; }
        public double[]? temperature_2m_member17 { get; set; }
        public double[]? temperature_2m_member18 { get; set; }
        public double[]? temperature_2m_member19 { get; set; }
        public double[]? temperature_2m_member20 { get; set; }
        public double[]? temperature_2m_member21 { get; set; }
        public double[]? temperature_2m_member22 { get; set; }
        public double[]? temperature_2m_member23 { get; set; }
        public double[]? temperature_2m_member24 { get; set; }
        public double[]? temperature_2m_member25 { get; set; }
        public double[]? temperature_2m_member26 { get; set; }
        public double[]? temperature_2m_member27 { get; set; }
        public double[]? temperature_2m_member28 { get; set; }
        public double[]? temperature_2m_member29 { get; set; }
        public double[]? temperature_2m_member30 { get; set; }
        public double[]? temperature_2m_member31 { get; set; }
        public double[]? temperature_2m_member32 { get; set; }
        public double[]? temperature_2m_member33 { get; set; }
        public double[]? temperature_2m_member34 { get; set; }
        public double[]? temperature_2m_member35 { get; set; }
        public double[]? temperature_2m_member36 { get; set; }
        public double[]? temperature_2m_member37 { get; set; }
        public double[]? temperature_2m_member38 { get; set; }
        public double[]? temperature_2m_member39 { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }

    }
    public static class iconEPSTemperature2mApi
    {
        public static async Task<Temperature2m?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         string temperatureUnit = "fahrenheit",
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns DWD ICON EPS 2-Meter Temperature Forecast (Ensemble Members) from the Open-Meteo API.
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
          2) proxy (string) - Optional proxy server URL in the form of "https://proxyserver:port". Default is null (no proxy).
         *      
         * 
         * Returns
         * -------
         * 
         * The ICON EPS 2-Meter Temperature Forecast (Ensemble Members) for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {

            // Open-Meto API Call URL
            string url = $"https://ensemble-api.open-meteo.com/v1/ensemble?latitude={latitude}&longitude={longitude}" +
                $"&hourly=temperature_2m" +
                $"&models=icon_seamless_eps" +
                $"&temperature_unit={temperatureUnit}";
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

                // Deserialize the "hourly" property into our iconParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<Temperature2m>(hourlyWeatherElement.GetRawText());
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
                    Console.WriteLine($"ICON Data Not Available At This Time");
                    return null;

                }
            }
        }
    }
}
