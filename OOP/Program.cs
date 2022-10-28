using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle CircleArea = new Circle(5);
            Console.WriteLine(CircleArea.getArea());
            Circle CircleArea2 = new Circle(6);
            Console.WriteLine(CircleArea2.getArea());
        }
    }
}
