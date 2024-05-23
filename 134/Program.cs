namespace _134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int redSocks = int.Parse(input[0]);
            int blueSocks = int.Parse(input[1]);

            int differentPairs = 0, matchingPairs = 0;

            differentPairs = Math.Min(redSocks, blueSocks);
            redSocks -= differentPairs;
            blueSocks -= differentPairs;

            matchingPairs = redSocks / 2 + blueSocks / 2;

            Console.WriteLine($"{differentPairs} {matchingPairs}");
        }
    }
}

//namespace _134
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] noOfSocks = Console.ReadLine().Split(" ");
//            int redAndLeft = int.Parse(noOfSocks[0]);
//            int blueAndRight = int.Parse(noOfSocks[1]);
//            int differentSocks=0, matchingSocks = 0;
//            while (redAndLeft+blueAndRight >1)
//            {
//                if (redAndLeft>=1&&blueAndRight>=1)
//                {
//                    differentSocks++;   
//                    redAndLeft--;
//                    blueAndRight--;
//                }else if (redAndLeft >= 2)
//                {
//                    matchingSocks++;
//                    redAndLeft=redAndLeft-2;
//                }
//                else
//                {
//                    matchingSocks++;
//                    blueAndRight = blueAndRight - 2;
//                }
//            }

//            Console.WriteLine($"{differentSocks} {matchingSocks}");
//        }
//    }
//}
