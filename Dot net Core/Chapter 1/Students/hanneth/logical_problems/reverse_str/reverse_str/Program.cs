internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, enter a string!");
        string input = Console.ReadLine();
        int len = input.Length;
        char[] chars = input.ToCharArray();
        string reversedString=string.Empty;




        for (int i = len-1; i >= 0; i--)
        {
            reversedString += chars[i];
        }
            Console.WriteLine("Reversed string is\t"+reversedString);
        
    }
}