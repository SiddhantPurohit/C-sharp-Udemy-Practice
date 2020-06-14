using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQpractice
{
    public class Book
    {
        public string Tittle { get; set; }
        public float Price { get; set; }
    }

    public class Toy
    {
        public string NameOfToy { get; set; }
        public float Price { get; set; }
    }

    public class BookRepo
    {
        public List<Book> GetBook()
        {
            return new List<Book>
            {
                new Book() {Tittle =" My Book 1", Price = 10},
                new Book() {Tittle =" My Book 2", Price = 20},
                new Book() {Tittle =" My Book 3", Price = 30},
                new Book() {Tittle =" My Book 4", Price = 40},
                new Book() {Tittle =" My Book 5", Price = 5}
            };
        }
    }

    public class Toyrepo
    {
        public List<Toy> GetToy()
        {
            return new List<Toy>
            {
                new Toy() {NameOfToy = "My toy 1.1", Price = 10},
                new Toy() {NameOfToy = "My toy 1.2", Price = 20},
                new Toy() {NameOfToy = "My toy 1.3", Price = 30},
                new Toy() {NameOfToy = "My toy 1.4", Price = 40},
                new Toy() {NameOfToy = "My toy 1.5", Price = 5}
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookRepo();
            var books = book.GetBook();

            var toy = new Toyrepo();
            var toys = toy.GetToy();

            var cheapBook = from b in books
                            where b.Price < 25 && b.Price > 5
                            join t in toys
                            on b.Price equals t.Price
                            orderby b.Tittle
                            select new
                            {
                                b.Price,
                                b.Tittle,
                                t.NameOfToy
                            };


            foreach(var bk in cheapBook)
            {
                Console.WriteLine(bk);
            }
            


        }
    }
}
