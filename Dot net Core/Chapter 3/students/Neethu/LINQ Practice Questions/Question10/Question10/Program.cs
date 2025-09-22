internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,int> Students = new Dictionary<string,int>
        {
             {"Neethu",80 },
            {"Miya",95 },
            {"Sajithlal",64 },
            {"Jithin",55 },
            {"Hira",34 },
            {"Manii",45 }
        };
        var averagemark = Students.Values.Average();
        var aboveaverage = Students.Where(n => n.Value > averagemark).Select(n => n.Key);
        Console.WriteLine("Above average students are");
        foreach (var student in aboveaverage)
        {
            Console.WriteLine(student);
        }
    }
}