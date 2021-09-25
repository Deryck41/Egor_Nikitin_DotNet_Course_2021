using System;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Max());
            // This gets the data, then translates to an array
            // Then translates to an array of int and finds the max number

            Console.ReadKey();
        }
    }
}
