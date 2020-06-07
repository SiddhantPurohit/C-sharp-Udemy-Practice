//ExtensionMEthods allows us to add methods to an existing class without changing source code or creating inheritance of it.

using System;
using System.Linq;

namespace Extensionmethods
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            
            
                if (numberOfWords <= 0)
                    throw new ArgumentOutOfRangeException("number of words must be greater than 0 !");

                if (numberOfWords == 0)
                    return String.Empty;

                var words = str.Split(' ');

                if (words.Length < numberOfWords)
                    return str;

                return String.Join(" ", words.Take(numberOfWords));
            
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is really long blog post blah blah blah ...";
            var shortedPost = post.Shorten(2);
            Console.WriteLine(shortedPost);
        }
    }
}
