//lambda Expression are anonymous method.
//It has no access modifier.
//no name and no return statement.
//for convinience
//syntax
//args => expression
//() => ...
//X => ...
//(x,y,z) => ...

using System;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> square = number => number* number;
            Console.WriteLine(square(5));

            int multiplier = 10;
            Func<int, int> Multiplier = n => n * multiplier;
            Console.WriteLine(Multiplier(10));
        }
    }
}
