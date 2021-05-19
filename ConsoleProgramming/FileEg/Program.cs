using System;
using System.IO;
namespace FileEg
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Car.model = "Toyota";
            Console.WriteLine("Enter model:FIRST TIME ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            Car.model = model;
            Car.setSalary(salary);

            Console.WriteLine("Enter model: SECOND TIME");
             model = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
             salary = double.Parse(Console.ReadLine());

            Box box1 = new Box();
            Box box2 = new Box();

            box1.length = 12;
            box1.width = 3;
            box1.getParam();

            box2.length = 10;
            box2.width = 3;
            box2.getParam();




            Console.WriteLine($"Model: {model} , Salary: {salary}");
            Console.WriteLine("for box1:");
            Console.WriteLine($"Length: {box1.length} , width: {box1.width}, param: {box1.getParam()}");
            Console.WriteLine("for box2:");
            Console.WriteLine($"Length: {box2.length} , width: {box2.width}, param: {box2.getParam()}");

        }
    }
    static class Car
    {
        public static string model { get; set; }

        private  static double _salary;

        public static double getSalary()
        {
            return _salary;
        }

        public static void setSalary(double salary)
        {
            _salary = salary;
        }

    }
    class Box
    {
        public int length { get; set; }
        public int width { get; set; }

        public double getParam()
        {
            double param = length*width;
            return param;
        }

       
    }
}
