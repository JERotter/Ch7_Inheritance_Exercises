using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public string WeightInGrams { get; set; }

        public SmartPhone(string weightInGrams, string year, string color, string os, double version, double ram) : base(year, color, os, version, ram)
        {
            WeightInGrams = weightInGrams;
        }

        public void DecreaseRam()
        {
            Ram = this.Ram - 4;
        }
    }
}
