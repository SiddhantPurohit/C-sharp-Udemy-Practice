using System;

namespace Inheritance_constructor
{
    class vehicals
    {
        public readonly string RegistrationNumber;

        public vehicals(string RegistrationNumber)
        {
           this.RegistrationNumber = RegistrationNumber;
        }

        public void RegisterTheVehical ()
        {
            Console.WriteLine("Vehical is regitered at :" + RegistrationNumber);
        }
            
    }

    class car : vehicals
    {
        public car(string RegistrationNumber)
            : base(RegistrationNumber)
        {

        }

        public void RegisterTheCar ()
        {
            Console.WriteLine("Car is registered at :" + RegistrationNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new car("MH99AA9999");
            car1.RegisterTheVehical(); //car took the method from vehicals class
            car1.RegisterTheCar(); //car took method from car class 
        }
    }
}
