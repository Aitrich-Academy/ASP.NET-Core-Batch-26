internal class Program
{
    private static void Main(string[] args)
    {
        List <int> scores = new List<int> { 54,89,23,75,56,48,99};
        var maxm=scores.Max();
        var minm=scores.Min();
        var average=scores.Average();
        Console.WriteLine($"Maximum scored:{maxm}\nMinimum scored:{minm}\n Score average:{average}");
    }
}