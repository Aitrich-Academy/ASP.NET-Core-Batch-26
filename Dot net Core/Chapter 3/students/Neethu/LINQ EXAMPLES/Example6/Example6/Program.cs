internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Alice","Bob","Anae"};
        var result = names.Where(name => name.StartsWith("A"));
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}