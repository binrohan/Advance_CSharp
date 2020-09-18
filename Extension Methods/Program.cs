using System;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post =  "This is supposed to be a very long blog post";
            var shortenPost = post.Shorten(6);

            System.Console.WriteLine(shortenPost + "....");
        }
    }
}
