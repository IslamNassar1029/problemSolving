namespace _128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lengthOfString = Convert.ToInt32(Console.ReadLine());
            var stringofChar = Console.ReadLine();
            int noOf0=0, noOf1=0;   
            for (int i = 0; i < lengthOfString; i++)
            {
                if (stringofChar[i]=='1')
                {
                    noOf1++;
                }
                else
                {
                    noOf0++;
                }
            }
            Console.WriteLine(Math.Abs( noOf0-noOf1));

        }
    }
}
