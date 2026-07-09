/*
 * (C) Eric J. Drewitz 2026
 */
using Microsoft.Data.Analysis;
using OpenMeteoApiNet.Utils.BuildDirectory;
using OpenMeteoApiNet.Utils.DataAccess;
using OpenMeteoApiNet.Utils.DataArchive;
using System.Text.Json;

namespace OpenMeteoApiNet.DWD.ICON_EPS
{
    public class iconEPSParams
    {
        public string[]? time { get; set; }
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
        public double?[]? temperature_2m_member31 { get; set; }
        public double?[]? temperature_2m_member32 { get; set; }
        public double?[]? temperature_2m_member33 { get; set; }
        public double?[]? temperature_2m_member34 { get; set; }
        public double?[]? temperature_2m_member35 { get; set; }
        public double?[]? temperature_2m_member36 { get; set; }
        public double?[]? temperature_2m_member37 { get; set; }
        public double?[]? temperature_2m_member38 { get; set; }
        public double?[]? temperature_2m_member39 { get; set; }
        public double?[]? relative_humidity_2m { get; set; }
        public double?[]? relative_humidity_2m_member01 { get; set; }
        public double?[]? relative_humidity_2m_member02 { get; set; }
        public double?[]? relative_humidity_2m_member03 { get; set; }
        public double?[]? relative_humidity_2m_member04 { get; set; }
        public double?[]? relative_humidity_2m_member05 { get; set; }
        public double?[]? relative_humidity_2m_member06 { get; set; }
        public double?[]? relative_humidity_2m_member07 { get; set; }
        public double?[]? relative_humidity_2m_member08 { get; set; }
        public double?[]? relative_humidity_2m_member09 { get; set; }
        public double?[]? relative_humidity_2m_member10 { get; set; }
        public double?[]? relative_humidity_2m_member11 { get; set; }
        public double?[]? relative_humidity_2m_member12 { get; set; }
        public double?[]? relative_humidity_2m_member13 { get; set; }
        public double?[]? relative_humidity_2m_member14 { get; set; }
        public double?[]? relative_humidity_2m_member15 { get; set; }
        public double?[]? relative_humidity_2m_member16 { get; set; }
        public double?[]? relative_humidity_2m_member17 { get; set; }
        public double?[]? relative_humidity_2m_member18 { get; set; }
        public double?[]? relative_humidity_2m_member19 { get; set; }
        public double?[]? relative_humidity_2m_member20 { get; set; }
        public double?[]? relative_humidity_2m_member21 { get; set; }
        public double?[]? relative_humidity_2m_member22 { get; set; }
        public double?[]? relative_humidity_2m_member23 { get; set; }
        public double?[]? relative_humidity_2m_member24 { get; set; }
        public double?[]? relative_humidity_2m_member25 { get; set; }
        public double?[]? relative_humidity_2m_member26 { get; set; }
        public double?[]? relative_humidity_2m_member27 { get; set; }
        public double?[]? relative_humidity_2m_member28 { get; set; }
        public double?[]? relative_humidity_2m_member29 { get; set; }
        public double?[]? relative_humidity_2m_member30 { get; set; }
        public double?[]? relative_humidity_2m_member31 { get; set; }
        public double?[]? relative_humidity_2m_member32 { get; set; }
        public double?[]? relative_humidity_2m_member33 { get; set; }
        public double?[]? relative_humidity_2m_member34 { get; set; }
        public double?[]? relative_humidity_2m_member35 { get; set; }
        public double?[]? relative_humidity_2m_member36 { get; set; }
        public double?[]? relative_humidity_2m_member37 { get; set; }
        public double?[]? relative_humidity_2m_member38 { get; set; }
        public double?[]? relative_humidity_2m_member39 { get; set; }
        public double?[]? dew_point_2m { get; set; }
        public double?[]? dew_point_2m_member01 { get; set; }
        public double?[]? dew_point_2m_member02 { get; set; }
        public double?[]? dew_point_2m_member03 { get; set; }
        public double?[]? dew_point_2m_member04 { get; set; }
        public double?[]? dew_point_2m_member05 { get; set; }
        public double?[]? dew_point_2m_member06 { get; set; }
        public double?[]? dew_point_2m_member07 { get; set; }
        public double?[]? dew_point_2m_member08 { get; set; }
        public double?[]? dew_point_2m_member09 { get; set; }
        public double?[]? dew_point_2m_member10 { get; set; }
        public double?[]? dew_point_2m_member11 { get; set; }
        public double?[]? dew_point_2m_member12 { get; set; }
        public double?[]? dew_point_2m_member13 { get; set; }
        public double?[]? dew_point_2m_member14 { get; set; }
        public double?[]? dew_point_2m_member15 { get; set; }
        public double?[]? dew_point_2m_member16 { get; set; }
        public double?[]? dew_point_2m_member17 { get; set; }
        public double?[]? dew_point_2m_member18 { get; set; }
        public double?[]? dew_point_2m_member19 { get; set; }
        public double?[]? dew_point_2m_member20 { get; set; }
        public double?[]? dew_point_2m_member21 { get; set; }
        public double?[]? dew_point_2m_member22 { get; set; }
        public double?[]? dew_point_2m_member23 { get; set; }
        public double?[]? dew_point_2m_member24 { get; set; }
        public double?[]? dew_point_2m_member25 { get; set; }
        public double?[]? dew_point_2m_member26 { get; set; }
        public double?[]? dew_point_2m_member27 { get; set; }
        public double?[]? dew_point_2m_member28 { get; set; }
        public double?[]? dew_point_2m_member29 { get; set; }
        public double?[]? dew_point_2m_member30 { get; set; }
        public double?[]? dew_point_2m_member31 { get; set; }
        public double?[]? dew_point_2m_member32 { get; set; }
        public double?[]? dew_point_2m_member33 { get; set; }
        public double?[]? dew_point_2m_member34 { get; set; }
        public double?[]? dew_point_2m_member35 { get; set; }
        public double?[]? dew_point_2m_member36 { get; set; }
        public double?[]? dew_point_2m_member37 { get; set; }
        public double?[]? dew_point_2m_member38 { get; set; }
        public double?[]? dew_point_2m_member39 { get; set; }
        public double?[]? apparent_temperature { get; set; }
        public double?[]? apparent_temperature_member01 { get; set; }
        public double?[]? apparent_temperature_member02 { get; set; }
        public double?[]? apparent_temperature_member03 { get; set; }
        public double?[]? apparent_temperature_member04 { get; set; }
        public double?[]? apparent_temperature_member05 { get; set; }
        public double?[]? apparent_temperature_member06 { get; set; }
        public double?[]? apparent_temperature_member07 { get; set; }
        public double?[]? apparent_temperature_member08 { get; set; }
        public double?[]? apparent_temperature_member09 { get; set; }
        public double?[]? apparent_temperature_member10 { get; set; }
        public double?[]? apparent_temperature_member11 { get; set; }
        public double?[]? apparent_temperature_member12 { get; set; }
        public double?[]? apparent_temperature_member13 { get; set; }
        public double?[]? apparent_temperature_member14 { get; set; }
        public double?[]? apparent_temperature_member15 { get; set; }
        public double?[]? apparent_temperature_member16 { get; set; }
        public double?[]? apparent_temperature_member17 { get; set; }
        public double?[]? apparent_temperature_member18 { get; set; }
        public double?[]? apparent_temperature_member19 { get; set; }
        public double?[]? apparent_temperature_member20 { get; set; }
        public double?[]? apparent_temperature_member21 { get; set; }
        public double?[]? apparent_temperature_member22 { get; set; }
        public double?[]? apparent_temperature_member23 { get; set; }
        public double?[]? apparent_temperature_member24 { get; set; }
        public double?[]? apparent_temperature_member25 { get; set; }
        public double?[]? apparent_temperature_member26 { get; set; }
        public double?[]? apparent_temperature_member27 { get; set; }
        public double?[]? apparent_temperature_member28 { get; set; }
        public double?[]? apparent_temperature_member29 { get; set; }
        public double?[]? apparent_temperature_member30 { get; set; }
        public double?[]? apparent_temperature_member31 { get; set; }
        public double?[]? apparent_temperature_member32 { get; set; }
        public double?[]? apparent_temperature_member33 { get; set; }
        public double?[]? apparent_temperature_member34 { get; set; }
        public double?[]? apparent_temperature_member35 { get; set; }
        public double?[]? apparent_temperature_member36 { get; set; }
        public double?[]? apparent_temperature_member37 { get; set; }
        public double?[]? apparent_temperature_member38 { get; set; }
        public double?[]? apparent_temperature_member39 { get; set; }
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
        public double?[]? precipitation_member31 { get; set; }
        public double?[]? precipitation_member32 { get; set; }
        public double?[]? precipitation_member33 { get; set; }
        public double?[]? precipitation_member34 { get; set; }
        public double?[]? precipitation_member35 { get; set; }
        public double?[]? precipitation_member36 { get; set; }
        public double?[]? precipitation_member37 { get; set; }
        public double?[]? precipitation_member38 { get; set; }
        public double?[]? precipitation_member39 { get; set; }
        public double?[]? rain { get; set; }
        public double?[]? rain_member01 { get; set; }
        public double?[]? rain_member02 { get; set; }
        public double?[]? rain_member03 { get; set; }
        public double?[]? rain_member04 { get; set; }
        public double?[]? rain_member05 { get; set; }
        public double?[]? rain_member06 { get; set; }
        public double?[]? rain_member07 { get; set; }
        public double?[]? rain_member08 { get; set; }
        public double?[]? rain_member09 { get; set; }
        public double?[]? rain_member10 { get; set; }
        public double?[]? rain_member11 { get; set; }
        public double?[]? rain_member12 { get; set; }
        public double?[]? rain_member13 { get; set; }
        public double?[]? rain_member14 { get; set; }
        public double?[]? rain_member15 { get; set; }
        public double?[]? rain_member16 { get; set; }
        public double?[]? rain_member17 { get; set; }
        public double?[]? rain_member18 { get; set; }
        public double?[]? rain_member19 { get; set; }
        public double?[]? rain_member20 { get; set; }
        public double?[]? rain_member21 { get; set; }
        public double?[]? rain_member22 { get; set; }
        public double?[]? rain_member23 { get; set; }
        public double?[]? rain_member24 { get; set; }
        public double?[]? rain_member25 { get; set; }
        public double?[]? rain_member26 { get; set; }
        public double?[]? rain_member27 { get; set; }
        public double?[]? rain_member28 { get; set; }
        public double?[]? rain_member29 { get; set; }
        public double?[]? rain_member30 { get; set; }
        public double?[]? rain_member31 { get; set; }
        public double?[]? rain_member32 { get; set; }
        public double?[]? rain_member33 { get; set; }
        public double?[]? rain_member34 { get; set; }
        public double?[]? rain_member35 { get; set; }
        public double?[]? rain_member36 { get; set; }
        public double?[]? rain_member37 { get; set; }
        public double?[]? rain_member38 { get; set; }
        public double?[]? rain_member39 { get; set; }
        public double?[]? snowfall { get; set; }
        public double?[]? snowfall_member01 { get; set; }
        public double?[]? snowfall_member02 { get; set; }
        public double?[]? snowfall_member03 { get; set; }
        public double?[]? snowfall_member04 { get; set; }
        public double?[]? snowfall_member05 { get; set; }
        public double?[]? snowfall_member06 { get; set; }
        public double?[]? snowfall_member07 { get; set; }
        public double?[]? snowfall_member08 { get; set; }
        public double?[]? snowfall_member09 { get; set; }
        public double?[]? snowfall_member10 { get; set; }
        public double?[]? snowfall_member11 { get; set; }
        public double?[]? snowfall_member12 { get; set; }
        public double?[]? snowfall_member13 { get; set; }
        public double?[]? snowfall_member14 { get; set; }
        public double?[]? snowfall_member15 { get; set; }
        public double?[]? snowfall_member16 { get; set; }
        public double?[]? snowfall_member17 { get; set; }
        public double?[]? snowfall_member18 { get; set; }
        public double?[]? snowfall_member19 { get; set; }
        public double?[]? snowfall_member20 { get; set; }
        public double?[]? snowfall_member21 { get; set; }
        public double?[]? snowfall_member22 { get; set; }
        public double?[]? snowfall_member23 { get; set; }
        public double?[]? snowfall_member24 { get; set; }
        public double?[]? snowfall_member25 { get; set; }
        public double?[]? snowfall_member26 { get; set; }
        public double?[]? snowfall_member27 { get; set; }
        public double?[]? snowfall_member28 { get; set; }
        public double?[]? snowfall_member29 { get; set; }
        public double?[]? snowfall_member30 { get; set; }
        public double?[]? snowfall_member31 { get; set; }
        public double?[]? snowfall_member32 { get; set; }
        public double?[]? snowfall_member33 { get; set; }
        public double?[]? snowfall_member34 { get; set; }
        public double?[]? snowfall_member35 { get; set; }
        public double?[]? snowfall_member36 { get; set; }
        public double?[]? snowfall_member37 { get; set; }
        public double?[]? snowfall_member38 { get; set; }
        public double?[]? snowfall_member39 { get; set; }
        public double?[]? weather_code { get; set; }
        public double?[]? weather_code_member01 { get; set; }
        public double?[]? weather_code_member02 { get; set; }
        public double?[]? weather_code_member03 { get; set; }
        public double?[]? weather_code_member04 { get; set; }
        public double?[]? weather_code_member05 { get; set; }
        public double?[]? weather_code_member06 { get; set; }
        public double?[]? weather_code_member07 { get; set; }
        public double?[]? weather_code_member08 { get; set; }
        public double?[]? weather_code_member09 { get; set; }
        public double?[]? weather_code_member10 { get; set; }
        public double?[]? weather_code_member11 { get; set; }
        public double?[]? weather_code_member12 { get; set; }
        public double?[]? weather_code_member13 { get; set; }
        public double?[]? weather_code_member14 { get; set; }
        public double?[]? weather_code_member15 { get; set; }
        public double?[]? weather_code_member16 { get; set; }
        public double?[]? weather_code_member17 { get; set; }
        public double?[]? weather_code_member18 { get; set; }
        public double?[]? weather_code_member19 { get; set; }
        public double?[]? weather_code_member20 { get; set; }
        public double?[]? weather_code_member21 { get; set; }
        public double?[]? weather_code_member22 { get; set; }
        public double?[]? weather_code_member23 { get; set; }
        public double?[]? weather_code_member24 { get; set; }
        public double?[]? weather_code_member25 { get; set; }
        public double?[]? weather_code_member26 { get; set; }
        public double?[]? weather_code_member27 { get; set; }
        public double?[]? weather_code_member28 { get; set; }
        public double?[]? weather_code_member29 { get; set; }
        public double?[]? weather_code_member30 { get; set; }
        public double?[]? weather_code_member31 { get; set; }
        public double?[]? weather_code_member32 { get; set; }
        public double?[]? weather_code_member33 { get; set; }
        public double?[]? weather_code_member34 { get; set; }
        public double?[]? weather_code_member35 { get; set; }
        public double?[]? weather_code_member36 { get; set; }
        public double?[]? weather_code_member37 { get; set; }
        public double?[]? weather_code_member38 { get; set; }
        public double?[]? weather_code_member39 { get; set; }
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
        public double?[]? pressure_msl_member31 { get; set; }
        public double?[]? pressure_msl_member32 { get; set; }
        public double?[]? pressure_msl_member33 { get; set; }
        public double?[]? pressure_msl_member34 { get; set; }
        public double?[]? pressure_msl_member35 { get; set; }
        public double?[]? pressure_msl_member36 { get; set; }
        public double?[]? pressure_msl_member37 { get; set; }
        public double?[]? pressure_msl_member38 { get; set; }
        public double?[]? pressure_msl_member39 { get; set; }
        public double?[]? surface_pressure { get; set; }
        public double?[]? surface_pressure_member01 { get; set; }
        public double?[]? surface_pressure_member02 { get; set; }
        public double?[]? surface_pressure_member03 { get; set; }
        public double?[]? surface_pressure_member04 { get; set; }
        public double?[]? surface_pressure_member05 { get; set; }
        public double?[]? surface_pressure_member06 { get; set; }
        public double?[]? surface_pressure_member07 { get; set; }
        public double?[]? surface_pressure_member08 { get; set; }
        public double?[]? surface_pressure_member09 { get; set; }
        public double?[]? surface_pressure_member10 { get; set; }
        public double?[]? surface_pressure_member11 { get; set; }
        public double?[]? surface_pressure_member12 { get; set; }
        public double?[]? surface_pressure_member13 { get; set; }
        public double?[]? surface_pressure_member14 { get; set; }
        public double?[]? surface_pressure_member15 { get; set; }
        public double?[]? surface_pressure_member16 { get; set; }
        public double?[]? surface_pressure_member17 { get; set; }
        public double?[]? surface_pressure_member18 { get; set; }
        public double?[]? surface_pressure_member19 { get; set; }
        public double?[]? surface_pressure_member20 { get; set; }
        public double?[]? surface_pressure_member21 { get; set; }
        public double?[]? surface_pressure_member22 { get; set; }
        public double?[]? surface_pressure_member23 { get; set; }
        public double?[]? surface_pressure_member24 { get; set; }
        public double?[]? surface_pressure_member25 { get; set; }
        public double?[]? surface_pressure_member26 { get; set; }
        public double?[]? surface_pressure_member27 { get; set; }
        public double?[]? surface_pressure_member28 { get; set; }
        public double?[]? surface_pressure_member29 { get; set; }
        public double?[]? surface_pressure_member30 { get; set; }
        public double?[]? surface_pressure_member31 { get; set; }
        public double?[]? surface_pressure_member32 { get; set; }
        public double?[]? surface_pressure_member33 { get; set; }
        public double?[]? surface_pressure_member34 { get; set; }
        public double?[]? surface_pressure_member35 { get; set; }
        public double?[]? surface_pressure_member36 { get; set; }
        public double?[]? surface_pressure_member37 { get; set; }
        public double?[]? surface_pressure_member38 { get; set; }
        public double?[]? surface_pressure_member39 { get; set; }
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
        public double?[]? cloud_cover_member31 { get; set; }
        public double?[]? cloud_cover_member32 { get; set; }
        public double?[]? cloud_cover_member33 { get; set; }
        public double?[]? cloud_cover_member34 { get; set; }
        public double?[]? cloud_cover_member35 { get; set; }
        public double?[]? cloud_cover_member36 { get; set; }
        public double?[]? cloud_cover_member37 { get; set; }
        public double?[]? cloud_cover_member38 { get; set; }
        public double?[]? cloud_cover_member39 { get; set; }
        public double?[]? et0_fao_evapotranspiration { get; set; }
        public double?[]? et0_fao_evapotranspiration_member01 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member02 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member03 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member04 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member05 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member06 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member07 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member08 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member09 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member10 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member11 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member12 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member13 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member14 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member15 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member16 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member17 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member18 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member19 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member20 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member21 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member22 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member23 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member24 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member25 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member26 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member27 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member28 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member29 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member30 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member31 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member32 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member33 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member34 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member35 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member36 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member37 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member38 { get; set; }
        public double?[]? et0_fao_evapotranspiration_member39 { get; set; }
        public double?[]? vapour_pressure_deficit { get; set; }
        public double?[]? vapour_pressure_deficit_member01 { get; set; }
        public double?[]? vapour_pressure_deficit_member02 { get; set; }
        public double?[]? vapour_pressure_deficit_member03 { get; set; }
        public double?[]? vapour_pressure_deficit_member04 { get; set; }
        public double?[]? vapour_pressure_deficit_member05 { get; set; }
        public double?[]? vapour_pressure_deficit_member06 { get; set; }
        public double?[]? vapour_pressure_deficit_member07 { get; set; }
        public double?[]? vapour_pressure_deficit_member08 { get; set; }
        public double?[]? vapour_pressure_deficit_member09 { get; set; }
        public double?[]? vapour_pressure_deficit_member10 { get; set; }
        public double?[]? vapour_pressure_deficit_member11 { get; set; }
        public double?[]? vapour_pressure_deficit_member12 { get; set; }
        public double?[]? vapour_pressure_deficit_member13 { get; set; }
        public double?[]? vapour_pressure_deficit_member14 { get; set; }
        public double?[]? vapour_pressure_deficit_member15 { get; set; }
        public double?[]? vapour_pressure_deficit_member16 { get; set; }
        public double?[]? vapour_pressure_deficit_member17 { get; set; }
        public double?[]? vapour_pressure_deficit_member18 { get; set; }
        public double?[]? vapour_pressure_deficit_member19 { get; set; }
        public double?[]? vapour_pressure_deficit_member20 { get; set; }
        public double?[]? vapour_pressure_deficit_member21 { get; set; }
        public double?[]? vapour_pressure_deficit_member22 { get; set; }
        public double?[]? vapour_pressure_deficit_member23 { get; set; }
        public double?[]? vapour_pressure_deficit_member24 { get; set; }
        public double?[]? vapour_pressure_deficit_member25 { get; set; }
        public double?[]? vapour_pressure_deficit_member26 { get; set; }
        public double?[]? vapour_pressure_deficit_member27 { get; set; }
        public double?[]? vapour_pressure_deficit_member28 { get; set; }
        public double?[]? vapour_pressure_deficit_member29 { get; set; }
        public double?[]? vapour_pressure_deficit_member30 { get; set; }
        public double?[]? vapour_pressure_deficit_member31 { get; set; }
        public double?[]? vapour_pressure_deficit_member32 { get; set; }
        public double?[]? vapour_pressure_deficit_member33 { get; set; }
        public double?[]? vapour_pressure_deficit_member34 { get; set; }
        public double?[]? vapour_pressure_deficit_member35 { get; set; }
        public double?[]? vapour_pressure_deficit_member36 { get; set; }
        public double?[]? vapour_pressure_deficit_member37 { get; set; }
        public double?[]? vapour_pressure_deficit_member38 { get; set; }
        public double?[]? vapour_pressure_deficit_member39 { get; set; }
        public double?[]? wind_speed_10m { get; set; }
        public double?[]? wind_speed_10m_member01 { get; set; }
        public double?[]? wind_speed_10m_member02 { get; set; }
        public double?[]? wind_speed_10m_member03 { get; set; }
        public double?[]? wind_speed_10m_member04 { get; set; }
        public double?[]? wind_speed_10m_member05 { get; set; }
        public double?[]? wind_speed_10m_member06 { get; set; }
        public double?[]? wind_speed_10m_member07 { get; set; }
        public double?[]? wind_speed_10m_member08 { get; set; }
        public double?[]? wind_speed_10m_member09 { get; set; }
        public double?[]? wind_speed_10m_member10 { get; set; }
        public double?[]? wind_speed_10m_member11 { get; set; }
        public double?[]? wind_speed_10m_member12 { get; set; }
        public double?[]? wind_speed_10m_member13 { get; set; }
        public double?[]? wind_speed_10m_member14 { get; set; }
        public double?[]? wind_speed_10m_member15 { get; set; }
        public double?[]? wind_speed_10m_member16 { get; set; }
        public double?[]? wind_speed_10m_member17 { get; set; }
        public double?[]? wind_speed_10m_member18 { get; set; }
        public double?[]? wind_speed_10m_member19 { get; set; }
        public double?[]? wind_speed_10m_member20 { get; set; }
        public double?[]? wind_speed_10m_member21 { get; set; }
        public double?[]? wind_speed_10m_member22 { get; set; }
        public double?[]? wind_speed_10m_member23 { get; set; }
        public double?[]? wind_speed_10m_member24 { get; set; }
        public double?[]? wind_speed_10m_member25 { get; set; }
        public double?[]? wind_speed_10m_member26 { get; set; }
        public double?[]? wind_speed_10m_member27 { get; set; }
        public double?[]? wind_speed_10m_member28 { get; set; }
        public double?[]? wind_speed_10m_member29 { get; set; }
        public double?[]? wind_speed_10m_member30 { get; set; }
        public double?[]? wind_speed_10m_member31 { get; set; }
        public double?[]? wind_speed_10m_member32 { get; set; }
        public double?[]? wind_speed_10m_member33 { get; set; }
        public double?[]? wind_speed_10m_member34 { get; set; }
        public double?[]? wind_speed_10m_member35 { get; set; }
        public double?[]? wind_speed_10m_member36 { get; set; }
        public double?[]? wind_speed_10m_member37 { get; set; }
        public double?[]? wind_speed_10m_member38 { get; set; }
        public double?[]? wind_speed_10m_member39 { get; set; }
        public double?[]? wind_speed_80m { get; set; }
        public double?[]? wind_speed_80m_member01 { get; set; }
        public double?[]? wind_speed_80m_member02 { get; set; }
        public double?[]? wind_speed_80m_member03 { get; set; }
        public double?[]? wind_speed_80m_member04 { get; set; }
        public double?[]? wind_speed_80m_member05 { get; set; }
        public double?[]? wind_speed_80m_member06 { get; set; }
        public double?[]? wind_speed_80m_member07 { get; set; }
        public double?[]? wind_speed_80m_member08 { get; set; }
        public double?[]? wind_speed_80m_member09 { get; set; }
        public double?[]? wind_speed_80m_member10 { get; set; }
        public double?[]? wind_speed_80m_member11 { get; set; }
        public double?[]? wind_speed_80m_member12 { get; set; }
        public double?[]? wind_speed_80m_member13 { get; set; }
        public double?[]? wind_speed_80m_member14 { get; set; }
        public double?[]? wind_speed_80m_member15 { get; set; }
        public double?[]? wind_speed_80m_member16 { get; set; }
        public double?[]? wind_speed_80m_member17 { get; set; }
        public double?[]? wind_speed_80m_member18 { get; set; }
        public double?[]? wind_speed_80m_member19 { get; set; }
        public double?[]? wind_speed_80m_member20 { get; set; }
        public double?[]? wind_speed_80m_member21 { get; set; }
        public double?[]? wind_speed_80m_member22 { get; set; }
        public double?[]? wind_speed_80m_member23 { get; set; }
        public double?[]? wind_speed_80m_member24 { get; set; }
        public double?[]? wind_speed_80m_member25 { get; set; }
        public double?[]? wind_speed_80m_member26 { get; set; }
        public double?[]? wind_speed_80m_member27 { get; set; }
        public double?[]? wind_speed_80m_member28 { get; set; }
        public double?[]? wind_speed_80m_member29 { get; set; }
        public double?[]? wind_speed_80m_member30 { get; set; }
        public double?[]? wind_speed_80m_member31 { get; set; }
        public double?[]? wind_speed_80m_member32 { get; set; }
        public double?[]? wind_speed_80m_member33 { get; set; }
        public double?[]? wind_speed_80m_member34 { get; set; }
        public double?[]? wind_speed_80m_member35 { get; set; }
        public double?[]? wind_speed_80m_member36 { get; set; }
        public double?[]? wind_speed_80m_member37 { get; set; }
        public double?[]? wind_speed_80m_member38 { get; set; }
        public double?[]? wind_speed_80m_member39 { get; set; }
        public double?[]? wind_direction_10m { get; set; }
        public double?[]? wind_direction_10m_member01 { get; set; }
        public double?[]? wind_direction_10m_member02 { get; set; }
        public double?[]? wind_direction_10m_member03 { get; set; }
        public double?[]? wind_direction_10m_member04 { get; set; }
        public double?[]? wind_direction_10m_member05 { get; set; }
        public double?[]? wind_direction_10m_member06 { get; set; }
        public double?[]? wind_direction_10m_member07 { get; set; }
        public double?[]? wind_direction_10m_member08 { get; set; }
        public double?[]? wind_direction_10m_member09 { get; set; }
        public double?[]? wind_direction_10m_member10 { get; set; }
        public double?[]? wind_direction_10m_member11 { get; set; }
        public double?[]? wind_direction_10m_member12 { get; set; }
        public double?[]? wind_direction_10m_member13 { get; set; }
        public double?[]? wind_direction_10m_member14 { get; set; }
        public double?[]? wind_direction_10m_member15 { get; set; }
        public double?[]? wind_direction_10m_member16 { get; set; }
        public double?[]? wind_direction_10m_member17 { get; set; }
        public double?[]? wind_direction_10m_member18 { get; set; }
        public double?[]? wind_direction_10m_member19 { get; set; }
        public double?[]? wind_direction_10m_member20 { get; set; }
        public double?[]? wind_direction_10m_member21 { get; set; }
        public double?[]? wind_direction_10m_member22 { get; set; }
        public double?[]? wind_direction_10m_member23 { get; set; }
        public double?[]? wind_direction_10m_member24 { get; set; }
        public double?[]? wind_direction_10m_member25 { get; set; }
        public double?[]? wind_direction_10m_member26 { get; set; }
        public double?[]? wind_direction_10m_member27 { get; set; }
        public double?[]? wind_direction_10m_member28 { get; set; }
        public double?[]? wind_direction_10m_member29 { get; set; }
        public double?[]? wind_direction_10m_member30 { get; set; }
        public double?[]? wind_direction_10m_member31 { get; set; }
        public double?[]? wind_direction_10m_member32 { get; set; }
        public double?[]? wind_direction_10m_member33 { get; set; }
        public double?[]? wind_direction_10m_member34 { get; set; }
        public double?[]? wind_direction_10m_member35 { get; set; }
        public double?[]? wind_direction_10m_member36 { get; set; }
        public double?[]? wind_direction_10m_member37 { get; set; }
        public double?[]? wind_direction_10m_member38 { get; set; }
        public double?[]? wind_direction_10m_member39 { get; set; }
        public double?[]? wind_direction_80m { get; set; }
        public double?[]? wind_direction_80m_member01 { get; set; }
        public double?[]? wind_direction_80m_member02 { get; set; }
        public double?[]? wind_direction_80m_member03 { get; set; }
        public double?[]? wind_direction_80m_member04 { get; set; }
        public double?[]? wind_direction_80m_member05 { get; set; }
        public double?[]? wind_direction_80m_member06 { get; set; }
        public double?[]? wind_direction_80m_member07 { get; set; }
        public double?[]? wind_direction_80m_member08 { get; set; }
        public double?[]? wind_direction_80m_member09 { get; set; }
        public double?[]? wind_direction_80m_member10 { get; set; }
        public double?[]? wind_direction_80m_member11 { get; set; }
        public double?[]? wind_direction_80m_member12 { get; set; }
        public double?[]? wind_direction_80m_member13 { get; set; }
        public double?[]? wind_direction_80m_member14 { get; set; }
        public double?[]? wind_direction_80m_member15 { get; set; }
        public double?[]? wind_direction_80m_member16 { get; set; }
        public double?[]? wind_direction_80m_member17 { get; set; }
        public double?[]? wind_direction_80m_member18 { get; set; }
        public double?[]? wind_direction_80m_member19 { get; set; }
        public double?[]? wind_direction_80m_member20 { get; set; }
        public double?[]? wind_direction_80m_member21 { get; set; }
        public double?[]? wind_direction_80m_member22 { get; set; }
        public double?[]? wind_direction_80m_member23 { get; set; }
        public double?[]? wind_direction_80m_member24 { get; set; }
        public double?[]? wind_direction_80m_member25 { get; set; }
        public double?[]? wind_direction_80m_member26 { get; set; }
        public double?[]? wind_direction_80m_member27 { get; set; }
        public double?[]? wind_direction_80m_member28 { get; set; }
        public double?[]? wind_direction_80m_member29 { get; set; }
        public double?[]? wind_direction_80m_member30 { get; set; }
        public double?[]? wind_direction_80m_member31 { get; set; }
        public double?[]? wind_direction_80m_member32 { get; set; }
        public double?[]? wind_direction_80m_member33 { get; set; }
        public double?[]? wind_direction_80m_member34 { get; set; }
        public double?[]? wind_direction_80m_member35 { get; set; }
        public double?[]? wind_direction_80m_member36 { get; set; }
        public double?[]? wind_direction_80m_member37 { get; set; }
        public double?[]? wind_direction_80m_member38 { get; set; }
        public double?[]? wind_direction_80m_member39 { get; set; }
        public double?[]? wind_gusts_10m { get; set; }
        public double?[]? wind_gusts_10m_member01 { get; set; }
        public double?[]? wind_gusts_10m_member02 { get; set; }
        public double?[]? wind_gusts_10m_member03 { get; set; }
        public double?[]? wind_gusts_10m_member04 { get; set; }
        public double?[]? wind_gusts_10m_member05 { get; set; }
        public double?[]? wind_gusts_10m_member06 { get; set; }
        public double?[]? wind_gusts_10m_member07 { get; set; }
        public double?[]? wind_gusts_10m_member08 { get; set; }
        public double?[]? wind_gusts_10m_member09 { get; set; }
        public double?[]? wind_gusts_10m_member10 { get; set; }
        public double?[]? wind_gusts_10m_member11 { get; set; }
        public double?[]? wind_gusts_10m_member12 { get; set; }
        public double?[]? wind_gusts_10m_member13 { get; set; }
        public double?[]? wind_gusts_10m_member14 { get; set; }
        public double?[]? wind_gusts_10m_member15 { get; set; }
        public double?[]? wind_gusts_10m_member16 { get; set; }
        public double?[]? wind_gusts_10m_member17 { get; set; }
        public double?[]? wind_gusts_10m_member18 { get; set; }
        public double?[]? wind_gusts_10m_member19 { get; set; }
        public double?[]? wind_gusts_10m_member20 { get; set; }
        public double?[]? wind_gusts_10m_member21 { get; set; }
        public double?[]? wind_gusts_10m_member22 { get; set; }
        public double?[]? wind_gusts_10m_member23 { get; set; }
        public double?[]? wind_gusts_10m_member24 { get; set; }
        public double?[]? wind_gusts_10m_member25 { get; set; }
        public double?[]? wind_gusts_10m_member26 { get; set; }
        public double?[]? wind_gusts_10m_member27 { get; set; }
        public double?[]? wind_gusts_10m_member28 { get; set; }
        public double?[]? wind_gusts_10m_member29 { get; set; }
        public double?[]? wind_gusts_10m_member30 { get; set; }
        public double?[]? wind_gusts_10m_member31 { get; set; }
        public double?[]? wind_gusts_10m_member32 { get; set; }
        public double?[]? wind_gusts_10m_member33 { get; set; }
        public double?[]? wind_gusts_10m_member34 { get; set; }
        public double?[]? wind_gusts_10m_member35 { get; set; }
        public double?[]? wind_gusts_10m_member36 { get; set; }
        public double?[]? wind_gusts_10m_member37 { get; set; }
        public double?[]? wind_gusts_10m_member38 { get; set; }
        public double?[]? wind_gusts_10m_member39 { get; set; }
        public double?[]? temperature_80m { get; set; }
        public double?[]? temperature_80m_member01 { get; set; }
        public double?[]? temperature_80m_member02 { get; set; }
        public double?[]? temperature_80m_member03 { get; set; }
        public double?[]? temperature_80m_member04 { get; set; }
        public double?[]? temperature_80m_member05 { get; set; }
        public double?[]? temperature_80m_member06 { get; set; }
        public double?[]? temperature_80m_member07 { get; set; }
        public double?[]? temperature_80m_member08 { get; set; }
        public double?[]? temperature_80m_member09 { get; set; }
        public double?[]? temperature_80m_member10 { get; set; }
        public double?[]? temperature_80m_member11 { get; set; }
        public double?[]? temperature_80m_member12 { get; set; }
        public double?[]? temperature_80m_member13 { get; set; }
        public double?[]? temperature_80m_member14 { get; set; }
        public double?[]? temperature_80m_member15 { get; set; }
        public double?[]? temperature_80m_member16 { get; set; }
        public double?[]? temperature_80m_member17 { get; set; }
        public double?[]? temperature_80m_member18 { get; set; }
        public double?[]? temperature_80m_member19 { get; set; }
        public double?[]? temperature_80m_member20 { get; set; }
        public double?[]? temperature_80m_member21 { get; set; }
        public double?[]? temperature_80m_member22 { get; set; }
        public double?[]? temperature_80m_member23 { get; set; }
        public double?[]? temperature_80m_member24 { get; set; }
        public double?[]? temperature_80m_member25 { get; set; }
        public double?[]? temperature_80m_member26 { get; set; }
        public double?[]? temperature_80m_member27 { get; set; }
        public double?[]? temperature_80m_member28 { get; set; }
        public double?[]? temperature_80m_member29 { get; set; }
        public double?[]? temperature_80m_member30 { get; set; }
        public double?[]? temperature_80m_member31 { get; set; }
        public double?[]? temperature_80m_member32 { get; set; }
        public double?[]? temperature_80m_member33 { get; set; }
        public double?[]? temperature_80m_member34 { get; set; }
        public double?[]? temperature_80m_member35 { get; set; }
        public double?[]? temperature_80m_member36 { get; set; }
        public double?[]? temperature_80m_member37 { get; set; }
        public double?[]? temperature_80m_member38 { get; set; }
        public double?[]? temperature_80m_member39 { get; set; }
        public List<DateTime>? parsedDateTimes { get; set; }
        public List<DateTime>? parsedLocalTimes { get; set; }


    }

