internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "John", "Jane", "Doe" };
        var nameLengths = names.Select(n => n.Length);
        foreach (var nameLength in nameLengths)
        {
            Console.WriteLine(nameLength);
        }
    }
}