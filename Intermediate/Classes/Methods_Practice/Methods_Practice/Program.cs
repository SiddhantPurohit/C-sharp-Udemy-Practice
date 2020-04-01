using System;

namespace Methods_Practice
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int Mul(params int[] numbers)
        {
            var mul = 1;
            foreach (var number in numbers)
            {
                mul *= number;
            }
            return mul;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator1 = new Calculator();
            Console.WriteLine("addition is : " + calculator1.Add(1,2));
            Console.WriteLine("multiplication is: "+ calculator1.Mul(1,4,5,6,7));
        }
    }
}
