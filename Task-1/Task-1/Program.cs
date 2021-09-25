using System;


class Program
{
    static void Main(string[] args)
    {
        int firstValue = 12;
        int secondValue = -234;

        Console.WriteLine($"before replacing:\nfirstValue: {firstValue}\tsecondValue: {secondValue}\n\n");

        int buffer = firstValue;
        firstValue = secondValue;
        secondValue = buffer;

        Console.WriteLine($"after replacing:\nfirstValue: {firstValue}\tsecondValue: {secondValue}");
        Console.ReadKey();
    }
}
