/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Variables.HourlyData.ICON;

namespace OpenMeteoApiNet.DataFrames.HourlyData.ICON
{
    public class iconDataFrame
    {
        public static DataFrame ToDataFrame(iconParams data)
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
    }
}
