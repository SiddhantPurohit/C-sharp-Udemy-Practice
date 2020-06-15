using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipkartSimulationUsingLinq
{
    public class Laptop
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public int ScreenSize { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
    }

    public class LaptopRepo
    {
        public List<Laptop> GetLaptop()
        {
            return new List<Laptop>
            {
                new Laptop () {Type="Gaming",Price = 50000, ScreenSize=15, Ram=16, Storage = 2048},
                new Laptop () {Type="Work",Price = 40000, ScreenSize=13, Ram=8, Storage = 1024/2},
                new Laptop () {Type="Low Gaming",Price = 30000, ScreenSize=14, Ram=8, Storage = 1024},
                new Laptop () {Type="Casual use",Price = 20000, ScreenSize=12, Ram=4, Storage = 1024/4},
                new Laptop () {Type="Low end",Price = 10000, ScreenSize=10, Ram=2, Storage = 1024/4},
                new Laptop () {Type="Premium",Price = 100000, ScreenSize=20, Ram=32, Storage = 2048*2}
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new LaptopRepo();
            var listoflaptops = laptop.GetLaptop();

            Console.WriteLine("Welcome to Online laptop store");
            Console.WriteLine("Enter the Maximum Price you are intrested in");
            var interestedprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Minimum Screen Size in inches you are intrested in");
            var interestedScreenSize= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Minimum Ram in GB you are intrested in");
            var interestedRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Minimum Storage in GB you are intrested in");
            var interestedStorage = Convert.ToInt32(Console.ReadLine());

            var suitableLaptop = from l in listoflaptops
                                 where l.Price <= interestedprice &&
                                       l.ScreenSize >= interestedScreenSize &&
                                       l.Ram >= interestedRam &&
                                       l.Storage >= interestedRam
                                 orderby l.Price descending
                                 select l.Type;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your search result are :");

            foreach(var lap in suitableLaptop)
            {
                Console.WriteLine(lap);
            }

            Console.Beep();
            Console.ResetColor();
           
        }
    }
}
