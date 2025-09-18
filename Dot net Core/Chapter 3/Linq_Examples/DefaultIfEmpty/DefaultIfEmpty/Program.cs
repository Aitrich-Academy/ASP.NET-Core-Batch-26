internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n---- DefaultIfEmpty() ----");
        var defaultIfEmptyList = new List<int> { 1, 2 };
        Console.WriteLine("DefaultIfEmpty (non-empty list):");
        foreach (var item in defaultIfEmptyList.DefaultIfEmpty())
        {
            Console.WriteLine(item);
        }

        var emptyDefaultIfEmptyList = new List<string>();
        Console.WriteLine("DefaultIfEmpty (empty list):");
        foreach (var item in emptyDefaultIfEmptyList.DefaultIfEmpty())
        {
            Console.WriteLine(item); // Output: 0
        }
    }
}