# Meteo France

## `class arpegeHourlyForecastApi`

***public static async Task<arpegeParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 4 ,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns a Meteo France/ARPEGE point forecast for a specified point of lat/lon.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=4. The number of days to forecast, maximum of 4 days. 
 
 2) temperatureUnit (string) - Default="fahrenheit". The units for the temperature data.
 
        Valid Units
        -----------
        
        1) fahrenheit [Fahrenheit]
        2) celsius [Celsius]
      
 3) windSpeedUnit (string) - Default="mph". The units for the wind speed data. 
 
        Valid Units
        -----------
        1) mph (Miles Per Hour)
        2) ms (Meters Per Second)
        3) kmh (Kilometers Per Hour)
        4) kn (Knots)
      
 4) precipitationUnit (string) - Default="inch". The units for the precipitation data.
 
        Valid Units
        -----------
        1) inch [Inches]
        2) mm [Millimeters]
      
 5) variables (string[]) - Optional list of current variables to request. Default is all variables.
 
                Variables
                ---------
                "temperature_2m"
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
                "cloud_cover_low"
                "cloud_cover_mid"
                "cloud_cover_high"
                "et0_fao_evapotranspiration"
                "vapour_pressure_deficit"
                "wind_speed_10m"
                "wind_speed_20m"
                "wind_speed_50m"
                "wind_speed_100m"
                "wind_speed_150m"
                "wind_speed_200m"
                "wind_direction_10m"
                "wind_direction_20m"
                "wind_direction_50m"
                "wind_direction_100m"
                "wind_direction_150m"
                "wind_direction_200m"
                "wind_gusts_10m"
                "temperature_20m"
                "temperature_50m"
                "temperature_100m"
                "temperature_150m"
                "temperature_200m"
                "temperature_1000hPa"
                "temperature_950hPa"
                "temperature_925hPa"
                "temperature_900hPa"
                "temperature_850hPa"
                "temperature_800hPa"
                "temperature_750hPa"
                "temperature_700hPa"
                "temperature_650hPa"
                "temperature_600hPa"
                "temperature_550hPa"
                "temperature_500hPa"
                "temperature_450hPa"
                "temperature_400hPa"
                "temperature_350hPa"
                "temperature_300hPa"
                "temperature_275hPa"
                "temperature_250hPa"
                "temperature_225hPa"
                "temperature_200hPa"
                "temperature_175hPa"
                "temperature_150hPa"
                "temperature_125hPa"
                "temperature_100hPa"
                "temperature_70hPa"
                "temperature_50hPa"
                "temperature_30hPa"
                "temperature_20hPa"
                "temperature_10hPa"
                "dew_point_1000hPa"
                "dew_point_950hPa"
                "dew_point_925hPa"
                "dew_point_900hPa"
                "dew_point_850hPa"
                "dew_point_800hPa"
                "dew_point_700hPa"
                "dew_point_750hPa"
                "dew_point_650hPa"
                "dew_point_600hPa"
                "dew_point_550hPa"
                "dew_point_500hPa"
                "dew_point_450hPa"
                "dew_point_400hPa"
                "dew_point_350hPa"
                "dew_point_300hPa"
                "dew_point_275hPa"
                "dew_point_250hPa"
                "dew_point_225hPa"
                "dew_point_200hPa"
                "dew_point_175hPa"
                "dew_point_150hPa"
                "dew_point_125hPa"
                "dew_point_100hPa"
                "dew_point_70hPa"
                "dew_point_50hPa"
                "dew_point_30hPa"
                "dew_point_20hPa"
                "dew_point_10hPa"
                "relative_humidity_1000hPa"
                "relative_humidity_950hPa"
                "relative_humidity_925hPa"
                "relative_humidity_900hPa"
                "relative_humidity_850hPa"
                "relative_humidity_800hPa"
                "relative_humidity_750hPa"
                "relative_humidity_700hPa"
                "relative_humidity_650hPa"
                "relative_humidity_600hPa"
                "relative_humidity_550hPa"
                "relative_humidity_500hPa"
                "relative_humidity_450hPa"
                "relative_humidity_400hPa"
                "relative_humidity_350hPa"
                "relative_humidity_300hPa"
                "relative_humidity_275hPa"
                "relative_humidity_250hPa"
                "relative_humidity_225hPa"
                "relative_humidity_200hPa"
                "relative_humidity_175hPa"
                "relative_humidity_150hPa"
                "relative_humidity_125hPa"
                "relative_humidity_100hPa"
                "relative_humidity_70hPa"
                "relative_humidity_50hPa"
                "relative_humidity_30hPa"
                "relative_humidity_20hPa"
                "relative_humidity_10hPa"
                "cloud_cover_1000hPa"
                "cloud_cover_950hPa"
                "cloud_cover_925hPa"
                "cloud_cover_900hPa"
                "cloud_cover_850hPa"
                "cloud_cover_800hPa"
                "cloud_cover_750hPa"
                "cloud_cover_700hPa"
                "cloud_cover_650hPa"
                "cloud_cover_600hPa"
                "cloud_cover_550hPa"
                "cloud_cover_500hPa"
                "cloud_cover_450hPa"
                "cloud_cover_400hPa"
                "cloud_cover_350hPa"
                "cloud_cover_300hPa"
                "cloud_cover_275hPa"
                "cloud_cover_250hPa"
                "cloud_cover_225hPa"
                "cloud_cover_200hPa"
                "cloud_cover_175hPa"
                "cloud_cover_150hPa"
                "cloud_cover_125hPa"
                "cloud_cover_100hPa"
                "cloud_cover_70hPa"
                "cloud_cover_50hPa"
                "cloud_cover_30hPa"
                "cloud_cover_20hPa"
                "cloud_cover_10hPa"
                "wind_speed_1000hPa"
                "wind_speed_950hPa"
                "wind_speed_925hPa"
                "wind_speed_900hPa"
                "wind_speed_850hPa"
                "wind_speed_800hPa"
                "wind_speed_750hPa"
                "wind_speed_700hPa"
                "wind_speed_650hPa"
                "wind_speed_600hPa"
                "wind_speed_550hPa"
                "wind_speed_500hPa"
                "wind_speed_450hPa"
                "wind_speed_400hPa"
                "wind_speed_350hPa"
                "wind_speed_300hPa"
                "wind_speed_275hPa"
                "wind_speed_250hPa"
                "wind_speed_225hPa"
                "wind_speed_200hPa"
                "wind_speed_175hPa"
                "wind_speed_150hPa"
                "wind_speed_125hPa"
                "wind_speed_100hPa"
                "wind_speed_70hPa"
                "wind_speed_50hPa"
                "wind_speed_30hPa"
                "wind_speed_20hPa"
                "wind_speed_10hPa"
                "wind_direction_1000hPa"
                "wind_direction_950hPa"
                "wind_direction_925hPa"
                "wind_direction_900hPa"
                "wind_direction_850hPa"
                "wind_direction_800hPa"
                "wind_direction_750hPa"
                "wind_direction_700hPa"
                "wind_direction_650hPa"
                "wind_direction_600hPa"
                "wind_direction_550hPa"
                "wind_direction_500hPa"
                "wind_direction_450hPa"
                "wind_direction_400hPa"
                "wind_direction_350hPa"
                "wind_direction_300hPa"
                "wind_direction_275hPa"
                "wind_direction_250hPa"
                "wind_direction_225hPa"
                "wind_direction_200hPa"
                "wind_direction_175hPa"
                "wind_direction_150hPa"
                "wind_direction_125hPa"
                "wind_direction_100hPa"
                "wind_direction_70hPa"
                "wind_direction_50hPa"
                "wind_direction_30hPa"
                "wind_direction_20hPa"
                "wind_direction_10hPa"
                "geopotential_height_1000hPa"
                "geopotential_height_950hPa"
                "geopotential_height_925hPa"
                "geopotential_height_900hPa"
                "geopotential_height_850hPa"
                "geopotential_height_800hPa"
                "geopotential_height_750hPa"
                "geopotential_height_700hPa"
                "geopotential_height_650hPa"
                "geopotential_height_600hPa"
                "geopotential_height_550hPa"
                "geopotential_height_500hPa"
                "geopotential_height_450hPa"
                "geopotential_height_400hPa"
                "geopotential_height_350hPa"
                "geopotential_height_300hPa"
                "geopotential_height_275hPa"
                "geopotential_height_250hPa"
                "geopotential_height_225hPa"
                "geopotential_height_200hPa"
                "geopotential_height_175hPa"
                "geopotential_height_150hPa"
                "geopotential_height_125hPa"
                "geopotential_height_100hPa"
                "geopotential_height_70hPa"
                "geopotential_height_50hPa"
                "geopotential_height_30hPa"
                "geopotential_height_20hPa"
                "geopotential_height_10hPa" 

6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
 
 **Returns**

 The ARPEGE Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
