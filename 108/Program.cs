string input = Console.ReadLine();
int n=int.Parse(input.Split(" ")[0]);
int k=int.Parse(input.Split(" ")[1]);
int sum = 0;

for(int i=0; i<n; i++)
{
    string input1 = Console.ReadLine();
    sum += (int.Parse(input1.Split(" ")[1])- int.Parse(input1.Split(" ")[0])+1);
}


    Console.WriteLine((k-(sum % k))%k);
 

