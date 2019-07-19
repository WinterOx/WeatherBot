namespace Day021_SkillBox_Homework.RequestModels.ForecastApi
{
    public class WeatherData
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public LocalSource LocalSource { get; set; }
        public string ShortPhrase { get; set; }
        public string LongPhrase { get; set; }
        public int? PrecipitationProbability { get; set; }
        public int? ThunderstormProbability { get; set; }
        public int? RainProbability { get; set; }
        public int? SnowProbability { get; set; }
        public int? IceProbability { get; set; }
        public Wind Wind { get; set; }
        public WindGust WindGust { get; set; }
        public Measure TotalLiquid { get; set; }
        public Measure Rain { get; set; }
        public Measure Snow { get; set; }
        public Measure Ice { get; set; }
        public float HoursOfPrecipitation { get; set; }
        public float HoursOfRain { get; set; }
        public int CloudCover { get; set; }

    }
}