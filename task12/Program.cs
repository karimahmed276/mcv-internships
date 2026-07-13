using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 10 and 20 = " + Add(10, 20));

            Console.WriteLine("Sum of 10, 20 and 30 = " + Add(10, 20, 30));

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
