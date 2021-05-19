using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter Length for Box1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth for Box1: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height for Box1: ");
            double n3 = double.Parse(Console.ReadLine());

            //Create obj of Class Type Box
            Box box = new Box();
            Box box2 = new Box();

            box.Length = n1;
            box.Breadth = n2;
            box.Height = n3;
            double volume = box.getVolume();
            double area = box.getArea();

            Console.WriteLine("Enter Length for Box2: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth for Box2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height for Box2: ");
            n3 = double.Parse(Console.ReadLine());

            box2.Length = n1;
            box2.Breadth = n2;
            box2.Height = n3;

            Console.WriteLine($"box dimesions  for Box1 are: {box.Length},{box.Breadth},{box.Height}");
            Console.WriteLine($"box Volume  for Box1 are: {volume} , Area:{area} ");

            Console.WriteLine($"box dimesions  for Box2 are: {box2.Length},{box2.Breadth},{box2.Height}");
            Console.WriteLine($"box Volume  for Box2 are: {box2.getVolume()} , Area:{box2.getArea()} ");

            Console.WriteLine();
            Console.WriteLine("Test for Person");
            Person p = new Person();
            Console.WriteLine("Enter first Name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last Name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            p.firstName = fName;
            p.lastName = lName;
            p.setSalary(salary);
            Console.WriteLine("first Name: "+ p.firstName+ " last Name: " + p.lastName + " Salary: " + p.getSalary() );
            Console.WriteLine($"full Name: {p.getFullName()}");

        }
    }
   

}
