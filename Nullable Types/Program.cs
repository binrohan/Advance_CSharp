using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            System.Console.WriteLine("Get value or default" + date.GetValueOrDefault());
            System.Console.WriteLine("Has value" + date.HasValue);
            // System.Console.WriteLine("Value " + date.Value);

            DateTime? date1 = new DateTime(2014, 1, 1);
            //DateTime date2 = date1;
            DateTime date2 = date1.GetValueOrDefault();

            DateTime? date3 = date2;
            System.Console.WriteLine(date3.GetValueOrDefault());

            // Traditional way
            if(date != null)
                date2 = date.GetValueOrDefault();
            else
            {
                date2 = DateTime.Today;
            }
            System.Console.WriteLine(date2);

            // Null Coalescing Operator
            date2 = date ?? DateTime.Today;
            System.Console.WriteLine(date2);

            // Ternary Operator
            date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            System.Console.WriteLine(date2);
        }
    }
}
