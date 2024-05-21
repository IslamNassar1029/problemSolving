namespace _133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfRooms = Convert.ToInt32(Console.ReadLine());

            int sumOfRooms = 0;

            for (int i = 0; i < noOfRooms; i++)
            {
                string[] roomDiscription = Console.ReadLine().Split();
                int noOfPeople = int.Parse(roomDiscription[0]);
                int roomCapacity = int.Parse(roomDiscription[1]);
                if (roomCapacity-noOfPeople >=2)
                {
                    sumOfRooms++;
                }
            }
            Console.WriteLine(sumOfRooms);
        }
    }
}
