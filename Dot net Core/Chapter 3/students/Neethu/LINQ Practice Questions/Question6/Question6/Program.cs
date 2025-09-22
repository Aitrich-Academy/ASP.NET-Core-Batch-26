internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,int> reportcard= new Dictionary<string,int>
        {
            {"Neethu",80 },
            {"Miya",95 },
            {"Sajithlal",64 },
            {"Jithin",55 },
            {"Hira",34 },
            {"Manii",45 }
        };
        var result = reportcard.Select(n => new { Name = n.Key, Status = n.Value >= 60 ? "Pass" : "Fail" });
        foreach(var item in result)
        {
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"status: {item.Status}");
        }
    }
}