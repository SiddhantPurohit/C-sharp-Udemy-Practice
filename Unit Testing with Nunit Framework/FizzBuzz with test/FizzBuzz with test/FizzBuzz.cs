using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_with_test
{
    class FizzBuzz
    {
        public const int Test = 20;
        public static string Ask(int i)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "";
            }

        }
    }
}
