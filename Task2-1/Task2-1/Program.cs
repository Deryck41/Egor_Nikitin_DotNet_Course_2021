using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input year: ");

            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("This year is leap");
                }

                else
                {
                    Console.WriteLine("This year is not leap");
                }
            }

            else
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
