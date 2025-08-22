internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence");
        string myString=Console.ReadLine();
        string cleanedSring = myString.ToLower().Replace(" ", "");
        string vowels = "aeiou";
        int Vcount = 0 , ConCount=0;
        for (int i = 0; i < cleanedSring.Length; i++)
        {
            bool isVowel=vowels.Contains(cleanedSring[i]);
            if (isVowel)
            {
                Vcount++;
            }
            else
            {
                ConCount++;
            }
        }
        Console.WriteLine("Number of Vowels: " + Vcount);
        Console.WriteLine("Number of Consonants: "+ConCount);
    }
}