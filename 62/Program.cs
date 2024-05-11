namespace _62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coins = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            Array.Sort(coins);

            int sum = 0;
            int coinsTaken = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                sum += coins[i];
                coinsTaken++;
                int sumOfBrother = 0;

                for (int j = i-1; j >= 0; j--)
                {
                    sumOfBrother += coins[j];
                }
                    if (sum > sumOfBrother)
                {
                    break;
                }
            }

            Console.WriteLine(coinsTaken);
        }
    }
}

