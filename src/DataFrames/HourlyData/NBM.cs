/*
 * OpenMeteoApiNet - A C# library for accessing the Open-Meteo API.
 * 
 * (C) Eric J. Drewitz 2026
 */

using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Variables.HourlyData.NBM;

namespace OpenMeteoApiNet.DataFrames.HourlyData.NBM
{
    public class  nbmDataFrame
    {
        public static DataFrame ToDataFrame(nbmParams data)
        {
            /*
             * Converts the data object of type nbmParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the nbmParams object.
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

            if (data.cape != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cape", data.cape));

            if (data.precipitation != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation", data.precipitation));

            if (data.snowfall != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall", data.snowfall));

            if (data.surface_pressure != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure", data.surface_pressure));

            if (data.visibility != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("visibility", data.visibility));

            if (data.wind_speed_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m", data.wind_speed_10m));

            if (data.wind_speed_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m", data.wind_speed_80m));

            if (data.wind_direction_10m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_10m", data.wind_direction_10m));

            if (data.wind_direction_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_80m", data.wind_direction_80m));


            return df;

        }
    }
}
