internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a String!!!");
        string input = Console.ReadLine();
        int len = input.Length;
        char[] chars = input.ToCharArray();

        int i = 0;
        string rev = string.Empty;
        for (i = len - 1; i >= 0; i--)
        {
            rev += chars[i];
        }
        if (rev == input)
        {
            Console.WriteLine("String entered is palindrome \n Entered string is{0}\nReversed string is {1}", input, rev);
        }
        else
        {
            Console.WriteLine("String entered is not palindrome \n Entered string is{0}\nReversed string is {1}", input, rev);
        }
    }
}