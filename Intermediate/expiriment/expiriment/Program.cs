using System;

namespace expiriment
{
    public class Wife
    {
        static public string name;
        static private int love;

        public static void getWhoisit()
        {
            Wife.name = Console.ReadLine();
        }

        public static void gethowmuch()
        {
            Wife.love = Convert.ToInt32(Console.ReadLine());
        }

        public static void Whoisit ()
        {
            Console.WriteLine("The love of your life is " + name +".");
        }

        public static void howmuch ()
        {
            Console.WriteLine("You love her "+ love + "%.");
        }
    }
    public class Daughter : Wife
    {
        static private string Dname;
        static private int Dlove;

        public static void getDWhoisit()
        {
            Daughter.Dname = Console.ReadLine();
        }

        public static void getDhowmuch()
        {
            Daughter.Dlove = Convert.ToInt32(Console.ReadLine());
        }

        public static void DWhoisit()
        {
            Console.WriteLine("The name of Daughter is " + Dname + ".");
        }

        public static void Whosmom()
        {
            Console.WriteLine("The mon of " + Dname + " is " + name + ".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of your wife");
            Wife.getWhoisit();

            Console.WriteLine("Enter how much you love her");
            Wife.gethowmuch();

            Console.WriteLine("Enter name of your Daughter ");
            Daughter.getDWhoisit();

            Console.WriteLine("Who is my wife?");
            Wife.Whoisit();

            Console.WriteLine("How much do I love her?");
            Wife.howmuch();

            Console.WriteLine("who is my daughter ?");
            Daughter.DWhoisit();

            Console.WriteLine("who is her mom?");
            Daughter.Whosmom();

        }
    }
}
