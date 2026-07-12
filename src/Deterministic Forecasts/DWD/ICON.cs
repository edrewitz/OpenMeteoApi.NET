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

namespace OpenMeteoApiNet.DeterministicForecasts.DWD.ICON
{
    public class iconParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? relative_humidity_2m { get; set; }
        public double?[]? apparent_temperature { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? snow_depth { get; set; }
        public double?[]? pressure_msl { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? cloud_cover { get; set; }
        public double?[]? cloud_cover_low { get; set; }
        public double?[]? cloud_cover_mid { get; set; }
        public double?[]? cloud_cover_high { get; set; }
        public double?[]? visibility { get; set; }
        public double?[]? evapotranspiration { get; set; }
        public double?[]? et0_fao_evapotranspiration { get; set; }
        public double?[]? vapour_pressure_deficit { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_80m { get; set; }
        public double?[]? wind_speed_120m { get; set; }
        public double?[]? wind_speed_180m { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_80m { get; set; }
        public double?[]? wind_direction_120m { get; set; }
        public double?[]? wind_direction_180m { get; set; }
        public double?[]? temperature_80m { get; set; }
        public double?[]? wind_gusts_10m { get; set; }
        public double?[]? temperature_120m { get; set; }
        public double?[]? temperature_180m { get; set; }
        public double?[]? soil_temperature_0cm { get; set; }
        public double?[]? soil_temperature_6cm { get; set; }
        public double?[]? soil_temperature_18cm { get; set; }
        public double?[]? soil_temperature_54cm { get; set; }
        public double?[]? soil_moisture_0_to_1cm { get; set; }
        public double?[]? soil_moisture_1_to_3cm { get; set; }
        public double?[]? soil_moisture_3_to_9cm { get; set; }
        public double?[]? soil_moisture_9_to_27cm { get; set; }
        public double?[]? soil_moisture_27_to_81cm { get; set; }
        public double?[]? temperature_1000hPa { get; set; }
        public double?[]? temperature_975hPa { get; set; }
        public double?[]? temperature_950hPa { get; set; }
        public double?[]? temperature_925hPa { get; set; }
        public double?[]? temperature_900hPa { get; set; }
        public double?[]? temperature_850hPa { get; set; }
        public double?[]? temperature_800hPa { get; set; }
        public double?[]? temperature_700hPa { get; set; }
        public double?[]? temperature_600hPa { get; set; }
        public double?[]? temperature_500hPa { get; set; }
        public double?[]? temperature_400hPa { get; set; }
        public double?[]? temperature_300hPa { get; set; }
        public double?[]? temperature_250hPa { get; set; }
        public double?[]? temperature_200hPa { get; set; }
        public double?[]? temperature_150hPa { get; set; }
        public double?[]? temperature_100hPa { get; set; }
        public double?[]? temperature_70hPa { get; set; }
        public double?[]? temperature_50hPa { get; set; }
        public double?[]? temperature_30hPa { get; set; }
        public double?[]? relative_humidity_1000hPa { get; set; }
        public double?[]? relative_humidity_975hPa { get; set; }
        public double?[]? relative_humidity_950hPa { get; set; }
        public double?[]? relative_humidity_925hPa { get; set; }
        public double?[]? relative_humidity_900hPa { get; set; }
        public double?[]? relative_humidity_850hPa { get; set; }
        public double?[]? relative_humidity_800hPa { get; set; }
        public double?[]? relative_humidity_700hPa { get; set; }
        public double?[]? relative_humidity_600hPa { get; set; }
        public double?[]? relative_humidity_500hPa { get; set; }
        public double?[]? relative_humidity_400hPa { get; set; }
        public double?[]? relative_humidity_300hPa { get; set; }
        public double?[]? relative_humidity_250hPa { get; set; }
        public double?[]? relative_humidity_200hPa { get; set; }
        public double?[]? relative_humidity_150hPa { get; set; }
        public double?[]? relative_humidity_100hPa { get; set; }
        public double?[]? relative_humidity_70hPa { get; set; }
        public double?[]? relative_humidity_50hPa { get; set; }
        public double?[]? relative_humidity_30hPa { get; set; }
        public double?[]? cloud_cover_1000hPa { get; set; }
        public double?[]? cloud_cover_975hPa { get; set; }
        public double?[]? cloud_cover_950hPa { get; set; }
        public double?[]? cloud_cover_925hPa { get; set; }
        public double?[]? cloud_cover_900hPa { get; set; }
        public double?[]? cloud_cover_850hPa { get; set; }
        public double?[]? cloud_cover_800hPa { get; set; }
        public double?[]? cloud_cover_700hPa { get; set; }
        public double?[]? cloud_cover_600hPa { get; set; }
        public double?[]? cloud_cover_500hPa { get; set; }
        public double?[]? cloud_cover_400hPa { get; set; }
        public double?[]? cloud_cover_300hPa { get; set; }
        public double?[]? cloud_cover_250hPa { get; set; }
        public double?[]? cloud_cover_200hPa { get; set; }
        public double?[]? cloud_cover_150hPa { get; set; }
        public double?[]? cloud_cover_100hPa { get; set; }
        public double?[]? cloud_cover_70hPa { get; set; }
        public double?[]? cloud_cover_50hPa { get; set; }
        public double?[]? cloud_cover_30hPa { get; set; }
        public double?[]? wind_speed_1000hPa { get; set; }
        public double?[]? wind_speed_975hPa { get; set; }
        public double?[]? wind_speed_950hPa { get; set; }
        public double?[]? wind_speed_925hPa { get; set; }
        public double?[]? wind_speed_900hPa { get; set; }
        public double?[]? wind_speed_850hPa { get; set; }
        public double?[]? wind_speed_800hPa { get; set; }
        public double?[]? wind_speed_700hPa { get; set; }
        public double?[]? wind_speed_600hPa { get; set; }
        public double?[]? wind_speed_500hPa { get; set; }
        public double?[]? wind_speed_400hPa { get; set; }
        public double?[]? wind_speed_300hPa { get; set; }
        public double?[]? wind_speed_250hPa { get; set; }
        public double?[]? wind_speed_200hPa { get; set; }
        public double?[]? wind_speed_150hPa { get; set; }
        public double?[]? wind_speed_100hPa { get; set; }
        public double?[]? wind_speed_70hPa { get; set; }
        public double?[]? wind_speed_50hPa { get; set; }
        public double?[]? wind_speed_30hPa { get; set; }
        public double?[]? wind_direction_1000hPa { get; set; }
        public double?[]? wind_direction_975hPa { get; set; }
        public double?[]? wind_direction_950hPa { get; set; }
        public double?[]? wind_direction_925hPa { get; set; }
        public double?[]? wind_direction_900hPa { get; set; }
        public double?[]? wind_direction_850hPa { get; set; }
        public double?[]? wind_direction_800hPa { get; set; }
        public double?[]? wind_direction_700hPa { get; set; }
        public double?[]? wind_direction_600hPa { get; set; }
        public double?[]? wind_direction_500hPa { get; set; }
        public double?[]? wind_direction_400hPa { get; set; }
        public double?[]? wind_direction_300hPa { get; set; }
        public double?[]? wind_direction_250hPa { get; set; }
        public double?[]? wind_direction_200hPa { get; set; }
        public double?[]? wind_direction_150hPa { get; set; }
        public double?[]? wind_direction_100hPa { get; set; }
        public double?[]? wind_direction_70hPa { get; set; }
        public double?[]? wind_direction_50hPa { get; set; }
        public double?[]? wind_direction_30hPa { get; set; }
        public double?[]? geopotential_height_1000hPa { get; set; }
        public double?[]? geopotential_height_975hPa { get; set; }
        public double?[]? geopotential_height_950hPa { get; set; }
        public double?[]? geopotential_height_925hPa { get; set; }
        public double?[]? geopotential_height_900hPa { get; set; }
        public double?[]? geopotential_height_850hPa { get; set; }
        public double?[]? geopotential_height_800hPa { get; set; }
        public double?[]? geopotential_height_700hPa { get; set; }
        public double?[]? geopotential_height_600hPa { get; set; }
        public double?[]? geopotential_height_500hPa { get; set; }
        public double?[]? geopotential_height_400hPa { get; set; }
        public double?[]? geopotential_height_300hPa { get; set; }
        public double?[]? geopotential_height_250hPa { get; set; }
        public double?[]? geopotential_height_200hPa { get; set; }
        public double?[]? geopotential_height_150hPa { get; set; }
        public double?[]? geopotential_height_100hPa { get; set; }
        public double?[]? geopotential_height_70hPa { get; set; }
        public double?[]? geopotential_height_50hPa { get; set; }
        public double?[]? geopotential_height_30hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }
    }

    public static class iconHourlyForecastApi
    {

        private static DataFrame ToDataFrame(iconParams data)
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

            if (data.apparent_temperature != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature", data.apparent_temperature));

            if (data.precipitation != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation", data.precipitation));

            if (data.snowfall != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall", data.snowfall));

            if (data.snow_depth != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snow_depth", data.snow_depth));

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

            if (data.visibility != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility", data.visibility));

            if (data.evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("evapotranspiration", data.evapotranspiration));

            if (data.et0_fao_evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration", data.et0_fao_evapotranspiration));

            if (data.vapour_pressure_deficit != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit", data.vapour_pressure_deficit));

            if (data.wind_speed_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m", data.wind_speed_10m));

            if (data.wind_speed_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m", data.wind_speed_80m));

            if (data.wind_speed_120m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_120m", data.wind_speed_120m));

            if (data.wind_speed_180m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_180m", data.wind_speed_180m));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_80m", data.wind_direction_80m));

            if (data.wind_direction_120m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_120m", data.wind_direction_120m));

            if (data.wind_direction_180m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_180m", data.wind_direction_180m));

            if (data.temperature_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m", data.temperature_80m));

            if (data.wind_gusts_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m", data.wind_gusts_10m));

            if (data.temperature_120m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_120m", data.temperature_120m));

            if (data.temperature_180m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_180m", data.temperature_180m));

            if (data.soil_temperature_0cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_0cm", data.soil_temperature_0cm));

            if (data.soil_temperature_6cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_6cm", data.soil_temperature_6cm));

            if (data.soil_temperature_18cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_18cm", data.soil_temperature_18cm));

            if (data.soil_temperature_54cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_54cm", data.soil_temperature_54cm));

            if (data.soil_moisture_0_to_1cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_0_to_1cm", data.soil_moisture_0_to_1cm));

            if (data.soil_moisture_1_to_3cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_1_to_3cm", data.soil_moisture_1_to_3cm));

            if (data.soil_moisture_3_to_9cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_3_to_9cm", data.soil_moisture_3_to_9cm));

            if (data.soil_moisture_9_to_27cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_9_to_27cm", data.soil_moisture_9_to_27cm));

            if (data.soil_moisture_27_to_81cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_27_to_81cm", data.soil_moisture_27_to_81cm));

            if (data.temperature_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa", data.temperature_1000hPa));

            if (data.temperature_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_975hPa", data.temperature_975hPa));

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

            if (data.temperature_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa", data.temperature_700hPa));

            if (data.temperature_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa", data.temperature_600hPa));

            if (data.temperature_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa", data.temperature_500hPa));

            if (data.temperature_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa", data.temperature_400hPa));

            if (data.temperature_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa", data.temperature_300hPa));

            if (data.temperature_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa", data.temperature_250hPa));

            if (data.temperature_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa", data.temperature_200hPa));

            if (data.temperature_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa", data.temperature_150hPa));

            if (data.temperature_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa", data.temperature_100hPa));

            if (data.temperature_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_70hPa", data.temperature_70hPa));

            if (data.temperature_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa", data.temperature_50hPa));

            if (data.temperature_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_30hPa", data.temperature_30hPa));

            if (data.relative_humidity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa", data.relative_humidity_1000hPa));

            if (data.relative_humidity_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_975hPa", data.relative_humidity_975hPa));

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

            if (data.relative_humidity_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa", data.relative_humidity_700hPa));

            if (data.relative_humidity_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa", data.relative_humidity_600hPa));

            if (data.relative_humidity_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa", data.relative_humidity_500hPa));

            if (data.relative_humidity_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa", data.relative_humidity_400hPa));

            if (data.relative_humidity_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa", data.relative_humidity_300hPa));

            if (data.relative_humidity_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa", data.relative_humidity_250hPa));

            if (data.relative_humidity_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa", data.relative_humidity_200hPa));

            if (data.relative_humidity_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa", data.relative_humidity_150hPa));

            if (data.relative_humidity_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa", data.relative_humidity_100hPa));

            if (data.relative_humidity_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_70hPa", data.relative_humidity_70hPa));

            if (data.relative_humidity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa", data.relative_humidity_50hPa));

            if (data.relative_humidity_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_30hPa", data.relative_humidity_30hPa));

            if (data.cloud_cover_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_1000hPa", data.cloud_cover_1000hPa));

            if (data.cloud_cover_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_975hPa", data.cloud_cover_975hPa));

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

            if (data.cloud_cover_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_700hPa", data.cloud_cover_700hPa));

            if (data.cloud_cover_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_600hPa", data.cloud_cover_600hPa));

            if (data.cloud_cover_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_500hPa", data.cloud_cover_500hPa));

            if (data.cloud_cover_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_400hPa", data.cloud_cover_400hPa));

            if (data.cloud_cover_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_300hPa", data.cloud_cover_300hPa));

            if (data.cloud_cover_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_250hPa", data.cloud_cover_250hPa));

            if (data.cloud_cover_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_200hPa", data.cloud_cover_200hPa));

            if (data.cloud_cover_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_150hPa", data.cloud_cover_150hPa));

            if (data.cloud_cover_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_100hPa", data.cloud_cover_100hPa));

            if (data.cloud_cover_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_70hPa", data.cloud_cover_70hPa));

            if (data.cloud_cover_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_50hPa", data.cloud_cover_50hPa));

            if (data.cloud_cover_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_30hPa", data.cloud_cover_30hPa));

            if (data.wind_speed_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa", data.wind_speed_1000hPa));

            if (data.wind_speed_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_975hPa", data.wind_speed_975hPa));

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

            if (data.wind_speed_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa", data.wind_speed_700hPa));

            if (data.wind_speed_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa", data.wind_speed_600hPa));

            if (data.wind_speed_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa", data.wind_speed_500hPa));

            if (data.wind_speed_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa", data.wind_speed_400hPa));

            if (data.wind_speed_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa", data.wind_speed_300hPa));

            if (data.wind_speed_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa", data.wind_speed_250hPa));

            if (data.wind_speed_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa", data.wind_speed_200hPa));

            if (data.wind_speed_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa", data.wind_speed_150hPa));

            if (data.wind_speed_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa", data.wind_speed_100hPa));

            if (data.wind_speed_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_70hPa", data.wind_speed_70hPa));

            if (data.wind_speed_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa", data.wind_speed_50hPa));

            if (data.wind_speed_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_30hPa", data.wind_speed_30hPa));

            if (data.wind_direction_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa", data.wind_direction_1000hPa));

            if (data.wind_direction_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_975hPa", data.wind_direction_975hPa));

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

            if (data.wind_direction_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa", data.wind_direction_700hPa));

            if (data.wind_direction_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa", data.wind_direction_600hPa));

            if (data.wind_direction_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa", data.wind_direction_500hPa));

            if (data.wind_direction_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa", data.wind_direction_400hPa));

            if (data.wind_direction_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa", data.wind_direction_300hPa));

            if (data.wind_direction_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa", data.wind_direction_250hPa));

            if (data.wind_direction_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa", data.wind_direction_200hPa));

            if (data.wind_direction_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa", data.wind_direction_150hPa));

            if (data.wind_direction_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa", data.wind_direction_100hPa));

            if (data.wind_direction_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_70hPa", data.wind_direction_70hPa));

            if (data.wind_direction_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa", data.wind_direction_50hPa));

            if (data.wind_direction_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_30hPa", data.wind_direction_30hPa));

            if (data.geopotential_height_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa", data.geopotential_height_1000hPa));

            if (data.geopotential_height_975hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_975hPa", data.geopotential_height_975hPa));

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

            if (data.geopotential_height_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa", data.geopotential_height_700hPa));

            if (data.geopotential_height_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa", data.geopotential_height_600hPa));

            if (data.geopotential_height_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa", data.geopotential_height_500hPa));

            if (data.geopotential_height_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa", data.geopotential_height_400hPa));

            if (data.geopotential_height_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa", data.geopotential_height_300hPa));

            if (data.geopotential_height_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa", data.geopotential_height_250hPa));

            if (data.geopotential_height_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa", data.geopotential_height_200hPa));

            if (data.geopotential_height_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa", data.geopotential_height_150hPa));

            if (data.geopotential_height_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa", data.geopotential_height_100hPa));

            if (data.geopotential_height_70hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_70hPa", data.geopotential_height_70hPa));

            if (data.geopotential_height_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa", data.geopotential_height_50hPa));

            if (data.geopotential_height_30hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_30hPa", data.geopotential_height_30hPa));

            return df;
        }

        private static string currentDirectory = DirectoryHelper.GetCurrentDirectory();

        public static async Task<DataFrame?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 7 ,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null,
                                                         bool toCsv = false,
                                                         string? filePath = null,
                                                         string? fileName = null)
        /*
         * This function is the client that retrieves and returns DWD ICON Forecast from the Open-Meteo API.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=7. The number of days to retrieve forecast data for, starting from the current day. Maximum is 7 days.
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
         *      "temperature_2m" 
                "relative_humidity_2m" 
                "apparent_temperature" 
                "precipitation" 
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
                "temperature_975hPa"
                "temperature_950hPa"
                "temperature_925hPa"
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
                "temperature_70hPa"
                "temperature_50hPa"
                "temperature_30hPa"
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
                "relative_humidity_70hPa"
                "relative_humidity_50hPa"
                "relative_humidity_30hPa"
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
                "cloud_cover_70hPa"
                "cloud_cover_50hPa"
                "cloud_cover_30hPa"
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
                "wind_speed_70hPa"
                "wind_speed_50hPa"
                "wind_speed_30hPa"
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
                "wind_direction_70hPa"
                "wind_direction_50hPa"
                "wind_direction_30hPa"
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
                "geopotential_height_70hPa" 
                "geopotential_height_50hPa" 
                "geopotential_height_30hPa" 


          6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).

          7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

          8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

          9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
         *      
         * 
         * Returns
         * -------
         * 
         * The ICON Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {
            if (days > 7) {
                Console.WriteLine("The maximum number of days for the forecast is 7. Setting 'days' to 7.");
                days = 7;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m" ,
                                    "relative_humidity_2m" ,
                                    "apparent_temperature" ,
                                    "precipitation" ,
                                    "snowfall" ,
                                    "snow_depth" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "cloud_cover_low" ,
                                    "cloud_cover_mid" ,
                                    "cloud_cover_high" ,
                                    "visibility" ,
                                    "evapotranspiration" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_80m" ,
                                    "wind_speed_120m" ,
                                    "wind_speed_180m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_80m" ,
                                    "wind_direction_120m" ,
                                    "wind_direction_180m" ,
                                    "temperature_80m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_120m" ,
                                    "temperature_180m" ,
                                    "soil_temperature_0cm" ,
                                    "soil_temperature_6cm" ,
                                    "soil_temperature_18cm" ,
                                    "soil_temperature_54cm" ,
                                    "soil_moisture_0_to_1cm" ,
                                    "soil_moisture_1_to_3cm" ,
                                    "soil_moisture_3_to_9cm" ,
                                    "soil_moisture_9_to_27cm" ,
                                    "soil_moisture_27_to_81cm" ,
                                    "temperature_1000hPa" ,
                                    "temperature_975hPa" ,
                                    "temperature_950hPa" ,
                                    "temperature_925hPa" ,
                                    "temperature_900hPa" ,
                                    "temperature_850hPa" ,
                                    "temperature_800hPa" ,
                                    "temperature_700hPa" ,
                                    "temperature_600hPa" ,
                                    "temperature_500hPa" ,
                                    "temperature_400hPa" ,
                                    "temperature_300hPa" ,
                                    "temperature_250hPa" ,
                                    "temperature_200hPa" ,
                                    "temperature_150hPa" ,
                                    "temperature_100hPa" ,
                                    "temperature_70hPa" ,
                                    "temperature_50hPa" ,
                                    "temperature_30hPa" ,
                                    "relative_humidity_1000hPa" ,
                                    "relative_humidity_975hPa" ,
                                    "relative_humidity_950hPa" ,
                                    "relative_humidity_925hPa" ,
                                    "relative_humidity_900hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_800hPa" ,
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_70hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "relative_humidity_30hPa" ,
                                    "cloud_cover_1000hPa" ,
                                    "cloud_cover_975hPa" ,
                                    "cloud_cover_950hPa" ,
                                    "cloud_cover_925hPa" ,
                                    "cloud_cover_900hPa" ,
                                    "cloud_cover_850hPa" ,
                                    "cloud_cover_800hPa" ,
                                    "cloud_cover_700hPa" ,
                                    "cloud_cover_600hPa" ,
                                    "cloud_cover_500hPa" ,
                                    "cloud_cover_400hPa" ,
                                    "cloud_cover_300hPa" ,
                                    "cloud_cover_250hPa" ,
                                    "cloud_cover_200hPa" ,
                                    "cloud_cover_150hPa" ,
                                    "cloud_cover_100hPa" ,
                                    "cloud_cover_70hPa" ,
                                    "cloud_cover_50hPa" ,
                                    "cloud_cover_30hPa" ,
                                    "wind_speed_1000hPa" ,
                                    "wind_speed_975hPa" ,
                                    "wind_speed_950hPa" ,
                                    "wind_speed_925hPa" ,
                                    "wind_speed_900hPa" ,
                                    "wind_speed_850hPa" ,
                                    "wind_speed_800hPa" ,
                                    "wind_speed_700hPa" ,
                                    "wind_speed_600hPa" ,
                                    "wind_speed_500hPa" ,
                                    "wind_speed_400hPa" ,
                                    "wind_speed_300hPa" ,
                                    "wind_speed_250hPa" ,
                                    "wind_speed_200hPa" ,
                                    "wind_speed_150hPa" ,
                                    "wind_speed_100hPa" ,
                                    "wind_speed_70hPa" ,
                                    "wind_speed_50hPa" ,
                                    "wind_speed_30hPa" ,
                                    "wind_direction_1000hPa" ,
                                    "wind_direction_975hPa" ,
                                    "wind_direction_950hPa" ,
                                    "wind_direction_925hPa" ,
                                    "wind_direction_900hPa" ,
                                    "wind_direction_850hPa" ,
                                    "wind_direction_800hPa" ,
                                    "wind_direction_700hPa" ,
                                    "wind_direction_600hPa" ,
                                    "wind_direction_500hPa" ,
                                    "wind_direction_400hPa" ,
                                    "wind_direction_300hPa" ,
                                    "wind_direction_250hPa" ,
                                    "wind_direction_200hPa" ,
                                    "wind_direction_150hPa" ,
                                    "wind_direction_100hPa" ,
                                    "wind_direction_70hPa" ,
                                    "wind_direction_50hPa" ,
                                    "wind_direction_30hPa" ,
                                    "geopotential_height_1000hPa" ,
                                    "geopotential_height_975hPa" ,
                                    "geopotential_height_950hPa" ,
                                    "geopotential_height_925hPa" ,
                                    "geopotential_height_900hPa" ,
                                    "geopotential_height_850hPa" ,
                                    "geopotential_height_800hPa" ,
                                    "geopotential_height_700hPa" ,
                                    "geopotential_height_600hPa" ,
                                    "geopotential_height_500hPa" ,
                                    "geopotential_height_400hPa" ,
                                    "geopotential_height_300hPa" ,
                                    "geopotential_height_250hPa" ,
                                    "geopotential_height_200hPa" ,
                                    "geopotential_height_150hPa" ,
                                    "geopotential_height_100hPa" ,
                                    "geopotential_height_70hPa" ,
                                    "geopotential_height_50hPa" ,
                                    "geopotential_height_30hPa" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=icon_seamless&forecast_days={days}" +
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

            // Deserialize the "hourly" property into our iconParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<iconParams>(hourlyWeatherElement.GetRawText());
            if (data == null)
            {
                Console.WriteLine("Unable to parse hourly weather data.");
                return null;
            }

            // Extract the time attribute which is in the form of a string.
            var time = data.time;

            // Convert the time string to a DateTime object.
            var dateTimeList = new List<DateTime>();

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
                        fileName = $"ICON_PointForecast_{latString}_{lonString}.csv";
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
                Console.WriteLine($"ICON Data Not Available At This Time");
                return null;
            }
        }           
    }
}

