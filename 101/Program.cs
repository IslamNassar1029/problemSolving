namespace _101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, z, x, y;
            string[] inputs = new string[2];
            n = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine().Split();
                x = int.Parse(inputs[0]);
                y = int.Parse(inputs[1]);

                if (x == z || x == 7 - z || y == z || y == 7 - z)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
   
