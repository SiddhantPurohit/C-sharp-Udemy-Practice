//An Indexer is a special type of property that allows a class or structure to be accessed like an array for its private collection.
//An indexer can be defined the same way as property with this keyword and square brackets [].

using System;
using System.Collections.Generic;

namespace Indexers_practice
{
    public class HttpCookie
    {
        // Indexers is an easy way to acess elements in Dictionary
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //Indexers
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "ED";
            Console.WriteLine(cookie["name"]);
        }
    }
}
