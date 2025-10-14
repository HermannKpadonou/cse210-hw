using System;

namespace Shapes
{
    public class Square : Shapes
    {
        private float _sideLength;

        public Square()
        {
        }

        public float GetSideLength()
        {
            return _sideLength;
        }

        public void SetSideLength(float sideLength)
        {
            _sideLength = sideLength;
        }

        public override float GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}

