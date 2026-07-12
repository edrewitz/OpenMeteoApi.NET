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

namespace OpenMeteoApiNet.DeterministicForecasts.ECMWF.ECMWF_AIFS
{
    public class aifsParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? relative_humidity_2m { get; set; }
        public double?[]? dew_point_2m { get; set; }
        public double?[]? apparent_temperature { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? rain { get; set; }
        public double?[]? showers { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? runoff { get; set; }
        public double?[]? visibility { get; set; }
        public double?[]? weather_code { get; set; }
        public double?[]? pressure_msl { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? cloud_cover { get; set; }
        public double?[]? cloud_cover_low { get; set; }
        public double?[]? cloud_cover_mid { get; set; }
        public double?[]? cloud_cover_high { get; set; }
        public double?[]? sunshine_duration { get; set; }
        public double?[]? potential_evapotranspiration { get; set; }
        public double?[]? et0_fao_evapotranspiration { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_100m { get; set; }
        public double?[]? wind_speed_200m { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_100m { get; set; }
        public double?[]? wind_direction_200m { get; set; }
        public double?[]? wind_gusts_10m { get; set; }
        public double?[]? cape { get; set; }
        public double?[]? convective_inhibition { get; set; }
        public double?[]? total_column_integrated_water_vapour { get; set; }
        public double?[]? vapour_pressure_deficit { get; set; }
        public double?[]? surface_temperature { get; set; }
        public double?[]? soil_temperature_0_to_7cm { get; set; }
        public double?[]? soil_temperature_7_to_28cm { get; set; }
        public double?[]? soil_temperature_28_to_100cm { get; set; }
        public double?[]? soil_temperature_100_to_255cm { get; set; }
        public double?[]? soil_moisture_0_to_7cm { get; set; }
        public double?[]? soil_moisture_28_to_100cm { get; set; }
        public double?[]? soil_moisture_7_to_28cm { get; set; }
        public double?[]? soil_moisture_100_to_255cm { get; set; }
        public double?[]? temperature_1000hPa { get; set; }
        public double?[]? temperature_925hPa { get; set; }
        public double?[]? temperature_850hPa { get; set; }
        public double?[]? temperature_700hPa { get; set; }
        public double?[]? temperature_600hPa { get; set; }
        public double?[]? temperature_500hPa { get; set; }
        public double?[]? temperature_400hPa { get; set; }
        public double?[]? temperature_300hPa { get; set; }
        public double?[]? temperature_250hPa { get; set; }
        public double?[]? temperature_200hPa { get; set; }
        public double?[]? temperature_150hPa { get; set; }
        public double?[]? temperature_100hPa { get; set; }
        public double?[]? temperature_50hPa { get; set; }
        public double?[]? relative_humidity_1000hPa { get; set; }
        public double?[]? relative_humidity_925hPa { get; set; }
        public double?[]? relative_humidity_850hPa { get; set; }
        public double?[]? relative_humidity_700hPa { get; set; }
        public double?[]? relative_humidity_600hPa { get; set; }
        public double?[]? relative_humidity_500hPa { get; set; }
        public double?[]? relative_humidity_400hPa { get; set; }
        public double?[]? relative_humidity_300hPa { get; set; }
        public double?[]? relative_humidity_250hPa { get; set; }
        public double?[]? relative_humidity_200hPa { get; set; }
        public double?[]? relative_humidity_150hPa { get; set; }
        public double?[]? relative_humidity_100hPa { get; set; }
        public double?[]? relative_humidity_50hPa { get; set; }
        public double?[]? cloud_cover_1000hPa { get; set; }
        public double?[]? cloud_cover_925hPa { get; set; }
        public double?[]? cloud_cover_850hPa { get; set; }
        public double?[]? cloud_cover_700hPa { get; set; }
        public double?[]? cloud_cover_600hPa { get; set; }
        public double?[]? cloud_cover_500hPa { get; set; }
        public double?[]? cloud_cover_400hPa { get; set; }
        public double?[]? cloud_cover_300hPa { get; set; }
        public double?[]? cloud_cover_250hPa { get; set; }
        public double?[]? cloud_cover_200hPa { get; set; }
        public double?[]? cloud_cover_150hPa { get; set; }
        public double?[]? cloud_cover_100hPa { get; set; }
        public double?[]? cloud_cover_50hPa { get; set; }
        public double?[]? wind_speed_1000hPa { get; set; }
        public double?[]? wind_speed_925hPa { get; set; }
        public double?[]? wind_speed_850hPa { get; set; }
        public double?[]? wind_speed_700hPa { get; set; }
        public double?[]? wind_speed_600hPa { get; set; }
        public double?[]? wind_speed_500hPa { get; set; }
        public double?[]? wind_speed_400hPa { get; set; }
        public double?[]? wind_speed_300hPa { get; set; }
        public double?[]? wind_speed_250hPa { get; set; }
        public double?[]? wind_speed_200hPa { get; set; }
        public double?[]? wind_speed_150hPa { get; set; }
        public double?[]? wind_speed_100hPa { get; set; }
        public double?[]? wind_speed_50hPa { get; set; }
        public double?[]? wind_direction_1000hPa { get; set; }
        public double?[]? wind_direction_925hPa { get; set; }
        public double?[]? wind_direction_850hPa { get; set; }
        public double?[]? wind_direction_700hPa { get; set; }
        public double?[]? wind_direction_600hPa { get; set; }
        public double?[]? wind_direction_500hPa { get; set; }
        public double?[]? wind_direction_400hPa { get; set; }
        public double?[]? wind_direction_300hPa { get; set; }
        public double?[]? wind_direction_250hPa { get; set; }
        public double?[]? wind_direction_200hPa { get; set; }
        public double?[]? wind_direction_150hPa { get; set; }
        public double?[]? wind_direction_100hPa { get; set; }
        public double?[]? wind_direction_50hPa { get; set; }
        public double?[]? vertical_velocity_1000hPa { get; set; }
        public double?[]? vertical_velocity_925hPa { get; set; }
        public double?[]? vertical_velocity_850hPa { get; set; }
        public double?[]? vertical_velocity_700hPa { get; set; }
        public double?[]? vertical_velocity_600hPa { get; set; }
        public double?[]? vertical_velocity_500hPa { get; set; }
        public double?[]? vertical_velocity_400hPa { get; set; }
        public double?[]? vertical_velocity_300hPa { get; set; }
        public double?[]? vertical_velocity_250hPa { get; set; }
        public double?[]? vertical_velocity_200hPa { get; set; }
        public double?[]? vertical_velocity_150hPa { get; set; }
        public double?[]? vertical_velocity_100hPa { get; set; }
        public double?[]? vertical_velocity_50hPa { get; set; }
        public double?[]? geopotential_height_1000hPa { get; set; }
        public double?[]? geopotential_height_925hPa { get; set; }
        public double?[]? geopotential_height_850hPa { get; set; }
        public double?[]? geopotential_height_700hPa { get; set; }
        public double?[]? geopotential_height_600hPa { get; set; }
        public double?[]? geopotential_height_500hPa { get; set; }
        public double?[]? geopotential_height_400hPa { get; set; }
        public double?[]? geopotential_height_300hPa { get; set; }
        public double?[]? geopotential_height_250hPa { get; set; }
        public double?[]? geopotential_height_200hPa { get; set; }
        public double?[]? geopotential_height_150hPa { get; set; }
        public double?[]? geopotential_height_100hPa { get; set; }
        public double?[]? geopotential_height_50hPa { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }
    }
    public static class aifsHourlyForecastApi
    {

        private static DataFrame ToDataFrame(aifsParams data)
        {
            /*
             * Converts the data object of type iconParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the aifsParams object.
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

            if (data.showers != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("showers", data.showers));

            if (data.snowfall != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall", data.snowfall));

            if (data.runoff != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("runoff", data.runoff));

            if (data.visibility != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility", data.visibility));

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

            if (data.sunshine_duration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("sunshine_duration", data.sunshine_duration));

            if (data.potential_evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("potential_evapotranspiration", data.potential_evapotranspiration));

            if (data.et0_fao_evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration", data.et0_fao_evapotranspiration));

            if (data.wind_speed_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m", data.wind_speed_10m));

            if (data.wind_speed_100m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100m", data.wind_speed_100m));

            if (data.wind_speed_200m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200m", data.wind_speed_200m));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_100m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100m", data.wind_direction_100m));

            if (data.wind_direction_200m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200m", data.wind_direction_200m));

            if (data.wind_gusts_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m", data.wind_gusts_10m));

            if (data.cape != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cape", data.cape));

            if (data.convective_inhibition != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("convective_inhibition", data.convective_inhibition));

            if (data.total_column_integrated_water_vapour != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("total_column_integrated_water_vapour", data.total_column_integrated_water_vapour));

            if (data.vapour_pressure_deficit != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit", data.vapour_pressure_deficit));

            if (data.soil_temperature_0_to_7cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_0_to_7cm", data.soil_temperature_0_to_7cm));

            if (data.soil_temperature_7_to_28cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_7_to_28cm", data.soil_temperature_7_to_28cm));

            if (data.soil_temperature_28_to_100cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_28_to_100cm", data.soil_temperature_28_to_100cm));

            if (data.soil_temperature_100_to_255cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_temperature_100_to_255cm", data.soil_temperature_100_to_255cm));

            if (data.soil_moisture_0_to_7cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_0_to_7cm", data.soil_moisture_0_to_7cm));

            if (data.soil_moisture_28_to_100cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_28_to_100cm", data.soil_moisture_28_to_100cm));

            if (data.soil_moisture_7_to_28cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_7_to_28cm", data.soil_moisture_7_to_28cm));

            if (data.soil_moisture_100_to_255cm != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("soil_moisture_100_to_255cm", data.soil_moisture_100_to_255cm));

            if (data.temperature_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa", data.temperature_1000hPa));

            if (data.temperature_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa", data.temperature_925hPa));

            if (data.temperature_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa", data.temperature_850hPa));

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

            if (data.temperature_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa", data.temperature_50hPa));

            if (data.relative_humidity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa", data.relative_humidity_1000hPa));

            if (data.relative_humidity_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa", data.relative_humidity_925hPa));

            if (data.relative_humidity_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa", data.relative_humidity_850hPa));

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

            if (data.relative_humidity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa", data.relative_humidity_50hPa));

            if (data.cloud_cover_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_1000hPa", data.cloud_cover_1000hPa));

            if (data.cloud_cover_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_925hPa", data.cloud_cover_925hPa));

            if (data.cloud_cover_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_850hPa", data.cloud_cover_850hPa));

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

            if (data.cloud_cover_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_50hPa", data.cloud_cover_50hPa));

            if (data.wind_speed_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa", data.wind_speed_1000hPa));

            if (data.wind_speed_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa", data.wind_speed_925hPa));

            if (data.wind_speed_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa", data.wind_speed_850hPa));

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

            if (data.wind_speed_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa", data.wind_speed_50hPa));

            if (data.wind_direction_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa", data.wind_direction_1000hPa));

            if (data.wind_direction_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa", data.wind_direction_925hPa));

            if (data.wind_direction_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa", data.wind_direction_850hPa));

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

            if (data.wind_direction_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa", data.wind_direction_50hPa));

            if (data.vertical_velocity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa", data.vertical_velocity_1000hPa));

            if (data.vertical_velocity_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa", data.vertical_velocity_925hPa));

            if (data.vertical_velocity_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa", data.vertical_velocity_850hPa));

            if (data.vertical_velocity_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa", data.vertical_velocity_700hPa));

            if (data.vertical_velocity_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa", data.vertical_velocity_600hPa));

            if (data.vertical_velocity_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa", data.vertical_velocity_500hPa));

            if (data.vertical_velocity_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa", data.vertical_velocity_400hPa));

            if (data.vertical_velocity_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa", data.vertical_velocity_300hPa));

            if (data.vertical_velocity_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa", data.vertical_velocity_250hPa));

            if (data.vertical_velocity_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa", data.vertical_velocity_200hPa));

            if (data.vertical_velocity_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa", data.vertical_velocity_150hPa));

            if (data.vertical_velocity_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa", data.vertical_velocity_100hPa));

            if (data.vertical_velocity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa", data.vertical_velocity_50hPa));

            if (data.geopotential_height_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa", data.geopotential_height_1000hPa));

            if (data.geopotential_height_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa", data.geopotential_height_925hPa));

            if (data.geopotential_height_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa", data.geopotential_height_850hPa));

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

            if (data.geopotential_height_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa", data.geopotential_height_50hPa));

            return df;

        }


        private static string currentDirectory = DirectoryHelper.GetCurrentDirectory();

        public static async Task<DataFrame?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 14,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null,
                                                         bool toCsv = false,
                                                         string? filePath = null,
                                                         string? fileName = null)
        /*
         * This function is the client that retrieves and returns ECMWF AIFS Forecast from the Open-Meteo API.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=14. The number of days to retrieve forecast data for, starting from the current day. Maximum is 14 days.
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

          7) toCsv (bool) - Optional boolean flag to indicate whether to save the forecast data to a CSV file. Default is false.

          8) filePath (string) - Optional file path to save the CSV file. Default is null (current directory).

          9) fileName (string) - Optional file name for the CSV file. Default is null (auto-generated name based on latitude, longitude, and timestamp).
         *      
         * 
         * Returns
         * -------
         * 
         * The ECMWF AIFS Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {
            if (days > 14)
            {
                Console.WriteLine("The maximum number of days for the forecast is 14. Setting 'days' to 14.");
                days = 14;
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
                                    "showers" ,
                                    "snowfall" ,
                                    "runoff" ,
                                    "visibility" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "cloud_cover_low" ,
                                    "cloud_cover_mid" ,
                                    "cloud_cover_high" ,
                                    "sunshine_duration" ,
                                    "potential_evapotranspiration" ,
                                    "et0_fao_evapotranspiration" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_100m" ,
                                    "wind_speed_200m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_100m" ,
                                    "wind_direction_200m" ,
                                    "wind_gusts_10m" ,
                                    "cape" ,
                                    "convective_inhibition" ,
                                    "total_column_integrated_water_vapour" ,
                                    "vapour_pressure_deficit" ,
                                    "surface_temperature" ,
                                    "soil_temperature_0_to_7cm" ,
                                    "soil_temperature_7_to_28cm" ,
                                    "soil_temperature_28_to_100cm" ,
                                    "soil_temperature_100_to_255cm" ,
                                    "soil_moisture_0_to_7cm" ,
                                    "soil_moisture_28_to_100cm" ,
                                    "soil_moisture_7_to_28cm" ,
                                    "soil_moisture_100_to_255cm" ,
                                    "temperature_1000hPa" ,
                                    "temperature_925hPa" ,
                                    "temperature_850hPa" ,
                                    "temperature_700hPa" ,
                                    "temperature_600hPa" ,
                                    "temperature_500hPa" ,
                                    "temperature_400hPa" ,
                                    "temperature_300hPa" ,
                                    "temperature_250hPa" ,
                                    "temperature_200hPa" ,
                                    "temperature_150hPa" ,
                                    "temperature_100hPa" ,
                                    "temperature_50hPa" ,
                                    "relative_humidity_1000hPa" ,
                                    "relative_humidity_925hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "cloud_cover_1000hPa" ,
                                    "cloud_cover_925hPa" ,
                                    "cloud_cover_850hPa" ,
                                    "cloud_cover_700hPa" ,
                                    "cloud_cover_600hPa" ,
                                    "cloud_cover_500hPa" ,
                                    "cloud_cover_400hPa" ,
                                    "cloud_cover_300hPa" ,
                                    "cloud_cover_250hPa" ,
                                    "cloud_cover_200hPa" ,
                                    "cloud_cover_150hPa" ,
                                    "cloud_cover_100hPa" ,
                                    "cloud_cover_50hPa" ,
                                    "wind_speed_1000hPa" ,
                                    "wind_speed_925hPa" ,
                                    "wind_speed_850hPa" ,
                                    "wind_speed_700hPa" ,
                                    "wind_speed_600hPa" ,
                                    "wind_speed_500hPa" ,
                                    "wind_speed_400hPa" ,
                                    "wind_speed_300hPa" ,
                                    "wind_speed_250hPa" ,
                                    "wind_speed_200hPa" ,
                                    "wind_speed_150hPa" ,
                                    "wind_speed_100hPa" ,
                                    "wind_speed_50hPa" ,
                                    "wind_direction_1000hPa" ,
                                    "wind_direction_925hPa" ,
                                    "wind_direction_850hPa" ,
                                    "wind_direction_700hPa" ,
                                    "wind_direction_600hPa" ,
                                    "wind_direction_500hPa" ,
                                    "wind_direction_400hPa" ,
                                    "wind_direction_300hPa" ,
                                    "wind_direction_250hPa" ,
                                    "wind_direction_200hPa" ,
                                    "wind_direction_150hPa" ,
                                    "wind_direction_100hPa" ,
                                    "wind_direction_50hPa" ,
                                    "vertical_velocity_1000hPa" ,
                                    "vertical_velocity_925hPa" ,
                                    "vertical_velocity_850hPa" ,
                                    "vertical_velocity_700hPa" ,
                                    "vertical_velocity_600hPa" ,
                                    "vertical_velocity_500hPa" ,
                                    "vertical_velocity_400hPa" ,
                                    "vertical_velocity_300hPa" ,
                                    "vertical_velocity_250hPa" ,
                                    "vertical_velocity_200hPa" ,
                                    "vertical_velocity_150hPa" ,
                                    "vertical_velocity_100hPa" ,
                                    "vertical_velocity_50hPa" ,
                                    "geopotential_height_1000hPa" ,
                                    "geopotential_height_925hPa" ,
                                    "geopotential_height_850hPa" ,
                                    "geopotential_height_700hPa" ,
                                    "geopotential_height_600hPa" ,
                                    "geopotential_height_500hPa" ,
                                    "geopotential_height_400hPa" ,
                                    "geopotential_height_300hPa" ,
                                    "geopotential_height_250hPa" ,
                                    "geopotential_height_200hPa" ,
                                    "geopotential_height_150hPa" ,
                                    "geopotential_height_100hPa" ,
                                    "geopotential_height_50hPa" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=ecmwf_aifs025_single&forecast_days={days}" +
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

            // Deserialize the "hourly" property into our aifsParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<aifsParams>(hourlyWeatherElement.GetRawText());
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
                        fileName = $"AIFS_PointForecast_{latString}_{lonString}.csv";
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
                Console.WriteLine($"ECMWF AIFS Data Not Available At This Time");
                return null;

            }
        }
    }
}




