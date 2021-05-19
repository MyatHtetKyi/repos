using System;

namespace Methods
{
    class Program
    {
        //void functions
       static void PrintName()
        {
            Console.WriteLine("Hello ,Myat Htet Kyi!");

        }
        static void PrintName(string name)
        {
            Console.WriteLine(" Upper Case: "+name.ToUpper());
            Console.WriteLine(" Length: " + name.Length);
            Console.WriteLine(" Contains(M): " + name.Contains("M"));
            Console.WriteLine(" Trim: " + name.Trim());
            Console.WriteLine(" GetType: " + name.GetType());
        }
        static void PrintNameLowerCase(string name)
        {
            Console.WriteLine(" LowerCase: " + name.ToLower());

        }
        //Values returning functions
        static int LargestNumber(int num1, int num2, int num3)
        {
            int largest = num1;
            if (num2 > largest)
            {
                largest = num2;
            }
            if (num3 > largest)
            {
                largest = num3;
            }
            return largest;
        }
        static void Main(string[] args)
        {
            //call void function
            PrintName();
            Console.WriteLine("End void function call!");

            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            PrintName(name);
            Console.WriteLine("End void function Uppercase call!");

            PrintNameLowerCase(name);
            Console.WriteLine("End void function Lowercase call!");

            //value function call
            Console.WriteLine("Enter first no: ");
            int n1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no: ");
            int n2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter third no: ");
            int n3 = int.Parse(Console.ReadLine());

            int result = LargestNumber(n1, n2, n3);
            Console.WriteLine($"Largest No:{result}");
        }
    }
}
