//namespace __76
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            string[] inputa = Console.ReadLine().Split();
//            string[] inputb = Console.ReadLine().Split();
//            long a = long.Parse(inputa[0]);
//            long b = long.Parse(inputb[0]);
//            HashSet<char> levels = new HashSet<char>();

//            foreach (char c in inputa)
//            {

//                    levels.Add(char.ToLower(c));
                
//            }
//            if (levels.Count==n)
//            {
//                Console.WriteLine("I become the guy.");
//            }
//            else
//            {
//                Console.WriteLine("Oh, my keyboard");
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;

namespace _76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputa = Console.ReadLine().Split();
            string[] inputb = Console.ReadLine().Split();
            HashSet<int> levels = new HashSet<int>();

            for (int i = 1; i < inputa.Length; i++)
            {
                levels.Add(int.Parse(inputa[i]));
            }

            for (int i = 1; i < inputb.Length; i++)
            {
                levels.Add(int.Parse(inputb[i]));
            }

            if (levels.Count == n)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
