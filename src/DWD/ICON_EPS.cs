/*
 * (C) Eric J. Drewitz 2026
 */

using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenMeteoApiNet.ICON_EPS
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
        public static async Task<iconEPSParams?> GetPointForecast(string latitude,
                                                         string longitude,
                                                         int days = 7,
                                                         string temperatureUnit = "fahrenheit",
                                                         string windSpeedUnit = "mph",
                                                         string precipitationUnit = "inch",
                                                         string[]? variables = null,
                                                         string? proxy = null)
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
                "temperature_850hPa"
                "temperature_500hPa"
                "geopotential_height_850hPa"
                "geopotential_height_500hPa"


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
            // Create HTTP client
            HttpClient httpClient;

            // If a proxy is provided, set up the HttpClient to use the proxy.
            if (!string.IsNullOrEmpty(proxy))
            {
                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = new WebProxy(proxy),
                    UseProxy = true
                };
                httpClient = new HttpClient(httpClientHandler);
            }
            else
            {
                httpClient = new HttpClient();
            }

            // 3. Ensure proper disposal of the selected client
            using (httpClient)
            {

                // Ping the server for a response. 
                var response = await httpClient.GetAsync(url);

                // Ensure we get a successful response, otherwise throw an exception.
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch
                {
                    HttpStatusCode statusCode = response.StatusCode;

                    if (statusCode == HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine($"Bad Request: The server could not understand the request. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.Unauthorized)
                    {
                        Console.WriteLine($"Unauthorized: Access is denied due to invalid credentials. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.Forbidden)
                    {
                        Console.WriteLine($"Forbidden: You do not have permission to access this resource. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Not Found: The requested resource could not be found. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else if ((int)statusCode >= 500 && (int)statusCode < 600)
                    {
                        Console.WriteLine($"Server Error: The server encountered an error. Status Code: {(int)statusCode} {statusCode}");
                    }
                    else
                    {
                        Console.WriteLine($"HTTP Error: An error occurred while making the request. Status Code: {(int)statusCode} {statusCode}");
                    }
                }

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

                // Deserialize the "hourly" property into our iconEPSParams class. If deserialization fails, print an error message and return.
                var data = JsonSerializer.Deserialize<iconEPSParams>(hourlyWeatherElement.GetRawText());
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

                    return data;
                }
                else
                {
                    Console.WriteLine($"ICON Data Not Available At This Time");
                    return null;

                }
            }
        }
    }
}
