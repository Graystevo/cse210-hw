using System;

namespace FitnessApp
{
    public class Cycling : Activity
    {
        private float _speed; // dpeed in km/h

        public Cycling(string date, int duration, float speed) : base(date, duration)
        {
            _speed = speed;
        }

        // the polymorphism bits below
        public override float GetDistance()
        {
            return _speed * (_duration / 60.0f);
        }

        public override float GetSpeed()
        {
            return _speed;
        }

        public override float GetPace()
        {
            return 60.0f / _speed;
        }

        public override string GetSummary()
        {
            return $"Cycling: {base.GetSummary()}";
        }
    }
}
