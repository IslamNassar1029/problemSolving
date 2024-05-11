namespace _81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new string[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
