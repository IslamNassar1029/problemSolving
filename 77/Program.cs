namespace _77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());


            int[] before= new int[n];
            int[] after= new int[n];

            bool rated=false;
            bool unrated = false;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                before[i] = int.Parse(input[0]);
                after[i] = int.Parse(input[1]);
                if (before[i] != after[i])
                {
                    rated = true;
                    break;
                }
                if (i > 0&&before[i] > before[i-1])
                {
                    unrated = true;  
                }
            }
            if (rated)
                Console.WriteLine( "rated");
            else if(unrated)
                Console.WriteLine("unrated");
            else
                Console.WriteLine("maybe");
        }
    }
}
