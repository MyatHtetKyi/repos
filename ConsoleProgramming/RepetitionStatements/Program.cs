using System;

namespace RepetitionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop(Counter Controlled) finite loop
           for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("I am a Winner");
                Console.WriteLine($"Counter: {i}");
            }
            Console.WriteLine();
            Console.WriteLine("for loop finished;");

            //While Loop(Condition controlled- Pre Check)infinite loop
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("input a number(0-4)");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"you entered {n}");
            }
            Console.WriteLine();
            Console.WriteLine("while loop finished;");

            //do...While Loop(Condition controlled- Post Check)
            do {
                Console.WriteLine("input a number(0-4)");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"you entered {n}");
            } while (n < 5) ;
            Console.WriteLine();
            Console.WriteLine("do while loop finished;");
        }
    }
}
