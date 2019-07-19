using System.Linq;
using Day021_SkillBox_Homework.DataReciever.Models;
using Day021_SkillBox_Homework.Infrastructure;
using Day021_SkillBox_Homework.RequestModels.LocationApi;

namespace Day021_SkillBox_Homework.DataReciever
{
    public class CityInfoReciever : ICityInfoReciever
    {
        private readonly string apiKey;

        public CityInfoReciever(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public CityDataModel GetCityInformation(string cityName)
        {
            var citiesResponse = Webber.Get<Location[]>(
                "http://dataservice.accuweather.com/locations/v1/cities/search" +
                $"?apikey={apiKey}" +
                $"&q={cityName}" +
                "&details=true"
            );
            var city = citiesResponse
                .Result
                .OrderBy(x => x.Rank)
                .FirstOrDefault();

            return city != null
                ? CityDataModel.BuildSuccess(city)
                : CityDataModel.BuildFailed();
        }
    }
}