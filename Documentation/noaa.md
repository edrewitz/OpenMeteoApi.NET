# National Oceanic and Atmospheric Administration (NOAA)

[***`class gfsHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/noaa.md#class-gfshourlyforecastapi)

[***`class aigfsHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/noaa.md#class-aigfshourlyforecastapi)

[***`class hgefsHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/noaa.md#class-hgefshourlyforecastapi)

[***`class nbmHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/noaa.md#class-nbmhourlyforecastapi)

## `class gfsHourlyForecastApi`

***public static async Task<gfsParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 7 ,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns a NOAA/NCEP/GFS point forecast for a specified point of lat/lon.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=7. The number of days to retrieve in the forecast, up to a maximum of 16 days.
 
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
                "cape"
                "precipitation"
                "rain"
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
                "weather_code"
                "showers"
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
                "temperature_30hPa"
                "temperature_20hPa"
                "temperature_10hPa"
                "dew_point_1000hPa"
                "dew_point_925hPa"
                "dew_point_850hPa"
                "dew_point_700hPa"
                "dew_point_600hPa"
                "dew_point_500hPa"
                "dew_point_400hPa"
                "dew_point_300hPa"
                "dew_point_250hPa"
                "dew_point_200hPa"
                "dew_point_150hPa"
                "dew_point_100hPa"
                "dew_point_50hPa"
                "dew_point_30hPa"
                "dew_point_20hPa"
                "dew_point_10hPa"
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
                "relative_humidity_30hPa"
                "relative_humidity_20hPa"
                "relative_humidity_10hPa"
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
                "wind_speed_30hPa"
                "wind_speed_20hPa"
                "wind_speed_10hPa"
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
                "wind_direction_30hPa"
                "wind_direction_20hPa"
                "wind_direction_10hPa"
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
                "geopotential_height_30hPa"
                "geopotential_height_20hPa"
                "geopotential_height_10hPa"
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
                "cloud_cover_30hPa"
                "cloud_cover_20hPa"
                "cloud_cover_10hPa"
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
                "vertical_velocity_30hPa"
                "vertical_velocity_20hPa"
                "vertical_velocity_10hPa" 

6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).
      
 
 **Returns**

 The GFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


 ## `class aigfsHourlyForecastApi`

 ***public static async Task<aigfsParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 7,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns a NOAA/NCEP/AIGFS point forecast for a specified point of lat/lon.
 
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
                "apparent_temperature" 
                "cape"
                "precipitation" 
                "rain"
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
                "dew_point_1000hPa" 
                "dew_point_925hPa" 
                "dew_point_850hPa" 
                "dew_point_700hPa" 
                "dew_point_600hPa" 
                "dew_point_500hPa" 
                "dew_point_400hPa" 
                "dew_point_300hPa" 
                "dew_point_250hPa" 
                "dew_point_200hPa" 
                "dew_point_150hPa" 
                "dew_point_100hPa" 
                "dew_point_50hPa" 
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
      
 
 **Returns**

 The AIGFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


## `class hgefsHourlyForecastApi`

***public static async Task<hgefsParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 7,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns a NOAA/NCEP/HGEFS ensemble mean point forecast for a specified point of lat/lon.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=7. The number of days to forecast, up to a maximum of 10 days.
 
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
                "apparent_temperature" 
                "cape"
                "precipitation" 
                "rain"
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
                "dew_point_1000hPa" 
                "dew_point_925hPa" 
                "dew_point_850hPa" 
                "dew_point_700hPa" 
                "dew_point_600hPa" 
                "dew_point_500hPa" 
                "dew_point_400hPa" 
                "dew_point_300hPa" 
                "dew_point_250hPa" 
                "dew_point_200hPa" 
                "dew_point_150hPa" 
                "dew_point_100hPa" 
                "dew_point_50hPa" 
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
      
 
 **Returns**

 The HGEFS Ensemble Mean Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


## `class nbmHourlyForecastApi`

***public static async Task<nbmParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 7,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns a NOAA/NCEP/NBM point forecast for a specified point of lat/lon.
 
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
                "cape" 
                "precipitation" 
                "snowfall" 
                "surface_pressure" 
                "visibility" 
                "wind_speed_10m" 
                "wind_speed_80m" 
                "wind_direction_10m" 
                "wind_direction_80m" 

6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).
      
 
**Returns**

 The NBM Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
