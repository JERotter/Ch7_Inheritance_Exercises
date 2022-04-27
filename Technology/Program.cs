using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer(string year, string color, string os)
            Computer newMac = new Computer("2020","Red","Mac OS", 2.0);
            Console.WriteLine(Computer.HasHardDrive);
            Console.WriteLine(newMac.Color);
            Console.WriteLine(newMac.Version);
            newMac.UpdateVersion();
            Console.WriteLine();

            //Laptop(screenSz,year,color,os,version)
            Laptop macBook = new Laptop(13.5, "2019", "silver", "Mac OS", 3.0);
            Console.WriteLine(macBook.Color);
            Console.WriteLine(macBook.ScreenSz);
            Console.WriteLine(macBook.Version);
            macBook.UpdateVersion();
            Console.WriteLine();

            //SmartPhone(weightInGrams, year, color, os, version)
            SmartPhone galaxy10 = new SmartPhone("157g", "2022", "pink", "Droid", 6.0);
            Console.WriteLine(galaxy10.Color);
            Console.WriteLine(galaxy10.WeightInGrams);
            Console.WriteLine(galaxy10.Version);
            galaxy10.UpdateVersion();
            Console.WriteLine();

        }
    }
}
