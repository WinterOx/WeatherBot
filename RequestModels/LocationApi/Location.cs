namespace Day021_SkillBox_Homework.RequestModels.LocationApi
{
    public class Location
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public Region Region { get; set; }
        public Country Country { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }
        public TimeZone TimeZone { get; set; }
        public GeoPosition GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public SupplementalAdminArea[] SupplementalAdminArea { get; set; }
        public string[] DataSets { get; set; }
        public Details Details { get; set; }
    }
}