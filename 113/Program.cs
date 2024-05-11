namespace _113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            while (str != null)
            {
                int last1 = -1, cnt1s = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1')
                    {
                        if (last1 == -1)
                            last1 = i;
                        cnt1s += 1;
                    }
                }

                if (cnt1s == 0)
                {
                    Console.WriteLine(0);
                    break;
                }
                last1 = str.Length - last1 - 1;

                if (cnt1s > 1&& last1 % 2 == 1)
                {
                    last1 += 1;
                    last1 = last1 / 2;
                }
                else
                {
                    if (last1 % 2 == 1)
                        last1 += 1; 

                    last1 = last1 / 2;

                    if (cnt1s > 1)
                        last1 += 1;

                }

                Console.WriteLine(last1);

                break;
            }
        }
        }
    }

