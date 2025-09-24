internal class Program
{
    private static void Main(string[] args)
    {
        string input = "abc";
        int number = Convert.ToInt32(input); // Cannot convert "abc" to int
        Console.WriteLine(number);
    }
}