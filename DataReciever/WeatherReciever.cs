using System;
using System.Linq;
using Day021_SkillBox_Homework.DataReciever.Models;
using Day021_SkillBox_Homework.Infrastructure;
using Day021_SkillBox_Homework.RequestModels.ForecastApi;
using Day021_SkillBox_Homework.RequestModels.LocationApi;

namespace Day021_SkillBox_Homework.DataReciever
{
    public class WeatherReciever : IWeatherReciever
    {
        private readonly string apiKey;

        public WeatherReciever(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public WeatherDataModel GetWeather(string cityCode)
        {
            var responseAccuWeather = Webber.Get<AccuWeather>(
                $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{cityCode}" +
                $"?apikey={apiKey}" +
                "&details=true" +
                "&metric=true"
            );

            var weather = responseAccuWeather.Result.DailyForecasts.FirstOrDefault();
            if (weather == null)
            {
                return null;
            }

            return new WeatherDataModel
            {
                MinimumTemperature = weather.Temperature.Minimum.Value,
                MaximumTemperature = weather.Temperature.Maximum.Value,
                SunlightDuration = DateTime.Parse(weather.Sun.Set) - DateTime.Parse(weather.Sun.Rise),
                RealFeelTemperature = (weather.RealFeelTemperature.Minimum.Value + weather.RealFeelTemperature.Maximum.Value) / 2,
                WindSpeed = weather.Day.Wind.Speed.Value,
                WindDirection = weather.Day.Wind.Direction.English,
                PrecipitationProbability = weather.Day.PrecipitationProbability
            };
        }
    }
}