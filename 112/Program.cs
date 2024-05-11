//namespace _112
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = Convert.ToInt32(Console.ReadLine());
//            if (num==1 || num % 2 == 0)
//            {
//                Console.WriteLine(1);

//            }
//            else 
//            {
//                Console.WriteLine(2);

//            }
//        }
//    }
using System;

namespace _112
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int sol = 0;
                while (x > 0)
                {
                    if (x % 2 == 1)
                        sol++;
                    x /= 2;
                }
                Console.WriteLine(sol);
            }
        }
    }



