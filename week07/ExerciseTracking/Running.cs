using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private float _distance;

        public Running(DateTime date, int duration, float distance) : base("Running", date, duration)
        {
            _distance = distance;
        }

        public override float GetDistance()
        {
            return _distance;
        }
        public override float GetSpeed()
        {
            return (_distance / _duration) * 60;
        }

        public override float GetPace()
        {
            return _duration / _distance;
        }

        public override void GetSummary()
        {
            Console.WriteLine("----- Running -----");
            Console.WriteLine($"{_date:dd MMM yyyy} "); 
            Console.WriteLine($"{_name} ({_duration} min))");
            Console.WriteLine($"Distance: {_distance} km, Speed: {GetSpeed()} kph)");
            Console.WriteLine($"Pace: {GetPace()} min per km");
            Console.WriteLine("-------------------");
        }

    }
}