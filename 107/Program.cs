using System.IO;

namespace _107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstMoment = int.MaxValue;

            string directions = Console.ReadLine();

            int[] distances = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);



            for (int i = 0; i < n-1; i++)
            {
                if (directions[i]== 'R' && directions[i+1]=='L')
                {

                    firstMoment = Math.Min(firstMoment, ((distances[i + 1] - distances[i]) / 2));
                }
            }

            Console.WriteLine(firstMoment ==int.MaxValue?-1:firstMoment);

        }
    }
}
