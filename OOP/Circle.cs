using System;

namespace OOP
{
    internal class Circle
    {
        float _pi = 3.141f;
        int _Radius;
        public Circle(int radius)
        {
            _Radius = radius;
        }
        public float getArea()
        {
            return _Radius * _Radius * _pi;
        }
    }
}
