/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using System.Net;

namespace OpenMeteoApiNet.Utils.DataAccess
{
    public class RetrieveData
    {
        public static async Task<HttpResponseMessage?> GetDataAsync(string url,
                                              string? proxy = null)

        /*
         * This function retrieves the HTTPS response from the URL and uses a proxy server if provided.
         * 
         * Required Arguments: 
         * 
         * 1) url (String) - The URL of the API. 
         * 
         * Optional Arguments:
         * 
         * 1) proxy (String) - The proxy server to use for the request. If not provided, no proxy will be used.
         * 
         * Returns
         * -------
         * 
         * An HTTP Response Message containing the data or null if an error occurred. 
         */

        {
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

                    return response;
                }
                catch
                {
                    // Returns an error message based on the HTTP status code received from the server.
                    HttpStatusCode statusCode = response.StatusCode;
                    string errorMessage = statusCode switch
                    {
                        HttpStatusCode.BadRequest => $"Bad Request: Server could not understand. Code: {(int)statusCode}",
                        HttpStatusCode.Unauthorized => $"Unauthorized: Invalid credentials. Code: {(int)statusCode}",
                        HttpStatusCode.Forbidden => $"Forbidden: Permission denied. Code: {(int)statusCode}",
                        HttpStatusCode.NotFound => $"Not Found: Resource not found. Code: {(int)statusCode}",

                        HttpStatusCode code when (int)code >= 500 && (int)code < 600
                                                    => $"Server Error: The server encountered an error. Code: {(int)code}",

                        _ => $"HTTP Error: An error occurred. Code: {(int)statusCode}"
                    };

                    Console.WriteLine(errorMessage);
                    return null;
                }
            }
        }
    }
}

