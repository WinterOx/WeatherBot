namespace Day021_SkillBox_Homework.RequestModels.ForecastApi
{
    public class AccuWeather
    {
        public Headline Headline { get; set; }
        public DailyForecast[] DailyForecasts { get; set; }
    }
}