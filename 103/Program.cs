using System.Threading.Tasks.Dataflow;

namespace _103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] r = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            
            for (int i = 1; i < r.Length-1; i++)
            {
                if (r[i] > r[i-1]+1&& r[i] > r[i + 1] + 1)
                {
                    r[i] --;
                    k--;
                    if (k==0)
                    {
                        break;
                    }
                }
            }

            
           Console.Write(String.Join(" ",r));
        }
    }
}
