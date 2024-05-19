using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            string result = "";

            foreach (var item in word)
            {
                char lowerCaseItem = char.ToLower(item); 
                if ("aoyeui".Contains(lowerCaseItem)) 
                {
                    continue; 
                }
                else
                {
                    result += "." + lowerCaseItem; 
                }
            }
            Console.WriteLine(result);
        }
    }
}
