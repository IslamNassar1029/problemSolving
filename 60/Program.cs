namespace _60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(number);
            int counter=0;
            for (int i = 0; i < n; i++)
            {
                if (i!=0&&i!=n-1)
                {
                    if (number[i] > number[0] && number[i] < number[n-1])
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);   
        }
    }
}
