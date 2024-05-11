using System.Drawing;

namespace _80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < m; j++)
                {
                    if ("CMY".Contains(input[j]))
                    {
                        Console.WriteLine("#Color");
                        return;
                    }
                }
            }
            Console.WriteLine("#Black&White");
        }
    }
}
