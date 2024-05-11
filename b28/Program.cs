using System;
using System.Linq;
using System.Numerics;

namespace b28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            long[] arrNum = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] prfx1 = new long[num+1];
            long[] prfx2 = new long[num+1];
            for (int i = 0; i <=num; i++)
            {
                if (i == 0)
                {
                    prfx1[i] = 0;
                    continue;
                }
                prfx1[i] = prfx1[i - 1] + arrNum[i-1];
            }
            Array.Sort(arrNum);
            for (int i = 0; i <= num; i++)
            {
                if (i == 0)
                {
                    prfx2[i] = 0;
                    continue;
                }
                prfx2[i] = prfx2[i - 1] + arrNum[i-1];
            }
            int questions = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < questions; i++)
            {
                BigInteger result = 0;
                string[] inputs = Console.ReadLine().Split();
                int startIndex = int.Parse(inputs[1]) - 1;
                int endIndex = int.Parse(inputs[2]) ;
                if (inputs[0] == "1")
                {
                    result = prfx1[endIndex] - prfx1[startIndex];
                }
                else
                {
                    result = prfx2[endIndex] - prfx2[startIndex];

                }
                Console.WriteLine(result);
            }



        }
    }
}

