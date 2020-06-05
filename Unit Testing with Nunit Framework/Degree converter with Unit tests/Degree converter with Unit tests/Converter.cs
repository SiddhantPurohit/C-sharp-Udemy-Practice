using System;
using System.Collections.Generic;
using System.Text;

namespace Degree_converter_with_Unit_tests
{
    class Converter
    {
        public static double ToFarenheit(double Celcius)
        {
            return ((Celcius * 9 / 5) + 32);
        }
        public double ToCelcius (double Farenheit)
        {
            return ((32 * Farenheit - 32) * 5 / 9);
        }
    }
}
