using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string sum = Console.ReadLine();
        string[] numbers = sum.Split('+');
        Array.Sort(numbers);
        string rearrangedSum = string.Join("+", numbers);
        Console.WriteLine(rearrangedSum);
    }
}