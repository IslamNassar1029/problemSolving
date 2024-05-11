namespace _104
{
    internal class Program
    {
        static bool Check(int x00, int x01, int x10, int x11, int r1, int r2, int c1, int c2, int d1, int d2)
        {
            return (x00 + x01 == r1 && x10 + x11 == r2 && x00 + x10 == c1 && x01 + x11 == c2 && x00 + x11 == d1 && x01 + x10 == d2);
        }
        static void Main(string[] args)
        {
            int[] r = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] d = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int r1, r2, c1, c2, d1, d2;
            r1 = r[0];
            r2 = r[1];
            c1 = c[0];
            c2 = c[1];
            d1 = d[0];
            d2 = d[1];
            for (int x00 = 1; x00 < 10; x00++)
            {
                for (int x01 = 1; x01 < 10; x01++)
                {
                    if (x00 == x01) continue;
                    for (int x10 = 1; x10 < 10; x10++)
                    {
                        if (x10 == x00 || x10 == x01) continue;
                        for (int x11 = 1; x11 < 10; x11++)
                        {
                            if (x11 == x00 || x11 == x10 || x11 == x01) continue;
                            if (Check(x00, x01, x10, x11, r1, r2, c1, c2, d1, d2))
                            {
                                Console.WriteLine($"{x00} {x01}");
                                Console.WriteLine($"{x10} {x11}");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("-1");
        }
    }
}
