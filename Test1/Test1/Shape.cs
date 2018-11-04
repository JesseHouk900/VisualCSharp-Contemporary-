using System;
namespace Test1
{
    public abstract class Shape : Point
    {
        private string form;
        private Color itsColor;
        public string Form {
            get;
        }
        public Color ItsColor {
            set {
                itsColor.Red = value.Red;
                itsColor.Green = value.Green;
                itsColor.Blue = value.Blue;
            }
        }
        public Shape() : base()
        {
            form = "null";
        }

        public Shape(string figure, int x = 0, int y = 0) : base(x, y) {
            form = figure;
        } 

        public abstract double Area();

        public void setCenter(int x, int y) {
            X = x;
            Y = y;
        }

    }
}
