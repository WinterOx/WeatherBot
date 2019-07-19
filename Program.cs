using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Ninject;
using Ninject.Parameters;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Day021_SkillBox_Homework
{
    class Program
    {
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var accuWeatherApiKey = configuration.GetSection("accuweather_apikey").Value;
            var telegramApiKey = configuration.GetSection("telegram_apikey").Value;

            new StandardKernel(new Bindings(accuWeatherApiKey))
                .Get<Application>(new ConstructorArgument(@"apikey", telegramApiKey))
                .Run();

            Console.ReadKey();
        }
    }
}