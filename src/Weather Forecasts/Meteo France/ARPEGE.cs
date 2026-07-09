/*
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;

namespace OpenMeteoApiNet.MeteoFrance.ARPEGE
{
    public class arpegeParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? relative_humidity_2m { get; set; }
        public double?[]? dew_point_2m { get; set; }
        public double?[]? apparent_temperature { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? rain { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? weather_code { get; set; }
        public double?[]? pressure_msl { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? cloud_cover { get; set; }
        public double?[]? cloud_cover_low { get; set; }
        public double?[]? cloud_cover_mid { get; set; }
        public double?[]? cloud_cover_high { get; set; }
        public double?[]? et0_fao_evapotranspiration { get; set; }
        public double?[]? vapour_pressure_deficit { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_20m { get; set; }
        public double?[]? wind_speed_50m { get; set; }
        public double?[]? wind_speed_100m { get; set; }
        public double?[]? wind_speed_150m { get; set; }
        public double?[]? wind_speed_200m { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_20m { get; set; }
        public double?[]? wind_direction_50m { get; set; }
        public double?[]? wind_direction_100m { get; set; }
        public double?[]? wind_direction_150m { get; set; }
        public double?[]? wind_direction_200m { get; set; }
        public double?[]? wind_gusts_10m { get; set; }
        public double?[]? temperature_20m { get; set; }
        public double?[]? temperature_50m { get; set; }
        public double?[]? temperature_100m { get; set; }
        public double?[]? temperature_150m { get; set; }
        public double?[]? temperature_200m { get; set; }
        public double?[]? temperature_1000hPa { get; set; }
        public double?[]? temperature_950hPa { get; set; }
        public double?[]? temperature_925hPa { get; set; }
        public double?[]? temperature_900hPa { get; set; }
        public double?[]? temperature_850hPa { get; set; }
        public double?[]? temperature_800hPa { get; set; }
        public double?[]? temperature_750hPa { get; set; }
        public double?[]? temperature_700hPa { get; set; }
        public double?[]? temperature_650hPa { get; set; }
        public double?[]? temperature_600hPa { get; set; }
        public double?[]? temperature_550hPa { get; set; }
        public double?[]? temperature_500hPa { get; set; }
        public double?[]? temperature_450hPa { get; set; }
        public double?[]? temperature_400hPa { get; set; }
        public double?[]? temperature_350hPa { get; set; }
        public double?[]? temperature_300hPa { get; set; }
        public double?[]? temperature_275hPa { get; set; }
        public double?[]? temperature_250hPa { get; set; }
        public double?[]? temperature_225hPa { get; set; }
        public double?[]? temperature_200hPa { get; set; }
        public double?[]? temperature_175hPa { get; set; }
        public double?[]? temperature_150hPa { get; set; }
        public double?[]? temperature_125hPa { get; set; }
        public double?[]? temperature_100hPa { get; set; }
        public double?[]? temperature_70hPa { get; set; }
        public double?[]? temperature_50hPa { get; set; }
        public double?[]? temperature_30hPa { get; set; }
        public double?[]? temperature_20hPa { get; set; }
        public double?[]? temperature_10hPa { get; set; }
        public double?[]? dew_point_1000hPa { get; set; }
        public double?[]? dew_point_950hPa { get; set; }
        public double?[]? dew_point_925hPa { get; set; }
        public double?[]? dew_point_900hPa { get; set; }
        public double?[]? dew_point_850hPa { get; set; }
        public double?[]? dew_point_800hPa { get; set; }
        public double?[]? dew_point_700hPa { get; set; }
        public double?[]? dew_point_750hPa { get; set; }
        public double?[]? dew_point_650hPa { get; set; }
        public double?[]? dew_point_600hPa { get; set; }
        public double?[]? dew_point_550hPa { get; set; }
        public double?[]? dew_point_500hPa { get; set; }
        public double?[]? dew_point_450hPa { get; set; }
        public double?[]? dew_point_400hPa { get; set; }
        public double?[]? dew_point_350hPa { get; set; }
        public double?[]? dew_point_300hPa { get; set; }
        public double?[]? dew_point_275hPa { get; set; }
        public double?[]? dew_point_250hPa { get; set; }
        public double?[]? dew_point_225hPa { get; set; }
        public double?[]? dew_point_200hPa { get; set; }
        public double?[]? dew_point_175hPa { get; set; }
        public double?[]? dew_point_150hPa { get; set; }
        public double?[]? dew_point_125hPa { get; set; }
        public double?[]? dew_point_100hPa { get; set; }
        public double?[]? dew_point_70hPa { get; set; }
        public double?[]? dew_point_50hPa { get; set; }
        public double?[]? dew_point_30hPa { get; set; }
        public double?[]? dew_point_20hPa { get; set; }
        public double?[]? dew_point_10hPa { get; set; }
        public double?[]? relative_humidity_1000hPa { get; set; }
        public double?[]? relative_humidity_950hPa { get; set; }
        public double?[]? relative_humidity_925hPa { get; set; }
        public double?[]? relative_humidity_900hPa { get; set; }
        public double?[]? relative_humidity_850hPa { get; set; }
        public double?[]? relative_humidity_800hPa { get; set; }
        public double?[]? relative_humidity_750hPa { get; set; }
        public double?[]? relative_humidity_700hPa { get; set; }
        public double?[]? relative_humidity_650hPa { get; set; }
        public double?[]? relative_humidity_600hPa { get; set; }
        public double?[]? relative_humidity_550hPa { get; set; }
        public double?[]? relative_humidity_500hPa { get; set; }
        public double?[]? relative_humidity_450hPa { get; set; }
        public double?[]? relative_humidity_400hPa { get; set; }
        public double?[]? relative_humidity_350hPa { get; set; }
        public double?[]? relative_humidity_300hPa { get; set; }
        public double?[]? relative_humidity_275hPa { get; set; }
        public double?[]? relative_humidity_250hPa { get; set; }
        public double?[]? relative_humidity_225hPa { get; set; }
        public double?[]? relative_humidity_200hPa { get; set; }
        public double?[]? relative_humidity_175hPa { get; set; }
        public double?[]? relative_humidity_150hPa { get; set; }
        public double?[]? relative_humidity_125hPa { get; set; }
        public double?[]? relative_humidity_100hPa { get; set; }
        public double?[]? relative_humidity_70hPa { get; set; }
        public double?[]? relative_humidity_50hPa { get; set; }
        public double?[]? relative_humidity_30hPa { get; set; }
        public double?[]? relative_humidity_20hPa { get; set; }
        public double?[]? relative_humidity_10hPa { get; set; }
        public double?[]? cloud_cover_1000hPa { get; set; }
        public double?[]? cloud_cover_950hPa { get; set; }
        public double?[]? cloud_cover_925hPa { get; set; }
        public double?[]? cloud_cover_900hPa { get; set; }
        public double?[]? cloud_cover_850hPa { get; set; }
        public double?[]? cloud_cover_800hPa { get; set; }
        public double?[]? cloud_cover_750hPa { get; set; }
        public double?[]? cloud_cover_700hPa { get; set; }
        public double?[]? cloud_cover_650hPa { get; set; }
        public double?[]? cloud_cover_600hPa { get; set; }
        public double?[]? cloud_cover_550hPa { get; set; }
        public double?[]? cloud_cover_500hPa { get; set; }
        public double?[]? cloud_cover_450hPa { get; set; }
        public double?[]? cloud_cover_400hPa { get; set; }
        public double?[]? cloud_cover_350hPa { get; set; }
        public double?[]? cloud_cover_300hPa { get; set; }
        public double?[]? cloud_cover_275hPa { get; set; }
        public double?[]? cloud_cover_250hPa { get; set; }
        public double?[]? cloud_cover_225hPa { get; set; }
        public double?[]? cloud_cover_200hPa { get; set; }
        public double?[]? cloud_cover_175hPa { get; set; }
        public double?[]? cloud_cover_150hPa { get; set; }
        public double?[]? cloud_cover_125hPa { get; set; }
        public double?[]? cloud_cover_100hPa { get; set; }
        public double?[]? cloud_cover_70hPa { get; set; }
        public double?[]? cloud_cover_50hPa { get; set; }
        public double?[]? cloud_cover_30hPa { get; set; }
        public double?[]? cloud_cover_20hPa { get; set; }
        public double?[]? cloud_cover_10hPa { get; set; }
        public double?[]? wind_speed_1000hPa { get; set; }
        public double?[]? wind_speed_950hPa { get; set; }
        public double?[]? wind_speed_925hPa { get; set; }
        public double?[]? wind_speed_900hPa { get; set; }
        public double?[]? wind_speed_850hPa { get; set; }
        public double?[]? wind_speed_800hPa { get; set; }
        public double?[]? wind_speed_750hPa { get; set; }
        public double?[]? wind_speed_700hPa { get; set; }
        public double?[]? wind_speed_650hPa { get; set; }
        public double?[]? wind_speed_600hPa { get; set; }
        public double?[]? wind_speed_550hPa { get; set; }
        public double?[]? wind_speed_500hPa { get; set; }
        public double?[]? wind_speed_450hPa { get; set; }
        public double?[]? wind_speed_400hPa { get; set; }
        public double?[]? wind_speed_350hPa { get; set; }
        public double?[]? wind_speed_300hPa { get; set; }
        public double?[]? wind_speed_275hPa { get; set; }
        public double?[]? wind_speed_250hPa { get; set; }
        public double?[]? wind_speed_225hPa { get; set; }
        public double?[]? wind_speed_200hPa { get; set; }
        public double?[]? wind_speed_175hPa { get; set; }
        public double?[]? wind_speed_150hPa { get; set; }
        public double?[]? wind_speed_125hPa { get; set; }
        public double?[]? wind_speed_100hPa { get; set; }
        public double?[]? wind_speed_70hPa { get; set; }
        public double?[]? wind_speed_50hPa { get; set; }
        public double?[]? wind_speed_30hPa { get; set; }
        public double?[]? wind_speed_20hPa { get; set; }
        public double?[]? wind_speed_10hPa { get; set; }
        public double?[]? wind_direction_1000hPa { get; set; }
        public double?[]? wind_direction_950hPa { get; set; }
        public double?[]? wind_direction_925hPa { get; set; }
        public double?[]? wind_direction_900hPa { get; set; }
        public double?[]? wind_direction_850hPa { get; set; }
        public double?[]? wind_direction_800hPa { get; set; }
        public double?[]? wind_direction_750hPa { get; set; }
        public double?[]? wind_direction_700hPa { get; set; }
        public double?[]? wind_direction_650hPa { get; set; }
        public double?[]? wind_direction_600hPa { get; set; }
        public double?[]? wind_direction_550hPa { get; set; }
        public double?[]? wind_direction_500hPa { get; set; }
        public double?[]? wind_direction_450hPa { get; set; }
        public double?[]? wind_direction_400hPa { get; set; }
        public double?[]? wind_direction_350hPa { get; set; }
        public double?[]? wind_direction_300hPa { get; set; }
        public double?[]? wind_direction_275hPa { get; set; }
        public double?[]? wind_direction_250hPa { get; set; }
        public double?[]? wind_direction_225hPa { get; set; }
        public double?[]? wind_direction_200hPa { get; set; }
        public double?[]? wind_direction_175hPa { get; set; }
        public double?[]? wind_direction_150hPa { get; set; }
        public double?[]? wind_direction_125hPa { get; set; }
        public double?[]? wind_direction_100hPa { get; set; }
        public double?[]? wind_direction_70hPa { get; set; }
        public double?[]? wind_direction_50hPa { get; set; }
        public double?[]? wind_direction_30hPa { get; set; }
        public double?[]? wind_direction_20hPa { get; set; }
        public double?[]? wind_direction_10hPa { get; set; }
        public double?[]? geopotential_height_1000hPa { get; set; }
        public double?[]? geopotential_height_950hPa { get; set; }
        public double?[]? geopotential_height_925hPa { get; set; }
        public double?[]? geopotential_height_900hPa { get; set; }
        public double?[]? geopotential_height_850hPa { get; set; }
        public double?[]? geopotential_height_800hPa { get; set; }
        public double?[]? geopotential_height_750hPa { get; set; }
        public double?[]? geopotential_height_700hPa { get; set; }
        public double?[]? geopotential_height_650hPa { get; set; }
        public double?[]? geopotential_height_600hPa { get; set; }
        public double?[]? geopotential_height_550hPa { get; set; }
        public double?[]? geopotential_height_500hPa { get; set; }
        public double?[]? geopotential_height_450hPa { get; set; }
        public double?[]? geopotential_height_400hPa { get; set; }
        public double?[]? geopotential_height_350hPa { get; set; }
        public double?[]? geopotential_height_300hPa { get; set; }
        public double?[]? geopotential_height_275hPa { get; set; }
        public double?[]? geopotential_height_250hPa { get; set; }
        public double?[]? geopotential_height_225hPa { get; set; }
        public double?[]? geopotential_height_200hPa { get; set; }
        public double?[]? geopotential_height_175hPa { get; set; }
        public double?[]? geopotential_height_150hPa { get; set; }
        public double?[]? geopotential_height_125hPa { get; set; }
        public double?[]? geopotential_height_100hPa { get; set; }
        public double?[]? geopotential_height_70hPa { get; set; }
        public double?[]? geopotential_height_50hPa { get; set; }
        public double?[]? geopotential_height_30hPa { get; set; }
        public double?[]? geopotential_height_20hPa { get; set; }
        public double?[]? geopotential_height_10hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }

    }
    public static class arpegeHourlyForecastApi
    {
        public static async Task<arpegeParams?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 4 ,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
        /*
         * This function is the client that retrieves and returns a Meteo France/ARPEGE point forecast for a specified point of lat/lon.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=4. The number of days to forecast, maximum of 4 days. 
         * 
         * 2) temperatureUnit (string) - Default="fahrenheit". The units for the temperature data.
         * 
         *      Valid Units
         *      -----------
         *      
         *      1) fahrenheit [Fahrenheit]
         *      2) celsius [Celsius]
         *      
         * 3) windSpeedUnit (string) - Default="mph". The units for the wind speed data. 
         * 
         *      Valid Units
         *      -----------
         *      1) mph (Miles Per Hour)
         *      2) ms (Meters Per Second)
         *      3) kmh (Kilometers Per Hour)
         *      4) kn (Knots)
         *      
         * 4) precipitationUnit (string) - Default="inch". The units for the precipitation data.
         * 
         *      Valid Units
         *      -----------
         *      1) inch [Inches]
         *      2) mm [Millimeters]
         *      
         * 5) variables (string[]) - Optional list of current variables to request. Default is all variables.
         * 
         *      Variables
         *      ---------
*               "temperature_2m"
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
         *      
         * 
         * Returns
         * -------
         * 
         * The ARPEGE Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {
            if (days > 4)
            {
                Console.WriteLine("The maximum number of days that can be retrieved is 4. Setting 'days' to 4.");
                days = 4;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m" ,
                                    "relative_humidity_2m" ,
                                    "dew_point_2m" ,
                                    "apparent_temperature" ,
                                    "precipitation" ,
                                    "rain" ,
                                    "snowfall" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "cloud_cover_low" ,
                                    "cloud_cover_mid" ,
                                    "cloud_cover_high" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_20m" ,
                                    "wind_speed_50m" ,
                                    "wind_speed_100m" ,
                                    "wind_speed_150m" ,
                                    "wind_speed_200m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_20m" ,
                                    "wind_direction_50m" ,
                                    "wind_direction_100m" ,
                                    "wind_direction_150m" ,
                                    "wind_direction_200m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_20m" ,
                                    "temperature_50m" ,
                                    "temperature_100m" ,
                                    "temperature_150m" ,
                                    "temperature_200m" ,
                                    "temperature_1000hPa" ,
                                    "temperature_950hPa" ,
                                    "temperature_925hPa" ,
                                    "temperature_900hPa" ,
                                    "temperature_850hPa" ,
                                    "temperature_800hPa" ,
                                    "temperature_750hPa" ,
                                    "temperature_700hPa" ,
                                    "temperature_650hPa" ,
                                    "temperature_600hPa" ,
                                    "temperature_550hPa" ,
                                    "temperature_500hPa" ,
                                    "temperature_450hPa" ,
                                    "temperature_400hPa" ,
                                    "temperature_350hPa" ,
                                    "temperature_300hPa" ,
                                    "temperature_275hPa" ,
                                    "temperature_250hPa" ,
                                    "temperature_225hPa" ,
                                    "temperature_200hPa" ,
                                    "temperature_175hPa" ,
                                    "temperature_150hPa" ,
                                    "temperature_125hPa" ,
                                    "temperature_100hPa" ,
                                    "temperature_70hPa" ,
                                    "temperature_50hPa" ,
                                    "temperature_30hPa" ,
                                    "temperature_20hPa" ,
                                    "temperature_10hPa" ,
                                    "dew_point_1000hPa" ,
                                    "dew_point_950hPa" ,
                                    "dew_point_925hPa" ,
                                    "dew_point_900hPa" ,
                                    "dew_point_850hPa" ,
                                    "dew_point_800hPa" ,
                                    "dew_point_700hPa" ,
                                    "dew_point_750hPa" ,
                                    "dew_point_650hPa" ,
                                    "dew_point_600hPa" ,
                                    "dew_point_550hPa" ,
                                    "dew_point_500hPa" ,
                                    "dew_point_450hPa" ,
                                    "dew_point_400hPa" ,
                                    "dew_point_350hPa" ,
                                    "dew_point_300hPa" ,
                                    "dew_point_275hPa" ,
                                    "dew_point_250hPa" ,
                                    "dew_point_225hPa" ,
                                    "dew_point_200hPa" ,
                                    "dew_point_175hPa" ,
                                    "dew_point_150hPa" ,
                                    "dew_point_125hPa" ,
                                    "dew_point_100hPa" ,
                                    "dew_point_70hPa" ,
                                    "dew_point_50hPa" ,
                                    "dew_point_30hPa" ,
                                    "dew_point_20hPa" ,
                                    "dew_point_10hPa" ,
                                    "relative_humidity_1000hPa" ,
                                    "relative_humidity_950hPa" ,
                                    "relative_humidity_925hPa" ,
                                    "relative_humidity_900hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_800hPa" ,
                                    "relative_humidity_750hPa" ,
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_650hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_550hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_450hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_350hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_275hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_225hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_175hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_125hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_70hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "relative_humidity_30hPa" ,
                                    "relative_humidity_20hPa" ,
                                    "relative_humidity_10hPa" ,
                                    "cloud_cover_1000hPa" ,
                                    "cloud_cover_950hPa" ,
                                    "cloud_cover_925hPa" ,
                                    "cloud_cover_900hPa" ,
                                    "cloud_cover_850hPa" ,
                                    "cloud_cover_800hPa" ,
                                    "cloud_cover_750hPa" ,
                                    "cloud_cover_700hPa" ,
                                    "cloud_cover_650hPa" ,
                                    "cloud_cover_600hPa" ,
                                    "cloud_cover_550hPa" ,
                                    "cloud_cover_500hPa" ,
                                    "cloud_cover_450hPa" ,
                                    "cloud_cover_400hPa" ,
                                    "cloud_cover_350hPa" ,
                                    "cloud_cover_300hPa" ,
                                    "cloud_cover_275hPa" ,
                                    "cloud_cover_250hPa" ,
                                    "cloud_cover_225hPa" ,
                                    "cloud_cover_200hPa" ,
                                    "cloud_cover_175hPa" ,
                                    "cloud_cover_150hPa" ,
                                    "cloud_cover_125hPa" ,
                                    "cloud_cover_100hPa" ,
                                    "cloud_cover_70hPa" ,
                                    "cloud_cover_50hPa" ,
                                    "cloud_cover_30hPa" ,
                                    "cloud_cover_20hPa" ,
                                    "cloud_cover_10hPa" ,
                                    "wind_speed_1000hPa" ,
                                    "wind_speed_950hPa" ,
                                    "wind_speed_925hPa" ,
                                    "wind_speed_900hPa" ,
                                    "wind_speed_850hPa" ,
                                    "wind_speed_800hPa" ,
                                    "wind_speed_750hPa" ,
                                    "wind_speed_700hPa" ,
                                    "wind_speed_650hPa" ,
                                    "wind_speed_600hPa" ,
                                    "wind_speed_550hPa" ,
                                    "wind_speed_500hPa" ,
                                    "wind_speed_450hPa" ,
                                    "wind_speed_400hPa" ,
                                    "wind_speed_350hPa" ,
                                    "wind_speed_300hPa" ,
                                    "wind_speed_275hPa" ,
                                    "wind_speed_250hPa" ,
                                    "wind_speed_225hPa" ,
                                    "wind_speed_200hPa" ,
                                    "wind_speed_175hPa" ,
                                    "wind_speed_150hPa" ,
                                    "wind_speed_125hPa" ,
                                    "wind_speed_100hPa" ,
                                    "wind_speed_70hPa" ,
                                    "wind_speed_50hPa" ,
                                    "wind_speed_30hPa" ,
                                    "wind_speed_20hPa" ,
                                    "wind_speed_10hPa" ,
                                    "wind_direction_1000hPa" ,
                                    "wind_direction_950hPa" ,
                                    "wind_direction_925hPa" ,
                                    "wind_direction_900hPa" ,
                                    "wind_direction_850hPa" ,
                                    "wind_direction_800hPa" ,
                                    "wind_direction_750hPa" ,
                                    "wind_direction_700hPa" ,
                                    "wind_direction_650hPa" ,
                                    "wind_direction_600hPa" ,
                                    "wind_direction_550hPa" ,
                                    "wind_direction_500hPa" ,
                                    "wind_direction_450hPa" ,
                                    "wind_direction_400hPa" ,
                                    "wind_direction_350hPa" ,
                                    "wind_direction_300hPa" ,
                                    "wind_direction_275hPa" ,
                                    "wind_direction_250hPa" ,
                                    "wind_direction_225hPa" ,
                                    "wind_direction_200hPa" ,
                                    "wind_direction_175hPa" ,
                                    "wind_direction_150hPa" ,
                                    "wind_direction_125hPa" ,
                                    "wind_direction_100hPa" ,
                                    "wind_direction_70hPa" ,
                                    "wind_direction_50hPa" ,
                                    "wind_direction_30hPa" ,
                                    "wind_direction_20hPa" ,
                                    "wind_direction_10hPa" ,
                                    "geopotential_height_1000hPa" ,
                                    "geopotential_height_950hPa" ,
                                    "geopotential_height_925hPa" ,
                                    "geopotential_height_900hPa" ,
                                    "geopotential_height_850hPa" ,
                                    "geopotential_height_800hPa" ,
                                    "geopotential_height_750hPa" ,
                                    "geopotential_height_700hPa" ,
                                    "geopotential_height_650hPa" ,
                                    "geopotential_height_600hPa" ,
                                    "geopotential_height_550hPa" ,
                                    "geopotential_height_500hPa" ,
                                    "geopotential_height_450hPa" ,
                                    "geopotential_height_400hPa" ,
                                    "geopotential_height_350hPa" ,
                                    "geopotential_height_300hPa" ,
                                    "geopotential_height_275hPa" ,
                                    "geopotential_height_250hPa" ,
                                    "geopotential_height_225hPa" ,
                                    "geopotential_height_200hPa" ,
                                    "geopotential_height_175hPa" ,
                                    "geopotential_height_150hPa" ,
                                    "geopotential_height_125hPa" ,
                                    "geopotential_height_100hPa" ,
                                    "geopotential_height_70hPa" ,
                                    "geopotential_height_50hPa" ,
                                    "geopotential_height_30hPa" ,
                                    "geopotential_height_20hPa" ,
                                    "geopotential_height_10hPa" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=best_match&forecast_days={days}" +
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

                // Deserialize the "hourly" property into our arpegeParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<arpegeParams>(hourlyWeatherElement.GetRawText());
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
                    Console.WriteLine($"ARPEGE Data Not Available At This Time");
                    return null;
                }
            }

        }
    }
}


