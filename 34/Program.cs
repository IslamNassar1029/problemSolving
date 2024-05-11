using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] wires = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] shoot = Console.ReadLine().Split();
            int x = int.Parse(shoot[0]) - 1;
            int y = int.Parse(shoot[1]);

            if (x > 0)
                wires[x - 1] += y - 1;
            if (x < n - 1)
                wires[x + 1] += wires[x] - y;
            wires[x] = 0;
        }

        foreach (int wire in wires)
        {
            Console.WriteLine(wire);
        }
    }
}
