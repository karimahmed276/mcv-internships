using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            int total = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                total += numbers[i];

                max = Math.Max(max, numbers[i]);
                min = Math.Min(min, numbers[i]);
            }

            double average = (double)total / 5;

            Console.WriteLine();
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
