# European Centre for Medium-Range Weather Forecasts (ECMWF)

[***`class ifsHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/ecmwf.md#class-ifshourlyforecastapi)

[***`class aifsHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/ecmwf.md#class-aifshourlyforecastapi)

[***`class ifsHRESHourlyForecastApi`***](https://github.com/edrewitz/OpenMeteoApi.NET/blob/master/Documentation/ecmwf.md#class-ifshreshourlyforecastapi)

## `class ifsHourlyForecastApi`

***public static async Task<ifsParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 14,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns ECMWF IFS Forecast from the Open-Meteo API.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=14. The number of days to retrieve forecast data for, starting from the current day. Maximum is 14 days.
 
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
                "showers"
                "snowfall"
                "runoff"
                "visibility"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "cloud_cover_low"
                "cloud_cover_mid"
                "cloud_cover_high"
                "sunshine_duration"
                "potential_evapotranspiration"
                "et0_fao_evapotranspiration"
                "wind_speed_10m"
                "wind_speed_100m"
                "wind_speed_200m"
                "wind_direction_10m"
                "wind_direction_100m"
                "wind_direction_200m"
                "wind_gusts_10m"
                "cape"
                "convective_inhibition"
                "total_column_integrated_water_vapour"
                "vapour_pressure_deficit"
                "surface_temperature"
                "soil_temperature_0_to_7cm"
                "soil_temperature_7_to_28cm"
                "soil_temperature_28_to_100cm"
                "soil_temperature_100_to_255cm"
                "soil_moisture_0_to_7cm"
                "soil_moisture_28_to_100cm"
                "soil_moisture_7_to_28cm"
                "soil_moisture_100_to_255cm"
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
                "geopotential_heighty_925hPa"
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
 
 The ECMWF IFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


 ## `class aifsHourlyForecastApi`

 ***public static async Task<aifsParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 14,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

This function is the client that retrieves and returns ECMWF AIFS Forecast from the Open-Meteo API.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=14. The number of days to retrieve forecast data for, starting from the current day. Maximum is 14 days.
 
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
                "showers"
                "snowfall"
                "runoff"
                "visibility"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "cloud_cover_low"
                "cloud_cover_mid"
                "cloud_cover_high"
                "sunshine_duration"
                "potential_evapotranspiration"
                "et0_fao_evapotranspiration"
                "wind_speed_10m"
                "wind_speed_100m"
                "wind_speed_200m"
                "wind_direction_10m"
                "wind_direction_100m"
                "wind_direction_200m"
                "wind_gusts_10m"
                "cape"
                "convective_inhibition"
                "total_column_integrated_water_vapour"
                "vapour_pressure_deficit"
                "surface_temperature"
                "soil_temperature_0_to_7cm"
                "soil_temperature_7_to_28cm"
                "soil_temperature_28_to_100cm"
                "soil_temperature_100_to_255cm"
                "soil_moisture_0_to_7cm"
                "soil_moisture_28_to_100cm"
                "soil_moisture_7_to_28cm"
                "soil_moisture_100_to_255cm"
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
                "geopotential_heighty_925hPa"
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
 
 The ECMWF AIFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


 ## `class ifsHRESHourlyForecastApi`

***public static async Task<ifsHRESParams?> GetPointForecast(string latitude,
                                                 string longitude,
                                                 int days = 14,
                                                 string temperatureUnit = "fahrenheit",
                                                 string windSpeedUnit = "mph",
                                                 string precipitationUnit = "inch",
                                                 string[]? variables = null,
                                                 string? proxy = null)***

 This function is the client that retrieves and returns ECMWF IFS Medium-range Control forecast from the Open-Meteo API.
 
 Required Arguments:
 
 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
 
 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
 
 Optional Arguments:
 
 1) days (int) - Default=14. The number of days to retrieve forecast data for, starting from the current day. Maximum is 14 days.
 
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
                "showers"
                "snowfall"
                "runoff"
                "visibility"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "cloud_cover_low"
                "cloud_cover_mid"
                "cloud_cover_high"
                "sunshine_duration"
                "potential_evapotranspiration"
                "et0_fao_evapotranspiration"
                "wind_speed_10m"
                "wind_speed_100m"
                "wind_speed_200m"
                "wind_direction_10m"
                "wind_direction_100m"
                "wind_direction_200m"
                "wind_gusts_10m"
                "cape"
                "convective_inhibition"
                "total_column_integrated_water_vapour"
                "vapour_pressure_deficit"
                "surface_temperature"
                "soil_temperature_0_to_7cm"
                "soil_temperature_7_to_28cm"
                "soil_temperature_28_to_100cm"
                "soil_temperature_100_to_255cm"
                "soil_moisture_0_to_7cm"
                "soil_moisture_28_to_100cm"
                "soil_moisture_7_to_28cm"
                "soil_moisture_100_to_255cm"
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
                "geopotential_heighty_925hPa"
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
 
 The ECMWF IFS HRES Forecast for the specified latitude and longitude as a data object, or null if an error occurs.


