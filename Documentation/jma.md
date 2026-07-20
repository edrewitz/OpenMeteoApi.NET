# Japan Meteorological Agency (JMA)

## `class jmaHourlyForecastApi`

```Csharp
namespace OpenMeteoApiNet.DeterministicForecasts.JMA.JMA
```

```Csharp
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
```

 This function is the client that retrieves and returns the hourly Japan Meteorological Agency (JMA) point forecast for a specified point of lat/lon.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=7. The number of days to forecast, up to a maximum of 16 days.
 
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
                "wind_speed_10m"
                "wind_direction_10m"
                "et0_fao_evapotranspiration"
                "vapour_pressure_deficit"
                "temperature_1000hPa"
                "temperature_975hPa"
                "temperature_925hPa"
                "temperature_950hPa"
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
                "dew_point_1000hPa"
                "dew_point_975hPa"
                "dew_point_950hPa"
                "dew_point_925hPa"
                "dew_point_900hPa"
                "dew_point_850hPa"
                "dew_point_800hPa"
                "dew_point_700hPa"
                "dew_point_600hPa"
                "dew_point_500hPa"
                "dew_point_400hPa"
                "dew_point_300hPa"
                "dew_point_250hPa"
                "dew_point_200hPa"
                "dew_point_150hPa"
                "dew_point_100hPa"
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
                "vertical_velocity_1000hPa"
                "vertical_velocity_975hPa"
                "vertical_velocity_950hPa"
                "vertical_velocity_925hPa"
                "vertical_velocity_900hPa"
                "vertical_velocity_850hPa"
                "vertical_velocity_800hPa"
                "vertical_velocity_700hPa"
                "vertical_velocity_600hPa"
                "vertical_velocity_500hPa"
                "vertical_velocity_400hPa"
                "vertical_velocity_300hPa"
                "vertical_velocity_250hPa"
                "vertical_velocity_200hPa"
                "vertical_velocity_150hPa"
                "vertical_velocity_100hPa"
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

6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
      
 
 **Returns**
 
 The JMA Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
