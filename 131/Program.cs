//using System.Collections.Generic;

//namespace _131
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var noOfLabTop= Convert.ToInt32(Console.ReadLine());
//            Dictionary<int,int> laptops = new Dictionary<int,int>();
//            for (int i = 0; i < noOfLabTop; i++)
//            {
//                var laptop = Console.ReadLine().Split(" ");
//                int price = Convert.ToInt32(laptop[0]);
//                int quality = Convert.ToInt32(laptop[1]);
//                laptops[price] = quality;
//            }
//            bool AlexIsRight=false;
//            foreach (var labtopfirst in laptops)
//            {
//                foreach (var otherLabtop in laptops)
//                {
//                    if (labtopfirst.Key<otherLabtop.Key&&labtopfirst.Value>otherLabtop.Value)
//                    {
//                        AlexIsRight = true;
//                        break;
//                    }
//                    else if(labtopfirst.Key > otherLabtop.Key && labtopfirst.Value < otherLabtop.Value)
//                    {
//                        AlexIsRight = true;
//                        break;
//                    }
//                }
//                if( AlexIsRight)break;
//            }

//            Console.WriteLine(AlexIsRight? "Happy Alex":"Poor Alex");

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfLaptops = Convert.ToInt32(Console.ReadLine());
            List<(int price, int quality)> laptops = new List<(int, int)>();

            for (int i = 0; i < noOfLaptops; i++)
            {
                var laptop = Console.ReadLine().Split(" ");
                int price = Convert.ToInt32(laptop[0]);
                int quality = Convert.ToInt32(laptop[1]);
                laptops.Add((price, quality));
            }
            laptops.Sort((x, y) => x.price.CompareTo(y.price));

            bool AlexIsRight = false;
            for (int i = 0; i < laptops.Count - 1; i++)
            {
                if (laptops[i].quality > laptops[i + 1].quality)
                {
                    AlexIsRight = true;
                    break;
                }
            }

            Console.WriteLine(AlexIsRight ? "Happy Alex" : "Poor Alex");
        }
    }
}

