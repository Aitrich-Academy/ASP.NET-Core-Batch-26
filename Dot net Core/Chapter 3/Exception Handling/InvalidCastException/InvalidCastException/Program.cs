internal class Program
{
    private static void Main(string[] args)
    {
        object obj = "Hello";
        int num = (int)obj; // Cannot cast string to int
        Console.WriteLine(num);
    }
}