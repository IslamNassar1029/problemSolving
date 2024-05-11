using System;

namespace _109
{
    internal class Program
    {
        static int[] TestNumber(char[,] inputs, int i, int j)
        {
            int[] count = new int[2];
            if (inputs[i, j] == '#')
            {
                count[0] = 1; 
            }
            else
            {
                count[1] = 1; 
            }
            return count;
        }

        static bool Test(char[,] inputs, int i, int j)
        {
            if (i <= 0 || j <= 0)
                return false;

            int blackCount = 0, whiteCount = 0; 

            for (int x = i - 1; x <= i; x++)
            {
                for (int y = j - 1; y <= j; y++)
                {
                    int[] cellCounts = TestNumber(inputs, x, y);
                    blackCount += cellCounts[0];
                    whiteCount += cellCounts[1];
                }
            }

            return blackCount == 3 || whiteCount == 3 || blackCount == 4 || whiteCount == 4;
        }

        static void Main(string[] args)
        {
            bool yesOrNo = false;
            char[,] inputs = new char[4, 4];
            for (int i = 0; i < 4; i++)
            {
                string inputRow = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    inputs[i, j] = inputRow[j];
                    if (i > 0 && j > 0 && !yesOrNo)
                    {
                        yesOrNo = Test(inputs, i, j);
                        if (yesOrNo)
                            break;
                    }
                }
            }

            Console.WriteLine(yesOrNo ? "YES" : "NO");
        }
    }
}
