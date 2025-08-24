internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string input = Console.ReadLine();
        int len = input.Length;
       
        Console.WriteLine("number of digits is" + len);
    }
}