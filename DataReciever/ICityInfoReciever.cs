using Day021_SkillBox_Homework.DataReciever.Models;

namespace Day021_SkillBox_Homework.DataReciever
{
    public interface ICityInfoReciever
    {
        CityDataModel GetCityInformation(string cityName);
    }
}