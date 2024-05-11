namespace b34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            int k = int.Parse(firstLine[2]);
            int t = int.Parse(firstLine[3]);
            SortedSet<Pair> pairs = new SortedSet<Pair>();

            for (int i = 0; i < k; i++)
            {
                string[] wasteCeils = Console.ReadLine().Split(' ');
                pairs.Add(new Pair(int.Parse(wasteCeils[0]), int.Parse(wasteCeils[1])));
            }
            int realCounterOfWasteCeils = 1;
            foreach (Pair pair in pairs)
            {
                pair.order = realCounterOfWasteCeils++;   
            }
            while (t-->0)
            {
                string[] queryCeils = Console.ReadLine().Split(' ');
                int r = int.Parse(queryCeils[0]);
                int c = int.Parse(queryCeils[1]);
                Pair p = pairs.FirstOrDefault(pair => pair.CompareTo(new Pair(r, c)) >= 0);
                if (p == null)
                {
                    int res = (r - 1) * m + c - k;
                    switch (res%3)
                    {
                        case 1:
                            Console.WriteLine("Carrots");
                            break;
                        case 2:
                            Console.WriteLine("Kiwis");
                            break;
                        case 0:
                            Console.WriteLine("Grapes");
                            break;
                    }
                }
                else
                {
                    if (p.C == c && p.R == r)
                    {
                        Console.WriteLine("Waste");
                    }
                    else
                    {
                        int res = (r - 1) * m + c -(p.order - 1); ;
                        switch (res % 3)
                        {
                            case 1:
                                Console.WriteLine("Carrots");
                                break;
                            case 2:
                                Console.WriteLine("Kiwis");
                                break;
                            case 0:
                                Console.WriteLine("Grapes");
                                break;
                        }
                    }
                }


            }
        }
    }
    class Pair:IComparable<Pair>
    {
        public int C;
        public int R;
        public int order;

        public Pair(int r, int c)
        {
            this.C = c;
            this.R = r;
        }

        public int CompareTo(Pair? other)
        {
            if (other.R!=R) 
            {
                return R.CompareTo(other.R);
                
            }
            return C.CompareTo(other.C);
        }
    }
}



