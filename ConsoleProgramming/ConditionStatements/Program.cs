using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            int num3 = 0;
            int n1, n2;
            string result;
            //if statements(>,<,==,>=,<=,!=)
            if (2 < 3)
            {
                Console.WriteLine("yes. 2 is less than 3.");
            }
            else{
                Console.WriteLine("no. 2 is not less than 3.");
            }

            Console.WriteLine("dyanmic testing:");
           /*
            Console.WriteLine("Enter num 1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
            {
                Console.WriteLine($"yes. {n1} is less than {n2}.");
            }
            else
            {
                Console.WriteLine($"no. {n1} is not less than {n2}.");
            }

            */
         
          Console.WriteLine("Enter num 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine($"yes. {num1} is less than {num2}.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"yes. {num1} is greater than {num2}.");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($" {num1} is equal {num2}.");
            }
            else
            {
                Console.WriteLine("Invalid parameters");
            }

            //switch statements
            Console.WriteLine("How many eyes do you have:");
            num3 = Convert.ToInt32(Console.ReadLine());
            switch (num3)
            {
                case 1:
                    Console.WriteLine("Value is 1.");
                    break;

                case 2:
                    Console.WriteLine("Value is 2.");
                    Console.WriteLine("Value is 2.");
                    Console.WriteLine("Value is 2.");
                    break;

                default:
                    Console.WriteLine("Invalid Value.");
                    break;
            }

            //ternary statements
            result = (num1 > num2) ? "yes ,num1 is  greater than num2" : "no,num1 is  less than num2";
            Console.WriteLine("Ternary . :"+result);

            //Ternary with more condition
            result = (num1 > num2) ? "yes ,num1 is  greater than num2" : (num1 > num3) ? "num1 is  greater than num3" : "num1 is not greater than num3";
            Console.WriteLine("Ternary with more condition. :" + result);


        }
    }
}
