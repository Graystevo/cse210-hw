using System;

namespace FitnessApp
{
    public class Swimming : Activity
    {
        private int _laps;
        private const float LapDistance = 0.05f; // Each lap is 50 meters (converted to km)

        public Swimming(string date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override float GetDistance()
        {
            return _laps * LapDistance;
        }

        public override float GetSpeed()
        {
            return GetDistance() / (_duration / 60.0f);
        }

        public override float GetPace()
        {
            return _duration / GetDistance();
        }

        public override string GetSummary()
        {
            return $"Swimming: {base.GetSummary()}";
        }
    }
}
