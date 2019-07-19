using System;

namespace Day021_SkillBox_Homework.RequestModels.LocationApi
{
    public class TimeZone
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public float GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public DateTime? NextOffsetChange { get; set; }
    }
}