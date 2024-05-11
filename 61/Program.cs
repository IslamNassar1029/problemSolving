//namespace _61
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            char[] charcters = Console.ReadLine().ToCharArray();
//            var distinctChar= charcters.Distinct().ToArray();
//            if (distinctChar.Length==26)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        Console.WriteLine(IsPangram(s) ? "YES" : "NO");
    }

    static bool IsPangram(string s)
    {
        HashSet<char> alphabet = new HashSet<char>();

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                alphabet.Add(char.ToLower(c));
            }
        }

        return alphabet.Count == 26;
    }
}
