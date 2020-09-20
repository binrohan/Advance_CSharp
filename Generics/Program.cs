using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new List();
            // numbers.Add(10);

            var books = new BookList();
            // books.Add(book);

            var Gnumbers = new GenericList<int>();
            // Gnumbers.Add(10);

            var Gbooks = new GenericList<Book>();
            // books.Add(new Book());

            var dictionary = new GenericDictionary<String, Book>();
            // dictionary.Add("123", book);

            var number = new Nullable<int>();
            System.Console.WriteLine("Has Value ? " + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
 