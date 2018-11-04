using System;
namespace Test1
{
    public class Color
    {
        // Static Area:
        //      Default color
        private static int dRed;
        private static int dGreen;
        private static int dBlue;
        public static int DefaultRed
        {
            get
            {
                return dRed;
            }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    dRed = value;
                }
            }
        }
        public static int DefaultGreen
        {
            get
            {
                return dGreen;
            }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    dGreen = value;
                }
            }
        }
        public static int DefaultBlue
        {
            get
            {
                return dBlue;
            }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    dBlue = value;
                }
            }
        }
        private int red;
        private int blue;
        private int green;
        public int Red {
            get {
                return red;
            }
            set {
                if (0 <= value && value <= 255) {
                    red = value;
                }
            }
        }
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    green = value;
                }
            }
        }
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    blue = value;
                }
            }
        }
        public Color()
        {
            SetColor(0);
        }
        public Color(int r, int g, int b) {
            SetColor(r, g, b);
        }
        public Color SetColor(int c) {
            Red = Blue = Green = c;
            return new Color(Red, Green, Blue);
        }
        public Color SetColor(int r, int g, int b) {
            Red = r;
            Blue = b;
            Green = g;
            return new Color(Red, Green, Blue);
        }
        public static Color SetDefaultColor(int c)
        {
            DefaultRed = DefaultBlue = DefaultGreen = c;
            return new Color(DefaultRed, DefaultGreen, DefaultBlue);
        }
        public static Color SetDefaultColor(int r, int g, int b) {
            DefaultRed = r;
            DefaultGreen = g;
            DefaultBlue = b;
            return new Color(DefaultRed, DefaultGreen, DefaultBlue);
        }
    }
}
