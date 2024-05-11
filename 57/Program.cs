//namespace _57
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] number = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
//            for (int i = 0; i < n; i++)
//            {
//                if (i==0 || i==n-1)
//                {
//                    Console.WriteLine($"{number[i] - number[i + 1]} {number[i] - number[n - 1]}");
//                }else if (i == n - 1)
//                {
//                    Console.WriteLine($"{number[i] - number[i - 1]} {number[i] - number[0]}");
//                }
//                else
//                {
//                    int min=Math.Min(number[i] - number[i - 1], number[i] - number[i + 1] );
//                    int max =Math.Max(number[i] - number[0], number[i] - number[i - 1]);
//                }

//            }
//        }
//    }
//}
using System;

namespace LinelandMail
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cities = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
            {
                int minDistance, maxDistance;
                if (i == 0)
                {
                    minDistance = Math.Abs(cities[i] - cities[i + 1]);
                    maxDistance = Math.Abs(cities[i] - cities[n - 1]);
                }
                else if (i == n - 1)
                {
                    minDistance = Math.Abs(cities[i] - cities[i - 1]);
                    maxDistance = Math.Abs(cities[i] - cities[0]);
                }
                else
                {
                    minDistance = Math.Min(Math.Abs(cities[i] - cities[i - 1]), Math.Abs(cities[i] - cities[i + 1]));
                    maxDistance = Math.Max(Math.Abs(cities[i] - cities[0]), Math.Abs(cities[i] - cities[n - 1]));
                }

                Console.WriteLine($"{minDistance} {maxDistance}");
            }
        }
    }
}