    public static class iconEPSHourlyForecastApi
    {

        private static DataFrame ToDataFrame(iconEPSParams data)
        {
            /*
             * Converts the data object of type iconEPSParams to a DataFrame object.
             * 
             * Returns
             * -------
             * 
             * Microsoft.Data.Analysis.DataFrame object containing the data from the iconEPSParams object.
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

            if (data.temperature_2m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member31", data.temperature_2m_member31));

            if (data.temperature_2m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member32", data.temperature_2m_member32));

            if (data.temperature_2m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member33", data.temperature_2m_member33));

            if (data.temperature_2m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member34", data.temperature_2m_member34));

            if (data.temperature_2m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member35", data.temperature_2m_member35));

            if (data.temperature_2m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member36", data.temperature_2m_member36));

            if (data.temperature_2m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member37", data.temperature_2m_member37));

            if (data.temperature_2m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member38", data.temperature_2m_member38));

            if (data.temperature_2m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_2m_member39", data.temperature_2m_member39));

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

            if (data.relative_humidity_2m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member18", data.relative_humidity_2m_member18));

            if (data.relative_humidity_2m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member19", data.relative_humidity_2m_member19));

            if (data.relative_humidity_2m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member20", data.relative_humidity_2m_member20));

            if (data.relative_humidity_2m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member21", data.relative_humidity_2m_member21));

            if (data.relative_humidity_2m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member22", data.relative_humidity_2m_member22));

            if (data.relative_humidity_2m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member23", data.relative_humidity_2m_member23));

            if (data.relative_humidity_2m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member24", data.relative_humidity_2m_member24));

            if (data.relative_humidity_2m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member25", data.relative_humidity_2m_member25));

            if (data.relative_humidity_2m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member26", data.relative_humidity_2m_member26));

            if (data.relative_humidity_2m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member27", data.relative_humidity_2m_member27));

            if (data.relative_humidity_2m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member28", data.relative_humidity_2m_member28));

            if (data.relative_humidity_2m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member29", data.relative_humidity_2m_member29));

            if (data.relative_humidity_2m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member30", data.relative_humidity_2m_member30));

            if (data.relative_humidity_2m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member31", data.relative_humidity_2m_member31));

            if (data.relative_humidity_2m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member32", data.relative_humidity_2m_member32));

            if (data.relative_humidity_2m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member33", data.relative_humidity_2m_member33));

            if (data.relative_humidity_2m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member34", data.relative_humidity_2m_member34));

            if (data.relative_humidity_2m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member35", data.relative_humidity_2m_member35));

            if (data.relative_humidity_2m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member36", data.relative_humidity_2m_member36));

            if (data.relative_humidity_2m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member37", data.relative_humidity_2m_member37));

            if (data.relative_humidity_2m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member38", data.relative_humidity_2m_member38));

            if (data.relative_humidity_2m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("relative_humidity_2m_member39", data.relative_humidity_2m_member39));

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

            if (data.dew_point_2m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member18", data.dew_point_2m_member18));

            if (data.dew_point_2m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member19", data.dew_point_2m_member19));

            if (data.dew_point_2m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member20", data.dew_point_2m_member20));

            if (data.dew_point_2m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member21", data.dew_point_2m_member21));

            if (data.dew_point_2m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member22", data.dew_point_2m_member22));

            if (data.dew_point_2m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member23", data.dew_point_2m_member23));

            if (data.dew_point_2m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member24", data.dew_point_2m_member24));

            if (data.dew_point_2m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member25", data.dew_point_2m_member25));

            if (data.dew_point_2m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member26", data.dew_point_2m_member26));

            if (data.dew_point_2m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member27", data.dew_point_2m_member27));

            if (data.dew_point_2m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member28", data.dew_point_2m_member28));

            if (data.dew_point_2m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member29", data.dew_point_2m_member29));

            if (data.dew_point_2m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member30", data.dew_point_2m_member30));

            if (data.dew_point_2m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member31", data.dew_point_2m_member31));

            if (data.dew_point_2m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member32", data.dew_point_2m_member32));

            if (data.dew_point_2m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member33", data.dew_point_2m_member33));

            if (data.dew_point_2m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member34", data.dew_point_2m_member34));

            if (data.dew_point_2m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member35", data.dew_point_2m_member35));

            if (data.dew_point_2m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member36", data.dew_point_2m_member36));

            if (data.dew_point_2m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member37", data.dew_point_2m_member37));

            if (data.dew_point_2m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member38", data.dew_point_2m_member38));

            if (data.dew_point_2m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("dew_point_2m_member39", data.dew_point_2m_member39));

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

            if (data.apparent_temperature_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member18", data.apparent_temperature_member18));

            if (data.apparent_temperature_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member19", data.apparent_temperature_member19));

            if (data.apparent_temperature_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member20", data.apparent_temperature_member20));

            if (data.apparent_temperature_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member21", data.apparent_temperature_member21));

            if (data.apparent_temperature_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member22", data.apparent_temperature_member22));

            if (data.apparent_temperature_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member23", data.apparent_temperature_member23));

            if (data.apparent_temperature_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member24", data.apparent_temperature_member24));

            if (data.apparent_temperature_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member25", data.apparent_temperature_member25));

            if (data.apparent_temperature_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member26", data.apparent_temperature_member26));

            if (data.apparent_temperature_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member27", data.apparent_temperature_member27));

            if (data.apparent_temperature_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member28", data.apparent_temperature_member28));

            if (data.apparent_temperature_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member29", data.apparent_temperature_member29));

            if (data.apparent_temperature_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member30", data.apparent_temperature_member30));

            if (data.apparent_temperature_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member31", data.apparent_temperature_member31));

            if (data.apparent_temperature_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member32", data.apparent_temperature_member32));

            if (data.apparent_temperature_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member33", data.apparent_temperature_member33));

            if (data.apparent_temperature_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member34", data.apparent_temperature_member34));

            if (data.apparent_temperature_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member35", data.apparent_temperature_member35));

            if (data.apparent_temperature_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member36", data.apparent_temperature_member36));

            if (data.apparent_temperature_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member37", data.apparent_temperature_member37));

            if (data.apparent_temperature_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member38", data.apparent_temperature_member38));

            if (data.apparent_temperature_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("apparent_temperature_member39", data.apparent_temperature_member39));

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

            if (data.precipitation_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member31", data.precipitation_member31));

            if (data.precipitation_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member32", data.precipitation_member32));

            if (data.precipitation_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member33", data.precipitation_member33));

            if (data.precipitation_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member34", data.precipitation_member34));

            if (data.precipitation_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member35", data.precipitation_member35));

            if (data.precipitation_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member36", data.precipitation_member36));

            if (data.precipitation_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member37", data.precipitation_member37));

            if (data.precipitation_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member38", data.precipitation_member38));

            if (data.precipitation_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("precipitation_member39", data.precipitation_member39));

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

            if (data.rain_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member18", data.rain_member18));

            if (data.rain_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member19", data.rain_member19));

            if (data.rain_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member20", data.rain_member20));

            if (data.rain_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member21", data.rain_member21));

            if (data.rain_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member22", data.rain_member22));

            if (data.rain_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member23", data.rain_member23));

            if (data.rain_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member24", data.rain_member24));

            if (data.rain_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member25", data.rain_member25));

            if (data.rain_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member26", data.rain_member26));

            if (data.rain_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member27", data.rain_member27));

            if (data.rain_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member28", data.rain_member28));

            if (data.rain_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member29", data.rain_member29));

            if (data.rain_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member30", data.rain_member30));

            if (data.rain_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member31", data.rain_member31));

            if (data.rain_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member32", data.rain_member32));

            if (data.rain_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member33", data.rain_member33));

            if (data.rain_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member34", data.rain_member34));

            if (data.rain_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member35", data.rain_member35));

            if (data.rain_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member36", data.rain_member36));

            if (data.rain_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member37", data.rain_member37));

            if (data.rain_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member38", data.rain_member38));

            if (data.rain_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("rain_member39", data.rain_member39));

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

            if (data.snowfall_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member18", data.snowfall_member18));

            if (data.snowfall_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member19", data.snowfall_member19));

            if (data.snowfall_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member20", data.snowfall_member20));

            if (data.snowfall_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member21", data.snowfall_member21));

            if (data.snowfall_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member22", data.snowfall_member22));

            if (data.snowfall_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member23", data.snowfall_member23));

            if (data.snowfall_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member24", data.snowfall_member24));

            if (data.snowfall_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member25", data.snowfall_member25));

            if (data.snowfall_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member26", data.snowfall_member26));

            if (data.snowfall_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member27", data.snowfall_member27));

            if (data.snowfall_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member28", data.snowfall_member28));

            if (data.snowfall_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member29", data.snowfall_member29));

            if (data.snowfall_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member30", data.snowfall_member30));

            if (data.snowfall_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member31", data.snowfall_member31));

            if (data.snowfall_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member32", data.snowfall_member32));

            if (data.snowfall_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member33", data.snowfall_member33));

            if (data.snowfall_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member34", data.snowfall_member34));

            if (data.snowfall_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member35", data.snowfall_member35));

            if (data.snowfall_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member36", data.snowfall_member36));

            if (data.snowfall_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member37", data.snowfall_member37));

            if (data.snowfall_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member38", data.snowfall_member38));

            if (data.snowfall_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("snowfall_member39", data.snowfall_member39));

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

            if (data.weather_code_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member18", data.weather_code_member18));

            if (data.weather_code_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member19", data.weather_code_member19));

            if (data.weather_code_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member20", data.weather_code_member20));

            if (data.weather_code_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member21", data.weather_code_member21));

            if (data.weather_code_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member22", data.weather_code_member22));

            if (data.weather_code_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member23", data.weather_code_member23));

            if (data.weather_code_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member24", data.weather_code_member24));

            if (data.weather_code_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member25", data.weather_code_member25));

            if (data.weather_code_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member26", data.weather_code_member26));

            if (data.weather_code_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member27", data.weather_code_member27));

            if (data.weather_code_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member28", data.weather_code_member28));

            if (data.weather_code_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member29", data.weather_code_member29));

            if (data.weather_code_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member30", data.weather_code_member30));

            if (data.weather_code_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member31", data.weather_code_member31));

            if (data.weather_code_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member32", data.weather_code_member32));

            if (data.weather_code_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member33", data.weather_code_member33));

            if (data.weather_code_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member34", data.weather_code_member34));

            if (data.weather_code_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member35", data.weather_code_member35));

            if (data.weather_code_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member36", data.weather_code_member36));

            if (data.weather_code_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member37", data.weather_code_member37));

            if (data.weather_code_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member38", data.weather_code_member38));

            if (data.weather_code_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("weather_code_member39", data.weather_code_member39));

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

            if (data.pressure_msl_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member18", data.pressure_msl_member18));

            if (data.pressure_msl_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member19", data.pressure_msl_member19));

            if (data.pressure_msl_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member20", data.pressure_msl_member20));

            if (data.pressure_msl_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member21", data.pressure_msl_member21));

            if (data.pressure_msl_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member22", data.pressure_msl_member22));

            if (data.pressure_msl_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member23", data.pressure_msl_member23));

            if (data.pressure_msl_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member24", data.pressure_msl_member24));

            if (data.pressure_msl_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member25", data.pressure_msl_member25));

            if (data.pressure_msl_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member26", data.pressure_msl_member26));

            if (data.pressure_msl_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member27", data.pressure_msl_member27));

            if (data.pressure_msl_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member28", data.pressure_msl_member28));

            if (data.pressure_msl_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member29", data.pressure_msl_member29));

            if (data.pressure_msl_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member30", data.pressure_msl_member30));

            if (data.pressure_msl_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member31", data.pressure_msl_member31));

            if (data.pressure_msl_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member32", data.pressure_msl_member32));

            if (data.pressure_msl_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member33", data.pressure_msl_member33));

            if (data.pressure_msl_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member34", data.pressure_msl_member34));

            if (data.pressure_msl_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member35", data.pressure_msl_member35));

            if (data.pressure_msl_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member36", data.pressure_msl_member36));

            if (data.pressure_msl_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member37", data.pressure_msl_member37));

            if (data.pressure_msl_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member38", data.pressure_msl_member38));

            if (data.pressure_msl_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("pressure_msl_member39", data.pressure_msl_member39));

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

            if (data.surface_pressure_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member18", data.surface_pressure_member18));

            if (data.surface_pressure_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member19", data.surface_pressure_member19));

            if (data.surface_pressure_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member20", data.surface_pressure_member20));

            if (data.surface_pressure_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member21", data.surface_pressure_member21));

            if (data.surface_pressure_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member22", data.surface_pressure_member22));

            if (data.surface_pressure_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member23", data.surface_pressure_member23));

            if (data.surface_pressure_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member24", data.surface_pressure_member24));

            if (data.surface_pressure_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member25", data.surface_pressure_member25));

            if (data.surface_pressure_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member26", data.surface_pressure_member26));

            if (data.surface_pressure_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member27", data.surface_pressure_member27));

            if (data.surface_pressure_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member28", data.surface_pressure_member28));

            if (data.surface_pressure_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member29", data.surface_pressure_member29));

            if (data.surface_pressure_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member30", data.surface_pressure_member30));

            if (data.surface_pressure_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member31", data.surface_pressure_member31));

            if (data.surface_pressure_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member32", data.surface_pressure_member32));

            if (data.surface_pressure_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member33", data.surface_pressure_member33));

            if (data.surface_pressure_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member34", data.surface_pressure_member34));

            if (data.surface_pressure_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member35", data.surface_pressure_member35));

            if (data.surface_pressure_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member36", data.surface_pressure_member36));

            if (data.surface_pressure_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member37", data.surface_pressure_member37));

            if (data.surface_pressure_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member38", data.surface_pressure_member38));

            if (data.surface_pressure_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("surface_pressure_member39", data.surface_pressure_member39));

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

            if (data.cloud_cover_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member31", data.cloud_cover_member31));

            if (data.cloud_cover_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member32", data.cloud_cover_member32));

            if (data.cloud_cover_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member33", data.cloud_cover_member33));

            if (data.cloud_cover_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member34", data.cloud_cover_member34));

            if (data.cloud_cover_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member35", data.cloud_cover_member35));

            if (data.cloud_cover_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member36", data.cloud_cover_member36));

            if (data.cloud_cover_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member37", data.cloud_cover_member37));

            if (data.cloud_cover_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member38", data.cloud_cover_member38));

            if (data.cloud_cover_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("cloud_cover_member39", data.cloud_cover_member39));

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

            if (data.et0_fao_evapotranspiration_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member18", data.et0_fao_evapotranspiration_member18));

            if (data.et0_fao_evapotranspiration_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member19", data.et0_fao_evapotranspiration_member19));

            if (data.et0_fao_evapotranspiration_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member20", data.et0_fao_evapotranspiration_member20));

            if (data.et0_fao_evapotranspiration_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member21", data.et0_fao_evapotranspiration_member21));

            if (data.et0_fao_evapotranspiration_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member22", data.et0_fao_evapotranspiration_member22));

            if (data.et0_fao_evapotranspiration_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member23", data.et0_fao_evapotranspiration_member23));

            if (data.et0_fao_evapotranspiration_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member24", data.et0_fao_evapotranspiration_member24));

            if (data.et0_fao_evapotranspiration_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member25", data.et0_fao_evapotranspiration_member25));

            if (data.et0_fao_evapotranspiration_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member26", data.et0_fao_evapotranspiration_member26));

            if (data.et0_fao_evapotranspiration_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member27", data.et0_fao_evapotranspiration_member27));

            if (data.et0_fao_evapotranspiration_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member28", data.et0_fao_evapotranspiration_member28));

            if (data.et0_fao_evapotranspiration_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member29", data.et0_fao_evapotranspiration_member29));

            if (data.et0_fao_evapotranspiration_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member30", data.et0_fao_evapotranspiration_member30));

            if (data.et0_fao_evapotranspiration_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member31", data.et0_fao_evapotranspiration_member31));

            if (data.et0_fao_evapotranspiration_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member32", data.et0_fao_evapotranspiration_member32));

            if (data.et0_fao_evapotranspiration_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member33", data.et0_fao_evapotranspiration_member33));

            if (data.et0_fao_evapotranspiration_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member34", data.et0_fao_evapotranspiration_member34));

            if (data.et0_fao_evapotranspiration_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member35", data.et0_fao_evapotranspiration_member35));

            if (data.et0_fao_evapotranspiration_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member36", data.et0_fao_evapotranspiration_member36));

            if (data.et0_fao_evapotranspiration_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member37", data.et0_fao_evapotranspiration_member37));

            if (data.et0_fao_evapotranspiration_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member38", data.et0_fao_evapotranspiration_member38));

            if (data.et0_fao_evapotranspiration_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("et0_fao_evapotranspiration_member39", data.et0_fao_evapotranspiration_member39));

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

            if (data.vapour_pressure_deficit_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member18", data.vapour_pressure_deficit_member18));

            if (data.vapour_pressure_deficit_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member19", data.vapour_pressure_deficit_member19));

            if (data.vapour_pressure_deficit_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member20", data.vapour_pressure_deficit_member20));

            if (data.vapour_pressure_deficit_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member21", data.vapour_pressure_deficit_member21));

            if (data.vapour_pressure_deficit_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member22", data.vapour_pressure_deficit_member22));

            if (data.vapour_pressure_deficit_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member23", data.vapour_pressure_deficit_member23));

            if (data.vapour_pressure_deficit_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member24", data.vapour_pressure_deficit_member24));

            if (data.vapour_pressure_deficit_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member25", data.vapour_pressure_deficit_member25));

            if (data.vapour_pressure_deficit_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member26", data.vapour_pressure_deficit_member26));

            if (data.vapour_pressure_deficit_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member27", data.vapour_pressure_deficit_member27));

            if (data.vapour_pressure_deficit_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member28", data.vapour_pressure_deficit_member28));

            if (data.vapour_pressure_deficit_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member29", data.vapour_pressure_deficit_member29));

            if (data.vapour_pressure_deficit_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member30", data.vapour_pressure_deficit_member30));

            if (data.vapour_pressure_deficit_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member31", data.vapour_pressure_deficit_member31));

            if (data.vapour_pressure_deficit_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member32", data.vapour_pressure_deficit_member32));

            if (data.vapour_pressure_deficit_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member33", data.vapour_pressure_deficit_member33));

            if (data.vapour_pressure_deficit_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member34", data.vapour_pressure_deficit_member34));

            if (data.vapour_pressure_deficit_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member35", data.vapour_pressure_deficit_member35));

            if (data.vapour_pressure_deficit_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member36", data.vapour_pressure_deficit_member36));

            if (data.vapour_pressure_deficit_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member37", data.vapour_pressure_deficit_member37));

            if (data.vapour_pressure_deficit_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member38", data.vapour_pressure_deficit_member38));

            if (data.vapour_pressure_deficit_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("vapour_pressure_deficit_member39", data.vapour_pressure_deficit_member39));

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

            if (data.wind_speed_10m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member18", data.wind_speed_10m_member18));

            if (data.wind_speed_10m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member19", data.wind_speed_10m_member19));

            if (data.wind_speed_10m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member20", data.wind_speed_10m_member20));

            if (data.wind_speed_10m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member21", data.wind_speed_10m_member21));

            if (data.wind_speed_10m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member22", data.wind_speed_10m_member22));

            if (data.wind_speed_10m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member23", data.wind_speed_10m_member23));

            if (data.wind_speed_10m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member24", data.wind_speed_10m_member24));

            if (data.wind_speed_10m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member25", data.wind_speed_10m_member25));

            if (data.wind_speed_10m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member26", data.wind_speed_10m_member26));

            if (data.wind_speed_10m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member27", data.wind_speed_10m_member27));

            if (data.wind_speed_10m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member28", data.wind_speed_10m_member28));

            if (data.wind_speed_10m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member29", data.wind_speed_10m_member29));

            if (data.wind_speed_10m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member30", data.wind_speed_10m_member30));

            if (data.wind_speed_10m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member31", data.wind_speed_10m_member31));

            if (data.wind_speed_10m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member32", data.wind_speed_10m_member32));

            if (data.wind_speed_10m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member33", data.wind_speed_10m_member33));

            if (data.wind_speed_10m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member34", data.wind_speed_10m_member34));

            if (data.wind_speed_10m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member35", data.wind_speed_10m_member35));

            if (data.wind_speed_10m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member36", data.wind_speed_10m_member36));

            if (data.wind_speed_10m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member37", data.wind_speed_10m_member37));

            if (data.wind_speed_10m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member38", data.wind_speed_10m_member38));

            if (data.wind_speed_10m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_10m_member39", data.wind_speed_10m_member39));

            if (data.wind_speed_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m", data.wind_speed_80m));

            if (data.wind_speed_80m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member01", data.wind_speed_80m_member01));

            if (data.wind_speed_80m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member02", data.wind_speed_80m_member02));

            if (data.wind_speed_80m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member03", data.wind_speed_80m_member03));

            if (data.wind_speed_80m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member04", data.wind_speed_80m_member04));

            if (data.wind_speed_80m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member05", data.wind_speed_80m_member05));

            if (data.wind_speed_80m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member06", data.wind_speed_80m_member06));

            if (data.wind_speed_80m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member07", data.wind_speed_80m_member07));

            if (data.wind_speed_80m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member08", data.wind_speed_80m_member08));

            if (data.wind_speed_80m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member09", data.wind_speed_80m_member09));

            if (data.wind_speed_80m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member10", data.wind_speed_80m_member10));

            if (data.wind_speed_80m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member11", data.wind_speed_80m_member11));

            if (data.wind_speed_80m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member12", data.wind_speed_80m_member12));

            if (data.wind_speed_80m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member13", data.wind_speed_80m_member13));

            if (data.wind_speed_80m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member14", data.wind_speed_80m_member14));

            if (data.wind_speed_80m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member15", data.wind_speed_80m_member15));

            if (data.wind_speed_80m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member16", data.wind_speed_80m_member16));

            if (data.wind_speed_80m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member17", data.wind_speed_80m_member17));

            if (data.wind_speed_80m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member18", data.wind_speed_80m_member18));

            if (data.wind_speed_80m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member19", data.wind_speed_80m_member19));

            if (data.wind_speed_80m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member20", data.wind_speed_80m_member20));

            if (data.wind_speed_80m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member21", data.wind_speed_80m_member21));

            if (data.wind_speed_80m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member22", data.wind_speed_80m_member22));

            if (data.wind_speed_80m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member23", data.wind_speed_80m_member23));

            if (data.wind_speed_80m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member24", data.wind_speed_80m_member24));

            if (data.wind_speed_80m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member25", data.wind_speed_80m_member25));

            if (data.wind_speed_80m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member26", data.wind_speed_80m_member26));

            if (data.wind_speed_80m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member27", data.wind_speed_80m_member27));

            if (data.wind_speed_80m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member28", data.wind_speed_80m_member28));

            if (data.wind_speed_80m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member29", data.wind_speed_80m_member29));

            if (data.wind_speed_80m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member30", data.wind_speed_80m_member30));

            if (data.wind_speed_80m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member31", data.wind_speed_80m_member31));

            if (data.wind_speed_80m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member32", data.wind_speed_80m_member32));

            if (data.wind_speed_80m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member33", data.wind_speed_80m_member33));

            if (data.wind_speed_80m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member34", data.wind_speed_80m_member34));

            if (data.wind_speed_80m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member35", data.wind_speed_80m_member35));

            if (data.wind_speed_80m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member36", data.wind_speed_80m_member36));

            if (data.wind_speed_80m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member37", data.wind_speed_80m_member37));

            if (data.wind_speed_80m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member38", data.wind_speed_80m_member38));

            if (data.wind_speed_80m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_speed_80m_member39", data.wind_speed_80m_member39));

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

            if (data.wind_gusts_10m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member18", data.wind_gusts_10m_member18));

            if (data.wind_gusts_10m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member19", data.wind_gusts_10m_member19));

            if (data.wind_gusts_10m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member20", data.wind_gusts_10m_member20));

            if (data.wind_gusts_10m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member21", data.wind_gusts_10m_member21));

            if (data.wind_gusts_10m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member22", data.wind_gusts_10m_member22));

            if (data.wind_gusts_10m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member23", data.wind_gusts_10m_member23));

            if (data.wind_gusts_10m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member24", data.wind_gusts_10m_member24));

            if (data.wind_gusts_10m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member25", data.wind_gusts_10m_member25));

            if (data.wind_gusts_10m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member26", data.wind_gusts_10m_member26));

            if (data.wind_gusts_10m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member27", data.wind_gusts_10m_member27));

            if (data.wind_gusts_10m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member28", data.wind_gusts_10m_member28));

            if (data.wind_gusts_10m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member29", data.wind_gusts_10m_member29));

            if (data.wind_gusts_10m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member30", data.wind_gusts_10m_member30));

            if (data.wind_gusts_10m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member31", data.wind_gusts_10m_member31));

            if (data.wind_gusts_10m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member32", data.wind_gusts_10m_member32));

            if (data.wind_gusts_10m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member33", data.wind_gusts_10m_member33));

            if (data.wind_gusts_10m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member34", data.wind_gusts_10m_member34));

            if (data.wind_gusts_10m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member35", data.wind_gusts_10m_member35));

            if (data.wind_gusts_10m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member36", data.wind_gusts_10m_member36));

            if (data.wind_gusts_10m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member37", data.wind_gusts_10m_member37));

            if (data.wind_gusts_10m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member38", data.wind_gusts_10m_member38));

            if (data.wind_gusts_10m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("wind_gusts_10m_member39", data.wind_gusts_10m_member39));

            if (data.temperature_80m != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m", data.temperature_80m));

            if (data.temperature_80m_member01 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member01", data.temperature_80m_member01));

            if (data.temperature_80m_member02 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member02", data.temperature_80m_member02));

            if (data.temperature_80m_member03 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member03", data.temperature_80m_member03));

            if (data.temperature_80m_member04 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member04", data.temperature_80m_member04));

            if (data.temperature_80m_member05 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member05", data.temperature_80m_member05));

            if (data.temperature_80m_member06 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member06", data.temperature_80m_member06));

            if (data.temperature_80m_member07 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member07", data.temperature_80m_member07));

            if (data.temperature_80m_member08 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member08", data.temperature_80m_member08));

            if (data.temperature_80m_member09 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member09", data.temperature_80m_member09));

            if (data.temperature_80m_member10 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member10", data.temperature_80m_member10));

            if (data.temperature_80m_member11 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member11", data.temperature_80m_member11));

            if (data.temperature_80m_member12 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member12", data.temperature_80m_member12));

            if (data.temperature_80m_member13 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member13", data.temperature_80m_member13));

            if (data.temperature_80m_member14 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member14", data.temperature_80m_member14));

            if (data.temperature_80m_member15 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member15", data.temperature_80m_member15));

            if (data.temperature_80m_member16 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member16", data.temperature_80m_member16));

            if (data.temperature_80m_member17 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member17", data.temperature_80m_member17));

            if (data.temperature_80m_member18 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member18", data.temperature_80m_member18));

            if (data.temperature_80m_member19 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member19", data.temperature_80m_member19));

            if (data.temperature_80m_member20 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member20", data.temperature_80m_member20));

            if (data.temperature_80m_member21 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member21", data.temperature_80m_member21));

            if (data.temperature_80m_member22 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member22", data.temperature_80m_member22));

            if (data.temperature_80m_member23 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member23", data.temperature_80m_member23));

            if (data.temperature_80m_member24 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member24", data.temperature_80m_member24));

            if (data.temperature_80m_member25 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member25", data.temperature_80m_member25));

            if (data.temperature_80m_member26 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member26", data.temperature_80m_member26));

            if (data.temperature_80m_member27 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member27", data.temperature_80m_member27));

            if (data.temperature_80m_member28 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member28", data.temperature_80m_member28));

            if (data.temperature_80m_member29 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member29", data.temperature_80m_member29));

            if (data.temperature_80m_member30 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member30", data.temperature_80m_member30));

            if (data.temperature_80m_member31 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member31", data.temperature_80m_member31));

            if (data.temperature_80m_member32 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member32", data.temperature_80m_member32));

            if (data.temperature_80m_member33 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member33", data.temperature_80m_member33));

            if (data.temperature_80m_member34 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member34", data.temperature_80m_member34));

            if (data.temperature_80m_member35 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member35", data.temperature_80m_member35));

            if (data.temperature_80m_member36 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member36", data.temperature_80m_member36));

            if (data.temperature_80m_member37 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member37", data.temperature_80m_member37));

            if (data.temperature_80m_member38 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member38", data.temperature_80m_member38));

            if (data.temperature_80m_member39 != null)
                df.Columns.Add(new PrimitiveDataFrameColumn<double>("temperature_80m_member39", data.temperature_80m_member39));

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
         * This function is the client that retrieves and returns DWD ICON EPS 2-Meter Forecast from the Open-Meteo API.
         * 
         * Required Arguments:
         * 
         * 1) latitude (string) - The latitude [decimal degrees] in the form of a string. Use negative values for the southern hemisphere.
         * 
         * 2) longitude (string) - The longitude [decimal degrees] in the form of a string. Use negative values for the western hemisphere.
         * 
         * Optional Arguments:
         * 
         * 1) days (int) - Default=7. The number of forecast days to retrieve, starting from the current day. Maximum is 7 days.
         *          * 
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
                "dew_point_2m"
                "apparent_temperature"
                "precipitation"
                "rain"
                "snowfall"
                "weather_code"
                "pressure_msl"
                "surface_pressure"
                "cloud_cover"
                "et0_fao_evapotranspiration"
                "vapour_pressure_deficit"
                "wind_speed_10m"
                "wind_speed_80m"
                "wind_direction_10m"
                "wind_direction_80m"
                "wind_gusts_10m"
                "temperature_80m"


          6) proxy (string) - Optional proxy server URL in the form of "https://proxy-address:port" or "http://proxy-address:port". Default is null (no proxy).
         *      
         * 
         * Returns
         * -------
         * 
         * The ICON EPS point forecast for a given latitude and longitude. 
         * 
         *          variable naming convention
         *          ---------------------------
         *          
         *          Control Run (Example 2-Meter Temperature): data.temperature_2m
         *          Ensemble Member 1 (Example 2-Meter Temperature): data.temperature_2m_member01 -> data.temperature_2m_member39 (40 total members [39 members + 1 control])
         */

        {
            // Fixes if the user enters more than 7 days since the data goes out to 7 days at most. 

            if (days > 7)
            {
                    Console.WriteLine($"Requested forecast length of {days} days exceeds the maximum of 7 days. Defaulting to 7 days.");
                    days = 7;
            }

            // Ensure 'variables' has a valid default at runtime (arrays cannot be default parameter compile-time constants).
            if (variables == null || variables.Length == 0)
            {
                variables = new[] { "temperature_2m", 
                                    "relative_humidity_2m",
                                    "dew_point_2m",
                                    "apparent_temperature",
                                    "precipitation" ,
                                    "rain" ,
                                    "snowfall" ,
                                    "weather_code" ,
                                    "pressure_msl" ,
                                    "surface_pressure" ,
                                    "cloud_cover" ,
                                    "et0_fao_evapotranspiration" ,
                                    "vapour_pressure_deficit" ,
                                    "wind_speed_10m" ,
                                    "wind_speed_80m" ,
                                    "wind_direction_10m" ,
                                    "wind_direction_80m" ,
                                    "wind_gusts_10m" ,
                                    "temperature_80m" };
            }
            else
            {

            }

            // Build the 'hourly' query parameter from the variables array.
            var modelParams = string.Join(",", variables);

            // Open-Meto API Call URL
            string url = $"https://ensemble-api.open-meteo.com/v1/ensemble?latitude={latitude}&longitude={longitude}" +
                $"&hourly={modelParams}" +
                $"&models=icon_seamless_eps&forecast_days={days}" +
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

            }

            // Deserialize the "hourly" property into our iconEPSParams class. If deserialization fails, print an error message and return.
            var data = JsonSerializer.Deserialize<iconEPSParams>(hourlyWeatherElement.GetRawText());

            if (data == null)
            {
                Console.WriteLine("Unable to parse hourly weather data.");
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
                        fileName = $"ICON_EPS_PointForecast_{latString}_{lonString}.csv";
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
                Console.WriteLine($"ICON EPS Data Not Available At This Time");
                return null;

            }
        }
    }
}

