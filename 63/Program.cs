namespace _63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mapping of characters to their original positions on Mole's keyboard
            Dictionary<char, char> mapping = new Dictionary<char, char>()
        {
            {'q', 'q'}, {'w', 'w'}, {'e', 'e'}, {'r', 'r'}, {'t', 't'}, {'y', 'y'}, {'u', 'u'}, {'i', 'i'}, {'o', 'o'}, {'p', 'p'},
            {'a', 'a'}, {'s', 's'}, {'d', 'd'}, {'f', 'f'}, {'g', 'g'}, {'h', 'h'}, {'j', 'j'}, {'k', 'k'}, {'l', 'l'}, {';', ';'},
            {'z', 'z'}, {'x', 'x'}, {'c', 'c'}, {'v', 'v'}, {'b', 'b'}, {'n', 'n'}, {'m', 'm'}, {',', ','}, {'.', '.'}, {'/', '/'}
        };

            // Read input direction and sequence of characters typed by Mole
            char direction = Console.ReadLine()[0];
            string sequence = Console.ReadLine();

            // Adjust the mapping based on the direction
            if (direction == 'L')
            {
                mapping = ShiftMappingLeft(mapping);
            }
            else if (direction == 'R')
            {
                mapping = ShiftMappingRight(mapping);
            }

            // Convert the sequence of characters to the original message
            string originalMessage = ConvertToOriginalMessage(sequence, mapping);

            // Print the original message
            Console.WriteLine(originalMessage);
        }

        // Function to adjust the mapping one position to the left
        static Dictionary<char, char> ShiftMappingLeft(Dictionary<char, char> mapping)
        {
            Dictionary<char, char> shiftedMapping = new Dictionary<char, char>();
            foreach (var pair in mapping)
            {
                char originalChar = pair.Key;
                char shiftedChar = (char)(((originalChar - 'a' + 25) % 26) + 'a');
                shiftedMapping.Add(shiftedChar, pair.Value);
            }
            return shiftedMapping;
        }

        // Function to adjust the mapping one position to the right
        static Dictionary<char, char> ShiftMappingRight(Dictionary<char, char> mapping)
        {
            Dictionary<char, char> shiftedMapping = new Dictionary<char, char>();
            foreach (var pair in mapping)
            {
                char originalChar = pair.Key;
                char shiftedChar = (char)(((originalChar - 'a' + 1) % 26) + 'a');
                shiftedMapping.Add(shiftedChar, pair.Value);
            }
            return shiftedMapping;
        }

        // Function to convert the sequence of characters to the original message
        static string ConvertToOriginalMessage(string sequence, Dictionary<char, char> mapping)
        {
            char[] originalMessageArray = new char[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                char typedChar = sequence[i];
                originalMessageArray[i] = mapping[typedChar];
            }
            return new string(originalMessageArray);
        }
    }
}

