internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence!!!1");
        string input=Console.ReadLine();
        int len=input.Length;
        char[] chars = input.ToCharArray();
        int vowels = 0;
        int consonants = 0;
        for (int i = 0; i < len; i++)
        {
            if (chars[i] == 'a' ||chars[i]== 'e' ||chars[i]== 'i' ||chars[i]== 'o' ||chars[i]== 'u')
            {
                vowels++;
            }
            else if (chars[i] !=' ')
             {
                consonants++;
            }
        }
        Console.WriteLine("Number of Vowels in the given sentence is {0}\nNumber of Consonants in the given sentence is{1}",vowels,consonants);
    }
}