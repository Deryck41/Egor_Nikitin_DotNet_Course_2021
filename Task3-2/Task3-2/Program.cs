using System;

namespace Task3_2
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Input size of array: ");
            if (!int.TryParse(Console.ReadLine(), out int size))
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }

            int[] numArray = new int[size];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out numArray[i]))
                {
                    Console.WriteLine("Invalid input!");
                    return 0;
                }
            }

            int sum = 0;
            int count = 0;
            foreach (int num in numArray)
            {
                if (num > 0)
                {
                    count++;
                    sum += num;
                }
            }

            Console.WriteLine("average: " + sum / count);
            Console.ReadKey();
            return 0;
        }
    }
}
