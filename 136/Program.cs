// See https://aka.ms/new-console-template for more information
string input = Console.ReadLine();
int[] positions = input.Split(' ').Select(int.Parse).ToArray();

Array.Sort(positions);

int totalDistance = Math.Abs(positions[0] - positions[2]);

Console.WriteLine(totalDistance);
