using System;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int firstDigit = input % 10;
            int secondDigit = input / 100;
            int thirdDigit = input / 10 % 10;
            if (firstDigit>=secondDigit && firstDigit >= thirdDigit)
            {
                Console.WriteLine(firstDigit);
            }
            else if (secondDigit > firstDigit && secondDigit >= thirdDigit)
            {
                Console.WriteLine(secondDigit);
            }
            else
            {
                Console.WriteLine(thirdDigit);
            }

            Console.ReadKey();
        }
    }
}
