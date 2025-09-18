internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n---- Single() ----");
        var singleList = new List<int> { 999 };
        Console.WriteLine("Single: " + singleList.Single());

        var emptySingleList = new List<int>();
        // Console.WriteLine(emptySingleList.Single()); // ❌ InvalidOperationException

        var multipleSingleList = new List<int> { 1, 2 };
        // Console.WriteLine(multipleSingleList.Single()); // ❌ InvalidOperationException

        Console.WriteLine("\n---- SingleOrDefault() ----");
        var singleOrDefaultList = new List<int> { 500 };
        Console.WriteLine("SingleOrDefault: " + singleOrDefaultList.SingleOrDefault());

        var emptySingleOrDefaultList = new List<int>();
        Console.WriteLine("SingleOrDefault (empty): " + emptySingleOrDefaultList.SingleOrDefault());

        var multipleSingleOrDefaultList = new List<int> { 1, 2 };
        // Console.WriteLine(multipleSingleOrDefaultList.SingleOrDefault()); // ❌ InvalidOperationException
    }
}