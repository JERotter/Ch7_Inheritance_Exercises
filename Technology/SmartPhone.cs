using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public string WeightInGrams { get; set; }

        public SmartPhone(string weightInGrams, string year, string color, string os, double version) : base(year, color, os, version)
        {
            WeightInGrams = weightInGrams;
        }
    }
}
