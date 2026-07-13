using System;
using System.IO;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Student.txt";

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            File.WriteAllText(filePath, "Name: " + name + "\nAge: " + age);

            Console.WriteLine();
            Console.WriteLine("Data Saved Successfully.");

            Console.WriteLine();
            Console.WriteLine("Reading Data From File...");
            Console.WriteLine();

            string data = File.ReadAllText(filePath);

            Console.WriteLine(data);

            Console.ReadKey();
        }
    }
}
