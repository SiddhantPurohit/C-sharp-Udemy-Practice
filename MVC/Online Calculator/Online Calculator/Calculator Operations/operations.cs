using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_Calculator.Models;

namespace Online_Calculator.Calculator_Operations
{
    public class operations
    {
        
        public int calculation(int input1, int input2, string operation)
        {
            if(operation == "add")
            {
                var result = input1 + input2;
                return result;
            }

            if (operation == "sub")
            {
                var result = input1 - input2;
                return result;
            }

            if (operation == "mul")
            {
                var result = input1 * input2;
                return result;
            }

            else
            {
                var result = input1 / input2;
                return result;
            }




        }
    }
}