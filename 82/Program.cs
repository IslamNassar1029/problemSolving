//namespace _82
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            bool isItX = true;
//            string[,] x = new string[n,n];
//            for (int i = 0; i < n; i++)
//            {
//                string[i] x = Console.ReadLine().Split();
//                if (x[0, 0] != x[i,i]|| x[i, n-1-i])
//                {
//                    isItX=false
//                }



//            }
//            Console.WriteLine(isItX? "YES": "NO");
//        }
//    }
////}
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[,] paper = new char[n, n];

        // Reading the square piece of paper
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                paper[i, j] = line[j];
            }
        }

        // Checking if the paper forms letter "X"
        bool isX = true;
        char diagonalChar = paper[0, 0];

        for (int i = 0; i < n; i++)
        {
            if (paper[i, i] != diagonalChar || paper[i, n - i - 1] != diagonalChar)
            {
                isX = false;
                break;
            }
            for (int j = 0; j < n; j++)
            {
                if ((i != j && j != n - i - 1) && (paper[i, j] == diagonalChar || paper[i, j] != paper[0, 1]))
                {
                    isX = false;
                    break;
                }
            }
            if (!isX) break;
        }

        // Output the result
        Console.WriteLine(isX ? "YES" : "NO");
    }
}

using System;

namespace _82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isItX = true;
            char[,] x = new char[n, n];
             

            // Read input matrix
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = row[j];
                }
            }

            // Check diagonals
            char diagonalLetter = x[0, 0];
            for (int i = 0; i < n; i++)
            {
                if (x[i, i] != diagonalLetter || x[i, n - 1 - i] != diagonalLetter)
                {
                    isItX = false;
                    break;
                }
            }

            // Check other squares
            if (isItX)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j && i != n - 1 - j &&(x[i, j] != x[0, 1] || x[i, j] == diagonalLetter))
                        {
                            isItX = false;
                            break;
                        }
                    }
                    if (!isItX) break;
                }
            }

            Console.WriteLine(isItX ? "YES" : "NO");
        }
    }
}

using System;

class Diaa
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        char[,] c = new char[t, t];
        bool f = false;
        char first, sec;

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            for (int j = 0; j < t; j++)
            {
                c[i, j] = s[j];
                first = c[0, 0];
                sec = c[0, 1];
                if (i == j)
                {
                    if (first != c[i, j])
                    {
                        f = true;
                    }
                }
                else if (i == t - 1 - j)
                {
                    if (first != c[i, j])
                    {
                        f = true;
                    }

                }
                else
                {
                    if (sec != c[i, j] || first == c[i, j])
                    {
                        f = true;
                    }
                }

            }
            if (f)
                break;
        }
        if (f)
            Console.WriteLine("NO");
        else
            Console.WriteLine("YES");
    }
}



