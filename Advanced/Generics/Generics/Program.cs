using System;
using System.Collections.Generic;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add (T value)
        {

        }

        public T this [int index]
        {
            get { throw new NotImplementedException () ; }
        }

    }
    
    public class GenericDict<Tvalue ,Tkey>
    {
        public void Add(Tvalue value , Tkey key)
        {

        }
    }

    //where T : Icomparable
    //where T : Product
    //where T : Struct
    //where T : class
    //where T : new()
    public class Utilities <T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max (T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<string> ();
            books.Add("c#");

            //In practice we have to use generic list and dont have to create them.
            //System.Collections.Generic. here we can access all the gerenics in .Net framework.

            var dict = new GenericDict<int, string>();
            dict.Add(10, "sid");

;
        }
    }
}
