using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using For Loop");

            for (int i = 1; i <= 20; i++)
            {
                if (i == 17)
                {
                    break;
                }

                if (i % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Using While Loop");

            int j = 1;

            while (j <= 20)
            {
                if (j == 17)
                {
                    break;
                }

                if (j % 3 == 0)
                {
                    j++;
                    continue;
                }

                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
