using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(30, 50);
            Circle circle1 = new Circle(120, 89, 3);
            Point point3 = new Point(10, 20);
            Point point4 = new Point(15, 17);
            Point point2 = circle1;
            //Circle circle3 = (Circle)point4;
            circle1 = (Circle)point1;
            //Circle circle2 = point3;
            Console.WriteLine("Hello World!");
        }
    }
}
