using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int duration, int laps) 
            : base("Swimming", date, duration)
        {
            _laps = laps;
        }

        public override float GetDistance()
        {
            
            return (_laps * 50) / 1000f;
        }

        public override float GetSpeed()
        {
            float distance = GetDistance();
            return (distance / _duration) * 60;
        }

        public override float GetPace()
        {
            float distance = GetDistance();
            return _duration / distance;
        }

        public override void GetSummary()
        {
            float distance = GetDistance();
            float speed = GetSpeed();
            float pace = GetPace();

            Console.WriteLine("----- Swimming -----");
            Console.WriteLine($"{_date:dd MMM yyyy} ");
            Console.WriteLine($"{_name} ({_duration} min)");
            Console.WriteLine($"Distance: {distance:F1} km, Speed: {speed:F1} kph");
            Console.WriteLine($"Pace: {pace:F1} min per km, Laps: {_laps}");
            Console.WriteLine("-------------------");
        }
    }
}