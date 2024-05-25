using System;

namespace _137
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = Convert.ToInt32(Console.ReadLine());
            int steps = 0;

            while (distance > 0)
            {
                if (distance >= 5)
                {
                    getSteps(ref distance, 5, ref steps);
                }
                else if (distance >= 4)
                {
                    getSteps(ref distance, 4, ref steps);
                }
                else if (distance >= 3)
                {
                    getSteps(ref distance, 3, ref steps);
                }
                else if (distance >= 2)
                {
                    getSteps(ref distance, 2, ref steps);
                }
                else if (distance >= 1)
                {
                    getSteps(ref distance, 1, ref steps);
                }
            }

            Console.WriteLine(steps);
        }

        static void getSteps(ref int distance, int stepLength, ref int steps)
        {
            steps += distance / stepLength;
            distance %= stepLength;
        }
    }
}
