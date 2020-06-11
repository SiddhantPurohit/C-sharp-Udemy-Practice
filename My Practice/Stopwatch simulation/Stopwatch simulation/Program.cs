using System;
using System.Threading;

namespace Stopwatch_simulation
{
    public class Stopwatch
    {
        public DateTime StarTime;
        public DateTime StopTime;
        public bool Isrunning;

        public DateTime StartTheTime ()
        {
            StarTime = DateTime.Now;
            Isrunning = true;
            return StarTime;
        }

        public DateTime StopTheWatch ()
        {
            StopTime = DateTime.Now;
            Isrunning = false;
            return StopTime;
        }

        public TimeSpan TotalSpan ()
        {
            TimeSpan TotalTime = StopTime - StarTime;
            return TotalTime;
        }

        public TimeSpan Resetthewatch()
        {
            TimeSpan TotalTime = TimeSpan.Zero;
            return TotalTime;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Enter 1 to start the stopwatch, 2 to stop the stopwatch, 3 to display result, 4 to restart and 5 to exit");

            var ToExit = true;
            while(ToExit == true)
            {
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        if (stopwatch.Isrunning == true)
                        {
                            Console.WriteLine("Stopwatch is already running");
                        }
                        Console.WriteLine("start");
                        stopwatch.StartTheTime();
                        break;
                    case 2:
                        if (stopwatch.Isrunning == false)
                        {
                            Console.WriteLine("You didnt start the watch");
                        }
                        Console.WriteLine("stop");
                        stopwatch.StopTheWatch();
                        break;
                    case 3:
                        Console.WriteLine("Total time duration is :" + stopwatch.TotalSpan());
                        break;
                    case 4:
                        Console.WriteLine("restart");
                        break;
                    case 5:
                        Console.WriteLine("exit");
                        ToExit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }


    }
}

            