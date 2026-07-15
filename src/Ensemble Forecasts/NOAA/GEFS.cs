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

namespace OpenMeteoApiNet.EnsembleForecasts.NOAA.GEFS
{
    public class gefsParams
    {
        public string?[]? time { get; set; }
        public double?[]? temperature_2m { get; set; }
        public double?[]? temperature_2m_member01 { get; set; }
        public double?[]? temperature_2m_member02 { get; set; }
        public double?[]? temperature_2m_member03 { get; set; }
        public double?[]? temperature_2m_member04 { get; set; }
        public double?[]? temperature_2m_member05 { get; set; }
        public double?[]? temperature_2m_member06 { get; set; }
        public double?[]? temperature_2m_member07 { get; set; }
        public double?[]? temperature_2m_member08 { get; set; }
        public double?[]? temperature_2m_member09 { get; set; }
        public double?[]? temperature_2m_member10 { get; set; }
        public double?[]? temperature_2m_member11 { get; set; }
        public double?[]? temperature_2m_member12 { get; set; }
        public double?[]? temperature_2m_member13 { get; set; }
        public double?[]? temperature_2m_member14 { get; set; }
        public double?[]? temperature_2m_member15 { get; set; }
        public double?[]? temperature_2m_member16 { get; set; }
        public double?[]? temperature_2m_member17 { get; set; }
        public double?[]? temperature_2m_member18 { get; set; }
        public double?[]? temperature_2m_member19 { get; set; }
        public double?[]? temperature_2m_member20 { get; set; }
        public double?[]? temperature_2m_member21 { get; set; }
        public double?[]? temperature_2m_member22 { get; set; }
        public double?[]? temperature_2m_member23 { get; set; }
        public double?[]? temperature_2m_member24 { get; set; }
        public double?[]? temperature_2m_member25 { get; set; }
        public double?[]? temperature_2m_member26 { get; set; }
        public double?[]? temperature_2m_member27 { get; set; }
        public double?[]? temperature_2m_member28 { get; set; }
        public double?[]? temperature_2m_member29 { get; set; }
        public double?[]? temperature_2m_member30 { get; set; }
        public double?[]? cloud_cover { get; set; }
        public double?[]? cloud_cover_member01 { get; set; }
        public double?[]? cloud_cover_member02 { get; set; }
        public double?[]? cloud_cover_member03 { get; set; }
        public double?[]? cloud_cover_member04 { get; set; }
        public double?[]? cloud_cover_member05 { get; set; }
        public double?[]? cloud_cover_member06 { get; set; }
        public double?[]? cloud_cover_member07 { get; set; }
        public double?[]? cloud_cover_member08 { get; set; }
        public double?[]? cloud_cover_member09 { get; set; }
        public double?[]? cloud_cover_member10 { get; set; }
        public double?[]? cloud_cover_member11 { get; set; }
        public double?[]? cloud_cover_member12 { get; set; }
        public double?[]? cloud_cover_member13 { get; set; }
        public double?[]? cloud_cover_member14 { get; set; }
        public double?[]? cloud_cover_member15 { get; set; }
        public double?[]? cloud_cover_member16 { get; set; }
        public double?[]? cloud_cover_member17 { get; set; }
        public double?[]? cloud_cover_member18 { get; set; }
        public double?[]? cloud_cover_member19 { get; set; }
        public double?[]? cloud_cover_member20 { get; set; }
        public double?[]? cloud_cover_member21 { get; set; }
        public double?[]? cloud_cover_member22 { get; set; }
        public double?[]? cloud_cover_member23 { get; set; }
        public double?[]? cloud_cover_member24 { get; set; }
        public double?[]? cloud_cover_member25 { get; set; }
        public double?[]? cloud_cover_member26 { get; set; }
        public double?[]? cloud_cover_member27 { get; set; }
        public double?[]? cloud_cover_member28 { get; set; }
        public double?[]? cloud_cover_member29 { get; set; }
        public double?[]? cloud_cover_member30 { get; set; }
        public double?[]? cloud_cover_low { get; set; }
        public double?[]? cloud_cover_low_member01 { get; set; }
        public double?[]? cloud_cover_low_member02 { get; set; }
        public double?[]? cloud_cover_low_member03 { get; set; }
        public double?[]? cloud_cover_low_member04 { get; set; }
        public double?[]? cloud_cover_low_member05 { get; set; }
        public double?[]? cloud_cover_low_member06 { get; set; }
        public double?[]? cloud_cover_low_member07 { get; set; }
        public double?[]? cloud_cover_low_member08 { get; set; }
        public double?[]? cloud_cover_low_member09 { get; set; }
        public double?[]? cloud_cover_low_member10 { get; set; }
        public double?[]? cloud_cover_low_member11 { get; set; }
        public double?[]? cloud_cover_low_member12 { get; set; }
        public double?[]? cloud_cover_low_member13 { get; set; }
        public double?[]? cloud_cover_low_member14 { get; set; }
        public double?[]? cloud_cover_low_member15 { get; set; }
        public double?[]? cloud_cover_low_member16 { get; set; }
        public double?[]? cloud_cover_low_member17 { get; set; }
        public double?[]? cloud_cover_low_member18 { get; set; }
        public double?[]? cloud_cover_low_member19 { get; set; }
        public double?[]? cloud_cover_low_member20 { get; set; }
        public double?[]? cloud_cover_low_member21 { get; set; }
        public double?[]? cloud_cover_low_member22 { get; set; }
        public double?[]? cloud_cover_low_member23 { get; set; }
        public double?[]? cloud_cover_low_member24 { get; set; }
        public double?[]? cloud_cover_low_member25 { get; set; }
        public double?[]? cloud_cover_low_member26 { get; set; }
        public double?[]? cloud_cover_low_member27 { get; set; }
        public double?[]? cloud_cover_low_member28 { get; set; }
        public double?[]? cloud_cover_low_member29 { get; set; }
        public double?[]? cloud_cover_low_member30 { get; set; }
        public double?[]? cloud_cover_mid { get; set; }
        public double?[]? cloud_cover_mid_member01 { get; set; }
        public double?[]? cloud_cover_mid_member02 { get; set; }
        public double?[]? cloud_cover_mid_member03 { get; set; }
        public double?[]? cloud_cover_mid_member04 { get; set; }
        public double?[]? cloud_cover_mid_member05 { get; set; }
        public double?[]? cloud_cover_mid_member06 { get; set; }
        public double?[]? cloud_cover_mid_member07 { get; set; }
        public double?[]? cloud_cover_mid_member08 { get; set; }
        public double?[]? cloud_cover_mid_member09 { get; set; }
        public double?[]? cloud_cover_mid_member10 { get; set; }
        public double?[]? cloud_cover_mid_member11 { get; set; }
        public double?[]? cloud_cover_mid_member12 { get; set; }
        public double?[]? cloud_cover_mid_member13 { get; set; }
        public double?[]? cloud_cover_mid_member14 { get; set; }
        public double?[]? cloud_cover_mid_member15 { get; set; }
        public double?[]? cloud_cover_mid_member16 { get; set; }
        public double?[]? cloud_cover_mid_member17 { get; set; }
        public double?[]? cloud_cover_mid_member18 { get; set; }
        public double?[]? cloud_cover_mid_member19 { get; set; }
        public double?[]? cloud_cover_mid_member20 { get; set; }
        public double?[]? cloud_cover_mid_member21 { get; set; }
        public double?[]? cloud_cover_mid_member22 { get; set; }
        public double?[]? cloud_cover_mid_member23 { get; set; }
        public double?[]? cloud_cover_mid_member24 { get; set; }
        public double?[]? cloud_cover_mid_member25 { get; set; }
        public double?[]? cloud_cover_mid_member26 { get; set; }
        public double?[]? cloud_cover_mid_member27 { get; set; }
        public double?[]? cloud_cover_mid_member28 { get; set; }
        public double?[]? cloud_cover_mid_member29 { get; set; }
        public double?[]? cloud_cover_mid_member30 { get; set; }
        public double?[]? cloud_cover_high { get; set; }
        public double?[]? cloud_cover_high_member01 { get; set; }
        public double?[]? cloud_cover_high_member02 { get; set; }
        public double?[]? cloud_cover_high_member03 { get; set; }
        public double?[]? cloud_cover_high_member04 { get; set; }
        public double?[]? cloud_cover_high_member05 { get; set; }
        public double?[]? cloud_cover_high_member06 { get; set; }
        public double?[]? cloud_cover_high_member07 { get; set; }
        public double?[]? cloud_cover_high_member08 { get; set; }
        public double?[]? cloud_cover_high_member09 { get; set; }
        public double?[]? cloud_cover_high_member10 { get; set; }
        public double?[]? cloud_cover_high_member11 { get; set; }
        public double?[]? cloud_cover_high_member12 { get; set; }
        public double?[]? cloud_cover_high_member13 { get; set; }
        public double?[]? cloud_cover_high_member14 { get; set; }
        public double?[]? cloud_cover_high_member15 { get; set; }
        public double?[]? cloud_cover_high_member16 { get; set; }
        public double?[]? cloud_cover_high_member17 { get; set; }
        public double?[]? cloud_cover_high_member18 { get; set; }
        public double?[]? cloud_cover_high_member19 { get; set; }
        public double?[]? cloud_cover_high_member20 { get; set; }
        public double?[]? cloud_cover_high_member21 { get; set; }
        public double?[]? cloud_cover_high_member22 { get; set; }
        public double?[]? cloud_cover_high_member23 { get; set; }
        public double?[]? cloud_cover_high_member24 { get; set; }
        public double?[]? cloud_cover_high_member25 { get; set; }
        public double?[]? cloud_cover_high_member26 { get; set; }
        public double?[]? cloud_cover_high_member27 { get; set; }
        public double?[]? cloud_cover_high_member28 { get; set; }
        public double?[]? cloud_cover_high_member29 { get; set; }
        public double?[]? cloud_cover_high_member30 { get; set; }
        public double?[]? precipitation { get; set; }
        public double?[]? precipitation_member01 { get; set; }
        public double?[]? precipitation_member02 { get; set; }
        public double?[]? precipitation_member03 { get; set; }
        public double?[]? precipitation_member04 { get; set; }
        public double?[]? precipitation_member05 { get; set; }
        public double?[]? precipitation_member06 { get; set; }
        public double?[]? precipitation_member07 { get; set; }
        public double?[]? precipitation_member08 { get; set; }
        public double?[]? precipitation_member09 { get; set; }
        public double?[]? precipitation_member10 { get; set; }
        public double?[]? precipitation_member11 { get; set; }
        public double?[]? precipitation_member12 { get; set; }
        public double?[]? precipitation_member13 { get; set; }
        public double?[]? precipitation_member14 { get; set; }
        public double?[]? precipitation_member15 { get; set; }
        public double?[]? precipitation_member16 { get; set; }
        public double?[]? precipitation_member17 { get; set; }
        public double?[]? precipitation_member18 { get; set; }
        public double?[]? precipitation_member19 { get; set; }
        public double?[]? precipitation_member20 { get; set; }
        public double?[]? precipitation_member21 { get; set; }
        public double?[]? precipitation_member22 { get; set; }
        public double?[]? precipitation_member23 { get; set; }
        public double?[]? precipitation_member24 { get; set; }
        public double?[]? precipitation_member25 { get; set; }
        public double?[]? precipitation_member26 { get; set; }
        public double?[]? precipitation_member27 { get; set; }
        public double?[]? precipitation_member28 { get; set; }
        public double?[]? precipitation_member29 { get; set; }
        public double?[]? precipitation_member30 { get; set; }
        public double?[]? pressure_msl { get; set; }
        public double?[]? pressure_msl_member01 { get; set; }
        public double?[]? pressure_msl_member02 { get; set; }
        public double?[]? pressure_msl_member03 { get; set; }
        public double?[]? pressure_msl_member04 { get; set; }
        public double?[]? pressure_msl_member05 { get; set; }
        public double?[]? pressure_msl_member06 { get; set; }
        public double?[]? pressure_msl_member07 { get; set; }
        public double?[]? pressure_msl_member08 { get; set; }
        public double?[]? pressure_msl_member09 { get; set; }
        public double?[]? pressure_msl_member10 { get; set; }
        public double?[]? pressure_msl_member11 { get; set; }
        public double?[]? pressure_msl_member12 { get; set; }
        public double?[]? pressure_msl_member13 { get; set; }
        public double?[]? pressure_msl_member14 { get; set; }
        public double?[]? pressure_msl_member15 { get; set; }
        public double?[]? pressure_msl_member16 { get; set; }
        public double?[]? pressure_msl_member17 { get; set; }
        public double?[]? pressure_msl_member18 { get; set; }
        public double?[]? pressure_msl_member19 { get; set; }
        public double?[]? pressure_msl_member20 { get; set; }
        public double?[]? pressure_msl_member21 { get; set; }
        public double?[]? pressure_msl_member22 { get; set; }
        public double?[]? pressure_msl_member23 { get; set; }
        public double?[]? pressure_msl_member24 { get; set; }
        public double?[]? pressure_msl_member25 { get; set; }
        public double?[]? pressure_msl_member26 { get; set; }
        public double?[]? pressure_msl_member27 { get; set; }
        public double?[]? pressure_msl_member28 { get; set; }
        public double?[]? pressure_msl_member29 { get; set; }
        public double?[]? pressure_msl_member30 { get; set; }
        public double?[]? temperature_1000hPa { get; set; }
        public double?[]? temperature_1000hPa_member01 { get; set; }
        public double?[]? temperature_1000hPa_member02 { get; set; }
        public double?[]? temperature_1000hPa_member03 { get; set; }
        public double?[]? temperature_1000hPa_member04 { get; set; }
        public double?[]? temperature_1000hPa_member05 { get; set; }
        public double?[]? temperature_1000hPa_member06 { get; set; }
        public double?[]? temperature_1000hPa_member07 { get; set; }
        public double?[]? temperature_1000hPa_member08 { get; set; }
        public double?[]? temperature_1000hPa_member09 { get; set; }
        public double?[]? temperature_1000hPa_member10 { get; set; }
        public double?[]? temperature_1000hPa_member11 { get; set; }
        public double?[]? temperature_1000hPa_member12 { get; set; }
        public double?[]? temperature_1000hPa_member13 { get; set; }
        public double?[]? temperature_1000hPa_member14 { get; set; }
        public double?[]? temperature_1000hPa_member15 { get; set; }
        public double?[]? temperature_1000hPa_member16 { get; set; }
        public double?[]? temperature_1000hPa_member17 { get; set; }
        public double?[]? temperature_1000hPa_member18 { get; set; }
        public double?[]? temperature_1000hPa_member19 { get; set; }
        public double?[]? temperature_1000hPa_member20 { get; set; }
        public double?[]? temperature_1000hPa_member21 { get; set; }
        public double?[]? temperature_1000hPa_member22 { get; set; }
        public double?[]? temperature_1000hPa_member23 { get; set; }
        public double?[]? temperature_1000hPa_member24 { get; set; }
        public double?[]? temperature_1000hPa_member25 { get; set; }
        public double?[]? temperature_1000hPa_member26 { get; set; }
        public double?[]? temperature_1000hPa_member27 { get; set; }
        public double?[]? temperature_1000hPa_member28 { get; set; }
        public double?[]? temperature_1000hPa_member29 { get; set; }
        public double?[]? temperature_1000hPa_member30 { get; set; }
        public double?[]? temperature_925hPa { get; set; }
        public double?[]? temperature_925hPa_member01 { get; set; }
        public double?[]? temperature_925hPa_member02 { get; set; }
        public double?[]? temperature_925hPa_member03 { get; set; }
        public double?[]? temperature_925hPa_member04 { get; set; }
        public double?[]? temperature_925hPa_member05 { get; set; }
        public double?[]? temperature_925hPa_member06 { get; set; }
        public double?[]? temperature_925hPa_member07 { get; set; }
        public double?[]? temperature_925hPa_member08 { get; set; }
        public double?[]? temperature_925hPa_member09 { get; set; }
        public double?[]? temperature_925hPa_member10 { get; set; }
        public double?[]? temperature_925hPa_member11 { get; set; }
        public double?[]? temperature_925hPa_member12 { get; set; }
        public double?[]? temperature_925hPa_member13 { get; set; }
        public double?[]? temperature_925hPa_member14 { get; set; }
        public double?[]? temperature_925hPa_member15 { get; set; }
        public double?[]? temperature_925hPa_member16 { get; set; }
        public double?[]? temperature_925hPa_member17 { get; set; }
        public double?[]? temperature_925hPa_member18 { get; set; }
        public double?[]? temperature_925hPa_member19 { get; set; }
        public double?[]? temperature_925hPa_member20 { get; set; }
        public double?[]? temperature_925hPa_member21 { get; set; }
        public double?[]? temperature_925hPa_member22 { get; set; }
        public double?[]? temperature_925hPa_member23 { get; set; }
        public double?[]? temperature_925hPa_member24 { get; set; }
        public double?[]? temperature_925hPa_member25 { get; set; }
        public double?[]? temperature_925hPa_member26 { get; set; }
        public double?[]? temperature_925hPa_member27 { get; set; }
        public double?[]? temperature_925hPa_member28 { get; set; }
        public double?[]? temperature_925hPa_member29 { get; set; }
        public double?[]? temperature_925hPa_member30 { get; set; }
        public double?[]? temperature_850hPa { get; set; }
        public double?[]? temperature_850hPa_member01 { get; set; }
        public double?[]? temperature_850hPa_member02 { get; set; }
        public double?[]? temperature_850hPa_member03 { get; set; }
        public double?[]? temperature_850hPa_member04 { get; set; }
        public double?[]? temperature_850hPa_member05 { get; set; }
        public double?[]? temperature_850hPa_member06 { get; set; }
        public double?[]? temperature_850hPa_member07 { get; set; }
        public double?[]? temperature_850hPa_member08 { get; set; }
        public double?[]? temperature_850hPa_member09 { get; set; }
        public double?[]? temperature_850hPa_member10 { get; set; }
        public double?[]? temperature_850hPa_member11 { get; set; }
        public double?[]? temperature_850hPa_member12 { get; set; }
        public double?[]? temperature_850hPa_member13 { get; set; }
        public double?[]? temperature_850hPa_member14 { get; set; }
        public double?[]? temperature_850hPa_member15 { get; set; }
        public double?[]? temperature_850hPa_member16 { get; set; }
        public double?[]? temperature_850hPa_member17 { get; set; }
        public double?[]? temperature_850hPa_member18 { get; set; }
        public double?[]? temperature_850hPa_member19 { get; set; }
        public double?[]? temperature_850hPa_member20 { get; set; }
        public double?[]? temperature_850hPa_member21 { get; set; }
        public double?[]? temperature_850hPa_member22 { get; set; }
        public double?[]? temperature_850hPa_member23 { get; set; }
        public double?[]? temperature_850hPa_member24 { get; set; }
        public double?[]? temperature_850hPa_member25 { get; set; }
        public double?[]? temperature_850hPa_member26 { get; set; }
        public double?[]? temperature_850hPa_member27 { get; set; }
        public double?[]? temperature_850hPa_member28 { get; set; }
        public double?[]? temperature_850hPa_member29 { get; set; }
        public double?[]? temperature_850hPa_member30 { get; set; }
        public double?[]? temperature_700hPa { get; set; }
        public double?[]? temperature_700hPa_member01 { get; set; }
        public double?[]? temperature_700hPa_member02 { get; set; }
        public double?[]? temperature_700hPa_member03 { get; set; }
        public double?[]? temperature_700hPa_member04 { get; set; }
        public double?[]? temperature_700hPa_member05 { get; set; }
        public double?[]? temperature_700hPa_member06 { get; set; }
        public double?[]? temperature_700hPa_member07 { get; set; }
        public double?[]? temperature_700hPa_member08 { get; set; }
        public double?[]? temperature_700hPa_member09 { get; set; }
        public double?[]? temperature_700hPa_member10 { get; set; }
        public double?[]? temperature_700hPa_member11 { get; set; }
        public double?[]? temperature_700hPa_member12 { get; set; }
        public double?[]? temperature_700hPa_member13 { get; set; }
        public double?[]? temperature_700hPa_member14 { get; set; }
        public double?[]? temperature_700hPa_member15 { get; set; }
        public double?[]? temperature_700hPa_member16 { get; set; }
        public double?[]? temperature_700hPa_member17 { get; set; }
        public double?[]? temperature_700hPa_member18 { get; set; }
        public double?[]? temperature_700hPa_member19 { get; set; }
        public double?[]? temperature_700hPa_member20 { get; set; }
        public double?[]? temperature_700hPa_member21 { get; set; }
        public double?[]? temperature_700hPa_member22 { get; set; }
        public double?[]? temperature_700hPa_member23 { get; set; }
        public double?[]? temperature_700hPa_member24 { get; set; }
        public double?[]? temperature_700hPa_member25 { get; set; }
        public double?[]? temperature_700hPa_member26 { get; set; }
        public double?[]? temperature_700hPa_member27 { get; set; }
        public double?[]? temperature_700hPa_member28 { get; set; }
        public double?[]? temperature_700hPa_member29 { get; set; }
        public double?[]? temperature_700hPa_member30 { get; set; }
        public double?[]? temperature_600hPa { get; set; }
        public double?[]? temperature_600hPa_member01 { get; set; }
        public double?[]? temperature_600hPa_member02 { get; set; }
        public double?[]? temperature_600hPa_member03 { get; set; }
        public double?[]? temperature_600hPa_member04 { get; set; }
        public double?[]? temperature_600hPa_member05 { get; set; }
        public double?[]? temperature_600hPa_member06 { get; set; }
        public double?[]? temperature_600hPa_member07 { get; set; }
        public double?[]? temperature_600hPa_member08 { get; set; }
        public double?[]? temperature_600hPa_member09 { get; set; }
        public double?[]? temperature_600hPa_member10 { get; set; }
        public double?[]? temperature_600hPa_member11 { get; set; }
        public double?[]? temperature_600hPa_member12 { get; set; }
        public double?[]? temperature_600hPa_member13 { get; set; }
        public double?[]? temperature_600hPa_member14 { get; set; }
        public double?[]? temperature_600hPa_member15 { get; set; }
        public double?[]? temperature_600hPa_member16 { get; set; }
        public double?[]? temperature_600hPa_member17 { get; set; }
        public double?[]? temperature_600hPa_member18 { get; set; }
        public double?[]? temperature_600hPa_member19 { get; set; }
        public double?[]? temperature_600hPa_member20 { get; set; }
        public double?[]? temperature_600hPa_member21 { get; set; }
        public double?[]? temperature_600hPa_member22 { get; set; }
        public double?[]? temperature_600hPa_member23 { get; set; }
        public double?[]? temperature_600hPa_member24 { get; set; }
        public double?[]? temperature_600hPa_member25 { get; set; }
        public double?[]? temperature_600hPa_member26 { get; set; }
        public double?[]? temperature_600hPa_member27 { get; set; }
        public double?[]? temperature_600hPa_member28 { get; set; }
        public double?[]? temperature_600hPa_member29 { get; set; }
        public double?[]? temperature_600hPa_member30 { get; set; }
        public double?[]? temperature_500hPa { get; set; }
        public double?[]? temperature_500hPa_member01 { get; set; }
        public double?[]? temperature_500hPa_member02 { get; set; }
        public double?[]? temperature_500hPa_member03 { get; set; }
        public double?[]? temperature_500hPa_member04 { get; set; }
        public double?[]? temperature_500hPa_member05 { get; set; }
        public double?[]? temperature_500hPa_member06 { get; set; }
        public double?[]? temperature_500hPa_member07 { get; set; }
        public double?[]? temperature_500hPa_member08 { get; set; }
        public double?[]? temperature_500hPa_member09 { get; set; }
        public double?[]? temperature_500hPa_member10 { get; set; }
        public double?[]? temperature_500hPa_member11 { get; set; }
        public double?[]? temperature_500hPa_member12 { get; set; }
        public double?[]? temperature_500hPa_member13 { get; set; }
        public double?[]? temperature_500hPa_member14 { get; set; }
        public double?[]? temperature_500hPa_member15 { get; set; }
        public double?[]? temperature_500hPa_member16 { get; set; }
        public double?[]? temperature_500hPa_member17 { get; set; }
        public double?[]? temperature_500hPa_member18 { get; set; }
        public double?[]? temperature_500hPa_member19 { get; set; }
        public double?[]? temperature_500hPa_member20 { get; set; }
        public double?[]? temperature_500hPa_member21 { get; set; }
        public double?[]? temperature_500hPa_member22 { get; set; }
        public double?[]? temperature_500hPa_member23 { get; set; }
        public double?[]? temperature_500hPa_member24 { get; set; }
        public double?[]? temperature_500hPa_member25 { get; set; }
        public double?[]? temperature_500hPa_member26 { get; set; }
        public double?[]? temperature_500hPa_member27 { get; set; }
        public double?[]? temperature_500hPa_member28 { get; set; }
        public double?[]? temperature_500hPa_member29 { get; set; }
        public double?[]? temperature_500hPa_member30 { get; set; }
        public double?[]? temperature_400hPa { get; set; }
        public double?[]? temperature_400hPa_member01 { get; set; }
        public double?[]? temperature_400hPa_member02 { get; set; }
        public double?[]? temperature_400hPa_member03 { get; set; }
        public double?[]? temperature_400hPa_member04 { get; set; }
        public double?[]? temperature_400hPa_member05 { get; set; }
        public double?[]? temperature_400hPa_member06 { get; set; }
        public double?[]? temperature_400hPa_member07 { get; set; }
        public double?[]? temperature_400hPa_member08 { get; set; }
        public double?[]? temperature_400hPa_member09 { get; set; }
        public double?[]? temperature_400hPa_member10 { get; set; }
        public double?[]? temperature_400hPa_member11 { get; set; }
        public double?[]? temperature_400hPa_member12 { get; set; }
        public double?[]? temperature_400hPa_member13 { get; set; }
        public double?[]? temperature_400hPa_member14 { get; set; }
        public double?[]? temperature_400hPa_member15 { get; set; }
        public double?[]? temperature_400hPa_member16 { get; set; }
        public double?[]? temperature_400hPa_member17 { get; set; }
        public double?[]? temperature_400hPa_member18 { get; set; }
        public double?[]? temperature_400hPa_member19 { get; set; }
        public double?[]? temperature_400hPa_member20 { get; set; }
        public double?[]? temperature_400hPa_member21 { get; set; }
        public double?[]? temperature_400hPa_member22 { get; set; }
        public double?[]? temperature_400hPa_member23 { get; set; }
        public double?[]? temperature_400hPa_member24 { get; set; }
        public double?[]? temperature_400hPa_member25 { get; set; }
        public double?[]? temperature_400hPa_member26 { get; set; }
        public double?[]? temperature_400hPa_member27 { get; set; }
        public double?[]? temperature_400hPa_member28 { get; set; }
        public double?[]? temperature_400hPa_member29 { get; set; }
        public double?[]? temperature_400hPa_member30 { get; set; }
        public double?[]? temperature_300hPa { get; set; }
        public double?[]? temperature_300hPa_member01 { get; set; }
        public double?[]? temperature_300hPa_member02 { get; set; }
        public double?[]? temperature_300hPa_member03 { get; set; }
        public double?[]? temperature_300hPa_member04 { get; set; }
        public double?[]? temperature_300hPa_member05 { get; set; }
        public double?[]? temperature_300hPa_member06 { get; set; }
        public double?[]? temperature_300hPa_member07 { get; set; }
        public double?[]? temperature_300hPa_member08 { get; set; }
        public double?[]? temperature_300hPa_member09 { get; set; }
        public double?[]? temperature_300hPa_member10 { get; set; }
        public double?[]? temperature_300hPa_member11 { get; set; }
        public double?[]? temperature_300hPa_member12 { get; set; }
        public double?[]? temperature_300hPa_member13 { get; set; }
        public double?[]? temperature_300hPa_member14 { get; set; }
        public double?[]? temperature_300hPa_member15 { get; set; }
        public double?[]? temperature_300hPa_member16 { get; set; }
        public double?[]? temperature_300hPa_member17 { get; set; }
        public double?[]? temperature_300hPa_member18 { get; set; }
        public double?[]? temperature_300hPa_member19 { get; set; }
        public double?[]? temperature_300hPa_member20 { get; set; }
        public double?[]? temperature_300hPa_member21 { get; set; }
        public double?[]? temperature_300hPa_member22 { get; set; }
        public double?[]? temperature_300hPa_member23 { get; set; }
        public double?[]? temperature_300hPa_member24 { get; set; }
        public double?[]? temperature_300hPa_member25 { get; set; }
        public double?[]? temperature_300hPa_member26 { get; set; }
        public double?[]? temperature_300hPa_member27 { get; set; }
        public double?[]? temperature_300hPa_member28 { get; set; }
        public double?[]? temperature_300hPa_member29 { get; set; }
        public double?[]? temperature_300hPa_member30 { get; set; }
        public double?[]? temperature_250hPa { get; set; }
        public double?[]? temperature_250hPa_member01 { get; set; }
        public double?[]? temperature_250hPa_member02 { get; set; }
        public double?[]? temperature_250hPa_member03 { get; set; }
        public double?[]? temperature_250hPa_member04 { get; set; }
        public double?[]? temperature_250hPa_member05 { get; set; }
        public double?[]? temperature_250hPa_member06 { get; set; }
        public double?[]? temperature_250hPa_member07 { get; set; }
        public double?[]? temperature_250hPa_member08 { get; set; }
        public double?[]? temperature_250hPa_member09 { get; set; }
        public double?[]? temperature_250hPa_member10 { get; set; }
        public double?[]? temperature_250hPa_member11 { get; set; }
        public double?[]? temperature_250hPa_member12 { get; set; }
        public double?[]? temperature_250hPa_member13 { get; set; }
        public double?[]? temperature_250hPa_member14 { get; set; }
        public double?[]? temperature_250hPa_member15 { get; set; }
        public double?[]? temperature_250hPa_member16 { get; set; }
        public double?[]? temperature_250hPa_member17 { get; set; }
        public double?[]? temperature_250hPa_member18 { get; set; }
        public double?[]? temperature_250hPa_member19 { get; set; }
        public double?[]? temperature_250hPa_member20 { get; set; }
        public double?[]? temperature_250hPa_member21 { get; set; }
        public double?[]? temperature_250hPa_member22 { get; set; }
        public double?[]? temperature_250hPa_member23 { get; set; }
        public double?[]? temperature_250hPa_member24 { get; set; }
        public double?[]? temperature_250hPa_member25 { get; set; }
        public double?[]? temperature_250hPa_member26 { get; set; }
        public double?[]? temperature_250hPa_member27 { get; set; }
        public double?[]? temperature_250hPa_member28 { get; set; }
        public double?[]? temperature_250hPa_member29 { get; set; }
        public double?[]? temperature_250hPa_member30 { get; set; }
        public double?[]? temperature_200hPa { get; set; }
        public double?[]? temperature_200hPa_member01 { get; set; }
        public double?[]? temperature_200hPa_member02 { get; set; }
        public double?[]? temperature_200hPa_member03 { get; set; }
        public double?[]? temperature_200hPa_member04 { get; set; }
        public double?[]? temperature_200hPa_member05 { get; set; }
        public double?[]? temperature_200hPa_member06 { get; set; }
        public double?[]? temperature_200hPa_member07 { get; set; }
        public double?[]? temperature_200hPa_member08 { get; set; }
        public double?[]? temperature_200hPa_member09 { get; set; }
        public double?[]? temperature_200hPa_member10 { get; set; }
        public double?[]? temperature_200hPa_member11 { get; set; }
        public double?[]? temperature_200hPa_member12 { get; set; }
        public double?[]? temperature_200hPa_member13 { get; set; }
        public double?[]? temperature_200hPa_member14 { get; set; }
        public double?[]? temperature_200hPa_member15 { get; set; }
        public double?[]? temperature_200hPa_member16 { get; set; }
        public double?[]? temperature_200hPa_member17 { get; set; }
        public double?[]? temperature_200hPa_member18 { get; set; }
        public double?[]? temperature_200hPa_member19 { get; set; }
        public double?[]? temperature_200hPa_member20 { get; set; }
        public double?[]? temperature_200hPa_member21 { get; set; }
        public double?[]? temperature_200hPa_member22 { get; set; }
        public double?[]? temperature_200hPa_member23 { get; set; }
        public double?[]? temperature_200hPa_member24 { get; set; }
        public double?[]? temperature_200hPa_member25 { get; set; }
        public double?[]? temperature_200hPa_member26 { get; set; }
        public double?[]? temperature_200hPa_member27 { get; set; }
        public double?[]? temperature_200hPa_member28 { get; set; }
        public double?[]? temperature_200hPa_member29 { get; set; }
        public double?[]? temperature_200hPa_member30 { get; set; }
        public double?[]? temperature_150hPa { get; set; }
        public double?[]? temperature_150hPa_member01 { get; set; }
        public double?[]? temperature_150hPa_member02 { get; set; }
        public double?[]? temperature_150hPa_member03 { get; set; }
        public double?[]? temperature_150hPa_member04 { get; set; }
        public double?[]? temperature_150hPa_member05 { get; set; }
        public double?[]? temperature_150hPa_member06 { get; set; }
        public double?[]? temperature_150hPa_member07 { get; set; }
        public double?[]? temperature_150hPa_member08 { get; set; }
        public double?[]? temperature_150hPa_member09 { get; set; }
        public double?[]? temperature_150hPa_member10 { get; set; }
        public double?[]? temperature_150hPa_member11 { get; set; }
        public double?[]? temperature_150hPa_member12 { get; set; }
        public double?[]? temperature_150hPa_member13 { get; set; }
        public double?[]? temperature_150hPa_member14 { get; set; }
        public double?[]? temperature_150hPa_member15 { get; set; }
        public double?[]? temperature_150hPa_member16 { get; set; }
        public double?[]? temperature_150hPa_member17 { get; set; }
        public double?[]? temperature_150hPa_member18 { get; set; }
        public double?[]? temperature_150hPa_member19 { get; set; }
        public double?[]? temperature_150hPa_member20 { get; set; }
        public double?[]? temperature_150hPa_member21 { get; set; }
        public double?[]? temperature_150hPa_member22 { get; set; }
        public double?[]? temperature_150hPa_member23 { get; set; }
        public double?[]? temperature_150hPa_member24 { get; set; }
        public double?[]? temperature_150hPa_member25 { get; set; }
        public double?[]? temperature_150hPa_member26 { get; set; }
        public double?[]? temperature_150hPa_member27 { get; set; }
        public double?[]? temperature_150hPa_member28 { get; set; }
        public double?[]? temperature_150hPa_member29 { get; set; }
        public double?[]? temperature_150hPa_member30 { get; set; }
        public double?[]? temperature_100hPa { get; set; }
        public double?[]? temperature_100hPa_member01 { get; set; }
        public double?[]? temperature_100hPa_member02 { get; set; }
        public double?[]? temperature_100hPa_member03 { get; set; }
        public double?[]? temperature_100hPa_member04 { get; set; }
        public double?[]? temperature_100hPa_member05 { get; set; }
        public double?[]? temperature_100hPa_member06 { get; set; }
        public double?[]? temperature_100hPa_member07 { get; set; }
        public double?[]? temperature_100hPa_member08 { get; set; }
        public double?[]? temperature_100hPa_member09 { get; set; }
        public double?[]? temperature_100hPa_member10 { get; set; }
        public double?[]? temperature_100hPa_member11 { get; set; }
        public double?[]? temperature_100hPa_member12 { get; set; }
        public double?[]? temperature_100hPa_member13 { get; set; }
        public double?[]? temperature_100hPa_member14 { get; set; }
        public double?[]? temperature_100hPa_member15 { get; set; }
        public double?[]? temperature_100hPa_member16 { get; set; }
        public double?[]? temperature_100hPa_member17 { get; set; }
        public double?[]? temperature_100hPa_member18 { get; set; }
        public double?[]? temperature_100hPa_member19 { get; set; }
        public double?[]? temperature_100hPa_member20 { get; set; }
        public double?[]? temperature_100hPa_member21 { get; set; }
        public double?[]? temperature_100hPa_member22 { get; set; }
        public double?[]? temperature_100hPa_member23 { get; set; }
        public double?[]? temperature_100hPa_member24 { get; set; }
        public double?[]? temperature_100hPa_member25 { get; set; }
        public double?[]? temperature_100hPa_member26 { get; set; }
        public double?[]? temperature_100hPa_member27 { get; set; }
        public double?[]? temperature_100hPa_member28 { get; set; }
        public double?[]? temperature_100hPa_member29 { get; set; }
        public double?[]? temperature_100hPa_member30 { get; set; }
        public double?[]? temperature_50hPa { get; set; }
        public double?[]? temperature_50hPa_member01 { get; set; }
        public double?[]? temperature_50hPa_member02 { get; set; }
        public double?[]? temperature_50hPa_member03 { get; set; }
        public double?[]? temperature_50hPa_member04 { get; set; }
        public double?[]? temperature_50hPa_member05 { get; set; }
        public double?[]? temperature_50hPa_member06 { get; set; }
        public double?[]? temperature_50hPa_member07 { get; set; }
        public double?[]? temperature_50hPa_member08 { get; set; }
        public double?[]? temperature_50hPa_member09 { get; set; }
        public double?[]? temperature_50hPa_member10 { get; set; }
        public double?[]? temperature_50hPa_member11 { get; set; }
        public double?[]? temperature_50hPa_member12 { get; set; }
        public double?[]? temperature_50hPa_member13 { get; set; }
        public double?[]? temperature_50hPa_member14 { get; set; }
        public double?[]? temperature_50hPa_member15 { get; set; }
        public double?[]? temperature_50hPa_member16 { get; set; }
        public double?[]? temperature_50hPa_member17 { get; set; }
        public double?[]? temperature_50hPa_member18 { get; set; }
        public double?[]? temperature_50hPa_member19 { get; set; }
        public double?[]? temperature_50hPa_member20 { get; set; }
        public double?[]? temperature_50hPa_member21 { get; set; }
        public double?[]? temperature_50hPa_member22 { get; set; }
        public double?[]? temperature_50hPa_member23 { get; set; }
        public double?[]? temperature_50hPa_member24 { get; set; }
        public double?[]? temperature_50hPa_member25 { get; set; }
        public double?[]? temperature_50hPa_member26 { get; set; }
        public double?[]? temperature_50hPa_member27 { get; set; }
        public double?[]? temperature_50hPa_member28 { get; set; }
        public double?[]? temperature_50hPa_member29 { get; set; }
        public double?[]? temperature_50hPa_member30 { get; set; }
        public double?[]? dew_point_1000hPa { get; set; }
        public double?[]? dew_point_1000hPa_member01 { get; set; }
        public double?[]? dew_point_1000hPa_member02 { get; set; }
        public double?[]? dew_point_1000hPa_member03 { get; set; }
        public double?[]? dew_point_1000hPa_member04 { get; set; }
        public double?[]? dew_point_1000hPa_member05 { get; set; }
        public double?[]? dew_point_1000hPa_member06 { get; set; }
        public double?[]? dew_point_1000hPa_member07 { get; set; }
        public double?[]? dew_point_1000hPa_member08 { get; set; }
        public double?[]? dew_point_1000hPa_member09 { get; set; }
        public double?[]? dew_point_1000hPa_member10 { get; set; }
        public double?[]? dew_point_1000hPa_member11 { get; set; }
        public double?[]? dew_point_1000hPa_member12 { get; set; }
        public double?[]? dew_point_1000hPa_member13 { get; set; }
        public double?[]? dew_point_1000hPa_member14 { get; set; }
        public double?[]? dew_point_1000hPa_member15 { get; set; }
        public double?[]? dew_point_1000hPa_member16 { get; set; }
        public double?[]? dew_point_1000hPa_member17 { get; set; }
        public double?[]? dew_point_1000hPa_member18 { get; set; }
        public double?[]? dew_point_1000hPa_member19 { get; set; }
        public double?[]? dew_point_1000hPa_member20 { get; set; }
        public double?[]? dew_point_1000hPa_member21 { get; set; }
        public double?[]? dew_point_1000hPa_member22 { get; set; }
        public double?[]? dew_point_1000hPa_member23 { get; set; }
        public double?[]? dew_point_1000hPa_member24 { get; set; }
        public double?[]? dew_point_1000hPa_member25 { get; set; }
        public double?[]? dew_point_1000hPa_member26 { get; set; }
        public double?[]? dew_point_1000hPa_member27 { get; set; }
        public double?[]? dew_point_1000hPa_member28 { get; set; }
        public double?[]? dew_point_1000hPa_member29 { get; set; }
        public double?[]? dew_point_1000hPa_member30 { get; set; }
        public double?[]? dew_point_925hPa { get; set; }
        public double?[]? dew_point_925hPa_member01 { get; set; }
        public double?[]? dew_point_925hPa_member02 { get; set; }
        public double?[]? dew_point_925hPa_member03 { get; set; }
        public double?[]? dew_point_925hPa_member04 { get; set; }
        public double?[]? dew_point_925hPa_member05 { get; set; }
        public double?[]? dew_point_925hPa_member06 { get; set; }
        public double?[]? dew_point_925hPa_member07 { get; set; }
        public double?[]? dew_point_925hPa_member08 { get; set; }
        public double?[]? dew_point_925hPa_member09 { get; set; }
        public double?[]? dew_point_925hPa_member10 { get; set; }
        public double?[]? dew_point_925hPa_member11 { get; set; }
        public double?[]? dew_point_925hPa_member12 { get; set; }
        public double?[]? dew_point_925hPa_member13 { get; set; }
        public double?[]? dew_point_925hPa_member14 { get; set; }
        public double?[]? dew_point_925hPa_member15 { get; set; }
        public double?[]? dew_point_925hPa_member16 { get; set; }
        public double?[]? dew_point_925hPa_member17 { get; set; }
        public double?[]? dew_point_925hPa_member18 { get; set; }
        public double?[]? dew_point_925hPa_member19 { get; set; }
        public double?[]? dew_point_925hPa_member20 { get; set; }
        public double?[]? dew_point_925hPa_member21 { get; set; }
        public double?[]? dew_point_925hPa_member22 { get; set; }
        public double?[]? dew_point_925hPa_member23 { get; set; }
        public double?[]? dew_point_925hPa_member24 { get; set; }
        public double?[]? dew_point_925hPa_member25 { get; set; }
        public double?[]? dew_point_925hPa_member26 { get; set; }
        public double?[]? dew_point_925hPa_member27 { get; set; }
        public double?[]? dew_point_925hPa_member28 { get; set; }
        public double?[]? dew_point_925hPa_member29 { get; set; }
        public double?[]? dew_point_925hPa_member30 { get; set; }
        public double?[]? dew_point_850hPa { get; set; }
        public double?[]? dew_point_850hPa_member01 { get; set; }
        public double?[]? dew_point_850hPa_member02 { get; set; }
        public double?[]? dew_point_850hPa_member03 { get; set; }
        public double?[]? dew_point_850hPa_member04 { get; set; }
        public double?[]? dew_point_850hPa_member05 { get; set; }
        public double?[]? dew_point_850hPa_member06 { get; set; }
        public double?[]? dew_point_850hPa_member07 { get; set; }
        public double?[]? dew_point_850hPa_member08 { get; set; }
        public double?[]? dew_point_850hPa_member09 { get; set; }
        public double?[]? dew_point_850hPa_member10 { get; set; }
        public double?[]? dew_point_850hPa_member11 { get; set; }
        public double?[]? dew_point_850hPa_member12 { get; set; }
        public double?[]? dew_point_850hPa_member13 { get; set; }
        public double?[]? dew_point_850hPa_member14 { get; set; }
        public double?[]? dew_point_850hPa_member15 { get; set; }
        public double?[]? dew_point_850hPa_member16 { get; set; }
        public double?[]? dew_point_850hPa_member17 { get; set; }
        public double?[]? dew_point_850hPa_member18 { get; set; }
        public double?[]? dew_point_850hPa_member19 { get; set; }
        public double?[]? dew_point_850hPa_member20 { get; set; }
        public double?[]? dew_point_850hPa_member21 { get; set; }
        public double?[]? dew_point_850hPa_member22 { get; set; }
        public double?[]? dew_point_850hPa_member23 { get; set; }
        public double?[]? dew_point_850hPa_member24 { get; set; }
        public double?[]? dew_point_850hPa_member25 { get; set; }
        public double?[]? dew_point_850hPa_member26 { get; set; }
        public double?[]? dew_point_850hPa_member27 { get; set; }
        public double?[]? dew_point_850hPa_member28 { get; set; }
        public double?[]? dew_point_850hPa_member29 { get; set; }
        public double?[]? dew_point_850hPa_member30 { get; set; }
        public double?[]? dew_point_700hPa { get; set; }
        public double?[]? dew_point_700hPa_member01 { get; set; }
        public double?[]? dew_point_700hPa_member02 { get; set; }
        public double?[]? dew_point_700hPa_member03 { get; set; }
        public double?[]? dew_point_700hPa_member04 { get; set; }
        public double?[]? dew_point_700hPa_member05 { get; set; }
        public double?[]? dew_point_700hPa_member06 { get; set; }
        public double?[]? dew_point_700hPa_member07 { get; set; }
        public double?[]? dew_point_700hPa_member08 { get; set; }
        public double?[]? dew_point_700hPa_member09 { get; set; }
        public double?[]? dew_point_700hPa_member10 { get; set; }
        public double?[]? dew_point_700hPa_member11 { get; set; }
        public double?[]? dew_point_700hPa_member12 { get; set; }
        public double?[]? dew_point_700hPa_member13 { get; set; }
        public double?[]? dew_point_700hPa_member14 { get; set; }
        public double?[]? dew_point_700hPa_member15 { get; set; }
        public double?[]? dew_point_700hPa_member16 { get; set; }
        public double?[]? dew_point_700hPa_member17 { get; set; }
        public double?[]? dew_point_700hPa_member18 { get; set; }
        public double?[]? dew_point_700hPa_member19 { get; set; }
        public double?[]? dew_point_700hPa_member20 { get; set; }
        public double?[]? dew_point_700hPa_member21 { get; set; }
        public double?[]? dew_point_700hPa_member22 { get; set; }
        public double?[]? dew_point_700hPa_member23 { get; set; }
        public double?[]? dew_point_700hPa_member24 { get; set; }
        public double?[]? dew_point_700hPa_member25 { get; set; }
        public double?[]? dew_point_700hPa_member26 { get; set; }
        public double?[]? dew_point_700hPa_member27 { get; set; }
        public double?[]? dew_point_700hPa_member28 { get; set; }
        public double?[]? dew_point_700hPa_member29 { get; set; }
        public double?[]? dew_point_700hPa_member30 { get; set; }
        public double?[]? dew_point_600hPa { get; set; }
        public double?[]? dew_point_600hPa_member01 { get; set; }
        public double?[]? dew_point_600hPa_member02 { get; set; }
        public double?[]? dew_point_600hPa_member03 { get; set; }
        public double?[]? dew_point_600hPa_member04 { get; set; }
        public double?[]? dew_point_600hPa_member05 { get; set; }
        public double?[]? dew_point_600hPa_member06 { get; set; }
        public double?[]? dew_point_600hPa_member07 { get; set; }
        public double?[]? dew_point_600hPa_member08 { get; set; }
        public double?[]? dew_point_600hPa_member09 { get; set; }
        public double?[]? dew_point_600hPa_member10 { get; set; }
        public double?[]? dew_point_600hPa_member11 { get; set; }
        public double?[]? dew_point_600hPa_member12 { get; set; }
        public double?[]? dew_point_600hPa_member13 { get; set; }
        public double?[]? dew_point_600hPa_member14 { get; set; }
        public double?[]? dew_point_600hPa_member15 { get; set; }
        public double?[]? dew_point_600hPa_member16 { get; set; }
        public double?[]? dew_point_600hPa_member17 { get; set; }
        public double?[]? dew_point_600hPa_member18 { get; set; }
        public double?[]? dew_point_600hPa_member19 { get; set; }
        public double?[]? dew_point_600hPa_member20 { get; set; }
        public double?[]? dew_point_600hPa_member21 { get; set; }
        public double?[]? dew_point_600hPa_member22 { get; set; }
        public double?[]? dew_point_600hPa_member23 { get; set; }
        public double?[]? dew_point_600hPa_member24 { get; set; }
        public double?[]? dew_point_600hPa_member25 { get; set; }
        public double?[]? dew_point_600hPa_member26 { get; set; }
        public double?[]? dew_point_600hPa_member27 { get; set; }
        public double?[]? dew_point_600hPa_member28 { get; set; }
        public double?[]? dew_point_600hPa_member29 { get; set; }
        public double?[]? dew_point_600hPa_member30 { get; set; }
        public double?[]? dew_point_500hPa { get; set; }
        public double?[]? dew_point_500hPa_member01 { get; set; }
        public double?[]? dew_point_500hPa_member02 { get; set; }
        public double?[]? dew_point_500hPa_member03 { get; set; }
        public double?[]? dew_point_500hPa_member04 { get; set; }
        public double?[]? dew_point_500hPa_member05 { get; set; }
        public double?[]? dew_point_500hPa_member06 { get; set; }
        public double?[]? dew_point_500hPa_member07 { get; set; }
        public double?[]? dew_point_500hPa_member08 { get; set; }
        public double?[]? dew_point_500hPa_member09 { get; set; }
        public double?[]? dew_point_500hPa_member10 { get; set; }
        public double?[]? dew_point_500hPa_member11 { get; set; }
        public double?[]? dew_point_500hPa_member12 { get; set; }
        public double?[]? dew_point_500hPa_member13 { get; set; }
        public double?[]? dew_point_500hPa_member14 { get; set; }
        public double?[]? dew_point_500hPa_member15 { get; set; }
        public double?[]? dew_point_500hPa_member16 { get; set; }
        public double?[]? dew_point_500hPa_member17 { get; set; }
        public double?[]? dew_point_500hPa_member18 { get; set; }
        public double?[]? dew_point_500hPa_member19 { get; set; }
        public double?[]? dew_point_500hPa_member20 { get; set; }
        public double?[]? dew_point_500hPa_member21 { get; set; }
        public double?[]? dew_point_500hPa_member22 { get; set; }
        public double?[]? dew_point_500hPa_member23 { get; set; }
        public double?[]? dew_point_500hPa_member24 { get; set; }
        public double?[]? dew_point_500hPa_member25 { get; set; }
        public double?[]? dew_point_500hPa_member26 { get; set; }
        public double?[]? dew_point_500hPa_member27 { get; set; }
        public double?[]? dew_point_500hPa_member28 { get; set; }
        public double?[]? dew_point_500hPa_member29 { get; set; }
        public double?[]? dew_point_500hPa_member30 { get; set; }
        public double?[]? dew_point_400hPa { get; set; }
        public double?[]? dew_point_400hPa_member01 { get; set; }
        public double?[]? dew_point_400hPa_member02 { get; set; }
        public double?[]? dew_point_400hPa_member03 { get; set; }
        public double?[]? dew_point_400hPa_member04 { get; set; }
        public double?[]? dew_point_400hPa_member05 { get; set; }
        public double?[]? dew_point_400hPa_member06 { get; set; }
        public double?[]? dew_point_400hPa_member07 { get; set; }
        public double?[]? dew_point_400hPa_member08 { get; set; }
        public double?[]? dew_point_400hPa_member09 { get; set; }
        public double?[]? dew_point_400hPa_member10 { get; set; }
        public double?[]? dew_point_400hPa_member11 { get; set; }
        public double?[]? dew_point_400hPa_member12 { get; set; }
        public double?[]? dew_point_400hPa_member13 { get; set; }
        public double?[]? dew_point_400hPa_member14 { get; set; }
        public double?[]? dew_point_400hPa_member15 { get; set; }
        public double?[]? dew_point_400hPa_member16 { get; set; }
        public double?[]? dew_point_400hPa_member17 { get; set; }
        public double?[]? dew_point_400hPa_member18 { get; set; }
        public double?[]? dew_point_400hPa_member19 { get; set; }
        public double?[]? dew_point_400hPa_member20 { get; set; }
        public double?[]? dew_point_400hPa_member21 { get; set; }
        public double?[]? dew_point_400hPa_member22 { get; set; }
        public double?[]? dew_point_400hPa_member23 { get; set; }
        public double?[]? dew_point_400hPa_member24 { get; set; }
        public double?[]? dew_point_400hPa_member25 { get; set; }
        public double?[]? dew_point_400hPa_member26 { get; set; }
        public double?[]? dew_point_400hPa_member27 { get; set; }
        public double?[]? dew_point_400hPa_member28 { get; set; }
        public double?[]? dew_point_400hPa_member29 { get; set; }
        public double?[]? dew_point_400hPa_member30 { get; set; }
        public double?[]? dew_point_300hPa { get; set; }
        public double?[]? dew_point_300hPa_member01 { get; set; }
        public double?[]? dew_point_300hPa_member02 { get; set; }
        public double?[]? dew_point_300hPa_member03 { get; set; }
        public double?[]? dew_point_300hPa_member04 { get; set; }
        public double?[]? dew_point_300hPa_member05 { get; set; }
        public double?[]? dew_point_300hPa_member06 { get; set; }
        public double?[]? dew_point_300hPa_member07 { get; set; }
        public double?[]? dew_point_300hPa_member08 { get; set; }
        public double?[]? dew_point_300hPa_member09 { get; set; }
        public double?[]? dew_point_300hPa_member10 { get; set; }
        public double?[]? dew_point_300hPa_member11 { get; set; }
        public double?[]? dew_point_300hPa_member12 { get; set; }
        public double?[]? dew_point_300hPa_member13 { get; set; }
        public double?[]? dew_point_300hPa_member14 { get; set; }
        public double?[]? dew_point_300hPa_member15 { get; set; }
        public double?[]? dew_point_300hPa_member16 { get; set; }
        public double?[]? dew_point_300hPa_member17 { get; set; }
        public double?[]? dew_point_300hPa_member18 { get; set; }
        public double?[]? dew_point_300hPa_member19 { get; set; }
        public double?[]? dew_point_300hPa_member20 { get; set; }
        public double?[]? dew_point_300hPa_member21 { get; set; }
        public double?[]? dew_point_300hPa_member22 { get; set; }
        public double?[]? dew_point_300hPa_member23 { get; set; }
        public double?[]? dew_point_300hPa_member24 { get; set; }
        public double?[]? dew_point_300hPa_member25 { get; set; }
        public double?[]? dew_point_300hPa_member26 { get; set; }
        public double?[]? dew_point_300hPa_member27 { get; set; }
        public double?[]? dew_point_300hPa_member28 { get; set; }
        public double?[]? dew_point_300hPa_member29 { get; set; }
        public double?[]? dew_point_300hPa_member30 { get; set; }
        public double?[]? dew_point_250hPa { get; set; }
        public double?[]? dew_point_250hPa_member01 { get; set; }
        public double?[]? dew_point_250hPa_member02 { get; set; }
        public double?[]? dew_point_250hPa_member03 { get; set; }
        public double?[]? dew_point_250hPa_member04 { get; set; }
        public double?[]? dew_point_250hPa_member05 { get; set; }
        public double?[]? dew_point_250hPa_member06 { get; set; }
        public double?[]? dew_point_250hPa_member07 { get; set; }
        public double?[]? dew_point_250hPa_member08 { get; set; }
        public double?[]? dew_point_250hPa_member09 { get; set; }
        public double?[]? dew_point_250hPa_member10 { get; set; }
        public double?[]? dew_point_250hPa_member11 { get; set; }
        public double?[]? dew_point_250hPa_member12 { get; set; }
        public double?[]? dew_point_250hPa_member13 { get; set; }
        public double?[]? dew_point_250hPa_member14 { get; set; }
        public double?[]? dew_point_250hPa_member15 { get; set; }
        public double?[]? dew_point_250hPa_member16 { get; set; }
        public double?[]? dew_point_250hPa_member17 { get; set; }
        public double?[]? dew_point_250hPa_member18 { get; set; }
        public double?[]? dew_point_250hPa_member19 { get; set; }
        public double?[]? dew_point_250hPa_member20 { get; set; }
        public double?[]? dew_point_250hPa_member21 { get; set; }
        public double?[]? dew_point_250hPa_member22 { get; set; }
        public double?[]? dew_point_250hPa_member23 { get; set; }
        public double?[]? dew_point_250hPa_member24 { get; set; }
        public double?[]? dew_point_250hPa_member25 { get; set; }
        public double?[]? dew_point_250hPa_member26 { get; set; }
        public double?[]? dew_point_250hPa_member27 { get; set; }
        public double?[]? dew_point_250hPa_member28 { get; set; }
        public double?[]? dew_point_250hPa_member29 { get; set; }
        public double?[]? dew_point_250hPa_member30 { get; set; }
        public double?[]? dew_point_200hPa { get; set; }
        public double?[]? dew_point_200hPa_member01 { get; set; }
        public double?[]? dew_point_200hPa_member02 { get; set; }
        public double?[]? dew_point_200hPa_member03 { get; set; }
        public double?[]? dew_point_200hPa_member04 { get; set; }
        public double?[]? dew_point_200hPa_member05 { get; set; }
        public double?[]? dew_point_200hPa_member06 { get; set; }
        public double?[]? dew_point_200hPa_member07 { get; set; }
        public double?[]? dew_point_200hPa_member08 { get; set; }
        public double?[]? dew_point_200hPa_member09 { get; set; }
        public double?[]? dew_point_200hPa_member10 { get; set; }
        public double?[]? dew_point_200hPa_member11 { get; set; }
        public double?[]? dew_point_200hPa_member12 { get; set; }
        public double?[]? dew_point_200hPa_member13 { get; set; }
        public double?[]? dew_point_200hPa_member14 { get; set; }
        public double?[]? dew_point_200hPa_member15 { get; set; }
        public double?[]? dew_point_200hPa_member16 { get; set; }
        public double?[]? dew_point_200hPa_member17 { get; set; }
        public double?[]? dew_point_200hPa_member18 { get; set; }
        public double?[]? dew_point_200hPa_member19 { get; set; }
        public double?[]? dew_point_200hPa_member20 { get; set; }
        public double?[]? dew_point_200hPa_member21 { get; set; }
        public double?[]? dew_point_200hPa_member22 { get; set; }
        public double?[]? dew_point_200hPa_member23 { get; set; }
        public double?[]? dew_point_200hPa_member24 { get; set; }
        public double?[]? dew_point_200hPa_member25 { get; set; }
        public double?[]? dew_point_200hPa_member26 { get; set; }
        public double?[]? dew_point_200hPa_member27 { get; set; }
        public double?[]? dew_point_200hPa_member28 { get; set; }
        public double?[]? dew_point_200hPa_member29 { get; set; }
        public double?[]? dew_point_200hPa_member30 { get; set; }
        public double?[]? dew_point_150hPa { get; set; }
        public double?[]? dew_point_150hPa_member01 { get; set; }
        public double?[]? dew_point_150hPa_member02 { get; set; }
        public double?[]? dew_point_150hPa_member03 { get; set; }
        public double?[]? dew_point_150hPa_member04 { get; set; }
        public double?[]? dew_point_150hPa_member05 { get; set; }
        public double?[]? dew_point_150hPa_member06 { get; set; }
        public double?[]? dew_point_150hPa_member07 { get; set; }
        public double?[]? dew_point_150hPa_member08 { get; set; }
        public double?[]? dew_point_150hPa_member09 { get; set; }
        public double?[]? dew_point_150hPa_member10 { get; set; }
        public double?[]? dew_point_150hPa_member11 { get; set; }
        public double?[]? dew_point_150hPa_member12 { get; set; }
        public double?[]? dew_point_150hPa_member13 { get; set; }
        public double?[]? dew_point_150hPa_member14 { get; set; }
        public double?[]? dew_point_150hPa_member15 { get; set; }
        public double?[]? dew_point_150hPa_member16 { get; set; }
        public double?[]? dew_point_150hPa_member17 { get; set; }
        public double?[]? dew_point_150hPa_member18 { get; set; }
        public double?[]? dew_point_150hPa_member19 { get; set; }
        public double?[]? dew_point_150hPa_member20 { get; set; }
        public double?[]? dew_point_150hPa_member21 { get; set; }
        public double?[]? dew_point_150hPa_member22 { get; set; }
        public double?[]? dew_point_150hPa_member23 { get; set; }
        public double?[]? dew_point_150hPa_member24 { get; set; }
        public double?[]? dew_point_150hPa_member25 { get; set; }
        public double?[]? dew_point_150hPa_member26 { get; set; }
        public double?[]? dew_point_150hPa_member27 { get; set; }
        public double?[]? dew_point_150hPa_member28 { get; set; }
        public double?[]? dew_point_150hPa_member29 { get; set; }
        public double?[]? dew_point_150hPa_member30 { get; set; }
        public double?[]? dew_point_100hPa { get; set; }
        public double?[]? dew_point_100hPa_member01 { get; set; }
        public double?[]? dew_point_100hPa_member02 { get; set; }
        public double?[]? dew_point_100hPa_member03 { get; set; }
        public double?[]? dew_point_100hPa_member04 { get; set; }
        public double?[]? dew_point_100hPa_member05 { get; set; }
        public double?[]? dew_point_100hPa_member06 { get; set; }
        public double?[]? dew_point_100hPa_member07 { get; set; }
        public double?[]? dew_point_100hPa_member08 { get; set; }
        public double?[]? dew_point_100hPa_member09 { get; set; }
        public double?[]? dew_point_100hPa_member10 { get; set; }
        public double?[]? dew_point_100hPa_member11 { get; set; }
        public double?[]? dew_point_100hPa_member12 { get; set; }
        public double?[]? dew_point_100hPa_member13 { get; set; }
        public double?[]? dew_point_100hPa_member14 { get; set; }
        public double?[]? dew_point_100hPa_member15 { get; set; }
        public double?[]? dew_point_100hPa_member16 { get; set; }
        public double?[]? dew_point_100hPa_member17 { get; set; }
        public double?[]? dew_point_100hPa_member18 { get; set; }
        public double?[]? dew_point_100hPa_member19 { get; set; }
        public double?[]? dew_point_100hPa_member20 { get; set; }
        public double?[]? dew_point_100hPa_member21 { get; set; }
        public double?[]? dew_point_100hPa_member22 { get; set; }
        public double?[]? dew_point_100hPa_member23 { get; set; }
        public double?[]? dew_point_100hPa_member24 { get; set; }
        public double?[]? dew_point_100hPa_member25 { get; set; }
        public double?[]? dew_point_100hPa_member26 { get; set; }
        public double?[]? dew_point_100hPa_member27 { get; set; }
        public double?[]? dew_point_100hPa_member28 { get; set; }
        public double?[]? dew_point_100hPa_member29 { get; set; }
        public double?[]? dew_point_100hPa_member30 { get; set; }
        public double?[]? dew_point_50hPa { get; set; }
        public double?[]? dew_point_50hPa_member01 { get; set; }
        public double?[]? dew_point_50hPa_member02 { get; set; }
        public double?[]? dew_point_50hPa_member03 { get; set; }
        public double?[]? dew_point_50hPa_member04 { get; set; }
        public double?[]? dew_point_50hPa_member05 { get; set; }
        public double?[]? dew_point_50hPa_member06 { get; set; }
        public double?[]? dew_point_50hPa_member07 { get; set; }
        public double?[]? dew_point_50hPa_member08 { get; set; }
        public double?[]? dew_point_50hPa_member09 { get; set; }
        public double?[]? dew_point_50hPa_member10 { get; set; }
        public double?[]? dew_point_50hPa_member11 { get; set; }
        public double?[]? dew_point_50hPa_member12 { get; set; }
        public double?[]? dew_point_50hPa_member13 { get; set; }
        public double?[]? dew_point_50hPa_member14 { get; set; }
        public double?[]? dew_point_50hPa_member15 { get; set; }
        public double?[]? dew_point_50hPa_member16 { get; set; }
        public double?[]? dew_point_50hPa_member17 { get; set; }
        public double?[]? dew_point_50hPa_member18 { get; set; }
        public double?[]? dew_point_50hPa_member19 { get; set; }
        public double?[]? dew_point_50hPa_member20 { get; set; }
        public double?[]? dew_point_50hPa_member21 { get; set; }
        public double?[]? dew_point_50hPa_member22 { get; set; }
        public double?[]? dew_point_50hPa_member23 { get; set; }
        public double?[]? dew_point_50hPa_member24 { get; set; }
        public double?[]? dew_point_50hPa_member25 { get; set; }
        public double?[]? dew_point_50hPa_member26 { get; set; }
        public double?[]? dew_point_50hPa_member27 { get; set; }
        public double?[]? dew_point_50hPa_member28 { get; set; }
        public double?[]? dew_point_50hPa_member29 { get; set; }
        public double?[]? dew_point_50hPa_member30 { get; set; }
        public double?[]? relative_humidity_1000hPa { get; set; }
        public double?[]? relative_humidity_1000hPa_member01 { get; set; }
        public double?[]? relative_humidity_1000hPa_member02 { get; set; }
        public double?[]? relative_humidity_1000hPa_member03 { get; set; }
        public double?[]? relative_humidity_1000hPa_member04 { get; set; }
        public double?[]? relative_humidity_1000hPa_member05 { get; set; }
        public double?[]? relative_humidity_1000hPa_member06 { get; set; }
        public double?[]? relative_humidity_1000hPa_member07 { get; set; }
        public double?[]? relative_humidity_1000hPa_member08 { get; set; }
        public double?[]? relative_humidity_1000hPa_member09 { get; set; }
        public double?[]? relative_humidity_1000hPa_member10 { get; set; }
        public double?[]? relative_humidity_1000hPa_member11 { get; set; }
        public double?[]? relative_humidity_1000hPa_member12 { get; set; }
        public double?[]? relative_humidity_1000hPa_member13 { get; set; }
        public double?[]? relative_humidity_1000hPa_member14 { get; set; }
        public double?[]? relative_humidity_1000hPa_member15 { get; set; }
        public double?[]? relative_humidity_1000hPa_member16 { get; set; }
        public double?[]? relative_humidity_1000hPa_member17 { get; set; }
        public double?[]? relative_humidity_1000hPa_member18 { get; set; }
        public double?[]? relative_humidity_1000hPa_member19 { get; set; }
        public double?[]? relative_humidity_1000hPa_member20 { get; set; }
        public double?[]? relative_humidity_1000hPa_member21 { get; set; }
        public double?[]? relative_humidity_1000hPa_member22 { get; set; }
        public double?[]? relative_humidity_1000hPa_member23 { get; set; }
        public double?[]? relative_humidity_1000hPa_member24 { get; set; }
        public double?[]? relative_humidity_1000hPa_member25 { get; set; }
        public double?[]? relative_humidity_1000hPa_member26 { get; set; }
        public double?[]? relative_humidity_1000hPa_member27 { get; set; }
        public double?[]? relative_humidity_1000hPa_member28 { get; set; }
        public double?[]? relative_humidity_1000hPa_member29 { get; set; }
        public double?[]? relative_humidity_1000hPa_member30 { get; set; }
        public double?[]? relative_humidity_925hPa { get; set; }
        public double?[]? relative_humidity_925hPa_member01 { get; set; }
        public double?[]? relative_humidity_925hPa_member02 { get; set; }
        public double?[]? relative_humidity_925hPa_member03 { get; set; }
        public double?[]? relative_humidity_925hPa_member04 { get; set; }
        public double?[]? relative_humidity_925hPa_member05 { get; set; }
        public double?[]? relative_humidity_925hPa_member06 { get; set; }
        public double?[]? relative_humidity_925hPa_member07 { get; set; }
        public double?[]? relative_humidity_925hPa_member08 { get; set; }
        public double?[]? relative_humidity_925hPa_member09 { get; set; }
        public double?[]? relative_humidity_925hPa_member10 { get; set; }
        public double?[]? relative_humidity_925hPa_member11 { get; set; }
        public double?[]? relative_humidity_925hPa_member12 { get; set; }
        public double?[]? relative_humidity_925hPa_member13 { get; set; }
        public double?[]? relative_humidity_925hPa_member14 { get; set; }
        public double?[]? relative_humidity_925hPa_member15 { get; set; }
        public double?[]? relative_humidity_925hPa_member16 { get; set; }
        public double?[]? relative_humidity_925hPa_member17 { get; set; }
        public double?[]? relative_humidity_925hPa_member18 { get; set; }
        public double?[]? relative_humidity_925hPa_member19 { get; set; }
        public double?[]? relative_humidity_925hPa_member20 { get; set; }
        public double?[]? relative_humidity_925hPa_member21 { get; set; }
        public double?[]? relative_humidity_925hPa_member22 { get; set; }
        public double?[]? relative_humidity_925hPa_member23 { get; set; }
        public double?[]? relative_humidity_925hPa_member24 { get; set; }
        public double?[]? relative_humidity_925hPa_member25 { get; set; }
        public double?[]? relative_humidity_925hPa_member26 { get; set; }
        public double?[]? relative_humidity_925hPa_member27 { get; set; }
        public double?[]? relative_humidity_925hPa_member28 { get; set; }
        public double?[]? relative_humidity_925hPa_member29 { get; set; }
        public double?[]? relative_humidity_925hPa_member30 { get; set; }
        public double?[]? relative_humidity_850hPa { get; set; }
        public double?[]? relative_humidity_850hPa_member01 { get; set; }
        public double?[]? relative_humidity_850hPa_member02 { get; set; }
        public double?[]? relative_humidity_850hPa_member03 { get; set; }
        public double?[]? relative_humidity_850hPa_member04 { get; set; }
        public double?[]? relative_humidity_850hPa_member05 { get; set; }
        public double?[]? relative_humidity_850hPa_member06 { get; set; }
        public double?[]? relative_humidity_850hPa_member07 { get; set; }
        public double?[]? relative_humidity_850hPa_member08 { get; set; }
        public double?[]? relative_humidity_850hPa_member09 { get; set; }
        public double?[]? relative_humidity_850hPa_member10 { get; set; }
        public double?[]? relative_humidity_850hPa_member11 { get; set; }
        public double?[]? relative_humidity_850hPa_member12 { get; set; }
        public double?[]? relative_humidity_850hPa_member13 { get; set; }
        public double?[]? relative_humidity_850hPa_member14 { get; set; }
        public double?[]? relative_humidity_850hPa_member15 { get; set; }
        public double?[]? relative_humidity_850hPa_member16 { get; set; }
        public double?[]? relative_humidity_850hPa_member17 { get; set; }
        public double?[]? relative_humidity_850hPa_member18 { get; set; }
        public double?[]? relative_humidity_850hPa_member19 { get; set; }
        public double?[]? relative_humidity_850hPa_member20 { get; set; }
        public double?[]? relative_humidity_850hPa_member21 { get; set; }
        public double?[]? relative_humidity_850hPa_member22 { get; set; }
        public double?[]? relative_humidity_850hPa_member23 { get; set; }
        public double?[]? relative_humidity_850hPa_member24 { get; set; }
        public double?[]? relative_humidity_850hPa_member25 { get; set; }
        public double?[]? relative_humidity_850hPa_member26 { get; set; }
        public double?[]? relative_humidity_850hPa_member27 { get; set; }
        public double?[]? relative_humidity_850hPa_member28 { get; set; }
        public double?[]? relative_humidity_850hPa_member29 { get; set; }
        public double?[]? relative_humidity_850hPa_member30 { get; set; }
        public double?[]? relative_humidity_700hPa { get; set; }
        public double?[]? relative_humidity_700hPa_member01 { get; set; }
        public double?[]? relative_humidity_700hPa_member02 { get; set; }
        public double?[]? relative_humidity_700hPa_member03 { get; set; }
        public double?[]? relative_humidity_700hPa_member04 { get; set; }
        public double?[]? relative_humidity_700hPa_member05 { get; set; }
        public double?[]? relative_humidity_700hPa_member06 { get; set; }
        public double?[]? relative_humidity_700hPa_member07 { get; set; }
        public double?[]? relative_humidity_700hPa_member08 { get; set; }
        public double?[]? relative_humidity_700hPa_member09 { get; set; }
        public double?[]? relative_humidity_700hPa_member10 { get; set; }
        public double?[]? relative_humidity_700hPa_member11 { get; set; }
        public double?[]? relative_humidity_700hPa_member12 { get; set; }
        public double?[]? relative_humidity_700hPa_member13 { get; set; }
        public double?[]? relative_humidity_700hPa_member14 { get; set; }
        public double?[]? relative_humidity_700hPa_member15 { get; set; }
        public double?[]? relative_humidity_700hPa_member16 { get; set; }
        public double?[]? relative_humidity_700hPa_member17 { get; set; }
        public double?[]? relative_humidity_700hPa_member18 { get; set; }
        public double?[]? relative_humidity_700hPa_member19 { get; set; }
        public double?[]? relative_humidity_700hPa_member20 { get; set; }
        public double?[]? relative_humidity_700hPa_member21 { get; set; }
        public double?[]? relative_humidity_700hPa_member22 { get; set; }
        public double?[]? relative_humidity_700hPa_member23 { get; set; }
        public double?[]? relative_humidity_700hPa_member24 { get; set; }
        public double?[]? relative_humidity_700hPa_member25 { get; set; }
        public double?[]? relative_humidity_700hPa_member26 { get; set; }
        public double?[]? relative_humidity_700hPa_member27 { get; set; }
        public double?[]? relative_humidity_700hPa_member28 { get; set; }
        public double?[]? relative_humidity_700hPa_member29 { get; set; }
        public double?[]? relative_humidity_700hPa_member30 { get; set; }
        public double?[]? relative_humidity_600hPa { get; set; }
        public double?[]? relative_humidity_600hPa_member01 { get; set; }
        public double?[]? relative_humidity_600hPa_member02 { get; set; }
        public double?[]? relative_humidity_600hPa_member03 { get; set; }
        public double?[]? relative_humidity_600hPa_member04 { get; set; }
        public double?[]? relative_humidity_600hPa_member05 { get; set; }
        public double?[]? relative_humidity_600hPa_member06 { get; set; }
        public double?[]? relative_humidity_600hPa_member07 { get; set; }
        public double?[]? relative_humidity_600hPa_member08 { get; set; }
        public double?[]? relative_humidity_600hPa_member09 { get; set; }
        public double?[]? relative_humidity_600hPa_member10 { get; set; }
        public double?[]? relative_humidity_600hPa_member11 { get; set; }
        public double?[]? relative_humidity_600hPa_member12 { get; set; }
        public double?[]? relative_humidity_600hPa_member13 { get; set; }
        public double?[]? relative_humidity_600hPa_member14 { get; set; }
        public double?[]? relative_humidity_600hPa_member15 { get; set; }
        public double?[]? relative_humidity_600hPa_member16 { get; set; }
        public double?[]? relative_humidity_600hPa_member17 { get; set; }
        public double?[]? relative_humidity_600hPa_member18 { get; set; }
        public double?[]? relative_humidity_600hPa_member19 { get; set; }
        public double?[]? relative_humidity_600hPa_member20 { get; set; }
        public double?[]? relative_humidity_600hPa_member21 { get; set; }
        public double?[]? relative_humidity_600hPa_member22 { get; set; }
        public double?[]? relative_humidity_600hPa_member23 { get; set; }
        public double?[]? relative_humidity_600hPa_member24 { get; set; }
        public double?[]? relative_humidity_600hPa_member25 { get; set; }
        public double?[]? relative_humidity_600hPa_member26 { get; set; }
        public double?[]? relative_humidity_600hPa_member27 { get; set; }
        public double?[]? relative_humidity_600hPa_member28 { get; set; }
        public double?[]? relative_humidity_600hPa_member29 { get; set; }
        public double?[]? relative_humidity_600hPa_member30 { get; set; }
        public double?[]? relative_humidity_500hPa { get; set; }
        public double?[]? relative_humidity_500hPa_member01 { get; set; }
        public double?[]? relative_humidity_500hPa_member02 { get; set; }
        public double?[]? relative_humidity_500hPa_member03 { get; set; }
        public double?[]? relative_humidity_500hPa_member04 { get; set; }
        public double?[]? relative_humidity_500hPa_member05 { get; set; }
        public double?[]? relative_humidity_500hPa_member06 { get; set; }
        public double?[]? relative_humidity_500hPa_member07 { get; set; }
        public double?[]? relative_humidity_500hPa_member08 { get; set; }
        public double?[]? relative_humidity_500hPa_member09 { get; set; }
        public double?[]? relative_humidity_500hPa_member10 { get; set; }
        public double?[]? relative_humidity_500hPa_member11 { get; set; }
        public double?[]? relative_humidity_500hPa_member12 { get; set; }
        public double?[]? relative_humidity_500hPa_member13 { get; set; }
        public double?[]? relative_humidity_500hPa_member14 { get; set; }
        public double?[]? relative_humidity_500hPa_member15 { get; set; }
        public double?[]? relative_humidity_500hPa_member16 { get; set; }
        public double?[]? relative_humidity_500hPa_member17 { get; set; }
        public double?[]? relative_humidity_500hPa_member18 { get; set; }
        public double?[]? relative_humidity_500hPa_member19 { get; set; }
        public double?[]? relative_humidity_500hPa_member20 { get; set; }
        public double?[]? relative_humidity_500hPa_member21 { get; set; }
        public double?[]? relative_humidity_500hPa_member22 { get; set; }
        public double?[]? relative_humidity_500hPa_member23 { get; set; }
        public double?[]? relative_humidity_500hPa_member24 { get; set; }
        public double?[]? relative_humidity_500hPa_member25 { get; set; }
        public double?[]? relative_humidity_500hPa_member26 { get; set; }
        public double?[]? relative_humidity_500hPa_member27 { get; set; }
        public double?[]? relative_humidity_500hPa_member28 { get; set; }
        public double?[]? relative_humidity_500hPa_member29 { get; set; }
        public double?[]? relative_humidity_500hPa_member30 { get; set; }
        public double?[]? relative_humidity_400hPa { get; set; }
        public double?[]? relative_humidity_400hPa_member01 { get; set; }
        public double?[]? relative_humidity_400hPa_member02 { get; set; }
        public double?[]? relative_humidity_400hPa_member03 { get; set; }
        public double?[]? relative_humidity_400hPa_member04 { get; set; }
        public double?[]? relative_humidity_400hPa_member05 { get; set; }
        public double?[]? relative_humidity_400hPa_member06 { get; set; }
        public double?[]? relative_humidity_400hPa_member07 { get; set; }
        public double?[]? relative_humidity_400hPa_member08 { get; set; }
        public double?[]? relative_humidity_400hPa_member09 { get; set; }
        public double?[]? relative_humidity_400hPa_member10 { get; set; }
        public double?[]? relative_humidity_400hPa_member11 { get; set; }
        public double?[]? relative_humidity_400hPa_member12 { get; set; }
        public double?[]? relative_humidity_400hPa_member13 { get; set; }
        public double?[]? relative_humidity_400hPa_member14 { get; set; }
        public double?[]? relative_humidity_400hPa_member15 { get; set; }
        public double?[]? relative_humidity_400hPa_member16 { get; set; }
        public double?[]? relative_humidity_400hPa_member17 { get; set; }
        public double?[]? relative_humidity_400hPa_member18 { get; set; }
        public double?[]? relative_humidity_400hPa_member19 { get; set; }
        public double?[]? relative_humidity_400hPa_member20 { get; set; }
        public double?[]? relative_humidity_400hPa_member21 { get; set; }
        public double?[]? relative_humidity_400hPa_member22 { get; set; }
        public double?[]? relative_humidity_400hPa_member23 { get; set; }
        public double?[]? relative_humidity_400hPa_member24 { get; set; }
        public double?[]? relative_humidity_400hPa_member25 { get; set; }
        public double?[]? relative_humidity_400hPa_member26 { get; set; }
        public double?[]? relative_humidity_400hPa_member27 { get; set; }
        public double?[]? relative_humidity_400hPa_member28 { get; set; }
        public double?[]? relative_humidity_400hPa_member29 { get; set; }
        public double?[]? relative_humidity_400hPa_member30 { get; set; }
        public double?[]? relative_humidity_300hPa { get; set; }
        public double?[]? relative_humidity_300hPa_member01 { get; set; }
        public double?[]? relative_humidity_300hPa_member02 { get; set; }
        public double?[]? relative_humidity_300hPa_member03 { get; set; }
        public double?[]? relative_humidity_300hPa_member04 { get; set; }
        public double?[]? relative_humidity_300hPa_member05 { get; set; }
        public double?[]? relative_humidity_300hPa_member06 { get; set; }
        public double?[]? relative_humidity_300hPa_member07 { get; set; }
        public double?[]? relative_humidity_300hPa_member08 { get; set; }
        public double?[]? relative_humidity_300hPa_member09 { get; set; }
        public double?[]? relative_humidity_300hPa_member10 { get; set; }
        public double?[]? relative_humidity_300hPa_member11 { get; set; }
        public double?[]? relative_humidity_300hPa_member12 { get; set; }
        public double?[]? relative_humidity_300hPa_member13 { get; set; }
        public double?[]? relative_humidity_300hPa_member14 { get; set; }
        public double?[]? relative_humidity_300hPa_member15 { get; set; }
        public double?[]? relative_humidity_300hPa_member16 { get; set; }
        public double?[]? relative_humidity_300hPa_member17 { get; set; }
        public double?[]? relative_humidity_300hPa_member18 { get; set; }
        public double?[]? relative_humidity_300hPa_member19 { get; set; }
        public double?[]? relative_humidity_300hPa_member20 { get; set; }
        public double?[]? relative_humidity_300hPa_member21 { get; set; }
        public double?[]? relative_humidity_300hPa_member22 { get; set; }
        public double?[]? relative_humidity_300hPa_member23 { get; set; }
        public double?[]? relative_humidity_300hPa_member24 { get; set; }
        public double?[]? relative_humidity_300hPa_member25 { get; set; }
        public double?[]? relative_humidity_300hPa_member26 { get; set; }
        public double?[]? relative_humidity_300hPa_member27 { get; set; }
        public double?[]? relative_humidity_300hPa_member28 { get; set; }
        public double?[]? relative_humidity_300hPa_member29 { get; set; }
        public double?[]? relative_humidity_300hPa_member30 { get; set; }
        public double?[]? relative_humidity_250hPa { get; set; }
        public double?[]? relative_humidity_250hPa_member01 { get; set; }
        public double?[]? relative_humidity_250hPa_member02 { get; set; }
        public double?[]? relative_humidity_250hPa_member03 { get; set; }
        public double?[]? relative_humidity_250hPa_member04 { get; set; }
        public double?[]? relative_humidity_250hPa_member05 { get; set; }
        public double?[]? relative_humidity_250hPa_member06 { get; set; }
        public double?[]? relative_humidity_250hPa_member07 { get; set; }
        public double?[]? relative_humidity_250hPa_member08 { get; set; }
        public double?[]? relative_humidity_250hPa_member09 { get; set; }
        public double?[]? relative_humidity_250hPa_member10 { get; set; }
        public double?[]? relative_humidity_250hPa_member11 { get; set; }
        public double?[]? relative_humidity_250hPa_member12 { get; set; }
        public double?[]? relative_humidity_250hPa_member13 { get; set; }
        public double?[]? relative_humidity_250hPa_member14 { get; set; }
        public double?[]? relative_humidity_250hPa_member15 { get; set; }
        public double?[]? relative_humidity_250hPa_member16 { get; set; }
        public double?[]? relative_humidity_250hPa_member17 { get; set; }
        public double?[]? relative_humidity_250hPa_member18 { get; set; }
        public double?[]? relative_humidity_250hPa_member19 { get; set; }
        public double?[]? relative_humidity_250hPa_member20 { get; set; }
        public double?[]? relative_humidity_250hPa_member21 { get; set; }
        public double?[]? relative_humidity_250hPa_member22 { get; set; }
        public double?[]? relative_humidity_250hPa_member23 { get; set; }
        public double?[]? relative_humidity_250hPa_member24 { get; set; }
        public double?[]? relative_humidity_250hPa_member25 { get; set; }
        public double?[]? relative_humidity_250hPa_member26 { get; set; }
        public double?[]? relative_humidity_250hPa_member27 { get; set; }
        public double?[]? relative_humidity_250hPa_member28 { get; set; }
        public double?[]? relative_humidity_250hPa_member29 { get; set; }
        public double?[]? relative_humidity_250hPa_member30 { get; set; }
        public double?[]? relative_humidity_200hPa { get; set; }
        public double?[]? relative_humidity_200hPa_member01 { get; set; }
        public double?[]? relative_humidity_200hPa_member02 { get; set; }
        public double?[]? relative_humidity_200hPa_member03 { get; set; }
        public double?[]? relative_humidity_200hPa_member04 { get; set; }
        public double?[]? relative_humidity_200hPa_member05 { get; set; }
        public double?[]? relative_humidity_200hPa_member06 { get; set; }
        public double?[]? relative_humidity_200hPa_member07 { get; set; }
        public double?[]? relative_humidity_200hPa_member08 { get; set; }
        public double?[]? relative_humidity_200hPa_member09 { get; set; }
        public double?[]? relative_humidity_200hPa_member10 { get; set; }
        public double?[]? relative_humidity_200hPa_member11 { get; set; }
        public double?[]? relative_humidity_200hPa_member12 { get; set; }
        public double?[]? relative_humidity_200hPa_member13 { get; set; }
        public double?[]? relative_humidity_200hPa_member14 { get; set; }
        public double?[]? relative_humidity_200hPa_member15 { get; set; }
        public double?[]? relative_humidity_200hPa_member16 { get; set; }
        public double?[]? relative_humidity_200hPa_member17 { get; set; }
        public double?[]? relative_humidity_200hPa_member18 { get; set; }
        public double?[]? relative_humidity_200hPa_member19 { get; set; }
        public double?[]? relative_humidity_200hPa_member20 { get; set; }
        public double?[]? relative_humidity_200hPa_member21 { get; set; }
        public double?[]? relative_humidity_200hPa_member22 { get; set; }
        public double?[]? relative_humidity_200hPa_member23 { get; set; }
        public double?[]? relative_humidity_200hPa_member24 { get; set; }
        public double?[]? relative_humidity_200hPa_member25 { get; set; }
        public double?[]? relative_humidity_200hPa_member26 { get; set; }
        public double?[]? relative_humidity_200hPa_member27 { get; set; }
        public double?[]? relative_humidity_200hPa_member28 { get; set; }
        public double?[]? relative_humidity_200hPa_member29 { get; set; }
        public double?[]? relative_humidity_200hPa_member30 { get; set; }
        public double?[]? relative_humidity_150hPa { get; set; }
        public double?[]? relative_humidity_150hPa_member01 { get; set; }
        public double?[]? relative_humidity_150hPa_member02 { get; set; }
        public double?[]? relative_humidity_150hPa_member03 { get; set; }
        public double?[]? relative_humidity_150hPa_member04 { get; set; }
        public double?[]? relative_humidity_150hPa_member05 { get; set; }
        public double?[]? relative_humidity_150hPa_member06 { get; set; }
        public double?[]? relative_humidity_150hPa_member07 { get; set; }
        public double?[]? relative_humidity_150hPa_member08 { get; set; }
        public double?[]? relative_humidity_150hPa_member09 { get; set; }
        public double?[]? relative_humidity_150hPa_member10 { get; set; }
        public double?[]? relative_humidity_150hPa_member11 { get; set; }
        public double?[]? relative_humidity_150hPa_member12 { get; set; }
        public double?[]? relative_humidity_150hPa_member13 { get; set; }
        public double?[]? relative_humidity_150hPa_member14 { get; set; }
        public double?[]? relative_humidity_150hPa_member15 { get; set; }
        public double?[]? relative_humidity_150hPa_member16 { get; set; }
        public double?[]? relative_humidity_150hPa_member17 { get; set; }
        public double?[]? relative_humidity_150hPa_member18 { get; set; }
        public double?[]? relative_humidity_150hPa_member19 { get; set; }
        public double?[]? relative_humidity_150hPa_member20 { get; set; }
        public double?[]? relative_humidity_150hPa_member21 { get; set; }
        public double?[]? relative_humidity_150hPa_member22 { get; set; }
        public double?[]? relative_humidity_150hPa_member23 { get; set; }
        public double?[]? relative_humidity_150hPa_member24 { get; set; }
        public double?[]? relative_humidity_150hPa_member25 { get; set; }
        public double?[]? relative_humidity_150hPa_member26 { get; set; }
        public double?[]? relative_humidity_150hPa_member27 { get; set; }
        public double?[]? relative_humidity_150hPa_member28 { get; set; }
        public double?[]? relative_humidity_150hPa_member29 { get; set; }
        public double?[]? relative_humidity_150hPa_member30 { get; set; }
        public double?[]? relative_humidity_100hPa { get; set; }
        public double?[]? relative_humidity_100hPa_member01 { get; set; }
        public double?[]? relative_humidity_100hPa_member02 { get; set; }
        public double?[]? relative_humidity_100hPa_member03 { get; set; }
        public double?[]? relative_humidity_100hPa_member04 { get; set; }
        public double?[]? relative_humidity_100hPa_member05 { get; set; }
        public double?[]? relative_humidity_100hPa_member06 { get; set; }
        public double?[]? relative_humidity_100hPa_member07 { get; set; }
        public double?[]? relative_humidity_100hPa_member08 { get; set; }
        public double?[]? relative_humidity_100hPa_member09 { get; set; }
        public double?[]? relative_humidity_100hPa_member10 { get; set; }
        public double?[]? relative_humidity_100hPa_member11 { get; set; }
        public double?[]? relative_humidity_100hPa_member12 { get; set; }
        public double?[]? relative_humidity_100hPa_member13 { get; set; }
        public double?[]? relative_humidity_100hPa_member14 { get; set; }
        public double?[]? relative_humidity_100hPa_member15 { get; set; }
        public double?[]? relative_humidity_100hPa_member16 { get; set; }
        public double?[]? relative_humidity_100hPa_member17 { get; set; }
        public double?[]? relative_humidity_100hPa_member18 { get; set; }
        public double?[]? relative_humidity_100hPa_member19 { get; set; }
        public double?[]? relative_humidity_100hPa_member20 { get; set; }
        public double?[]? relative_humidity_100hPa_member21 { get; set; }
        public double?[]? relative_humidity_100hPa_member22 { get; set; }
        public double?[]? relative_humidity_100hPa_member23 { get; set; }
        public double?[]? relative_humidity_100hPa_member24 { get; set; }
        public double?[]? relative_humidity_100hPa_member25 { get; set; }
        public double?[]? relative_humidity_100hPa_member26 { get; set; }
        public double?[]? relative_humidity_100hPa_member27 { get; set; }
        public double?[]? relative_humidity_100hPa_member28 { get; set; }
        public double?[]? relative_humidity_100hPa_member29 { get; set; }
        public double?[]? relative_humidity_100hPa_member30 { get; set; }
        public double?[]? relative_humidity_50hPa { get; set; }
        public double?[]? relative_humidity_50hPa_member01 { get; set; }
        public double?[]? relative_humidity_50hPa_member02 { get; set; }
        public double?[]? relative_humidity_50hPa_member03 { get; set; }
        public double?[]? relative_humidity_50hPa_member04 { get; set; }
        public double?[]? relative_humidity_50hPa_member05 { get; set; }
        public double?[]? relative_humidity_50hPa_member06 { get; set; }
        public double?[]? relative_humidity_50hPa_member07 { get; set; }
        public double?[]? relative_humidity_50hPa_member08 { get; set; }
        public double?[]? relative_humidity_50hPa_member09 { get; set; }
        public double?[]? relative_humidity_50hPa_member10 { get; set; }
        public double?[]? relative_humidity_50hPa_member11 { get; set; }
        public double?[]? relative_humidity_50hPa_member12 { get; set; }
        public double?[]? relative_humidity_50hPa_member13 { get; set; }
        public double?[]? relative_humidity_50hPa_member14 { get; set; }
        public double?[]? relative_humidity_50hPa_member15 { get; set; }
        public double?[]? relative_humidity_50hPa_member16 { get; set; }
        public double?[]? relative_humidity_50hPa_member17 { get; set; }
        public double?[]? relative_humidity_50hPa_member18 { get; set; }
        public double?[]? relative_humidity_50hPa_member19 { get; set; }
        public double?[]? relative_humidity_50hPa_member20 { get; set; }
        public double?[]? relative_humidity_50hPa_member21 { get; set; }
        public double?[]? relative_humidity_50hPa_member22 { get; set; }
        public double?[]? relative_humidity_50hPa_member23 { get; set; }
        public double?[]? relative_humidity_50hPa_member24 { get; set; }
        public double?[]? relative_humidity_50hPa_member25 { get; set; }
        public double?[]? relative_humidity_50hPa_member26 { get; set; }
        public double?[]? relative_humidity_50hPa_member27 { get; set; }
        public double?[]? relative_humidity_50hPa_member28 { get; set; }
        public double?[]? relative_humidity_50hPa_member29 { get; set; }
        public double?[]? relative_humidity_50hPa_member30 { get; set; }
        public double?[]? wind_speed_1000hPa { get; set; }
        public double?[]? wind_speed_1000hPa_member01 { get; set; }
        public double?[]? wind_speed_1000hPa_member02 { get; set; }
        public double?[]? wind_speed_1000hPa_member03 { get; set; }
        public double?[]? wind_speed_1000hPa_member04 { get; set; }
        public double?[]? wind_speed_1000hPa_member05 { get; set; }
        public double?[]? wind_speed_1000hPa_member06 { get; set; }
        public double?[]? wind_speed_1000hPa_member07 { get; set; }
        public double?[]? wind_speed_1000hPa_member08 { get; set; }
        public double?[]? wind_speed_1000hPa_member09 { get; set; }
        public double?[]? wind_speed_1000hPa_member10 { get; set; }
        public double?[]? wind_speed_1000hPa_member11 { get; set; }
        public double?[]? wind_speed_1000hPa_member12 { get; set; }
        public double?[]? wind_speed_1000hPa_member13 { get; set; }
        public double?[]? wind_speed_1000hPa_member14 { get; set; }
        public double?[]? wind_speed_1000hPa_member15 { get; set; }
        public double?[]? wind_speed_1000hPa_member16 { get; set; }
        public double?[]? wind_speed_1000hPa_member17 { get; set; }
        public double?[]? wind_speed_1000hPa_member18 { get; set; }
        public double?[]? wind_speed_1000hPa_member19 { get; set; }
        public double?[]? wind_speed_1000hPa_member20 { get; set; }
        public double?[]? wind_speed_1000hPa_member21 { get; set; }
        public double?[]? wind_speed_1000hPa_member22 { get; set; }
        public double?[]? wind_speed_1000hPa_member23 { get; set; }
        public double?[]? wind_speed_1000hPa_member24 { get; set; }
        public double?[]? wind_speed_1000hPa_member25 { get; set; }
        public double?[]? wind_speed_1000hPa_member26 { get; set; }
        public double?[]? wind_speed_1000hPa_member27 { get; set; }
        public double?[]? wind_speed_1000hPa_member28 { get; set; }
        public double?[]? wind_speed_1000hPa_member29 { get; set; }
        public double?[]? wind_speed_1000hPa_member30 { get; set; }
        public double?[]? wind_speed_925hPa { get; set; }
        public double?[]? wind_speed_925hPa_member01 { get; set; }
        public double?[]? wind_speed_925hPa_member02 { get; set; }
        public double?[]? wind_speed_925hPa_member03 { get; set; }
        public double?[]? wind_speed_925hPa_member04 { get; set; }
        public double?[]? wind_speed_925hPa_member05 { get; set; }
        public double?[]? wind_speed_925hPa_member06 { get; set; }
        public double?[]? wind_speed_925hPa_member07 { get; set; }
        public double?[]? wind_speed_925hPa_member08 { get; set; }
        public double?[]? wind_speed_925hPa_member09 { get; set; }
        public double?[]? wind_speed_925hPa_member10 { get; set; }
        public double?[]? wind_speed_925hPa_member11 { get; set; }
        public double?[]? wind_speed_925hPa_member12 { get; set; }
        public double?[]? wind_speed_925hPa_member13 { get; set; }
        public double?[]? wind_speed_925hPa_member14 { get; set; }
        public double?[]? wind_speed_925hPa_member15 { get; set; }
        public double?[]? wind_speed_925hPa_member16 { get; set; }
        public double?[]? wind_speed_925hPa_member17 { get; set; }
        public double?[]? wind_speed_925hPa_member18 { get; set; }
        public double?[]? wind_speed_925hPa_member19 { get; set; }
        public double?[]? wind_speed_925hPa_member20 { get; set; }
        public double?[]? wind_speed_925hPa_member21 { get; set; }
        public double?[]? wind_speed_925hPa_member22 { get; set; }
        public double?[]? wind_speed_925hPa_member23 { get; set; }
        public double?[]? wind_speed_925hPa_member24 { get; set; }
        public double?[]? wind_speed_925hPa_member25 { get; set; }
        public double?[]? wind_speed_925hPa_member26 { get; set; }
        public double?[]? wind_speed_925hPa_member27 { get; set; }
        public double?[]? wind_speed_925hPa_member28 { get; set; }
        public double?[]? wind_speed_925hPa_member29 { get; set; }
        public double?[]? wind_speed_925hPa_member30 { get; set; }
        public double?[]? wind_speed_850hPa { get; set; }
        public double?[]? wind_speed_850hPa_member01 { get; set; }
        public double?[]? wind_speed_850hPa_member02 { get; set; }
        public double?[]? wind_speed_850hPa_member03 { get; set; }
        public double?[]? wind_speed_850hPa_member04 { get; set; }
        public double?[]? wind_speed_850hPa_member05 { get; set; }
        public double?[]? wind_speed_850hPa_member06 { get; set; }
        public double?[]? wind_speed_850hPa_member07 { get; set; }
        public double?[]? wind_speed_850hPa_member08 { get; set; }
        public double?[]? wind_speed_850hPa_member09 { get; set; }
        public double?[]? wind_speed_850hPa_member10 { get; set; }
        public double?[]? wind_speed_850hPa_member11 { get; set; }
        public double?[]? wind_speed_850hPa_member12 { get; set; }
        public double?[]? wind_speed_850hPa_member13 { get; set; }
        public double?[]? wind_speed_850hPa_member14 { get; set; }
        public double?[]? wind_speed_850hPa_member15 { get; set; }
        public double?[]? wind_speed_850hPa_member16 { get; set; }
        public double?[]? wind_speed_850hPa_member17 { get; set; }
        public double?[]? wind_speed_850hPa_member18 { get; set; }
        public double?[]? wind_speed_850hPa_member19 { get; set; }
        public double?[]? wind_speed_850hPa_member20 { get; set; }
        public double?[]? wind_speed_850hPa_member21 { get; set; }
        public double?[]? wind_speed_850hPa_member22 { get; set; }
        public double?[]? wind_speed_850hPa_member23 { get; set; }
        public double?[]? wind_speed_850hPa_member24 { get; set; }
        public double?[]? wind_speed_850hPa_member25 { get; set; }
        public double?[]? wind_speed_850hPa_member26 { get; set; }
        public double?[]? wind_speed_850hPa_member27 { get; set; }
        public double?[]? wind_speed_850hPa_member28 { get; set; }
        public double?[]? wind_speed_850hPa_member29 { get; set; }
        public double?[]? wind_speed_850hPa_member30 { get; set; }
        public double?[]? wind_speed_700hPa { get; set; }
        public double?[]? wind_speed_700hPa_member01 { get; set; }
        public double?[]? wind_speed_700hPa_member02 { get; set; }
        public double?[]? wind_speed_700hPa_member03 { get; set; }
        public double?[]? wind_speed_700hPa_member04 { get; set; }
        public double?[]? wind_speed_700hPa_member05 { get; set; }
        public double?[]? wind_speed_700hPa_member06 { get; set; }
        public double?[]? wind_speed_700hPa_member07 { get; set; }
        public double?[]? wind_speed_700hPa_member08 { get; set; }
        public double?[]? wind_speed_700hPa_member09 { get; set; }
        public double?[]? wind_speed_700hPa_member10 { get; set; }
        public double?[]? wind_speed_700hPa_member11 { get; set; }
        public double?[]? wind_speed_700hPa_member12 { get; set; }
        public double?[]? wind_speed_700hPa_member13 { get; set; }
        public double?[]? wind_speed_700hPa_member14 { get; set; }
        public double?[]? wind_speed_700hPa_member15 { get; set; }
        public double?[]? wind_speed_700hPa_member16 { get; set; }
        public double?[]? wind_speed_700hPa_member17 { get; set; }
        public double?[]? wind_speed_700hPa_member18 { get; set; }
        public double?[]? wind_speed_700hPa_member19 { get; set; }
        public double?[]? wind_speed_700hPa_member20 { get; set; }
        public double?[]? wind_speed_700hPa_member21 { get; set; }
        public double?[]? wind_speed_700hPa_member22 { get; set; }
        public double?[]? wind_speed_700hPa_member23 { get; set; }
        public double?[]? wind_speed_700hPa_member24 { get; set; }
        public double?[]? wind_speed_700hPa_member25 { get; set; }
        public double?[]? wind_speed_700hPa_member26 { get; set; }
        public double?[]? wind_speed_700hPa_member27 { get; set; }
        public double?[]? wind_speed_700hPa_member28 { get; set; }
        public double?[]? wind_speed_700hPa_member29 { get; set; }
        public double?[]? wind_speed_700hPa_member30 { get; set; }
        public double?[]? wind_speed_600hPa { get; set; }
        public double?[]? wind_speed_600hPa_member01 { get; set; }
        public double?[]? wind_speed_600hPa_member02 { get; set; }
        public double?[]? wind_speed_600hPa_member03 { get; set; }
        public double?[]? wind_speed_600hPa_member04 { get; set; }
        public double?[]? wind_speed_600hPa_member05 { get; set; }
        public double?[]? wind_speed_600hPa_member06 { get; set; }
        public double?[]? wind_speed_600hPa_member07 { get; set; }
        public double?[]? wind_speed_600hPa_member08 { get; set; }
        public double?[]? wind_speed_600hPa_member09 { get; set; }
        public double?[]? wind_speed_600hPa_member10 { get; set; }
        public double?[]? wind_speed_600hPa_member11 { get; set; }
        public double?[]? wind_speed_600hPa_member12 { get; set; }
        public double?[]? wind_speed_600hPa_member13 { get; set; }
        public double?[]? wind_speed_600hPa_member14 { get; set; }
        public double?[]? wind_speed_600hPa_member15 { get; set; }
        public double?[]? wind_speed_600hPa_member16 { get; set; }
        public double?[]? wind_speed_600hPa_member17 { get; set; }
        public double?[]? wind_speed_600hPa_member18 { get; set; }
        public double?[]? wind_speed_600hPa_member19 { get; set; }
        public double?[]? wind_speed_600hPa_member20 { get; set; }
        public double?[]? wind_speed_600hPa_member21 { get; set; }
        public double?[]? wind_speed_600hPa_member22 { get; set; }
        public double?[]? wind_speed_600hPa_member23 { get; set; }
        public double?[]? wind_speed_600hPa_member24 { get; set; }
        public double?[]? wind_speed_600hPa_member25 { get; set; }
        public double?[]? wind_speed_600hPa_member26 { get; set; }
        public double?[]? wind_speed_600hPa_member27 { get; set; }
        public double?[]? wind_speed_600hPa_member28 { get; set; }
        public double?[]? wind_speed_600hPa_member29 { get; set; }
        public double?[]? wind_speed_600hPa_member30 { get; set; }
        public double?[]? wind_speed_500hPa { get; set; }
        public double?[]? wind_speed_500hPa_member01 { get; set; }
        public double?[]? wind_speed_500hPa_member02 { get; set; }
        public double?[]? wind_speed_500hPa_member03 { get; set; }
        public double?[]? wind_speed_500hPa_member04 { get; set; }
        public double?[]? wind_speed_500hPa_member05 { get; set; }
        public double?[]? wind_speed_500hPa_member06 { get; set; }
        public double?[]? wind_speed_500hPa_member07 { get; set; }
        public double?[]? wind_speed_500hPa_member08 { get; set; }
        public double?[]? wind_speed_500hPa_member09 { get; set; }
        public double?[]? wind_speed_500hPa_member10 { get; set; }
        public double?[]? wind_speed_500hPa_member11 { get; set; }
        public double?[]? wind_speed_500hPa_member12 { get; set; }
        public double?[]? wind_speed_500hPa_member13 { get; set; }
        public double?[]? wind_speed_500hPa_member14 { get; set; }
        public double?[]? wind_speed_500hPa_member15 { get; set; }
        public double?[]? wind_speed_500hPa_member16 { get; set; }
        public double?[]? wind_speed_500hPa_member17 { get; set; }
        public double?[]? wind_speed_500hPa_member18 { get; set; }
        public double?[]? wind_speed_500hPa_member19 { get; set; }
        public double?[]? wind_speed_500hPa_member20 { get; set; }
        public double?[]? wind_speed_500hPa_member21 { get; set; }
        public double?[]? wind_speed_500hPa_member22 { get; set; }
        public double?[]? wind_speed_500hPa_member23 { get; set; }
        public double?[]? wind_speed_500hPa_member24 { get; set; }
        public double?[]? wind_speed_500hPa_member25 { get; set; }
        public double?[]? wind_speed_500hPa_member26 { get; set; }
        public double?[]? wind_speed_500hPa_member27 { get; set; }
        public double?[]? wind_speed_500hPa_member28 { get; set; }
        public double?[]? wind_speed_500hPa_member29 { get; set; }
        public double?[]? wind_speed_500hPa_member30 { get; set; }
        public double?[]? wind_speed_400hPa { get; set; }
        public double?[]? wind_speed_400hPa_member01 { get; set; }
        public double?[]? wind_speed_400hPa_member02 { get; set; }
        public double?[]? wind_speed_400hPa_member03 { get; set; }
        public double?[]? wind_speed_400hPa_member04 { get; set; }
        public double?[]? wind_speed_400hPa_member05 { get; set; }
        public double?[]? wind_speed_400hPa_member06 { get; set; }
        public double?[]? wind_speed_400hPa_member07 { get; set; }
        public double?[]? wind_speed_400hPa_member08 { get; set; }
        public double?[]? wind_speed_400hPa_member09 { get; set; }
        public double?[]? wind_speed_400hPa_member10 { get; set; }
        public double?[]? wind_speed_400hPa_member11 { get; set; }
        public double?[]? wind_speed_400hPa_member12 { get; set; }
        public double?[]? wind_speed_400hPa_member13 { get; set; }
        public double?[]? wind_speed_400hPa_member14 { get; set; }
        public double?[]? wind_speed_400hPa_member15 { get; set; }
        public double?[]? wind_speed_400hPa_member16 { get; set; }
        public double?[]? wind_speed_400hPa_member17 { get; set; }
        public double?[]? wind_speed_400hPa_member18 { get; set; }
        public double?[]? wind_speed_400hPa_member19 { get; set; }
        public double?[]? wind_speed_400hPa_member20 { get; set; }
        public double?[]? wind_speed_400hPa_member21 { get; set; }
        public double?[]? wind_speed_400hPa_member22 { get; set; }
        public double?[]? wind_speed_400hPa_member23 { get; set; }
        public double?[]? wind_speed_400hPa_member24 { get; set; }
        public double?[]? wind_speed_400hPa_member25 { get; set; }
        public double?[]? wind_speed_400hPa_member26 { get; set; }
        public double?[]? wind_speed_400hPa_member27 { get; set; }
        public double?[]? wind_speed_400hPa_member28 { get; set; }
        public double?[]? wind_speed_400hPa_member29 { get; set; }
        public double?[]? wind_speed_400hPa_member30 { get; set; }
        public double?[]? wind_speed_300hPa { get; set; }
        public double?[]? wind_speed_300hPa_member01 { get; set; }
        public double?[]? wind_speed_300hPa_member02 { get; set; }
        public double?[]? wind_speed_300hPa_member03 { get; set; }
        public double?[]? wind_speed_300hPa_member04 { get; set; }
        public double?[]? wind_speed_300hPa_member05 { get; set; }
        public double?[]? wind_speed_300hPa_member06 { get; set; }
        public double?[]? wind_speed_300hPa_member07 { get; set; }
        public double?[]? wind_speed_300hPa_member08 { get; set; }
        public double?[]? wind_speed_300hPa_member09 { get; set; }
        public double?[]? wind_speed_300hPa_member10 { get; set; }
        public double?[]? wind_speed_300hPa_member11 { get; set; }
        public double?[]? wind_speed_300hPa_member12 { get; set; }
        public double?[]? wind_speed_300hPa_member13 { get; set; }
        public double?[]? wind_speed_300hPa_member14 { get; set; }
        public double?[]? wind_speed_300hPa_member15 { get; set; }
        public double?[]? wind_speed_300hPa_member16 { get; set; }
        public double?[]? wind_speed_300hPa_member17 { get; set; }
        public double?[]? wind_speed_300hPa_member18 { get; set; }
        public double?[]? wind_speed_300hPa_member19 { get; set; }
        public double?[]? wind_speed_300hPa_member20 { get; set; }
        public double?[]? wind_speed_300hPa_member21 { get; set; }
        public double?[]? wind_speed_300hPa_member22 { get; set; }
        public double?[]? wind_speed_300hPa_member23 { get; set; }
        public double?[]? wind_speed_300hPa_member24 { get; set; }
        public double?[]? wind_speed_300hPa_member25 { get; set; }
        public double?[]? wind_speed_300hPa_member26 { get; set; }
        public double?[]? wind_speed_300hPa_member27 { get; set; }
        public double?[]? wind_speed_300hPa_member28 { get; set; }
        public double?[]? wind_speed_300hPa_member29 { get; set; }
        public double?[]? wind_speed_300hPa_member30 { get; set; }
        public double?[]? wind_speed_250hPa { get; set; }
        public double?[]? wind_speed_250hPa_member01 { get; set; }
        public double?[]? wind_speed_250hPa_member02 { get; set; }
        public double?[]? wind_speed_250hPa_member03 { get; set; }
        public double?[]? wind_speed_250hPa_member04 { get; set; }
        public double?[]? wind_speed_250hPa_member05 { get; set; }
        public double?[]? wind_speed_250hPa_member06 { get; set; }
        public double?[]? wind_speed_250hPa_member07 { get; set; }
        public double?[]? wind_speed_250hPa_member08 { get; set; }
        public double?[]? wind_speed_250hPa_member09 { get; set; }
        public double?[]? wind_speed_250hPa_member10 { get; set; }
        public double?[]? wind_speed_250hPa_member11 { get; set; }
        public double?[]? wind_speed_250hPa_member12 { get; set; }
        public double?[]? wind_speed_250hPa_member13 { get; set; }
        public double?[]? wind_speed_250hPa_member14 { get; set; }
        public double?[]? wind_speed_250hPa_member15 { get; set; }
        public double?[]? wind_speed_250hPa_member16 { get; set; }
        public double?[]? wind_speed_250hPa_member17 { get; set; }
        public double?[]? wind_speed_250hPa_member18 { get; set; }
        public double?[]? wind_speed_250hPa_member19 { get; set; }
        public double?[]? wind_speed_250hPa_member20 { get; set; }
        public double?[]? wind_speed_250hPa_member21 { get; set; }
        public double?[]? wind_speed_250hPa_member22 { get; set; }
        public double?[]? wind_speed_250hPa_member23 { get; set; }
        public double?[]? wind_speed_250hPa_member24 { get; set; }
        public double?[]? wind_speed_250hPa_member25 { get; set; }
        public double?[]? wind_speed_250hPa_member26 { get; set; }
        public double?[]? wind_speed_250hPa_member27 { get; set; }
        public double?[]? wind_speed_250hPa_member28 { get; set; }
        public double?[]? wind_speed_250hPa_member29 { get; set; }
        public double?[]? wind_speed_250hPa_member30 { get; set; }
        public double?[]? wind_speed_200hPa { get; set; }
        public double?[]? wind_speed_200hPa_member01 { get; set; }
        public double?[]? wind_speed_200hPa_member02 { get; set; }
        public double?[]? wind_speed_200hPa_member03 { get; set; }
        public double?[]? wind_speed_200hPa_member04 { get; set; }
        public double?[]? wind_speed_200hPa_member05 { get; set; }
        public double?[]? wind_speed_200hPa_member06 { get; set; }
        public double?[]? wind_speed_200hPa_member07 { get; set; }
        public double?[]? wind_speed_200hPa_member08 { get; set; }
        public double?[]? wind_speed_200hPa_member09 { get; set; }
        public double?[]? wind_speed_200hPa_member10 { get; set; }
        public double?[]? wind_speed_200hPa_member11 { get; set; }
        public double?[]? wind_speed_200hPa_member12 { get; set; }
        public double?[]? wind_speed_200hPa_member13 { get; set; }
        public double?[]? wind_speed_200hPa_member14 { get; set; }
        public double?[]? wind_speed_200hPa_member15 { get; set; }
        public double?[]? wind_speed_200hPa_member16 { get; set; }
        public double?[]? wind_speed_200hPa_member17 { get; set; }
        public double?[]? wind_speed_200hPa_member18 { get; set; }
        public double?[]? wind_speed_200hPa_member19 { get; set; }
        public double?[]? wind_speed_200hPa_member20 { get; set; }
        public double?[]? wind_speed_200hPa_member21 { get; set; }
        public double?[]? wind_speed_200hPa_member22 { get; set; }
        public double?[]? wind_speed_200hPa_member23 { get; set; }
        public double?[]? wind_speed_200hPa_member24 { get; set; }
        public double?[]? wind_speed_200hPa_member25 { get; set; }
        public double?[]? wind_speed_200hPa_member26 { get; set; }
        public double?[]? wind_speed_200hPa_member27 { get; set; }
        public double?[]? wind_speed_200hPa_member28 { get; set; }
        public double?[]? wind_speed_200hPa_member29 { get; set; }
        public double?[]? wind_speed_200hPa_member30 { get; set; }
        public double?[]? wind_speed_150hPa { get; set; }
        public double?[]? wind_speed_150hPa_member01 { get; set; }
        public double?[]? wind_speed_150hPa_member02 { get; set; }
        public double?[]? wind_speed_150hPa_member03 { get; set; }
        public double?[]? wind_speed_150hPa_member04 { get; set; }
        public double?[]? wind_speed_150hPa_member05 { get; set; }
        public double?[]? wind_speed_150hPa_member06 { get; set; }
        public double?[]? wind_speed_150hPa_member07 { get; set; }
        public double?[]? wind_speed_150hPa_member08 { get; set; }
        public double?[]? wind_speed_150hPa_member09 { get; set; }
        public double?[]? wind_speed_150hPa_member10 { get; set; }
        public double?[]? wind_speed_150hPa_member11 { get; set; }
        public double?[]? wind_speed_150hPa_member12 { get; set; }
        public double?[]? wind_speed_150hPa_member13 { get; set; }
        public double?[]? wind_speed_150hPa_member14 { get; set; }
        public double?[]? wind_speed_150hPa_member15 { get; set; }
        public double?[]? wind_speed_150hPa_member16 { get; set; }
        public double?[]? wind_speed_150hPa_member17 { get; set; }
        public double?[]? wind_speed_150hPa_member18 { get; set; }
        public double?[]? wind_speed_150hPa_member19 { get; set; }
        public double?[]? wind_speed_150hPa_member20 { get; set; }
        public double?[]? wind_speed_150hPa_member21 { get; set; }
        public double?[]? wind_speed_150hPa_member22 { get; set; }
        public double?[]? wind_speed_150hPa_member23 { get; set; }
        public double?[]? wind_speed_150hPa_member24 { get; set; }
        public double?[]? wind_speed_150hPa_member25 { get; set; }
        public double?[]? wind_speed_150hPa_member26 { get; set; }
        public double?[]? wind_speed_150hPa_member27 { get; set; }
        public double?[]? wind_speed_150hPa_member28 { get; set; }
        public double?[]? wind_speed_150hPa_member29 { get; set; }
        public double?[]? wind_speed_150hPa_member30 { get; set; }
        public double?[]? wind_speed_100hPa { get; set; }
        public double?[]? wind_speed_100hPa_member01 { get; set; }
        public double?[]? wind_speed_100hPa_member02 { get; set; }
        public double?[]? wind_speed_100hPa_member03 { get; set; }
        public double?[]? wind_speed_100hPa_member04 { get; set; }
        public double?[]? wind_speed_100hPa_member05 { get; set; }
        public double?[]? wind_speed_100hPa_member06 { get; set; }
        public double?[]? wind_speed_100hPa_member07 { get; set; }
        public double?[]? wind_speed_100hPa_member08 { get; set; }
        public double?[]? wind_speed_100hPa_member09 { get; set; }
        public double?[]? wind_speed_100hPa_member10 { get; set; }
        public double?[]? wind_speed_100hPa_member11 { get; set; }
        public double?[]? wind_speed_100hPa_member12 { get; set; }
        public double?[]? wind_speed_100hPa_member13 { get; set; }
        public double?[]? wind_speed_100hPa_member14 { get; set; }
        public double?[]? wind_speed_100hPa_member15 { get; set; }
        public double?[]? wind_speed_100hPa_member16 { get; set; }
        public double?[]? wind_speed_100hPa_member17 { get; set; }
        public double?[]? wind_speed_100hPa_member18 { get; set; }
        public double?[]? wind_speed_100hPa_member19 { get; set; }
        public double?[]? wind_speed_100hPa_member20 { get; set; }
        public double?[]? wind_speed_100hPa_member21 { get; set; }
        public double?[]? wind_speed_100hPa_member22 { get; set; }
        public double?[]? wind_speed_100hPa_member23 { get; set; }
        public double?[]? wind_speed_100hPa_member24 { get; set; }
        public double?[]? wind_speed_100hPa_member25 { get; set; }
        public double?[]? wind_speed_100hPa_member26 { get; set; }
        public double?[]? wind_speed_100hPa_member27 { get; set; }
        public double?[]? wind_speed_100hPa_member28 { get; set; }
        public double?[]? wind_speed_100hPa_member29 { get; set; }
        public double?[]? wind_speed_100hPa_member30 { get; set; }
        public double?[]? wind_speed_50hPa { get; set; }
        public double?[]? wind_speed_50hPa_member01 { get; set; }
        public double?[]? wind_speed_50hPa_member02 { get; set; }
        public double?[]? wind_speed_50hPa_member03 { get; set; }
        public double?[]? wind_speed_50hPa_member04 { get; set; }
        public double?[]? wind_speed_50hPa_member05 { get; set; }
        public double?[]? wind_speed_50hPa_member06 { get; set; }
        public double?[]? wind_speed_50hPa_member07 { get; set; }
        public double?[]? wind_speed_50hPa_member08 { get; set; }
        public double?[]? wind_speed_50hPa_member09 { get; set; }
        public double?[]? wind_speed_50hPa_member10 { get; set; }
        public double?[]? wind_speed_50hPa_member11 { get; set; }
        public double?[]? wind_speed_50hPa_member12 { get; set; }
        public double?[]? wind_speed_50hPa_member13 { get; set; }
        public double?[]? wind_speed_50hPa_member14 { get; set; }
        public double?[]? wind_speed_50hPa_member15 { get; set; }
        public double?[]? wind_speed_50hPa_member16 { get; set; }
        public double?[]? wind_speed_50hPa_member17 { get; set; }
        public double?[]? wind_speed_50hPa_member18 { get; set; }
        public double?[]? wind_speed_50hPa_member19 { get; set; }
        public double?[]? wind_speed_50hPa_member20 { get; set; }
        public double?[]? wind_speed_50hPa_member21 { get; set; }
        public double?[]? wind_speed_50hPa_member22 { get; set; }
        public double?[]? wind_speed_50hPa_member23 { get; set; }
        public double?[]? wind_speed_50hPa_member24 { get; set; }
        public double?[]? wind_speed_50hPa_member25 { get; set; }
        public double?[]? wind_speed_50hPa_member26 { get; set; }
        public double?[]? wind_speed_50hPa_member27 { get; set; }
        public double?[]? wind_speed_50hPa_member28 { get; set; }
        public double?[]? wind_speed_50hPa_member29 { get; set; }
        public double?[]? wind_speed_50hPa_member30 { get; set; }
        public double?[]? wind_direction_1000hPa { get; set; }
        public double?[]? wind_direction_1000hPa_member01 { get; set; }
        public double?[]? wind_direction_1000hPa_member02 { get; set; }
        public double?[]? wind_direction_1000hPa_member03 { get; set; }
        public double?[]? wind_direction_1000hPa_member04 { get; set; }
        public double?[]? wind_direction_1000hPa_member05 { get; set; }
        public double?[]? wind_direction_1000hPa_member06 { get; set; }
        public double?[]? wind_direction_1000hPa_member07 { get; set; }
        public double?[]? wind_direction_1000hPa_member08 { get; set; }
        public double?[]? wind_direction_1000hPa_member09 { get; set; }
        public double?[]? wind_direction_1000hPa_member10 { get; set; }
        public double?[]? wind_direction_1000hPa_member11 { get; set; }
        public double?[]? wind_direction_1000hPa_member12 { get; set; }
        public double?[]? wind_direction_1000hPa_member13 { get; set; }
        public double?[]? wind_direction_1000hPa_member14 { get; set; }
        public double?[]? wind_direction_1000hPa_member15 { get; set; }
        public double?[]? wind_direction_1000hPa_member16 { get; set; }
        public double?[]? wind_direction_1000hPa_member17 { get; set; }
        public double?[]? wind_direction_1000hPa_member18 { get; set; }
        public double?[]? wind_direction_1000hPa_member19 { get; set; }
        public double?[]? wind_direction_1000hPa_member20 { get; set; }
        public double?[]? wind_direction_1000hPa_member21 { get; set; }
        public double?[]? wind_direction_1000hPa_member22 { get; set; }
        public double?[]? wind_direction_1000hPa_member23 { get; set; }
        public double?[]? wind_direction_1000hPa_member24 { get; set; }
        public double?[]? wind_direction_1000hPa_member25 { get; set; }
        public double?[]? wind_direction_1000hPa_member26 { get; set; }
        public double?[]? wind_direction_1000hPa_member27 { get; set; }
        public double?[]? wind_direction_1000hPa_member28 { get; set; }
        public double?[]? wind_direction_1000hPa_member29 { get; set; }
        public double?[]? wind_direction_1000hPa_member30 { get; set; }
        public double?[]? wind_direction_925hPa { get; set; }
        public double?[]? wind_direction_925hPa_member01 { get; set; }
        public double?[]? wind_direction_925hPa_member02 { get; set; }
        public double?[]? wind_direction_925hPa_member03 { get; set; }
        public double?[]? wind_direction_925hPa_member04 { get; set; }
        public double?[]? wind_direction_925hPa_member05 { get; set; }
        public double?[]? wind_direction_925hPa_member06 { get; set; }
        public double?[]? wind_direction_925hPa_member07 { get; set; }
        public double?[]? wind_direction_925hPa_member08 { get; set; }
        public double?[]? wind_direction_925hPa_member09 { get; set; }
        public double?[]? wind_direction_925hPa_member10 { get; set; }
        public double?[]? wind_direction_925hPa_member11 { get; set; }
        public double?[]? wind_direction_925hPa_member12 { get; set; }
        public double?[]? wind_direction_925hPa_member13 { get; set; }
        public double?[]? wind_direction_925hPa_member14 { get; set; }
        public double?[]? wind_direction_925hPa_member15 { get; set; }
        public double?[]? wind_direction_925hPa_member16 { get; set; }
        public double?[]? wind_direction_925hPa_member17 { get; set; }
        public double?[]? wind_direction_925hPa_member18 { get; set; }
        public double?[]? wind_direction_925hPa_member19 { get; set; }
        public double?[]? wind_direction_925hPa_member20 { get; set; }
        public double?[]? wind_direction_925hPa_member21 { get; set; }
        public double?[]? wind_direction_925hPa_member22 { get; set; }
        public double?[]? wind_direction_925hPa_member23 { get; set; }
        public double?[]? wind_direction_925hPa_member24 { get; set; }
        public double?[]? wind_direction_925hPa_member25 { get; set; }
        public double?[]? wind_direction_925hPa_member26 { get; set; }
        public double?[]? wind_direction_925hPa_member27 { get; set; }
        public double?[]? wind_direction_925hPa_member28 { get; set; }
        public double?[]? wind_direction_925hPa_member29 { get; set; }
        public double?[]? wind_direction_925hPa_member30 { get; set; }
        public double?[]? wind_direction_850hPa { get; set; }
        public double?[]? wind_direction_850hPa_member01 { get; set; }
        public double?[]? wind_direction_850hPa_member02 { get; set; }
        public double?[]? wind_direction_850hPa_member03 { get; set; }
        public double?[]? wind_direction_850hPa_member04 { get; set; }
        public double?[]? wind_direction_850hPa_member05 { get; set; }
        public double?[]? wind_direction_850hPa_member06 { get; set; }
        public double?[]? wind_direction_850hPa_member07 { get; set; }
        public double?[]? wind_direction_850hPa_member08 { get; set; }
        public double?[]? wind_direction_850hPa_member09 { get; set; }
        public double?[]? wind_direction_850hPa_member10 { get; set; }
        public double?[]? wind_direction_850hPa_member11 { get; set; }
        public double?[]? wind_direction_850hPa_member12 { get; set; }
        public double?[]? wind_direction_850hPa_member13 { get; set; }
        public double?[]? wind_direction_850hPa_member14 { get; set; }
        public double?[]? wind_direction_850hPa_member15 { get; set; }
        public double?[]? wind_direction_850hPa_member16 { get; set; }
        public double?[]? wind_direction_850hPa_member17 { get; set; }
        public double?[]? wind_direction_850hPa_member18 { get; set; }
        public double?[]? wind_direction_850hPa_member19 { get; set; }
        public double?[]? wind_direction_850hPa_member20 { get; set; }
        public double?[]? wind_direction_850hPa_member21 { get; set; }
        public double?[]? wind_direction_850hPa_member22 { get; set; }
        public double?[]? wind_direction_850hPa_member23 { get; set; }
        public double?[]? wind_direction_850hPa_member24 { get; set; }
        public double?[]? wind_direction_850hPa_member25 { get; set; }
        public double?[]? wind_direction_850hPa_member26 { get; set; }
        public double?[]? wind_direction_850hPa_member27 { get; set; }
        public double?[]? wind_direction_850hPa_member28 { get; set; }
        public double?[]? wind_direction_850hPa_member29 { get; set; }
        public double?[]? wind_direction_850hPa_member30 { get; set; }
        public double?[]? wind_direction_700hPa { get; set; }
        public double?[]? wind_direction_700hPa_member01 { get; set; }
        public double?[]? wind_direction_700hPa_member02 { get; set; }
        public double?[]? wind_direction_700hPa_member03 { get; set; }
        public double?[]? wind_direction_700hPa_member04 { get; set; }
        public double?[]? wind_direction_700hPa_member05 { get; set; }
        public double?[]? wind_direction_700hPa_member06 { get; set; }
        public double?[]? wind_direction_700hPa_member07 { get; set; }
        public double?[]? wind_direction_700hPa_member08 { get; set; }
        public double?[]? wind_direction_700hPa_member09 { get; set; }
        public double?[]? wind_direction_700hPa_member10 { get; set; }
        public double?[]? wind_direction_700hPa_member11 { get; set; }
        public double?[]? wind_direction_700hPa_member12 { get; set; }
        public double?[]? wind_direction_700hPa_member13 { get; set; }
        public double?[]? wind_direction_700hPa_member14 { get; set; }
        public double?[]? wind_direction_700hPa_member15 { get; set; }
        public double?[]? wind_direction_700hPa_member16 { get; set; }
        public double?[]? wind_direction_700hPa_member17 { get; set; }
        public double?[]? wind_direction_700hPa_member18 { get; set; }
        public double?[]? wind_direction_700hPa_member19 { get; set; }
        public double?[]? wind_direction_700hPa_member20 { get; set; }
        public double?[]? wind_direction_700hPa_member21 { get; set; }
        public double?[]? wind_direction_700hPa_member22 { get; set; }
        public double?[]? wind_direction_700hPa_member23 { get; set; }
        public double?[]? wind_direction_700hPa_member24 { get; set; }
        public double?[]? wind_direction_700hPa_member25 { get; set; }
        public double?[]? wind_direction_700hPa_member26 { get; set; }
        public double?[]? wind_direction_700hPa_member27 { get; set; }
        public double?[]? wind_direction_700hPa_member28 { get; set; }
        public double?[]? wind_direction_700hPa_member29 { get; set; }
        public double?[]? wind_direction_700hPa_member30 { get; set; }
        public double?[]? wind_direction_600hPa { get; set; }
        public double?[]? wind_direction_600hPa_member01 { get; set; }
        public double?[]? wind_direction_600hPa_member02 { get; set; }
        public double?[]? wind_direction_600hPa_member03 { get; set; }
        public double?[]? wind_direction_600hPa_member04 { get; set; }
        public double?[]? wind_direction_600hPa_member05 { get; set; }
        public double?[]? wind_direction_600hPa_member06 { get; set; }
        public double?[]? wind_direction_600hPa_member07 { get; set; }
        public double?[]? wind_direction_600hPa_member08 { get; set; }
        public double?[]? wind_direction_600hPa_member09 { get; set; }
        public double?[]? wind_direction_600hPa_member10 { get; set; }
        public double?[]? wind_direction_600hPa_member11 { get; set; }
        public double?[]? wind_direction_600hPa_member12 { get; set; }
        public double?[]? wind_direction_600hPa_member13 { get; set; }
        public double?[]? wind_direction_600hPa_member14 { get; set; }
        public double?[]? wind_direction_600hPa_member15 { get; set; }
        public double?[]? wind_direction_600hPa_member16 { get; set; }
        public double?[]? wind_direction_600hPa_member17 { get; set; }
        public double?[]? wind_direction_600hPa_member18 { get; set; }
        public double?[]? wind_direction_600hPa_member19 { get; set; }
        public double?[]? wind_direction_600hPa_member20 { get; set; }
        public double?[]? wind_direction_600hPa_member21 { get; set; }
        public double?[]? wind_direction_600hPa_member22 { get; set; }
        public double?[]? wind_direction_600hPa_member23 { get; set; }
        public double?[]? wind_direction_600hPa_member24 { get; set; }
        public double?[]? wind_direction_600hPa_member25 { get; set; }
        public double?[]? wind_direction_600hPa_member26 { get; set; }
        public double?[]? wind_direction_600hPa_member27 { get; set; }
        public double?[]? wind_direction_600hPa_member28 { get; set; }
        public double?[]? wind_direction_600hPa_member29 { get; set; }
        public double?[]? wind_direction_600hPa_member30 { get; set; }
        public double?[]? wind_direction_500hPa { get; set; }
        public double?[]? wind_direction_500hPa_member01 { get; set; }
        public double?[]? wind_direction_500hPa_member02 { get; set; }
        public double?[]? wind_direction_500hPa_member03 { get; set; }
        public double?[]? wind_direction_500hPa_member04 { get; set; }
        public double?[]? wind_direction_500hPa_member05 { get; set; }
        public double?[]? wind_direction_500hPa_member06 { get; set; }
        public double?[]? wind_direction_500hPa_member07 { get; set; }
        public double?[]? wind_direction_500hPa_member08 { get; set; }
        public double?[]? wind_direction_500hPa_member09 { get; set; }
        public double?[]? wind_direction_500hPa_member10 { get; set; }
        public double?[]? wind_direction_500hPa_member11 { get; set; }
        public double?[]? wind_direction_500hPa_member12 { get; set; }
        public double?[]? wind_direction_500hPa_member13 { get; set; }
        public double?[]? wind_direction_500hPa_member14 { get; set; }
        public double?[]? wind_direction_500hPa_member15 { get; set; }
        public double?[]? wind_direction_500hPa_member16 { get; set; }
        public double?[]? wind_direction_500hPa_member17 { get; set; }
        public double?[]? wind_direction_500hPa_member18 { get; set; }
        public double?[]? wind_direction_500hPa_member19 { get; set; }
        public double?[]? wind_direction_500hPa_member20 { get; set; }
        public double?[]? wind_direction_500hPa_member21 { get; set; }
        public double?[]? wind_direction_500hPa_member22 { get; set; }
        public double?[]? wind_direction_500hPa_member23 { get; set; }
        public double?[]? wind_direction_500hPa_member24 { get; set; }
        public double?[]? wind_direction_500hPa_member25 { get; set; }
        public double?[]? wind_direction_500hPa_member26 { get; set; }
        public double?[]? wind_direction_500hPa_member27 { get; set; }
        public double?[]? wind_direction_500hPa_member28 { get; set; }
        public double?[]? wind_direction_500hPa_member29 { get; set; }
        public double?[]? wind_direction_500hPa_member30 { get; set; }
        public double?[]? wind_direction_400hPa { get; set; }
        public double?[]? wind_direction_400hPa_member01 { get; set; }
        public double?[]? wind_direction_400hPa_member02 { get; set; }
        public double?[]? wind_direction_400hPa_member03 { get; set; }
        public double?[]? wind_direction_400hPa_member04 { get; set; }
        public double?[]? wind_direction_400hPa_member05 { get; set; }
        public double?[]? wind_direction_400hPa_member06 { get; set; }
        public double?[]? wind_direction_400hPa_member07 { get; set; }
        public double?[]? wind_direction_400hPa_member08 { get; set; }
        public double?[]? wind_direction_400hPa_member09 { get; set; }
        public double?[]? wind_direction_400hPa_member10 { get; set; }
        public double?[]? wind_direction_400hPa_member11 { get; set; }
        public double?[]? wind_direction_400hPa_member12 { get; set; }
        public double?[]? wind_direction_400hPa_member13 { get; set; }
        public double?[]? wind_direction_400hPa_member14 { get; set; }
        public double?[]? wind_direction_400hPa_member15 { get; set; }
        public double?[]? wind_direction_400hPa_member16 { get; set; }
        public double?[]? wind_direction_400hPa_member17 { get; set; }
        public double?[]? wind_direction_400hPa_member18 { get; set; }
        public double?[]? wind_direction_400hPa_member19 { get; set; }
        public double?[]? wind_direction_400hPa_member20 { get; set; }
        public double?[]? wind_direction_400hPa_member21 { get; set; }
        public double?[]? wind_direction_400hPa_member22 { get; set; }
        public double?[]? wind_direction_400hPa_member23 { get; set; }
        public double?[]? wind_direction_400hPa_member24 { get; set; }
        public double?[]? wind_direction_400hPa_member25 { get; set; }
        public double?[]? wind_direction_400hPa_member26 { get; set; }
        public double?[]? wind_direction_400hPa_member27 { get; set; }
        public double?[]? wind_direction_400hPa_member28 { get; set; }
        public double?[]? wind_direction_400hPa_member29 { get; set; }
        public double?[]? wind_direction_400hPa_member30 { get; set; }
        public double?[]? wind_direction_300hPa { get; set; }
        public double?[]? wind_direction_300hPa_member01 { get; set; }
        public double?[]? wind_direction_300hPa_member02 { get; set; }
        public double?[]? wind_direction_300hPa_member03 { get; set; }
        public double?[]? wind_direction_300hPa_member04 { get; set; }
        public double?[]? wind_direction_300hPa_member05 { get; set; }
        public double?[]? wind_direction_300hPa_member06 { get; set; }
        public double?[]? wind_direction_300hPa_member07 { get; set; }
        public double?[]? wind_direction_300hPa_member08 { get; set; }
        public double?[]? wind_direction_300hPa_member09 { get; set; }
        public double?[]? wind_direction_300hPa_member10 { get; set; }
        public double?[]? wind_direction_300hPa_member11 { get; set; }
        public double?[]? wind_direction_300hPa_member12 { get; set; }
        public double?[]? wind_direction_300hPa_member13 { get; set; }
        public double?[]? wind_direction_300hPa_member14 { get; set; }
        public double?[]? wind_direction_300hPa_member15 { get; set; }
        public double?[]? wind_direction_300hPa_member16 { get; set; }
        public double?[]? wind_direction_300hPa_member17 { get; set; }
        public double?[]? wind_direction_300hPa_member18 { get; set; }
        public double?[]? wind_direction_300hPa_member19 { get; set; }
        public double?[]? wind_direction_300hPa_member20 { get; set; }
        public double?[]? wind_direction_300hPa_member21 { get; set; }
        public double?[]? wind_direction_300hPa_member22 { get; set; }
        public double?[]? wind_direction_300hPa_member23 { get; set; }
        public double?[]? wind_direction_300hPa_member24 { get; set; }
        public double?[]? wind_direction_300hPa_member25 { get; set; }
        public double?[]? wind_direction_300hPa_member26 { get; set; }
        public double?[]? wind_direction_300hPa_member27 { get; set; }
        public double?[]? wind_direction_300hPa_member28 { get; set; }
        public double?[]? wind_direction_300hPa_member29 { get; set; }
        public double?[]? wind_direction_300hPa_member30 { get; set; }
        public double?[]? wind_direction_250hPa { get; set; }
        public double?[]? wind_direction_250hPa_member01 { get; set; }
        public double?[]? wind_direction_250hPa_member02 { get; set; }
        public double?[]? wind_direction_250hPa_member03 { get; set; }
        public double?[]? wind_direction_250hPa_member04 { get; set; }
        public double?[]? wind_direction_250hPa_member05 { get; set; }
        public double?[]? wind_direction_250hPa_member06 { get; set; }
        public double?[]? wind_direction_250hPa_member07 { get; set; }
        public double?[]? wind_direction_250hPa_member08 { get; set; }
        public double?[]? wind_direction_250hPa_member09 { get; set; }
        public double?[]? wind_direction_250hPa_member10 { get; set; }
        public double?[]? wind_direction_250hPa_member11 { get; set; }
        public double?[]? wind_direction_250hPa_member12 { get; set; }
        public double?[]? wind_direction_250hPa_member13 { get; set; }
        public double?[]? wind_direction_250hPa_member14 { get; set; }
        public double?[]? wind_direction_250hPa_member15 { get; set; }
        public double?[]? wind_direction_250hPa_member16 { get; set; }
        public double?[]? wind_direction_250hPa_member17 { get; set; }
        public double?[]? wind_direction_250hPa_member18 { get; set; }
        public double?[]? wind_direction_250hPa_member19 { get; set; }
        public double?[]? wind_direction_250hPa_member20 { get; set; }
        public double?[]? wind_direction_250hPa_member21 { get; set; }
        public double?[]? wind_direction_250hPa_member22 { get; set; }
        public double?[]? wind_direction_250hPa_member23 { get; set; }
        public double?[]? wind_direction_250hPa_member24 { get; set; }
        public double?[]? wind_direction_250hPa_member25 { get; set; }
        public double?[]? wind_direction_250hPa_member26 { get; set; }
        public double?[]? wind_direction_250hPa_member27 { get; set; }
        public double?[]? wind_direction_250hPa_member28 { get; set; }
        public double?[]? wind_direction_250hPa_member29 { get; set; }
        public double?[]? wind_direction_250hPa_member30 { get; set; }
        public double?[]? wind_direction_200hPa { get; set; }
        public double?[]? wind_direction_200hPa_member01 { get; set; }
        public double?[]? wind_direction_200hPa_member02 { get; set; }
        public double?[]? wind_direction_200hPa_member03 { get; set; }
        public double?[]? wind_direction_200hPa_member04 { get; set; }
        public double?[]? wind_direction_200hPa_member05 { get; set; }
        public double?[]? wind_direction_200hPa_member06 { get; set; }
        public double?[]? wind_direction_200hPa_member07 { get; set; }
        public double?[]? wind_direction_200hPa_member08 { get; set; }
        public double?[]? wind_direction_200hPa_member09 { get; set; }
        public double?[]? wind_direction_200hPa_member10 { get; set; }
        public double?[]? wind_direction_200hPa_member11 { get; set; }
        public double?[]? wind_direction_200hPa_member12 { get; set; }
        public double?[]? wind_direction_200hPa_member13 { get; set; }
        public double?[]? wind_direction_200hPa_member14 { get; set; }
        public double?[]? wind_direction_200hPa_member15 { get; set; }
        public double?[]? wind_direction_200hPa_member16 { get; set; }
        public double?[]? wind_direction_200hPa_member17 { get; set; }
        public double?[]? wind_direction_200hPa_member18 { get; set; }
        public double?[]? wind_direction_200hPa_member19 { get; set; }
        public double?[]? wind_direction_200hPa_member20 { get; set; }
        public double?[]? wind_direction_200hPa_member21 { get; set; }
        public double?[]? wind_direction_200hPa_member22 { get; set; }
        public double?[]? wind_direction_200hPa_member23 { get; set; }
        public double?[]? wind_direction_200hPa_member24 { get; set; }
        public double?[]? wind_direction_200hPa_member25 { get; set; }
        public double?[]? wind_direction_200hPa_member26 { get; set; }
        public double?[]? wind_direction_200hPa_member27 { get; set; }
        public double?[]? wind_direction_200hPa_member28 { get; set; }
        public double?[]? wind_direction_200hPa_member29 { get; set; }
        public double?[]? wind_direction_200hPa_member30 { get; set; }
        public double?[]? wind_direction_150hPa { get; set; }
        public double?[]? wind_direction_150hPa_member01 { get; set; }
        public double?[]? wind_direction_150hPa_member02 { get; set; }
        public double?[]? wind_direction_150hPa_member03 { get; set; }
        public double?[]? wind_direction_150hPa_member04 { get; set; }
        public double?[]? wind_direction_150hPa_member05 { get; set; }
        public double?[]? wind_direction_150hPa_member06 { get; set; }
        public double?[]? wind_direction_150hPa_member07 { get; set; }
        public double?[]? wind_direction_150hPa_member08 { get; set; }
        public double?[]? wind_direction_150hPa_member09 { get; set; }
        public double?[]? wind_direction_150hPa_member10 { get; set; }
        public double?[]? wind_direction_150hPa_member11 { get; set; }
        public double?[]? wind_direction_150hPa_member12 { get; set; }
        public double?[]? wind_direction_150hPa_member13 { get; set; }
        public double?[]? wind_direction_150hPa_member14 { get; set; }
        public double?[]? wind_direction_150hPa_member15 { get; set; }
        public double?[]? wind_direction_150hPa_member16 { get; set; }
        public double?[]? wind_direction_150hPa_member17 { get; set; }
        public double?[]? wind_direction_150hPa_member18 { get; set; }
        public double?[]? wind_direction_150hPa_member19 { get; set; }
        public double?[]? wind_direction_150hPa_member20 { get; set; }
        public double?[]? wind_direction_150hPa_member21 { get; set; }
        public double?[]? wind_direction_150hPa_member22 { get; set; }
        public double?[]? wind_direction_150hPa_member23 { get; set; }
        public double?[]? wind_direction_150hPa_member24 { get; set; }
        public double?[]? wind_direction_150hPa_member25 { get; set; }
        public double?[]? wind_direction_150hPa_member26 { get; set; }
        public double?[]? wind_direction_150hPa_member27 { get; set; }
        public double?[]? wind_direction_150hPa_member28 { get; set; }
        public double?[]? wind_direction_150hPa_member29 { get; set; }
        public double?[]? wind_direction_150hPa_member30 { get; set; }
        public double?[]? wind_direction_100hPa { get; set; }
        public double?[]? wind_direction_100hPa_member01 { get; set; }
        public double?[]? wind_direction_100hPa_member02 { get; set; }
        public double?[]? wind_direction_100hPa_member03 { get; set; }
        public double?[]? wind_direction_100hPa_member04 { get; set; }
        public double?[]? wind_direction_100hPa_member05 { get; set; }
        public double?[]? wind_direction_100hPa_member06 { get; set; }
        public double?[]? wind_direction_100hPa_member07 { get; set; }
        public double?[]? wind_direction_100hPa_member08 { get; set; }
        public double?[]? wind_direction_100hPa_member09 { get; set; }
        public double?[]? wind_direction_100hPa_member10 { get; set; }
        public double?[]? wind_direction_100hPa_member11 { get; set; }
        public double?[]? wind_direction_100hPa_member12 { get; set; }
        public double?[]? wind_direction_100hPa_member13 { get; set; }
        public double?[]? wind_direction_100hPa_member14 { get; set; }
        public double?[]? wind_direction_100hPa_member15 { get; set; }
        public double?[]? wind_direction_100hPa_member16 { get; set; }
        public double?[]? wind_direction_100hPa_member17 { get; set; }
        public double?[]? wind_direction_100hPa_member18 { get; set; }
        public double?[]? wind_direction_100hPa_member19 { get; set; }
        public double?[]? wind_direction_100hPa_member20 { get; set; }
        public double?[]? wind_direction_100hPa_member21 { get; set; }
        public double?[]? wind_direction_100hPa_member22 { get; set; }
        public double?[]? wind_direction_100hPa_member23 { get; set; }
        public double?[]? wind_direction_100hPa_member24 { get; set; }
        public double?[]? wind_direction_100hPa_member25 { get; set; }
        public double?[]? wind_direction_100hPa_member26 { get; set; }
        public double?[]? wind_direction_100hPa_member27 { get; set; }
        public double?[]? wind_direction_100hPa_member28 { get; set; }
        public double?[]? wind_direction_100hPa_member29 { get; set; }
        public double?[]? wind_direction_100hPa_member30 { get; set; }
        public double?[]? wind_direction_50hPa { get; set; }
        public double?[]? wind_direction_50hPa_member01 { get; set; }
        public double?[]? wind_direction_50hPa_member02 { get; set; }
        public double?[]? wind_direction_50hPa_member03 { get; set; }
        public double?[]? wind_direction_50hPa_member04 { get; set; }
        public double?[]? wind_direction_50hPa_member05 { get; set; }
        public double?[]? wind_direction_50hPa_member06 { get; set; }
        public double?[]? wind_direction_50hPa_member07 { get; set; }
        public double?[]? wind_direction_50hPa_member08 { get; set; }
        public double?[]? wind_direction_50hPa_member09 { get; set; }
        public double?[]? wind_direction_50hPa_member10 { get; set; }
        public double?[]? wind_direction_50hPa_member11 { get; set; }
        public double?[]? wind_direction_50hPa_member12 { get; set; }
        public double?[]? wind_direction_50hPa_member13 { get; set; }
        public double?[]? wind_direction_50hPa_member14 { get; set; }
        public double?[]? wind_direction_50hPa_member15 { get; set; }
        public double?[]? wind_direction_50hPa_member16 { get; set; }
        public double?[]? wind_direction_50hPa_member17 { get; set; }
        public double?[]? wind_direction_50hPa_member18 { get; set; }
        public double?[]? wind_direction_50hPa_member19 { get; set; }
        public double?[]? wind_direction_50hPa_member20 { get; set; }
        public double?[]? wind_direction_50hPa_member21 { get; set; }
        public double?[]? wind_direction_50hPa_member22 { get; set; }
        public double?[]? wind_direction_50hPa_member23 { get; set; }
        public double?[]? wind_direction_50hPa_member24 { get; set; }
        public double?[]? wind_direction_50hPa_member25 { get; set; }
        public double?[]? wind_direction_50hPa_member26 { get; set; }
        public double?[]? wind_direction_50hPa_member27 { get; set; }
        public double?[]? wind_direction_50hPa_member28 { get; set; }
        public double?[]? wind_direction_50hPa_member29 { get; set; }
        public double?[]? wind_direction_50hPa_member30 { get; set; }
        public double?[]? vertical_velocity_1000hPa { get; set; }
        public double?[]? vertical_velocity_1000hPa_member01 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member02 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member03 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member04 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member05 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member06 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member07 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member08 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member09 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member10 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member11 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member12 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member13 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member14 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member15 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member16 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member17 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member18 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member19 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member20 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member21 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member22 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member23 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member24 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member25 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member26 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member27 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member28 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member29 { get; set; }
        public double?[]? vertical_velocity_1000hPa_member30 { get; set; }
        public double?[]? vertical_velocity_925hPa { get; set; }
        public double?[]? vertical_velocity_925hPa_member01 { get; set; }
        public double?[]? vertical_velocity_925hPa_member02 { get; set; }
        public double?[]? vertical_velocity_925hPa_member03 { get; set; }
        public double?[]? vertical_velocity_925hPa_member04 { get; set; }
        public double?[]? vertical_velocity_925hPa_member05 { get; set; }
        public double?[]? vertical_velocity_925hPa_member06 { get; set; }
        public double?[]? vertical_velocity_925hPa_member07 { get; set; }
        public double?[]? vertical_velocity_925hPa_member08 { get; set; }
        public double?[]? vertical_velocity_925hPa_member09 { get; set; }
        public double?[]? vertical_velocity_925hPa_member10 { get; set; }
        public double?[]? vertical_velocity_925hPa_member11 { get; set; }
        public double?[]? vertical_velocity_925hPa_member12 { get; set; }
        public double?[]? vertical_velocity_925hPa_member13 { get; set; }
        public double?[]? vertical_velocity_925hPa_member14 { get; set; }
        public double?[]? vertical_velocity_925hPa_member15 { get; set; }
        public double?[]? vertical_velocity_925hPa_member16 { get; set; }
        public double?[]? vertical_velocity_925hPa_member17 { get; set; }
        public double?[]? vertical_velocity_925hPa_member18 { get; set; }
        public double?[]? vertical_velocity_925hPa_member19 { get; set; }
        public double?[]? vertical_velocity_925hPa_member20 { get; set; }
        public double?[]? vertical_velocity_925hPa_member21 { get; set; }
        public double?[]? vertical_velocity_925hPa_member22 { get; set; }
        public double?[]? vertical_velocity_925hPa_member23 { get; set; }
        public double?[]? vertical_velocity_925hPa_member24 { get; set; }
        public double?[]? vertical_velocity_925hPa_member25 { get; set; }
        public double?[]? vertical_velocity_925hPa_member26 { get; set; }
        public double?[]? vertical_velocity_925hPa_member27 { get; set; }
        public double?[]? vertical_velocity_925hPa_member28 { get; set; }
        public double?[]? vertical_velocity_925hPa_member29 { get; set; }
        public double?[]? vertical_velocity_925hPa_member30 { get; set; }
        public double?[]? vertical_velocity_850hPa { get; set; }
        public double?[]? vertical_velocity_850hPa_member01 { get; set; }
        public double?[]? vertical_velocity_850hPa_member02 { get; set; }
        public double?[]? vertical_velocity_850hPa_member03 { get; set; }
        public double?[]? vertical_velocity_850hPa_member04 { get; set; }
        public double?[]? vertical_velocity_850hPa_member05 { get; set; }
        public double?[]? vertical_velocity_850hPa_member06 { get; set; }
        public double?[]? vertical_velocity_850hPa_member07 { get; set; }
        public double?[]? vertical_velocity_850hPa_member08 { get; set; }
        public double?[]? vertical_velocity_850hPa_member09 { get; set; }
        public double?[]? vertical_velocity_850hPa_member10 { get; set; }
        public double?[]? vertical_velocity_850hPa_member11 { get; set; }
        public double?[]? vertical_velocity_850hPa_member12 { get; set; }
        public double?[]? vertical_velocity_850hPa_member13 { get; set; }
        public double?[]? vertical_velocity_850hPa_member14 { get; set; }
        public double?[]? vertical_velocity_850hPa_member15 { get; set; }
        public double?[]? vertical_velocity_850hPa_member16 { get; set; }
        public double?[]? vertical_velocity_850hPa_member17 { get; set; }
        public double?[]? vertical_velocity_850hPa_member18 { get; set; }
        public double?[]? vertical_velocity_850hPa_member19 { get; set; }
        public double?[]? vertical_velocity_850hPa_member20 { get; set; }
        public double?[]? vertical_velocity_850hPa_member21 { get; set; }
        public double?[]? vertical_velocity_850hPa_member22 { get; set; }
        public double?[]? vertical_velocity_850hPa_member23 { get; set; }
        public double?[]? vertical_velocity_850hPa_member24 { get; set; }
        public double?[]? vertical_velocity_850hPa_member25 { get; set; }
        public double?[]? vertical_velocity_850hPa_member26 { get; set; }
        public double?[]? vertical_velocity_850hPa_member27 { get; set; }
        public double?[]? vertical_velocity_850hPa_member28 { get; set; }
        public double?[]? vertical_velocity_850hPa_member29 { get; set; }
        public double?[]? vertical_velocity_850hPa_member30 { get; set; }
        public double?[]? vertical_velocity_700hPa { get; set; }
        public double?[]? vertical_velocity_700hPa_member01 { get; set; }
        public double?[]? vertical_velocity_700hPa_member02 { get; set; }
        public double?[]? vertical_velocity_700hPa_member03 { get; set; }
        public double?[]? vertical_velocity_700hPa_member04 { get; set; }
        public double?[]? vertical_velocity_700hPa_member05 { get; set; }
        public double?[]? vertical_velocity_700hPa_member06 { get; set; }
        public double?[]? vertical_velocity_700hPa_member07 { get; set; }
        public double?[]? vertical_velocity_700hPa_member08 { get; set; }
        public double?[]? vertical_velocity_700hPa_member09 { get; set; }
        public double?[]? vertical_velocity_700hPa_member10 { get; set; }
        public double?[]? vertical_velocity_700hPa_member11 { get; set; }
        public double?[]? vertical_velocity_700hPa_member12 { get; set; }
        public double?[]? vertical_velocity_700hPa_member13 { get; set; }
        public double?[]? vertical_velocity_700hPa_member14 { get; set; }
        public double?[]? vertical_velocity_700hPa_member15 { get; set; }
        public double?[]? vertical_velocity_700hPa_member16 { get; set; }
        public double?[]? vertical_velocity_700hPa_member17 { get; set; }
        public double?[]? vertical_velocity_700hPa_member18 { get; set; }
        public double?[]? vertical_velocity_700hPa_member19 { get; set; }
        public double?[]? vertical_velocity_700hPa_member20 { get; set; }
        public double?[]? vertical_velocity_700hPa_member21 { get; set; }
        public double?[]? vertical_velocity_700hPa_member22 { get; set; }
        public double?[]? vertical_velocity_700hPa_member23 { get; set; }
        public double?[]? vertical_velocity_700hPa_member24 { get; set; }
        public double?[]? vertical_velocity_700hPa_member25 { get; set; }
        public double?[]? vertical_velocity_700hPa_member26 { get; set; }
        public double?[]? vertical_velocity_700hPa_member27 { get; set; }
        public double?[]? vertical_velocity_700hPa_member28 { get; set; }
        public double?[]? vertical_velocity_700hPa_member29 { get; set; }
        public double?[]? vertical_velocity_700hPa_member30 { get; set; }
        public double?[]? vertical_velocity_600hPa { get; set; }
        public double?[]? vertical_velocity_600hPa_member01 { get; set; }
        public double?[]? vertical_velocity_600hPa_member02 { get; set; }
        public double?[]? vertical_velocity_600hPa_member03 { get; set; }
        public double?[]? vertical_velocity_600hPa_member04 { get; set; }
        public double?[]? vertical_velocity_600hPa_member05 { get; set; }
        public double?[]? vertical_velocity_600hPa_member06 { get; set; }
        public double?[]? vertical_velocity_600hPa_member07 { get; set; }
        public double?[]? vertical_velocity_600hPa_member08 { get; set; }
        public double?[]? vertical_velocity_600hPa_member09 { get; set; }
        public double?[]? vertical_velocity_600hPa_member10 { get; set; }
        public double?[]? vertical_velocity_600hPa_member11 { get; set; }
        public double?[]? vertical_velocity_600hPa_member12 { get; set; }
        public double?[]? vertical_velocity_600hPa_member13 { get; set; }
        public double?[]? vertical_velocity_600hPa_member14 { get; set; }
        public double?[]? vertical_velocity_600hPa_member15 { get; set; }
        public double?[]? vertical_velocity_600hPa_member16 { get; set; }
        public double?[]? vertical_velocity_600hPa_member17 { get; set; }
        public double?[]? vertical_velocity_600hPa_member18 { get; set; }
        public double?[]? vertical_velocity_600hPa_member19 { get; set; }
        public double?[]? vertical_velocity_600hPa_member20 { get; set; }
        public double?[]? vertical_velocity_600hPa_member21 { get; set; }
        public double?[]? vertical_velocity_600hPa_member22 { get; set; }
        public double?[]? vertical_velocity_600hPa_member23 { get; set; }
        public double?[]? vertical_velocity_600hPa_member24 { get; set; }
        public double?[]? vertical_velocity_600hPa_member25 { get; set; }
        public double?[]? vertical_velocity_600hPa_member26 { get; set; }
        public double?[]? vertical_velocity_600hPa_member27 { get; set; }
        public double?[]? vertical_velocity_600hPa_member28 { get; set; }
        public double?[]? vertical_velocity_600hPa_member29 { get; set; }
        public double?[]? vertical_velocity_600hPa_member30 { get; set; }
        public double?[]? vertical_velocity_500hPa { get; set; }
        public double?[]? vertical_velocity_500hPa_member01 { get; set; }
        public double?[]? vertical_velocity_500hPa_member02 { get; set; }
        public double?[]? vertical_velocity_500hPa_member03 { get; set; }
        public double?[]? vertical_velocity_500hPa_member04 { get; set; }
        public double?[]? vertical_velocity_500hPa_member05 { get; set; }
        public double?[]? vertical_velocity_500hPa_member06 { get; set; }
        public double?[]? vertical_velocity_500hPa_member07 { get; set; }
        public double?[]? vertical_velocity_500hPa_member08 { get; set; }
        public double?[]? vertical_velocity_500hPa_member09 { get; set; }
        public double?[]? vertical_velocity_500hPa_member10 { get; set; }
        public double?[]? vertical_velocity_500hPa_member11 { get; set; }
        public double?[]? vertical_velocity_500hPa_member12 { get; set; }
        public double?[]? vertical_velocity_500hPa_member13 { get; set; }
        public double?[]? vertical_velocity_500hPa_member14 { get; set; }
        public double?[]? vertical_velocity_500hPa_member15 { get; set; }
        public double?[]? vertical_velocity_500hPa_member16 { get; set; }
        public double?[]? vertical_velocity_500hPa_member17 { get; set; }
        public double?[]? vertical_velocity_500hPa_member18 { get; set; }
        public double?[]? vertical_velocity_500hPa_member19 { get; set; }
        public double?[]? vertical_velocity_500hPa_member20 { get; set; }
        public double?[]? vertical_velocity_500hPa_member21 { get; set; }
        public double?[]? vertical_velocity_500hPa_member22 { get; set; }
        public double?[]? vertical_velocity_500hPa_member23 { get; set; }
        public double?[]? vertical_velocity_500hPa_member24 { get; set; }
        public double?[]? vertical_velocity_500hPa_member25 { get; set; }
        public double?[]? vertical_velocity_500hPa_member26 { get; set; }
        public double?[]? vertical_velocity_500hPa_member27 { get; set; }
        public double?[]? vertical_velocity_500hPa_member28 { get; set; }
        public double?[]? vertical_velocity_500hPa_member29 { get; set; }
        public double?[]? vertical_velocity_500hPa_member30 { get; set; }
        public double?[]? vertical_velocity_400hPa { get; set; }
        public double?[]? vertical_velocity_400hPa_member01 { get; set; }
        public double?[]? vertical_velocity_400hPa_member02 { get; set; }
        public double?[]? vertical_velocity_400hPa_member03 { get; set; }
        public double?[]? vertical_velocity_400hPa_member04 { get; set; }
        public double?[]? vertical_velocity_400hPa_member05 { get; set; }
        public double?[]? vertical_velocity_400hPa_member06 { get; set; }
        public double?[]? vertical_velocity_400hPa_member07 { get; set; }
        public double?[]? vertical_velocity_400hPa_member08 { get; set; }
        public double?[]? vertical_velocity_400hPa_member09 { get; set; }
        public double?[]? vertical_velocity_400hPa_member10 { get; set; }
        public double?[]? vertical_velocity_400hPa_member11 { get; set; }
        public double?[]? vertical_velocity_400hPa_member12 { get; set; }
        public double?[]? vertical_velocity_400hPa_member13 { get; set; }
        public double?[]? vertical_velocity_400hPa_member14 { get; set; }
        public double?[]? vertical_velocity_400hPa_member15 { get; set; }
        public double?[]? vertical_velocity_400hPa_member16 { get; set; }
        public double?[]? vertical_velocity_400hPa_member17 { get; set; }
        public double?[]? vertical_velocity_400hPa_member18 { get; set; }
        public double?[]? vertical_velocity_400hPa_member19 { get; set; }
        public double?[]? vertical_velocity_400hPa_member20 { get; set; }
        public double?[]? vertical_velocity_400hPa_member21 { get; set; }
        public double?[]? vertical_velocity_400hPa_member22 { get; set; }
        public double?[]? vertical_velocity_400hPa_member23 { get; set; }
        public double?[]? vertical_velocity_400hPa_member24 { get; set; }
        public double?[]? vertical_velocity_400hPa_member25 { get; set; }
        public double?[]? vertical_velocity_400hPa_member26 { get; set; }
        public double?[]? vertical_velocity_400hPa_member27 { get; set; }
        public double?[]? vertical_velocity_400hPa_member28 { get; set; }
        public double?[]? vertical_velocity_400hPa_member29 { get; set; }
        public double?[]? vertical_velocity_400hPa_member30 { get; set; }
        public double?[]? vertical_velocity_300hPa { get; set; }
        public double?[]? vertical_velocity_300hPa_member01 { get; set; }
        public double?[]? vertical_velocity_300hPa_member02 { get; set; }
        public double?[]? vertical_velocity_300hPa_member03 { get; set; }
        public double?[]? vertical_velocity_300hPa_member04 { get; set; }
        public double?[]? vertical_velocity_300hPa_member05 { get; set; }
        public double?[]? vertical_velocity_300hPa_member06 { get; set; }
        public double?[]? vertical_velocity_300hPa_member07 { get; set; }
        public double?[]? vertical_velocity_300hPa_member08 { get; set; }
        public double?[]? vertical_velocity_300hPa_member09 { get; set; }
        public double?[]? vertical_velocity_300hPa_member10 { get; set; }
        public double?[]? vertical_velocity_300hPa_member11 { get; set; }
        public double?[]? vertical_velocity_300hPa_member12 { get; set; }
        public double?[]? vertical_velocity_300hPa_member13 { get; set; }
        public double?[]? vertical_velocity_300hPa_member14 { get; set; }
        public double?[]? vertical_velocity_300hPa_member15 { get; set; }
        public double?[]? vertical_velocity_300hPa_member16 { get; set; }
        public double?[]? vertical_velocity_300hPa_member17 { get; set; }
        public double?[]? vertical_velocity_300hPa_member18 { get; set; }
        public double?[]? vertical_velocity_300hPa_member19 { get; set; }
        public double?[]? vertical_velocity_300hPa_member20 { get; set; }
        public double?[]? vertical_velocity_300hPa_member21 { get; set; }
        public double?[]? vertical_velocity_300hPa_member22 { get; set; }
        public double?[]? vertical_velocity_300hPa_member23 { get; set; }
        public double?[]? vertical_velocity_300hPa_member24 { get; set; }
        public double?[]? vertical_velocity_300hPa_member25 { get; set; }
        public double?[]? vertical_velocity_300hPa_member26 { get; set; }
        public double?[]? vertical_velocity_300hPa_member27 { get; set; }
        public double?[]? vertical_velocity_300hPa_member28 { get; set; }
        public double?[]? vertical_velocity_300hPa_member29 { get; set; }
        public double?[]? vertical_velocity_300hPa_member30 { get; set; }
        public double?[]? vertical_velocity_250hPa { get; set; }
        public double?[]? vertical_velocity_250hPa_member01 { get; set; }
        public double?[]? vertical_velocity_250hPa_member02 { get; set; }
        public double?[]? vertical_velocity_250hPa_member03 { get; set; }
        public double?[]? vertical_velocity_250hPa_member04 { get; set; }
        public double?[]? vertical_velocity_250hPa_member05 { get; set; }
        public double?[]? vertical_velocity_250hPa_member06 { get; set; }
        public double?[]? vertical_velocity_250hPa_member07 { get; set; }
        public double?[]? vertical_velocity_250hPa_member08 { get; set; }
        public double?[]? vertical_velocity_250hPa_member09 { get; set; }
        public double?[]? vertical_velocity_250hPa_member10 { get; set; }
        public double?[]? vertical_velocity_250hPa_member11 { get; set; }
        public double?[]? vertical_velocity_250hPa_member12 { get; set; }
        public double?[]? vertical_velocity_250hPa_member13 { get; set; }
        public double?[]? vertical_velocity_250hPa_member14 { get; set; }
        public double?[]? vertical_velocity_250hPa_member15 { get; set; }
        public double?[]? vertical_velocity_250hPa_member16 { get; set; }
        public double?[]? vertical_velocity_250hPa_member17 { get; set; }
        public double?[]? vertical_velocity_250hPa_member18 { get; set; }
        public double?[]? vertical_velocity_250hPa_member19 { get; set; }
        public double?[]? vertical_velocity_250hPa_member20 { get; set; }
        public double?[]? vertical_velocity_250hPa_member21 { get; set; }
        public double?[]? vertical_velocity_250hPa_member22 { get; set; }
        public double?[]? vertical_velocity_250hPa_member23 { get; set; }
        public double?[]? vertical_velocity_250hPa_member24 { get; set; }
        public double?[]? vertical_velocity_250hPa_member25 { get; set; }
        public double?[]? vertical_velocity_250hPa_member26 { get; set; }
        public double?[]? vertical_velocity_250hPa_member27 { get; set; }
        public double?[]? vertical_velocity_250hPa_member28 { get; set; }
        public double?[]? vertical_velocity_250hPa_member29 { get; set; }
        public double?[]? vertical_velocity_250hPa_member30 { get; set; }
        public double?[]? vertical_velocity_200hPa { get; set; }
        public double?[]? vertical_velocity_200hPa_member01 { get; set; }
        public double?[]? vertical_velocity_200hPa_member02 { get; set; }
        public double?[]? vertical_velocity_200hPa_member03 { get; set; }
        public double?[]? vertical_velocity_200hPa_member04 { get; set; }
        public double?[]? vertical_velocity_200hPa_member05 { get; set; }
        public double?[]? vertical_velocity_200hPa_member06 { get; set; }
        public double?[]? vertical_velocity_200hPa_member07 { get; set; }
        public double?[]? vertical_velocity_200hPa_member08 { get; set; }
        public double?[]? vertical_velocity_200hPa_member09 { get; set; }
        public double?[]? vertical_velocity_200hPa_member10 { get; set; }
        public double?[]? vertical_velocity_200hPa_member11 { get; set; }
        public double?[]? vertical_velocity_200hPa_member12 { get; set; }
        public double?[]? vertical_velocity_200hPa_member13 { get; set; }
        public double?[]? vertical_velocity_200hPa_member14 { get; set; }
        public double?[]? vertical_velocity_200hPa_member15 { get; set; }
        public double?[]? vertical_velocity_200hPa_member16 { get; set; }
        public double?[]? vertical_velocity_200hPa_member17 { get; set; }
        public double?[]? vertical_velocity_200hPa_member18 { get; set; }
        public double?[]? vertical_velocity_200hPa_member19 { get; set; }
        public double?[]? vertical_velocity_200hPa_member20 { get; set; }
        public double?[]? vertical_velocity_200hPa_member21 { get; set; }
        public double?[]? vertical_velocity_200hPa_member22 { get; set; }
        public double?[]? vertical_velocity_200hPa_member23 { get; set; }
        public double?[]? vertical_velocity_200hPa_member24 { get; set; }
        public double?[]? vertical_velocity_200hPa_member25 { get; set; }
        public double?[]? vertical_velocity_200hPa_member26 { get; set; }
        public double?[]? vertical_velocity_200hPa_member27 { get; set; }
        public double?[]? vertical_velocity_200hPa_member28 { get; set; }
        public double?[]? vertical_velocity_200hPa_member29 { get; set; }
        public double?[]? vertical_velocity_200hPa_member30 { get; set; }
        public double?[]? vertical_velocity_150hPa { get; set; }
        public double?[]? vertical_velocity_150hPa_member01 { get; set; }
        public double?[]? vertical_velocity_150hPa_member02 { get; set; }
        public double?[]? vertical_velocity_150hPa_member03 { get; set; }
        public double?[]? vertical_velocity_150hPa_member04 { get; set; }
        public double?[]? vertical_velocity_150hPa_member05 { get; set; }
        public double?[]? vertical_velocity_150hPa_member06 { get; set; }
        public double?[]? vertical_velocity_150hPa_member07 { get; set; }
        public double?[]? vertical_velocity_150hPa_member08 { get; set; }
        public double?[]? vertical_velocity_150hPa_member09 { get; set; }
        public double?[]? vertical_velocity_150hPa_member10 { get; set; }
        public double?[]? vertical_velocity_150hPa_member11 { get; set; }
        public double?[]? vertical_velocity_150hPa_member12 { get; set; }
        public double?[]? vertical_velocity_150hPa_member13 { get; set; }
        public double?[]? vertical_velocity_150hPa_member14 { get; set; }
        public double?[]? vertical_velocity_150hPa_member15 { get; set; }
        public double?[]? vertical_velocity_150hPa_member16 { get; set; }
        public double?[]? vertical_velocity_150hPa_member17 { get; set; }
        public double?[]? vertical_velocity_150hPa_member18 { get; set; }
        public double?[]? vertical_velocity_150hPa_member19 { get; set; }
        public double?[]? vertical_velocity_150hPa_member20 { get; set; }
        public double?[]? vertical_velocity_150hPa_member21 { get; set; }
        public double?[]? vertical_velocity_150hPa_member22 { get; set; }
        public double?[]? vertical_velocity_150hPa_member23 { get; set; }
        public double?[]? vertical_velocity_150hPa_member24 { get; set; }
        public double?[]? vertical_velocity_150hPa_member25 { get; set; }
        public double?[]? vertical_velocity_150hPa_member26 { get; set; }
        public double?[]? vertical_velocity_150hPa_member27 { get; set; }
        public double?[]? vertical_velocity_150hPa_member28 { get; set; }
        public double?[]? vertical_velocity_150hPa_member29 { get; set; }
        public double?[]? vertical_velocity_150hPa_member30 { get; set; }
        public double?[]? vertical_velocity_100hPa { get; set; }
        public double?[]? vertical_velocity_100hPa_member01 { get; set; }
        public double?[]? vertical_velocity_100hPa_member02 { get; set; }
        public double?[]? vertical_velocity_100hPa_member03 { get; set; }
        public double?[]? vertical_velocity_100hPa_member04 { get; set; }
        public double?[]? vertical_velocity_100hPa_member05 { get; set; }
        public double?[]? vertical_velocity_100hPa_member06 { get; set; }
        public double?[]? vertical_velocity_100hPa_member07 { get; set; }
        public double?[]? vertical_velocity_100hPa_member08 { get; set; }
        public double?[]? vertical_velocity_100hPa_member09 { get; set; }
        public double?[]? vertical_velocity_100hPa_member10 { get; set; }
        public double?[]? vertical_velocity_100hPa_member11 { get; set; }
        public double?[]? vertical_velocity_100hPa_member12 { get; set; }
        public double?[]? vertical_velocity_100hPa_member13 { get; set; }
        public double?[]? vertical_velocity_100hPa_member14 { get; set; }
        public double?[]? vertical_velocity_100hPa_member15 { get; set; }
        public double?[]? vertical_velocity_100hPa_member16 { get; set; }
        public double?[]? vertical_velocity_100hPa_member17 { get; set; }
        public double?[]? vertical_velocity_100hPa_member18 { get; set; }
        public double?[]? vertical_velocity_100hPa_member19 { get; set; }
        public double?[]? vertical_velocity_100hPa_member20 { get; set; }
        public double?[]? vertical_velocity_100hPa_member21 { get; set; }
        public double?[]? vertical_velocity_100hPa_member22 { get; set; }
        public double?[]? vertical_velocity_100hPa_member23 { get; set; }
        public double?[]? vertical_velocity_100hPa_member24 { get; set; }
        public double?[]? vertical_velocity_100hPa_member25 { get; set; }
        public double?[]? vertical_velocity_100hPa_member26 { get; set; }
        public double?[]? vertical_velocity_100hPa_member27 { get; set; }
        public double?[]? vertical_velocity_100hPa_member28 { get; set; }
        public double?[]? vertical_velocity_100hPa_member29 { get; set; }
        public double?[]? vertical_velocity_100hPa_member30 { get; set; }
        public double?[]? vertical_velocity_50hPa { get; set; }
        public double?[]? vertical_velocity_50hPa_member01 { get; set; }
        public double?[]? vertical_velocity_50hPa_member02 { get; set; }
        public double?[]? vertical_velocity_50hPa_member03 { get; set; }
        public double?[]? vertical_velocity_50hPa_member04 { get; set; }
        public double?[]? vertical_velocity_50hPa_member05 { get; set; }
        public double?[]? vertical_velocity_50hPa_member06 { get; set; }
        public double?[]? vertical_velocity_50hPa_member07 { get; set; }
        public double?[]? vertical_velocity_50hPa_member08 { get; set; }
        public double?[]? vertical_velocity_50hPa_member09 { get; set; }
        public double?[]? vertical_velocity_50hPa_member10 { get; set; }
        public double?[]? vertical_velocity_50hPa_member11 { get; set; }
        public double?[]? vertical_velocity_50hPa_member12 { get; set; }
        public double?[]? vertical_velocity_50hPa_member13 { get; set; }
        public double?[]? vertical_velocity_50hPa_member14 { get; set; }
        public double?[]? vertical_velocity_50hPa_member15 { get; set; }
        public double?[]? vertical_velocity_50hPa_member16 { get; set; }
        public double?[]? vertical_velocity_50hPa_member17 { get; set; }
        public double?[]? vertical_velocity_50hPa_member18 { get; set; }
        public double?[]? vertical_velocity_50hPa_member19 { get; set; }
        public double?[]? vertical_velocity_50hPa_member20 { get; set; }
        public double?[]? vertical_velocity_50hPa_member21 { get; set; }
        public double?[]? vertical_velocity_50hPa_member22 { get; set; }
        public double?[]? vertical_velocity_50hPa_member23 { get; set; }
        public double?[]? vertical_velocity_50hPa_member24 { get; set; }
        public double?[]? vertical_velocity_50hPa_member25 { get; set; }
        public double?[]? vertical_velocity_50hPa_member26 { get; set; }
        public double?[]? vertical_velocity_50hPa_member27 { get; set; }
        public double?[]? vertical_velocity_50hPa_member28 { get; set; }
        public double?[]? vertical_velocity_50hPa_member29 { get; set; }
        public double?[]? vertical_velocity_50hPa_member30 { get; set; }
        public double?[]? geopotential_height_1000hPa { get; set; }
        public double?[]? geopotential_height_1000hPa_member01 { get; set; }
        public double?[]? geopotential_height_1000hPa_member02 { get; set; }
        public double?[]? geopotential_height_1000hPa_member03 { get; set; }
        public double?[]? geopotential_height_1000hPa_member04 { get; set; }
        public double?[]? geopotential_height_1000hPa_member05 { get; set; }
        public double?[]? geopotential_height_1000hPa_member06 { get; set; }
        public double?[]? geopotential_height_1000hPa_member07 { get; set; }
        public double?[]? geopotential_height_1000hPa_member08 { get; set; }
        public double?[]? geopotential_height_1000hPa_member09 { get; set; }
        public double?[]? geopotential_height_1000hPa_member10 { get; set; }
        public double?[]? geopotential_height_1000hPa_member11 { get; set; }
        public double?[]? geopotential_height_1000hPa_member12 { get; set; }
        public double?[]? geopotential_height_1000hPa_member13 { get; set; }
        public double?[]? geopotential_height_1000hPa_member14 { get; set; }
        public double?[]? geopotential_height_1000hPa_member15 { get; set; }
        public double?[]? geopotential_height_1000hPa_member16 { get; set; }
        public double?[]? geopotential_height_1000hPa_member17 { get; set; }
        public double?[]? geopotential_height_1000hPa_member18 { get; set; }
        public double?[]? geopotential_height_1000hPa_member19 { get; set; }
        public double?[]? geopotential_height_1000hPa_member20 { get; set; }
        public double?[]? geopotential_height_1000hPa_member21 { get; set; }
        public double?[]? geopotential_height_1000hPa_member22 { get; set; }
        public double?[]? geopotential_height_1000hPa_member23 { get; set; }
        public double?[]? geopotential_height_1000hPa_member24 { get; set; }
        public double?[]? geopotential_height_1000hPa_member25 { get; set; }
        public double?[]? geopotential_height_1000hPa_member26 { get; set; }
        public double?[]? geopotential_height_1000hPa_member27 { get; set; }
        public double?[]? geopotential_height_1000hPa_member28 { get; set; }
        public double?[]? geopotential_height_1000hPa_member29 { get; set; }
        public double?[]? geopotential_height_1000hPa_member30 { get; set; }
        public double?[]? geopotential_height_925hPa { get; set; }
        public double?[]? geopotential_height_925hPa_member01 { get; set; }
        public double?[]? geopotential_height_925hPa_member02 { get; set; }
        public double?[]? geopotential_height_925hPa_member03 { get; set; }
        public double?[]? geopotential_height_925hPa_member04 { get; set; }
        public double?[]? geopotential_height_925hPa_member05 { get; set; }
        public double?[]? geopotential_height_925hPa_member06 { get; set; }
        public double?[]? geopotential_height_925hPa_member07 { get; set; }
        public double?[]? geopotential_height_925hPa_member08 { get; set; }
        public double?[]? geopotential_height_925hPa_member09 { get; set; }
        public double?[]? geopotential_height_925hPa_member10 { get; set; }
        public double?[]? geopotential_height_925hPa_member11 { get; set; }
        public double?[]? geopotential_height_925hPa_member12 { get; set; }
        public double?[]? geopotential_height_925hPa_member13 { get; set; }
        public double?[]? geopotential_height_925hPa_member14 { get; set; }
        public double?[]? geopotential_height_925hPa_member15 { get; set; }
        public double?[]? geopotential_height_925hPa_member16 { get; set; }
        public double?[]? geopotential_height_925hPa_member17 { get; set; }
        public double?[]? geopotential_height_925hPa_member18 { get; set; }
        public double?[]? geopotential_height_925hPa_member19 { get; set; }
        public double?[]? geopotential_height_925hPa_member20 { get; set; }
        public double?[]? geopotential_height_925hPa_member21 { get; set; }
        public double?[]? geopotential_height_925hPa_member22 { get; set; }
        public double?[]? geopotential_height_925hPa_member23 { get; set; }
        public double?[]? geopotential_height_925hPa_member24 { get; set; }
        public double?[]? geopotential_height_925hPa_member25 { get; set; }
        public double?[]? geopotential_height_925hPa_member26 { get; set; }
        public double?[]? geopotential_height_925hPa_member27 { get; set; }
        public double?[]? geopotential_height_925hPa_member28 { get; set; }
        public double?[]? geopotential_height_925hPa_member29 { get; set; }
        public double?[]? geopotential_height_925hPa_member30 { get; set; }
        public double?[]? geopotential_height_850hPa { get; set; }
        public double?[]? geopotential_height_850hPa_member01 { get; set; }
        public double?[]? geopotential_height_850hPa_member02 { get; set; }
        public double?[]? geopotential_height_850hPa_member03 { get; set; }
        public double?[]? geopotential_height_850hPa_member04 { get; set; }
        public double?[]? geopotential_height_850hPa_member05 { get; set; }
        public double?[]? geopotential_height_850hPa_member06 { get; set; }
        public double?[]? geopotential_height_850hPa_member07 { get; set; }
        public double?[]? geopotential_height_850hPa_member08 { get; set; }
        public double?[]? geopotential_height_850hPa_member09 { get; set; }
        public double?[]? geopotential_height_850hPa_member10 { get; set; }
        public double?[]? geopotential_height_850hPa_member11 { get; set; }
        public double?[]? geopotential_height_850hPa_member12 { get; set; }
        public double?[]? geopotential_height_850hPa_member13 { get; set; }
        public double?[]? geopotential_height_850hPa_member14 { get; set; }
        public double?[]? geopotential_height_850hPa_member15 { get; set; }
        public double?[]? geopotential_height_850hPa_member16 { get; set; }
        public double?[]? geopotential_height_850hPa_member17 { get; set; }
        public double?[]? geopotential_height_850hPa_member18 { get; set; }
        public double?[]? geopotential_height_850hPa_member19 { get; set; }
        public double?[]? geopotential_height_850hPa_member20 { get; set; }
        public double?[]? geopotential_height_850hPa_member21 { get; set; }
        public double?[]? geopotential_height_850hPa_member22 { get; set; }
        public double?[]? geopotential_height_850hPa_member23 { get; set; }
        public double?[]? geopotential_height_850hPa_member24 { get; set; }
        public double?[]? geopotential_height_850hPa_member25 { get; set; }
        public double?[]? geopotential_height_850hPa_member26 { get; set; }
        public double?[]? geopotential_height_850hPa_member27 { get; set; }
        public double?[]? geopotential_height_850hPa_member28 { get; set; }
        public double?[]? geopotential_height_850hPa_member29 { get; set; }
        public double?[]? geopotential_height_850hPa_member30 { get; set; }
        public double?[]? geopotential_height_700hPa { get; set; }
        public double?[]? geopotential_height_700hPa_member01 { get; set; }
        public double?[]? geopotential_height_700hPa_member02 { get; set; }
        public double?[]? geopotential_height_700hPa_member03 { get; set; }
        public double?[]? geopotential_height_700hPa_member04 { get; set; }
        public double?[]? geopotential_height_700hPa_member05 { get; set; }
        public double?[]? geopotential_height_700hPa_member06 { get; set; }
        public double?[]? geopotential_height_700hPa_member07 { get; set; }
        public double?[]? geopotential_height_700hPa_member08 { get; set; }
        public double?[]? geopotential_height_700hPa_member09 { get; set; }
        public double?[]? geopotential_height_700hPa_member10 { get; set; }
        public double?[]? geopotential_height_700hPa_member11 { get; set; }
        public double?[]? geopotential_height_700hPa_member12 { get; set; }
        public double?[]? geopotential_height_700hPa_member13 { get; set; }
        public double?[]? geopotential_height_700hPa_member14 { get; set; }
        public double?[]? geopotential_height_700hPa_member15 { get; set; }
        public double?[]? geopotential_height_700hPa_member16 { get; set; }
        public double?[]? geopotential_height_700hPa_member17 { get; set; }
        public double?[]? geopotential_height_700hPa_member18 { get; set; }
        public double?[]? geopotential_height_700hPa_member19 { get; set; }
        public double?[]? geopotential_height_700hPa_member20 { get; set; }
        public double?[]? geopotential_height_700hPa_member21 { get; set; }
        public double?[]? geopotential_height_700hPa_member22 { get; set; }
        public double?[]? geopotential_height_700hPa_member23 { get; set; }
        public double?[]? geopotential_height_700hPa_member24 { get; set; }
        public double?[]? geopotential_height_700hPa_member25 { get; set; }
        public double?[]? geopotential_height_700hPa_member26 { get; set; }
        public double?[]? geopotential_height_700hPa_member27 { get; set; }
        public double?[]? geopotential_height_700hPa_member28 { get; set; }
        public double?[]? geopotential_height_700hPa_member29 { get; set; }
        public double?[]? geopotential_height_700hPa_member30 { get; set; }
        public double?[]? geopotential_height_600hPa { get; set; }
        public double?[]? geopotential_height_600hPa_member01 { get; set; }
        public double?[]? geopotential_height_600hPa_member02 { get; set; }
        public double?[]? geopotential_height_600hPa_member03 { get; set; }
        public double?[]? geopotential_height_600hPa_member04 { get; set; }
        public double?[]? geopotential_height_600hPa_member05 { get; set; }
        public double?[]? geopotential_height_600hPa_member06 { get; set; }
        public double?[]? geopotential_height_600hPa_member07 { get; set; }
        public double?[]? geopotential_height_600hPa_member08 { get; set; }
        public double?[]? geopotential_height_600hPa_member09 { get; set; }
        public double?[]? geopotential_height_600hPa_member10 { get; set; }
        public double?[]? geopotential_height_600hPa_member11 { get; set; }
        public double?[]? geopotential_height_600hPa_member12 { get; set; }
        public double?[]? geopotential_height_600hPa_member13 { get; set; }
        public double?[]? geopotential_height_600hPa_member14 { get; set; }
        public double?[]? geopotential_height_600hPa_member15 { get; set; }
        public double?[]? geopotential_height_600hPa_member16 { get; set; }
        public double?[]? geopotential_height_600hPa_member17 { get; set; }
        public double?[]? geopotential_height_600hPa_member18 { get; set; }
        public double?[]? geopotential_height_600hPa_member19 { get; set; }
        public double?[]? geopotential_height_600hPa_member20 { get; set; }
        public double?[]? geopotential_height_600hPa_member21 { get; set; }
        public double?[]? geopotential_height_600hPa_member22 { get; set; }
        public double?[]? geopotential_height_600hPa_member23 { get; set; }
        public double?[]? geopotential_height_600hPa_member24 { get; set; }
        public double?[]? geopotential_height_600hPa_member25 { get; set; }
        public double?[]? geopotential_height_600hPa_member26 { get; set; }
        public double?[]? geopotential_height_600hPa_member27 { get; set; }
        public double?[]? geopotential_height_600hPa_member28 { get; set; }
        public double?[]? geopotential_height_600hPa_member29 { get; set; }
        public double?[]? geopotential_height_600hPa_member30 { get; set; }
        public double?[]? geopotential_height_500hPa { get; set; }
        public double?[]? geopotential_height_500hPa_member01 { get; set; }
        public double?[]? geopotential_height_500hPa_member02 { get; set; }
        public double?[]? geopotential_height_500hPa_member03 { get; set; }
        public double?[]? geopotential_height_500hPa_member04 { get; set; }
        public double?[]? geopotential_height_500hPa_member05 { get; set; }
        public double?[]? geopotential_height_500hPa_member06 { get; set; }
        public double?[]? geopotential_height_500hPa_member07 { get; set; }
        public double?[]? geopotential_height_500hPa_member08 { get; set; }
        public double?[]? geopotential_height_500hPa_member09 { get; set; }
        public double?[]? geopotential_height_500hPa_member10 { get; set; }
        public double?[]? geopotential_height_500hPa_member11 { get; set; }
        public double?[]? geopotential_height_500hPa_member12 { get; set; }
        public double?[]? geopotential_height_500hPa_member13 { get; set; }
        public double?[]? geopotential_height_500hPa_member14 { get; set; }
        public double?[]? geopotential_height_500hPa_member15 { get; set; }
        public double?[]? geopotential_height_500hPa_member16 { get; set; }
        public double?[]? geopotential_height_500hPa_member17 { get; set; }
        public double?[]? geopotential_height_500hPa_member18 { get; set; }
        public double?[]? geopotential_height_500hPa_member19 { get; set; }
        public double?[]? geopotential_height_500hPa_member20 { get; set; }
        public double?[]? geopotential_height_500hPa_member21 { get; set; }
        public double?[]? geopotential_height_500hPa_member22 { get; set; }
        public double?[]? geopotential_height_500hPa_member23 { get; set; }
        public double?[]? geopotential_height_500hPa_member24 { get; set; }
        public double?[]? geopotential_height_500hPa_member25 { get; set; }
        public double?[]? geopotential_height_500hPa_member26 { get; set; }
        public double?[]? geopotential_height_500hPa_member27 { get; set; }
        public double?[]? geopotential_height_500hPa_member28 { get; set; }
        public double?[]? geopotential_height_500hPa_member29 { get; set; }
        public double?[]? geopotential_height_500hPa_member30 { get; set; }
        public double?[]? geopotential_height_400hPa { get; set; }
        public double?[]? geopotential_height_400hPa_member01 { get; set; }
        public double?[]? geopotential_height_400hPa_member02 { get; set; }
        public double?[]? geopotential_height_400hPa_member03 { get; set; }
        public double?[]? geopotential_height_400hPa_member04 { get; set; }
        public double?[]? geopotential_height_400hPa_member05 { get; set; }
        public double?[]? geopotential_height_400hPa_member06 { get; set; }
        public double?[]? geopotential_height_400hPa_member07 { get; set; }
        public double?[]? geopotential_height_400hPa_member08 { get; set; }
        public double?[]? geopotential_height_400hPa_member09 { get; set; }
        public double?[]? geopotential_height_400hPa_member10 { get; set; }
        public double?[]? geopotential_height_400hPa_member11 { get; set; }
        public double?[]? geopotential_height_400hPa_member12 { get; set; }
        public double?[]? geopotential_height_400hPa_member13 { get; set; }
        public double?[]? geopotential_height_400hPa_member14 { get; set; }
        public double?[]? geopotential_height_400hPa_member15 { get; set; }
        public double?[]? geopotential_height_400hPa_member16 { get; set; }
        public double?[]? geopotential_height_400hPa_member17 { get; set; }
        public double?[]? geopotential_height_400hPa_member18 { get; set; }
        public double?[]? geopotential_height_400hPa_member19 { get; set; }
        public double?[]? geopotential_height_400hPa_member20 { get; set; }
        public double?[]? geopotential_height_400hPa_member21 { get; set; }
        public double?[]? geopotential_height_400hPa_member22 { get; set; }
        public double?[]? geopotential_height_400hPa_member23 { get; set; }
        public double?[]? geopotential_height_400hPa_member24 { get; set; }
        public double?[]? geopotential_height_400hPa_member25 { get; set; }
        public double?[]? geopotential_height_400hPa_member26 { get; set; }
        public double?[]? geopotential_height_400hPa_member27 { get; set; }
        public double?[]? geopotential_height_400hPa_member28 { get; set; }
        public double?[]? geopotential_height_400hPa_member29 { get; set; }
        public double?[]? geopotential_height_400hPa_member30 { get; set; }
        public double?[]? geopotential_height_300hPa { get; set; }
        public double?[]? geopotential_height_300hPa_member01 { get; set; }
        public double?[]? geopotential_height_300hPa_member02 { get; set; }
        public double?[]? geopotential_height_300hPa_member03 { get; set; }
        public double?[]? geopotential_height_300hPa_member04 { get; set; }
        public double?[]? geopotential_height_300hPa_member05 { get; set; }
        public double?[]? geopotential_height_300hPa_member06 { get; set; }
        public double?[]? geopotential_height_300hPa_member07 { get; set; }
        public double?[]? geopotential_height_300hPa_member08 { get; set; }
        public double?[]? geopotential_height_300hPa_member09 { get; set; }
        public double?[]? geopotential_height_300hPa_member10 { get; set; }
        public double?[]? geopotential_height_300hPa_member11 { get; set; }
        public double?[]? geopotential_height_300hPa_member12 { get; set; }
        public double?[]? geopotential_height_300hPa_member13 { get; set; }
        public double?[]? geopotential_height_300hPa_member14 { get; set; }
        public double?[]? geopotential_height_300hPa_member15 { get; set; }
        public double?[]? geopotential_height_300hPa_member16 { get; set; }
        public double?[]? geopotential_height_300hPa_member17 { get; set; }
        public double?[]? geopotential_height_300hPa_member18 { get; set; }
        public double?[]? geopotential_height_300hPa_member19 { get; set; }
        public double?[]? geopotential_height_300hPa_member20 { get; set; }
        public double?[]? geopotential_height_300hPa_member21 { get; set; }
        public double?[]? geopotential_height_300hPa_member22 { get; set; }
        public double?[]? geopotential_height_300hPa_member23 { get; set; }
        public double?[]? geopotential_height_300hPa_member24 { get; set; }
        public double?[]? geopotential_height_300hPa_member25 { get; set; }
        public double?[]? geopotential_height_300hPa_member26 { get; set; }
        public double?[]? geopotential_height_300hPa_member27 { get; set; }
        public double?[]? geopotential_height_300hPa_member28 { get; set; }
        public double?[]? geopotential_height_300hPa_member29 { get; set; }
        public double?[]? geopotential_height_300hPa_member30 { get; set; }
        public double?[]? geopotential_height_250hPa { get; set; }
        public double?[]? geopotential_height_250hPa_member01 { get; set; }
        public double?[]? geopotential_height_250hPa_member02 { get; set; }
        public double?[]? geopotential_height_250hPa_member03 { get; set; }
        public double?[]? geopotential_height_250hPa_member04 { get; set; }
        public double?[]? geopotential_height_250hPa_member05 { get; set; }
        public double?[]? geopotential_height_250hPa_member06 { get; set; }
        public double?[]? geopotential_height_250hPa_member07 { get; set; }
        public double?[]? geopotential_height_250hPa_member08 { get; set; }
        public double?[]? geopotential_height_250hPa_member09 { get; set; }
        public double?[]? geopotential_height_250hPa_member10 { get; set; }
        public double?[]? geopotential_height_250hPa_member11 { get; set; }
        public double?[]? geopotential_height_250hPa_member12 { get; set; }
        public double?[]? geopotential_height_250hPa_member13 { get; set; }
        public double?[]? geopotential_height_250hPa_member14 { get; set; }
        public double?[]? geopotential_height_250hPa_member15 { get; set; }
        public double?[]? geopotential_height_250hPa_member16 { get; set; }
        public double?[]? geopotential_height_250hPa_member17 { get; set; }
        public double?[]? geopotential_height_250hPa_member18 { get; set; }
        public double?[]? geopotential_height_250hPa_member19 { get; set; }
        public double?[]? geopotential_height_250hPa_member20 { get; set; }
        public double?[]? geopotential_height_250hPa_member21 { get; set; }
        public double?[]? geopotential_height_250hPa_member22 { get; set; }
        public double?[]? geopotential_height_250hPa_member23 { get; set; }
        public double?[]? geopotential_height_250hPa_member24 { get; set; }
        public double?[]? geopotential_height_250hPa_member25 { get; set; }
        public double?[]? geopotential_height_250hPa_member26 { get; set; }
        public double?[]? geopotential_height_250hPa_member27 { get; set; }
        public double?[]? geopotential_height_250hPa_member28 { get; set; }
        public double?[]? geopotential_height_250hPa_member29 { get; set; }
        public double?[]? geopotential_height_250hPa_member30 { get; set; }
        public double?[]? geopotential_height_200hPa { get; set; }
        public double?[]? geopotential_height_200hPa_member01 { get; set; }
        public double?[]? geopotential_height_200hPa_member02 { get; set; }
        public double?[]? geopotential_height_200hPa_member03 { get; set; }
        public double?[]? geopotential_height_200hPa_member04 { get; set; }
        public double?[]? geopotential_height_200hPa_member05 { get; set; }
        public double?[]? geopotential_height_200hPa_member06 { get; set; }
        public double?[]? geopotential_height_200hPa_member07 { get; set; }
        public double?[]? geopotential_height_200hPa_member08 { get; set; }
        public double?[]? geopotential_height_200hPa_member09 { get; set; }
        public double?[]? geopotential_height_200hPa_member10 { get; set; }
        public double?[]? geopotential_height_200hPa_member11 { get; set; }
        public double?[]? geopotential_height_200hPa_member12 { get; set; }
        public double?[]? geopotential_height_200hPa_member13 { get; set; }
        public double?[]? geopotential_height_200hPa_member14 { get; set; }
        public double?[]? geopotential_height_200hPa_member15 { get; set; }
        public double?[]? geopotential_height_200hPa_member16 { get; set; }
        public double?[]? geopotential_height_200hPa_member17 { get; set; }
        public double?[]? geopotential_height_200hPa_member18 { get; set; }
        public double?[]? geopotential_height_200hPa_member19 { get; set; }
        public double?[]? geopotential_height_200hPa_member20 { get; set; }
        public double?[]? geopotential_height_200hPa_member21 { get; set; }
        public double?[]? geopotential_height_200hPa_member22 { get; set; }
        public double?[]? geopotential_height_200hPa_member23 { get; set; }
        public double?[]? geopotential_height_200hPa_member24 { get; set; }
        public double?[]? geopotential_height_200hPa_member25 { get; set; }
        public double?[]? geopotential_height_200hPa_member26 { get; set; }
        public double?[]? geopotential_height_200hPa_member27 { get; set; }
        public double?[]? geopotential_height_200hPa_member28 { get; set; }
        public double?[]? geopotential_height_200hPa_member29 { get; set; }
        public double?[]? geopotential_height_200hPa_member30 { get; set; }
        public double?[]? geopotential_height_150hPa { get; set; }
        public double?[]? geopotential_height_150hPa_member01 { get; set; }
        public double?[]? geopotential_height_150hPa_member02 { get; set; }
        public double?[]? geopotential_height_150hPa_member03 { get; set; }
        public double?[]? geopotential_height_150hPa_member04 { get; set; }
        public double?[]? geopotential_height_150hPa_member05 { get; set; }
        public double?[]? geopotential_height_150hPa_member06 { get; set; }
        public double?[]? geopotential_height_150hPa_member07 { get; set; }
        public double?[]? geopotential_height_150hPa_member08 { get; set; }
        public double?[]? geopotential_height_150hPa_member09 { get; set; }
        public double?[]? geopotential_height_150hPa_member10 { get; set; }
        public double?[]? geopotential_height_150hPa_member11 { get; set; }
        public double?[]? geopotential_height_150hPa_member12 { get; set; }
        public double?[]? geopotential_height_150hPa_member13 { get; set; }
        public double?[]? geopotential_height_150hPa_member14 { get; set; }
        public double?[]? geopotential_height_150hPa_member15 { get; set; }
        public double?[]? geopotential_height_150hPa_member16 { get; set; }
        public double?[]? geopotential_height_150hPa_member17 { get; set; }
        public double?[]? geopotential_height_150hPa_member18 { get; set; }
        public double?[]? geopotential_height_150hPa_member19 { get; set; }
        public double?[]? geopotential_height_150hPa_member20 { get; set; }
        public double?[]? geopotential_height_150hPa_member21 { get; set; }
        public double?[]? geopotential_height_150hPa_member22 { get; set; }
        public double?[]? geopotential_height_150hPa_member23 { get; set; }
        public double?[]? geopotential_height_150hPa_member24 { get; set; }
        public double?[]? geopotential_height_150hPa_member25 { get; set; }
        public double?[]? geopotential_height_150hPa_member26 { get; set; }
        public double?[]? geopotential_height_150hPa_member27 { get; set; }
        public double?[]? geopotential_height_150hPa_member28 { get; set; }
        public double?[]? geopotential_height_150hPa_member29 { get; set; }
        public double?[]? geopotential_height_150hPa_member30 { get; set; }
        public double?[]? geopotential_height_100hPa { get; set; }
        public double?[]? geopotential_height_100hPa_member01 { get; set; }
        public double?[]? geopotential_height_100hPa_member02 { get; set; }
        public double?[]? geopotential_height_100hPa_member03 { get; set; }
        public double?[]? geopotential_height_100hPa_member04 { get; set; }
        public double?[]? geopotential_height_100hPa_member05 { get; set; }
        public double?[]? geopotential_height_100hPa_member06 { get; set; }
        public double?[]? geopotential_height_100hPa_member07 { get; set; }
        public double?[]? geopotential_height_100hPa_member08 { get; set; }
        public double?[]? geopotential_height_100hPa_member09 { get; set; }
        public double?[]? geopotential_height_100hPa_member10 { get; set; }
        public double?[]? geopotential_height_100hPa_member11 { get; set; }
        public double?[]? geopotential_height_100hPa_member12 { get; set; }
        public double?[]? geopotential_height_100hPa_member13 { get; set; }
        public double?[]? geopotential_height_100hPa_member14 { get; set; }
        public double?[]? geopotential_height_100hPa_member15 { get; set; }
        public double?[]? geopotential_height_100hPa_member16 { get; set; }
        public double?[]? geopotential_height_100hPa_member17 { get; set; }
        public double?[]? geopotential_height_100hPa_member18 { get; set; }
        public double?[]? geopotential_height_100hPa_member19 { get; set; }
        public double?[]? geopotential_height_100hPa_member20 { get; set; }
        public double?[]? geopotential_height_100hPa_member21 { get; set; }
        public double?[]? geopotential_height_100hPa_member22 { get; set; }
        public double?[]? geopotential_height_100hPa_member23 { get; set; }
        public double?[]? geopotential_height_100hPa_member24 { get; set; }
        public double?[]? geopotential_height_100hPa_member25 { get; set; }
        public double?[]? geopotential_height_100hPa_member26 { get; set; }
        public double?[]? geopotential_height_100hPa_member27 { get; set; }
        public double?[]? geopotential_height_100hPa_member28 { get; set; }
        public double?[]? geopotential_height_100hPa_member29 { get; set; }
        public double?[]? geopotential_height_100hPa_member30 { get; set; }
        public double?[]? geopotential_height_50hPa { get; set; }
        public double?[]? geopotential_height_50hPa_member01 { get; set; }
        public double?[]? geopotential_height_50hPa_member02 { get; set; }
        public double?[]? geopotential_height_50hPa_member03 { get; set; }
        public double?[]? geopotential_height_50hPa_member04 { get; set; }
        public double?[]? geopotential_height_50hPa_member05 { get; set; }
        public double?[]? geopotential_height_50hPa_member06 { get; set; }
        public double?[]? geopotential_height_50hPa_member07 { get; set; }
        public double?[]? geopotential_height_50hPa_member08 { get; set; }
        public double?[]? geopotential_height_50hPa_member09 { get; set; }
        public double?[]? geopotential_height_50hPa_member10 { get; set; }
        public double?[]? geopotential_height_50hPa_member11 { get; set; }
        public double?[]? geopotential_height_50hPa_member12 { get; set; }
        public double?[]? geopotential_height_50hPa_member13 { get; set; }
        public double?[]? geopotential_height_50hPa_member14 { get; set; }
        public double?[]? geopotential_height_50hPa_member15 { get; set; }
        public double?[]? geopotential_height_50hPa_member16 { get; set; }
        public double?[]? geopotential_height_50hPa_member17 { get; set; }
        public double?[]? geopotential_height_50hPa_member18 { get; set; }
        public double?[]? geopotential_height_50hPa_member19 { get; set; }
        public double?[]? geopotential_height_50hPa_member20 { get; set; }
        public double?[]? geopotential_height_50hPa_member21 { get; set; }
        public double?[]? geopotential_height_50hPa_member22 { get; set; }
        public double?[]? geopotential_height_50hPa_member23 { get; set; }
        public double?[]? geopotential_height_50hPa_member24 { get; set; }
        public double?[]? geopotential_height_50hPa_member25 { get; set; }
        public double?[]? geopotential_height_50hPa_member26 { get; set; }
        public double?[]? geopotential_height_50hPa_member27 { get; set; }
        public double?[]? geopotential_height_50hPa_member28 { get; set; }
        public double?[]? geopotential_height_50hPa_member29 { get; set; }
        public double?[]? geopotential_height_50hPa_member30 { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }

    }
    public static class gefsHourlyForecastApi
    {

        private static DataFrame ToDataFrame(gefsParams data)
        {
            /*
             * Converts the data object of type iconParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the gefsParams object.
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

            if (data.temperature_2m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member18", data.temperature_2m_member18));

            if (data.temperature_2m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member19", data.temperature_2m_member19));

            if (data.temperature_2m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member20", data.temperature_2m_member20));

            if (data.temperature_2m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member21", data.temperature_2m_member21));

            if (data.temperature_2m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member22", data.temperature_2m_member22));

            if (data.temperature_2m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member23", data.temperature_2m_member23));

            if (data.temperature_2m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member24", data.temperature_2m_member24));

            if (data.temperature_2m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member25", data.temperature_2m_member25));

            if (data.temperature_2m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member26", data.temperature_2m_member26));

            if (data.temperature_2m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member27", data.temperature_2m_member27));

            if (data.temperature_2m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member28", data.temperature_2m_member28));

            if (data.temperature_2m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member29", data.temperature_2m_member29));

            if (data.temperature_2m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member30", data.temperature_2m_member30));

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

            if (data.cloud_cover_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member18", data.cloud_cover_member18));

            if (data.cloud_cover_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member19", data.cloud_cover_member19));

            if (data.cloud_cover_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member20", data.cloud_cover_member20));

            if (data.cloud_cover_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member21", data.cloud_cover_member21));

            if (data.cloud_cover_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member22", data.cloud_cover_member22));

            if (data.cloud_cover_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member23", data.cloud_cover_member23));

            if (data.cloud_cover_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member24", data.cloud_cover_member24));

            if (data.cloud_cover_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member25", data.cloud_cover_member25));

            if (data.cloud_cover_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member26", data.cloud_cover_member26));

            if (data.cloud_cover_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member27", data.cloud_cover_member27));

            if (data.cloud_cover_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member28", data.cloud_cover_member28));

            if (data.cloud_cover_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member29", data.cloud_cover_member29));

            if (data.cloud_cover_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member30", data.cloud_cover_member30));

            if (data.cloud_cover_low != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low", data.cloud_cover_low));

            if (data.cloud_cover_low_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member01", data.cloud_cover_low_member01));

            if (data.cloud_cover_low_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member02", data.cloud_cover_low_member02));

            if (data.cloud_cover_low_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member03", data.cloud_cover_low_member03));

            if (data.cloud_cover_low_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member04", data.cloud_cover_low_member04));

            if (data.cloud_cover_low_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member05", data.cloud_cover_low_member05));

            if (data.cloud_cover_low_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member06", data.cloud_cover_low_member06));

            if (data.cloud_cover_low_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member07", data.cloud_cover_low_member07));

            if (data.cloud_cover_low_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member08", data.cloud_cover_low_member08));

            if (data.cloud_cover_low_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member09", data.cloud_cover_low_member09));

            if (data.cloud_cover_low_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member10", data.cloud_cover_low_member10));

            if (data.cloud_cover_low_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member11", data.cloud_cover_low_member11));

            if (data.cloud_cover_low_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member12", data.cloud_cover_low_member12));

            if (data.cloud_cover_low_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member13", data.cloud_cover_low_member13));

            if (data.cloud_cover_low_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member14", data.cloud_cover_low_member14));

            if (data.cloud_cover_low_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member15", data.cloud_cover_low_member15));

            if (data.cloud_cover_low_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member16", data.cloud_cover_low_member16));

            if (data.cloud_cover_low_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member17", data.cloud_cover_low_member17));

            if (data.cloud_cover_low_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member18", data.cloud_cover_low_member18));

            if (data.cloud_cover_low_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member19", data.cloud_cover_low_member19));

            if (data.cloud_cover_low_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member20", data.cloud_cover_low_member20));

            if (data.cloud_cover_low_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member21", data.cloud_cover_low_member21));

            if (data.cloud_cover_low_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member22", data.cloud_cover_low_member22));

            if (data.cloud_cover_low_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member23", data.cloud_cover_low_member23));

            if (data.cloud_cover_low_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member24", data.cloud_cover_low_member24));

            if (data.cloud_cover_low_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member25", data.cloud_cover_low_member25));

            if (data.cloud_cover_low_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member26", data.cloud_cover_low_member26));

            if (data.cloud_cover_low_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member27", data.cloud_cover_low_member27));

            if (data.cloud_cover_low_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member28", data.cloud_cover_low_member28));

            if (data.cloud_cover_low_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member29", data.cloud_cover_low_member29));

            if (data.cloud_cover_low_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_low_member30", data.cloud_cover_low_member30));

            if (data.cloud_cover_mid != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid", data.cloud_cover_mid));

            if (data.cloud_cover_mid_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member01", data.cloud_cover_mid_member01));

            if (data.cloud_cover_mid_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member02", data.cloud_cover_mid_member02));

            if (data.cloud_cover_mid_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member03", data.cloud_cover_mid_member03));

            if (data.cloud_cover_mid_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member04", data.cloud_cover_mid_member04));

            if (data.cloud_cover_mid_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member05", data.cloud_cover_mid_member05));

            if (data.cloud_cover_mid_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member06", data.cloud_cover_mid_member06));

            if (data.cloud_cover_mid_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member07", data.cloud_cover_mid_member07));

            if (data.cloud_cover_mid_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member08", data.cloud_cover_mid_member08));

            if (data.cloud_cover_mid_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member09", data.cloud_cover_mid_member09));

            if (data.cloud_cover_mid_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member10", data.cloud_cover_mid_member10));

            if (data.cloud_cover_mid_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member11", data.cloud_cover_mid_member11));

            if (data.cloud_cover_mid_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member12", data.cloud_cover_mid_member12));

            if (data.cloud_cover_mid_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member13", data.cloud_cover_mid_member13));

            if (data.cloud_cover_mid_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member14", data.cloud_cover_mid_member14));

            if (data.cloud_cover_mid_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member15", data.cloud_cover_mid_member15));

            if (data.cloud_cover_mid_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member16", data.cloud_cover_mid_member16));

            if (data.cloud_cover_mid_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member17", data.cloud_cover_mid_member17));

            if (data.cloud_cover_mid_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member18", data.cloud_cover_mid_member18));

            if (data.cloud_cover_mid_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member19", data.cloud_cover_mid_member19));

            if (data.cloud_cover_mid_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member20", data.cloud_cover_mid_member20));

            if (data.cloud_cover_mid_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member21", data.cloud_cover_mid_member21));

            if (data.cloud_cover_mid_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member22", data.cloud_cover_mid_member22));

            if (data.cloud_cover_mid_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member23", data.cloud_cover_mid_member23));

            if (data.cloud_cover_mid_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member24", data.cloud_cover_mid_member24));

            if (data.cloud_cover_mid_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member25", data.cloud_cover_mid_member25));

            if (data.cloud_cover_mid_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member26", data.cloud_cover_mid_member26));

            if (data.cloud_cover_mid_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member27", data.cloud_cover_mid_member27));

            if (data.cloud_cover_mid_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member28", data.cloud_cover_mid_member28));

            if (data.cloud_cover_mid_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member29", data.cloud_cover_mid_member29));

            if (data.cloud_cover_mid_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_mid_member30", data.cloud_cover_mid_member30));

            if (data.cloud_cover_high != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high", data.cloud_cover_high));

            if (data.cloud_cover_high_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member01", data.cloud_cover_high_member01));

            if (data.cloud_cover_high_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member02", data.cloud_cover_high_member02));

            if (data.cloud_cover_high_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member03", data.cloud_cover_high_member03));

            if (data.cloud_cover_high_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member04", data.cloud_cover_high_member04));

            if (data.cloud_cover_high_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member05", data.cloud_cover_high_member05));

            if (data.cloud_cover_high_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member06", data.cloud_cover_high_member06));

            if (data.cloud_cover_high_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member07", data.cloud_cover_high_member07));

            if (data.cloud_cover_high_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member08", data.cloud_cover_high_member08));

            if (data.cloud_cover_high_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member09", data.cloud_cover_high_member09));

            if (data.cloud_cover_high_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member10", data.cloud_cover_high_member10));

            if (data.cloud_cover_high_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member11", data.cloud_cover_high_member11));

            if (data.cloud_cover_high_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member12", data.cloud_cover_high_member12));

            if (data.cloud_cover_high_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member13", data.cloud_cover_high_member13));

            if (data.cloud_cover_high_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member14", data.cloud_cover_high_member14));

            if (data.cloud_cover_high_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member15", data.cloud_cover_high_member15));

            if (data.cloud_cover_high_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member16", data.cloud_cover_high_member16));

            if (data.cloud_cover_high_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member17", data.cloud_cover_high_member17));

            if (data.cloud_cover_high_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member18", data.cloud_cover_high_member18));

            if (data.cloud_cover_high_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member19", data.cloud_cover_high_member19));

            if (data.cloud_cover_high_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member20", data.cloud_cover_high_member20));

            if (data.cloud_cover_high_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member21", data.cloud_cover_high_member21));

            if (data.cloud_cover_high_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member22", data.cloud_cover_high_member22));

            if (data.cloud_cover_high_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member23", data.cloud_cover_high_member23));

            if (data.cloud_cover_high_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member24", data.cloud_cover_high_member24));

            if (data.cloud_cover_high_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member25", data.cloud_cover_high_member25));

            if (data.cloud_cover_high_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member26", data.cloud_cover_high_member26));

            if (data.cloud_cover_high_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member27", data.cloud_cover_high_member27));

            if (data.cloud_cover_high_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member28", data.cloud_cover_high_member28));

            if (data.cloud_cover_high_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member29", data.cloud_cover_high_member29));

            if (data.cloud_cover_high_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_high_member30", data.cloud_cover_high_member30));

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

            if (data.precipitation_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member18", data.precipitation_member18));

            if (data.precipitation_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member19", data.precipitation_member19));

            if (data.precipitation_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member20", data.precipitation_member20));

            if (data.precipitation_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member21", data.precipitation_member21));

            if (data.precipitation_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member22", data.precipitation_member22));

            if (data.precipitation_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member23", data.precipitation_member23));

            if (data.precipitation_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member24", data.precipitation_member24));

            if (data.precipitation_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member25", data.precipitation_member25));

            if (data.precipitation_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member26", data.precipitation_member26));

            if (data.precipitation_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member27", data.precipitation_member27));

            if (data.precipitation_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member28", data.precipitation_member28));

            if (data.precipitation_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member29", data.precipitation_member29));

            if (data.precipitation_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member30", data.precipitation_member30));

            if (data.temperature_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa", data.temperature_1000hPa));

            if (data.temperature_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member01", data.temperature_1000hPa_member01));

            if (data.temperature_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member02", data.temperature_1000hPa_member02));

            if (data.temperature_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member03", data.temperature_1000hPa_member03));

            if (data.temperature_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member04", data.temperature_1000hPa_member04));

            if (data.temperature_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member05", data.temperature_1000hPa_member05));

            if (data.temperature_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member06", data.temperature_1000hPa_member06));

            if (data.temperature_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member07", data.temperature_1000hPa_member07));

            if (data.temperature_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member08", data.temperature_1000hPa_member08));

            if (data.temperature_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member09", data.temperature_1000hPa_member09));

            if (data.temperature_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member10", data.temperature_1000hPa_member10));

            if (data.temperature_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member11", data.temperature_1000hPa_member11));

            if (data.temperature_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member12", data.temperature_1000hPa_member12));

            if (data.temperature_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member13", data.temperature_1000hPa_member13));

            if (data.temperature_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member14", data.temperature_1000hPa_member14));

            if (data.temperature_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member15", data.temperature_1000hPa_member15));

            if (data.temperature_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member16", data.temperature_1000hPa_member16));

            if (data.temperature_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member17", data.temperature_1000hPa_member17));

            if (data.temperature_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member18", data.temperature_1000hPa_member18));

            if (data.temperature_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member19", data.temperature_1000hPa_member19));

            if (data.temperature_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member20", data.temperature_1000hPa_member20));

            if (data.temperature_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member21", data.temperature_1000hPa_member21));

            if (data.temperature_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member22", data.temperature_1000hPa_member22));

            if (data.temperature_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member23", data.temperature_1000hPa_member23));

            if (data.temperature_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member24", data.temperature_1000hPa_member24));

            if (data.temperature_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member25", data.temperature_1000hPa_member25));

            if (data.temperature_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member26", data.temperature_1000hPa_member26));

            if (data.temperature_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member27", data.temperature_1000hPa_member27));

            if (data.temperature_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member28", data.temperature_1000hPa_member28));

            if (data.temperature_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member29", data.temperature_1000hPa_member29));

            if (data.temperature_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_1000hPa_member30", data.temperature_1000hPa_member30));

            if (data.temperature_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa", data.temperature_925hPa));

            if (data.temperature_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member01", data.temperature_925hPa_member01));

            if (data.temperature_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member02", data.temperature_925hPa_member02));

            if (data.temperature_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member03", data.temperature_925hPa_member03));

            if (data.temperature_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member04", data.temperature_925hPa_member04));

            if (data.temperature_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member05", data.temperature_925hPa_member05));

            if (data.temperature_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member06", data.temperature_925hPa_member06));

            if (data.temperature_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member07", data.temperature_925hPa_member07));

            if (data.temperature_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member08", data.temperature_925hPa_member08));

            if (data.temperature_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member09", data.temperature_925hPa_member09));

            if (data.temperature_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member10", data.temperature_925hPa_member10));

            if (data.temperature_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member11", data.temperature_925hPa_member11));

            if (data.temperature_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member12", data.temperature_925hPa_member12));

            if (data.temperature_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member13", data.temperature_925hPa_member13));

            if (data.temperature_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member14", data.temperature_925hPa_member14));

            if (data.temperature_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member15", data.temperature_925hPa_member15));

            if (data.temperature_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member16", data.temperature_925hPa_member16));

            if (data.temperature_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member17", data.temperature_925hPa_member17));

            if (data.temperature_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member18", data.temperature_925hPa_member18));

            if (data.temperature_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member19", data.temperature_925hPa_member19));

            if (data.temperature_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member20", data.temperature_925hPa_member20));

            if (data.temperature_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member21", data.temperature_925hPa_member21));

            if (data.temperature_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member22", data.temperature_925hPa_member22));

            if (data.temperature_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member23", data.temperature_925hPa_member23));

            if (data.temperature_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member24", data.temperature_925hPa_member24));

            if (data.temperature_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member25", data.temperature_925hPa_member25));

            if (data.temperature_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member26", data.temperature_925hPa_member26));

            if (data.temperature_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member27", data.temperature_925hPa_member27));

            if (data.temperature_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member28", data.temperature_925hPa_member28));

            if (data.temperature_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member29", data.temperature_925hPa_member29));

            if (data.temperature_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_925hPa_member30", data.temperature_925hPa_member30));

            if (data.temperature_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa", data.temperature_850hPa));

            if (data.temperature_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member01", data.temperature_850hPa_member01));

            if (data.temperature_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member02", data.temperature_850hPa_member02));

            if (data.temperature_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member03", data.temperature_850hPa_member03));

            if (data.temperature_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member04", data.temperature_850hPa_member04));

            if (data.temperature_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member05", data.temperature_850hPa_member05));

            if (data.temperature_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member06", data.temperature_850hPa_member06));

            if (data.temperature_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member07", data.temperature_850hPa_member07));

            if (data.temperature_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member08", data.temperature_850hPa_member08));

            if (data.temperature_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member09", data.temperature_850hPa_member09));

            if (data.temperature_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member10", data.temperature_850hPa_member10));

            if (data.temperature_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member11", data.temperature_850hPa_member11));

            if (data.temperature_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member12", data.temperature_850hPa_member12));

            if (data.temperature_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member13", data.temperature_850hPa_member13));

            if (data.temperature_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member14", data.temperature_850hPa_member14));

            if (data.temperature_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member15", data.temperature_850hPa_member15));

            if (data.temperature_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member16", data.temperature_850hPa_member16));

            if (data.temperature_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member17", data.temperature_850hPa_member17));

            if (data.temperature_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member18", data.temperature_850hPa_member18));

            if (data.temperature_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member19", data.temperature_850hPa_member19));

            if (data.temperature_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member20", data.temperature_850hPa_member20));

            if (data.temperature_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member21", data.temperature_850hPa_member21));

            if (data.temperature_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member22", data.temperature_850hPa_member22));

            if (data.temperature_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member23", data.temperature_850hPa_member23));

            if (data.temperature_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member24", data.temperature_850hPa_member24));

            if (data.temperature_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member25", data.temperature_850hPa_member25));

            if (data.temperature_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member26", data.temperature_850hPa_member26));

            if (data.temperature_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member27", data.temperature_850hPa_member27));

            if (data.temperature_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member28", data.temperature_850hPa_member28));

            if (data.temperature_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member29", data.temperature_850hPa_member29));

            if (data.temperature_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_850hPa_member30", data.temperature_850hPa_member30));

            if (data.temperature_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa", data.temperature_700hPa));

            if (data.temperature_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member01", data.temperature_700hPa_member01));

            if (data.temperature_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member02", data.temperature_700hPa_member02));

            if (data.temperature_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member03", data.temperature_700hPa_member03));

            if (data.temperature_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member04", data.temperature_700hPa_member04));

            if (data.temperature_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member05", data.temperature_700hPa_member05));

            if (data.temperature_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member06", data.temperature_700hPa_member06));

            if (data.temperature_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member07", data.temperature_700hPa_member07));

            if (data.temperature_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member08", data.temperature_700hPa_member08));

            if (data.temperature_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member09", data.temperature_700hPa_member09));

            if (data.temperature_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member10", data.temperature_700hPa_member10));

            if (data.temperature_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member11", data.temperature_700hPa_member11));

            if (data.temperature_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member12", data.temperature_700hPa_member12));

            if (data.temperature_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member13", data.temperature_700hPa_member13));

            if (data.temperature_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member14", data.temperature_700hPa_member14));

            if (data.temperature_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member15", data.temperature_700hPa_member15));

            if (data.temperature_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member16", data.temperature_700hPa_member16));

            if (data.temperature_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member17", data.temperature_700hPa_member17));

            if (data.temperature_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member18", data.temperature_700hPa_member18));

            if (data.temperature_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member19", data.temperature_700hPa_member19));

            if (data.temperature_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member20", data.temperature_700hPa_member20));

            if (data.temperature_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member21", data.temperature_700hPa_member21));

            if (data.temperature_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member22", data.temperature_700hPa_member22));

            if (data.temperature_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member23", data.temperature_700hPa_member23));

            if (data.temperature_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member24", data.temperature_700hPa_member24));

            if (data.temperature_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member25", data.temperature_700hPa_member25));

            if (data.temperature_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member26", data.temperature_700hPa_member26));

            if (data.temperature_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member27", data.temperature_700hPa_member27));

            if (data.temperature_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member28", data.temperature_700hPa_member28));

            if (data.temperature_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member29", data.temperature_700hPa_member29));

            if (data.temperature_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_700hPa_member30", data.temperature_700hPa_member30));

            if (data.temperature_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa", data.temperature_600hPa));

            if (data.temperature_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member01", data.temperature_600hPa_member01));

            if (data.temperature_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member02", data.temperature_600hPa_member02));

            if (data.temperature_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member03", data.temperature_600hPa_member03));

            if (data.temperature_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member04", data.temperature_600hPa_member04));

            if (data.temperature_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member05", data.temperature_600hPa_member05));

            if (data.temperature_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member06", data.temperature_600hPa_member06));

            if (data.temperature_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member07", data.temperature_600hPa_member07));

            if (data.temperature_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member08", data.temperature_600hPa_member08));

            if (data.temperature_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member09", data.temperature_600hPa_member09));

            if (data.temperature_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member10", data.temperature_600hPa_member10));

            if (data.temperature_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member11", data.temperature_600hPa_member11));

            if (data.temperature_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member12", data.temperature_600hPa_member12));

            if (data.temperature_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member13", data.temperature_600hPa_member13));

            if (data.temperature_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member14", data.temperature_600hPa_member14));

            if (data.temperature_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member15", data.temperature_600hPa_member15));

            if (data.temperature_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member16", data.temperature_600hPa_member16));

            if (data.temperature_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member17", data.temperature_600hPa_member17));

            if (data.temperature_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member18", data.temperature_600hPa_member18));

            if (data.temperature_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member19", data.temperature_600hPa_member19));

            if (data.temperature_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member20", data.temperature_600hPa_member20));

            if (data.temperature_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member21", data.temperature_600hPa_member21));

            if (data.temperature_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member22", data.temperature_600hPa_member22));

            if (data.temperature_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member23", data.temperature_600hPa_member23));

            if (data.temperature_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member24", data.temperature_600hPa_member24));

            if (data.temperature_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member25", data.temperature_600hPa_member25));

            if (data.temperature_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member26", data.temperature_600hPa_member26));

            if (data.temperature_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member27", data.temperature_600hPa_member27));

            if (data.temperature_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member28", data.temperature_600hPa_member28));

            if (data.temperature_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member29", data.temperature_600hPa_member29));

            if (data.temperature_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_600hPa_member30", data.temperature_600hPa_member30));

            if (data.temperature_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa", data.temperature_500hPa));

            if (data.temperature_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member01", data.temperature_500hPa_member01));

            if (data.temperature_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member02", data.temperature_500hPa_member02));

            if (data.temperature_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member03", data.temperature_500hPa_member03));

            if (data.temperature_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member04", data.temperature_500hPa_member04));

            if (data.temperature_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member05", data.temperature_500hPa_member05));

            if (data.temperature_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member06", data.temperature_500hPa_member06));

            if (data.temperature_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member07", data.temperature_500hPa_member07));

            if (data.temperature_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member08", data.temperature_500hPa_member08));

            if (data.temperature_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member09", data.temperature_500hPa_member09));

            if (data.temperature_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member10", data.temperature_500hPa_member10));

            if (data.temperature_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member11", data.temperature_500hPa_member11));

            if (data.temperature_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member12", data.temperature_500hPa_member12));

            if (data.temperature_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member13", data.temperature_500hPa_member13));

            if (data.temperature_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member14", data.temperature_500hPa_member14));

            if (data.temperature_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member15", data.temperature_500hPa_member15));

            if (data.temperature_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member16", data.temperature_500hPa_member16));

            if (data.temperature_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member17", data.temperature_500hPa_member17));

            if (data.temperature_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member18", data.temperature_500hPa_member18));

            if (data.temperature_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member19", data.temperature_500hPa_member19));

            if (data.temperature_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member20", data.temperature_500hPa_member20));

            if (data.temperature_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member21", data.temperature_500hPa_member21));

            if (data.temperature_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member22", data.temperature_500hPa_member22));

            if (data.temperature_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member23", data.temperature_500hPa_member23));

            if (data.temperature_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member24", data.temperature_500hPa_member24));

            if (data.temperature_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member25", data.temperature_500hPa_member25));

            if (data.temperature_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member26", data.temperature_500hPa_member26));

            if (data.temperature_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member27", data.temperature_500hPa_member27));

            if (data.temperature_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member28", data.temperature_500hPa_member28));

            if (data.temperature_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member29", data.temperature_500hPa_member29));

            if (data.temperature_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_500hPa_member30", data.temperature_500hPa_member30));

            if (data.temperature_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa", data.temperature_400hPa));

            if (data.temperature_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member01", data.temperature_400hPa_member01));

            if (data.temperature_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member02", data.temperature_400hPa_member02));

            if (data.temperature_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member03", data.temperature_400hPa_member03));

            if (data.temperature_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member04", data.temperature_400hPa_member04));

            if (data.temperature_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member05", data.temperature_400hPa_member05));

            if (data.temperature_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member06", data.temperature_400hPa_member06));

            if (data.temperature_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member07", data.temperature_400hPa_member07));

            if (data.temperature_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member08", data.temperature_400hPa_member08));

            if (data.temperature_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member09", data.temperature_400hPa_member09));

            if (data.temperature_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member10", data.temperature_400hPa_member10));

            if (data.temperature_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member11", data.temperature_400hPa_member11));

            if (data.temperature_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member12", data.temperature_400hPa_member12));

            if (data.temperature_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member13", data.temperature_400hPa_member13));

            if (data.temperature_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member14", data.temperature_400hPa_member14));

            if (data.temperature_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member15", data.temperature_400hPa_member15));

            if (data.temperature_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member16", data.temperature_400hPa_member16));

            if (data.temperature_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member17", data.temperature_400hPa_member17));

            if (data.temperature_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member18", data.temperature_400hPa_member18));

            if (data.temperature_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member19", data.temperature_400hPa_member19));

            if (data.temperature_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member20", data.temperature_400hPa_member20));

            if (data.temperature_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member21", data.temperature_400hPa_member21));

            if (data.temperature_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member22", data.temperature_400hPa_member22));

            if (data.temperature_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member23", data.temperature_400hPa_member23));

            if (data.temperature_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member24", data.temperature_400hPa_member24));

            if (data.temperature_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member25", data.temperature_400hPa_member25));

            if (data.temperature_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member26", data.temperature_400hPa_member26));

            if (data.temperature_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member27", data.temperature_400hPa_member27));

            if (data.temperature_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member28", data.temperature_400hPa_member28));

            if (data.temperature_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member29", data.temperature_400hPa_member29));

            if (data.temperature_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_400hPa_member30", data.temperature_400hPa_member30));

            if (data.temperature_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa", data.temperature_300hPa));

            if (data.temperature_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member01", data.temperature_300hPa_member01));

            if (data.temperature_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member02", data.temperature_300hPa_member02));

            if (data.temperature_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member03", data.temperature_300hPa_member03));

            if (data.temperature_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member04", data.temperature_300hPa_member04));

            if (data.temperature_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member05", data.temperature_300hPa_member05));

            if (data.temperature_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member06", data.temperature_300hPa_member06));

            if (data.temperature_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member07", data.temperature_300hPa_member07));

            if (data.temperature_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member08", data.temperature_300hPa_member08));

            if (data.temperature_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member09", data.temperature_300hPa_member09));

            if (data.temperature_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member10", data.temperature_300hPa_member10));

            if (data.temperature_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member11", data.temperature_300hPa_member11));

            if (data.temperature_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member12", data.temperature_300hPa_member12));

            if (data.temperature_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member13", data.temperature_300hPa_member13));

            if (data.temperature_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member14", data.temperature_300hPa_member14));

            if (data.temperature_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member15", data.temperature_300hPa_member15));

            if (data.temperature_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member16", data.temperature_300hPa_member16));

            if (data.temperature_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member17", data.temperature_300hPa_member17));

            if (data.temperature_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member18", data.temperature_300hPa_member18));

            if (data.temperature_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member19", data.temperature_300hPa_member19));

            if (data.temperature_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member20", data.temperature_300hPa_member20));

            if (data.temperature_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member21", data.temperature_300hPa_member21));

            if (data.temperature_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member22", data.temperature_300hPa_member22));

            if (data.temperature_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member23", data.temperature_300hPa_member23));

            if (data.temperature_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member24", data.temperature_300hPa_member24));

            if (data.temperature_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member25", data.temperature_300hPa_member25));

            if (data.temperature_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member26", data.temperature_300hPa_member26));

            if (data.temperature_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member27", data.temperature_300hPa_member27));

            if (data.temperature_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member28", data.temperature_300hPa_member28));

            if (data.temperature_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member29", data.temperature_300hPa_member29));

            if (data.temperature_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_300hPa_member30", data.temperature_300hPa_member30));

            if (data.temperature_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa", data.temperature_250hPa));

            if (data.temperature_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member01", data.temperature_250hPa_member01));

            if (data.temperature_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member02", data.temperature_250hPa_member02));

            if (data.temperature_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member03", data.temperature_250hPa_member03));

            if (data.temperature_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member04", data.temperature_250hPa_member04));

            if (data.temperature_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member05", data.temperature_250hPa_member05));

            if (data.temperature_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member06", data.temperature_250hPa_member06));

            if (data.temperature_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member07", data.temperature_250hPa_member07));

            if (data.temperature_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member08", data.temperature_250hPa_member08));

            if (data.temperature_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member09", data.temperature_250hPa_member09));

            if (data.temperature_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member10", data.temperature_250hPa_member10));

            if (data.temperature_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member11", data.temperature_250hPa_member11));

            if (data.temperature_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member12", data.temperature_250hPa_member12));

            if (data.temperature_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member13", data.temperature_250hPa_member13));

            if (data.temperature_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member14", data.temperature_250hPa_member14));

            if (data.temperature_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member15", data.temperature_250hPa_member15));

            if (data.temperature_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member16", data.temperature_250hPa_member16));

            if (data.temperature_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member17", data.temperature_250hPa_member17));

            if (data.temperature_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member18", data.temperature_250hPa_member18));

            if (data.temperature_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member19", data.temperature_250hPa_member19));

            if (data.temperature_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member20", data.temperature_250hPa_member20));

            if (data.temperature_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member21", data.temperature_250hPa_member21));

            if (data.temperature_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member22", data.temperature_250hPa_member22));

            if (data.temperature_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member23", data.temperature_250hPa_member23));

            if (data.temperature_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member24", data.temperature_250hPa_member24));

            if (data.temperature_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member25", data.temperature_250hPa_member25));

            if (data.temperature_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member26", data.temperature_250hPa_member26));

            if (data.temperature_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member27", data.temperature_250hPa_member27));

            if (data.temperature_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member28", data.temperature_250hPa_member28));

            if (data.temperature_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member29", data.temperature_250hPa_member29));

            if (data.temperature_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_250hPa_member30", data.temperature_250hPa_member30));

            if (data.temperature_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa", data.temperature_200hPa));

            if (data.temperature_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member01", data.temperature_200hPa_member01));

            if (data.temperature_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member02", data.temperature_200hPa_member02));

            if (data.temperature_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member03", data.temperature_200hPa_member03));

            if (data.temperature_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member04", data.temperature_200hPa_member04));

            if (data.temperature_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member05", data.temperature_200hPa_member05));

            if (data.temperature_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member06", data.temperature_200hPa_member06));

            if (data.temperature_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member07", data.temperature_200hPa_member07));

            if (data.temperature_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member08", data.temperature_200hPa_member08));

            if (data.temperature_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member09", data.temperature_200hPa_member09));

            if (data.temperature_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member10", data.temperature_200hPa_member10));

            if (data.temperature_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member11", data.temperature_200hPa_member11));

            if (data.temperature_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member12", data.temperature_200hPa_member12));

            if (data.temperature_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member13", data.temperature_200hPa_member13));

            if (data.temperature_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member14", data.temperature_200hPa_member14));

            if (data.temperature_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member15", data.temperature_200hPa_member15));

            if (data.temperature_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member16", data.temperature_200hPa_member16));

            if (data.temperature_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member17", data.temperature_200hPa_member17));

            if (data.temperature_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member18", data.temperature_200hPa_member18));

            if (data.temperature_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member19", data.temperature_200hPa_member19));

            if (data.temperature_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member20", data.temperature_200hPa_member20));

            if (data.temperature_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member21", data.temperature_200hPa_member21));

            if (data.temperature_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member22", data.temperature_200hPa_member22));

            if (data.temperature_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member23", data.temperature_200hPa_member23));

            if (data.temperature_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member24", data.temperature_200hPa_member24));

            if (data.temperature_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member25", data.temperature_200hPa_member25));

            if (data.temperature_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member26", data.temperature_200hPa_member26));

            if (data.temperature_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member27", data.temperature_200hPa_member27));

            if (data.temperature_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member28", data.temperature_200hPa_member28));

            if (data.temperature_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member29", data.temperature_200hPa_member29));

            if (data.temperature_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_200hPa_member30", data.temperature_200hPa_member30));

            if (data.temperature_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa", data.temperature_150hPa));

            if (data.temperature_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member01", data.temperature_150hPa_member01));

            if (data.temperature_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member02", data.temperature_150hPa_member02));

            if (data.temperature_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member03", data.temperature_150hPa_member03));

            if (data.temperature_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member04", data.temperature_150hPa_member04));

            if (data.temperature_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member05", data.temperature_150hPa_member05));

            if (data.temperature_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member06", data.temperature_150hPa_member06));

            if (data.temperature_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member07", data.temperature_150hPa_member07));

            if (data.temperature_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member08", data.temperature_150hPa_member08));

            if (data.temperature_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member09", data.temperature_150hPa_member09));

            if (data.temperature_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member10", data.temperature_150hPa_member10));

            if (data.temperature_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member11", data.temperature_150hPa_member11));

            if (data.temperature_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member12", data.temperature_150hPa_member12));

            if (data.temperature_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member13", data.temperature_150hPa_member13));

            if (data.temperature_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member14", data.temperature_150hPa_member14));

            if (data.temperature_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member15", data.temperature_150hPa_member15));

            if (data.temperature_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member16", data.temperature_150hPa_member16));

            if (data.temperature_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member17", data.temperature_150hPa_member17));

            if (data.temperature_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member18", data.temperature_150hPa_member18));

            if (data.temperature_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member19", data.temperature_150hPa_member19));

            if (data.temperature_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member20", data.temperature_150hPa_member20));

            if (data.temperature_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member21", data.temperature_150hPa_member21));

            if (data.temperature_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member22", data.temperature_150hPa_member22));

            if (data.temperature_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member23", data.temperature_150hPa_member23));

            if (data.temperature_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member24", data.temperature_150hPa_member24));

            if (data.temperature_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member25", data.temperature_150hPa_member25));

            if (data.temperature_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member26", data.temperature_150hPa_member26));

            if (data.temperature_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member27", data.temperature_150hPa_member27));

            if (data.temperature_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member28", data.temperature_150hPa_member28));

            if (data.temperature_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member29", data.temperature_150hPa_member29));

            if (data.temperature_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_150hPa_member30", data.temperature_150hPa_member30));

            if (data.temperature_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa", data.temperature_100hPa));

            if (data.temperature_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member01", data.temperature_100hPa_member01));

            if (data.temperature_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member02", data.temperature_100hPa_member02));

            if (data.temperature_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member03", data.temperature_100hPa_member03));

            if (data.temperature_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member04", data.temperature_100hPa_member04));

            if (data.temperature_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member05", data.temperature_100hPa_member05));

            if (data.temperature_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member06", data.temperature_100hPa_member06));

            if (data.temperature_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member07", data.temperature_100hPa_member07));

            if (data.temperature_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member08", data.temperature_100hPa_member08));

            if (data.temperature_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member09", data.temperature_100hPa_member09));

            if (data.temperature_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member10", data.temperature_100hPa_member10));

            if (data.temperature_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member11", data.temperature_100hPa_member11));

            if (data.temperature_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member12", data.temperature_100hPa_member12));

            if (data.temperature_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member13", data.temperature_100hPa_member13));

            if (data.temperature_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member14", data.temperature_100hPa_member14));

            if (data.temperature_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member15", data.temperature_100hPa_member15));

            if (data.temperature_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member16", data.temperature_100hPa_member16));

            if (data.temperature_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member17", data.temperature_100hPa_member17));

            if (data.temperature_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member18", data.temperature_100hPa_member18));

            if (data.temperature_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member19", data.temperature_100hPa_member19));

            if (data.temperature_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member20", data.temperature_100hPa_member20));

            if (data.temperature_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member21", data.temperature_100hPa_member21));

            if (data.temperature_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member22", data.temperature_100hPa_member22));

            if (data.temperature_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member23", data.temperature_100hPa_member23));

            if (data.temperature_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member24", data.temperature_100hPa_member24));

            if (data.temperature_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member25", data.temperature_100hPa_member25));

            if (data.temperature_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member26", data.temperature_100hPa_member26));

            if (data.temperature_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member27", data.temperature_100hPa_member27));

            if (data.temperature_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member28", data.temperature_100hPa_member28));

            if (data.temperature_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member29", data.temperature_100hPa_member29));

            if (data.temperature_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_100hPa_member30", data.temperature_100hPa_member30));

            if (data.temperature_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa", data.temperature_50hPa));

            if (data.temperature_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member01", data.temperature_50hPa_member01));

            if (data.temperature_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member02", data.temperature_50hPa_member02));

            if (data.temperature_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member03", data.temperature_50hPa_member03));

            if (data.temperature_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member04", data.temperature_50hPa_member04));

            if (data.temperature_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member05", data.temperature_50hPa_member05));

            if (data.temperature_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member06", data.temperature_50hPa_member06));

            if (data.temperature_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member07", data.temperature_50hPa_member07));

            if (data.temperature_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member08", data.temperature_50hPa_member08));

            if (data.temperature_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member09", data.temperature_50hPa_member09));

            if (data.temperature_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member10", data.temperature_50hPa_member10));

            if (data.temperature_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member11", data.temperature_50hPa_member11));

            if (data.temperature_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member12", data.temperature_50hPa_member12));

            if (data.temperature_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member13", data.temperature_50hPa_member13));

            if (data.temperature_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member14", data.temperature_50hPa_member14));

            if (data.temperature_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member15", data.temperature_50hPa_member15));

            if (data.temperature_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member16", data.temperature_50hPa_member16));

            if (data.temperature_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member17", data.temperature_50hPa_member17));

            if (data.temperature_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member18", data.temperature_50hPa_member18));

            if (data.temperature_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member19", data.temperature_50hPa_member19));

            if (data.temperature_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member20", data.temperature_50hPa_member20));

            if (data.temperature_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member21", data.temperature_50hPa_member21));

            if (data.temperature_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member22", data.temperature_50hPa_member22));

            if (data.temperature_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member23", data.temperature_50hPa_member23));

            if (data.temperature_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member24", data.temperature_50hPa_member24));

            if (data.temperature_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member25", data.temperature_50hPa_member25));

            if (data.temperature_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member26", data.temperature_50hPa_member26));

            if (data.temperature_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member27", data.temperature_50hPa_member27));

            if (data.temperature_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member28", data.temperature_50hPa_member28));

            if (data.temperature_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member29", data.temperature_50hPa_member29));

            if (data.temperature_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_50hPa_member30", data.temperature_50hPa_member30));

            if (data.dew_point_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa", data.dew_point_1000hPa));

            if (data.dew_point_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member01", data.dew_point_1000hPa_member01));

            if (data.dew_point_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member02", data.dew_point_1000hPa_member02));

            if (data.dew_point_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member03", data.dew_point_1000hPa_member03));

            if (data.dew_point_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member04", data.dew_point_1000hPa_member04));

            if (data.dew_point_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member05", data.dew_point_1000hPa_member05));

            if (data.dew_point_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member06", data.dew_point_1000hPa_member06));

            if (data.dew_point_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member07", data.dew_point_1000hPa_member07));

            if (data.dew_point_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member08", data.dew_point_1000hPa_member08));

            if (data.dew_point_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member09", data.dew_point_1000hPa_member09));

            if (data.dew_point_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member10", data.dew_point_1000hPa_member10));

            if (data.dew_point_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member11", data.dew_point_1000hPa_member11));

            if (data.dew_point_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member12", data.dew_point_1000hPa_member12));

            if (data.dew_point_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member13", data.dew_point_1000hPa_member13));

            if (data.dew_point_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member14", data.dew_point_1000hPa_member14));

            if (data.dew_point_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member15", data.dew_point_1000hPa_member15));

            if (data.dew_point_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member16", data.dew_point_1000hPa_member16));

            if (data.dew_point_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member17", data.dew_point_1000hPa_member17));

            if (data.dew_point_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member18", data.dew_point_1000hPa_member18));

            if (data.dew_point_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member19", data.dew_point_1000hPa_member19));

            if (data.dew_point_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member20", data.dew_point_1000hPa_member20));

            if (data.dew_point_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member21", data.dew_point_1000hPa_member21));

            if (data.dew_point_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member22", data.dew_point_1000hPa_member22));

            if (data.dew_point_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member23", data.dew_point_1000hPa_member23));

            if (data.dew_point_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member24", data.dew_point_1000hPa_member24));

            if (data.dew_point_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member25", data.dew_point_1000hPa_member25));

            if (data.dew_point_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member26", data.dew_point_1000hPa_member26));

            if (data.dew_point_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member27", data.dew_point_1000hPa_member27));

            if (data.dew_point_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member28", data.dew_point_1000hPa_member28));

            if (data.dew_point_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member29", data.dew_point_1000hPa_member29));

            if (data.dew_point_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_1000hPa_member30", data.dew_point_1000hPa_member30));

            if (data.dew_point_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa", data.dew_point_925hPa));

            if (data.dew_point_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member01", data.dew_point_925hPa_member01));

            if (data.dew_point_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member02", data.dew_point_925hPa_member02));

            if (data.dew_point_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member03", data.dew_point_925hPa_member03));

            if (data.dew_point_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member04", data.dew_point_925hPa_member04));

            if (data.dew_point_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member05", data.dew_point_925hPa_member05));

            if (data.dew_point_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member06", data.dew_point_925hPa_member06));

            if (data.dew_point_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member07", data.dew_point_925hPa_member07));

            if (data.dew_point_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member08", data.dew_point_925hPa_member08));

            if (data.dew_point_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member09", data.dew_point_925hPa_member09));

            if (data.dew_point_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member10", data.dew_point_925hPa_member10));

            if (data.dew_point_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member11", data.dew_point_925hPa_member11));

            if (data.dew_point_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member12", data.dew_point_925hPa_member12));

            if (data.dew_point_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member13", data.dew_point_925hPa_member13));

            if (data.dew_point_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member14", data.dew_point_925hPa_member14));

            if (data.dew_point_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member15", data.dew_point_925hPa_member15));

            if (data.dew_point_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member16", data.dew_point_925hPa_member16));

            if (data.dew_point_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member17", data.dew_point_925hPa_member17));

            if (data.dew_point_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member18", data.dew_point_925hPa_member18));

            if (data.dew_point_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member19", data.dew_point_925hPa_member19));

            if (data.dew_point_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member20", data.dew_point_925hPa_member20));

            if (data.dew_point_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member21", data.dew_point_925hPa_member21));

            if (data.dew_point_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member22", data.dew_point_925hPa_member22));

            if (data.dew_point_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member23", data.dew_point_925hPa_member23));

            if (data.dew_point_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member24", data.dew_point_925hPa_member24));

            if (data.dew_point_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member25", data.dew_point_925hPa_member25));

            if (data.dew_point_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member26", data.dew_point_925hPa_member26));

            if (data.dew_point_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member27", data.dew_point_925hPa_member27));

            if (data.dew_point_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member28", data.dew_point_925hPa_member28));

            if (data.dew_point_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member29", data.dew_point_925hPa_member29));

            if (data.dew_point_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_925hPa_member30", data.dew_point_925hPa_member30));

            if (data.dew_point_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa", data.dew_point_850hPa));

            if (data.dew_point_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member01", data.dew_point_850hPa_member01));

            if (data.dew_point_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member02", data.dew_point_850hPa_member02));

            if (data.dew_point_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member03", data.dew_point_850hPa_member03));

            if (data.dew_point_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member04", data.dew_point_850hPa_member04));

            if (data.dew_point_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member05", data.dew_point_850hPa_member05));

            if (data.dew_point_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member06", data.dew_point_850hPa_member06));

            if (data.dew_point_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member07", data.dew_point_850hPa_member07));

            if (data.dew_point_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member08", data.dew_point_850hPa_member08));

            if (data.dew_point_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member09", data.dew_point_850hPa_member09));

            if (data.dew_point_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member10", data.dew_point_850hPa_member10));

            if (data.dew_point_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member11", data.dew_point_850hPa_member11));

            if (data.dew_point_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member12", data.dew_point_850hPa_member12));

            if (data.dew_point_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member13", data.dew_point_850hPa_member13));

            if (data.dew_point_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member14", data.dew_point_850hPa_member14));

            if (data.dew_point_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member15", data.dew_point_850hPa_member15));

            if (data.dew_point_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member16", data.dew_point_850hPa_member16));

            if (data.dew_point_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member17", data.dew_point_850hPa_member17));

            if (data.dew_point_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member18", data.dew_point_850hPa_member18));

            if (data.dew_point_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member19", data.dew_point_850hPa_member19));

            if (data.dew_point_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member20", data.dew_point_850hPa_member20));

            if (data.dew_point_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member21", data.dew_point_850hPa_member21));

            if (data.dew_point_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member22", data.dew_point_850hPa_member22));

            if (data.dew_point_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member23", data.dew_point_850hPa_member23));

            if (data.dew_point_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member24", data.dew_point_850hPa_member24));

            if (data.dew_point_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member25", data.dew_point_850hPa_member25));

            if (data.dew_point_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member26", data.dew_point_850hPa_member26));

            if (data.dew_point_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member27", data.dew_point_850hPa_member27));

            if (data.dew_point_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member28", data.dew_point_850hPa_member28));

            if (data.dew_point_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member29", data.dew_point_850hPa_member29));

            if (data.dew_point_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_850hPa_member30", data.dew_point_850hPa_member30));

            if (data.dew_point_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa", data.dew_point_700hPa));

            if (data.dew_point_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member01", data.dew_point_700hPa_member01));

            if (data.dew_point_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member02", data.dew_point_700hPa_member02));

            if (data.dew_point_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member03", data.dew_point_700hPa_member03));

            if (data.dew_point_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member04", data.dew_point_700hPa_member04));

            if (data.dew_point_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member05", data.dew_point_700hPa_member05));

            if (data.dew_point_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member06", data.dew_point_700hPa_member06));

            if (data.dew_point_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member07", data.dew_point_700hPa_member07));

            if (data.dew_point_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member08", data.dew_point_700hPa_member08));

            if (data.dew_point_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member09", data.dew_point_700hPa_member09));

            if (data.dew_point_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member10", data.dew_point_700hPa_member10));

            if (data.dew_point_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member11", data.dew_point_700hPa_member11));

            if (data.dew_point_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member12", data.dew_point_700hPa_member12));

            if (data.dew_point_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member13", data.dew_point_700hPa_member13));

            if (data.dew_point_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member14", data.dew_point_700hPa_member14));

            if (data.dew_point_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member15", data.dew_point_700hPa_member15));

            if (data.dew_point_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member16", data.dew_point_700hPa_member16));

            if (data.dew_point_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member17", data.dew_point_700hPa_member17));

            if (data.dew_point_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member18", data.dew_point_700hPa_member18));

            if (data.dew_point_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member19", data.dew_point_700hPa_member19));

            if (data.dew_point_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member20", data.dew_point_700hPa_member20));

            if (data.dew_point_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member21", data.dew_point_700hPa_member21));

            if (data.dew_point_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member22", data.dew_point_700hPa_member22));

            if (data.dew_point_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member23", data.dew_point_700hPa_member23));

            if (data.dew_point_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member24", data.dew_point_700hPa_member24));

            if (data.dew_point_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member25", data.dew_point_700hPa_member25));

            if (data.dew_point_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member26", data.dew_point_700hPa_member26));

            if (data.dew_point_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member27", data.dew_point_700hPa_member27));

            if (data.dew_point_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member28", data.dew_point_700hPa_member28));

            if (data.dew_point_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member29", data.dew_point_700hPa_member29));

            if (data.dew_point_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_700hPa_member30", data.dew_point_700hPa_member30));

            if (data.dew_point_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa", data.dew_point_600hPa));

            if (data.dew_point_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member01", data.dew_point_600hPa_member01));

            if (data.dew_point_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member02", data.dew_point_600hPa_member02));

            if (data.dew_point_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member03", data.dew_point_600hPa_member03));

            if (data.dew_point_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member04", data.dew_point_600hPa_member04));

            if (data.dew_point_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member05", data.dew_point_600hPa_member05));

            if (data.dew_point_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member06", data.dew_point_600hPa_member06));

            if (data.dew_point_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member07", data.dew_point_600hPa_member07));

            if (data.dew_point_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member08", data.dew_point_600hPa_member08));

            if (data.dew_point_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member09", data.dew_point_600hPa_member09));

            if (data.dew_point_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member10", data.dew_point_600hPa_member10));

            if (data.dew_point_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member11", data.dew_point_600hPa_member11));

            if (data.dew_point_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member12", data.dew_point_600hPa_member12));

            if (data.dew_point_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member13", data.dew_point_600hPa_member13));

            if (data.dew_point_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member14", data.dew_point_600hPa_member14));

            if (data.dew_point_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member15", data.dew_point_600hPa_member15));

            if (data.dew_point_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member16", data.dew_point_600hPa_member16));

            if (data.dew_point_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member17", data.dew_point_600hPa_member17));

            if (data.dew_point_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member18", data.dew_point_600hPa_member18));

            if (data.dew_point_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member19", data.dew_point_600hPa_member19));

            if (data.dew_point_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member20", data.dew_point_600hPa_member20));

            if (data.dew_point_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member21", data.dew_point_600hPa_member21));

            if (data.dew_point_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member22", data.dew_point_600hPa_member22));

            if (data.dew_point_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member23", data.dew_point_600hPa_member23));

            if (data.dew_point_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member24", data.dew_point_600hPa_member24));

            if (data.dew_point_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member25", data.dew_point_600hPa_member25));

            if (data.dew_point_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member26", data.dew_point_600hPa_member26));

            if (data.dew_point_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member27", data.dew_point_600hPa_member27));

            if (data.dew_point_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member28", data.dew_point_600hPa_member28));

            if (data.dew_point_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member29", data.dew_point_600hPa_member29));

            if (data.dew_point_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_600hPa_member30", data.dew_point_600hPa_member30));

            if (data.dew_point_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa", data.dew_point_500hPa));

            if (data.dew_point_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member01", data.dew_point_500hPa_member01));

            if (data.dew_point_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member02", data.dew_point_500hPa_member02));

            if (data.dew_point_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member03", data.dew_point_500hPa_member03));

            if (data.dew_point_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member04", data.dew_point_500hPa_member04));

            if (data.dew_point_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member05", data.dew_point_500hPa_member05));

            if (data.dew_point_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member06", data.dew_point_500hPa_member06));

            if (data.dew_point_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member07", data.dew_point_500hPa_member07));

            if (data.dew_point_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member08", data.dew_point_500hPa_member08));

            if (data.dew_point_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member09", data.dew_point_500hPa_member09));

            if (data.dew_point_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member10", data.dew_point_500hPa_member10));

            if (data.dew_point_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member11", data.dew_point_500hPa_member11));

            if (data.dew_point_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member12", data.dew_point_500hPa_member12));

            if (data.dew_point_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member13", data.dew_point_500hPa_member13));

            if (data.dew_point_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member14", data.dew_point_500hPa_member14));

            if (data.dew_point_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member15", data.dew_point_500hPa_member15));

            if (data.dew_point_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member16", data.dew_point_500hPa_member16));

            if (data.dew_point_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member17", data.dew_point_500hPa_member17));

            if (data.dew_point_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member18", data.dew_point_500hPa_member18));

            if (data.dew_point_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member19", data.dew_point_500hPa_member19));

            if (data.dew_point_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member20", data.dew_point_500hPa_member20));

            if (data.dew_point_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member21", data.dew_point_500hPa_member21));

            if (data.dew_point_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member22", data.dew_point_500hPa_member22));

            if (data.dew_point_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member23", data.dew_point_500hPa_member23));

            if (data.dew_point_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member24", data.dew_point_500hPa_member24));

            if (data.dew_point_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member25", data.dew_point_500hPa_member25));

            if (data.dew_point_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member26", data.dew_point_500hPa_member26));

            if (data.dew_point_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member27", data.dew_point_500hPa_member27));

            if (data.dew_point_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member28", data.dew_point_500hPa_member28));

            if (data.dew_point_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member29", data.dew_point_500hPa_member29));

            if (data.dew_point_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_500hPa_member30", data.dew_point_500hPa_member30));

            if (data.dew_point_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa", data.dew_point_400hPa));

            if (data.dew_point_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member01", data.dew_point_400hPa_member01));

            if (data.dew_point_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member02", data.dew_point_400hPa_member02));

            if (data.dew_point_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member03", data.dew_point_400hPa_member03));

            if (data.dew_point_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member04", data.dew_point_400hPa_member04));

            if (data.dew_point_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member05", data.dew_point_400hPa_member05));

            if (data.dew_point_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member06", data.dew_point_400hPa_member06));

            if (data.dew_point_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member07", data.dew_point_400hPa_member07));

            if (data.dew_point_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member08", data.dew_point_400hPa_member08));

            if (data.dew_point_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member09", data.dew_point_400hPa_member09));

            if (data.dew_point_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member10", data.dew_point_400hPa_member10));

            if (data.dew_point_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member11", data.dew_point_400hPa_member11));

            if (data.dew_point_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member12", data.dew_point_400hPa_member12));

            if (data.dew_point_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member13", data.dew_point_400hPa_member13));

            if (data.dew_point_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member14", data.dew_point_400hPa_member14));

            if (data.dew_point_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member15", data.dew_point_400hPa_member15));

            if (data.dew_point_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member16", data.dew_point_400hPa_member16));

            if (data.dew_point_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member17", data.dew_point_400hPa_member17));

            if (data.dew_point_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member18", data.dew_point_400hPa_member18));

            if (data.dew_point_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member19", data.dew_point_400hPa_member19));

            if (data.dew_point_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member20", data.dew_point_400hPa_member20));

            if (data.dew_point_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member21", data.dew_point_400hPa_member21));

            if (data.dew_point_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member22", data.dew_point_400hPa_member22));

            if (data.dew_point_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member23", data.dew_point_400hPa_member23));

            if (data.dew_point_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member24", data.dew_point_400hPa_member24));

            if (data.dew_point_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member25", data.dew_point_400hPa_member25));

            if (data.dew_point_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member26", data.dew_point_400hPa_member26));

            if (data.dew_point_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member27", data.dew_point_400hPa_member27));

            if (data.dew_point_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member28", data.dew_point_400hPa_member28));

            if (data.dew_point_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member29", data.dew_point_400hPa_member29));

            if (data.dew_point_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_400hPa_member30", data.dew_point_400hPa_member30));

            if (data.dew_point_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa", data.dew_point_300hPa));

            if (data.dew_point_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member01", data.dew_point_300hPa_member01));

            if (data.dew_point_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member02", data.dew_point_300hPa_member02));

            if (data.dew_point_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member03", data.dew_point_300hPa_member03));

            if (data.dew_point_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member04", data.dew_point_300hPa_member04));

            if (data.dew_point_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member05", data.dew_point_300hPa_member05));

            if (data.dew_point_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member06", data.dew_point_300hPa_member06));

            if (data.dew_point_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member07", data.dew_point_300hPa_member07));

            if (data.dew_point_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member08", data.dew_point_300hPa_member08));

            if (data.dew_point_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member09", data.dew_point_300hPa_member09));

            if (data.dew_point_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member10", data.dew_point_300hPa_member10));

            if (data.dew_point_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member11", data.dew_point_300hPa_member11));

            if (data.dew_point_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member12", data.dew_point_300hPa_member12));

            if (data.dew_point_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member13", data.dew_point_300hPa_member13));

            if (data.dew_point_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member14", data.dew_point_300hPa_member14));

            if (data.dew_point_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member15", data.dew_point_300hPa_member15));

            if (data.dew_point_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member16", data.dew_point_300hPa_member16));

            if (data.dew_point_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member17", data.dew_point_300hPa_member17));

            if (data.dew_point_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member18", data.dew_point_300hPa_member18));

            if (data.dew_point_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member19", data.dew_point_300hPa_member19));

            if (data.dew_point_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member20", data.dew_point_300hPa_member20));

            if (data.dew_point_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member21", data.dew_point_300hPa_member21));

            if (data.dew_point_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member22", data.dew_point_300hPa_member22));

            if (data.dew_point_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member23", data.dew_point_300hPa_member23));

            if (data.dew_point_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member24", data.dew_point_300hPa_member24));

            if (data.dew_point_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member25", data.dew_point_300hPa_member25));

            if (data.dew_point_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member26", data.dew_point_300hPa_member26));

            if (data.dew_point_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member27", data.dew_point_300hPa_member27));

            if (data.dew_point_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member28", data.dew_point_300hPa_member28));

            if (data.dew_point_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member29", data.dew_point_300hPa_member29));

            if (data.dew_point_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_300hPa_member30", data.dew_point_300hPa_member30));

            if (data.dew_point_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa", data.dew_point_250hPa));

            if (data.dew_point_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member01", data.dew_point_250hPa_member01));

            if (data.dew_point_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member02", data.dew_point_250hPa_member02));

            if (data.dew_point_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member03", data.dew_point_250hPa_member03));

            if (data.dew_point_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member04", data.dew_point_250hPa_member04));

            if (data.dew_point_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member05", data.dew_point_250hPa_member05));

            if (data.dew_point_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member06", data.dew_point_250hPa_member06));

            if (data.dew_point_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member07", data.dew_point_250hPa_member07));

            if (data.dew_point_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member08", data.dew_point_250hPa_member08));

            if (data.dew_point_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member09", data.dew_point_250hPa_member09));

            if (data.dew_point_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member10", data.dew_point_250hPa_member10));

            if (data.dew_point_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member11", data.dew_point_250hPa_member11));

            if (data.dew_point_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member12", data.dew_point_250hPa_member12));

            if (data.dew_point_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member13", data.dew_point_250hPa_member13));

            if (data.dew_point_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member14", data.dew_point_250hPa_member14));

            if (data.dew_point_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member15", data.dew_point_250hPa_member15));

            if (data.dew_point_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member16", data.dew_point_250hPa_member16));

            if (data.dew_point_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member17", data.dew_point_250hPa_member17));

            if (data.dew_point_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member18", data.dew_point_250hPa_member18));

            if (data.dew_point_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member19", data.dew_point_250hPa_member19));

            if (data.dew_point_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member20", data.dew_point_250hPa_member20));

            if (data.dew_point_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member21", data.dew_point_250hPa_member21));

            if (data.dew_point_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member22", data.dew_point_250hPa_member22));

            if (data.dew_point_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member23", data.dew_point_250hPa_member23));

            if (data.dew_point_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member24", data.dew_point_250hPa_member24));

            if (data.dew_point_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member25", data.dew_point_250hPa_member25));

            if (data.dew_point_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member26", data.dew_point_250hPa_member26));

            if (data.dew_point_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member27", data.dew_point_250hPa_member27));

            if (data.dew_point_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member28", data.dew_point_250hPa_member28));

            if (data.dew_point_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member29", data.dew_point_250hPa_member29));

            if (data.dew_point_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_250hPa_member30", data.dew_point_250hPa_member30));

            if (data.dew_point_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa", data.dew_point_200hPa));

            if (data.dew_point_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member01", data.dew_point_200hPa_member01));

            if (data.dew_point_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member02", data.dew_point_200hPa_member02));

            if (data.dew_point_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member03", data.dew_point_200hPa_member03));

            if (data.dew_point_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member04", data.dew_point_200hPa_member04));

            if (data.dew_point_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member05", data.dew_point_200hPa_member05));

            if (data.dew_point_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member06", data.dew_point_200hPa_member06));

            if (data.dew_point_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member07", data.dew_point_200hPa_member07));

            if (data.dew_point_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member08", data.dew_point_200hPa_member08));

            if (data.dew_point_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member09", data.dew_point_200hPa_member09));

            if (data.dew_point_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member10", data.dew_point_200hPa_member10));

            if (data.dew_point_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member11", data.dew_point_200hPa_member11));

            if (data.dew_point_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member12", data.dew_point_200hPa_member12));

            if (data.dew_point_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member13", data.dew_point_200hPa_member13));

            if (data.dew_point_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member14", data.dew_point_200hPa_member14));

            if (data.dew_point_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member15", data.dew_point_200hPa_member15));

            if (data.dew_point_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member16", data.dew_point_200hPa_member16));

            if (data.dew_point_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member17", data.dew_point_200hPa_member17));

            if (data.dew_point_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member18", data.dew_point_200hPa_member18));

            if (data.dew_point_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member19", data.dew_point_200hPa_member19));

            if (data.dew_point_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member20", data.dew_point_200hPa_member20));

            if (data.dew_point_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member21", data.dew_point_200hPa_member21));

            if (data.dew_point_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member22", data.dew_point_200hPa_member22));

            if (data.dew_point_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member23", data.dew_point_200hPa_member23));

            if (data.dew_point_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member24", data.dew_point_200hPa_member24));

            if (data.dew_point_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member25", data.dew_point_200hPa_member25));

            if (data.dew_point_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member26", data.dew_point_200hPa_member26));

            if (data.dew_point_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member27", data.dew_point_200hPa_member27));

            if (data.dew_point_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member28", data.dew_point_200hPa_member28));

            if (data.dew_point_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member29", data.dew_point_200hPa_member29));

            if (data.dew_point_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_200hPa_member30", data.dew_point_200hPa_member30));

            if (data.dew_point_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa", data.dew_point_150hPa));

            if (data.dew_point_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member01", data.dew_point_150hPa_member01));

            if (data.dew_point_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member02", data.dew_point_150hPa_member02));

            if (data.dew_point_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member03", data.dew_point_150hPa_member03));

            if (data.dew_point_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member04", data.dew_point_150hPa_member04));

            if (data.dew_point_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member05", data.dew_point_150hPa_member05));

            if (data.dew_point_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member06", data.dew_point_150hPa_member06));

            if (data.dew_point_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member07", data.dew_point_150hPa_member07));

            if (data.dew_point_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member08", data.dew_point_150hPa_member08));

            if (data.dew_point_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member09", data.dew_point_150hPa_member09));

            if (data.dew_point_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member10", data.dew_point_150hPa_member10));

            if (data.dew_point_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member11", data.dew_point_150hPa_member11));

            if (data.dew_point_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member12", data.dew_point_150hPa_member12));

            if (data.dew_point_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member13", data.dew_point_150hPa_member13));

            if (data.dew_point_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member14", data.dew_point_150hPa_member14));

            if (data.dew_point_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member15", data.dew_point_150hPa_member15));

            if (data.dew_point_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member16", data.dew_point_150hPa_member16));

            if (data.dew_point_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member17", data.dew_point_150hPa_member17));

            if (data.dew_point_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member18", data.dew_point_150hPa_member18));

            if (data.dew_point_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member19", data.dew_point_150hPa_member19));

            if (data.dew_point_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member20", data.dew_point_150hPa_member20));

            if (data.dew_point_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member21", data.dew_point_150hPa_member21));

            if (data.dew_point_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member22", data.dew_point_150hPa_member22));

            if (data.dew_point_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member23", data.dew_point_150hPa_member23));

            if (data.dew_point_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member24", data.dew_point_150hPa_member24));

            if (data.dew_point_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member25", data.dew_point_150hPa_member25));

            if (data.dew_point_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member26", data.dew_point_150hPa_member26));

            if (data.dew_point_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member27", data.dew_point_150hPa_member27));

            if (data.dew_point_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member28", data.dew_point_150hPa_member28));

            if (data.dew_point_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member29", data.dew_point_150hPa_member29));

            if (data.dew_point_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_150hPa_member30", data.dew_point_150hPa_member30));

            if (data.dew_point_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa", data.dew_point_100hPa));

            if (data.dew_point_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member01", data.dew_point_100hPa_member01));

            if (data.dew_point_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member02", data.dew_point_100hPa_member02));

            if (data.dew_point_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member03", data.dew_point_100hPa_member03));

            if (data.dew_point_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member04", data.dew_point_100hPa_member04));

            if (data.dew_point_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member05", data.dew_point_100hPa_member05));

            if (data.dew_point_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member06", data.dew_point_100hPa_member06));

            if (data.dew_point_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member07", data.dew_point_100hPa_member07));

            if (data.dew_point_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member08", data.dew_point_100hPa_member08));

            if (data.dew_point_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member09", data.dew_point_100hPa_member09));

            if (data.dew_point_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member10", data.dew_point_100hPa_member10));

            if (data.dew_point_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member11", data.dew_point_100hPa_member11));

            if (data.dew_point_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member12", data.dew_point_100hPa_member12));

            if (data.dew_point_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member13", data.dew_point_100hPa_member13));

            if (data.dew_point_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member14", data.dew_point_100hPa_member14));

            if (data.dew_point_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member15", data.dew_point_100hPa_member15));

            if (data.dew_point_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member16", data.dew_point_100hPa_member16));

            if (data.dew_point_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member17", data.dew_point_100hPa_member17));

            if (data.dew_point_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member18", data.dew_point_100hPa_member18));

            if (data.dew_point_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member19", data.dew_point_100hPa_member19));

            if (data.dew_point_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member20", data.dew_point_100hPa_member20));

            if (data.dew_point_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member21", data.dew_point_100hPa_member21));

            if (data.dew_point_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member22", data.dew_point_100hPa_member22));

            if (data.dew_point_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member23", data.dew_point_100hPa_member23));

            if (data.dew_point_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member24", data.dew_point_100hPa_member24));

            if (data.dew_point_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member25", data.dew_point_100hPa_member25));

            if (data.dew_point_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member26", data.dew_point_100hPa_member26));

            if (data.dew_point_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member27", data.dew_point_100hPa_member27));

            if (data.dew_point_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member28", data.dew_point_100hPa_member28));

            if (data.dew_point_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member29", data.dew_point_100hPa_member29));

            if (data.dew_point_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_100hPa_member30", data.dew_point_100hPa_member30));

            if (data.dew_point_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa", data.dew_point_50hPa));

            if (data.dew_point_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member01", data.dew_point_50hPa_member01));

            if (data.dew_point_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member02", data.dew_point_50hPa_member02));

            if (data.dew_point_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member03", data.dew_point_50hPa_member03));

            if (data.dew_point_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member04", data.dew_point_50hPa_member04));

            if (data.dew_point_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member05", data.dew_point_50hPa_member05));

            if (data.dew_point_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member06", data.dew_point_50hPa_member06));

            if (data.dew_point_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member07", data.dew_point_50hPa_member07));

            if (data.dew_point_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member08", data.dew_point_50hPa_member08));

            if (data.dew_point_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member09", data.dew_point_50hPa_member09));

            if (data.dew_point_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member10", data.dew_point_50hPa_member10));

            if (data.dew_point_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member11", data.dew_point_50hPa_member11));

            if (data.dew_point_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member12", data.dew_point_50hPa_member12));

            if (data.dew_point_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member13", data.dew_point_50hPa_member13));

            if (data.dew_point_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member14", data.dew_point_50hPa_member14));

            if (data.dew_point_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member15", data.dew_point_50hPa_member15));

            if (data.dew_point_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member16", data.dew_point_50hPa_member16));

            if (data.dew_point_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member17", data.dew_point_50hPa_member17));

            if (data.dew_point_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member18", data.dew_point_50hPa_member18));

            if (data.dew_point_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member19", data.dew_point_50hPa_member19));

            if (data.dew_point_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member20", data.dew_point_50hPa_member20));

            if (data.dew_point_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member21", data.dew_point_50hPa_member21));

            if (data.dew_point_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member22", data.dew_point_50hPa_member22));

            if (data.dew_point_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member23", data.dew_point_50hPa_member23));

            if (data.dew_point_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member24", data.dew_point_50hPa_member24));

            if (data.dew_point_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member25", data.dew_point_50hPa_member25));

            if (data.dew_point_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member26", data.dew_point_50hPa_member26));

            if (data.dew_point_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member27", data.dew_point_50hPa_member27));

            if (data.dew_point_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member28", data.dew_point_50hPa_member28));

            if (data.dew_point_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member29", data.dew_point_50hPa_member29));

            if (data.dew_point_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_50hPa_member30", data.dew_point_50hPa_member30));

            if (data.relative_humidity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa", data.relative_humidity_1000hPa));

            if (data.relative_humidity_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member01", data.relative_humidity_1000hPa_member01));

            if (data.relative_humidity_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member02", data.relative_humidity_1000hPa_member02));

            if (data.relative_humidity_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member03", data.relative_humidity_1000hPa_member03));

            if (data.relative_humidity_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member04", data.relative_humidity_1000hPa_member04));

            if (data.relative_humidity_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member05", data.relative_humidity_1000hPa_member05));

            if (data.relative_humidity_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member06", data.relative_humidity_1000hPa_member06));

            if (data.relative_humidity_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member07", data.relative_humidity_1000hPa_member07));

            if (data.relative_humidity_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member08", data.relative_humidity_1000hPa_member08));

            if (data.relative_humidity_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member09", data.relative_humidity_1000hPa_member09));

            if (data.relative_humidity_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member10", data.relative_humidity_1000hPa_member10));

            if (data.relative_humidity_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member11", data.relative_humidity_1000hPa_member11));

            if (data.relative_humidity_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member12", data.relative_humidity_1000hPa_member12));

            if (data.relative_humidity_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member13", data.relative_humidity_1000hPa_member13));

            if (data.relative_humidity_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member14", data.relative_humidity_1000hPa_member14));

            if (data.relative_humidity_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member15", data.relative_humidity_1000hPa_member15));

            if (data.relative_humidity_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member16", data.relative_humidity_1000hPa_member16));

            if (data.relative_humidity_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member17", data.relative_humidity_1000hPa_member17));

            if (data.relative_humidity_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member18", data.relative_humidity_1000hPa_member18));

            if (data.relative_humidity_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member19", data.relative_humidity_1000hPa_member19));

            if (data.relative_humidity_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member20", data.relative_humidity_1000hPa_member20));

            if (data.relative_humidity_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member21", data.relative_humidity_1000hPa_member21));

            if (data.relative_humidity_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member22", data.relative_humidity_1000hPa_member22));

            if (data.relative_humidity_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member23", data.relative_humidity_1000hPa_member23));

            if (data.relative_humidity_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member24", data.relative_humidity_1000hPa_member24));

            if (data.relative_humidity_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member25", data.relative_humidity_1000hPa_member25));

            if (data.relative_humidity_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member26", data.relative_humidity_1000hPa_member26));

            if (data.relative_humidity_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member27", data.relative_humidity_1000hPa_member27));

            if (data.relative_humidity_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member28", data.relative_humidity_1000hPa_member28));

            if (data.relative_humidity_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member29", data.relative_humidity_1000hPa_member29));

            if (data.relative_humidity_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_1000hPa_member30", data.relative_humidity_1000hPa_member30));

            if (data.relative_humidity_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa", data.relative_humidity_925hPa));

            if (data.relative_humidity_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member01", data.relative_humidity_925hPa_member01));

            if (data.relative_humidity_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member02", data.relative_humidity_925hPa_member02));

            if (data.relative_humidity_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member03", data.relative_humidity_925hPa_member03));

            if (data.relative_humidity_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member04", data.relative_humidity_925hPa_member04));

            if (data.relative_humidity_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member05", data.relative_humidity_925hPa_member05));

            if (data.relative_humidity_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member06", data.relative_humidity_925hPa_member06));

            if (data.relative_humidity_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member07", data.relative_humidity_925hPa_member07));

            if (data.relative_humidity_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member08", data.relative_humidity_925hPa_member08));

            if (data.relative_humidity_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member09", data.relative_humidity_925hPa_member09));

            if (data.relative_humidity_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member10", data.relative_humidity_925hPa_member10));

            if (data.relative_humidity_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member11", data.relative_humidity_925hPa_member11));

            if (data.relative_humidity_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member12", data.relative_humidity_925hPa_member12));

            if (data.relative_humidity_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member13", data.relative_humidity_925hPa_member13));

            if (data.relative_humidity_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member14", data.relative_humidity_925hPa_member14));

            if (data.relative_humidity_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member15", data.relative_humidity_925hPa_member15));

            if (data.relative_humidity_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member16", data.relative_humidity_925hPa_member16));

            if (data.relative_humidity_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member17", data.relative_humidity_925hPa_member17));

            if (data.relative_humidity_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member18", data.relative_humidity_925hPa_member18));

            if (data.relative_humidity_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member19", data.relative_humidity_925hPa_member19));

            if (data.relative_humidity_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member20", data.relative_humidity_925hPa_member20));

            if (data.relative_humidity_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member21", data.relative_humidity_925hPa_member21));

            if (data.relative_humidity_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member22", data.relative_humidity_925hPa_member22));

            if (data.relative_humidity_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member23", data.relative_humidity_925hPa_member23));

            if (data.relative_humidity_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member24", data.relative_humidity_925hPa_member24));

            if (data.relative_humidity_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member25", data.relative_humidity_925hPa_member25));

            if (data.relative_humidity_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member26", data.relative_humidity_925hPa_member26));

            if (data.relative_humidity_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member27", data.relative_humidity_925hPa_member27));

            if (data.relative_humidity_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member28", data.relative_humidity_925hPa_member28));

            if (data.relative_humidity_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member29", data.relative_humidity_925hPa_member29));

            if (data.relative_humidity_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_925hPa_member30", data.relative_humidity_925hPa_member30));

            if (data.relative_humidity_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa", data.relative_humidity_850hPa));

            if (data.relative_humidity_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member01", data.relative_humidity_850hPa_member01));

            if (data.relative_humidity_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member02", data.relative_humidity_850hPa_member02));

            if (data.relative_humidity_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member03", data.relative_humidity_850hPa_member03));

            if (data.relative_humidity_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member04", data.relative_humidity_850hPa_member04));

            if (data.relative_humidity_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member05", data.relative_humidity_850hPa_member05));

            if (data.relative_humidity_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member06", data.relative_humidity_850hPa_member06));

            if (data.relative_humidity_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member07", data.relative_humidity_850hPa_member07));

            if (data.relative_humidity_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member08", data.relative_humidity_850hPa_member08));

            if (data.relative_humidity_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member09", data.relative_humidity_850hPa_member09));

            if (data.relative_humidity_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member10", data.relative_humidity_850hPa_member10));

            if (data.relative_humidity_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member11", data.relative_humidity_850hPa_member11));

            if (data.relative_humidity_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member12", data.relative_humidity_850hPa_member12));

            if (data.relative_humidity_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member13", data.relative_humidity_850hPa_member13));

            if (data.relative_humidity_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member14", data.relative_humidity_850hPa_member14));

            if (data.relative_humidity_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member15", data.relative_humidity_850hPa_member15));

            if (data.relative_humidity_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member16", data.relative_humidity_850hPa_member16));

            if (data.relative_humidity_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member17", data.relative_humidity_850hPa_member17));

            if (data.relative_humidity_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member18", data.relative_humidity_850hPa_member18));

            if (data.relative_humidity_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member19", data.relative_humidity_850hPa_member19));

            if (data.relative_humidity_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member20", data.relative_humidity_850hPa_member20));

            if (data.relative_humidity_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member21", data.relative_humidity_850hPa_member21));

            if (data.relative_humidity_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member22", data.relative_humidity_850hPa_member22));

            if (data.relative_humidity_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member23", data.relative_humidity_850hPa_member23));

            if (data.relative_humidity_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member24", data.relative_humidity_850hPa_member24));

            if (data.relative_humidity_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member25", data.relative_humidity_850hPa_member25));

            if (data.relative_humidity_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member26", data.relative_humidity_850hPa_member26));

            if (data.relative_humidity_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member27", data.relative_humidity_850hPa_member27));

            if (data.relative_humidity_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member28", data.relative_humidity_850hPa_member28));

            if (data.relative_humidity_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member29", data.relative_humidity_850hPa_member29));

            if (data.relative_humidity_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_850hPa_member30", data.relative_humidity_850hPa_member30));

            if (data.relative_humidity_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa", data.relative_humidity_700hPa));

            if (data.relative_humidity_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member01", data.relative_humidity_700hPa_member01));

            if (data.relative_humidity_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member02", data.relative_humidity_700hPa_member02));

            if (data.relative_humidity_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member03", data.relative_humidity_700hPa_member03));

            if (data.relative_humidity_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member04", data.relative_humidity_700hPa_member04));

            if (data.relative_humidity_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member05", data.relative_humidity_700hPa_member05));

            if (data.relative_humidity_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member06", data.relative_humidity_700hPa_member06));

            if (data.relative_humidity_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member07", data.relative_humidity_700hPa_member07));

            if (data.relative_humidity_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member08", data.relative_humidity_700hPa_member08));

            if (data.relative_humidity_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member09", data.relative_humidity_700hPa_member09));

            if (data.relative_humidity_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member10", data.relative_humidity_700hPa_member10));

            if (data.relative_humidity_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member11", data.relative_humidity_700hPa_member11));

            if (data.relative_humidity_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member12", data.relative_humidity_700hPa_member12));

            if (data.relative_humidity_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member13", data.relative_humidity_700hPa_member13));

            if (data.relative_humidity_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member14", data.relative_humidity_700hPa_member14));

            if (data.relative_humidity_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member15", data.relative_humidity_700hPa_member15));

            if (data.relative_humidity_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member16", data.relative_humidity_700hPa_member16));

            if (data.relative_humidity_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member17", data.relative_humidity_700hPa_member17));

            if (data.relative_humidity_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member18", data.relative_humidity_700hPa_member18));

            if (data.relative_humidity_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member19", data.relative_humidity_700hPa_member19));

            if (data.relative_humidity_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member20", data.relative_humidity_700hPa_member20));

            if (data.relative_humidity_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member21", data.relative_humidity_700hPa_member21));

            if (data.relative_humidity_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member22", data.relative_humidity_700hPa_member22));

            if (data.relative_humidity_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member23", data.relative_humidity_700hPa_member23));

            if (data.relative_humidity_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member24", data.relative_humidity_700hPa_member24));

            if (data.relative_humidity_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member25", data.relative_humidity_700hPa_member25));

            if (data.relative_humidity_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member26", data.relative_humidity_700hPa_member26));

            if (data.relative_humidity_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member27", data.relative_humidity_700hPa_member27));

            if (data.relative_humidity_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member28", data.relative_humidity_700hPa_member28));

            if (data.relative_humidity_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member29", data.relative_humidity_700hPa_member29));

            if (data.relative_humidity_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_700hPa_member30", data.relative_humidity_700hPa_member30));

            if (data.relative_humidity_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa", data.relative_humidity_600hPa));

            if (data.relative_humidity_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member01", data.relative_humidity_600hPa_member01));

            if (data.relative_humidity_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member02", data.relative_humidity_600hPa_member02));

            if (data.relative_humidity_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member03", data.relative_humidity_600hPa_member03));

            if (data.relative_humidity_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member04", data.relative_humidity_600hPa_member04));

            if (data.relative_humidity_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member05", data.relative_humidity_600hPa_member05));

            if (data.relative_humidity_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member06", data.relative_humidity_600hPa_member06));

            if (data.relative_humidity_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member07", data.relative_humidity_600hPa_member07));

            if (data.relative_humidity_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member08", data.relative_humidity_600hPa_member08));

            if (data.relative_humidity_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member09", data.relative_humidity_600hPa_member09));

            if (data.relative_humidity_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member10", data.relative_humidity_600hPa_member10));

            if (data.relative_humidity_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member11", data.relative_humidity_600hPa_member11));

            if (data.relative_humidity_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member12", data.relative_humidity_600hPa_member12));

            if (data.relative_humidity_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member13", data.relative_humidity_600hPa_member13));

            if (data.relative_humidity_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member14", data.relative_humidity_600hPa_member14));

            if (data.relative_humidity_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member15", data.relative_humidity_600hPa_member15));

            if (data.relative_humidity_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member16", data.relative_humidity_600hPa_member16));

            if (data.relative_humidity_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member17", data.relative_humidity_600hPa_member17));

            if (data.relative_humidity_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member18", data.relative_humidity_600hPa_member18));

            if (data.relative_humidity_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member19", data.relative_humidity_600hPa_member19));

            if (data.relative_humidity_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member20", data.relative_humidity_600hPa_member20));

            if (data.relative_humidity_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member21", data.relative_humidity_600hPa_member21));

            if (data.relative_humidity_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member22", data.relative_humidity_600hPa_member22));

            if (data.relative_humidity_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member23", data.relative_humidity_600hPa_member23));

            if (data.relative_humidity_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member24", data.relative_humidity_600hPa_member24));

            if (data.relative_humidity_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member25", data.relative_humidity_600hPa_member25));

            if (data.relative_humidity_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member26", data.relative_humidity_600hPa_member26));

            if (data.relative_humidity_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member27", data.relative_humidity_600hPa_member27));

            if (data.relative_humidity_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member28", data.relative_humidity_600hPa_member28));

            if (data.relative_humidity_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member29", data.relative_humidity_600hPa_member29));

            if (data.relative_humidity_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_600hPa_member30", data.relative_humidity_600hPa_member30));

            if (data.relative_humidity_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa", data.relative_humidity_500hPa));

            if (data.relative_humidity_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member01", data.relative_humidity_500hPa_member01));

            if (data.relative_humidity_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member02", data.relative_humidity_500hPa_member02));

            if (data.relative_humidity_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member03", data.relative_humidity_500hPa_member03));

            if (data.relative_humidity_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member04", data.relative_humidity_500hPa_member04));

            if (data.relative_humidity_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member05", data.relative_humidity_500hPa_member05));

            if (data.relative_humidity_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member06", data.relative_humidity_500hPa_member06));

            if (data.relative_humidity_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member07", data.relative_humidity_500hPa_member07));

            if (data.relative_humidity_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member08", data.relative_humidity_500hPa_member08));

            if (data.relative_humidity_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member09", data.relative_humidity_500hPa_member09));

            if (data.relative_humidity_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member10", data.relative_humidity_500hPa_member10));

            if (data.relative_humidity_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member11", data.relative_humidity_500hPa_member11));

            if (data.relative_humidity_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member12", data.relative_humidity_500hPa_member12));

            if (data.relative_humidity_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member13", data.relative_humidity_500hPa_member13));

            if (data.relative_humidity_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member14", data.relative_humidity_500hPa_member14));

            if (data.relative_humidity_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member15", data.relative_humidity_500hPa_member15));

            if (data.relative_humidity_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member16", data.relative_humidity_500hPa_member16));

            if (data.relative_humidity_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member17", data.relative_humidity_500hPa_member17));

            if (data.relative_humidity_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member18", data.relative_humidity_500hPa_member18));

            if (data.relative_humidity_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member19", data.relative_humidity_500hPa_member19));

            if (data.relative_humidity_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member20", data.relative_humidity_500hPa_member20));

            if (data.relative_humidity_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member21", data.relative_humidity_500hPa_member21));

            if (data.relative_humidity_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member22", data.relative_humidity_500hPa_member22));

            if (data.relative_humidity_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member23", data.relative_humidity_500hPa_member23));

            if (data.relative_humidity_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member24", data.relative_humidity_500hPa_member24));

            if (data.relative_humidity_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member25", data.relative_humidity_500hPa_member25));

            if (data.relative_humidity_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member26", data.relative_humidity_500hPa_member26));

            if (data.relative_humidity_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member27", data.relative_humidity_500hPa_member27));

            if (data.relative_humidity_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member28", data.relative_humidity_500hPa_member28));

            if (data.relative_humidity_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member29", data.relative_humidity_500hPa_member29));

            if (data.relative_humidity_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_500hPa_member30", data.relative_humidity_500hPa_member30));

            if (data.relative_humidity_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa", data.relative_humidity_400hPa));

            if (data.relative_humidity_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member01", data.relative_humidity_400hPa_member01));

            if (data.relative_humidity_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member02", data.relative_humidity_400hPa_member02));

            if (data.relative_humidity_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member03", data.relative_humidity_400hPa_member03));

            if (data.relative_humidity_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member04", data.relative_humidity_400hPa_member04));

            if (data.relative_humidity_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member05", data.relative_humidity_400hPa_member05));

            if (data.relative_humidity_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member06", data.relative_humidity_400hPa_member06));

            if (data.relative_humidity_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member07", data.relative_humidity_400hPa_member07));

            if (data.relative_humidity_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member08", data.relative_humidity_400hPa_member08));

            if (data.relative_humidity_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member09", data.relative_humidity_400hPa_member09));

            if (data.relative_humidity_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member10", data.relative_humidity_400hPa_member10));

            if (data.relative_humidity_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member11", data.relative_humidity_400hPa_member11));

            if (data.relative_humidity_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member12", data.relative_humidity_400hPa_member12));

            if (data.relative_humidity_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member13", data.relative_humidity_400hPa_member13));

            if (data.relative_humidity_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member14", data.relative_humidity_400hPa_member14));

            if (data.relative_humidity_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member15", data.relative_humidity_400hPa_member15));

            if (data.relative_humidity_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member16", data.relative_humidity_400hPa_member16));

            if (data.relative_humidity_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member17", data.relative_humidity_400hPa_member17));

            if (data.relative_humidity_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member18", data.relative_humidity_400hPa_member18));

            if (data.relative_humidity_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member19", data.relative_humidity_400hPa_member19));

            if (data.relative_humidity_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member20", data.relative_humidity_400hPa_member20));

            if (data.relative_humidity_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member21", data.relative_humidity_400hPa_member21));

            if (data.relative_humidity_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member22", data.relative_humidity_400hPa_member22));

            if (data.relative_humidity_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member23", data.relative_humidity_400hPa_member23));

            if (data.relative_humidity_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member24", data.relative_humidity_400hPa_member24));

            if (data.relative_humidity_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member25", data.relative_humidity_400hPa_member25));

            if (data.relative_humidity_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member26", data.relative_humidity_400hPa_member26));

            if (data.relative_humidity_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member27", data.relative_humidity_400hPa_member27));

            if (data.relative_humidity_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member28", data.relative_humidity_400hPa_member28));

            if (data.relative_humidity_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member29", data.relative_humidity_400hPa_member29));

            if (data.relative_humidity_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_400hPa_member30", data.relative_humidity_400hPa_member30));

            if (data.relative_humidity_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa", data.relative_humidity_300hPa));

            if (data.relative_humidity_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member01", data.relative_humidity_300hPa_member01));

            if (data.relative_humidity_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member02", data.relative_humidity_300hPa_member02));

            if (data.relative_humidity_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member03", data.relative_humidity_300hPa_member03));

            if (data.relative_humidity_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member04", data.relative_humidity_300hPa_member04));

            if (data.relative_humidity_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member05", data.relative_humidity_300hPa_member05));

            if (data.relative_humidity_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member06", data.relative_humidity_300hPa_member06));

            if (data.relative_humidity_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member07", data.relative_humidity_300hPa_member07));

            if (data.relative_humidity_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member08", data.relative_humidity_300hPa_member08));

            if (data.relative_humidity_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member09", data.relative_humidity_300hPa_member09));

            if (data.relative_humidity_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member10", data.relative_humidity_300hPa_member10));

            if (data.relative_humidity_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member11", data.relative_humidity_300hPa_member11));

            if (data.relative_humidity_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member12", data.relative_humidity_300hPa_member12));

            if (data.relative_humidity_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member13", data.relative_humidity_300hPa_member13));

            if (data.relative_humidity_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member14", data.relative_humidity_300hPa_member14));

            if (data.relative_humidity_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member15", data.relative_humidity_300hPa_member15));

            if (data.relative_humidity_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member16", data.relative_humidity_300hPa_member16));

            if (data.relative_humidity_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member17", data.relative_humidity_300hPa_member17));

            if (data.relative_humidity_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member18", data.relative_humidity_300hPa_member18));

            if (data.relative_humidity_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member19", data.relative_humidity_300hPa_member19));

            if (data.relative_humidity_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member20", data.relative_humidity_300hPa_member20));

            if (data.relative_humidity_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member21", data.relative_humidity_300hPa_member21));

            if (data.relative_humidity_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member22", data.relative_humidity_300hPa_member22));

            if (data.relative_humidity_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member23", data.relative_humidity_300hPa_member23));

            if (data.relative_humidity_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member24", data.relative_humidity_300hPa_member24));

            if (data.relative_humidity_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member25", data.relative_humidity_300hPa_member25));

            if (data.relative_humidity_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member26", data.relative_humidity_300hPa_member26));

            if (data.relative_humidity_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member27", data.relative_humidity_300hPa_member27));

            if (data.relative_humidity_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member28", data.relative_humidity_300hPa_member28));

            if (data.relative_humidity_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member29", data.relative_humidity_300hPa_member29));

            if (data.relative_humidity_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_300hPa_member30", data.relative_humidity_300hPa_member30));

            if (data.relative_humidity_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa", data.relative_humidity_250hPa));

            if (data.relative_humidity_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member01", data.relative_humidity_250hPa_member01));

            if (data.relative_humidity_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member02", data.relative_humidity_250hPa_member02));

            if (data.relative_humidity_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member03", data.relative_humidity_250hPa_member03));

            if (data.relative_humidity_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member04", data.relative_humidity_250hPa_member04));

            if (data.relative_humidity_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member05", data.relative_humidity_250hPa_member05));

            if (data.relative_humidity_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member06", data.relative_humidity_250hPa_member06));

            if (data.relative_humidity_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member07", data.relative_humidity_250hPa_member07));

            if (data.relative_humidity_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member08", data.relative_humidity_250hPa_member08));

            if (data.relative_humidity_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member09", data.relative_humidity_250hPa_member09));

            if (data.relative_humidity_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member10", data.relative_humidity_250hPa_member10));

            if (data.relative_humidity_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member11", data.relative_humidity_250hPa_member11));

            if (data.relative_humidity_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member12", data.relative_humidity_250hPa_member12));

            if (data.relative_humidity_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member13", data.relative_humidity_250hPa_member13));

            if (data.relative_humidity_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member14", data.relative_humidity_250hPa_member14));

            if (data.relative_humidity_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member15", data.relative_humidity_250hPa_member15));

            if (data.relative_humidity_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member16", data.relative_humidity_250hPa_member16));

            if (data.relative_humidity_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member17", data.relative_humidity_250hPa_member17));

            if (data.relative_humidity_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member18", data.relative_humidity_250hPa_member18));

            if (data.relative_humidity_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member19", data.relative_humidity_250hPa_member19));

            if (data.relative_humidity_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member20", data.relative_humidity_250hPa_member20));

            if (data.relative_humidity_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member21", data.relative_humidity_250hPa_member21));

            if (data.relative_humidity_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member22", data.relative_humidity_250hPa_member22));

            if (data.relative_humidity_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member23", data.relative_humidity_250hPa_member23));

            if (data.relative_humidity_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member24", data.relative_humidity_250hPa_member24));

            if (data.relative_humidity_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member25", data.relative_humidity_250hPa_member25));

            if (data.relative_humidity_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member26", data.relative_humidity_250hPa_member26));

            if (data.relative_humidity_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member27", data.relative_humidity_250hPa_member27));

            if (data.relative_humidity_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member28", data.relative_humidity_250hPa_member28));

            if (data.relative_humidity_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member29", data.relative_humidity_250hPa_member29));

            if (data.relative_humidity_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_250hPa_member30", data.relative_humidity_250hPa_member30));

            if (data.relative_humidity_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa", data.relative_humidity_200hPa));

            if (data.relative_humidity_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member01", data.relative_humidity_200hPa_member01));

            if (data.relative_humidity_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member02", data.relative_humidity_200hPa_member02));

            if (data.relative_humidity_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member03", data.relative_humidity_200hPa_member03));

            if (data.relative_humidity_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member04", data.relative_humidity_200hPa_member04));

            if (data.relative_humidity_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member05", data.relative_humidity_200hPa_member05));

            if (data.relative_humidity_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member06", data.relative_humidity_200hPa_member06));

            if (data.relative_humidity_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member07", data.relative_humidity_200hPa_member07));

            if (data.relative_humidity_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member08", data.relative_humidity_200hPa_member08));

            if (data.relative_humidity_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member09", data.relative_humidity_200hPa_member09));

            if (data.relative_humidity_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member10", data.relative_humidity_200hPa_member10));

            if (data.relative_humidity_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member11", data.relative_humidity_200hPa_member11));

            if (data.relative_humidity_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member12", data.relative_humidity_200hPa_member12));

            if (data.relative_humidity_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member13", data.relative_humidity_200hPa_member13));

            if (data.relative_humidity_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member14", data.relative_humidity_200hPa_member14));

            if (data.relative_humidity_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member15", data.relative_humidity_200hPa_member15));

            if (data.relative_humidity_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member16", data.relative_humidity_200hPa_member16));

            if (data.relative_humidity_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member17", data.relative_humidity_200hPa_member17));

            if (data.relative_humidity_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member18", data.relative_humidity_200hPa_member18));

            if (data.relative_humidity_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member19", data.relative_humidity_200hPa_member19));

            if (data.relative_humidity_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member20", data.relative_humidity_200hPa_member20));

            if (data.relative_humidity_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member21", data.relative_humidity_200hPa_member21));

            if (data.relative_humidity_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member22", data.relative_humidity_200hPa_member22));

            if (data.relative_humidity_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member23", data.relative_humidity_200hPa_member23));

            if (data.relative_humidity_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member24", data.relative_humidity_200hPa_member24));

            if (data.relative_humidity_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member25", data.relative_humidity_200hPa_member25));

            if (data.relative_humidity_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member26", data.relative_humidity_200hPa_member26));

            if (data.relative_humidity_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member27", data.relative_humidity_200hPa_member27));

            if (data.relative_humidity_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member28", data.relative_humidity_200hPa_member28));

            if (data.relative_humidity_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member29", data.relative_humidity_200hPa_member29));

            if (data.relative_humidity_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_200hPa_member30", data.relative_humidity_200hPa_member30));

            if (data.relative_humidity_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa", data.relative_humidity_150hPa));

            if (data.relative_humidity_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member01", data.relative_humidity_150hPa_member01));

            if (data.relative_humidity_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member02", data.relative_humidity_150hPa_member02));

            if (data.relative_humidity_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member03", data.relative_humidity_150hPa_member03));

            if (data.relative_humidity_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member04", data.relative_humidity_150hPa_member04));

            if (data.relative_humidity_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member05", data.relative_humidity_150hPa_member05));

            if (data.relative_humidity_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member06", data.relative_humidity_150hPa_member06));

            if (data.relative_humidity_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member07", data.relative_humidity_150hPa_member07));

            if (data.relative_humidity_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member08", data.relative_humidity_150hPa_member08));

            if (data.relative_humidity_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member09", data.relative_humidity_150hPa_member09));

            if (data.relative_humidity_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member10", data.relative_humidity_150hPa_member10));

            if (data.relative_humidity_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member11", data.relative_humidity_150hPa_member11));

            if (data.relative_humidity_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member12", data.relative_humidity_150hPa_member12));

            if (data.relative_humidity_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member13", data.relative_humidity_150hPa_member13));

            if (data.relative_humidity_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member14", data.relative_humidity_150hPa_member14));

            if (data.relative_humidity_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member15", data.relative_humidity_150hPa_member15));

            if (data.relative_humidity_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member16", data.relative_humidity_150hPa_member16));

            if (data.relative_humidity_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member17", data.relative_humidity_150hPa_member17));

            if (data.relative_humidity_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member18", data.relative_humidity_150hPa_member18));

            if (data.relative_humidity_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member19", data.relative_humidity_150hPa_member19));

            if (data.relative_humidity_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member20", data.relative_humidity_150hPa_member20));

            if (data.relative_humidity_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member21", data.relative_humidity_150hPa_member21));

            if (data.relative_humidity_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member22", data.relative_humidity_150hPa_member22));

            if (data.relative_humidity_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member23", data.relative_humidity_150hPa_member23));

            if (data.relative_humidity_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member24", data.relative_humidity_150hPa_member24));

            if (data.relative_humidity_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member25", data.relative_humidity_150hPa_member25));

            if (data.relative_humidity_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member26", data.relative_humidity_150hPa_member26));

            if (data.relative_humidity_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member27", data.relative_humidity_150hPa_member27));

            if (data.relative_humidity_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member28", data.relative_humidity_150hPa_member28));

            if (data.relative_humidity_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member29", data.relative_humidity_150hPa_member29));

            if (data.relative_humidity_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_150hPa_member30", data.relative_humidity_150hPa_member30));

            if (data.relative_humidity_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa", data.relative_humidity_100hPa));

            if (data.relative_humidity_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member01", data.relative_humidity_100hPa_member01));

            if (data.relative_humidity_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member02", data.relative_humidity_100hPa_member02));

            if (data.relative_humidity_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member03", data.relative_humidity_100hPa_member03));

            if (data.relative_humidity_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member04", data.relative_humidity_100hPa_member04));

            if (data.relative_humidity_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member05", data.relative_humidity_100hPa_member05));

            if (data.relative_humidity_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member06", data.relative_humidity_100hPa_member06));

            if (data.relative_humidity_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member07", data.relative_humidity_100hPa_member07));

            if (data.relative_humidity_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member08", data.relative_humidity_100hPa_member08));

            if (data.relative_humidity_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member09", data.relative_humidity_100hPa_member09));

            if (data.relative_humidity_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member10", data.relative_humidity_100hPa_member10));

            if (data.relative_humidity_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member11", data.relative_humidity_100hPa_member11));

            if (data.relative_humidity_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member12", data.relative_humidity_100hPa_member12));

            if (data.relative_humidity_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member13", data.relative_humidity_100hPa_member13));

            if (data.relative_humidity_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member14", data.relative_humidity_100hPa_member14));

            if (data.relative_humidity_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member15", data.relative_humidity_100hPa_member15));

            if (data.relative_humidity_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member16", data.relative_humidity_100hPa_member16));

            if (data.relative_humidity_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member17", data.relative_humidity_100hPa_member17));

            if (data.relative_humidity_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member18", data.relative_humidity_100hPa_member18));

            if (data.relative_humidity_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member19", data.relative_humidity_100hPa_member19));

            if (data.relative_humidity_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member20", data.relative_humidity_100hPa_member20));

            if (data.relative_humidity_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member21", data.relative_humidity_100hPa_member21));

            if (data.relative_humidity_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member22", data.relative_humidity_100hPa_member22));

            if (data.relative_humidity_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member23", data.relative_humidity_100hPa_member23));

            if (data.relative_humidity_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member24", data.relative_humidity_100hPa_member24));

            if (data.relative_humidity_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member25", data.relative_humidity_100hPa_member25));

            if (data.relative_humidity_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member26", data.relative_humidity_100hPa_member26));

            if (data.relative_humidity_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member27", data.relative_humidity_100hPa_member27));

            if (data.relative_humidity_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member28", data.relative_humidity_100hPa_member28));

            if (data.relative_humidity_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member29", data.relative_humidity_100hPa_member29));

            if (data.relative_humidity_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_100hPa_member30", data.relative_humidity_100hPa_member30));

            if (data.relative_humidity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa", data.relative_humidity_50hPa));

            if (data.relative_humidity_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member01", data.relative_humidity_50hPa_member01));

            if (data.relative_humidity_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member02", data.relative_humidity_50hPa_member02));

            if (data.relative_humidity_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member03", data.relative_humidity_50hPa_member03));

            if (data.relative_humidity_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member04", data.relative_humidity_50hPa_member04));

            if (data.relative_humidity_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member05", data.relative_humidity_50hPa_member05));

            if (data.relative_humidity_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member06", data.relative_humidity_50hPa_member06));

            if (data.relative_humidity_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member07", data.relative_humidity_50hPa_member07));

            if (data.relative_humidity_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member08", data.relative_humidity_50hPa_member08));

            if (data.relative_humidity_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member09", data.relative_humidity_50hPa_member09));

            if (data.relative_humidity_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member10", data.relative_humidity_50hPa_member10));

            if (data.relative_humidity_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member11", data.relative_humidity_50hPa_member11));

            if (data.relative_humidity_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member12", data.relative_humidity_50hPa_member12));

            if (data.relative_humidity_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member13", data.relative_humidity_50hPa_member13));

            if (data.relative_humidity_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member14", data.relative_humidity_50hPa_member14));

            if (data.relative_humidity_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member15", data.relative_humidity_50hPa_member15));

            if (data.relative_humidity_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member16", data.relative_humidity_50hPa_member16));

            if (data.relative_humidity_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member17", data.relative_humidity_50hPa_member17));

            if (data.relative_humidity_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member18", data.relative_humidity_50hPa_member18));

            if (data.relative_humidity_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member19", data.relative_humidity_50hPa_member19));

            if (data.relative_humidity_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member20", data.relative_humidity_50hPa_member20));

            if (data.relative_humidity_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member21", data.relative_humidity_50hPa_member21));

            if (data.relative_humidity_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member22", data.relative_humidity_50hPa_member22));

            if (data.relative_humidity_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member23", data.relative_humidity_50hPa_member23));

            if (data.relative_humidity_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member24", data.relative_humidity_50hPa_member24));

            if (data.relative_humidity_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member25", data.relative_humidity_50hPa_member25));

            if (data.relative_humidity_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member26", data.relative_humidity_50hPa_member26));

            if (data.relative_humidity_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member27", data.relative_humidity_50hPa_member27));

            if (data.relative_humidity_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member28", data.relative_humidity_50hPa_member28));

            if (data.relative_humidity_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member29", data.relative_humidity_50hPa_member29));

            if (data.relative_humidity_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_50hPa_member30", data.relative_humidity_50hPa_member30));

            if (data.wind_speed_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa", data.wind_speed_1000hPa));

            if (data.wind_speed_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member01", data.wind_speed_1000hPa_member01));

            if (data.wind_speed_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member02", data.wind_speed_1000hPa_member02));

            if (data.wind_speed_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member03", data.wind_speed_1000hPa_member03));

            if (data.wind_speed_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member04", data.wind_speed_1000hPa_member04));

            if (data.wind_speed_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member05", data.wind_speed_1000hPa_member05));

            if (data.wind_speed_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member06", data.wind_speed_1000hPa_member06));

            if (data.wind_speed_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member07", data.wind_speed_1000hPa_member07));

            if (data.wind_speed_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member08", data.wind_speed_1000hPa_member08));

            if (data.wind_speed_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member09", data.wind_speed_1000hPa_member09));

            if (data.wind_speed_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member10", data.wind_speed_1000hPa_member10));

            if (data.wind_speed_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member11", data.wind_speed_1000hPa_member11));

            if (data.wind_speed_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member12", data.wind_speed_1000hPa_member12));

            if (data.wind_speed_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member13", data.wind_speed_1000hPa_member13));

            if (data.wind_speed_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member14", data.wind_speed_1000hPa_member14));

            if (data.wind_speed_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member15", data.wind_speed_1000hPa_member15));

            if (data.wind_speed_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member16", data.wind_speed_1000hPa_member16));

            if (data.wind_speed_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member17", data.wind_speed_1000hPa_member17));

            if (data.wind_speed_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member18", data.wind_speed_1000hPa_member18));

            if (data.wind_speed_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member19", data.wind_speed_1000hPa_member19));

            if (data.wind_speed_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member20", data.wind_speed_1000hPa_member20));

            if (data.wind_speed_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member21", data.wind_speed_1000hPa_member21));

            if (data.wind_speed_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member22", data.wind_speed_1000hPa_member22));

            if (data.wind_speed_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member23", data.wind_speed_1000hPa_member23));

            if (data.wind_speed_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member24", data.wind_speed_1000hPa_member24));

            if (data.wind_speed_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member25", data.wind_speed_1000hPa_member25));

            if (data.wind_speed_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member26", data.wind_speed_1000hPa_member26));

            if (data.wind_speed_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member27", data.wind_speed_1000hPa_member27));

            if (data.wind_speed_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member28", data.wind_speed_1000hPa_member28));

            if (data.wind_speed_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member29", data.wind_speed_1000hPa_member29));

            if (data.wind_speed_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_1000hPa_member30", data.wind_speed_1000hPa_member30));

            if (data.wind_speed_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa", data.wind_speed_925hPa));

            if (data.wind_speed_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member01", data.wind_speed_925hPa_member01));

            if (data.wind_speed_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member02", data.wind_speed_925hPa_member02));

            if (data.wind_speed_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member03", data.wind_speed_925hPa_member03));

            if (data.wind_speed_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member04", data.wind_speed_925hPa_member04));

            if (data.wind_speed_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member05", data.wind_speed_925hPa_member05));

            if (data.wind_speed_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member06", data.wind_speed_925hPa_member06));

            if (data.wind_speed_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member07", data.wind_speed_925hPa_member07));

            if (data.wind_speed_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member08", data.wind_speed_925hPa_member08));

            if (data.wind_speed_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member09", data.wind_speed_925hPa_member09));

            if (data.wind_speed_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member10", data.wind_speed_925hPa_member10));

            if (data.wind_speed_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member11", data.wind_speed_925hPa_member11));

            if (data.wind_speed_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member12", data.wind_speed_925hPa_member12));

            if (data.wind_speed_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member13", data.wind_speed_925hPa_member13));

            if (data.wind_speed_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member14", data.wind_speed_925hPa_member14));

            if (data.wind_speed_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member15", data.wind_speed_925hPa_member15));

            if (data.wind_speed_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member16", data.wind_speed_925hPa_member16));

            if (data.wind_speed_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member17", data.wind_speed_925hPa_member17));

            if (data.wind_speed_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member18", data.wind_speed_925hPa_member18));

            if (data.wind_speed_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member19", data.wind_speed_925hPa_member19));

            if (data.wind_speed_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member20", data.wind_speed_925hPa_member20));

            if (data.wind_speed_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member21", data.wind_speed_925hPa_member21));

            if (data.wind_speed_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member22", data.wind_speed_925hPa_member22));

            if (data.wind_speed_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member23", data.wind_speed_925hPa_member23));

            if (data.wind_speed_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member24", data.wind_speed_925hPa_member24));

            if (data.wind_speed_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member25", data.wind_speed_925hPa_member25));

            if (data.wind_speed_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member26", data.wind_speed_925hPa_member26));

            if (data.wind_speed_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member27", data.wind_speed_925hPa_member27));

            if (data.wind_speed_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member28", data.wind_speed_925hPa_member28));

            if (data.wind_speed_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member29", data.wind_speed_925hPa_member29));

            if (data.wind_speed_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_925hPa_member30", data.wind_speed_925hPa_member30));

            if (data.wind_speed_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa", data.wind_speed_850hPa));

            if (data.wind_speed_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member01", data.wind_speed_850hPa_member01));

            if (data.wind_speed_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member02", data.wind_speed_850hPa_member02));

            if (data.wind_speed_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member03", data.wind_speed_850hPa_member03));

            if (data.wind_speed_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member04", data.wind_speed_850hPa_member04));

            if (data.wind_speed_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member05", data.wind_speed_850hPa_member05));

            if (data.wind_speed_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member06", data.wind_speed_850hPa_member06));

            if (data.wind_speed_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member07", data.wind_speed_850hPa_member07));

            if (data.wind_speed_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member08", data.wind_speed_850hPa_member08));

            if (data.wind_speed_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member09", data.wind_speed_850hPa_member09));

            if (data.wind_speed_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member10", data.wind_speed_850hPa_member10));

            if (data.wind_speed_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member11", data.wind_speed_850hPa_member11));

            if (data.wind_speed_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member12", data.wind_speed_850hPa_member12));

            if (data.wind_speed_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member13", data.wind_speed_850hPa_member13));

            if (data.wind_speed_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member14", data.wind_speed_850hPa_member14));

            if (data.wind_speed_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member15", data.wind_speed_850hPa_member15));

            if (data.wind_speed_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member16", data.wind_speed_850hPa_member16));

            if (data.wind_speed_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member17", data.wind_speed_850hPa_member17));

            if (data.wind_speed_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member18", data.wind_speed_850hPa_member18));

            if (data.wind_speed_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member19", data.wind_speed_850hPa_member19));

            if (data.wind_speed_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member20", data.wind_speed_850hPa_member20));

            if (data.wind_speed_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member21", data.wind_speed_850hPa_member21));

            if (data.wind_speed_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member22", data.wind_speed_850hPa_member22));

            if (data.wind_speed_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member23", data.wind_speed_850hPa_member23));

            if (data.wind_speed_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member24", data.wind_speed_850hPa_member24));

            if (data.wind_speed_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member25", data.wind_speed_850hPa_member25));

            if (data.wind_speed_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member26", data.wind_speed_850hPa_member26));

            if (data.wind_speed_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member27", data.wind_speed_850hPa_member27));

            if (data.wind_speed_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member28", data.wind_speed_850hPa_member28));

            if (data.wind_speed_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member29", data.wind_speed_850hPa_member29));

            if (data.wind_speed_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_850hPa_member30", data.wind_speed_850hPa_member30));

            if (data.wind_speed_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa", data.wind_speed_700hPa));

            if (data.wind_speed_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member01", data.wind_speed_700hPa_member01));

            if (data.wind_speed_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member02", data.wind_speed_700hPa_member02));

            if (data.wind_speed_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member03", data.wind_speed_700hPa_member03));

            if (data.wind_speed_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member04", data.wind_speed_700hPa_member04));

            if (data.wind_speed_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member05", data.wind_speed_700hPa_member05));

            if (data.wind_speed_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member06", data.wind_speed_700hPa_member06));

            if (data.wind_speed_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member07", data.wind_speed_700hPa_member07));

            if (data.wind_speed_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member08", data.wind_speed_700hPa_member08));

            if (data.wind_speed_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member09", data.wind_speed_700hPa_member09));

            if (data.wind_speed_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member10", data.wind_speed_700hPa_member10));

            if (data.wind_speed_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member11", data.wind_speed_700hPa_member11));

            if (data.wind_speed_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member12", data.wind_speed_700hPa_member12));

            if (data.wind_speed_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member13", data.wind_speed_700hPa_member13));

            if (data.wind_speed_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member14", data.wind_speed_700hPa_member14));

            if (data.wind_speed_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member15", data.wind_speed_700hPa_member15));

            if (data.wind_speed_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member16", data.wind_speed_700hPa_member16));

            if (data.wind_speed_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member17", data.wind_speed_700hPa_member17));

            if (data.wind_speed_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member18", data.wind_speed_700hPa_member18));

            if (data.wind_speed_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member19", data.wind_speed_700hPa_member19));

            if (data.wind_speed_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member20", data.wind_speed_700hPa_member20));

            if (data.wind_speed_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member21", data.wind_speed_700hPa_member21));

            if (data.wind_speed_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member22", data.wind_speed_700hPa_member22));

            if (data.wind_speed_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member23", data.wind_speed_700hPa_member23));

            if (data.wind_speed_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member24", data.wind_speed_700hPa_member24));

            if (data.wind_speed_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member25", data.wind_speed_700hPa_member25));

            if (data.wind_speed_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member26", data.wind_speed_700hPa_member26));

            if (data.wind_speed_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member27", data.wind_speed_700hPa_member27));

            if (data.wind_speed_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member28", data.wind_speed_700hPa_member28));

            if (data.wind_speed_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member29", data.wind_speed_700hPa_member29));

            if (data.wind_speed_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_700hPa_member30", data.wind_speed_700hPa_member30));

            if (data.wind_speed_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa", data.wind_speed_600hPa));

            if (data.wind_speed_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member01", data.wind_speed_600hPa_member01));

            if (data.wind_speed_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member02", data.wind_speed_600hPa_member02));

            if (data.wind_speed_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member03", data.wind_speed_600hPa_member03));

            if (data.wind_speed_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member04", data.wind_speed_600hPa_member04));

            if (data.wind_speed_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member05", data.wind_speed_600hPa_member05));

            if (data.wind_speed_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member06", data.wind_speed_600hPa_member06));

            if (data.wind_speed_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member07", data.wind_speed_600hPa_member07));

            if (data.wind_speed_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member08", data.wind_speed_600hPa_member08));

            if (data.wind_speed_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member09", data.wind_speed_600hPa_member09));

            if (data.wind_speed_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member10", data.wind_speed_600hPa_member10));

            if (data.wind_speed_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member11", data.wind_speed_600hPa_member11));

            if (data.wind_speed_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member12", data.wind_speed_600hPa_member12));

            if (data.wind_speed_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member13", data.wind_speed_600hPa_member13));

            if (data.wind_speed_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member14", data.wind_speed_600hPa_member14));

            if (data.wind_speed_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member15", data.wind_speed_600hPa_member15));

            if (data.wind_speed_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member16", data.wind_speed_600hPa_member16));

            if (data.wind_speed_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member17", data.wind_speed_600hPa_member17));

            if (data.wind_speed_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member18", data.wind_speed_600hPa_member18));

            if (data.wind_speed_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member19", data.wind_speed_600hPa_member19));

            if (data.wind_speed_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member20", data.wind_speed_600hPa_member20));

            if (data.wind_speed_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member21", data.wind_speed_600hPa_member21));

            if (data.wind_speed_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member22", data.wind_speed_600hPa_member22));

            if (data.wind_speed_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member23", data.wind_speed_600hPa_member23));

            if (data.wind_speed_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member24", data.wind_speed_600hPa_member24));

            if (data.wind_speed_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member25", data.wind_speed_600hPa_member25));

            if (data.wind_speed_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member26", data.wind_speed_600hPa_member26));

            if (data.wind_speed_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member27", data.wind_speed_600hPa_member27));

            if (data.wind_speed_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member28", data.wind_speed_600hPa_member28));

            if (data.wind_speed_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member29", data.wind_speed_600hPa_member29));

            if (data.wind_speed_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_600hPa_member30", data.wind_speed_600hPa_member30));

            if (data.wind_speed_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa", data.wind_speed_500hPa));

            if (data.wind_speed_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member01", data.wind_speed_500hPa_member01));

            if (data.wind_speed_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member02", data.wind_speed_500hPa_member02));

            if (data.wind_speed_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member03", data.wind_speed_500hPa_member03));

            if (data.wind_speed_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member04", data.wind_speed_500hPa_member04));

            if (data.wind_speed_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member05", data.wind_speed_500hPa_member05));

            if (data.wind_speed_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member06", data.wind_speed_500hPa_member06));

            if (data.wind_speed_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member07", data.wind_speed_500hPa_member07));

            if (data.wind_speed_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member08", data.wind_speed_500hPa_member08));

            if (data.wind_speed_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member09", data.wind_speed_500hPa_member09));

            if (data.wind_speed_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member10", data.wind_speed_500hPa_member10));

            if (data.wind_speed_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member11", data.wind_speed_500hPa_member11));

            if (data.wind_speed_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member12", data.wind_speed_500hPa_member12));

            if (data.wind_speed_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member13", data.wind_speed_500hPa_member13));

            if (data.wind_speed_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member14", data.wind_speed_500hPa_member14));

            if (data.wind_speed_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member15", data.wind_speed_500hPa_member15));

            if (data.wind_speed_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member16", data.wind_speed_500hPa_member16));

            if (data.wind_speed_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member17", data.wind_speed_500hPa_member17));

            if (data.wind_speed_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member18", data.wind_speed_500hPa_member18));

            if (data.wind_speed_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member19", data.wind_speed_500hPa_member19));

            if (data.wind_speed_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member20", data.wind_speed_500hPa_member20));

            if (data.wind_speed_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member21", data.wind_speed_500hPa_member21));

            if (data.wind_speed_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member22", data.wind_speed_500hPa_member22));

            if (data.wind_speed_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member23", data.wind_speed_500hPa_member23));

            if (data.wind_speed_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member24", data.wind_speed_500hPa_member24));

            if (data.wind_speed_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member25", data.wind_speed_500hPa_member25));

            if (data.wind_speed_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member26", data.wind_speed_500hPa_member26));

            if (data.wind_speed_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member27", data.wind_speed_500hPa_member27));

            if (data.wind_speed_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member28", data.wind_speed_500hPa_member28));

            if (data.wind_speed_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member29", data.wind_speed_500hPa_member29));

            if (data.wind_speed_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_500hPa_member30", data.wind_speed_500hPa_member30));

            if (data.wind_speed_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa", data.wind_speed_400hPa));

            if (data.wind_speed_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member01", data.wind_speed_400hPa_member01));

            if (data.wind_speed_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member02", data.wind_speed_400hPa_member02));

            if (data.wind_speed_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member03", data.wind_speed_400hPa_member03));

            if (data.wind_speed_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member04", data.wind_speed_400hPa_member04));

            if (data.wind_speed_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member05", data.wind_speed_400hPa_member05));

            if (data.wind_speed_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member06", data.wind_speed_400hPa_member06));

            if (data.wind_speed_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member07", data.wind_speed_400hPa_member07));

            if (data.wind_speed_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member08", data.wind_speed_400hPa_member08));

            if (data.wind_speed_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member09", data.wind_speed_400hPa_member09));

            if (data.wind_speed_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member10", data.wind_speed_400hPa_member10));

            if (data.wind_speed_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member11", data.wind_speed_400hPa_member11));

            if (data.wind_speed_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member12", data.wind_speed_400hPa_member12));

            if (data.wind_speed_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member13", data.wind_speed_400hPa_member13));

            if (data.wind_speed_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member14", data.wind_speed_400hPa_member14));

            if (data.wind_speed_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member15", data.wind_speed_400hPa_member15));

            if (data.wind_speed_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member16", data.wind_speed_400hPa_member16));

            if (data.wind_speed_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member17", data.wind_speed_400hPa_member17));

            if (data.wind_speed_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member18", data.wind_speed_400hPa_member18));

            if (data.wind_speed_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member19", data.wind_speed_400hPa_member19));

            if (data.wind_speed_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member20", data.wind_speed_400hPa_member20));

            if (data.wind_speed_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member21", data.wind_speed_400hPa_member21));

            if (data.wind_speed_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member22", data.wind_speed_400hPa_member22));

            if (data.wind_speed_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member23", data.wind_speed_400hPa_member23));

            if (data.wind_speed_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member24", data.wind_speed_400hPa_member24));

            if (data.wind_speed_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member25", data.wind_speed_400hPa_member25));

            if (data.wind_speed_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member26", data.wind_speed_400hPa_member26));

            if (data.wind_speed_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member27", data.wind_speed_400hPa_member27));

            if (data.wind_speed_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member28", data.wind_speed_400hPa_member28));

            if (data.wind_speed_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member29", data.wind_speed_400hPa_member29));

            if (data.wind_speed_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_400hPa_member30", data.wind_speed_400hPa_member30));

            if (data.wind_speed_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa", data.wind_speed_300hPa));

            if (data.wind_speed_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member01", data.wind_speed_300hPa_member01));

            if (data.wind_speed_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member02", data.wind_speed_300hPa_member02));

            if (data.wind_speed_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member03", data.wind_speed_300hPa_member03));

            if (data.wind_speed_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member04", data.wind_speed_300hPa_member04));

            if (data.wind_speed_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member05", data.wind_speed_300hPa_member05));

            if (data.wind_speed_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member06", data.wind_speed_300hPa_member06));

            if (data.wind_speed_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member07", data.wind_speed_300hPa_member07));

            if (data.wind_speed_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member08", data.wind_speed_300hPa_member08));

            if (data.wind_speed_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member09", data.wind_speed_300hPa_member09));

            if (data.wind_speed_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member10", data.wind_speed_300hPa_member10));

            if (data.wind_speed_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member11", data.wind_speed_300hPa_member11));

            if (data.wind_speed_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member12", data.wind_speed_300hPa_member12));

            if (data.wind_speed_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member13", data.wind_speed_300hPa_member13));

            if (data.wind_speed_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member14", data.wind_speed_300hPa_member14));

            if (data.wind_speed_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member15", data.wind_speed_300hPa_member15));

            if (data.wind_speed_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member16", data.wind_speed_300hPa_member16));

            if (data.wind_speed_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member17", data.wind_speed_300hPa_member17));

            if (data.wind_speed_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member18", data.wind_speed_300hPa_member18));

            if (data.wind_speed_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member19", data.wind_speed_300hPa_member19));

            if (data.wind_speed_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member20", data.wind_speed_300hPa_member20));

            if (data.wind_speed_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member21", data.wind_speed_300hPa_member21));

            if (data.wind_speed_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member22", data.wind_speed_300hPa_member22));

            if (data.wind_speed_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member23", data.wind_speed_300hPa_member23));

            if (data.wind_speed_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member24", data.wind_speed_300hPa_member24));

            if (data.wind_speed_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member25", data.wind_speed_300hPa_member25));

            if (data.wind_speed_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member26", data.wind_speed_300hPa_member26));

            if (data.wind_speed_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member27", data.wind_speed_300hPa_member27));

            if (data.wind_speed_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member28", data.wind_speed_300hPa_member28));

            if (data.wind_speed_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member29", data.wind_speed_300hPa_member29));

            if (data.wind_speed_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_300hPa_member30", data.wind_speed_300hPa_member30));

            if (data.wind_speed_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa", data.wind_speed_250hPa));

            if (data.wind_speed_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member01", data.wind_speed_250hPa_member01));

            if (data.wind_speed_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member02", data.wind_speed_250hPa_member02));

            if (data.wind_speed_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member03", data.wind_speed_250hPa_member03));

            if (data.wind_speed_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member04", data.wind_speed_250hPa_member04));

            if (data.wind_speed_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member05", data.wind_speed_250hPa_member05));

            if (data.wind_speed_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member06", data.wind_speed_250hPa_member06));

            if (data.wind_speed_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member07", data.wind_speed_250hPa_member07));

            if (data.wind_speed_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member08", data.wind_speed_250hPa_member08));

            if (data.wind_speed_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member09", data.wind_speed_250hPa_member09));

            if (data.wind_speed_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member10", data.wind_speed_250hPa_member10));

            if (data.wind_speed_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member11", data.wind_speed_250hPa_member11));

            if (data.wind_speed_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member12", data.wind_speed_250hPa_member12));

            if (data.wind_speed_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member13", data.wind_speed_250hPa_member13));

            if (data.wind_speed_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member14", data.wind_speed_250hPa_member14));

            if (data.wind_speed_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member15", data.wind_speed_250hPa_member15));

            if (data.wind_speed_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member16", data.wind_speed_250hPa_member16));

            if (data.wind_speed_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member17", data.wind_speed_250hPa_member17));

            if (data.wind_speed_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member18", data.wind_speed_250hPa_member18));

            if (data.wind_speed_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member19", data.wind_speed_250hPa_member19));

            if (data.wind_speed_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member20", data.wind_speed_250hPa_member20));

            if (data.wind_speed_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member21", data.wind_speed_250hPa_member21));

            if (data.wind_speed_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member22", data.wind_speed_250hPa_member22));

            if (data.wind_speed_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member23", data.wind_speed_250hPa_member23));

            if (data.wind_speed_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member24", data.wind_speed_250hPa_member24));

            if (data.wind_speed_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member25", data.wind_speed_250hPa_member25));

            if (data.wind_speed_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member26", data.wind_speed_250hPa_member26));

            if (data.wind_speed_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member27", data.wind_speed_250hPa_member27));

            if (data.wind_speed_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member28", data.wind_speed_250hPa_member28));

            if (data.wind_speed_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member29", data.wind_speed_250hPa_member29));

            if (data.wind_speed_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_250hPa_member30", data.wind_speed_250hPa_member30));

            if (data.wind_speed_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa", data.wind_speed_200hPa));

            if (data.wind_speed_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member01", data.wind_speed_200hPa_member01));

            if (data.wind_speed_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member02", data.wind_speed_200hPa_member02));

            if (data.wind_speed_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member03", data.wind_speed_200hPa_member03));

            if (data.wind_speed_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member04", data.wind_speed_200hPa_member04));

            if (data.wind_speed_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member05", data.wind_speed_200hPa_member05));

            if (data.wind_speed_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member06", data.wind_speed_200hPa_member06));

            if (data.wind_speed_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member07", data.wind_speed_200hPa_member07));

            if (data.wind_speed_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member08", data.wind_speed_200hPa_member08));

            if (data.wind_speed_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member09", data.wind_speed_200hPa_member09));

            if (data.wind_speed_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member10", data.wind_speed_200hPa_member10));

            if (data.wind_speed_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member11", data.wind_speed_200hPa_member11));

            if (data.wind_speed_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member12", data.wind_speed_200hPa_member12));

            if (data.wind_speed_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member13", data.wind_speed_200hPa_member13));

            if (data.wind_speed_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member14", data.wind_speed_200hPa_member14));

            if (data.wind_speed_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member15", data.wind_speed_200hPa_member15));

            if (data.wind_speed_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member16", data.wind_speed_200hPa_member16));

            if (data.wind_speed_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member17", data.wind_speed_200hPa_member17));

            if (data.wind_speed_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member18", data.wind_speed_200hPa_member18));

            if (data.wind_speed_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member19", data.wind_speed_200hPa_member19));

            if (data.wind_speed_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member20", data.wind_speed_200hPa_member20));

            if (data.wind_speed_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member21", data.wind_speed_200hPa_member21));

            if (data.wind_speed_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member22", data.wind_speed_200hPa_member22));

            if (data.wind_speed_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member23", data.wind_speed_200hPa_member23));

            if (data.wind_speed_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member24", data.wind_speed_200hPa_member24));

            if (data.wind_speed_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member25", data.wind_speed_200hPa_member25));

            if (data.wind_speed_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member26", data.wind_speed_200hPa_member26));

            if (data.wind_speed_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member27", data.wind_speed_200hPa_member27));

            if (data.wind_speed_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member28", data.wind_speed_200hPa_member28));

            if (data.wind_speed_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member29", data.wind_speed_200hPa_member29));

            if (data.wind_speed_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_200hPa_member30", data.wind_speed_200hPa_member30));

            if (data.wind_speed_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa", data.wind_speed_150hPa));

            if (data.wind_speed_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member01", data.wind_speed_150hPa_member01));

            if (data.wind_speed_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member02", data.wind_speed_150hPa_member02));

            if (data.wind_speed_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member03", data.wind_speed_150hPa_member03));

            if (data.wind_speed_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member04", data.wind_speed_150hPa_member04));

            if (data.wind_speed_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member05", data.wind_speed_150hPa_member05));

            if (data.wind_speed_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member06", data.wind_speed_150hPa_member06));

            if (data.wind_speed_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member07", data.wind_speed_150hPa_member07));

            if (data.wind_speed_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member08", data.wind_speed_150hPa_member08));

            if (data.wind_speed_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member09", data.wind_speed_150hPa_member09));

            if (data.wind_speed_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member10", data.wind_speed_150hPa_member10));

            if (data.wind_speed_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member11", data.wind_speed_150hPa_member11));

            if (data.wind_speed_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member12", data.wind_speed_150hPa_member12));

            if (data.wind_speed_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member13", data.wind_speed_150hPa_member13));

            if (data.wind_speed_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member14", data.wind_speed_150hPa_member14));

            if (data.wind_speed_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member15", data.wind_speed_150hPa_member15));

            if (data.wind_speed_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member16", data.wind_speed_150hPa_member16));

            if (data.wind_speed_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member17", data.wind_speed_150hPa_member17));

            if (data.wind_speed_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member18", data.wind_speed_150hPa_member18));

            if (data.wind_speed_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member19", data.wind_speed_150hPa_member19));

            if (data.wind_speed_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member20", data.wind_speed_150hPa_member20));

            if (data.wind_speed_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member21", data.wind_speed_150hPa_member21));

            if (data.wind_speed_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member22", data.wind_speed_150hPa_member22));

            if (data.wind_speed_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member23", data.wind_speed_150hPa_member23));

            if (data.wind_speed_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member24", data.wind_speed_150hPa_member24));

            if (data.wind_speed_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member25", data.wind_speed_150hPa_member25));

            if (data.wind_speed_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member26", data.wind_speed_150hPa_member26));

            if (data.wind_speed_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member27", data.wind_speed_150hPa_member27));

            if (data.wind_speed_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member28", data.wind_speed_150hPa_member28));

            if (data.wind_speed_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member29", data.wind_speed_150hPa_member29));

            if (data.wind_speed_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_150hPa_member30", data.wind_speed_150hPa_member30));

            if (data.wind_speed_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa", data.wind_speed_100hPa));

            if (data.wind_speed_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member01", data.wind_speed_100hPa_member01));

            if (data.wind_speed_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member02", data.wind_speed_100hPa_member02));

            if (data.wind_speed_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member03", data.wind_speed_100hPa_member03));

            if (data.wind_speed_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member04", data.wind_speed_100hPa_member04));

            if (data.wind_speed_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member05", data.wind_speed_100hPa_member05));

            if (data.wind_speed_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member06", data.wind_speed_100hPa_member06));

            if (data.wind_speed_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member07", data.wind_speed_100hPa_member07));

            if (data.wind_speed_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member08", data.wind_speed_100hPa_member08));

            if (data.wind_speed_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member09", data.wind_speed_100hPa_member09));

            if (data.wind_speed_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member10", data.wind_speed_100hPa_member10));

            if (data.wind_speed_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member11", data.wind_speed_100hPa_member11));

            if (data.wind_speed_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member12", data.wind_speed_100hPa_member12));

            if (data.wind_speed_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member13", data.wind_speed_100hPa_member13));

            if (data.wind_speed_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member14", data.wind_speed_100hPa_member14));

            if (data.wind_speed_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member15", data.wind_speed_100hPa_member15));

            if (data.wind_speed_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member16", data.wind_speed_100hPa_member16));

            if (data.wind_speed_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member17", data.wind_speed_100hPa_member17));

            if (data.wind_speed_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member18", data.wind_speed_100hPa_member18));

            if (data.wind_speed_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member19", data.wind_speed_100hPa_member19));

            if (data.wind_speed_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member20", data.wind_speed_100hPa_member20));

            if (data.wind_speed_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member21", data.wind_speed_100hPa_member21));

            if (data.wind_speed_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member22", data.wind_speed_100hPa_member22));

            if (data.wind_speed_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member23", data.wind_speed_100hPa_member23));

            if (data.wind_speed_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member24", data.wind_speed_100hPa_member24));

            if (data.wind_speed_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member25", data.wind_speed_100hPa_member25));

            if (data.wind_speed_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member26", data.wind_speed_100hPa_member26));

            if (data.wind_speed_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member27", data.wind_speed_100hPa_member27));

            if (data.wind_speed_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member28", data.wind_speed_100hPa_member28));

            if (data.wind_speed_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member29", data.wind_speed_100hPa_member29));

            if (data.wind_speed_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_100hPa_member30", data.wind_speed_100hPa_member30));

            if (data.wind_speed_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa", data.wind_speed_50hPa));

            if (data.wind_speed_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member01", data.wind_speed_50hPa_member01));

            if (data.wind_speed_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member02", data.wind_speed_50hPa_member02));

            if (data.wind_speed_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member03", data.wind_speed_50hPa_member03));

            if (data.wind_speed_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member04", data.wind_speed_50hPa_member04));

            if (data.wind_speed_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member05", data.wind_speed_50hPa_member05));

            if (data.wind_speed_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member06", data.wind_speed_50hPa_member06));

            if (data.wind_speed_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member07", data.wind_speed_50hPa_member07));

            if (data.wind_speed_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member08", data.wind_speed_50hPa_member08));

            if (data.wind_speed_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member09", data.wind_speed_50hPa_member09));

            if (data.wind_speed_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member10", data.wind_speed_50hPa_member10));

            if (data.wind_speed_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member11", data.wind_speed_50hPa_member11));

            if (data.wind_speed_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member12", data.wind_speed_50hPa_member12));

            if (data.wind_speed_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member13", data.wind_speed_50hPa_member13));

            if (data.wind_speed_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member14", data.wind_speed_50hPa_member14));

            if (data.wind_speed_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member15", data.wind_speed_50hPa_member15));

            if (data.wind_speed_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member16", data.wind_speed_50hPa_member16));

            if (data.wind_speed_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member17", data.wind_speed_50hPa_member17));

            if (data.wind_speed_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member18", data.wind_speed_50hPa_member18));

            if (data.wind_speed_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member19", data.wind_speed_50hPa_member19));

            if (data.wind_speed_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member20", data.wind_speed_50hPa_member20));

            if (data.wind_speed_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member21", data.wind_speed_50hPa_member21));

            if (data.wind_speed_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member22", data.wind_speed_50hPa_member22));

            if (data.wind_speed_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member23", data.wind_speed_50hPa_member23));

            if (data.wind_speed_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member24", data.wind_speed_50hPa_member24));

            if (data.wind_speed_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member25", data.wind_speed_50hPa_member25));

            if (data.wind_speed_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member26", data.wind_speed_50hPa_member26));

            if (data.wind_speed_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member27", data.wind_speed_50hPa_member27));

            if (data.wind_speed_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member28", data.wind_speed_50hPa_member28));

            if (data.wind_speed_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member29", data.wind_speed_50hPa_member29));

            if (data.wind_speed_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_50hPa_member30", data.wind_speed_50hPa_member30));

            if (data.wind_direction_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa", data.wind_direction_1000hPa));

            if (data.wind_direction_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member01", data.wind_direction_1000hPa_member01));

            if (data.wind_direction_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member02", data.wind_direction_1000hPa_member02));

            if (data.wind_direction_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member03", data.wind_direction_1000hPa_member03));

            if (data.wind_direction_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member04", data.wind_direction_1000hPa_member04));

            if (data.wind_direction_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member05", data.wind_direction_1000hPa_member05));

            if (data.wind_direction_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member06", data.wind_direction_1000hPa_member06));

            if (data.wind_direction_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member07", data.wind_direction_1000hPa_member07));

            if (data.wind_direction_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member08", data.wind_direction_1000hPa_member08));

            if (data.wind_direction_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member09", data.wind_direction_1000hPa_member09));

            if (data.wind_direction_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member10", data.wind_direction_1000hPa_member10));

            if (data.wind_direction_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member11", data.wind_direction_1000hPa_member11));

            if (data.wind_direction_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member12", data.wind_direction_1000hPa_member12));

            if (data.wind_direction_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member13", data.wind_direction_1000hPa_member13));

            if (data.wind_direction_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member14", data.wind_direction_1000hPa_member14));

            if (data.wind_direction_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member15", data.wind_direction_1000hPa_member15));

            if (data.wind_direction_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member16", data.wind_direction_1000hPa_member16));

            if (data.wind_direction_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member17", data.wind_direction_1000hPa_member17));

            if (data.wind_direction_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member18", data.wind_direction_1000hPa_member18));

            if (data.wind_direction_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member19", data.wind_direction_1000hPa_member19));

            if (data.wind_direction_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member20", data.wind_direction_1000hPa_member20));

            if (data.wind_direction_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member21", data.wind_direction_1000hPa_member21));

            if (data.wind_direction_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member22", data.wind_direction_1000hPa_member22));

            if (data.wind_direction_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member23", data.wind_direction_1000hPa_member23));

            if (data.wind_direction_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member24", data.wind_direction_1000hPa_member24));

            if (data.wind_direction_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member25", data.wind_direction_1000hPa_member25));

            if (data.wind_direction_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member26", data.wind_direction_1000hPa_member26));

            if (data.wind_direction_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member27", data.wind_direction_1000hPa_member27));

            if (data.wind_direction_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member28", data.wind_direction_1000hPa_member28));

            if (data.wind_direction_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member29", data.wind_direction_1000hPa_member29));

            if (data.wind_direction_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_1000hPa_member30", data.wind_direction_1000hPa_member30));

            if (data.wind_direction_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa", data.wind_direction_925hPa));

            if (data.wind_direction_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member01", data.wind_direction_925hPa_member01));

            if (data.wind_direction_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member02", data.wind_direction_925hPa_member02));

            if (data.wind_direction_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member03", data.wind_direction_925hPa_member03));

            if (data.wind_direction_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member04", data.wind_direction_925hPa_member04));

            if (data.wind_direction_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member05", data.wind_direction_925hPa_member05));

            if (data.wind_direction_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member06", data.wind_direction_925hPa_member06));

            if (data.wind_direction_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member07", data.wind_direction_925hPa_member07));

            if (data.wind_direction_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member08", data.wind_direction_925hPa_member08));

            if (data.wind_direction_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member09", data.wind_direction_925hPa_member09));

            if (data.wind_direction_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member10", data.wind_direction_925hPa_member10));

            if (data.wind_direction_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member11", data.wind_direction_925hPa_member11));

            if (data.wind_direction_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member12", data.wind_direction_925hPa_member12));

            if (data.wind_direction_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member13", data.wind_direction_925hPa_member13));

            if (data.wind_direction_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member14", data.wind_direction_925hPa_member14));

            if (data.wind_direction_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member15", data.wind_direction_925hPa_member15));

            if (data.wind_direction_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member16", data.wind_direction_925hPa_member16));

            if (data.wind_direction_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member17", data.wind_direction_925hPa_member17));

            if (data.wind_direction_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member18", data.wind_direction_925hPa_member18));

            if (data.wind_direction_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member19", data.wind_direction_925hPa_member19));

            if (data.wind_direction_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member20", data.wind_direction_925hPa_member20));

            if (data.wind_direction_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member21", data.wind_direction_925hPa_member21));

            if (data.wind_direction_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member22", data.wind_direction_925hPa_member22));

            if (data.wind_direction_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member23", data.wind_direction_925hPa_member23));

            if (data.wind_direction_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member24", data.wind_direction_925hPa_member24));

            if (data.wind_direction_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member25", data.wind_direction_925hPa_member25));

            if (data.wind_direction_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member26", data.wind_direction_925hPa_member26));

            if (data.wind_direction_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member27", data.wind_direction_925hPa_member27));

            if (data.wind_direction_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member28", data.wind_direction_925hPa_member28));

            if (data.wind_direction_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member29", data.wind_direction_925hPa_member29));

            if (data.wind_direction_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_925hPa_member30", data.wind_direction_925hPa_member30));

            if (data.wind_direction_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa", data.wind_direction_850hPa));

            if (data.wind_direction_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member01", data.wind_direction_850hPa_member01));

            if (data.wind_direction_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member02", data.wind_direction_850hPa_member02));

            if (data.wind_direction_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member03", data.wind_direction_850hPa_member03));

            if (data.wind_direction_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member04", data.wind_direction_850hPa_member04));

            if (data.wind_direction_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member05", data.wind_direction_850hPa_member05));

            if (data.wind_direction_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member06", data.wind_direction_850hPa_member06));

            if (data.wind_direction_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member07", data.wind_direction_850hPa_member07));

            if (data.wind_direction_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member08", data.wind_direction_850hPa_member08));

            if (data.wind_direction_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member09", data.wind_direction_850hPa_member09));

            if (data.wind_direction_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member10", data.wind_direction_850hPa_member10));

            if (data.wind_direction_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member11", data.wind_direction_850hPa_member11));

            if (data.wind_direction_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member12", data.wind_direction_850hPa_member12));

            if (data.wind_direction_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member13", data.wind_direction_850hPa_member13));

            if (data.wind_direction_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member14", data.wind_direction_850hPa_member14));

            if (data.wind_direction_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member15", data.wind_direction_850hPa_member15));

            if (data.wind_direction_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member16", data.wind_direction_850hPa_member16));

            if (data.wind_direction_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member17", data.wind_direction_850hPa_member17));

            if (data.wind_direction_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member18", data.wind_direction_850hPa_member18));

            if (data.wind_direction_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member19", data.wind_direction_850hPa_member19));

            if (data.wind_direction_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member20", data.wind_direction_850hPa_member20));

            if (data.wind_direction_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member21", data.wind_direction_850hPa_member21));

            if (data.wind_direction_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member22", data.wind_direction_850hPa_member22));

            if (data.wind_direction_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member23", data.wind_direction_850hPa_member23));

            if (data.wind_direction_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member24", data.wind_direction_850hPa_member24));

            if (data.wind_direction_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member25", data.wind_direction_850hPa_member25));

            if (data.wind_direction_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member26", data.wind_direction_850hPa_member26));

            if (data.wind_direction_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member27", data.wind_direction_850hPa_member27));

            if (data.wind_direction_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member28", data.wind_direction_850hPa_member28));

            if (data.wind_direction_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member29", data.wind_direction_850hPa_member29));

            if (data.wind_direction_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_850hPa_member30", data.wind_direction_850hPa_member30));

            if (data.wind_direction_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa", data.wind_direction_700hPa));

            if (data.wind_direction_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member01", data.wind_direction_700hPa_member01));

            if (data.wind_direction_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member02", data.wind_direction_700hPa_member02));

            if (data.wind_direction_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member03", data.wind_direction_700hPa_member03));

            if (data.wind_direction_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member04", data.wind_direction_700hPa_member04));

            if (data.wind_direction_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member05", data.wind_direction_700hPa_member05));

            if (data.wind_direction_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member06", data.wind_direction_700hPa_member06));

            if (data.wind_direction_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member07", data.wind_direction_700hPa_member07));

            if (data.wind_direction_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member08", data.wind_direction_700hPa_member08));

            if (data.wind_direction_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member09", data.wind_direction_700hPa_member09));

            if (data.wind_direction_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member10", data.wind_direction_700hPa_member10));

            if (data.wind_direction_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member11", data.wind_direction_700hPa_member11));

            if (data.wind_direction_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member12", data.wind_direction_700hPa_member12));

            if (data.wind_direction_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member13", data.wind_direction_700hPa_member13));

            if (data.wind_direction_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member14", data.wind_direction_700hPa_member14));

            if (data.wind_direction_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member15", data.wind_direction_700hPa_member15));

            if (data.wind_direction_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member16", data.wind_direction_700hPa_member16));

            if (data.wind_direction_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member17", data.wind_direction_700hPa_member17));

            if (data.wind_direction_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member18", data.wind_direction_700hPa_member18));

            if (data.wind_direction_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member19", data.wind_direction_700hPa_member19));

            if (data.wind_direction_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member20", data.wind_direction_700hPa_member20));

            if (data.wind_direction_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member21", data.wind_direction_700hPa_member21));

            if (data.wind_direction_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member22", data.wind_direction_700hPa_member22));

            if (data.wind_direction_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member23", data.wind_direction_700hPa_member23));

            if (data.wind_direction_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member24", data.wind_direction_700hPa_member24));

            if (data.wind_direction_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member25", data.wind_direction_700hPa_member25));

            if (data.wind_direction_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member26", data.wind_direction_700hPa_member26));

            if (data.wind_direction_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member27", data.wind_direction_700hPa_member27));

            if (data.wind_direction_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member28", data.wind_direction_700hPa_member28));

            if (data.wind_direction_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member29", data.wind_direction_700hPa_member29));

            if (data.wind_direction_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_700hPa_member30", data.wind_direction_700hPa_member30));

            if (data.wind_direction_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa", data.wind_direction_600hPa));

            if (data.wind_direction_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member01", data.wind_direction_600hPa_member01));

            if (data.wind_direction_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member02", data.wind_direction_600hPa_member02));

            if (data.wind_direction_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member03", data.wind_direction_600hPa_member03));

            if (data.wind_direction_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member04", data.wind_direction_600hPa_member04));

            if (data.wind_direction_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member05", data.wind_direction_600hPa_member05));

            if (data.wind_direction_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member06", data.wind_direction_600hPa_member06));

            if (data.wind_direction_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member07", data.wind_direction_600hPa_member07));

            if (data.wind_direction_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member08", data.wind_direction_600hPa_member08));

            if (data.wind_direction_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member09", data.wind_direction_600hPa_member09));

            if (data.wind_direction_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member10", data.wind_direction_600hPa_member10));

            if (data.wind_direction_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member11", data.wind_direction_600hPa_member11));

            if (data.wind_direction_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member12", data.wind_direction_600hPa_member12));

            if (data.wind_direction_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member13", data.wind_direction_600hPa_member13));

            if (data.wind_direction_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member14", data.wind_direction_600hPa_member14));

            if (data.wind_direction_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member15", data.wind_direction_600hPa_member15));

            if (data.wind_direction_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member16", data.wind_direction_600hPa_member16));

            if (data.wind_direction_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member17", data.wind_direction_600hPa_member17));

            if (data.wind_direction_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member18", data.wind_direction_600hPa_member18));

            if (data.wind_direction_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member19", data.wind_direction_600hPa_member19));

            if (data.wind_direction_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member20", data.wind_direction_600hPa_member20));

            if (data.wind_direction_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member21", data.wind_direction_600hPa_member21));

            if (data.wind_direction_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member22", data.wind_direction_600hPa_member22));

            if (data.wind_direction_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member23", data.wind_direction_600hPa_member23));

            if (data.wind_direction_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member24", data.wind_direction_600hPa_member24));

            if (data.wind_direction_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member25", data.wind_direction_600hPa_member25));

            if (data.wind_direction_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member26", data.wind_direction_600hPa_member26));

            if (data.wind_direction_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member27", data.wind_direction_600hPa_member27));

            if (data.wind_direction_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member28", data.wind_direction_600hPa_member28));

            if (data.wind_direction_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member29", data.wind_direction_600hPa_member29));

            if (data.wind_direction_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_600hPa_member30", data.wind_direction_600hPa_member30));

            if (data.wind_direction_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa", data.wind_direction_500hPa));

            if (data.wind_direction_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member01", data.wind_direction_500hPa_member01));

            if (data.wind_direction_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member02", data.wind_direction_500hPa_member02));

            if (data.wind_direction_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member03", data.wind_direction_500hPa_member03));

            if (data.wind_direction_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member04", data.wind_direction_500hPa_member04));

            if (data.wind_direction_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member05", data.wind_direction_500hPa_member05));

            if (data.wind_direction_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member06", data.wind_direction_500hPa_member06));

            if (data.wind_direction_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member07", data.wind_direction_500hPa_member07));

            if (data.wind_direction_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member08", data.wind_direction_500hPa_member08));

            if (data.wind_direction_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member09", data.wind_direction_500hPa_member09));

            if (data.wind_direction_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member10", data.wind_direction_500hPa_member10));

            if (data.wind_direction_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member11", data.wind_direction_500hPa_member11));

            if (data.wind_direction_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member12", data.wind_direction_500hPa_member12));

            if (data.wind_direction_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member13", data.wind_direction_500hPa_member13));

            if (data.wind_direction_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member14", data.wind_direction_500hPa_member14));

            if (data.wind_direction_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member15", data.wind_direction_500hPa_member15));

            if (data.wind_direction_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member16", data.wind_direction_500hPa_member16));

            if (data.wind_direction_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member17", data.wind_direction_500hPa_member17));

            if (data.wind_direction_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member18", data.wind_direction_500hPa_member18));

            if (data.wind_direction_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member19", data.wind_direction_500hPa_member19));

            if (data.wind_direction_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member20", data.wind_direction_500hPa_member20));

            if (data.wind_direction_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member21", data.wind_direction_500hPa_member21));

            if (data.wind_direction_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member22", data.wind_direction_500hPa_member22));

            if (data.wind_direction_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member23", data.wind_direction_500hPa_member23));

            if (data.wind_direction_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member24", data.wind_direction_500hPa_member24));

            if (data.wind_direction_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member25", data.wind_direction_500hPa_member25));

            if (data.wind_direction_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member26", data.wind_direction_500hPa_member26));

            if (data.wind_direction_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member27", data.wind_direction_500hPa_member27));

            if (data.wind_direction_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member28", data.wind_direction_500hPa_member28));

            if (data.wind_direction_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member29", data.wind_direction_500hPa_member29));

            if (data.wind_direction_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_500hPa_member30", data.wind_direction_500hPa_member30));

            if (data.wind_direction_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa", data.wind_direction_400hPa));

            if (data.wind_direction_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member01", data.wind_direction_400hPa_member01));

            if (data.wind_direction_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member02", data.wind_direction_400hPa_member02));

            if (data.wind_direction_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member03", data.wind_direction_400hPa_member03));

            if (data.wind_direction_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member04", data.wind_direction_400hPa_member04));

            if (data.wind_direction_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member05", data.wind_direction_400hPa_member05));

            if (data.wind_direction_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member06", data.wind_direction_400hPa_member06));

            if (data.wind_direction_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member07", data.wind_direction_400hPa_member07));

            if (data.wind_direction_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member08", data.wind_direction_400hPa_member08));

            if (data.wind_direction_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member09", data.wind_direction_400hPa_member09));

            if (data.wind_direction_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member10", data.wind_direction_400hPa_member10));

            if (data.wind_direction_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member11", data.wind_direction_400hPa_member11));

            if (data.wind_direction_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member12", data.wind_direction_400hPa_member12));

            if (data.wind_direction_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member13", data.wind_direction_400hPa_member13));

            if (data.wind_direction_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member14", data.wind_direction_400hPa_member14));

            if (data.wind_direction_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member15", data.wind_direction_400hPa_member15));

            if (data.wind_direction_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member16", data.wind_direction_400hPa_member16));

            if (data.wind_direction_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member17", data.wind_direction_400hPa_member17));

            if (data.wind_direction_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member18", data.wind_direction_400hPa_member18));

            if (data.wind_direction_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member19", data.wind_direction_400hPa_member19));

            if (data.wind_direction_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member20", data.wind_direction_400hPa_member20));

            if (data.wind_direction_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member21", data.wind_direction_400hPa_member21));

            if (data.wind_direction_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member22", data.wind_direction_400hPa_member22));

            if (data.wind_direction_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member23", data.wind_direction_400hPa_member23));

            if (data.wind_direction_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member24", data.wind_direction_400hPa_member24));

            if (data.wind_direction_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member25", data.wind_direction_400hPa_member25));

            if (data.wind_direction_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member26", data.wind_direction_400hPa_member26));

            if (data.wind_direction_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member27", data.wind_direction_400hPa_member27));

            if (data.wind_direction_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member28", data.wind_direction_400hPa_member28));

            if (data.wind_direction_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member29", data.wind_direction_400hPa_member29));

            if (data.wind_direction_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_400hPa_member30", data.wind_direction_400hPa_member30));

            if (data.wind_direction_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa", data.wind_direction_300hPa));

            if (data.wind_direction_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member01", data.wind_direction_300hPa_member01));

            if (data.wind_direction_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member02", data.wind_direction_300hPa_member02));

            if (data.wind_direction_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member03", data.wind_direction_300hPa_member03));

            if (data.wind_direction_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member04", data.wind_direction_300hPa_member04));

            if (data.wind_direction_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member05", data.wind_direction_300hPa_member05));

            if (data.wind_direction_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member06", data.wind_direction_300hPa_member06));

            if (data.wind_direction_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member07", data.wind_direction_300hPa_member07));

            if (data.wind_direction_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member08", data.wind_direction_300hPa_member08));

            if (data.wind_direction_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member09", data.wind_direction_300hPa_member09));

            if (data.wind_direction_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member10", data.wind_direction_300hPa_member10));

            if (data.wind_direction_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member11", data.wind_direction_300hPa_member11));

            if (data.wind_direction_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member12", data.wind_direction_300hPa_member12));

            if (data.wind_direction_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member13", data.wind_direction_300hPa_member13));

            if (data.wind_direction_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member14", data.wind_direction_300hPa_member14));

            if (data.wind_direction_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member15", data.wind_direction_300hPa_member15));

            if (data.wind_direction_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member16", data.wind_direction_300hPa_member16));

            if (data.wind_direction_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member17", data.wind_direction_300hPa_member17));

            if (data.wind_direction_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member18", data.wind_direction_300hPa_member18));

            if (data.wind_direction_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member19", data.wind_direction_300hPa_member19));

            if (data.wind_direction_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member20", data.wind_direction_300hPa_member20));

            if (data.wind_direction_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member21", data.wind_direction_300hPa_member21));

            if (data.wind_direction_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member22", data.wind_direction_300hPa_member22));

            if (data.wind_direction_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member23", data.wind_direction_300hPa_member23));

            if (data.wind_direction_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member24", data.wind_direction_300hPa_member24));

            if (data.wind_direction_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member25", data.wind_direction_300hPa_member25));

            if (data.wind_direction_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member26", data.wind_direction_300hPa_member26));

            if (data.wind_direction_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member27", data.wind_direction_300hPa_member27));

            if (data.wind_direction_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member28", data.wind_direction_300hPa_member28));

            if (data.wind_direction_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member29", data.wind_direction_300hPa_member29));

            if (data.wind_direction_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_300hPa_member30", data.wind_direction_300hPa_member30));

            if (data.wind_direction_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa", data.wind_direction_250hPa));

            if (data.wind_direction_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member01", data.wind_direction_250hPa_member01));

            if (data.wind_direction_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member02", data.wind_direction_250hPa_member02));

            if (data.wind_direction_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member03", data.wind_direction_250hPa_member03));

            if (data.wind_direction_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member04", data.wind_direction_250hPa_member04));

            if (data.wind_direction_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member05", data.wind_direction_250hPa_member05));

            if (data.wind_direction_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member06", data.wind_direction_250hPa_member06));

            if (data.wind_direction_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member07", data.wind_direction_250hPa_member07));

            if (data.wind_direction_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member08", data.wind_direction_250hPa_member08));

            if (data.wind_direction_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member09", data.wind_direction_250hPa_member09));

            if (data.wind_direction_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member10", data.wind_direction_250hPa_member10));

            if (data.wind_direction_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member11", data.wind_direction_250hPa_member11));

            if (data.wind_direction_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member12", data.wind_direction_250hPa_member12));

            if (data.wind_direction_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member13", data.wind_direction_250hPa_member13));

            if (data.wind_direction_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member14", data.wind_direction_250hPa_member14));

            if (data.wind_direction_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member15", data.wind_direction_250hPa_member15));

            if (data.wind_direction_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member16", data.wind_direction_250hPa_member16));

            if (data.wind_direction_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member17", data.wind_direction_250hPa_member17));

            if (data.wind_direction_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member18", data.wind_direction_250hPa_member18));

            if (data.wind_direction_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member19", data.wind_direction_250hPa_member19));

            if (data.wind_direction_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member20", data.wind_direction_250hPa_member20));

            if (data.wind_direction_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member21", data.wind_direction_250hPa_member21));

            if (data.wind_direction_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member22", data.wind_direction_250hPa_member22));

            if (data.wind_direction_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member23", data.wind_direction_250hPa_member23));

            if (data.wind_direction_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member24", data.wind_direction_250hPa_member24));

            if (data.wind_direction_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member25", data.wind_direction_250hPa_member25));

            if (data.wind_direction_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member26", data.wind_direction_250hPa_member26));

            if (data.wind_direction_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member27", data.wind_direction_250hPa_member27));

            if (data.wind_direction_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member28", data.wind_direction_250hPa_member28));

            if (data.wind_direction_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member29", data.wind_direction_250hPa_member29));

            if (data.wind_direction_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_250hPa_member30", data.wind_direction_250hPa_member30));

            if (data.wind_direction_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa", data.wind_direction_200hPa));

            if (data.wind_direction_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member01", data.wind_direction_200hPa_member01));

            if (data.wind_direction_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member02", data.wind_direction_200hPa_member02));

            if (data.wind_direction_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member03", data.wind_direction_200hPa_member03));

            if (data.wind_direction_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member04", data.wind_direction_200hPa_member04));

            if (data.wind_direction_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member05", data.wind_direction_200hPa_member05));

            if (data.wind_direction_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member06", data.wind_direction_200hPa_member06));

            if (data.wind_direction_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member07", data.wind_direction_200hPa_member07));

            if (data.wind_direction_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member08", data.wind_direction_200hPa_member08));

            if (data.wind_direction_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member09", data.wind_direction_200hPa_member09));

            if (data.wind_direction_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member10", data.wind_direction_200hPa_member10));

            if (data.wind_direction_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member11", data.wind_direction_200hPa_member11));

            if (data.wind_direction_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member12", data.wind_direction_200hPa_member12));

            if (data.wind_direction_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member13", data.wind_direction_200hPa_member13));

            if (data.wind_direction_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member14", data.wind_direction_200hPa_member14));

            if (data.wind_direction_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member15", data.wind_direction_200hPa_member15));

            if (data.wind_direction_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member16", data.wind_direction_200hPa_member16));

            if (data.wind_direction_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member17", data.wind_direction_200hPa_member17));

            if (data.wind_direction_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member18", data.wind_direction_200hPa_member18));

            if (data.wind_direction_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member19", data.wind_direction_200hPa_member19));

            if (data.wind_direction_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member20", data.wind_direction_200hPa_member20));

            if (data.wind_direction_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member21", data.wind_direction_200hPa_member21));

            if (data.wind_direction_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member22", data.wind_direction_200hPa_member22));

            if (data.wind_direction_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member23", data.wind_direction_200hPa_member23));

            if (data.wind_direction_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member24", data.wind_direction_200hPa_member24));

            if (data.wind_direction_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member25", data.wind_direction_200hPa_member25));

            if (data.wind_direction_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member26", data.wind_direction_200hPa_member26));

            if (data.wind_direction_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member27", data.wind_direction_200hPa_member27));

            if (data.wind_direction_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member28", data.wind_direction_200hPa_member28));

            if (data.wind_direction_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member29", data.wind_direction_200hPa_member29));

            if (data.wind_direction_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_200hPa_member30", data.wind_direction_200hPa_member30));

            if (data.wind_direction_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa", data.wind_direction_150hPa));

            if (data.wind_direction_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member01", data.wind_direction_150hPa_member01));

            if (data.wind_direction_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member02", data.wind_direction_150hPa_member02));

            if (data.wind_direction_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member03", data.wind_direction_150hPa_member03));

            if (data.wind_direction_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member04", data.wind_direction_150hPa_member04));

            if (data.wind_direction_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member05", data.wind_direction_150hPa_member05));

            if (data.wind_direction_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member06", data.wind_direction_150hPa_member06));

            if (data.wind_direction_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member07", data.wind_direction_150hPa_member07));

            if (data.wind_direction_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member08", data.wind_direction_150hPa_member08));

            if (data.wind_direction_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member09", data.wind_direction_150hPa_member09));

            if (data.wind_direction_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member10", data.wind_direction_150hPa_member10));

            if (data.wind_direction_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member11", data.wind_direction_150hPa_member11));

            if (data.wind_direction_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member12", data.wind_direction_150hPa_member12));

            if (data.wind_direction_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member13", data.wind_direction_150hPa_member13));

            if (data.wind_direction_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member14", data.wind_direction_150hPa_member14));

            if (data.wind_direction_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member15", data.wind_direction_150hPa_member15));

            if (data.wind_direction_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member16", data.wind_direction_150hPa_member16));

            if (data.wind_direction_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member17", data.wind_direction_150hPa_member17));

            if (data.wind_direction_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member18", data.wind_direction_150hPa_member18));

            if (data.wind_direction_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member19", data.wind_direction_150hPa_member19));

            if (data.wind_direction_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member20", data.wind_direction_150hPa_member20));

            if (data.wind_direction_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member21", data.wind_direction_150hPa_member21));

            if (data.wind_direction_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member22", data.wind_direction_150hPa_member22));

            if (data.wind_direction_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member23", data.wind_direction_150hPa_member23));

            if (data.wind_direction_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member24", data.wind_direction_150hPa_member24));

            if (data.wind_direction_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member25", data.wind_direction_150hPa_member25));

            if (data.wind_direction_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member26", data.wind_direction_150hPa_member26));

            if (data.wind_direction_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member27", data.wind_direction_150hPa_member27));

            if (data.wind_direction_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member28", data.wind_direction_150hPa_member28));

            if (data.wind_direction_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member29", data.wind_direction_150hPa_member29));

            if (data.wind_direction_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_150hPa_member30", data.wind_direction_150hPa_member30));

            if (data.wind_direction_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa", data.wind_direction_100hPa));

            if (data.wind_direction_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member01", data.wind_direction_100hPa_member01));

            if (data.wind_direction_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member02", data.wind_direction_100hPa_member02));

            if (data.wind_direction_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member03", data.wind_direction_100hPa_member03));

            if (data.wind_direction_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member04", data.wind_direction_100hPa_member04));

            if (data.wind_direction_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member05", data.wind_direction_100hPa_member05));

            if (data.wind_direction_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member06", data.wind_direction_100hPa_member06));

            if (data.wind_direction_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member07", data.wind_direction_100hPa_member07));

            if (data.wind_direction_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member08", data.wind_direction_100hPa_member08));

            if (data.wind_direction_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member09", data.wind_direction_100hPa_member09));

            if (data.wind_direction_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member10", data.wind_direction_100hPa_member10));

            if (data.wind_direction_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member11", data.wind_direction_100hPa_member11));

            if (data.wind_direction_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member12", data.wind_direction_100hPa_member12));

            if (data.wind_direction_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member13", data.wind_direction_100hPa_member13));

            if (data.wind_direction_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member14", data.wind_direction_100hPa_member14));

            if (data.wind_direction_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member15", data.wind_direction_100hPa_member15));

            if (data.wind_direction_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member16", data.wind_direction_100hPa_member16));

            if (data.wind_direction_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member17", data.wind_direction_100hPa_member17));

            if (data.wind_direction_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member18", data.wind_direction_100hPa_member18));

            if (data.wind_direction_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member19", data.wind_direction_100hPa_member19));

            if (data.wind_direction_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member20", data.wind_direction_100hPa_member20));

            if (data.wind_direction_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member21", data.wind_direction_100hPa_member21));

            if (data.wind_direction_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member22", data.wind_direction_100hPa_member22));

            if (data.wind_direction_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member23", data.wind_direction_100hPa_member23));

            if (data.wind_direction_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member24", data.wind_direction_100hPa_member24));

            if (data.wind_direction_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member25", data.wind_direction_100hPa_member25));

            if (data.wind_direction_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member26", data.wind_direction_100hPa_member26));

            if (data.wind_direction_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member27", data.wind_direction_100hPa_member27));

            if (data.wind_direction_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member28", data.wind_direction_100hPa_member28));

            if (data.wind_direction_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member29", data.wind_direction_100hPa_member29));

            if (data.wind_direction_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_100hPa_member30", data.wind_direction_100hPa_member30));

            if (data.wind_direction_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa", data.wind_direction_50hPa));

            if (data.wind_direction_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member01", data.wind_direction_50hPa_member01));

            if (data.wind_direction_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member02", data.wind_direction_50hPa_member02));

            if (data.wind_direction_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member03", data.wind_direction_50hPa_member03));

            if (data.wind_direction_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member04", data.wind_direction_50hPa_member04));

            if (data.wind_direction_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member05", data.wind_direction_50hPa_member05));

            if (data.wind_direction_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member06", data.wind_direction_50hPa_member06));

            if (data.wind_direction_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member07", data.wind_direction_50hPa_member07));

            if (data.wind_direction_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member08", data.wind_direction_50hPa_member08));

            if (data.wind_direction_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member09", data.wind_direction_50hPa_member09));

            if (data.wind_direction_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member10", data.wind_direction_50hPa_member10));

            if (data.wind_direction_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member11", data.wind_direction_50hPa_member11));

            if (data.wind_direction_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member12", data.wind_direction_50hPa_member12));

            if (data.wind_direction_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member13", data.wind_direction_50hPa_member13));

            if (data.wind_direction_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member14", data.wind_direction_50hPa_member14));

            if (data.wind_direction_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member15", data.wind_direction_50hPa_member15));

            if (data.wind_direction_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member16", data.wind_direction_50hPa_member16));

            if (data.wind_direction_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member17", data.wind_direction_50hPa_member17));

            if (data.wind_direction_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member18", data.wind_direction_50hPa_member18));

            if (data.wind_direction_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member19", data.wind_direction_50hPa_member19));

            if (data.wind_direction_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member20", data.wind_direction_50hPa_member20));

            if (data.wind_direction_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member21", data.wind_direction_50hPa_member21));

            if (data.wind_direction_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member22", data.wind_direction_50hPa_member22));

            if (data.wind_direction_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member23", data.wind_direction_50hPa_member23));

            if (data.wind_direction_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member24", data.wind_direction_50hPa_member24));

            if (data.wind_direction_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member25", data.wind_direction_50hPa_member25));

            if (data.wind_direction_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member26", data.wind_direction_50hPa_member26));

            if (data.wind_direction_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member27", data.wind_direction_50hPa_member27));

            if (data.wind_direction_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member28", data.wind_direction_50hPa_member28));

            if (data.wind_direction_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member29", data.wind_direction_50hPa_member29));

            if (data.wind_direction_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_direction_50hPa_member30", data.wind_direction_50hPa_member30));

            if (data.vertical_velocity_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa", data.vertical_velocity_1000hPa));

            if (data.vertical_velocity_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member01", data.vertical_velocity_1000hPa_member01));

            if (data.vertical_velocity_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member02", data.vertical_velocity_1000hPa_member02));

            if (data.vertical_velocity_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member03", data.vertical_velocity_1000hPa_member03));

            if (data.vertical_velocity_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member04", data.vertical_velocity_1000hPa_member04));

            if (data.vertical_velocity_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member05", data.vertical_velocity_1000hPa_member05));

            if (data.vertical_velocity_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member06", data.vertical_velocity_1000hPa_member06));

            if (data.vertical_velocity_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member07", data.vertical_velocity_1000hPa_member07));

            if (data.vertical_velocity_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member08", data.vertical_velocity_1000hPa_member08));

            if (data.vertical_velocity_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member09", data.vertical_velocity_1000hPa_member09));

            if (data.vertical_velocity_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member10", data.vertical_velocity_1000hPa_member10));

            if (data.vertical_velocity_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member11", data.vertical_velocity_1000hPa_member11));

            if (data.vertical_velocity_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member12", data.vertical_velocity_1000hPa_member12));

            if (data.vertical_velocity_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member13", data.vertical_velocity_1000hPa_member13));

            if (data.vertical_velocity_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member14", data.vertical_velocity_1000hPa_member14));

            if (data.vertical_velocity_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member15", data.vertical_velocity_1000hPa_member15));

            if (data.vertical_velocity_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member16", data.vertical_velocity_1000hPa_member16));

            if (data.vertical_velocity_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member17", data.vertical_velocity_1000hPa_member17));

            if (data.vertical_velocity_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member18", data.vertical_velocity_1000hPa_member18));

            if (data.vertical_velocity_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member19", data.vertical_velocity_1000hPa_member19));

            if (data.vertical_velocity_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member20", data.vertical_velocity_1000hPa_member20));

            if (data.vertical_velocity_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member21", data.vertical_velocity_1000hPa_member21));

            if (data.vertical_velocity_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member22", data.vertical_velocity_1000hPa_member22));

            if (data.vertical_velocity_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member23", data.vertical_velocity_1000hPa_member23));

            if (data.vertical_velocity_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member24", data.vertical_velocity_1000hPa_member24));

            if (data.vertical_velocity_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member25", data.vertical_velocity_1000hPa_member25));

            if (data.vertical_velocity_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member26", data.vertical_velocity_1000hPa_member26));

            if (data.vertical_velocity_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member27", data.vertical_velocity_1000hPa_member27));

            if (data.vertical_velocity_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member28", data.vertical_velocity_1000hPa_member28));

            if (data.vertical_velocity_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member29", data.vertical_velocity_1000hPa_member29));

            if (data.vertical_velocity_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_1000hPa_member30", data.vertical_velocity_1000hPa_member30));

            if (data.vertical_velocity_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa", data.vertical_velocity_925hPa));

            if (data.vertical_velocity_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member01", data.vertical_velocity_925hPa_member01));

            if (data.vertical_velocity_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member02", data.vertical_velocity_925hPa_member02));

            if (data.vertical_velocity_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member03", data.vertical_velocity_925hPa_member03));

            if (data.vertical_velocity_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member04", data.vertical_velocity_925hPa_member04));

            if (data.vertical_velocity_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member05", data.vertical_velocity_925hPa_member05));

            if (data.vertical_velocity_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member06", data.vertical_velocity_925hPa_member06));

            if (data.vertical_velocity_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member07", data.vertical_velocity_925hPa_member07));

            if (data.vertical_velocity_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member08", data.vertical_velocity_925hPa_member08));

            if (data.vertical_velocity_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member09", data.vertical_velocity_925hPa_member09));

            if (data.vertical_velocity_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member10", data.vertical_velocity_925hPa_member10));

            if (data.vertical_velocity_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member11", data.vertical_velocity_925hPa_member11));

            if (data.vertical_velocity_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member12", data.vertical_velocity_925hPa_member12));

            if (data.vertical_velocity_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member13", data.vertical_velocity_925hPa_member13));

            if (data.vertical_velocity_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member14", data.vertical_velocity_925hPa_member14));

            if (data.vertical_velocity_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member15", data.vertical_velocity_925hPa_member15));

            if (data.vertical_velocity_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member16", data.vertical_velocity_925hPa_member16));

            if (data.vertical_velocity_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member17", data.vertical_velocity_925hPa_member17));

            if (data.vertical_velocity_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member18", data.vertical_velocity_925hPa_member18));

            if (data.vertical_velocity_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member19", data.vertical_velocity_925hPa_member19));

            if (data.vertical_velocity_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member20", data.vertical_velocity_925hPa_member20));

            if (data.vertical_velocity_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member21", data.vertical_velocity_925hPa_member21));

            if (data.vertical_velocity_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member22", data.vertical_velocity_925hPa_member22));

            if (data.vertical_velocity_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member23", data.vertical_velocity_925hPa_member23));

            if (data.vertical_velocity_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member24", data.vertical_velocity_925hPa_member24));

            if (data.vertical_velocity_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member25", data.vertical_velocity_925hPa_member25));

            if (data.vertical_velocity_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member26", data.vertical_velocity_925hPa_member26));

            if (data.vertical_velocity_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member27", data.vertical_velocity_925hPa_member27));

            if (data.vertical_velocity_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member28", data.vertical_velocity_925hPa_member28));

            if (data.vertical_velocity_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member29", data.vertical_velocity_925hPa_member29));

            if (data.vertical_velocity_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_925hPa_member30", data.vertical_velocity_925hPa_member30));

            if (data.vertical_velocity_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa", data.vertical_velocity_850hPa));

            if (data.vertical_velocity_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member01", data.vertical_velocity_850hPa_member01));

            if (data.vertical_velocity_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member02", data.vertical_velocity_850hPa_member02));

            if (data.vertical_velocity_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member03", data.vertical_velocity_850hPa_member03));

            if (data.vertical_velocity_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member04", data.vertical_velocity_850hPa_member04));

            if (data.vertical_velocity_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member05", data.vertical_velocity_850hPa_member05));

            if (data.vertical_velocity_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member06", data.vertical_velocity_850hPa_member06));

            if (data.vertical_velocity_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member07", data.vertical_velocity_850hPa_member07));

            if (data.vertical_velocity_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member08", data.vertical_velocity_850hPa_member08));

            if (data.vertical_velocity_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member09", data.vertical_velocity_850hPa_member09));

            if (data.vertical_velocity_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member10", data.vertical_velocity_850hPa_member10));

            if (data.vertical_velocity_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member11", data.vertical_velocity_850hPa_member11));

            if (data.vertical_velocity_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member12", data.vertical_velocity_850hPa_member12));

            if (data.vertical_velocity_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member13", data.vertical_velocity_850hPa_member13));

            if (data.vertical_velocity_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member14", data.vertical_velocity_850hPa_member14));

            if (data.vertical_velocity_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member15", data.vertical_velocity_850hPa_member15));

            if (data.vertical_velocity_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member16", data.vertical_velocity_850hPa_member16));

            if (data.vertical_velocity_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member17", data.vertical_velocity_850hPa_member17));

            if (data.vertical_velocity_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member18", data.vertical_velocity_850hPa_member18));

            if (data.vertical_velocity_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member19", data.vertical_velocity_850hPa_member19));

            if (data.vertical_velocity_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member20", data.vertical_velocity_850hPa_member20));

            if (data.vertical_velocity_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member21", data.vertical_velocity_850hPa_member21));

            if (data.vertical_velocity_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member22", data.vertical_velocity_850hPa_member22));

            if (data.vertical_velocity_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member23", data.vertical_velocity_850hPa_member23));

            if (data.vertical_velocity_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member24", data.vertical_velocity_850hPa_member24));

            if (data.vertical_velocity_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member25", data.vertical_velocity_850hPa_member25));

            if (data.vertical_velocity_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member26", data.vertical_velocity_850hPa_member26));

            if (data.vertical_velocity_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member27", data.vertical_velocity_850hPa_member27));

            if (data.vertical_velocity_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member28", data.vertical_velocity_850hPa_member28));

            if (data.vertical_velocity_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member29", data.vertical_velocity_850hPa_member29));

            if (data.vertical_velocity_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_850hPa_member30", data.vertical_velocity_850hPa_member30));

            if (data.vertical_velocity_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa", data.vertical_velocity_700hPa));

            if (data.vertical_velocity_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member01", data.vertical_velocity_700hPa_member01));

            if (data.vertical_velocity_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member02", data.vertical_velocity_700hPa_member02));

            if (data.vertical_velocity_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member03", data.vertical_velocity_700hPa_member03));

            if (data.vertical_velocity_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member04", data.vertical_velocity_700hPa_member04));

            if (data.vertical_velocity_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member05", data.vertical_velocity_700hPa_member05));

            if (data.vertical_velocity_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member06", data.vertical_velocity_700hPa_member06));

            if (data.vertical_velocity_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member07", data.vertical_velocity_700hPa_member07));

            if (data.vertical_velocity_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member08", data.vertical_velocity_700hPa_member08));

            if (data.vertical_velocity_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member09", data.vertical_velocity_700hPa_member09));

            if (data.vertical_velocity_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member10", data.vertical_velocity_700hPa_member10));

            if (data.vertical_velocity_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member11", data.vertical_velocity_700hPa_member11));

            if (data.vertical_velocity_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member12", data.vertical_velocity_700hPa_member12));

            if (data.vertical_velocity_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member13", data.vertical_velocity_700hPa_member13));

            if (data.vertical_velocity_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member14", data.vertical_velocity_700hPa_member14));

            if (data.vertical_velocity_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member15", data.vertical_velocity_700hPa_member15));

            if (data.vertical_velocity_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member16", data.vertical_velocity_700hPa_member16));

            if (data.vertical_velocity_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member17", data.vertical_velocity_700hPa_member17));

            if (data.vertical_velocity_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member18", data.vertical_velocity_700hPa_member18));

            if (data.vertical_velocity_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member19", data.vertical_velocity_700hPa_member19));

            if (data.vertical_velocity_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member20", data.vertical_velocity_700hPa_member20));

            if (data.vertical_velocity_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member21", data.vertical_velocity_700hPa_member21));

            if (data.vertical_velocity_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member22", data.vertical_velocity_700hPa_member22));

            if (data.vertical_velocity_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member23", data.vertical_velocity_700hPa_member23));

            if (data.vertical_velocity_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member24", data.vertical_velocity_700hPa_member24));

            if (data.vertical_velocity_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member25", data.vertical_velocity_700hPa_member25));

            if (data.vertical_velocity_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member26", data.vertical_velocity_700hPa_member26));

            if (data.vertical_velocity_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member27", data.vertical_velocity_700hPa_member27));

            if (data.vertical_velocity_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member28", data.vertical_velocity_700hPa_member28));

            if (data.vertical_velocity_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member29", data.vertical_velocity_700hPa_member29));

            if (data.vertical_velocity_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_700hPa_member30", data.vertical_velocity_700hPa_member30));

            if (data.vertical_velocity_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa", data.vertical_velocity_600hPa));

            if (data.vertical_velocity_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member01", data.vertical_velocity_600hPa_member01));

            if (data.vertical_velocity_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member02", data.vertical_velocity_600hPa_member02));

            if (data.vertical_velocity_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member03", data.vertical_velocity_600hPa_member03));

            if (data.vertical_velocity_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member04", data.vertical_velocity_600hPa_member04));

            if (data.vertical_velocity_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member05", data.vertical_velocity_600hPa_member05));

            if (data.vertical_velocity_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member06", data.vertical_velocity_600hPa_member06));

            if (data.vertical_velocity_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member07", data.vertical_velocity_600hPa_member07));

            if (data.vertical_velocity_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member08", data.vertical_velocity_600hPa_member08));

            if (data.vertical_velocity_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member09", data.vertical_velocity_600hPa_member09));

            if (data.vertical_velocity_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member10", data.vertical_velocity_600hPa_member10));

            if (data.vertical_velocity_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member11", data.vertical_velocity_600hPa_member11));

            if (data.vertical_velocity_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member12", data.vertical_velocity_600hPa_member12));

            if (data.vertical_velocity_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member13", data.vertical_velocity_600hPa_member13));

            if (data.vertical_velocity_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member14", data.vertical_velocity_600hPa_member14));

            if (data.vertical_velocity_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member15", data.vertical_velocity_600hPa_member15));

            if (data.vertical_velocity_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member16", data.vertical_velocity_600hPa_member16));

            if (data.vertical_velocity_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member17", data.vertical_velocity_600hPa_member17));

            if (data.vertical_velocity_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member18", data.vertical_velocity_600hPa_member18));

            if (data.vertical_velocity_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member19", data.vertical_velocity_600hPa_member19));

            if (data.vertical_velocity_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member20", data.vertical_velocity_600hPa_member20));

            if (data.vertical_velocity_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member21", data.vertical_velocity_600hPa_member21));

            if (data.vertical_velocity_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member22", data.vertical_velocity_600hPa_member22));

            if (data.vertical_velocity_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member23", data.vertical_velocity_600hPa_member23));

            if (data.vertical_velocity_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member24", data.vertical_velocity_600hPa_member24));

            if (data.vertical_velocity_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member25", data.vertical_velocity_600hPa_member25));

            if (data.vertical_velocity_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member26", data.vertical_velocity_600hPa_member26));

            if (data.vertical_velocity_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member27", data.vertical_velocity_600hPa_member27));

            if (data.vertical_velocity_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member28", data.vertical_velocity_600hPa_member28));

            if (data.vertical_velocity_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member29", data.vertical_velocity_600hPa_member29));

            if (data.vertical_velocity_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_600hPa_member30", data.vertical_velocity_600hPa_member30));

            if (data.vertical_velocity_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa", data.vertical_velocity_500hPa));

            if (data.vertical_velocity_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member01", data.vertical_velocity_500hPa_member01));

            if (data.vertical_velocity_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member02", data.vertical_velocity_500hPa_member02));

            if (data.vertical_velocity_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member03", data.vertical_velocity_500hPa_member03));

            if (data.vertical_velocity_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member04", data.vertical_velocity_500hPa_member04));

            if (data.vertical_velocity_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member05", data.vertical_velocity_500hPa_member05));

            if (data.vertical_velocity_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member06", data.vertical_velocity_500hPa_member06));

            if (data.vertical_velocity_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member07", data.vertical_velocity_500hPa_member07));

            if (data.vertical_velocity_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member08", data.vertical_velocity_500hPa_member08));

            if (data.vertical_velocity_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member09", data.vertical_velocity_500hPa_member09));

            if (data.vertical_velocity_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member10", data.vertical_velocity_500hPa_member10));

            if (data.vertical_velocity_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member11", data.vertical_velocity_500hPa_member11));

            if (data.vertical_velocity_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member12", data.vertical_velocity_500hPa_member12));

            if (data.vertical_velocity_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member13", data.vertical_velocity_500hPa_member13));

            if (data.vertical_velocity_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member14", data.vertical_velocity_500hPa_member14));

            if (data.vertical_velocity_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member15", data.vertical_velocity_500hPa_member15));

            if (data.vertical_velocity_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member16", data.vertical_velocity_500hPa_member16));

            if (data.vertical_velocity_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member17", data.vertical_velocity_500hPa_member17));

            if (data.vertical_velocity_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member18", data.vertical_velocity_500hPa_member18));

            if (data.vertical_velocity_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member19", data.vertical_velocity_500hPa_member19));

            if (data.vertical_velocity_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member20", data.vertical_velocity_500hPa_member20));

            if (data.vertical_velocity_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member21", data.vertical_velocity_500hPa_member21));

            if (data.vertical_velocity_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member22", data.vertical_velocity_500hPa_member22));

            if (data.vertical_velocity_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member23", data.vertical_velocity_500hPa_member23));

            if (data.vertical_velocity_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member24", data.vertical_velocity_500hPa_member24));

            if (data.vertical_velocity_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member25", data.vertical_velocity_500hPa_member25));

            if (data.vertical_velocity_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member26", data.vertical_velocity_500hPa_member26));

            if (data.vertical_velocity_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member27", data.vertical_velocity_500hPa_member27));

            if (data.vertical_velocity_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member28", data.vertical_velocity_500hPa_member28));

            if (data.vertical_velocity_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member29", data.vertical_velocity_500hPa_member29));

            if (data.vertical_velocity_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_500hPa_member30", data.vertical_velocity_500hPa_member30));

            if (data.vertical_velocity_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa", data.vertical_velocity_400hPa));

            if (data.vertical_velocity_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member01", data.vertical_velocity_400hPa_member01));

            if (data.vertical_velocity_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member02", data.vertical_velocity_400hPa_member02));

            if (data.vertical_velocity_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member03", data.vertical_velocity_400hPa_member03));

            if (data.vertical_velocity_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member04", data.vertical_velocity_400hPa_member04));

            if (data.vertical_velocity_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member05", data.vertical_velocity_400hPa_member05));

            if (data.vertical_velocity_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member06", data.vertical_velocity_400hPa_member06));

            if (data.vertical_velocity_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member07", data.vertical_velocity_400hPa_member07));

            if (data.vertical_velocity_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member08", data.vertical_velocity_400hPa_member08));

            if (data.vertical_velocity_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member09", data.vertical_velocity_400hPa_member09));

            if (data.vertical_velocity_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member10", data.vertical_velocity_400hPa_member10));

            if (data.vertical_velocity_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member11", data.vertical_velocity_400hPa_member11));

            if (data.vertical_velocity_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member12", data.vertical_velocity_400hPa_member12));

            if (data.vertical_velocity_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member13", data.vertical_velocity_400hPa_member13));

            if (data.vertical_velocity_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member14", data.vertical_velocity_400hPa_member14));

            if (data.vertical_velocity_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member15", data.vertical_velocity_400hPa_member15));

            if (data.vertical_velocity_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member16", data.vertical_velocity_400hPa_member16));

            if (data.vertical_velocity_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member17", data.vertical_velocity_400hPa_member17));

            if (data.vertical_velocity_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member18", data.vertical_velocity_400hPa_member18));

            if (data.vertical_velocity_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member19", data.vertical_velocity_400hPa_member19));

            if (data.vertical_velocity_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member20", data.vertical_velocity_400hPa_member20));

            if (data.vertical_velocity_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member21", data.vertical_velocity_400hPa_member21));

            if (data.vertical_velocity_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member22", data.vertical_velocity_400hPa_member22));

            if (data.vertical_velocity_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member23", data.vertical_velocity_400hPa_member23));

            if (data.vertical_velocity_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member24", data.vertical_velocity_400hPa_member24));

            if (data.vertical_velocity_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member25", data.vertical_velocity_400hPa_member25));

            if (data.vertical_velocity_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member26", data.vertical_velocity_400hPa_member26));

            if (data.vertical_velocity_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member27", data.vertical_velocity_400hPa_member27));

            if (data.vertical_velocity_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member28", data.vertical_velocity_400hPa_member28));

            if (data.vertical_velocity_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member29", data.vertical_velocity_400hPa_member29));

            if (data.vertical_velocity_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_400hPa_member30", data.vertical_velocity_400hPa_member30));

            if (data.vertical_velocity_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa", data.vertical_velocity_300hPa));

            if (data.vertical_velocity_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member01", data.vertical_velocity_300hPa_member01));

            if (data.vertical_velocity_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member02", data.vertical_velocity_300hPa_member02));

            if (data.vertical_velocity_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member03", data.vertical_velocity_300hPa_member03));

            if (data.vertical_velocity_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member04", data.vertical_velocity_300hPa_member04));

            if (data.vertical_velocity_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member05", data.vertical_velocity_300hPa_member05));

            if (data.vertical_velocity_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member06", data.vertical_velocity_300hPa_member06));

            if (data.vertical_velocity_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member07", data.vertical_velocity_300hPa_member07));

            if (data.vertical_velocity_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member08", data.vertical_velocity_300hPa_member08));

            if (data.vertical_velocity_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member09", data.vertical_velocity_300hPa_member09));

            if (data.vertical_velocity_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member10", data.vertical_velocity_300hPa_member10));

            if (data.vertical_velocity_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member11", data.vertical_velocity_300hPa_member11));

            if (data.vertical_velocity_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member12", data.vertical_velocity_300hPa_member12));

            if (data.vertical_velocity_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member13", data.vertical_velocity_300hPa_member13));

            if (data.vertical_velocity_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member14", data.vertical_velocity_300hPa_member14));

            if (data.vertical_velocity_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member15", data.vertical_velocity_300hPa_member15));

            if (data.vertical_velocity_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member16", data.vertical_velocity_300hPa_member16));

            if (data.vertical_velocity_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member17", data.vertical_velocity_300hPa_member17));

            if (data.vertical_velocity_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member18", data.vertical_velocity_300hPa_member18));

            if (data.vertical_velocity_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member19", data.vertical_velocity_300hPa_member19));

            if (data.vertical_velocity_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member20", data.vertical_velocity_300hPa_member20));

            if (data.vertical_velocity_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member21", data.vertical_velocity_300hPa_member21));

            if (data.vertical_velocity_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member22", data.vertical_velocity_300hPa_member22));

            if (data.vertical_velocity_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member23", data.vertical_velocity_300hPa_member23));

            if (data.vertical_velocity_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member24", data.vertical_velocity_300hPa_member24));

            if (data.vertical_velocity_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member25", data.vertical_velocity_300hPa_member25));

            if (data.vertical_velocity_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member26", data.vertical_velocity_300hPa_member26));

            if (data.vertical_velocity_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member27", data.vertical_velocity_300hPa_member27));

            if (data.vertical_velocity_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member28", data.vertical_velocity_300hPa_member28));

            if (data.vertical_velocity_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member29", data.vertical_velocity_300hPa_member29));

            if (data.vertical_velocity_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_300hPa_member30", data.vertical_velocity_300hPa_member30));

            if (data.vertical_velocity_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa", data.vertical_velocity_250hPa));

            if (data.vertical_velocity_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member01", data.vertical_velocity_250hPa_member01));

            if (data.vertical_velocity_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member02", data.vertical_velocity_250hPa_member02));

            if (data.vertical_velocity_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member03", data.vertical_velocity_250hPa_member03));

            if (data.vertical_velocity_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member04", data.vertical_velocity_250hPa_member04));

            if (data.vertical_velocity_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member05", data.vertical_velocity_250hPa_member05));

            if (data.vertical_velocity_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member06", data.vertical_velocity_250hPa_member06));

            if (data.vertical_velocity_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member07", data.vertical_velocity_250hPa_member07));

            if (data.vertical_velocity_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member08", data.vertical_velocity_250hPa_member08));

            if (data.vertical_velocity_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member09", data.vertical_velocity_250hPa_member09));

            if (data.vertical_velocity_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member10", data.vertical_velocity_250hPa_member10));

            if (data.vertical_velocity_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member11", data.vertical_velocity_250hPa_member11));

            if (data.vertical_velocity_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member12", data.vertical_velocity_250hPa_member12));

            if (data.vertical_velocity_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member13", data.vertical_velocity_250hPa_member13));

            if (data.vertical_velocity_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member14", data.vertical_velocity_250hPa_member14));

            if (data.vertical_velocity_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member15", data.vertical_velocity_250hPa_member15));

            if (data.vertical_velocity_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member16", data.vertical_velocity_250hPa_member16));

            if (data.vertical_velocity_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member17", data.vertical_velocity_250hPa_member17));

            if (data.vertical_velocity_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member18", data.vertical_velocity_250hPa_member18));

            if (data.vertical_velocity_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member19", data.vertical_velocity_250hPa_member19));

            if (data.vertical_velocity_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member20", data.vertical_velocity_250hPa_member20));

            if (data.vertical_velocity_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member21", data.vertical_velocity_250hPa_member21));

            if (data.vertical_velocity_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member22", data.vertical_velocity_250hPa_member22));

            if (data.vertical_velocity_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member23", data.vertical_velocity_250hPa_member23));

            if (data.vertical_velocity_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member24", data.vertical_velocity_250hPa_member24));

            if (data.vertical_velocity_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member25", data.vertical_velocity_250hPa_member25));

            if (data.vertical_velocity_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member26", data.vertical_velocity_250hPa_member26));

            if (data.vertical_velocity_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member27", data.vertical_velocity_250hPa_member27));

            if (data.vertical_velocity_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member28", data.vertical_velocity_250hPa_member28));

            if (data.vertical_velocity_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member29", data.vertical_velocity_250hPa_member29));

            if (data.vertical_velocity_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_250hPa_member30", data.vertical_velocity_250hPa_member30));

            if (data.vertical_velocity_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa", data.vertical_velocity_200hPa));

            if (data.vertical_velocity_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member01", data.vertical_velocity_200hPa_member01));

            if (data.vertical_velocity_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member02", data.vertical_velocity_200hPa_member02));

            if (data.vertical_velocity_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member03", data.vertical_velocity_200hPa_member03));

            if (data.vertical_velocity_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member04", data.vertical_velocity_200hPa_member04));

            if (data.vertical_velocity_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member05", data.vertical_velocity_200hPa_member05));

            if (data.vertical_velocity_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member06", data.vertical_velocity_200hPa_member06));

            if (data.vertical_velocity_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member07", data.vertical_velocity_200hPa_member07));

            if (data.vertical_velocity_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member08", data.vertical_velocity_200hPa_member08));

            if (data.vertical_velocity_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member09", data.vertical_velocity_200hPa_member09));

            if (data.vertical_velocity_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member10", data.vertical_velocity_200hPa_member10));

            if (data.vertical_velocity_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member11", data.vertical_velocity_200hPa_member11));

            if (data.vertical_velocity_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member12", data.vertical_velocity_200hPa_member12));

            if (data.vertical_velocity_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member13", data.vertical_velocity_200hPa_member13));

            if (data.vertical_velocity_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member14", data.vertical_velocity_200hPa_member14));

            if (data.vertical_velocity_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member15", data.vertical_velocity_200hPa_member15));

            if (data.vertical_velocity_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member16", data.vertical_velocity_200hPa_member16));

            if (data.vertical_velocity_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member17", data.vertical_velocity_200hPa_member17));

            if (data.vertical_velocity_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member18", data.vertical_velocity_200hPa_member18));

            if (data.vertical_velocity_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member19", data.vertical_velocity_200hPa_member19));

            if (data.vertical_velocity_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member20", data.vertical_velocity_200hPa_member20));

            if (data.vertical_velocity_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member21", data.vertical_velocity_200hPa_member21));

            if (data.vertical_velocity_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member22", data.vertical_velocity_200hPa_member22));

            if (data.vertical_velocity_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member23", data.vertical_velocity_200hPa_member23));

            if (data.vertical_velocity_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member24", data.vertical_velocity_200hPa_member24));

            if (data.vertical_velocity_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member25", data.vertical_velocity_200hPa_member25));

            if (data.vertical_velocity_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member26", data.vertical_velocity_200hPa_member26));

            if (data.vertical_velocity_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member27", data.vertical_velocity_200hPa_member27));

            if (data.vertical_velocity_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member28", data.vertical_velocity_200hPa_member28));

            if (data.vertical_velocity_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member29", data.vertical_velocity_200hPa_member29));

            if (data.vertical_velocity_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_200hPa_member30", data.vertical_velocity_200hPa_member30));

            if (data.vertical_velocity_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa", data.vertical_velocity_150hPa));

            if (data.vertical_velocity_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member01", data.vertical_velocity_150hPa_member01));

            if (data.vertical_velocity_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member02", data.vertical_velocity_150hPa_member02));

            if (data.vertical_velocity_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member03", data.vertical_velocity_150hPa_member03));

            if (data.vertical_velocity_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member04", data.vertical_velocity_150hPa_member04));

            if (data.vertical_velocity_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member05", data.vertical_velocity_150hPa_member05));

            if (data.vertical_velocity_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member06", data.vertical_velocity_150hPa_member06));

            if (data.vertical_velocity_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member07", data.vertical_velocity_150hPa_member07));

            if (data.vertical_velocity_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member08", data.vertical_velocity_150hPa_member08));

            if (data.vertical_velocity_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member09", data.vertical_velocity_150hPa_member09));

            if (data.vertical_velocity_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member10", data.vertical_velocity_150hPa_member10));

            if (data.vertical_velocity_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member11", data.vertical_velocity_150hPa_member11));

            if (data.vertical_velocity_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member12", data.vertical_velocity_150hPa_member12));

            if (data.vertical_velocity_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member13", data.vertical_velocity_150hPa_member13));

            if (data.vertical_velocity_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member14", data.vertical_velocity_150hPa_member14));

            if (data.vertical_velocity_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member15", data.vertical_velocity_150hPa_member15));

            if (data.vertical_velocity_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member16", data.vertical_velocity_150hPa_member16));

            if (data.vertical_velocity_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member17", data.vertical_velocity_150hPa_member17));

            if (data.vertical_velocity_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member18", data.vertical_velocity_150hPa_member18));

            if (data.vertical_velocity_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member19", data.vertical_velocity_150hPa_member19));

            if (data.vertical_velocity_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member20", data.vertical_velocity_150hPa_member20));

            if (data.vertical_velocity_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member21", data.vertical_velocity_150hPa_member21));

            if (data.vertical_velocity_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member22", data.vertical_velocity_150hPa_member22));

            if (data.vertical_velocity_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member23", data.vertical_velocity_150hPa_member23));

            if (data.vertical_velocity_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member24", data.vertical_velocity_150hPa_member24));

            if (data.vertical_velocity_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member25", data.vertical_velocity_150hPa_member25));

            if (data.vertical_velocity_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member26", data.vertical_velocity_150hPa_member26));

            if (data.vertical_velocity_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member27", data.vertical_velocity_150hPa_member27));

            if (data.vertical_velocity_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member28", data.vertical_velocity_150hPa_member28));

            if (data.vertical_velocity_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member29", data.vertical_velocity_150hPa_member29));

            if (data.vertical_velocity_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_150hPa_member30", data.vertical_velocity_150hPa_member30));

            if (data.vertical_velocity_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa", data.vertical_velocity_100hPa));

            if (data.vertical_velocity_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member01", data.vertical_velocity_100hPa_member01));

            if (data.vertical_velocity_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member02", data.vertical_velocity_100hPa_member02));

            if (data.vertical_velocity_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member03", data.vertical_velocity_100hPa_member03));

            if (data.vertical_velocity_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member04", data.vertical_velocity_100hPa_member04));

            if (data.vertical_velocity_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member05", data.vertical_velocity_100hPa_member05));

            if (data.vertical_velocity_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member06", data.vertical_velocity_100hPa_member06));

            if (data.vertical_velocity_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member07", data.vertical_velocity_100hPa_member07));

            if (data.vertical_velocity_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member08", data.vertical_velocity_100hPa_member08));

            if (data.vertical_velocity_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member09", data.vertical_velocity_100hPa_member09));

            if (data.vertical_velocity_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member10", data.vertical_velocity_100hPa_member10));

            if (data.vertical_velocity_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member11", data.vertical_velocity_100hPa_member11));

            if (data.vertical_velocity_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member12", data.vertical_velocity_100hPa_member12));

            if (data.vertical_velocity_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member13", data.vertical_velocity_100hPa_member13));

            if (data.vertical_velocity_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member14", data.vertical_velocity_100hPa_member14));

            if (data.vertical_velocity_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member15", data.vertical_velocity_100hPa_member15));

            if (data.vertical_velocity_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member16", data.vertical_velocity_100hPa_member16));

            if (data.vertical_velocity_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member17", data.vertical_velocity_100hPa_member17));

            if (data.vertical_velocity_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member18", data.vertical_velocity_100hPa_member18));

            if (data.vertical_velocity_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member19", data.vertical_velocity_100hPa_member19));

            if (data.vertical_velocity_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member20", data.vertical_velocity_100hPa_member20));

            if (data.vertical_velocity_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member21", data.vertical_velocity_100hPa_member21));

            if (data.vertical_velocity_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member22", data.vertical_velocity_100hPa_member22));

            if (data.vertical_velocity_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member23", data.vertical_velocity_100hPa_member23));

            if (data.vertical_velocity_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member24", data.vertical_velocity_100hPa_member24));

            if (data.vertical_velocity_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member25", data.vertical_velocity_100hPa_member25));

            if (data.vertical_velocity_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member26", data.vertical_velocity_100hPa_member26));

            if (data.vertical_velocity_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member27", data.vertical_velocity_100hPa_member27));

            if (data.vertical_velocity_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member28", data.vertical_velocity_100hPa_member28));

            if (data.vertical_velocity_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member29", data.vertical_velocity_100hPa_member29));

            if (data.vertical_velocity_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_100hPa_member30", data.vertical_velocity_100hPa_member30));

            if (data.vertical_velocity_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa", data.vertical_velocity_50hPa));

            if (data.vertical_velocity_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member01", data.vertical_velocity_50hPa_member01));

            if (data.vertical_velocity_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member02", data.vertical_velocity_50hPa_member02));

            if (data.vertical_velocity_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member03", data.vertical_velocity_50hPa_member03));

            if (data.vertical_velocity_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member04", data.vertical_velocity_50hPa_member04));

            if (data.vertical_velocity_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member05", data.vertical_velocity_50hPa_member05));

            if (data.vertical_velocity_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member06", data.vertical_velocity_50hPa_member06));

            if (data.vertical_velocity_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member07", data.vertical_velocity_50hPa_member07));

            if (data.vertical_velocity_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member08", data.vertical_velocity_50hPa_member08));

            if (data.vertical_velocity_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member09", data.vertical_velocity_50hPa_member09));

            if (data.vertical_velocity_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member10", data.vertical_velocity_50hPa_member10));

            if (data.vertical_velocity_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member11", data.vertical_velocity_50hPa_member11));

            if (data.vertical_velocity_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member12", data.vertical_velocity_50hPa_member12));

            if (data.vertical_velocity_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member13", data.vertical_velocity_50hPa_member13));

            if (data.vertical_velocity_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member14", data.vertical_velocity_50hPa_member14));

            if (data.vertical_velocity_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member15", data.vertical_velocity_50hPa_member15));

            if (data.vertical_velocity_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member16", data.vertical_velocity_50hPa_member16));

            if (data.vertical_velocity_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member17", data.vertical_velocity_50hPa_member17));

            if (data.vertical_velocity_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member18", data.vertical_velocity_50hPa_member18));

            if (data.vertical_velocity_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member19", data.vertical_velocity_50hPa_member19));

            if (data.vertical_velocity_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member20", data.vertical_velocity_50hPa_member20));

            if (data.vertical_velocity_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member21", data.vertical_velocity_50hPa_member21));

            if (data.vertical_velocity_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member22", data.vertical_velocity_50hPa_member22));

            if (data.vertical_velocity_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member23", data.vertical_velocity_50hPa_member23));

            if (data.vertical_velocity_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member24", data.vertical_velocity_50hPa_member24));

            if (data.vertical_velocity_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member25", data.vertical_velocity_50hPa_member25));

            if (data.vertical_velocity_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member26", data.vertical_velocity_50hPa_member26));

            if (data.vertical_velocity_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member27", data.vertical_velocity_50hPa_member27));

            if (data.vertical_velocity_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member28", data.vertical_velocity_50hPa_member28));

            if (data.vertical_velocity_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member29", data.vertical_velocity_50hPa_member29));

            if (data.vertical_velocity_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vertical_velocity_50hPa_member30", data.vertical_velocity_50hPa_member30));

            if (data.geopotential_height_1000hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa", data.geopotential_height_1000hPa));

            if (data.geopotential_height_1000hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member01", data.geopotential_height_1000hPa_member01));

            if (data.geopotential_height_1000hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member02", data.geopotential_height_1000hPa_member02));

            if (data.geopotential_height_1000hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member03", data.geopotential_height_1000hPa_member03));

            if (data.geopotential_height_1000hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member04", data.geopotential_height_1000hPa_member04));

            if (data.geopotential_height_1000hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member05", data.geopotential_height_1000hPa_member05));

            if (data.geopotential_height_1000hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member06", data.geopotential_height_1000hPa_member06));

            if (data.geopotential_height_1000hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member07", data.geopotential_height_1000hPa_member07));

            if (data.geopotential_height_1000hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member08", data.geopotential_height_1000hPa_member08));

            if (data.geopotential_height_1000hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member09", data.geopotential_height_1000hPa_member09));

            if (data.geopotential_height_1000hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member10", data.geopotential_height_1000hPa_member10));

            if (data.geopotential_height_1000hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member11", data.geopotential_height_1000hPa_member11));

            if (data.geopotential_height_1000hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member12", data.geopotential_height_1000hPa_member12));

            if (data.geopotential_height_1000hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member13", data.geopotential_height_1000hPa_member13));

            if (data.geopotential_height_1000hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member14", data.geopotential_height_1000hPa_member14));

            if (data.geopotential_height_1000hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member15", data.geopotential_height_1000hPa_member15));

            if (data.geopotential_height_1000hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member16", data.geopotential_height_1000hPa_member16));

            if (data.geopotential_height_1000hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member17", data.geopotential_height_1000hPa_member17));

            if (data.geopotential_height_1000hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member18", data.geopotential_height_1000hPa_member18));

            if (data.geopotential_height_1000hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member19", data.geopotential_height_1000hPa_member19));

            if (data.geopotential_height_1000hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member20", data.geopotential_height_1000hPa_member20));

            if (data.geopotential_height_1000hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member21", data.geopotential_height_1000hPa_member21));

            if (data.geopotential_height_1000hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member22", data.geopotential_height_1000hPa_member22));

            if (data.geopotential_height_1000hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member23", data.geopotential_height_1000hPa_member23));

            if (data.geopotential_height_1000hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member24", data.geopotential_height_1000hPa_member24));

            if (data.geopotential_height_1000hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member25", data.geopotential_height_1000hPa_member25));

            if (data.geopotential_height_1000hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member26", data.geopotential_height_1000hPa_member26));

            if (data.geopotential_height_1000hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member27", data.geopotential_height_1000hPa_member27));

            if (data.geopotential_height_1000hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member28", data.geopotential_height_1000hPa_member28));

            if (data.geopotential_height_1000hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member29", data.geopotential_height_1000hPa_member29));

            if (data.geopotential_height_1000hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_1000hPa_member30", data.geopotential_height_1000hPa_member30));

            if (data.geopotential_height_925hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa", data.geopotential_height_925hPa));

            if (data.geopotential_height_925hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member01", data.geopotential_height_925hPa_member01));

            if (data.geopotential_height_925hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member02", data.geopotential_height_925hPa_member02));

            if (data.geopotential_height_925hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member03", data.geopotential_height_925hPa_member03));

            if (data.geopotential_height_925hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member04", data.geopotential_height_925hPa_member04));

            if (data.geopotential_height_925hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member05", data.geopotential_height_925hPa_member05));

            if (data.geopotential_height_925hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member06", data.geopotential_height_925hPa_member06));

            if (data.geopotential_height_925hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member07", data.geopotential_height_925hPa_member07));

            if (data.geopotential_height_925hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member08", data.geopotential_height_925hPa_member08));

            if (data.geopotential_height_925hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member09", data.geopotential_height_925hPa_member09));

            if (data.geopotential_height_925hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member10", data.geopotential_height_925hPa_member10));

            if (data.geopotential_height_925hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member11", data.geopotential_height_925hPa_member11));

            if (data.geopotential_height_925hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member12", data.geopotential_height_925hPa_member12));

            if (data.geopotential_height_925hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member13", data.geopotential_height_925hPa_member13));

            if (data.geopotential_height_925hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member14", data.geopotential_height_925hPa_member14));

            if (data.geopotential_height_925hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member15", data.geopotential_height_925hPa_member15));

            if (data.geopotential_height_925hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member16", data.geopotential_height_925hPa_member16));

            if (data.geopotential_height_925hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member17", data.geopotential_height_925hPa_member17));

            if (data.geopotential_height_925hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member18", data.geopotential_height_925hPa_member18));

            if (data.geopotential_height_925hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member19", data.geopotential_height_925hPa_member19));

            if (data.geopotential_height_925hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member20", data.geopotential_height_925hPa_member20));

            if (data.geopotential_height_925hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member21", data.geopotential_height_925hPa_member21));

            if (data.geopotential_height_925hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member22", data.geopotential_height_925hPa_member22));

            if (data.geopotential_height_925hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member23", data.geopotential_height_925hPa_member23));

            if (data.geopotential_height_925hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member24", data.geopotential_height_925hPa_member24));

            if (data.geopotential_height_925hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member25", data.geopotential_height_925hPa_member25));

            if (data.geopotential_height_925hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member26", data.geopotential_height_925hPa_member26));

            if (data.geopotential_height_925hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member27", data.geopotential_height_925hPa_member27));

            if (data.geopotential_height_925hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member28", data.geopotential_height_925hPa_member28));

            if (data.geopotential_height_925hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member29", data.geopotential_height_925hPa_member29));

            if (data.geopotential_height_925hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_925hPa_member30", data.geopotential_height_925hPa_member30));

            if (data.geopotential_height_850hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa", data.geopotential_height_850hPa));

            if (data.geopotential_height_850hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member01", data.geopotential_height_850hPa_member01));

            if (data.geopotential_height_850hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member02", data.geopotential_height_850hPa_member02));

            if (data.geopotential_height_850hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member03", data.geopotential_height_850hPa_member03));

            if (data.geopotential_height_850hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member04", data.geopotential_height_850hPa_member04));

            if (data.geopotential_height_850hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member05", data.geopotential_height_850hPa_member05));

            if (data.geopotential_height_850hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member06", data.geopotential_height_850hPa_member06));

            if (data.geopotential_height_850hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member07", data.geopotential_height_850hPa_member07));

            if (data.geopotential_height_850hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member08", data.geopotential_height_850hPa_member08));

            if (data.geopotential_height_850hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member09", data.geopotential_height_850hPa_member09));

            if (data.geopotential_height_850hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member10", data.geopotential_height_850hPa_member10));

            if (data.geopotential_height_850hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member11", data.geopotential_height_850hPa_member11));

            if (data.geopotential_height_850hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member12", data.geopotential_height_850hPa_member12));

            if (data.geopotential_height_850hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member13", data.geopotential_height_850hPa_member13));

            if (data.geopotential_height_850hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member14", data.geopotential_height_850hPa_member14));

            if (data.geopotential_height_850hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member15", data.geopotential_height_850hPa_member15));

            if (data.geopotential_height_850hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member16", data.geopotential_height_850hPa_member16));

            if (data.geopotential_height_850hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member17", data.geopotential_height_850hPa_member17));

            if (data.geopotential_height_850hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member18", data.geopotential_height_850hPa_member18));

            if (data.geopotential_height_850hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member19", data.geopotential_height_850hPa_member19));

            if (data.geopotential_height_850hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member20", data.geopotential_height_850hPa_member20));

            if (data.geopotential_height_850hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member21", data.geopotential_height_850hPa_member21));

            if (data.geopotential_height_850hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member22", data.geopotential_height_850hPa_member22));

            if (data.geopotential_height_850hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member23", data.geopotential_height_850hPa_member23));

            if (data.geopotential_height_850hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member24", data.geopotential_height_850hPa_member24));

            if (data.geopotential_height_850hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member25", data.geopotential_height_850hPa_member25));

            if (data.geopotential_height_850hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member26", data.geopotential_height_850hPa_member26));

            if (data.geopotential_height_850hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member27", data.geopotential_height_850hPa_member27));

            if (data.geopotential_height_850hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member28", data.geopotential_height_850hPa_member28));

            if (data.geopotential_height_850hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member29", data.geopotential_height_850hPa_member29));

            if (data.geopotential_height_850hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_850hPa_member30", data.geopotential_height_850hPa_member30));

            if (data.geopotential_height_700hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa", data.geopotential_height_700hPa));

            if (data.geopotential_height_700hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member01", data.geopotential_height_700hPa_member01));

            if (data.geopotential_height_700hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member02", data.geopotential_height_700hPa_member02));

            if (data.geopotential_height_700hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member03", data.geopotential_height_700hPa_member03));

            if (data.geopotential_height_700hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member04", data.geopotential_height_700hPa_member04));

            if (data.geopotential_height_700hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member05", data.geopotential_height_700hPa_member05));

            if (data.geopotential_height_700hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member06", data.geopotential_height_700hPa_member06));

            if (data.geopotential_height_700hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member07", data.geopotential_height_700hPa_member07));

            if (data.geopotential_height_700hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member08", data.geopotential_height_700hPa_member08));

            if (data.geopotential_height_700hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member09", data.geopotential_height_700hPa_member09));

            if (data.geopotential_height_700hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member10", data.geopotential_height_700hPa_member10));

            if (data.geopotential_height_700hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member11", data.geopotential_height_700hPa_member11));

            if (data.geopotential_height_700hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member12", data.geopotential_height_700hPa_member12));

            if (data.geopotential_height_700hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member13", data.geopotential_height_700hPa_member13));

            if (data.geopotential_height_700hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member14", data.geopotential_height_700hPa_member14));

            if (data.geopotential_height_700hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member15", data.geopotential_height_700hPa_member15));

            if (data.geopotential_height_700hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member16", data.geopotential_height_700hPa_member16));

            if (data.geopotential_height_700hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member17", data.geopotential_height_700hPa_member17));

            if (data.geopotential_height_700hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member18", data.geopotential_height_700hPa_member18));

            if (data.geopotential_height_700hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member19", data.geopotential_height_700hPa_member19));

            if (data.geopotential_height_700hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member20", data.geopotential_height_700hPa_member20));

            if (data.geopotential_height_700hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member21", data.geopotential_height_700hPa_member21));

            if (data.geopotential_height_700hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member22", data.geopotential_height_700hPa_member22));

            if (data.geopotential_height_700hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member23", data.geopotential_height_700hPa_member23));

            if (data.geopotential_height_700hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member24", data.geopotential_height_700hPa_member24));

            if (data.geopotential_height_700hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member25", data.geopotential_height_700hPa_member25));

            if (data.geopotential_height_700hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member26", data.geopotential_height_700hPa_member26));

            if (data.geopotential_height_700hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member27", data.geopotential_height_700hPa_member27));

            if (data.geopotential_height_700hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member28", data.geopotential_height_700hPa_member28));

            if (data.geopotential_height_700hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member29", data.geopotential_height_700hPa_member29));

            if (data.geopotential_height_700hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_700hPa_member30", data.geopotential_height_700hPa_member30));

            if (data.geopotential_height_600hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa", data.geopotential_height_600hPa));

            if (data.geopotential_height_600hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member01", data.geopotential_height_600hPa_member01));

            if (data.geopotential_height_600hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member02", data.geopotential_height_600hPa_member02));

            if (data.geopotential_height_600hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member03", data.geopotential_height_600hPa_member03));

            if (data.geopotential_height_600hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member04", data.geopotential_height_600hPa_member04));

            if (data.geopotential_height_600hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member05", data.geopotential_height_600hPa_member05));

            if (data.geopotential_height_600hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member06", data.geopotential_height_600hPa_member06));

            if (data.geopotential_height_600hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member07", data.geopotential_height_600hPa_member07));

            if (data.geopotential_height_600hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member08", data.geopotential_height_600hPa_member08));

            if (data.geopotential_height_600hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member09", data.geopotential_height_600hPa_member09));

            if (data.geopotential_height_600hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member10", data.geopotential_height_600hPa_member10));

            if (data.geopotential_height_600hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member11", data.geopotential_height_600hPa_member11));

            if (data.geopotential_height_600hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member12", data.geopotential_height_600hPa_member12));

            if (data.geopotential_height_600hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member13", data.geopotential_height_600hPa_member13));

            if (data.geopotential_height_600hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member14", data.geopotential_height_600hPa_member14));

            if (data.geopotential_height_600hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member15", data.geopotential_height_600hPa_member15));

            if (data.geopotential_height_600hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member16", data.geopotential_height_600hPa_member16));

            if (data.geopotential_height_600hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member17", data.geopotential_height_600hPa_member17));

            if (data.geopotential_height_600hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member18", data.geopotential_height_600hPa_member18));

            if (data.geopotential_height_600hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member19", data.geopotential_height_600hPa_member19));

            if (data.geopotential_height_600hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member20", data.geopotential_height_600hPa_member20));

            if (data.geopotential_height_600hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member21", data.geopotential_height_600hPa_member21));

            if (data.geopotential_height_600hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member22", data.geopotential_height_600hPa_member22));

            if (data.geopotential_height_600hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member23", data.geopotential_height_600hPa_member23));

            if (data.geopotential_height_600hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member24", data.geopotential_height_600hPa_member24));

            if (data.geopotential_height_600hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member25", data.geopotential_height_600hPa_member25));

            if (data.geopotential_height_600hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member26", data.geopotential_height_600hPa_member26));

            if (data.geopotential_height_600hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member27", data.geopotential_height_600hPa_member27));

            if (data.geopotential_height_600hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member28", data.geopotential_height_600hPa_member28));

            if (data.geopotential_height_600hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member29", data.geopotential_height_600hPa_member29));

            if (data.geopotential_height_600hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_600hPa_member30", data.geopotential_height_600hPa_member30));

            if (data.geopotential_height_500hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa", data.geopotential_height_500hPa));

            if (data.geopotential_height_500hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member01", data.geopotential_height_500hPa_member01));

            if (data.geopotential_height_500hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member02", data.geopotential_height_500hPa_member02));

            if (data.geopotential_height_500hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member03", data.geopotential_height_500hPa_member03));

            if (data.geopotential_height_500hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member04", data.geopotential_height_500hPa_member04));

            if (data.geopotential_height_500hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member05", data.geopotential_height_500hPa_member05));

            if (data.geopotential_height_500hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member06", data.geopotential_height_500hPa_member06));

            if (data.geopotential_height_500hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member07", data.geopotential_height_500hPa_member07));

            if (data.geopotential_height_500hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member08", data.geopotential_height_500hPa_member08));

            if (data.geopotential_height_500hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member09", data.geopotential_height_500hPa_member09));

            if (data.geopotential_height_500hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member10", data.geopotential_height_500hPa_member10));

            if (data.geopotential_height_500hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member11", data.geopotential_height_500hPa_member11));

            if (data.geopotential_height_500hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member12", data.geopotential_height_500hPa_member12));

            if (data.geopotential_height_500hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member13", data.geopotential_height_500hPa_member13));

            if (data.geopotential_height_500hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member14", data.geopotential_height_500hPa_member14));

            if (data.geopotential_height_500hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member15", data.geopotential_height_500hPa_member15));

            if (data.geopotential_height_500hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member16", data.geopotential_height_500hPa_member16));

            if (data.geopotential_height_500hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member17", data.geopotential_height_500hPa_member17));

            if (data.geopotential_height_500hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member18", data.geopotential_height_500hPa_member18));

            if (data.geopotential_height_500hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member19", data.geopotential_height_500hPa_member19));

            if (data.geopotential_height_500hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member20", data.geopotential_height_500hPa_member20));

            if (data.geopotential_height_500hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member21", data.geopotential_height_500hPa_member21));

            if (data.geopotential_height_500hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member22", data.geopotential_height_500hPa_member22));

            if (data.geopotential_height_500hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member23", data.geopotential_height_500hPa_member23));

            if (data.geopotential_height_500hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member24", data.geopotential_height_500hPa_member24));

            if (data.geopotential_height_500hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member25", data.geopotential_height_500hPa_member25));

            if (data.geopotential_height_500hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member26", data.geopotential_height_500hPa_member26));

            if (data.geopotential_height_500hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member27", data.geopotential_height_500hPa_member27));

            if (data.geopotential_height_500hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member28", data.geopotential_height_500hPa_member28));

            if (data.geopotential_height_500hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member29", data.geopotential_height_500hPa_member29));

            if (data.geopotential_height_500hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_500hPa_member30", data.geopotential_height_500hPa_member30));

            if (data.geopotential_height_400hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa", data.geopotential_height_400hPa));

            if (data.geopotential_height_400hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member01", data.geopotential_height_400hPa_member01));

            if (data.geopotential_height_400hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member02", data.geopotential_height_400hPa_member02));

            if (data.geopotential_height_400hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member03", data.geopotential_height_400hPa_member03));

            if (data.geopotential_height_400hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member04", data.geopotential_height_400hPa_member04));

            if (data.geopotential_height_400hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member05", data.geopotential_height_400hPa_member05));

            if (data.geopotential_height_400hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member06", data.geopotential_height_400hPa_member06));

            if (data.geopotential_height_400hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member07", data.geopotential_height_400hPa_member07));

            if (data.geopotential_height_400hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member08", data.geopotential_height_400hPa_member08));

            if (data.geopotential_height_400hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member09", data.geopotential_height_400hPa_member09));

            if (data.geopotential_height_400hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member10", data.geopotential_height_400hPa_member10));

            if (data.geopotential_height_400hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member11", data.geopotential_height_400hPa_member11));

            if (data.geopotential_height_400hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member12", data.geopotential_height_400hPa_member12));

            if (data.geopotential_height_400hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member13", data.geopotential_height_400hPa_member13));

            if (data.geopotential_height_400hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member14", data.geopotential_height_400hPa_member14));

            if (data.geopotential_height_400hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member15", data.geopotential_height_400hPa_member15));

            if (data.geopotential_height_400hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member16", data.geopotential_height_400hPa_member16));

            if (data.geopotential_height_400hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member17", data.geopotential_height_400hPa_member17));

            if (data.geopotential_height_400hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member18", data.geopotential_height_400hPa_member18));

            if (data.geopotential_height_400hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member19", data.geopotential_height_400hPa_member19));

            if (data.geopotential_height_400hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member20", data.geopotential_height_400hPa_member20));

            if (data.geopotential_height_400hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member21", data.geopotential_height_400hPa_member21));

            if (data.geopotential_height_400hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member22", data.geopotential_height_400hPa_member22));

            if (data.geopotential_height_400hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member23", data.geopotential_height_400hPa_member23));

            if (data.geopotential_height_400hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member24", data.geopotential_height_400hPa_member24));

            if (data.geopotential_height_400hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member25", data.geopotential_height_400hPa_member25));

            if (data.geopotential_height_400hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member26", data.geopotential_height_400hPa_member26));

            if (data.geopotential_height_400hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member27", data.geopotential_height_400hPa_member27));

            if (data.geopotential_height_400hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member28", data.geopotential_height_400hPa_member28));

            if (data.geopotential_height_400hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member29", data.geopotential_height_400hPa_member29));

            if (data.geopotential_height_400hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_400hPa_member30", data.geopotential_height_400hPa_member30));

            if (data.geopotential_height_300hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa", data.geopotential_height_300hPa));

            if (data.geopotential_height_300hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member01", data.geopotential_height_300hPa_member01));

            if (data.geopotential_height_300hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member02", data.geopotential_height_300hPa_member02));

            if (data.geopotential_height_300hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member03", data.geopotential_height_300hPa_member03));

            if (data.geopotential_height_300hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member04", data.geopotential_height_300hPa_member04));

            if (data.geopotential_height_300hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member05", data.geopotential_height_300hPa_member05));

            if (data.geopotential_height_300hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member06", data.geopotential_height_300hPa_member06));

            if (data.geopotential_height_300hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member07", data.geopotential_height_300hPa_member07));

            if (data.geopotential_height_300hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member08", data.geopotential_height_300hPa_member08));

            if (data.geopotential_height_300hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member09", data.geopotential_height_300hPa_member09));

            if (data.geopotential_height_300hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member10", data.geopotential_height_300hPa_member10));

            if (data.geopotential_height_300hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member11", data.geopotential_height_300hPa_member11));

            if (data.geopotential_height_300hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member12", data.geopotential_height_300hPa_member12));

            if (data.geopotential_height_300hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member13", data.geopotential_height_300hPa_member13));

            if (data.geopotential_height_300hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member14", data.geopotential_height_300hPa_member14));

            if (data.geopotential_height_300hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member15", data.geopotential_height_300hPa_member15));

            if (data.geopotential_height_300hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member16", data.geopotential_height_300hPa_member16));

            if (data.geopotential_height_300hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member17", data.geopotential_height_300hPa_member17));

            if (data.geopotential_height_300hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member18", data.geopotential_height_300hPa_member18));

            if (data.geopotential_height_300hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member19", data.geopotential_height_300hPa_member19));

            if (data.geopotential_height_300hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member20", data.geopotential_height_300hPa_member20));

            if (data.geopotential_height_300hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member21", data.geopotential_height_300hPa_member21));

            if (data.geopotential_height_300hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member22", data.geopotential_height_300hPa_member22));

            if (data.geopotential_height_300hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member23", data.geopotential_height_300hPa_member23));

            if (data.geopotential_height_300hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member24", data.geopotential_height_300hPa_member24));

            if (data.geopotential_height_300hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member25", data.geopotential_height_300hPa_member25));

            if (data.geopotential_height_300hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member26", data.geopotential_height_300hPa_member26));

            if (data.geopotential_height_300hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member27", data.geopotential_height_300hPa_member27));

            if (data.geopotential_height_300hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member28", data.geopotential_height_300hPa_member28));

            if (data.geopotential_height_300hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member29", data.geopotential_height_300hPa_member29));

            if (data.geopotential_height_300hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_300hPa_member30", data.geopotential_height_300hPa_member30));

            if (data.geopotential_height_250hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa", data.geopotential_height_250hPa));

            if (data.geopotential_height_250hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member01", data.geopotential_height_250hPa_member01));

            if (data.geopotential_height_250hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member02", data.geopotential_height_250hPa_member02));

            if (data.geopotential_height_250hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member03", data.geopotential_height_250hPa_member03));

            if (data.geopotential_height_250hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member04", data.geopotential_height_250hPa_member04));

            if (data.geopotential_height_250hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member05", data.geopotential_height_250hPa_member05));

            if (data.geopotential_height_250hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member06", data.geopotential_height_250hPa_member06));

            if (data.geopotential_height_250hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member07", data.geopotential_height_250hPa_member07));

            if (data.geopotential_height_250hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member08", data.geopotential_height_250hPa_member08));

            if (data.geopotential_height_250hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member09", data.geopotential_height_250hPa_member09));

            if (data.geopotential_height_250hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member10", data.geopotential_height_250hPa_member10));

            if (data.geopotential_height_250hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member11", data.geopotential_height_250hPa_member11));

            if (data.geopotential_height_250hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member12", data.geopotential_height_250hPa_member12));

            if (data.geopotential_height_250hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member13", data.geopotential_height_250hPa_member13));

            if (data.geopotential_height_250hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member14", data.geopotential_height_250hPa_member14));

            if (data.geopotential_height_250hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member15", data.geopotential_height_250hPa_member15));

            if (data.geopotential_height_250hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member16", data.geopotential_height_250hPa_member16));

            if (data.geopotential_height_250hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member17", data.geopotential_height_250hPa_member17));

            if (data.geopotential_height_250hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member18", data.geopotential_height_250hPa_member18));

            if (data.geopotential_height_250hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member19", data.geopotential_height_250hPa_member19));

            if (data.geopotential_height_250hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member20", data.geopotential_height_250hPa_member20));

            if (data.geopotential_height_250hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member21", data.geopotential_height_250hPa_member21));

            if (data.geopotential_height_250hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member22", data.geopotential_height_250hPa_member22));

            if (data.geopotential_height_250hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member23", data.geopotential_height_250hPa_member23));

            if (data.geopotential_height_250hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member24", data.geopotential_height_250hPa_member24));

            if (data.geopotential_height_250hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member25", data.geopotential_height_250hPa_member25));

            if (data.geopotential_height_250hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member26", data.geopotential_height_250hPa_member26));

            if (data.geopotential_height_250hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member27", data.geopotential_height_250hPa_member27));

            if (data.geopotential_height_250hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member28", data.geopotential_height_250hPa_member28));

            if (data.geopotential_height_250hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member29", data.geopotential_height_250hPa_member29));

            if (data.geopotential_height_250hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_250hPa_member30", data.geopotential_height_250hPa_member30));

            if (data.geopotential_height_200hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa", data.geopotential_height_200hPa));

            if (data.geopotential_height_200hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member01", data.geopotential_height_200hPa_member01));

            if (data.geopotential_height_200hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member02", data.geopotential_height_200hPa_member02));

            if (data.geopotential_height_200hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member03", data.geopotential_height_200hPa_member03));

            if (data.geopotential_height_200hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member04", data.geopotential_height_200hPa_member04));

            if (data.geopotential_height_200hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member05", data.geopotential_height_200hPa_member05));

            if (data.geopotential_height_200hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member06", data.geopotential_height_200hPa_member06));

            if (data.geopotential_height_200hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member07", data.geopotential_height_200hPa_member07));

            if (data.geopotential_height_200hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member08", data.geopotential_height_200hPa_member08));

            if (data.geopotential_height_200hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member09", data.geopotential_height_200hPa_member09));

            if (data.geopotential_height_200hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member10", data.geopotential_height_200hPa_member10));

            if (data.geopotential_height_200hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member11", data.geopotential_height_200hPa_member11));

            if (data.geopotential_height_200hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member12", data.geopotential_height_200hPa_member12));

            if (data.geopotential_height_200hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member13", data.geopotential_height_200hPa_member13));

            if (data.geopotential_height_200hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member14", data.geopotential_height_200hPa_member14));

            if (data.geopotential_height_200hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member15", data.geopotential_height_200hPa_member15));

            if (data.geopotential_height_200hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member16", data.geopotential_height_200hPa_member16));

            if (data.geopotential_height_200hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member17", data.geopotential_height_200hPa_member17));

            if (data.geopotential_height_200hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member18", data.geopotential_height_200hPa_member18));

            if (data.geopotential_height_200hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member19", data.geopotential_height_200hPa_member19));

            if (data.geopotential_height_200hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member20", data.geopotential_height_200hPa_member20));

            if (data.geopotential_height_200hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member21", data.geopotential_height_200hPa_member21));

            if (data.geopotential_height_200hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member22", data.geopotential_height_200hPa_member22));

            if (data.geopotential_height_200hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member23", data.geopotential_height_200hPa_member23));

            if (data.geopotential_height_200hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member24", data.geopotential_height_200hPa_member24));

            if (data.geopotential_height_200hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member25", data.geopotential_height_200hPa_member25));

            if (data.geopotential_height_200hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member26", data.geopotential_height_200hPa_member26));

            if (data.geopotential_height_200hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member27", data.geopotential_height_200hPa_member27));

            if (data.geopotential_height_200hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member28", data.geopotential_height_200hPa_member28));

            if (data.geopotential_height_200hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member29", data.geopotential_height_200hPa_member29));

            if (data.geopotential_height_200hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_200hPa_member30", data.geopotential_height_200hPa_member30));

            if (data.geopotential_height_150hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa", data.geopotential_height_150hPa));

            if (data.geopotential_height_150hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member01", data.geopotential_height_150hPa_member01));

            if (data.geopotential_height_150hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member02", data.geopotential_height_150hPa_member02));

            if (data.geopotential_height_150hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member03", data.geopotential_height_150hPa_member03));

            if (data.geopotential_height_150hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member04", data.geopotential_height_150hPa_member04));

            if (data.geopotential_height_150hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member05", data.geopotential_height_150hPa_member05));

            if (data.geopotential_height_150hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member06", data.geopotential_height_150hPa_member06));

            if (data.geopotential_height_150hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member07", data.geopotential_height_150hPa_member07));

            if (data.geopotential_height_150hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member08", data.geopotential_height_150hPa_member08));

            if (data.geopotential_height_150hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member09", data.geopotential_height_150hPa_member09));

            if (data.geopotential_height_150hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member10", data.geopotential_height_150hPa_member10));

            if (data.geopotential_height_150hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member11", data.geopotential_height_150hPa_member11));

            if (data.geopotential_height_150hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member12", data.geopotential_height_150hPa_member12));

            if (data.geopotential_height_150hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member13", data.geopotential_height_150hPa_member13));

            if (data.geopotential_height_150hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member14", data.geopotential_height_150hPa_member14));

            if (data.geopotential_height_150hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member15", data.geopotential_height_150hPa_member15));

            if (data.geopotential_height_150hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member16", data.geopotential_height_150hPa_member16));

            if (data.geopotential_height_150hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member17", data.geopotential_height_150hPa_member17));

            if (data.geopotential_height_150hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member18", data.geopotential_height_150hPa_member18));

            if (data.geopotential_height_150hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member19", data.geopotential_height_150hPa_member19));

            if (data.geopotential_height_150hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member20", data.geopotential_height_150hPa_member20));

            if (data.geopotential_height_150hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member21", data.geopotential_height_150hPa_member21));

            if (data.geopotential_height_150hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member22", data.geopotential_height_150hPa_member22));

            if (data.geopotential_height_150hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member23", data.geopotential_height_150hPa_member23));

            if (data.geopotential_height_150hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member24", data.geopotential_height_150hPa_member24));

            if (data.geopotential_height_150hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member25", data.geopotential_height_150hPa_member25));

            if (data.geopotential_height_150hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member26", data.geopotential_height_150hPa_member26));

            if (data.geopotential_height_150hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member27", data.geopotential_height_150hPa_member27));

            if (data.geopotential_height_150hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member28", data.geopotential_height_150hPa_member28));

            if (data.geopotential_height_150hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member29", data.geopotential_height_150hPa_member29));

            if (data.geopotential_height_150hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_150hPa_member30", data.geopotential_height_150hPa_member30));

            if (data.geopotential_height_100hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa", data.geopotential_height_100hPa));

            if (data.geopotential_height_100hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member01", data.geopotential_height_100hPa_member01));

            if (data.geopotential_height_100hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member02", data.geopotential_height_100hPa_member02));

            if (data.geopotential_height_100hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member03", data.geopotential_height_100hPa_member03));

            if (data.geopotential_height_100hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member04", data.geopotential_height_100hPa_member04));

            if (data.geopotential_height_100hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member05", data.geopotential_height_100hPa_member05));

            if (data.geopotential_height_100hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member06", data.geopotential_height_100hPa_member06));

            if (data.geopotential_height_100hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member07", data.geopotential_height_100hPa_member07));

            if (data.geopotential_height_100hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member08", data.geopotential_height_100hPa_member08));

            if (data.geopotential_height_100hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member09", data.geopotential_height_100hPa_member09));

            if (data.geopotential_height_100hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member10", data.geopotential_height_100hPa_member10));

            if (data.geopotential_height_100hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member11", data.geopotential_height_100hPa_member11));

            if (data.geopotential_height_100hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member12", data.geopotential_height_100hPa_member12));

            if (data.geopotential_height_100hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member13", data.geopotential_height_100hPa_member13));

            if (data.geopotential_height_100hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member14", data.geopotential_height_100hPa_member14));

            if (data.geopotential_height_100hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member15", data.geopotential_height_100hPa_member15));

            if (data.geopotential_height_100hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member16", data.geopotential_height_100hPa_member16));

            if (data.geopotential_height_100hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member17", data.geopotential_height_100hPa_member17));

            if (data.geopotential_height_100hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member18", data.geopotential_height_100hPa_member18));

            if (data.geopotential_height_100hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member19", data.geopotential_height_100hPa_member19));

            if (data.geopotential_height_100hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member20", data.geopotential_height_100hPa_member20));

            if (data.geopotential_height_100hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member21", data.geopotential_height_100hPa_member21));

            if (data.geopotential_height_100hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member22", data.geopotential_height_100hPa_member22));

            if (data.geopotential_height_100hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member23", data.geopotential_height_100hPa_member23));

            if (data.geopotential_height_100hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member24", data.geopotential_height_100hPa_member24));

            if (data.geopotential_height_100hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member25", data.geopotential_height_100hPa_member25));

            if (data.geopotential_height_100hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member26", data.geopotential_height_100hPa_member26));

            if (data.geopotential_height_100hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member27", data.geopotential_height_100hPa_member27));

            if (data.geopotential_height_100hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member28", data.geopotential_height_100hPa_member28));

            if (data.geopotential_height_100hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member29", data.geopotential_height_100hPa_member29));

            if (data.geopotential_height_100hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_100hPa_member30", data.geopotential_height_100hPa_member30));

            if (data.geopotential_height_50hPa != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa", data.geopotential_height_50hPa));

            if (data.geopotential_height_50hPa_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member01", data.geopotential_height_50hPa_member01));

            if (data.geopotential_height_50hPa_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member02", data.geopotential_height_50hPa_member02));

            if (data.geopotential_height_50hPa_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member03", data.geopotential_height_50hPa_member03));

            if (data.geopotential_height_50hPa_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member04", data.geopotential_height_50hPa_member04));

            if (data.geopotential_height_50hPa_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member05", data.geopotential_height_50hPa_member05));

            if (data.geopotential_height_50hPa_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member06", data.geopotential_height_50hPa_member06));

            if (data.geopotential_height_50hPa_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member07", data.geopotential_height_50hPa_member07));

            if (data.geopotential_height_50hPa_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member08", data.geopotential_height_50hPa_member08));

            if (data.geopotential_height_50hPa_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member09", data.geopotential_height_50hPa_member09));

            if (data.geopotential_height_50hPa_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member10", data.geopotential_height_50hPa_member10));

            if (data.geopotential_height_50hPa_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member11", data.geopotential_height_50hPa_member11));

            if (data.geopotential_height_50hPa_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member12", data.geopotential_height_50hPa_member12));

            if (data.geopotential_height_50hPa_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member13", data.geopotential_height_50hPa_member13));

            if (data.geopotential_height_50hPa_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member14", data.geopotential_height_50hPa_member14));

            if (data.geopotential_height_50hPa_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member15", data.geopotential_height_50hPa_member15));

            if (data.geopotential_height_50hPa_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member16", data.geopotential_height_50hPa_member16));

            if (data.geopotential_height_50hPa_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member17", data.geopotential_height_50hPa_member17));

            if (data.geopotential_height_50hPa_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member18", data.geopotential_height_50hPa_member18));

            if (data.geopotential_height_50hPa_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member19", data.geopotential_height_50hPa_member19));

            if (data.geopotential_height_50hPa_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member20", data.geopotential_height_50hPa_member20));

            if (data.geopotential_height_50hPa_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member21", data.geopotential_height_50hPa_member21));

            if (data.geopotential_height_50hPa_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member22", data.geopotential_height_50hPa_member22));

            if (data.geopotential_height_50hPa_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member23", data.geopotential_height_50hPa_member23));

            if (data.geopotential_height_50hPa_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member24", data.geopotential_height_50hPa_member24));

            if (data.geopotential_height_50hPa_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member25", data.geopotential_height_50hPa_member25));

            if (data.geopotential_height_50hPa_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member26", data.geopotential_height_50hPa_member26));

            if (data.geopotential_height_50hPa_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member27", data.geopotential_height_50hPa_member27));

            if (data.geopotential_height_50hPa_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member28", data.geopotential_height_50hPa_member28));

            if (data.geopotential_height_50hPa_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member29", data.geopotential_height_50hPa_member29));

            if (data.geopotential_height_50hPa_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("geopotential_height_50hPa_member30", data.geopotential_height_50hPa_member30));

            return df;

        }

        private static string currentDirectory = DirectoryHelper.GetCurrentDirectory();

        public static async Task<DataFrame?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 7,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null,
                                                         bool toCsv = false,
                                                         string? filePath = null,
                                                         string? fileName = null)
        /*
         * This function is the client that retrieves and returns a NOAA/NCEP/GEFS ensemble mean point forecast for a specified point of lat/lon.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=7. The number of days to forecast, up to a maximum of 10 days.
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
                "cape"
                "precipitation" 
                "rain"
                "snow"  
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
                "dew_point_1000hPa" 
                "dew_point_925hPa" 
                "dew_point_850hPa" 
                "dew_point_700hPa" 
                "dew_point_600hPa" 
                "dew_point_500hPa" 
                "dew_point_400hPa" 
                "dew_point_300hPa" 
                "dew_point_250hPa" 
                "dew_point_200hPa" 
                "dew_point_150hPa" 
                "dew_point_100hPa" 
                "dew_point_50hPa" 
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
         * The GEFS Ensemble Mean Forecast for the specified latitude and longitude as a data object, or null if an error occurs.
         */

        {

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] {"temperature_2m" ,
                                    "relative_humidity_2m" ,
                                    "dew_point_2m" ,
                                    "apparent_temperature" ,
                                    "precipitation" ,
                                    "rain" ,
                                    "snow_depth" ,
                                    "snowfall" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "visibility" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_80m" ,
                                    "wind_speed_100m" ,
                                    "wind_speed_120m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_80m" ,
                                    "wind_direction_100m" ,
                                    "wind_direction_120m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_80m" ,
                                    "temperature_120m" ,
                                    "surface_temperature" ,
                                    "soil_temperature_0_to_10cm" ,
                                    "soil_temperature_10_to_40cm" ,
                                    "soil_temperature_40_to_100cm" ,
                                    "soil_temperature_100_to_200cm" ,
                                    "soil_moisture_0_to_10cm" ,
                                    "soil_moisture_10_to_40cm" ,
                                    "soil_moisture_40_to_100cm" ,
                                    "soil_moisture_100_to_200cm" ,
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
                                    "relative_humidity_700hPa" ,
                                    "relative_humidity_850hPa" ,
                                    "relative_humidity_600hPa" ,
                                    "relative_humidity_500hPa" ,
                                    "relative_humidity_400hPa" ,
                                    "relative_humidity_300hPa" ,
                                    "relative_humidity_250hPa" ,
                                    "relative_humidity_200hPa" ,
                                    "relative_humidity_150hPa" ,
                                    "relative_humidity_100hPa" ,
                                    "relative_humidity_50hPa" ,
                                    "dew_point_1000hPa" ,
                                    "dew_point_925hPa" ,
                                    "dew_point_850hPa" ,
                                    "dew_point_700hPa" ,
                                    "dew_point_600hPa" ,
                                    "dew_point_500hPa" ,
                                    "dew_point_400hPa" ,
                                    "dew_point_300hPa" ,
                                    "dew_point_200hPa" ,
                                    "dew_point_250hPa" ,
                                    "dew_point_150hPa" ,
                                    "dew_point_100hPa" ,
                                    "dew_point_50hPa" ,
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
                                    "wind_direction_925hPa" ,
                                    "wind_direction_1000hPa" ,
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

            if (days > 36)
            {
                Console.WriteLine("The 'days' parameter cannot exceed 36. Setting 'days' to 36.");
                days = 36;
            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            string url = $"https://ensemble-api.open-meteo.com/v1/ensemble?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=ncep_gefs_seamless&forecast_days={days}" +
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

            // Deserialize the "hourly" property into our hgefsParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<gefsParams>(hourlyWeatherElement.GetRawText());
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
                        fileName = $"GEFS_PointForecast_{latString}_{lonString}.csv";
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
                Console.WriteLine($"HGEFS Data Not Available At This Time");
                return null;
            }
        }
    }
}


