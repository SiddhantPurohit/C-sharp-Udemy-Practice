using System;

namespace constructor_practice
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {
        }

        public Customer(int Id)
        {
            this.Id = Id;
        }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(10, "Siddhant");
            Console.WriteLine("Customer Id is :" + customer.Id);
            Console.WriteLine("Customer Name is :" + customer.Name);

            var customer1 = new Customer(11, "Sid");
            Console.WriteLine("Customer1 Id is :" + customer1.Id);
            Console.WriteLine("Customer1 Name is :" + customer1.Name);

            var customer2 = new Customer(12);
            Console.WriteLine("Customer2 Id is :" + customer2.Id);
            Console.WriteLine("Here we have used different constructor so name is not defined");

        }
    }
}
