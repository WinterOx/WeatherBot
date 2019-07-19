using System;

namespace Day021_SkillBox_Homework.DataReciever.Models
{
    public class WeatherDataModel
    {
        public double? MinimumTemperature { get; set; }
        public double? MaximumTemperature { get; set; }
        public TimeSpan? SunlightDuration { get; set; }
        public double? RealFeelTemperature { get; set; }
        public double? WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public int? PrecipitationProbability { get; set; }

        public override string ToString()
        {
            return $"Температура: {StringifyTemperature(MinimumTemperature)}...{StringifyTemperature(MaximumTemperature)}"
                + (RealFeelTemperature.HasValue ? $"{Environment.NewLine}Реальная температура: {StringifyTemperature(RealFeelTemperature)}" : string.Empty)
                + (SunlightDuration.HasValue ? $"{Environment.NewLine}Длительность солнцестояния: {SunlightDuration.Value}" : string.Empty)
                + (WindSpeed.HasValue ? $"{Environment.NewLine}Скорость ветра: {WindSpeed}км/ч. Направление ветра: {WindDirection}" : string.Empty)
                + (PrecipitationProbability.HasValue ? $"{Environment.NewLine}Вероятность осадков: {PrecipitationProbability.Value}%" : string.Empty);
        }

        private string StringifyTemperature(double? temperature)
        {
            if (!temperature.HasValue)
                return String.Empty;
            if (Math.Abs(temperature.Value) < 1e-6)
                return "0";
            return temperature.Value > 0
                ? $"+{temperature.Value}"
                : $"-{temperature.Value}";
        }

    }
}