using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator =  new Calculator();
                var result =  calculator.Divide(5,0);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex);
            }
            catch (ArithmeticException ex)
            {
                System.Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Sorry, an unexpected error occurred" + ex);
            }




            StreamReader streamReader = null;
            try
            {
               streamReader = new StreamReader(@"c:\file.zip");
               var content = streamReader.ReadToEnd();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Sorry, an unexpected error occurred while reading dile");
            }
            finally
            {
                if(streamReader != null)
                    streamReader.Dispose();
            }


            try
            {
                using(var streamReader1 =  new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader1.ReadToEnd();
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Sorry, an unexpected error.");
            }

            System.Console.WriteLine("*********************");
            try
            {
                var api = new YouTubeApi();
                var videoes = api.GetVideo("Rohan");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
