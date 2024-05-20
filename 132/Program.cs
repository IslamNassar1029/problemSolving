namespace _132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////var noOfPlayers=Console.ReadLine().Split(" ").Select(p=>Convert.ToInt32(p)).ToArray(); 
            //var noOfPlayers = Console.ReadLine().Split(" ");
            //var left =Convert.ToInt32( noOfPlayers[0]) ;
            //var right =Convert.ToInt32( noOfPlayers[1]) ;
            //var both =Convert.ToInt32( noOfPlayers[2]);

            //if (both==0&&(left==0||right==0))
            //{
            //    Console.WriteLine(0);
            //}else if (both == 0)
            //{
            //    Console.WriteLine(left>=right?right*2:left*2);
            //}
            //else if (left==right)
            //{
            //    Console.WriteLine((left+both/2)*2);
            //}
            //else
            //{
            //    var min = Math.Min(left, right);
            //    var max = Math.Max(left, right);
            //    if (both >= (max - min))
            //    {
            //        both -= (max - min);
            //        Console.WriteLine((min + both / 2) * 2 + (max - min) * 2);
            //    }
            //    else
            //    {
            //        Console.WriteLine((min + both) * 2);
            //    }
            //}

            string[] input = Console.ReadLine().Split();
            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int a = int.Parse(input[2]);

            // Adjust the values of l and r using the available a
            while (a > 0)
            {
                if (l < r)
                    l++;
                else
                    r++;
                a--;
            }

            // Calculate and print the result
            Console.WriteLine(Math.Min(l, r) * 2);


        }
    }
}
