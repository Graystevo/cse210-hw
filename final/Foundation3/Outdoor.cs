using System;

namespace EventManager
{
    public class Outdoor : Event
    {
        private string _weatherForecast;

        public Outdoor(string title, string description, string date, string time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nWeather Forecast: {_weatherForecast}";
        }
    }
}
