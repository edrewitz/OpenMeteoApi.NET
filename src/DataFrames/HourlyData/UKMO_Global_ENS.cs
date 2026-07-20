/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Variables.HourlyData.UKMO_Global_ENS;

namespace OpenMeteoApiNet.DataFrames.HourlyData.UKMO_Global_ENS
{
    public class ukmoGlobalENSDataFrame
    {
        public static DataFrame ToDataFrame(ukmoGlobalENSParams data)
        {
            /*
             * Converts the data object of type ukmoGlobalENSParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the ukmoGlobalENSParams object.
             * 
             */

            var df = new DataFrame();

            // 1. Add the time column (Strings)
            if (data.time != null)
            {
                df.Columns.Add(new StringDataFrameColumn("time", data.time));
            }

            if (data.temperature_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m", data.temperature_2m));

            if (data.temperature_2m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member01", data.temperature_2m_member01));

            if (data.temperature_2m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member02", data.temperature_2m_member02));

            if (data.temperature_2m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member03", data.temperature_2m_member03));

            if (data.temperature_2m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member04", data.temperature_2m_member04));

            if (data.temperature_2m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member05", data.temperature_2m_member05));

            if (data.temperature_2m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member06", data.temperature_2m_member06));

            if (data.temperature_2m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member07", data.temperature_2m_member07));

            if (data.temperature_2m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member08", data.temperature_2m_member08));

            if (data.temperature_2m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member09", data.temperature_2m_member09));

            if (data.temperature_2m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member10", data.temperature_2m_member10));

            if (data.temperature_2m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member11", data.temperature_2m_member11));

            if (data.temperature_2m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member12", data.temperature_2m_member12));

            if (data.temperature_2m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member13", data.temperature_2m_member13));

            if (data.temperature_2m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member14", data.temperature_2m_member14));

            if (data.temperature_2m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member15", data.temperature_2m_member15));

            if (data.temperature_2m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member16", data.temperature_2m_member16));

            if (data.temperature_2m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member17", data.temperature_2m_member17));

            if (data.relative_humidity_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m", data.relative_humidity_2m));

            if (data.relative_humidity_2m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member01", data.relative_humidity_2m_member01));

            if (data.relative_humidity_2m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member02", data.relative_humidity_2m_member02));

            if (data.relative_humidity_2m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member03", data.relative_humidity_2m_member03));

            if (data.relative_humidity_2m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member04", data.relative_humidity_2m_member04));

            if (data.relative_humidity_2m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member05", data.relative_humidity_2m_member05));

            if (data.relative_humidity_2m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member06", data.relative_humidity_2m_member06));

            if (data.relative_humidity_2m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member07", data.relative_humidity_2m_member07));

            if (data.relative_humidity_2m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member08", data.relative_humidity_2m_member08));

            if (data.relative_humidity_2m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member09", data.relative_humidity_2m_member09));

            if (data.relative_humidity_2m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member10", data.relative_humidity_2m_member10));

            if (data.relative_humidity_2m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member11", data.relative_humidity_2m_member11));

            if (data.relative_humidity_2m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member12", data.relative_humidity_2m_member12));

            if (data.relative_humidity_2m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member13", data.relative_humidity_2m_member13));

            if (data.relative_humidity_2m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member14", data.relative_humidity_2m_member14));

            if (data.relative_humidity_2m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member15", data.relative_humidity_2m_member15));

            if (data.relative_humidity_2m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member16", data.relative_humidity_2m_member16));

            if (data.relative_humidity_2m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member17", data.relative_humidity_2m_member17));

            if (data.dew_point_2m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m", data.dew_point_2m));

            if (data.dew_point_2m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member01", data.dew_point_2m_member01));

            if (data.dew_point_2m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member02", data.dew_point_2m_member02));

            if (data.dew_point_2m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member03", data.dew_point_2m_member03));

            if (data.dew_point_2m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member04", data.dew_point_2m_member04));

            if (data.dew_point_2m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member05", data.dew_point_2m_member05));

            if (data.dew_point_2m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member06", data.dew_point_2m_member06));

            if (data.dew_point_2m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member07", data.dew_point_2m_member07));

            if (data.dew_point_2m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member08", data.dew_point_2m_member08));

            if (data.dew_point_2m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member09", data.dew_point_2m_member09));

            if (data.dew_point_2m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member10", data.dew_point_2m_member10));

            if (data.dew_point_2m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member11", data.dew_point_2m_member11));

            if (data.dew_point_2m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member12", data.dew_point_2m_member12));

            if (data.dew_point_2m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member13", data.dew_point_2m_member13));

            if (data.dew_point_2m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member14", data.dew_point_2m_member14));

            if (data.dew_point_2m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member15", data.dew_point_2m_member15));

            if (data.dew_point_2m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member16", data.dew_point_2m_member16));

            if (data.dew_point_2m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member17", data.dew_point_2m_member17));

            if (data.apparent_temperature != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature", data.apparent_temperature));

            if (data.apparent_temperature_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member01", data.apparent_temperature_member01));

            if (data.apparent_temperature_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member02", data.apparent_temperature_member02));

            if (data.apparent_temperature_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member03", data.apparent_temperature_member03));

            if (data.apparent_temperature_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member04", data.apparent_temperature_member04));

            if (data.apparent_temperature_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member05", data.apparent_temperature_member05));

            if (data.apparent_temperature_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member06", data.apparent_temperature_member06));

            if (data.apparent_temperature_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member07", data.apparent_temperature_member07));

            if (data.apparent_temperature_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member08", data.apparent_temperature_member08));

            if (data.apparent_temperature_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member09", data.apparent_temperature_member09));

            if (data.apparent_temperature_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member10", data.apparent_temperature_member10));

            if (data.apparent_temperature_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member11", data.apparent_temperature_member11));

            if (data.apparent_temperature_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member12", data.apparent_temperature_member12));

            if (data.apparent_temperature_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member13", data.apparent_temperature_member13));

            if (data.apparent_temperature_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member14", data.apparent_temperature_member14));

            if (data.apparent_temperature_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member15", data.apparent_temperature_member15));

            if (data.apparent_temperature_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member16", data.apparent_temperature_member16));

            if (data.apparent_temperature_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member17", data.apparent_temperature_member17));

            if (data.snowfall != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall", data.snowfall));

            if (data.snowfall_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member01", data.snowfall_member01));

            if (data.snowfall_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member02", data.snowfall_member02));

            if (data.snowfall_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member03", data.snowfall_member03));

            if (data.snowfall_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member04", data.snowfall_member04));

            if (data.snowfall_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member05", data.snowfall_member05));

            if (data.snowfall_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member06", data.snowfall_member06));

            if (data.snowfall_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member07", data.snowfall_member07));

            if (data.snowfall_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member08", data.snowfall_member08));

            if (data.snowfall_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member09", data.snowfall_member09));

            if (data.snowfall_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member10", data.snowfall_member10));

            if (data.snowfall_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member11", data.snowfall_member11));

            if (data.snowfall_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member12", data.snowfall_member12));

            if (data.snowfall_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member13", data.snowfall_member13));

            if (data.snowfall_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member14", data.snowfall_member14));

            if (data.snowfall_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member15", data.snowfall_member15));

            if (data.snowfall_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member16", data.snowfall_member16));

            if (data.snowfall_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member17", data.snowfall_member17));

            if (data.rain != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain", data.rain));

            if (data.rain_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member01", data.rain_member01));

            if (data.rain_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member02", data.rain_member02));

            if (data.rain_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member03", data.rain_member03));

            if (data.rain_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member04", data.rain_member04));

            if (data.rain_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member05", data.rain_member05));

            if (data.rain_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member06", data.rain_member06));

            if (data.rain_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member07", data.rain_member07));

            if (data.rain_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member08", data.rain_member08));

            if (data.rain_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member09", data.rain_member09));

            if (data.rain_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member10", data.rain_member10));

            if (data.rain_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member11", data.rain_member11));

            if (data.rain_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member12", data.rain_member12));

            if (data.rain_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member13", data.rain_member13));

            if (data.rain_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member14", data.rain_member14));

            if (data.rain_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member15", data.rain_member15));

            if (data.rain_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member16", data.rain_member16));

            if (data.rain_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member17", data.rain_member17));

            if (data.precipitation != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation", data.precipitation));

            if (data.precipitation_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member01", data.precipitation_member01));

            if (data.precipitation_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member02", data.precipitation_member02));

            if (data.precipitation_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member03", data.precipitation_member03));

            if (data.precipitation_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member04", data.precipitation_member04));

            if (data.precipitation_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member05", data.precipitation_member05));

            if (data.precipitation_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member06", data.precipitation_member06));

            if (data.precipitation_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member07", data.precipitation_member07));

            if (data.precipitation_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member08", data.precipitation_member08));

            if (data.precipitation_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member09", data.precipitation_member09));

            if (data.precipitation_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member10", data.precipitation_member10));

            if (data.precipitation_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member11", data.precipitation_member11));

            if (data.precipitation_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member12", data.precipitation_member12));

            if (data.precipitation_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member13", data.precipitation_member13));

            if (data.precipitation_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member14", data.precipitation_member14));

            if (data.precipitation_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member15", data.precipitation_member15));

            if (data.precipitation_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member16", data.precipitation_member16));

            if (data.precipitation_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member17", data.precipitation_member17));

            if (data.weather_code != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code", data.weather_code));

            if (data.weather_code_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member01", data.weather_code_member01));

            if (data.weather_code_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member02", data.weather_code_member02));

            if (data.weather_code_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member03", data.weather_code_member03));

            if (data.weather_code_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member04", data.weather_code_member04));

            if (data.weather_code_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member05", data.weather_code_member05));

            if (data.weather_code_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member06", data.weather_code_member06));

            if (data.weather_code_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member07", data.weather_code_member07));

            if (data.weather_code_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member08", data.weather_code_member08));

            if (data.weather_code_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member09", data.weather_code_member09));

            if (data.weather_code_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member10", data.weather_code_member10));

            if (data.weather_code_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member11", data.weather_code_member11));

            if (data.weather_code_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member12", data.weather_code_member12));

            if (data.weather_code_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member13", data.weather_code_member13));

            if (data.weather_code_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member14", data.weather_code_member14));

            if (data.weather_code_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member15", data.weather_code_member15));

            if (data.weather_code_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member16", data.weather_code_member16));

            if (data.weather_code_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member17", data.weather_code_member17));

            if (data.pressure_msl != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl", data.pressure_msl));

            if (data.pressure_msl_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member01", data.pressure_msl_member01));

            if (data.pressure_msl_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member02", data.pressure_msl_member02));

            if (data.pressure_msl_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member03", data.pressure_msl_member03));

            if (data.pressure_msl_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member04", data.pressure_msl_member04));

            if (data.pressure_msl_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member05", data.pressure_msl_member05));

            if (data.pressure_msl_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member06", data.pressure_msl_member06));

            if (data.pressure_msl_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member07", data.pressure_msl_member07));

            if (data.pressure_msl_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member08", data.pressure_msl_member08));

            if (data.pressure_msl_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member09", data.pressure_msl_member09));

            if (data.pressure_msl_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member10", data.pressure_msl_member10));

            if (data.pressure_msl_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member11", data.pressure_msl_member11));

            if (data.pressure_msl_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member12", data.pressure_msl_member12));

            if (data.pressure_msl_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member13", data.pressure_msl_member13));

            if (data.pressure_msl_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member14", data.pressure_msl_member14));

            if (data.pressure_msl_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member15", data.pressure_msl_member15));

            if (data.pressure_msl_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member16", data.pressure_msl_member16));

            if (data.pressure_msl_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member17", data.pressure_msl_member17));

            if (data.surface_pressure != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure", data.surface_pressure));

            if (data.surface_pressure_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member01", data.surface_pressure_member01));

            if (data.surface_pressure_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member02", data.surface_pressure_member02));

            if (data.surface_pressure_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member03", data.surface_pressure_member03));

            if (data.surface_pressure_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member04", data.surface_pressure_member04));

            if (data.surface_pressure_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member05", data.surface_pressure_member05));

            if (data.surface_pressure_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member06", data.surface_pressure_member06));

            if (data.surface_pressure_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member07", data.surface_pressure_member07));

            if (data.surface_pressure_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member08", data.surface_pressure_member08));

            if (data.surface_pressure_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member09", data.surface_pressure_member09));

            if (data.surface_pressure_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member10", data.surface_pressure_member10));

            if (data.surface_pressure_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member11", data.surface_pressure_member11));

            if (data.surface_pressure_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member12", data.surface_pressure_member12));

            if (data.surface_pressure_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member13", data.surface_pressure_member13));

            if (data.surface_pressure_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member14", data.surface_pressure_member14));

            if (data.surface_pressure_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member15", data.surface_pressure_member15));

            if (data.surface_pressure_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member16", data.surface_pressure_member16));

            if (data.surface_pressure_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member17", data.surface_pressure_member17));

            if (data.cloud_cover != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover", data.cloud_cover));

            if (data.cloud_cover_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member01", data.cloud_cover_member01));

            if (data.cloud_cover_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member02", data.cloud_cover_member02));

            if (data.cloud_cover_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member03", data.cloud_cover_member03));

            if (data.cloud_cover_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member04", data.cloud_cover_member04));

            if (data.cloud_cover_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member05", data.cloud_cover_member05));

            if (data.cloud_cover_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member06", data.cloud_cover_member06));

            if (data.cloud_cover_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member07", data.cloud_cover_member07));

            if (data.cloud_cover_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member08", data.cloud_cover_member08));

            if (data.cloud_cover_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member09", data.cloud_cover_member09));

            if (data.cloud_cover_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member10", data.cloud_cover_member10));

            if (data.cloud_cover_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member11", data.cloud_cover_member11));

            if (data.cloud_cover_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member12", data.cloud_cover_member12));

            if (data.cloud_cover_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member13", data.cloud_cover_member13));

            if (data.cloud_cover_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member14", data.cloud_cover_member14));

            if (data.cloud_cover_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member15", data.cloud_cover_member15));

            if (data.cloud_cover_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member16", data.cloud_cover_member16));

            if (data.cloud_cover_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member17", data.cloud_cover_member17));

            if (data.visibility != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility", data.visibility));

            if (data.visibility_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member01", data.visibility_member01));

            if (data.visibility_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member02", data.visibility_member02));

            if (data.visibility_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member03", data.visibility_member03));

            if (data.visibility_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member04", data.visibility_member04));

            if (data.visibility_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member05", data.visibility_member05));

            if (data.visibility_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member06", data.visibility_member06));

            if (data.visibility_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member07", data.visibility_member07));

            if (data.visibility_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member08", data.visibility_member08));

            if (data.visibility_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member09", data.visibility_member09));

            if (data.visibility_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member10", data.visibility_member10));

            if (data.visibility_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member11", data.visibility_member11));

            if (data.visibility_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member12", data.visibility_member12));

            if (data.visibility_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member13", data.visibility_member13));

            if (data.visibility_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member14", data.visibility_member14));

            if (data.visibility_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member15", data.visibility_member15));

            if (data.visibility_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member16", data.visibility_member16));

            if (data.visibility_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility_member17", data.visibility_member17));

            if (data.et0_fao_evapotranspiration != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration", data.et0_fao_evapotranspiration));

            if (data.et0_fao_evapotranspiration_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member01", data.et0_fao_evapotranspiration_member01));

            if (data.et0_fao_evapotranspiration_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member02", data.et0_fao_evapotranspiration_member02));

            if (data.et0_fao_evapotranspiration_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member03", data.et0_fao_evapotranspiration_member03));

            if (data.et0_fao_evapotranspiration_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member04", data.et0_fao_evapotranspiration_member04));

            if (data.et0_fao_evapotranspiration_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member05", data.et0_fao_evapotranspiration_member05));

            if (data.et0_fao_evapotranspiration_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member06", data.et0_fao_evapotranspiration_member06));

            if (data.et0_fao_evapotranspiration_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member07", data.et0_fao_evapotranspiration_member07));

            if (data.et0_fao_evapotranspiration_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member08", data.et0_fao_evapotranspiration_member08));

            if (data.et0_fao_evapotranspiration_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member09", data.et0_fao_evapotranspiration_member09));

            if (data.et0_fao_evapotranspiration_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member10", data.et0_fao_evapotranspiration_member10));

            if (data.et0_fao_evapotranspiration_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member11", data.et0_fao_evapotranspiration_member11));

            if (data.et0_fao_evapotranspiration_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member12", data.et0_fao_evapotranspiration_member12));

            if (data.et0_fao_evapotranspiration_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member13", data.et0_fao_evapotranspiration_member13));

            if (data.et0_fao_evapotranspiration_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member14", data.et0_fao_evapotranspiration_member14));

            if (data.et0_fao_evapotranspiration_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member15", data.et0_fao_evapotranspiration_member15));

            if (data.et0_fao_evapotranspiration_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member16", data.et0_fao_evapotranspiration_member16));

            if (data.et0_fao_evapotranspiration_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member17", data.et0_fao_evapotranspiration_member17));

            if (data.vapour_pressure_deficit != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit", data.vapour_pressure_deficit));

            if (data.vapour_pressure_deficit_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member01", data.vapour_pressure_deficit_member01));

            if (data.vapour_pressure_deficit_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member02", data.vapour_pressure_deficit_member02));

            if (data.vapour_pressure_deficit_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member03", data.vapour_pressure_deficit_member03));

            if (data.vapour_pressure_deficit_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member04", data.vapour_pressure_deficit_member04));

            if (data.vapour_pressure_deficit_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member05", data.vapour_pressure_deficit_member05));

            if (data.vapour_pressure_deficit_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member06", data.vapour_pressure_deficit_member06));

            if (data.vapour_pressure_deficit_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member07", data.vapour_pressure_deficit_member07));

            if (data.vapour_pressure_deficit_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member08", data.vapour_pressure_deficit_member08));

            if (data.vapour_pressure_deficit_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member09", data.vapour_pressure_deficit_member09));

            if (data.vapour_pressure_deficit_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member10", data.vapour_pressure_deficit_member10));

            if (data.vapour_pressure_deficit_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member11", data.vapour_pressure_deficit_member11));

            if (data.vapour_pressure_deficit_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member12", data.vapour_pressure_deficit_member12));

            if (data.vapour_pressure_deficit_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member13", data.vapour_pressure_deficit_member13));

            if (data.vapour_pressure_deficit_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member14", data.vapour_pressure_deficit_member14));

            if (data.vapour_pressure_deficit_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member15", data.vapour_pressure_deficit_member15));

            if (data.vapour_pressure_deficit_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member16", data.vapour_pressure_deficit_member16));

            if (data.vapour_pressure_deficit_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member17", data.vapour_pressure_deficit_member17));

            if (data.wind_speed_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m", data.wind_speed_10m));

            if (data.wind_speed_10m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member01", data.wind_speed_10m_member01));

            if (data.wind_speed_10m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member02", data.wind_speed_10m_member02));

            if (data.wind_speed_10m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member03", data.wind_speed_10m_member03));

            if (data.wind_speed_10m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member04", data.wind_speed_10m_member04));

            if (data.wind_speed_10m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member05", data.wind_speed_10m_member05));

            if (data.wind_speed_10m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member06", data.wind_speed_10m_member06));

            if (data.wind_speed_10m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member07", data.wind_speed_10m_member07));

            if (data.wind_speed_10m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member08", data.wind_speed_10m_member08));

            if (data.wind_speed_10m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member09", data.wind_speed_10m_member09));

            if (data.wind_speed_10m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member10", data.wind_speed_10m_member10));

            if (data.wind_speed_10m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member11", data.wind_speed_10m_member11));

            if (data.wind_speed_10m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member12", data.wind_speed_10m_member12));

            if (data.wind_speed_10m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member13", data.wind_speed_10m_member13));

            if (data.wind_speed_10m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member14", data.wind_speed_10m_member14));

            if (data.wind_speed_10m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member15", data.wind_speed_10m_member15));

            if (data.wind_speed_10m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member16", data.wind_speed_10m_member16));

            if (data.wind_speed_10m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member17", data.wind_speed_10m_member17));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_10m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member01", data.wind_direction_10m_member01));

            if (data.wind_direction_10m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member02", data.wind_direction_10m_member02));

            if (data.wind_direction_10m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member03", data.wind_direction_10m_member03));

            if (data.wind_direction_10m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member04", data.wind_direction_10m_member04));

            if (data.wind_direction_10m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member05", data.wind_direction_10m_member05));

            if (data.wind_direction_10m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member06", data.wind_direction_10m_member06));

            if (data.wind_direction_10m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member07", data.wind_direction_10m_member07));

            if (data.wind_direction_10m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member08", data.wind_direction_10m_member08));

            if (data.wind_direction_10m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member09", data.wind_direction_10m_member09));

            if (data.wind_direction_10m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member10", data.wind_direction_10m_member10));

            if (data.wind_direction_10m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member11", data.wind_direction_10m_member11));

            if (data.wind_direction_10m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member12", data.wind_direction_10m_member12));

            if (data.wind_direction_10m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member13", data.wind_direction_10m_member13));

            if (data.wind_direction_10m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member14", data.wind_direction_10m_member14));

            if (data.wind_direction_10m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member15", data.wind_direction_10m_member15));

            if (data.wind_direction_10m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member16", data.wind_direction_10m_member16));

            if (data.wind_direction_10m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m_member17", data.wind_direction_10m_member17));

            if (data.wind_gusts_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m", data.wind_gusts_10m));

            if (data.wind_gusts_10m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member01", data.wind_gusts_10m_member01));

            if (data.wind_gusts_10m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member02", data.wind_gusts_10m_member02));

            if (data.wind_gusts_10m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member03", data.wind_gusts_10m_member03));

            if (data.wind_gusts_10m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member04", data.wind_gusts_10m_member04));

            if (data.wind_gusts_10m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member05", data.wind_gusts_10m_member05));

            if (data.wind_gusts_10m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member06", data.wind_gusts_10m_member06));

            if (data.wind_gusts_10m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member07", data.wind_gusts_10m_member07));

            if (data.wind_gusts_10m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member08", data.wind_gusts_10m_member08));

            if (data.wind_gusts_10m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member09", data.wind_gusts_10m_member09));

            if (data.wind_gusts_10m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member10", data.wind_gusts_10m_member10));

            if (data.wind_gusts_10m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member11", data.wind_gusts_10m_member11));

            if (data.wind_gusts_10m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member12", data.wind_gusts_10m_member12));

            if (data.wind_gusts_10m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member13", data.wind_gusts_10m_member13));

            if (data.wind_gusts_10m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member14", data.wind_gusts_10m_member14));

            if (data.wind_gusts_10m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member15", data.wind_gusts_10m_member15));

            if (data.wind_gusts_10m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member16", data.wind_gusts_10m_member16));

            if (data.wind_gusts_10m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member17", data.wind_gusts_10m_member17));

            if (data.surface_temperature != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature", data.surface_temperature));

            if (data.surface_temperature_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member01", data.surface_temperature_member01));

            if (data.surface_temperature_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member02", data.surface_temperature_member02));

            if (data.surface_temperature_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member03", data.surface_temperature_member03));

            if (data.surface_temperature_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member04", data.surface_temperature_member04));

            if (data.surface_temperature_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member05", data.surface_temperature_member05));

            if (data.surface_temperature_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member06", data.surface_temperature_member06));

            if (data.surface_temperature_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member07", data.surface_temperature_member07));

            if (data.surface_temperature_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member08", data.surface_temperature_member08));

            if (data.surface_temperature_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member09", data.surface_temperature_member09));

            if (data.surface_temperature_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member10", data.surface_temperature_member10));

            if (data.surface_temperature_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member11", data.surface_temperature_member11));

            if (data.surface_temperature_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member12", data.surface_temperature_member12));

            if (data.surface_temperature_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member13", data.surface_temperature_member13));

            if (data.surface_temperature_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member14", data.surface_temperature_member14));

            if (data.surface_temperature_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member15", data.surface_temperature_member15));

            if (data.surface_temperature_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member16", data.surface_temperature_member16));

            if (data.surface_temperature_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_temperature_member17", data.surface_temperature_member17));

            return df;

        }
    }
}
