/*
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.src.DWD
{
    public class iconParams
    {
        public string[]? time { get; set; }
        public double[]? temperature_2m { get; set; }
        public double[]? relative_humidity_2m { get; set; }
        public double[]? apparent_temperature { get; set; }
        public double[]? precipitation { get; set; }
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
        public double[]? temperature_975hPa { get; set; }
        public double[]? temperature_950hPa { get; set; }
        public double[]? temperature_925hPa { get; set; }
        public double[]? temperature_900hPa { get; set; }
        public double[]? temperature_850hPa { get; set; }
        public double[]? temperature_800hPa { get; set; }
        public double[]? temperature_700hPa { get; set; }
        public double[]? temperature_600hPa { get; set; }
        public double[]? temperature_500hPa { get; set; }
        public double[]? temperature_400hPa { get; set; }
        public double[]? temperature_300hPa { get; set; }
        public double[]? temperature_250hPa { get; set; }
        public double[]? temperature_200hPa { get; set; }
        public double[]? temperature_150hPa { get; set; }
        public double[]? temperature_100hPa { get; set; }
        public double[]? temperature_70hPa { get; set; }
        public double[]? temperature_50hPa { get; set; }
        public double[]? temperature_30hPa { get; set; }
        public double[]? relative_humidity_1000hPa { get; set; }
        public double[]? relative_humidity_975hPa { get; set; }
        public double[]? relative_humidity_950hPa { get; set; }
        public double[]? relative_humidity_925hPa { get; set; }
        public double[]? relative_humidity_900hPa { get; set; }
        public double[]? relative_humidity_850hPa { get; set; }
        public double[]? relative_humidity_800hPa { get; set; }
        public double[]? relative_humidity_700hPa { get; set; }
        public double[]? relative_humidity_600hPa { get; set; }
        public double[]? relative_humidity_500hPa { get; set; }
        public double[]? relative_humidity_400hPa { get; set; }
        public double[]? relative_humidity_300hPa { get; set; }
        public double[]? relative_humidity_250hPa { get; set; }
        public double[]? relative_humidity_200hPa { get; set; }
        public double[]? relative_humidity_150hPa { get; set; }
        public double[]? relative_humidity_100hPa { get; set; }
        public double[]? relative_humidity_70hPa { get; set; }
        public double[]? relative_humidity_50hPa { get; set; }
        public double[]? relative_humidity_30hPa { get; set; }
        public double[]? cloud_cover_1000hPa { get; set; }
        public double[]? cloud_cover_975hPa { get; set; }
        public double[]? cloud_cover_950hPa { get; set; }
        public double[]? cloud_cover_925hPa { get; set; }
        public double[]? cloud_cover_900hPa { get; set; }
        public double[]? cloud_cover_850hPa { get; set; }
        public double[]? cloud_cover_800hPa { get; set; }
        public double[]? cloud_cover_700hPa { get; set; }
        public double[]? cloud_cover_600hPa { get; set; }
        public double[]? cloud_cover_500hPa { get; set; }
        public double[]? cloud_cover_400hPa { get; set; }
        public double[]? cloud_cover_300hPa { get; set; }
        public double[]? cloud_cover_250hPa { get; set; }
        public double[]? cloud_cover_200hPa { get; set; }
        public double[]? cloud_cover_150hPa { get; set; }
        public double[]? cloud_cover_100hPa { get; set; }
        public double[]? cloud_cover_70hPa { get; set; }
        public double[]? cloud_cover_50hPa { get; set; }
        public double[]? cloud_cover_30hPa { get; set; }
        public double[]? wind_speed_1000hPa { get; set; }
        public double[]? wind_speed_975hPa { get; set; }
        public double[]? wind_speed_950hPa { get; set; }
        public double[]? wind_speed_925hPa { get; set; }
        public double[]? wind_speed_900hPa { get; set; }
        public double[]? wind_speed_850hPa { get; set; }
        public double[]? wind_speed_800hPa { get; set; }
        public double[]? wind_speed_700hPa { get; set; }
        public double[]? wind_speed_600hPa { get; set; }
        public double[]? wind_speed_500hPa { get; set; }
        public double[]? wind_speed_400hPa { get; set; }
        public double[]? wind_speed_300hPa { get; set; }
        public double[]? wind_speed_250hPa { get; set; }
        public double[]? wind_speed_200hPa { get; set; }
        public double[]? wind_speed_150hPa { get; set; }
        public double[]? wind_speed_100hPa { get; set; }
        public double[]? wind_speed_70hPa { get; set; }
        public double[]? wind_speed_50hPa { get; set; }
        public double[]? wind_speed_30hPa { get; set; }
        public double[]? wind_direction_1000hPa { get; set; }
        public double[]? wind_direction_975hPa { get; set; }
        public double[]? wind_direction_950hPa { get; set; }
        public double[]? wind_direction_925hPa { get; set; }
        public double[]? wind_direction_900hPa { get; set; }
        public double[]? wind_direction_850hPa { get; set; }
        public double[]? wind_direction_800hPa { get; set; }
        public double[]? wind_direction_700hPa { get; set; }
        public double[]? wind_direction_600hPa { get; set; }
        public double[]? wind_direction_500hPa { get; set; }
        public double[]? wind_direction_400hPa { get; set; }
        public double[]? wind_direction_300hPa { get; set; }
        public double[]? wind_direction_250hPa { get; set; }
        public double[]? wind_direction_200hPa { get; set; }
        public double[]? wind_direction_150hPa { get; set; }
        public double[]? wind_direction_100hPa { get; set; }
        public double[]? wind_direction_70hPa { get; set; }
        public double[]? wind_direction_50hPa { get; set; }
        public double[]? wind_directions_30hPa { get; set; }
        public double[]? geopotential_height_1000hPa { get; set; }
        public double[]? geopotential_height_975hPa { get; set; }
        public double[]? geopotential_height_950hPa { get; set; }
        public double[]? geopotential_height_925hPa { get; set; }
        public double[]? geopotential_height_900hPa { get; set; }
        public double[]? geopotential_height_850hPa { get; set; }
        public double[]? geopotential_height_800hPa { get; set; }
        public double[]? geopotential_height_700hPa { get; set; }
        public double[]? geopotential_height_600hPa { get; set; }
        public double[]? geopotential_height_500hPa { get; set; }
        public double[]? geopotential_height_400hPa { get; set; }
        public double[]? geopotential_height_300hPa { get; set; }
        public double[]? geopotential_height_250hPa { get; set; }
        public double[]? geopotential_height_200hPa { get; set; }
        public double[]? geopotential_height_150hPa { get; set; }
        public double[]? geopotential_height_100hPa { get; set; }
        public double[]? geopotential_height_70hPa { get; set; }
        public double[]? geopotential_height_50hPa { get; set; }
        public double[]? geopotential_height_30hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }
    }

    public static class iconHourlyForecastApi
    {
        public static async Task<iconParams?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns DWD ICON Forecast from the Open-Meteo API.
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
                "precipitation" 
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
                "temperature_975hPa"
                "temperature_950hPa"
                "temperature_925hPa"
                "temperature_900hPa"
                "temperature_850hPa"
                "temperature_800hPa"
                "temperature_700hPa"
                "temperature_600hPa"
                "temperature_500hPa"
                "temperature_400hPa"
                "temperature_300hPa"
                "temperature_250hPa"
                "temperature_200hPa"
                "temperature_150hPa"
                "temperature_100hPa"
                "temperature_70hPa"
                "temperature_50hPa"
                "temperature_30hPa"
                "relative_humidity_1000hPa"
                "relative_humidity_975hPa"
                "relative_humidity_950hPa"
                "relative_humidity_925hPa"
                "relative_humidity_900hPa"
                "relative_humidity_850hPa"
                "relative_humidity_800hPa"
                "relative_humidity_700hPa"
                "relative_humidity_600hPa"
                "relative_humidity_500hPa"
                "relative_humidity_400hPa"
                "relative_humidity_300hPa"
                "relative_humidity_250hPa"
                "relative_humidity_200hPa"
                "relative_humidity_150hPa"
                "relative_humidity_100hPa"
                "relative_humidity_70hPa"
                "relative_humidity_50hPa"
                "relative_humidity_30hPa"
                "cloud_cover_1000hPa"
                "cloud_cover_975hPa"
                "cloud_cover_950hPa"
                "cloud_cover_925hPa"
                "cloud_cover_900hPa"
                "cloud_cover_850hPa"
                "cloud_cover_800hPa"
                "cloud_cover_700hPa"
                "cloud_cover_600hPa"
                "cloud_cover_500hPa"
                "cloud_cover_400hPa"
                "cloud_cover_300hPa"
                "cloud_cover_250hPa"
                "cloud_cover_200hPa"
                "cloud_cover_150hPa"
                "cloud_cover_100hPa"
                "cloud_cover_70hPa"
                "cloud_cover_50hPa"
                "cloud_cover_30hPa"
                "wind_speed_1000hPa"
                "wind_speed_975hPa"
                "wind_speed_950hPa"
                "wind_speed_925hPa"
                "wind_speed_900hPa"
                "wind_speed_850hPa"
                "wind_speed_800hPa"
                "wind_speed_700hPa"
                "wind_speed_600hPa"
                "wind_speed_500hPa"
                "wind_speed_400hPa"
                "wind_speed_300hPa"
                "wind_speed_250hPa"
                "wind_speed_200hPa"
                "wind_speed_150hPa"
                "wind_speed_100hPa"
                "wind_speed_70hPa"
                "wind_speed_50hPa"
                "wind_speed_30hPa"
                "wind_direction_1000hPa"
                "wind_direction_975hPa"
                "wind_direction_950hPa"
                "wind_direction_925hPa"
                "wind_direction_900hPa"
                "wind_direction_850hPa"
                "wind_direction_800hPa"
                "wind_direction_700hPa"
                "wind_direction_600hPa"
                "wind_direction_500hPa"
                "wind_direction_400hPa"
                "wind_direction_300hPa"
                "wind_direction_250hPa"
                "wind_direction_200hPa"
                "wind_direction_150hPa"
                "wind_direction_100hPa"
                "wind_direction_70hPa"
                "wind_direction_50hPa"
                "wind_directions_30hPa"
                "geopotential_height_1000hPa" 
                "geopotential_height_975hPa" 
                "geopotential_height_950hPa" 
                "geopotential_height_925hPa" 
                "geopotential_height_900hPa" 
                "geopotential_height_850hPa" 
                "geopotential_height_800hPa" 
                "geopotential_height_700hPa" 
                "geopotential_height_600hPa" 
                "geopotential_height_500hPa" 
                "geopotential_height_400hPa" 
                "geopotential_height_300hPa" 
                "geopotential_height_250hPa" 
                "geopotential_height_200hPa" 
                "geopotential_height_150hPa" 
                "geopotential_height_100hPa" 
                "geopotential_height_70hPa" 
                "geopotential_height_50hPa" 
                "geopotential_height_30hPa" 


          5) proxy (string) - Optional proxy server URL in the form of "https://proxyserver:port". Default is null (no proxy).
         *      
         * 
         * Returns
         * -------
         * 
         * The ICON Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
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
                                    "soil_moisture_27_to_81cm" ,
                                    "temperature_1000hPa" ,
                                    "temperature_975hPa" ,
                                    "temperature_950hPa" ,
                                    "temperature_925hPa" ,
                                    "temperature_900hPa" ,
                                    "temperature_850hPa" ,
                                    "temperature_800hPa" ,
                                    "temperature_700hPa" ,
                                    "temperature_600hPa" ,
                                    "temperature_500hPa" ,
                                    "temperature_400hPa" ,
                                    "temperature_300hPa" ,
                                    "temperature_250hPa" ,
                                    "temperature_200hPa" ,
                                    "temperature_150hPa" ,
                                    "temperature_100hPa" ,
                                    "temperature_70hPa" ,
                                    "temperature_50hPa" ,
                                    "temperature_30hPa" ,
                                    "relative_humidity_1000hPa" ,
                                    "relative_humidity_975hPa" ,
                                    "relative_humidity_950hPa" ,
                                    "relative_humidity_925hPa" ,
                                    "relative_humidity_900hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_800hPa" ,
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_70hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "relative_humidity_30hPa" ,
                                    "cloud_cover_1000hPa" ,
                                    "cloud_cover_975hPa" ,
                                    "cloud_cover_950hPa" ,
                                    "cloud_cover_925hPa" ,
                                    "cloud_cover_900hPa" ,
                                    "cloud_cover_850hPa" ,
                                    "cloud_cover_800hPa" ,
                                    "cloud_cover_700hPa" ,
                                    "cloud_cover_600hPa" ,
                                    "cloud_cover_500hPa" ,
                                    "cloud_cover_400hPa" ,
                                    "cloud_cover_300hPa" ,
                                    "cloud_cover_250hPa" ,
                                    "cloud_cover_200hPa" ,
                                    "cloud_cover_150hPa" ,
                                    "cloud_cover_100hPa" ,
                                    "cloud_cover_70hPa" ,
                                    "cloud_cover_50hPa" ,
                                    "cloud_cover_30hPa" ,
                                    "wind_speed_1000hPa" ,
                                    "wind_speed_975hPa" ,
                                    "wind_speed_950hPa" ,
                                    "wind_speed_925hPa" ,
                                    "wind_speed_900hPa" ,
                                    "wind_speed_850hPa" ,
                                    "wind_speed_800hPa" ,
                                    "wind_speed_700hPa" ,
                                    "wind_speed_600hPa" ,
                                    "wind_speed_500hPa" ,
                                    "wind_speed_400hPa" ,
                                    "wind_speed_300hPa" ,
                                    "wind_speed_250hPa" ,
                                    "wind_speed_200hPa" ,
                                    "wind_speed_150hPa" ,
                                    "wind_speed_100hPa" ,
                                    "wind_speed_70hPa" ,
                                    "wind_speed_50hPa" ,
                                    "wind_speed_30hPa" ,
                                    "wind_direction_1000hPa" ,
                                    "wind_direction_975hPa" ,
                                    "wind_direction_950hPa" ,
                                    "wind_direction_925hPa" ,
                                    "wind_direction_900hPa" ,
                                    "wind_direction_850hPa" ,
                                    "wind_direction_800hPa" ,
                                    "wind_direction_700hPa" ,
                                    "wind_direction_600hPa" ,
                                    "wind_direction_500hPa" ,
                                    "wind_direction_400hPa" ,
                                    "wind_direction_300hPa" ,
                                    "wind_direction_250hPa" ,
                                    "wind_direction_200hPa" ,
                                    "wind_direction_150hPa" ,
                                    "wind_direction_100hPa" ,
                                    "wind_direction_70hPa" ,
                                    "wind_direction_50hPa" ,
                                    "wind_directions_30hPa" ,
                                    "geopotential_height_1000hPa" ,
                                    "geopotential_height_975hPa" ,
                                    "geopotential_height_950hPa" ,
                                    "geopotential_height_925hPa" ,
                                    "geopotential_height_900hPa" ,
                                    "geopotential_height_850hPa" ,
                                    "geopotential_height_800hPa" ,
                                    "geopotential_height_700hPa" ,
                                    "geopotential_height_600hPa" ,
                                    "geopotential_height_500hPa" ,
                                    "geopotential_height_400hPa" ,
                                    "geopotential_height_300hPa" ,
                                    "geopotential_height_250hPa" ,
                                    "geopotential_height_200hPa" ,
                                    "geopotential_height_150hPa" ,
                                    "geopotential_height_100hPa" ,
                                    "geopotential_height_70hPa" ,
                                    "geopotential_height_50hPa" ,
                                    "geopotential_height_30hPa" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=icon_seamless" +
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

                // Deserialize the "hourly" property into our iconParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<iconParams>(hourlyWeatherElement.GetRawText());
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

            }    }    
        }
    }
}
