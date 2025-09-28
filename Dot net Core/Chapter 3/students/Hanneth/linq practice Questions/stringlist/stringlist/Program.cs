internal class Program
{
    private static void Main(string[] args)
    {
        List<string> listNames = new List<string> {"Affan Ahmad","Aboothwahir","Fathima Noora","Hanneth C H","Asad PS"};
        var top3LongestNames=listNames.OrderByDescending(n=>n.Length).ToList().Take(3);
        foreach(var name in top3LongestNames)
        {
            Console.WriteLine(name);
        }
    }
}