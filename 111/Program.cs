using System;

namespace _111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            char[] input = Console.ReadLine().ToCharArray();
            int r = 0;
            int l = 0;
            int start = 0, End = 0;
            for (int i = 0; i < num; i++)
            {
                if (input[i] == 'R')
                {
                    r++;
                }
                else if (input[i] == 'L')
                {
                    l++;
                }
            }
            if (r == 0)
            {
                for (int i = 0; i < num; i++)
                {
                    End = (i > 0 && input[i] == 'L' && input[i - 1] == '.') ? i : End;
                    start = ((i < num - 1 && input[i] == 'L' && input[i + 1] == '.') || (i == num - 1 && input[i] == 'L')) ? i : start;

                }
                Console.WriteLine($"{start + 1} {End+1-1}");

            }
            else if (l == 0)
            {
                for (int i = 0; i < num; i++)
                {
                    start = (i > 0 && input[i] == 'R' && input[i - 1] == '.') ? i : start;
                    End = ((i < num - 1 && input[i] == 'R' && input[i + 1] == '.') || (i == num - 1 && input[i] == 'R')) ? i : End;

                }
                Console.WriteLine($"{start + 1} {End + 1+1}");

            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    start = (i > 0 && input[i] == 'R' && input[i - 1] == '.') ? i : start;
                    End = (i < num - 1 && input[i] == 'R' && input[i + 1] == 'L') ? i : End;
                }
                Console.WriteLine($"{start + 1} {End + 1}");
            }
        }
    }
}
