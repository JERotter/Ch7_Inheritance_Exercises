using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public double ScreenSz { get; set; }

        public Laptop(double screenSz, string year, string color, string os, double version): base (year, color, os, version)
        {
            ScreenSz = screenSz;

        }
    }
}
