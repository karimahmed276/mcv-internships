Cusing System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            int age = ReadInteger("Enter Age: ");
            int grade = ReadInteger("Enter Grade: ");

            string result = CalculateGrade(grade);

            PrintStudent(name, age, department, result);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static int ReadInteger(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static string CalculateGrade(int grade)
        {
            if (grade >= 90)
                return "Excellent";
            else if (grade >= 80)
                return "Very Good";
            else if (grade >= 70)
                return "Good";
            else if (grade >= 50)
                return "Pass";
            else
                return "Fail";
        }

        static void PrintStudent(string name, int age, string department, string result)
        {
            Console.WriteLine();
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Result: " + result);
        }
    }
}
