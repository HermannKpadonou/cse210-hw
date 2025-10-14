using System;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        private float _length;
        private float _width;

        public Rectangle()
        {
        }

        public float GetLength()
        {
            return _length;
        }

        public void SetLength(float length)
        {
            _length = length;
        }

        public float GetWidth()
        {
            return _width;
        }

        public void SetWidth(float width)
        {
            _width = width;
        }

        public override float GetArea()
        {
            return _length * _width;
        }
    }
}