using System;

namespace EventManager
{
    public abstract class Event
    {
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public string GetStandardDetails()
        {
            return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.GetFullAddress()}";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"Event Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date}";
        }
    }
}
