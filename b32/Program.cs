namespace b32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = a.OrderBy(x => x).ToArray();

            int l = -1, r = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] != b[i])
                {
                    l = i;
                    break;
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] != b[i])
                {
                    r = i;
                    break;
                }
            }

            if (l == -1)
            {
                Console.WriteLine("yes\n1 1");
                return;
            }

            Reverse(a, l, r);

            for (int i = 0; i < n; i++)
            {
                if (a[i] != b[i])
                {
                    Console.WriteLine("no");
                    return;
                }
            }

            Console.WriteLine($"yes\n{l + 1} {r + 1}");
        }
        static void Reverse(int[] a, int l, int r)
        {
            int[] t = new int[a.Length];

            for (int i = l, j = r; i <= r; i++, j--)
            {
                t[i] = a[j];
            }

            for (int i = l; i <= r; i++)
            {
                a[i] = t[i];
            }
        }
    }
}
