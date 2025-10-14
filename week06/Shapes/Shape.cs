using System;

namespace Shapes
{
    public class Shapes
    {

        public string _color;
        public Shapes()
        {
        }
        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public virtual float GetArea()
        {
            return 0;
        }
    }
}