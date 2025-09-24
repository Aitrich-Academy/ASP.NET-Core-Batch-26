internal class Program
{
    private static void Main(string[] args)
    {
        int num = 10;
        int zero = 0;
        int result = num / zero; // This will cause DivideByZeroException
        Console.WriteLine(result);
    }
}