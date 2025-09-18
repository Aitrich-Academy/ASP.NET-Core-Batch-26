internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n---- ElementAt() ----");
        var elementAtList = new List<int> { 10, 20, 30 };
        Console.WriteLine("ElementAt(1): " + elementAtList.ElementAt(0));

       // Console.WriteLine("ElementAt(5): " + elementAtList.ElementAt(5)); // ❌ ArgumentOutOfRangeException

        Console.WriteLine("\n---- ElementAtOrDefault() ----");
        var elementAtOrDefaultList = new List<int> { 10, 20, 30 };
        Console.WriteLine("ElementAtOrDefault(1): " + elementAtOrDefaultList.ElementAtOrDefault(1));
        Console.WriteLine("ElementAtOrDefault(5): " + elementAtOrDefaultList.ElementAtOrDefault(5));

    }
}