using Day021_SkillBox_Homework.DataReciever;
using Ninject.Modules;

namespace Day021_SkillBox_Homework
{
    public class Bindings : NinjectModule
    {
        private readonly string _apiKey;

        public Bindings(string apiKey)
        {
            _apiKey = apiKey;
        }

        public override void Load()
        {
            Bind<IWeatherReciever>().To<WeatherReciever>().WithConstructorArgument(@"apiKey", _apiKey);;
            Bind<ICityInfoReciever>().To<CityInfoReciever>().WithConstructorArgument(@"apiKey", _apiKey);;
        }
    }
}