internal class Program
{
    private static void Main(string[] args)
    {
        double d = 9.8;
        int i = (int)d;  // manually converting double to int
        Console.WriteLine(i);  // Output: 9 (decimal part removed)

    }
}