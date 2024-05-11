using System;

class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        if (a.Equals(b))
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(Math.Max(a.Length, b.Length));
        }
    }
}
