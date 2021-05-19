using System;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Decalartions and Types
            string name;
            String bigString;
            int age32;
            int age16;
            long age64;
            double salary;
            char gender;
            bool working;

            //Prompt users for Input
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter something: ");
            bigString = Console.ReadLine();

            Console.Write("Enter your age 16: ");
            age16 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your age 32: ");
            age32 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your age 64: ");
            age64 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your salary: ");
            salary =Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender: ");
            gender= Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working (t/f): ");
            working =Convert.ToBoolean(Console.ReadLine()) ;

            //Print to screen
            Console.Write("Name : "+name+" Something: "+bigString);
            Console.Write(" age : age32 {0} ,age16 {1}, age64 {2} ", age32,age16,age64);
            Console.Write($"Salary : {salary}");
            Console.Write(" gender : " + gender);
            Console.WriteLine(" Your are employed : " + working);

            //more than one args in one line
            Console.WriteLine(" age : {0} ,name: {1} ,salary:{2} ", age32, name,salary);

            //print all in one line
            Console.WriteLine("Name: " + name + " age: {0} ",age32 + $" Salary : {salary}"+ " gender : " + gender+ " Your are employed : " + working);
        }
    }
}
