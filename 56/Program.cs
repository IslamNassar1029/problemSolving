namespace _56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] result= new int[n];
            for (int i = 0; i < number.Length; i++)
            {
                result[number[i]-1] = i+1;
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
