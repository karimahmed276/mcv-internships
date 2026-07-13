using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] ages = new int[5];

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Student Name: ");
                names[i] = Console.ReadLine();

                Console.Write("Enter Student Age: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                max = Math.Max(max, ages[i]);
                min = Math.Min(min, ages[i]);

                Console.WriteLine();
            }

            Console.WriteLine("Students Between 18 and 22");

            for (int i = 0; i < 5; i++)
            {
                if (ages[i] >= 18 && ages[i] <= 22)
                {
                    Console.WriteLine(names[i] + " - " + ages[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Oldest Age = " + max);
            Console.WriteLine("Youngest Age = " + min);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
