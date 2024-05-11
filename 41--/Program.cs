namespace _41__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shoot = Console.ReadLine().Split();
            int noOfPeopleInLine = int.Parse(shoot[0]);
            Double noOfIceCream = double.Parse(shoot[1]);
            int distressKids = 0;

            for (int i = 0; i < noOfPeopleInLine; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                if (line[0]=="+")
                {
                    noOfIceCream += int.Parse(line[1]);
                }
                if (line[0] == "-")
                {
                    if (noOfIceCream >= int.Parse(line[1]))
                    {
                        noOfIceCream -= int.Parse(line[1]);

                    }
                    else
                    {
                        distressKids++;
                    }
                }
            }
            Console.WriteLine($"{noOfIceCream} {distressKids}");
        }
    }
}
