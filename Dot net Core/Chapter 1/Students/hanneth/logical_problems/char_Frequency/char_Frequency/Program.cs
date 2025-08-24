internal class Program
{
    private static void Main(string[] args)
    {
        string inputString = "hello world";
        Dictionary<char, int> charFrequencies = new Dictionary<char, int>();

        // Iterate through each character in the string
        foreach (char c in inputString)
        {
            // If the character is already in the dictionary, increment its count
            if (charFrequencies.ContainsKey(c))
            {
                charFrequencies[c]++;
            }
            // If the character is not in the dictionary, add it with a count of 1
            else
            {
                charFrequencies[c] = 1;
            }
        }

        // Print the frequencies
        Console.WriteLine("Character Frequencies:");
        foreach (var entry in charFrequencies)
        {
            Console.WriteLine($"Character '{entry.Key}': {entry.Value} times");
        }
}  }