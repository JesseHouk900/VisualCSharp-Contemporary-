using System;
namespace Test1
{
	public class Circle : Shape
    {
        private double radius;
        public double Radius {
            get {
                return radius;
            }
            set {
                if (value >= 0) {
                    radius = value;
                }
            }
        }
        public Circle() : base()
        {
            Radius = 1;
            // ItsColor = Color.SetDefaultColor(255);
        }
        public Circle(double r, int x, int y) : base("Circle", x, y) {
            Radius = r;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
