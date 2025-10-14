using System;

namespace Shapes
{
    public class Circle : Shapes
    {
        private float _radius;

        public Circle()
        {
        }

        public float GetRadius()
        {
            return _radius;
        }

        public void SetRadius(float radius)
        {
            _radius = radius;
        }

        public override float GetArea()
        {
            return (float)(Math.PI * _radius * _radius);
        }
    }
}