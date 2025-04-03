using System;

namespace FitnessApp
{
    public abstract class Activity
    {
        protected string _date;
        protected int _duration; // Duration in minutes

        public Activity(string date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract float GetDistance();
        public abstract float GetSpeed();
        public abstract float GetPace();

        public virtual string GetSummary()
        {
            return $"{_date} - Duration: {_duration} min, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
        }
    }
}
