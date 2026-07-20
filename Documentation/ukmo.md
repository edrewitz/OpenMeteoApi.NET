# UK Met Office (UKMO)

## ***`class ukmoGlobalENSHourlyForecastApi`***

```Csharp
namespace OpenMeteoApiNet.EnsembleForecasts.UKMO.UKMO_Global_ENS
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

 This function is the client that retrieves and returns the hourly UKMO Global Ensemble forecast from the Open-Meteo API.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=7. The number of forecast days to retrieve, starting from the current day. Maximum is 36 days.
  
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
                "snowfall"
                "rain"
                "precipitation"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "visibility"
                "et0_fao_evapotranspiration"
                "vapour_pressure_deficit"
                "wind_speed_10m"
                "wind_direction_10m"
                "wind_gusts_10m"
                "surface_temperature"


6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
      
 
 **Returns**
 
 The UKMO Global ENS point forecast for a given latitude and longitude. 
 
          variable naming convention
          ---------------------------
          
          Control Run (Example 2-Meter Temperature): data.temperature_2m
          Ensemble Member 1 (Example 2-Meter Temperature): data.temperature_2m_member01 -> data.temperature_2m_member17 (18 total members [17 members + 1 control])
