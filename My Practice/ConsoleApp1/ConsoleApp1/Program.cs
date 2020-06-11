/*Write a program and ask the user to enter a series of number. Find the maximum of the numbers and display it on console*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you want to sort");
            int Howmanynumbers = Getting();
            Console.WriteLine("you want to sort:" + Howmanynumbers + " Numbers");
            int[] Numberstosort = new int[Howmanynumbers];
            Console.WriteLine("enter numbers");
            for (int i = 0; i < Howmanynumbers; i++)
            {
                Numberstosort[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Howmanynumbers; i++)
            {
                Console.WriteLine("you entered " +Numberstosort[i]);
            }
            Array.Sort(Numberstosort);
            Console.WriteLine("the greatest number is " + Numberstosort[Howmanynumbers - 1]);


        }
        public static int Getting ()
        {
            int Howmanynumbers = Convert.ToInt32(Console.ReadLine());
            return Howmanynumbers;
        }
        
    }
}
