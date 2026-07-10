/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Utils.BuildDirectory;
using OpenMeteoApiNet.Utils.DataAccess;
using OpenMeteoApiNet.Utils.DataArchive;
using System.Text.Json;

namespace OpenMeteoApiNet.DeterministicForecasts.MeteoFrance.ARPEGE
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
        private static DataFrame ToDataFrame(arpegeParams data)
        {
            /*
             * Converts the data object of type iconParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the iconParams object.
             * 
             */

            var df = new DataFrame();

            // 1. Add the time column (Strings)
            if (data.time != null)
            {
                df.Columns.Add(new StringDataFrameColumn("time", data.time));
            }

            // 2. Add the nullable double columns (maps cleanly to PrimitiveDataFrameColumn)
            if (data.temperature_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m", data.temperature_2m));

            if (data.relative_humidity_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m", data.relative_humidity_2m));

            if (data.dew_point_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m", data.dew_point_2m));

            if (data.apparent_temperature != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature", data.apparent_temperature));

            if (data.precipitation != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation", data.precipitation));

            if (data.rain != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain", data.rain));

            if (data.snowfall != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall", data.snowfall));

            if (data.weather_code != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code", data.weather_code));

            if (data.pressure_msl != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl", data.pressure_msl));

            if (data.surface_pressure != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure", data.surface_pressure));

            if (data.cloud_cover != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover", data.cloud_cover));

            if (data.cloud_cover_low != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low", data.cloud_cover_low));

            if (data.cloud_cover_mid != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid", data.cloud_cover_mid));

            if (data.cloud_cover_high != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high", data.cloud_cover_high));

            if (data.et0_fao_evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration", data.et0_fao_evapotranspiration));

            if (data.vapour_pressure_deficit != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit", data.vapour_pressure_deficit));

            if (data.wind_speed_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m", data.wind_speed_10m));

            if (data.wind_speed_20m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_20m", data.wind_speed_20m));

            if (data.wind_speed_50m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50m", data.wind_speed_50m));

            if (data.wind_speed_100m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100m", data.wind_speed_100m));

            if (data.wind_speed_150m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150m", data.wind_speed_150m));

            if (data.wind_speed_200m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200m", data.wind_speed_200m));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_20m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_20m", data.wind_direction_20m));

            if (data.wind_direction_50m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50m", data.wind_direction_50m));

            if (data.wind_direction_100m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100m", data.wind_direction_100m));

            if (data.wind_direction_150m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150m", data.wind_direction_150m));

            if (data.wind_direction_200m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200m", data.wind_direction_200m));

            if (data.temperature_20m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_20m", data.temperature_20m));

            if (data.temperature_50m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50m", data.temperature_50m));

            if (data.temperature_100m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100m", data.temperature_100m));

            if (data.temperature_150m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150m", data.temperature_150m));

            if (data.temperature_200m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200m", data.temperature_200m));

            if (data.wind_gusts_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m", data.wind_gusts_10m));

            if (data.temperature_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa", data.temperature_1000hPa));

            if (data.temperature_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_950hPa", data.temperature_950hPa));

            if (data.temperature_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa", data.temperature_925hPa));

            if (data.temperature_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_900hPa", data.temperature_900hPa));

            if (data.temperature_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa", data.temperature_850hPa));

            if (data.temperature_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_800hPa", data.temperature_800hPa));

            if (data.temperature_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_750hPa", data.temperature_750hPa));

            if (data.temperature_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa", data.temperature_700hPa));

            if (data.temperature_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_650hPa", data.temperature_650hPa));

            if (data.temperature_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa", data.temperature_600hPa));

            if (data.temperature_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_550hPa", data.temperature_550hPa));

            if (data.temperature_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa", data.temperature_500hPa));

            if (data.temperature_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_450hPa", data.temperature_450hPa));

            if (data.temperature_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa", data.temperature_400hPa));

            if (data.temperature_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_350hPa", data.temperature_350hPa));

            if (data.temperature_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa", data.temperature_300hPa));

            if (data.temperature_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_275hPa", data.temperature_275hPa));

            if (data.temperature_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa", data.temperature_250hPa));

            if (data.temperature_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_225hPa", data.temperature_225hPa));

            if (data.temperature_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa", data.temperature_200hPa));

            if (data.temperature_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_175hPa", data.temperature_175hPa));

            if (data.temperature_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa", data.temperature_150hPa));

            if (data.temperature_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_125hPa", data.temperature_125hPa));

            if (data.temperature_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa", data.temperature_100hPa));

            if (data.temperature_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_70hPa", data.temperature_70hPa));

            if (data.temperature_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa", data.temperature_50hPa));

            if (data.temperature_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_30hPa", data.temperature_30hPa));

            if (data.temperature_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_20hPa", data.temperature_20hPa));

            if (data.temperature_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_10hPa", data.temperature_10hPa));

            if (data.relative_humidity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa", data.relative_humidity_1000hPa));

            if (data.relative_humidity_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_950hPa", data.relative_humidity_950hPa));

            if (data.relative_humidity_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa", data.relative_humidity_925hPa));

            if (data.relative_humidity_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_900hPa", data.relative_humidity_900hPa));

            if (data.relative_humidity_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa", data.relative_humidity_850hPa));

            if (data.relative_humidity_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_800hPa", data.relative_humidity_800hPa));

            if (data.relative_humidity_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_750hPa", data.relative_humidity_750hPa));

            if (data.relative_humidity_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa", data.relative_humidity_700hPa));

            if (data.relative_humidity_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_650hPa", data.relative_humidity_650hPa));

            if (data.relative_humidity_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa", data.relative_humidity_600hPa));

            if (data.relative_humidity_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_550hPa", data.relative_humidity_550hPa));

            if (data.relative_humidity_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa", data.relative_humidity_500hPa));

            if (data.relative_humidity_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_450hPa", data.relative_humidity_450hPa));

            if (data.relative_humidity_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa", data.relative_humidity_400hPa));

            if (data.relative_humidity_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_350hPa", data.relative_humidity_350hPa));

            if (data.relative_humidity_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa", data.relative_humidity_300hPa));

            if (data.relative_humidity_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_275hPa", data.relative_humidity_275hPa));

            if (data.relative_humidity_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa", data.relative_humidity_250hPa));

            if (data.relative_humidity_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_225hPa", data.relative_humidity_225hPa));

            if (data.relative_humidity_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa", data.relative_humidity_200hPa));

            if (data.relative_humidity_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_175hPa", data.relative_humidity_175hPa));

            if (data.relative_humidity_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa", data.relative_humidity_150hPa));

            if (data.relative_humidity_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_125hPa", data.relative_humidity_125hPa));

            if (data.relative_humidity_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa", data.relative_humidity_100hPa));

            if (data.relative_humidity_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_70hPa", data.relative_humidity_70hPa));

            if (data.relative_humidity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa", data.relative_humidity_50hPa));

            if (data.relative_humidity_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_30hPa", data.relative_humidity_30hPa));

            if (data.relative_humidity_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_20hPa", data.relative_humidity_20hPa));

            if (data.relative_humidity_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_10hPa", data.relative_humidity_10hPa));

            if (data.cloud_cover_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_1000hPa", data.cloud_cover_1000hPa));

            if (data.cloud_cover_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_950hPa", data.cloud_cover_950hPa));

            if (data.cloud_cover_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_925hPa", data.cloud_cover_925hPa));

            if (data.cloud_cover_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_900hPa", data.cloud_cover_900hPa));

            if (data.cloud_cover_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_850hPa", data.cloud_cover_850hPa));

            if (data.cloud_cover_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_800hPa", data.cloud_cover_800hPa));

            if (data.cloud_cover_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_750hPa", data.cloud_cover_750hPa));

            if (data.cloud_cover_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_700hPa", data.cloud_cover_700hPa));

            if (data.cloud_cover_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_650hPa", data.cloud_cover_650hPa));

            if (data.cloud_cover_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_600hPa", data.cloud_cover_600hPa));

            if (data.cloud_cover_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_550hPa", data.cloud_cover_550hPa));

            if (data.cloud_cover_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_500hPa", data.cloud_cover_500hPa));

            if (data.cloud_cover_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_450hPa", data.cloud_cover_450hPa));

            if (data.cloud_cover_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_400hPa", data.cloud_cover_400hPa));

            if (data.cloud_cover_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_350hPa", data.cloud_cover_350hPa));

            if (data.cloud_cover_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_300hPa", data.cloud_cover_300hPa));

            if (data.cloud_cover_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_275hPa", data.cloud_cover_275hPa));

            if (data.cloud_cover_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_250hPa", data.cloud_cover_250hPa));

            if (data.cloud_cover_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_225hPa", data.cloud_cover_225hPa));

            if (data.cloud_cover_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_200hPa", data.cloud_cover_200hPa));

            if (data.cloud_cover_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_175hPa", data.cloud_cover_175hPa));

            if (data.cloud_cover_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_150hPa", data.cloud_cover_150hPa));

            if (data.cloud_cover_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_125hPa", data.cloud_cover_125hPa));

            if (data.cloud_cover_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_100hPa", data.cloud_cover_100hPa));

            if (data.cloud_cover_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_70hPa", data.cloud_cover_70hPa));

            if (data.cloud_cover_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_50hPa", data.cloud_cover_50hPa));

            if (data.cloud_cover_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_30hPa", data.cloud_cover_30hPa));

            if (data.cloud_cover_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_20hPa", data.cloud_cover_20hPa));

            if (data.cloud_cover_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_10hPa", data.cloud_cover_10hPa));

            if (data.wind_speed_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa", data.wind_speed_1000hPa));

            if (data.wind_speed_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_950hPa", data.wind_speed_950hPa));

            if (data.wind_speed_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa", data.wind_speed_925hPa));

            if (data.wind_speed_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_900hPa", data.wind_speed_900hPa));

            if (data.wind_speed_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa", data.wind_speed_850hPa));

            if (data.wind_speed_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_800hPa", data.wind_speed_800hPa));

            if (data.wind_speed_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_750hPa", data.wind_speed_750hPa));

            if (data.wind_speed_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa", data.wind_speed_700hPa));

            if (data.wind_speed_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_650hPa", data.wind_speed_650hPa));

            if (data.wind_speed_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa", data.wind_speed_600hPa));

            if (data.wind_speed_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_550hPa", data.wind_speed_550hPa));

            if (data.wind_speed_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa", data.wind_speed_500hPa));

            if (data.wind_speed_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_450hPa", data.wind_speed_450hPa));

            if (data.wind_speed_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa", data.wind_speed_400hPa));

            if (data.wind_speed_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_350hPa", data.wind_speed_350hPa));

            if (data.wind_speed_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa", data.wind_speed_300hPa));

            if (data.wind_speed_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_275hPa", data.wind_speed_275hPa));

            if (data.wind_speed_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa", data.wind_speed_250hPa));

            if (data.wind_speed_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_225hPa", data.wind_speed_225hPa));

            if (data.wind_speed_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa", data.wind_speed_200hPa));

            if (data.wind_speed_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_175hPa", data.wind_speed_175hPa));

            if (data.wind_speed_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa", data.wind_speed_150hPa));

            if (data.wind_speed_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_125hPa", data.wind_speed_125hPa));

            if (data.wind_speed_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa", data.wind_speed_100hPa));

            if (data.wind_speed_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_70hPa", data.wind_speed_70hPa));

            if (data.wind_speed_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa", data.wind_speed_50hPa));

            if (data.wind_speed_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_30hPa", data.wind_speed_30hPa));

            if (data.wind_speed_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_20hPa", data.wind_speed_20hPa));

            if (data.wind_speed_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10hPa", data.wind_speed_10hPa));

            if (data.wind_direction_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa", data.wind_direction_1000hPa));

            if (data.wind_direction_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_950hPa", data.wind_direction_950hPa));

            if (data.wind_direction_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa", data.wind_direction_925hPa));

            if (data.wind_direction_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_900hPa", data.wind_direction_900hPa));

            if (data.wind_direction_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa", data.wind_direction_850hPa));

            if (data.wind_direction_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_800hPa", data.wind_direction_800hPa));

            if (data.wind_direction_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_750hPa", data.wind_direction_750hPa));

            if (data.wind_direction_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa", data.wind_direction_700hPa));

            if (data.wind_direction_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_650hPa", data.wind_direction_650hPa));

            if (data.wind_direction_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa", data.wind_direction_600hPa));

            if (data.wind_direction_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_550hPa", data.wind_direction_550hPa));

            if (data.wind_direction_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa", data.wind_direction_500hPa));

            if (data.wind_direction_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_450hPa", data.wind_direction_450hPa));

            if (data.wind_direction_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa", data.wind_direction_400hPa));

            if (data.wind_direction_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_350hPa", data.wind_direction_350hPa));

            if (data.wind_direction_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa", data.wind_direction_300hPa));

            if (data.wind_direction_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_275hPa", data.wind_direction_275hPa));

            if (data.wind_direction_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa", data.wind_direction_250hPa));

            if (data.wind_direction_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_225hPa", data.wind_direction_225hPa));

            if (data.wind_direction_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa", data.wind_direction_200hPa));

            if (data.wind_direction_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_175hPa", data.wind_direction_175hPa));

            if (data.wind_direction_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa", data.wind_direction_150hPa));

            if (data.wind_direction_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_125hPa", data.wind_direction_125hPa));

            if (data.wind_direction_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa", data.wind_direction_100hPa));

            if (data.wind_direction_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_70hPa", data.wind_direction_70hPa));

            if (data.wind_direction_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa", data.wind_direction_50hPa));

            if (data.wind_direction_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_30hPa", data.wind_direction_30hPa));

            if (data.wind_direction_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_20hPa", data.wind_direction_20hPa));

            if (data.wind_direction_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10hPa", data.wind_direction_10hPa));

            if (data.geopotential_height_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa", data.geopotential_height_1000hPa));

            if (data.geopotential_height_950hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_950hPa", data.geopotential_height_950hPa));

            if (data.geopotential_height_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa", data.geopotential_height_925hPa));

            if (data.geopotential_height_900hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_900hPa", data.geopotential_height_900hPa));

            if (data.geopotential_height_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa", data.geopotential_height_850hPa));

            if (data.geopotential_height_800hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_800hPa", data.geopotential_height_800hPa));

            if (data.geopotential_height_750hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_750hPa", data.geopotential_height_750hPa));

            if (data.geopotential_height_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa", data.geopotential_height_700hPa));

            if (data.geopotential_height_650hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_650hPa", data.geopotential_height_650hPa));

            if (data.geopotential_height_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa", data.geopotential_height_600hPa));

            if (data.geopotential_height_550hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_550hPa", data.geopotential_height_550hPa));

            if (data.geopotential_height_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa", data.geopotential_height_500hPa));

            if (data.geopotential_height_450hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_450hPa", data.geopotential_height_450hPa));

            if (data.geopotential_height_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa", data.geopotential_height_400hPa));

            if (data.geopotential_height_350hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_350hPa", data.geopotential_height_350hPa));

            if (data.geopotential_height_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa", data.geopotential_height_300hPa));

            if (data.geopotential_height_275hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_275hPa", data.geopotential_height_275hPa));

            if (data.geopotential_height_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa", data.geopotential_height_250hPa));

            if (data.geopotential_height_225hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_225hPa", data.geopotential_height_225hPa));

            if (data.geopotential_height_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa", data.geopotential_height_200hPa));

            if (data.geopotential_height_175hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_175hPa", data.geopotential_height_175hPa));

            if (data.geopotential_height_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa", data.geopotential_height_150hPa));

            if (data.geopotential_height_125hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_125hPa", data.geopotential_height_125hPa));

            if (data.geopotential_height_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa", data.geopotential_height_100hPa));

            if (data.geopotential_height_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_70hPa", data.geopotential_height_70hPa));

            if (data.geopotential_height_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa", data.geopotential_height_50hPa));

            if (data.geopotential_height_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_30hPa", data.geopotential_height_30hPa));

            if (data.geopotential_height_20hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_20hPa", data.geopotential_height_20hPa));

            if (data.geopotential_height_10hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_10hPa", data.geopotential_height_10hPa));

            return df;
        }

        private static string currentDirectory = DirectoryHelper.GetCurrentDirectory();

        public static async Task<DataFrame?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 4 ,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null,
                                                         bool toCsv = false,
                                                         string? filePath = null,
                                                         string? fileName = null)
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

            var response = await RetrieveData.GetDataAsync(url,
                                              proxy);

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

                var df = ToDataFrame(data);

                if (toCsv == true)
                {
                    if (filePath == null)
                    {
                        filePath = Path.Combine(currentDirectory, "Open Meteo Data");
                    }
                    else
                    {
                        filePath = filePath;
                    }
                    DirectoryBuilder.BuildDirectory(filePath);

                    if (fileName == null)
                    {
                        string latString = (string)latitude.Replace('.', '_');
                        string lonString = (string)longitude.Replace('.', '_');
                        fileName = $"ARPEGE_PointForecast_{latString}_{lonString}.csv";
                    }
                    else
                    {
                        fileName = fileName;
                    }

                    ArchiveData.SaveDataToCsv(filePath, fileName, df);
                }

                return df;
            }

            else
            {
                Console.WriteLine($"ARPEGE Data Not Available At This Time");
                return null;
            }    
        }
    }
}


