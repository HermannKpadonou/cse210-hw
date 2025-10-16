using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private float _speed;

        public Cycling(DateTime date, int duration, float speed) 
            : base("Cycling", date, duration)
        {
            _speed = speed;
        }

        public override float GetDistance()
        {
            return (_speed * _duration) / 60;
        }

        public override float GetSpeed()
        {
            return _speed;
        }

        public override float GetPace()
        {
            return 60 / _speed;
        }

        public override void GetSummary()
        {
            float distance = GetDistance();
            float speed = GetSpeed();
            float pace = GetPace();

            Console.WriteLine("----- Cycling -----");
            Console.WriteLine($"{_date:dd MMM yyyy}");
            Console.WriteLine($"{_name} ({_duration} min)");
            Console.WriteLine($"Distance: {distance:F1} km, Speed: {speed:F1} kph))");
            Console.WriteLine($"Pace: {pace:F1} min per km, Pace: {pace:F1} min per km");
            Console.WriteLine("-------------------");
        }
    }
}