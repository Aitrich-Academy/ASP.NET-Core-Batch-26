internal class Program
{
    private static void Main(string[] args)
    {
        List <string> names= new List<string> { "John","Megha","Robert","Jayanthan","Sreelakshmi","Rajalakshmipriya","Allen Joseph"};
        var result = names.OrderByDescending(n => n.Length).Take(3);
        Console.WriteLine("Selection by method");
        foreach(var name in result)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\n\nSelection by query syntax");
        var top3names = from name in names orderby name.Length descending select name.Take(3);
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}