using System;
namespace Test1
{
    public class Point
    {
        private int x;
        private int y;
        public int X {
            get {
                return x;
            }
            set {
                x = value;
            }

        }
        public int Y {
            get; set;
        }
        public Point()
        {
            X = Y = 0;
        }
        public Point (int x, int y) {
            X = x;
            Y = y;
        }
    }
}
