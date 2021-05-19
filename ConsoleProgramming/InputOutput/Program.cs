using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;

            //Getting and storing value from input
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //Printing values to console screen
            Console.Write("Your Name is: ");
            Console.WriteLine(name);
        }
    }
}
