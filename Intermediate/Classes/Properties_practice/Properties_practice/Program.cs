using System;

namespace Properties_practice
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }

        public Person (DateTime birtday)
        {
            Birthday = birtday;
        }
        
        public int Age ()
        {
            var timeSpan = DateTime.Today - Birthday;
            var years = timeSpan.Days / 365;
            return years;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1998, 10, 21));
            Console.WriteLine( person.Age() );
        }
    }
}
