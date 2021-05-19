using System;

namespace CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Assignment Operator
            int num;
            num = 5;
            Console.WriteLine($"Assigned value to var : {num}");

            //Arithmetic Operator
            int x = 11;
            int y = 3;
            Console.WriteLine($"Addition : {x+y}");
            Console.WriteLine($"Subtraction : {x-y}");
            Console.WriteLine($"Multiply : {x*y}");
            Console.WriteLine($"Division : {x/y}");
            Console.WriteLine($"Modulus : {x%y}");

            x = x + 4;
            Console.WriteLine($"New value of x : {x}");
            Console.WriteLine($"Addition : {x + y}");
            Console.WriteLine($"Subtraction : {x - y}");
            Console.WriteLine($"Multiply : {x * y}");
            Console.WriteLine($"Division : {x / y}");
            Console.WriteLine($"Modulus : {x % y}");


            //Compound Assignment Operator
            x += 4;
            Console.WriteLine(x);
            x -= 4;
            Console.WriteLine(x);
            x *= 4;
            Console.WriteLine(x);
            x /= 4;
            Console.WriteLine(x);
            x %= 4;
            Console.WriteLine(x);

        }
    }
}
