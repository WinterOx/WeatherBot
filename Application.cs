using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Day021_SkillBox_Homework.DataReciever;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Day021_SkillBox_Homework
{
    public class Application
    {
        private readonly IWeatherReciever weatherReciever;
        private readonly ICityInfoReciever cityInfoReciever;
        private readonly TelegramBotClient telegramBotClient;

        private static readonly Regex cityNameRegexp =
            new Regex(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", RegexOptions.Compiled);

        public Application(
            string apikey,
            IWeatherReciever weatherReciever,
            ICityInfoReciever cityInfoReciever
        )
        {
            telegramBotClient = new TelegramBotClient(apikey);
            this.weatherReciever = weatherReciever;
            this.cityInfoReciever = cityInfoReciever;
        }

        public void Run()
        {
            telegramBotClient.OnMessage += HandleMessage;
            telegramBotClient.StartReceiving();
        }

        private void HandleMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
            {
                telegramBotClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    "Я умею обрабатывать только названия городов."
                );
                return;
            }

            var cityName = e.Message.Text;
            if (cityName == null)
            {
                return;
            }

            if (!cityNameRegexp.IsMatch(cityName))
            {
                telegramBotClient.SendTextMessageAsync(
                        e.Message.Chat.Id,
                    $"\'{cityName}\' - некорректное название города. Введите, пожалуйста на английском."
                );
                return;
            }

            var cityModel = cityInfoReciever.GetCityInformation(cityName);
            if (!cityModel.IsSuccess)
            {
                telegramBotClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"У меня нет информации о городе \'{cityName}\'."
                );
                return;
            }

            var weatherDataModel = weatherReciever.GetWeather(cityModel.CityCode);

            telegramBotClient.SendTextMessageAsync(
                e.Message.Chat.Id,
                $"{cityModel}{Environment.NewLine}{weatherDataModel}"
            );
        }
    }
}