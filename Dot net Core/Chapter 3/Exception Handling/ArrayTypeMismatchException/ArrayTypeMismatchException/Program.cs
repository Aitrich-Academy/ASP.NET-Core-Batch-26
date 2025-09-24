internal class Program
{
    private static void Main(string[] args)
    {
        object[] items = new string[3];
        items[0] = "Hello";
        items[1] = 100; // Wrong type: int in string array
        Console.WriteLine(items[1]);
    }
}