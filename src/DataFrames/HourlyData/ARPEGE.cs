/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Variables.HourlyData.ARPEGE;

namespace OpenMeteoApiNet.DataFrames.HourlyData.ARPEGE
{
    public class arpegeDataFrame
    {
        public static DataFrame ToDataFrame(arpegeParams data)
        {
            /*
             * Converts the data object of type arpegeParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the arpegeParams object.
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
    }
}
