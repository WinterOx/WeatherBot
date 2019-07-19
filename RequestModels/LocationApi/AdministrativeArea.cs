namespace Day021_SkillBox_Homework.RequestModels.LocationApi
{
    public class AdministrativeArea
    {
        public string Id { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int? Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryId { get; set; }
    }
}