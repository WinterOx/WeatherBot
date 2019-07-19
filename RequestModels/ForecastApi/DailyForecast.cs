namespace Day021_SkillBox_Homework.RequestModels.ForecastApi
{
    public class DailyForecast
    {
        public string Date { get; set; }
        public long EpochDate { get; set; }
        public Sun Sun { get; set; }
        public Moon Moon { get; set; }
        public Temperature Temperature { get; set; }
        public Temperature RealFeelTemperature { get; set; }
        public Temperature RealFeelTemperatureShade { get; set; }
        public float? HoursOfSun { get; set; }
        public DegreeDaySummary DegreeDaySummary { get; set; }
        public AirAndPollen[] AirAndPollen { get; set; }
        public WeatherData Day { get; set; }
        public WeatherData Night { get; set; }
        public string[] Sources { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }
}