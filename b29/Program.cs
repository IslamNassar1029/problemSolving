namespace b29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] heights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int minSum = int.MaxValue;
            int minIndex = 0;
            int currentSum = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += heights[i];
            }

            minSum = currentSum;

            for (int i = k; i < n; i++)
            {
                currentSum = currentSum - heights[i - k] + heights[i];
                if (currentSum < minSum)
                {
                    minSum = currentSum;
                    minIndex = i - k + 1;
                }
            }
            Console.WriteLine(minIndex + 1);
        }
    }
}
