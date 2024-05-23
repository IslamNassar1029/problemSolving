namespace _135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int rows = int.Parse(input[0]);
            int colums = int.Parse(input[1]);

            bool isItInTHeEnd=false;

            for (int i = 0; i < rows; i++)
            {

                if (i % 2 == 0 &&i!=1)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        Console.Write("#");
                    }
                    isItInTHeEnd = !isItInTHeEnd;
                }
                else
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (isItInTHeEnd == true && j == colums-1)
                        {
                            Console.Write("#");
                        }
                        else if (isItInTHeEnd == false && j == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
