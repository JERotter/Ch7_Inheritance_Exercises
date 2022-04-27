using System;
namespace Technology
{
    public class Computer //parent
    {
        public static readonly bool HasHardDrive = true;
        public string Year {get; set;}
        public string Color {get; set;}
        public string Os {get; set;}
        public double Version {get; set;}
        

        public Computer(string year, string color, string os, double version)
        {
            //HardDrive = true;
            Year = year;
            Color = color;
            Os = os;
            Version = version;

        }

        public void UpdateVersion()
        {
            Version = Version + 0.5;
            Console.WriteLine($"Version update: {Version}");
        }
    }
}
