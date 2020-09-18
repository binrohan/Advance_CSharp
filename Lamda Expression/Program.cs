using System;

namespace Lamda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number*number;

            System.Console.WriteLine(square(5));

            const int factor =  5;

            Func<int, int> multipler = n => n*factor;

            var result =  multipler(10);
            System.Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(IsCheaperThen10Dollars);
            foreach (var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }
            var cheapBooksLamda = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooksLamda)
            {
                System.Console.WriteLine(book.Title + book.Price);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }

        static bool IsCheaperThen10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
