//syntax
/*<return type> this[<parameter type> index]
{
    get
    {
        // return the value from the specified index of an internal collection
    }
    set
    {
        // set values at the specified index in an internal collection
    }
}*/

using System;

namespace Indexers_more_info
{
    class StringDataStrore
    {
        private string[] strArr = new string[10];
        public string this [int index]
        {
            get
            {
                return strArr[index];
            }

            set
            {
                strArr[index] = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var strStore = new StringDataStrore();

            strStore[0] = "one";
            strStore[1] = "two";
            strStore[2] = "three";
            strStore[3] = "four";

            for (int i = 0; i < 5; i++)
                Console.WriteLine(strStore[i]);

            Console.WriteLine(strStore[2]);
        }
    }
}
