# Current Weather

## `class currentWeatherApi`

### `GetPointData()`

This function is the client that retrieves and returns the latest weather data.

Required Arguments:

1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.

Optional Arguments:
 
 1) temperatureUnit (string) - Default="fahrenheit". The units for the temperature data.
 
        Valid Units
        -----------
        
        1) fahrenheit [Fahrenheit]
        2) celsius [Celsius]
      
 2) windSpeedUnit (string) - Default="mph". The units for the wind speed data. 
 
        Valid Units
        -----------
        1) mph (Miles Per Hour)
        2) ms (Meters Per Second)
        3) kmh (Kilometers Per Hour)
        4) kn (Knots)
      
 3) precipitationUnit (string) - Default="inch". The units for the precipitation data.
 
        Valid Units
        -----------
        1) inch [Inches]
        2) mm [Millimeters]
      
 4) variables (string[]) - Optional list of current variables to request. Default is all variables.
 
         Variables
         ---------
         
         "temperature_2m"
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
 
 Returns
 -------
 
 The current weather data in the form of a JSON object. 
