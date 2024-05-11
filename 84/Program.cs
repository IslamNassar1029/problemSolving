namespace _84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long result = CalculateFunction(n);
            Console.WriteLine(result);
        }

        static long CalculateFunction(long n)
        {
            if (n % 2 == 0)
                return n / 2;
            else
                return -(n / 2 + 1);
        }
    }
}
