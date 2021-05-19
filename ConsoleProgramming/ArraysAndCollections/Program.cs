using System;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Array Fixed Size Array
            int[] grades = new int[5];

            //Assign value to Fixed Array
            /* grades[0] = 1;
             grades[1] = 12;
             grades[2] = 13;
             grades[3] = 90;
             grades[4] = 54;

             grades = new int[] {10,20,30,40,50};
 */
            Console.WriteLine("Enter Student Grades: ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter grades: ");
                grades[i] = int.Parse(Console.ReadLine());


            }
            //Print value in Fixed Array
            Console.WriteLine("The Grades you entered are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(grades[i]+" ");
             
            }

            //Declare Variable size array
            int[] grades1;
            int grade = 0, index = 0;


            //Assign values to Variable Array
            grades1 = new int[] { 10, 20, 30, 40, 50,1,2,3,4,5 };


            //Print values in Variable Array

            Console.WriteLine("The Grades you entered are: ");
            for (int i = 0; i < grades1.Length; i++)
            {
                Console.WriteLine(grades1[i] + " ");

            }

            //Declare a List
            List<string> names = new List<string>();
            string name = "";

            //Assing value to List
            names.Add("Myat");
            Console.WriteLine("Enter Names: ");
            while (!name.Equals("-1"))
            {
                name = Console.ReadLine();
                if (!name.Equals("-1"))
                {
                    names.Add(name);
                }
            }
            Console.WriteLine("The Names you entered are(for loop): ");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i] + " ");

            }
            Console.WriteLine("The Names you entered are(foreach loop): ");
            foreach(string item in names)
            {
                Console.WriteLine(item);
            }
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("Myat");
            authors.Add("Htet");
            authors.Add("Kyi");

            foreach (string a in authors)
                Console.WriteLine(a);

            authors.Remove("Myat");
            foreach (string a in authors)
                Console.WriteLine("after removing  'Myat': " + a);

            authors.RemoveAt(3);
            foreach (string a in authors)
                Console.WriteLine("after removing RemoveAt(3): " + a);

            //removes a list of items from the starting index to the number of items. 
            authors.RemoveRange(3, 2);
            foreach (string a in authors)
                Console.WriteLine("after removing  RemoveRange: " + a);

            // Remove all items  
            authors.Clear();
           
                Console.WriteLine("Clear(): ");
        }
    }
}
