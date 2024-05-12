namespace _127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noOfOperations=Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < noOfOperations; i++)
            {
                var operation = Console.ReadLine();
                if (operation[1] is '+')
                {
                    result++;
                }
                else
                {
                    result--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
