using System;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second no: ");
            int n2 = int.Parse(Console.ReadLine());

            int result = 0;
            try
            {
                 result = n1 / n2;
                Console.WriteLine($"Result:{result}");

                //File.ReadAllText("non-existing.file");
                if (File.Exists(@"C:\Users\GICM"))
                {
                    Console.WriteLine("file exists");
                }
            }
            catch(IOException  e)
            {
                //throw;
                Console.WriteLine($"Illegal Operation;{e.Message}");
            }
            finally
            {
                Console.WriteLine("End of program;");
                //Console.WriteLine($"Result:{result}");
            }
        }
    }
}
