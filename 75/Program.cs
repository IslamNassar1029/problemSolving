using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long k = long.Parse(input[1]);

        long oddCount = (n + 1) / 2;
        long evenCount = n / 2;

        if (k <= oddCount)
        {
            Console.WriteLine(2 * (k )-  1);
        }
        else
        {
            Console.WriteLine(2 * (k - oddCount));
        }
    }
}