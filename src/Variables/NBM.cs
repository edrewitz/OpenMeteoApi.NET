
/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */


namespace OpenMeteoApiNet.Variables.NBM
{
    public class nbmParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? cape { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? visibility { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_80m { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_80m { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }
    }
}
