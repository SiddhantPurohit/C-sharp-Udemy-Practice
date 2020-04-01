using System;
using System.Threading;

namespace Stopwatch_simulation
{
    public class Stopwatch
    {
        public DateTime StarTime;
        public DateTime StopTime;

        public DateTime StartTheTime ()
        {
            StarTime = DateTime.Now;
            return StarTime;
        }

        public DateTime StopTheWatch ()
        {
            StopTime = DateTime.Now;
            return StopTime;
        }

        public TimeSpan TotalSpan ()
        {
            TimeSpan TotalTime = StopTime - StarTime;
            return TotalTime;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.StartTheTime();
            Thread.Sleep(1000);
            stopwatch.StopTheWatch();
            Console.WriteLine("Total time duration is :" + stopwatch.TotalSpan());
        }


    }
}

            