internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Manu","Ashmi","Keerthana","Renu","Jithin","Sreelakshmi","Anna","Amritha"};
        var namesort = names.Where(n => n.StartsWith("A"));
        Console.WriteLine("Names that start with alphabet A");
        foreach(var name in namesort)
        {
            Console.WriteLine(name);
        }
        var firstname=names.First(n=>n.Length>5);
        Console.WriteLine("\n First name in the list of names which has more than 5 characters");
        Console.WriteLine(firstname);
    } 
}