namespace _106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scale = Console.ReadLine().Split("|");
            string weightNotUsed = Console.ReadLine();

            if ((scale[0].Length + scale[1].Length + weightNotUsed.Length)%2==0)
            {
                foreach (var item in weightNotUsed)
                {
                    if (scale[0].Length> scale[1].Length)
                    {
                        scale[1] += item;
                    }
                    else
                    {
                        scale[0] += item;
                    }
                }
                Console.WriteLine(scale[0].Length == scale[1].Length ? $"{scale[0]}|{scale[1]}" : "Impossible");

            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
