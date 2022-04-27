using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public double ScreenSz { get; set; }

        public Laptop(double screenSz, string year, string color, string os, double version, double ram) : base (year, color, os, version, ram)
        {
            ScreenSz = screenSz;

        }

        public void IncreaseRam()
        {
            Ram = this.Ram + 4;
        }
    }
}
