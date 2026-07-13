using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter Grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Grade: " + grade);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
