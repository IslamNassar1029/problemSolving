namespace _28
{
   

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            int rotations = CalculateRotations(input);
            Console.WriteLine(rotations);
        }

        static int CalculateRotations(string input)
        {
            int totalRotations = 0;
            char currentLetter = 'a';

            foreach (char c in input)
            {
                int targetIndex = c - 'a'; // Calculate the target index of the character
                int clockwiseRotations = (targetIndex - (currentLetter - 'a') + 26) % 26; // Calculate clockwise rotations
                int counterclockwiseRotations = (26 - clockwiseRotations) % 26; // Calculate counterclockwise rotations

                totalRotations += Math.Min(clockwiseRotations, counterclockwiseRotations); // Choose the minimum rotations
                currentLetter = c; // Update current letter
            }

            return totalRotations;
        }
    }
}
