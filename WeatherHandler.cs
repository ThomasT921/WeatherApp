using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherHandler
    {
        private string _wind_cdir, _pod, _timezone, _ob_time, _country_code, _wind_cdir_full,
            _state_code, _station, _datetime, _city_name, _sunrise, _sunset;
        private int _rh, _clouds, _vis, _h_angle, _uv, _aqi, _wind_dir, _elev_angle, _precip,
            _dni, _dhi, _solar_rad, _weather_description;
        private double _lat, _lon, _temp, _slp, _ghi, _dewpt, _app_temp, _wind_spd, _pres;

        public WeatherHandler()
        {

        }

        public WeatherHandler(dynamic thing)
        {
            _wind_cdir = thing["wind_cdir"].ToString();
            _pod = thing["pod"].ToString();
            _timezone = thing["timezone"].ToString();
            _ob_time = thing["ob_time"].ToString();
            _country_code = thing["country_code"].ToString();
            _wind_cdir_full = thing["wind_cdir_full"].ToString();
            _state_code = thing["state_code"].ToString();
            if (int.TryParse(thing["weather"]["code"].ToString(), out _weather_description)) ;
            _station = thing["station"].ToString();
            _datetime = thing["datetime"].ToString();
            _city_name = thing["city_name"].ToString();
            _sunrise = thing["sunrise"].ToString();
            _sunset = thing["sunset"].ToString();
            if (int.TryParse(thing["rh"].ToString(), out _rh)) ;
            if (int.TryParse(thing["clouds"].ToString(), out _clouds)) ;
            if (int.TryParse(thing["vis"].ToString(), out _vis)) ;
            if (int.TryParse(thing["h_angle"].ToString(), out _h_angle)) ;
            if (int.TryParse(thing["uv"].ToString(), out _uv)) ;
            if (int.TryParse(thing["aqi"].ToString(), out _aqi)) ;
            if (int.TryParse(thing["wind_dir"].ToString(), out _wind_dir)) ;
            if (int.TryParse(thing["dhi"].ToString(), out _dhi)) ;
            if (int.TryParse(thing["dni"].ToString(), out _dni)) ;
            if (int.TryParse(thing["precip"].ToString(), out _precip)) ;
            if (int.TryParse(thing["elev_angle"].ToString(), out _elev_angle)) ;
            if (int.TryParse(thing["solar_rad"].ToString(), out _solar_rad)) ;
            if (double.TryParse(thing["dewpt"].ToString(), out _dewpt)) ;
            if (double.TryParse(thing["lon"].ToString(), out _lon)) ;
            if (double.TryParse(thing["temp"].ToString(), out _temp)) ;
            if (double.TryParse(thing["app_temp"].ToString(), out _app_temp)) ;
            if (double.TryParse(thing["lat"].ToString(), out _lat)) ;
            if (double.TryParse(thing["slp"].ToString(), out _slp)) ;
            if (double.TryParse(thing["pres"].ToString(), out _pres)) ;
            if (double.TryParse(thing["wind_spd"].ToString(), out _wind_spd)) ;
            if (double.TryParse(thing["ghi"].ToString(), out _ghi)) ;


        }
        public double Lattitude
        {
            get { return _lat; }
            set { _lat = value; }
        }
        public double Longitude
        {
            get { return _lon; }
            set { _lon = value; }
        }
        public double Temperature
        {
            get { return _temp; }
            set { _temp = value; }
        }
        public double SeaLevel
        {
            get { return _slp; }
            set { _slp = value; }
        }
        public double GlobalHorizontalSolarIrradiance
        {
            get { return _ghi; }
            set { _ghi = value; }
        }
        public double DewPoint
        {
            get { return _dewpt; }
            set { _dewpt = value; }
        }
        public double FeelsLikeTemp
        {
            get { return _app_temp; }
            set { _app_temp = value; }
        }
        public double WindSpeed
        {
            get { return _wind_spd; }
            set { _wind_spd = value; }
        }
        public double Pressure
        {
            get { return _pres; }
            set { _pres = value; }
        }
        public int RelativeHumidity
        {
            get { return _rh; }
            set { _rh = value; }
        }
        public int CloudCoverage
        {
            get { return _clouds; }
            set { _clouds = value; }
        }
        public int Visibility
        {
            get { return _vis; }
            set { _vis = value; }
        }
        public int SolarHourAngle
        {
            get { return _h_angle; }
            set { _h_angle = value; }
        }
        public int WindDirection_degrees
        {
            get { return _wind_dir; }
            set { _wind_dir = value; }
        }
        public int SolarElevationAngle
        {
            get { return _elev_angle; }
            set { _elev_angle = value; }
        }
        public int Precipitation
        {
            get { return _precip; }
            set { _precip = value; }
        }
        public int DirectNormalSolarIrradiance
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public int DiffuseHorizontalSolarIrradiance
        {
            get { return _dhi; }
            set { _dhi = value; }
        }
        public int EstimatedSolarRadiation
        {
            get { return _solar_rad; }
            set { _solar_rad = value; }
        }
        public int UVIndex
        {
            get { return _uv; }
            set { _uv = value; }
        }
        public int AirQualityIndex
        {
            get { return _aqi; }
            set { _aqi = value; }
        }
        public string WindDirection_Abbreviated
        {
            get { return _wind_cdir; }
            set { _wind_cdir = value; }
        }
        public string WindDirection_Full
        {
            get { return _wind_cdir_full; }
            set { _wind_cdir_full = value; }
        }
        public string State
        {
            get { return _state_code; }
            set { _state_code = value; }
        }
        public string Country
        {
            get { return _country_code; }
            set { _country_code = value; }
        }
        public string City
        {
            get { return _city_name; }
            set { _city_name = value; }
        }
        public string TimeZone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }
        public string PartOfDay
        {
            get { return _pod; }
            set { _pod = value; }
        }
        public int WeatherDescription
        {
            get { return _weather_description; }
            set { _weather_description = value; }
        }
        public string LastObservationTime
        {
            get { return _ob_time; }
            set { _ob_time = value; }
        }
        public string CurrentCycleHour
        {
            get { return _datetime; }
            set { _datetime = value; }
        }
        public string Sunset
        {
            get { return _sunset; }
            set { _sunset = value; }
        }
        public string Sunrise
        {
            get { return _sunrise; }
            set { _sunrise = value; }
        }
        public string Station
        {
            get { return _station; }
            set { _station = value; }
        }

    }
}
