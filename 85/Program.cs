// See https://aka.ms/new-console-template for more information
using System;

string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int a = int.Parse(input[2]);

// Calculating the number of flagstones needed
long flagstonesNeeded = ((long)Math.Ceiling((double)n / a)) * ((long)Math.Ceiling((double)m / a));

// Outputting the result
Console.WriteLine(flagstonesNeeded);
