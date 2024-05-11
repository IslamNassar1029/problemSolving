using System;

namespace _87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int number1 = Convert.ToInt32( numbers.Split(" ")[0]);
            int number2 = Convert.ToInt32( numbers.Split(" ")[1]);

            if (IsPrimeNumber(number2))
            {
                while (true)
                {
                    number1++;
                    if (IsPrimeNumber(number1))
                    {
                        if (number1==number2)
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("NO");
            }

            


        }

        static public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}

using System;

namespace _87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int number1 = Convert.ToInt32(numbers.Split(" ")[0]);
            int number2 = Convert.ToInt32(numbers.Split(" ")[1]);

            if (IsPrimeNumber(number2))
            {
                while (true)
                {
                    number1++;
                    if (IsPrimeNumber(number1))
                    {
                        if (number1 == number2)
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("NO");
            }




        }

        static public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

using System;

namespace PanoramixsPrediction
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;

            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        static int NextPrime(int num)
        {
            while (true)
            {
                num++;
                if (IsPrime(num))
                    return num;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int nextPrime = NextPrime(n);

            if (nextPrime == m)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

