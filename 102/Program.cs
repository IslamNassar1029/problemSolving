namespace _102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ");
            long noOfcolumn1 = Convert.ToInt32(inputs[0]);
            long noOfcolumn2 = Convert.ToInt32(inputs[1]);
            long[] column1 = new long[5] {0,0,0,0,0};
            long[] column2 = new long[5] {0,0,0,0,0};

            for (int i = 1; i <= noOfcolumn1; i++)
            {
                column1[i % 5]++;  
            }
            for (int i = 1; i <= noOfcolumn2; i++)
            {
                column2[i % 5]++;
            }
            long sum = column1[0] * column2[0] + column1[1] * column2[4]+ column1[2] * column2[3]+ column1[3] * column2[2]+ column1[4] * column2[1];

            Console.WriteLine(sum);

        }
    }
}
