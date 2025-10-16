using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        protected string _name;

        protected DateTime _date;
        protected int _duration;


        public Activity(string name, DateTime date, int duration)
        {
            _name = name;
            _duration = duration;
            _date = date;
        }
        
        public abstract float GetDistance();
        public abstract float GetSpeed();
        public abstract float GetPace();

        public virtual void GetSummary()
        {
            float distance = GetDistance();
            float speed = GetSpeed();
            float pace = GetPace();

            Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {_name} ({_duration} min) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km");

        }
    }
}