namespace _126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfForces = int.Parse(Console.ReadLine());
            int[] SumofForces = {0,0,0};    
            for (int i = 0; i < noOfForces; i++)
            {
                string[] forces = Console.ReadLine().Split(' ');
                SumofForces[0] += int.Parse(forces[0]);
                SumofForces[1] += int.Parse(forces[1]);
                SumofForces[2] += int.Parse(forces[2]);
            }
            var isItInEquilibrium = SumofForces.FirstOrDefault(x => x != 0);
            Console.WriteLine(isItInEquilibrium == 0 ? "YES" : "NO");
        }
    }
}
