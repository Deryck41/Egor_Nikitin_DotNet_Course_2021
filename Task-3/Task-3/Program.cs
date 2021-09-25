using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputData;
            bool success = int.TryParse(Console.ReadLine(), out inputData);

            if (success)
                Console.WriteLine("input data: " + inputData);
            else
                Console.WriteLine("Нou need to enter a number!");
            Console.ReadKey();

        }
    }
}
