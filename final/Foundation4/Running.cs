using System;

namespace FitnessApp
{
    public class Running : Activity
    {
        private float _distance; // distance in kilometer

        public Running(string date, int duration, float distance) : base(date, duration)
        {
            _distance = distance;
        }

        // the polymorphism bits below
        public override float GetDistance()
        {
            return _distance;
        }

        public override float GetSpeed()
        {
            return _distance / (_duration / 60.0f);
        }

        public override float GetPace()
        {
            return _duration / _distance;
        }

        public override string GetSummary()
        {
            return $"Running: {base.GetSummary()}";
        }
    }
}
