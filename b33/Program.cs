using static b33.Program;

namespace b33
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int f = int.Parse(input[1]);
            List<Day> listOfDays = new List<Day>();
            for (int i = 0; i < n; i++)
            {
                string[] day = Console.ReadLine().Split();
                listOfDays.Add(new Day(int.Parse(day[0]), int.Parse(day[1])));
            }
            listOfDays.Sort() ;
            long result = 0;
            foreach (var day in listOfDays)
            {
                result += Math.Min(day.k, day.l);
                if (f>0&day.x>0)
                {
                    f--;
                    result += day.x;
                }
            }
            Console.WriteLine(result);  
        }

        public class Day: IComparable<Day>
        {
            public int k;//product
            public int l;//customer
            public int x;

            public Day(int _k,int _l) 
            {
                k = _k; l = _l;
                x=Math.Min(k,l-k);
            }

            public int CompareTo(Day? other)
            {
                if (other.x != x) return other.x.CompareTo(x);
                if (other.k != k) return other.k.CompareTo(k);
                return other.l.CompareTo(l);

            }
        }
    }
}









//List<Day> days = new List<Day>();

//for (int i = 0; i < n; i++)
//{
//    input = Console.ReadLine().Split();
//    int k = int.Parse(input[0]);
//    int l = int.Parse(input[1]);

//    days.Add(new Day(k, l));
//}

//days.Sort();

//long ans = 0;

//foreach (Day day in days)
//{
//    ans += Math.Min(day.K, day.L);
//    if (f > 0 && day.X > 0)
//    {
//        f--;
//        ans += day.X;
//    }
//}

//Console.WriteLine(ans);
//    }
//}

//public class Day : IComparable<Day>
//{
//    public int K { get; }
//    public int L { get; }
//    public int X { get; }

//    public Day(int k, int l)
//    {
//        K = k;//products
//        L = l;//customers
//        X = Math.Min(k, l - k);
//    }

//    public int CompareTo(Day other)
//    {
//        if (other.X != X)
//            return other.X.CompareTo(X);
//        if (other.K != K)
//            return other.K.CompareTo(K);
//        return other.L.CompareTo(L);
//    }
//}



