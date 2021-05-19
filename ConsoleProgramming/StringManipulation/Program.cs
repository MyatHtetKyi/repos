using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //String.IsNullOrWhiteSpace()
            string[] values = { null, String.Empty, "ABCDE",
                          new String(' ', 20), "  \t   "};
            foreach (string value in values)
                Console.WriteLine(String.IsNullOrWhiteSpace(value));

            //Declar string variable
            string fullName = "Hi, my name is Myat Htet Kyi";
            string firstName = "Myat Htet";
            string lastName = "Kyi Kyi";

            //Print to screen
            Console.WriteLine("fullName! " + fullName);

            //Concatentation
            Console.WriteLine("My fullName is {0} {1}",firstName,lastName);
            Console.WriteLine("My fullName is : " + firstName+" "+lastName);
            Console.WriteLine($"My fullName is : {fullName} {lastName}");



            //Count length of string
            int length = firstName.Length;
            Console.WriteLine($"Length of string: {length}");

            int length1 = fullName.Length;
            Console.WriteLine($"Length of string: {length1}");

            //Replace parts of string
            string newName = firstName.Replace('M','K');
            Console.WriteLine($"New Name: {newName}");

            string newName1 = lastName.Replace('t', 'L');
            Console.WriteLine($"New Name: {newName1}");

            //compare string
            //if (firstName.Equals(lastName))
            object t = new String("Myat Htet");
            if (firstName==lastName)
            {
                Console.WriteLine("Your first and last name are same.");
            }
            else
            {
                Console.WriteLine("Your first and last name are different.");
            }
            string fName = "Myat";
            string lName = "myat";
            int r = string.Compare(fName, lName);
            Console.WriteLine("result - :" + r);
            int result = string.Compare(firstName, lastName);
          
            if (result == 0)
            {
                Console.WriteLine("Your first and last name are same.");
            }
            else
            {
                Console.WriteLine("Your first and last name are different.");
            }

        
            //convert to string
            result = 1234789;
            string bigNumber = result.ToString();
            Console.WriteLine($"bank balance is : {bigNumber}");
            int total = result + 1;
            Console.WriteLine($"total: {total}");

            

        }
    }
}
