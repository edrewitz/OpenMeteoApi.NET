/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

namespace OpenMeteoApiNet.Variables.CurrentData.CurrentWeather
{
    public class currentWeather
    {
        public string? time { get; set; }
        public double? temperature_2m { get; set; }
        public double? relative_humidity_2m { get; set; }
        public double? apparent_temperature { get; set; }
        public double? precipitation { get; set; }
        public double? snowfall { get; set; }
        public double? cloud_cover { get; set; }
        public double? pressure_msl { get; set; }
        public double? surface_pressure { get; set; }
        public double? wind_speed_10m { get; set; }
        public double? wind_direction_10m { get; set; }
        public double? wind_gusts_10m { get; set; }
        public double? weather_code { get; set; }
        public double? rain { get; set; }
        public double? showers { get; set; }
        public DateTime? localTime { get; set; }
    }
}
