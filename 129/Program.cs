using System;

namespace _129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            if (firstWord is null)
            {
                return;
            }
            char[] charArray = firstWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedFirstWord = new string(charArray);

            Console.WriteLine(reversedFirstWord == secondWord ? "YES" : "NO");
        }
    }
}
