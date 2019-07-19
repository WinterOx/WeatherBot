namespace Day021_SkillBox_Homework.RequestModels.ForecastApi
{
    public class Moon
    {
        public string Rise { get; set; }
        public long EpochRise { get; set; }
        public string Set { get; set; }
        public long EpochSet { get; set; }
        public string Phase { get; set; }
        public int Age { get; set; }
    }
}