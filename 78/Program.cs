namespace _78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            int t = int.Parse(input[1]);

            if (n == 1 && t == 10)
            {
                Console.WriteLine("-1");
                return;
            }

            string number="";
            if (t != 10)
            {
                number = t.ToString();
                for (int i = 1; i < n; i++)
                {
                    number += $"{t}";
                }
            }
            else
            {
                number = "1";
                for (int i = 1; i < n; i++)
                {
                    if (i < n - 1)
                    {
                        number += $"1";

                    }
                    else
                    {
                        number += $"0";

                    }

                }
            }
            

            Console.WriteLine(number);
        }
    }
}
