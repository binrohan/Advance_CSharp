using System;
using System.Linq;

namespace Linq_
{
    class Program
    {
        static void Main(string[] args)
        {
            var books =  new BookRepository().GetBooks();

            //Linq Query Operator
            var cheaperBooks = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            // Linq Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            var bookQuery = books.Single(b => b.Title == "ASP.Net MVC");
            var bookQuerySingleOrDefault = books.SingleOrDefault(b => b.Title == "ASP.Net");

            var bookQueryFirst =  books.First(b => b.Title == "C# Advanced Topics");
            var bookQueryFirstOrDefault =  books.FirstOrDefault(b => b.Title == "C# Advanced");

            System.Console.WriteLine("First or Default " + bookQueryFirstOrDefault);
            System.Console.WriteLine("First " + bookQueryFirst.Price);

            var bookQueryLast =  books.Last(b => b.Title == "C# Advanced Topics");
            var bookQueryLastOrDefault =  books.LastOrDefault(b => b.Title == "C# Advanced");

            System.Console.WriteLine("Last or Default " + bookQueryLastOrDefault);
            System.Console.WriteLine("Last " + bookQueryLast.Price);

            System.Console.WriteLine("Single" + bookQuery.Title);
            if(bookQuerySingleOrDefault != null)
                System.Console.WriteLine("Single Or Default " + bookQuerySingleOrDefault.Title);

            foreach (var book in cheapBooks)
            {
                System.Console.WriteLine(book);
            }
            foreach (var book in cheaperBooks)
            {
                System.Console.WriteLine(book.Title + " " + book.Price);
            }

            // Skip and Take
            System.Console.WriteLine("Skip and Take");
            var bookQuerySkipAndTake =  books.Skip(2).Take(2);
            foreach (var book in bookQuerySkipAndTake)
            {
                System.Console.WriteLine(book.Title + " " + book.Price);
            }

            var count = books.Count();
            System.Console.WriteLine("Number of books in repository " + count);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            System.Console.WriteLine("Max price " + maxPrice + "\n" + "Min Price " + minPrice);

            var totalPrice = books.Sum(b => b.Price);
            System.Console.WriteLine("Total Price " + totalPrice);
            
            var averagePrice = books.Average(b => b.Price);
            System.Console.WriteLine("Average Price " + averagePrice);
        }
    }
}
