using System;
using System.Text.Json;

namespace CoreRtRdXmlExamples
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public int[] NextTemperatures { get; set; }
    }

    public class WeatherForecastWithNullable
    {
        public DateTimeOffset Date { get; set; }
        public int? TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }

    class Program
    {
        static void SerializeNonNullableProperties()
        {
            var weatherForecast = new WeatherForecast()
            {
                TemperatureCelsius = 15,
                Summary = "Hot",
                Date = DateTimeOffset.UtcNow,
            };
            string jsonString;
            jsonString = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(jsonString);
        }

        static void SerializeNullableProperties()
        {
            var weatherForecast = new WeatherForecastWithNullable()
            {
                TemperatureCelsius = 15,
                Summary = "Hot",
                Date = DateTimeOffset.UtcNow,
            };
            string jsonString;
            jsonString = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(jsonString);
        }
        static void Main(string[] args)
        {
            SerializeNonNullableProperties();
            SerializeNullableProperties();
        }
    }
}
