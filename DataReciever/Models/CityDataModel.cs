using Day021_SkillBox_Homework.RequestModels.LocationApi;

namespace Day021_SkillBox_Homework.DataReciever.Models
{
    public class CityDataModel
    {
        private CityDataModel(
            bool isSuccess,
            string cityCode,
            string countryName,
            string locationName
            )
        {
            CityCode = cityCode;
            CountryName = countryName;
            LocationName = locationName;
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }
        public string CityCode { get; }
        private string CountryName { get; }
        private string LocationName { get; }

        public static CityDataModel BuildSuccess(Location location)
        => new CityDataModel(true, location.Key, location.Country.EnglishName, location.EnglishName);

        public static CityDataModel BuildFailed()
        => new CityDataModel(false, null, null, null);

        public override string ToString() => $"{LocationName} ({CountryName})";
    }
}