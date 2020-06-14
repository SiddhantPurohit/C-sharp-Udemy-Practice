using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Book
    {
        public String Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable <Book> Getbook()
        {
            return new List<Book>
            {
                new Book() {Title ="Beginners", Price = 5},
                new Book() {Title ="Intermediate", Price = 9.99f},
                new Book() {Title ="Advance", Price = 12},
                new Book() {Title ="OOP", Price = 7},
                new Book() {Title ="SQL", Price = 9}
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().Getbook();

            //LINQ Query Operators
            var cheaperbooks =
                from b in books
                where b.Price < 6
                orderby b.Title
                select b;

            //LINQ extension methods
            var cheapbooks = books
                                   .Where(books => books.Price < 10)
                                   .OrderBy(books => books.Title)
                                   .Select(books => books.Title);



            foreach (var book in cheapbooks)
                Console.WriteLine(book);
            

        }
    }
}
